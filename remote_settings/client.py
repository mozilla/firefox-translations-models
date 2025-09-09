import os, sys, requests, uuid, json

import hashlib
from kinto_http import Client, BearerTokenAuth, KintoException
from packaging import version

from remote_settings.format import print_error, print_help, print_info
import zstandard as zstd
from pathlib import Path

REMOTE_SETTINGS_BEARER_TOKEN = "REMOTE_SETTINGS_BEARER_TOKEN"
BEARER_TOKEN_HELP_MESSAGE = f"""\
Export the token as an environment variable called {REMOTE_SETTINGS_BEARER_TOKEN}.

You can retrieve a bearer token from the Remote Settings admin dashboards.

  Dev: https://remote-settings-dev.allizom.org/v1/admin
Stage: https://remote-settings.allizom.org/v1/admin
 Prod: https://remote-settings.mozilla.org/v1/admin
Local: http://localhost:8888/v1/admin

On the top right corner, use the 📋 icon to copy the authentication string
"""
COLLECTION = "translations-models-v2"
SERVER_URLS = {
    "dev": "https://remote-settings-dev.allizom.org/v1",
    "stage": "https://remote-settings.allizom.org/v1",
    "prod": "https://remote-settings.mozilla.org/v1",
    "local": "http://localhost:8888/v1",
}


class MockedClient:
    def __init__(self, args):
        self._server = args.server

    def get_records(self):
        return []

    def server_info(self):
        return {
            "url": SERVER_URLS.get(self._server),
            "user": {
                "id": "mocked_user",
            },
        }


class RemoteSettingsClient:
    def __init__(self, args):
        """Initializes the RemoteSettingsClient by authenticating with the server.

        The client may be mocked for testing if the --mock-connection flag was passed.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI
        """
        self._server = args.server

        if args.server == "local":
            # We work with the "main" bucket on the local instance.
            self._bucket = "main"
        else:
            # We work with the "main-workspace" bucket on production instances.
            self._bucket = "main-workspace"

        if args.mock_connection:
            self._client = MockedClient(args)
            self._auth_token = "mocked_token"

            return

        self._auth_token = RemoteSettingsClient._retrieve_remote_settings_bearer_token(
            self._server
        )

        self._client = Client(
            server_url=SERVER_URLS.get(args.server),
            bucket=self._bucket,
            collection=COLLECTION,
            auth=BearerTokenAuth(self._auth_token),
        )
        self._new_records = None

    @classmethod
    def init_for_create(cls, args):
        """Initializes the RemoteSettingsClient for the create subcommand
        This expects the CLI args to have information regarding creating a
        new record, which populates the _new_records data member.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI

        Returns:
            RemoteSettingsClient: A RemoteSettingsClient that can create new records
        """
        this = cls(args)

        if args.path is not None:
            new_record_info = RemoteSettingsClient._create_record_info(
                args.path, args.version, args.architecture, args.platform_filter
            )
            this._new_records = [new_record_info]
        else:
            paths = this._paths_for_lang_pair(args)
            this._new_records = [
                RemoteSettingsClient._create_record_info(
                    path, args.version, args.architecture, args.platform_filter
                )
                for path in paths
            ]

        return this

    @staticmethod
    def _compress_file_with_levels(args, input_path):
        """
        Compresses a given file using Zstandard at both compression levels 1 and 19,
        compares their resulting sizes, and retains only the smaller of the two.

        This function is used to determine the most size-efficient compression level
        for our model files. Although level 19 is expected to produce
        better compression (smaller files) in most general-purpose scenarios, we have
        observed that our model files, due to their specific structure and content,
        sometimes yield smaller compressed results with level 1.

        Therefore, we compress each file twice, once with level 1 and once with level 19, then keep the smaller of the two.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI
            input_path (str): The full path to the file to compress.
        """

        levels = [1, 19]
        compressed_paths = []

        try:
            for level in levels:
                cctx = zstd.ZstdCompressor(level)
                output_path = f"{input_path}.{level}.zst"
                with open(input_path, "rb") as ifh, open(output_path, "wb") as ofh:
                    print_info(f"Compressing {input_path} with level {level}")
                    cctx.copy_stream(ifh, ofh)
                compressed_paths.append(output_path)

            path_level_1 = compressed_paths[0]
            path_level_19 = compressed_paths[1]

            size_level_1 = os.path.getsize(path_level_1)
            size_level_19 = os.path.getsize(path_level_19)

            if size_level_1 > size_level_19:
                largest_path = path_level_1
                largest_size = size_level_1
                smallest_path = path_level_19
                smallest_size = size_level_19
            else:
                largest_path = path_level_19
                largest_size = size_level_19
                smallest_path = path_level_1
                smallest_size = size_level_1

            final_output_path = f"{input_path}.zst"
            os.rename(smallest_path, final_output_path)
            print_info(
                f"Selected smallest file: {os.path.basename(smallest_path)} ({smallest_size} bytes)",
            )

            os.remove(largest_path)
            print_info(
                f"Removed larger file: {os.path.basename(largest_path)} ({largest_size} bytes)",
            )

            return final_output_path

        except Exception as e:
            print_error(e)

    def _compute_sha256(file_path):
        """Computes the SHA-256 hash of a given file."""
        sha256 = hashlib.sha256()
        with open(file_path, "rb") as f:
            for chunk in iter(lambda: f.read(8192), b""):
                sha256.update(chunk)
        return sha256.hexdigest()

    def get_expected_model_file_hash(file_path):
        """Retrieves the expected hash value for a model file from its associated metadata.json."""

        file_path = Path(file_path)
        metadata_path = file_path.parent / "metadata.json"

        name = os.path.basename(file_path)

        if not name.startswith("model"):
            raise ValueError(f"Expected a model file but received {name}")

        if not metadata_path.exists():
            print_error(f"metadata.json not found for {file_path}")
            exit(1)

        with open(metadata_path) as f:
            metadata = json.load(f)

        expected_hash = metadata.get("hash")
        if expected_hash:
            return expected_hash

    @classmethod
    def init_for_list(cls, args):
        """Initializes the RemoteSettingsClient for the list subcommand.

        Args:
            args (argparse.Namespace): The CLI arguments containing the server info

        Returns:
            RemoteSettingsClient: A client ready to list records
        """
        this = cls(args)
        return this

    @staticmethod
    def _paths_for_lang_pair(args):
        """Retrieves all of the file paths for the given language pair and version in args.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI

        Returns:
            List[str]: A list of file paths in the specified language-pair directory.
        """
        base_dir = RemoteSettingsClient.base_dir(args)
        architecture_dir = os.path.join(base_dir, args.architecture)

        if not os.path.isdir(architecture_dir):
            print_error(
                f"Invalid architecture: '{args.architecture}'. No such architecture in {base_dir} directory"
            )
            exit(1)

        full_path = os.path.join(architecture_dir, args.lang_pair)

        if not os.path.exists(full_path):
            print_error(f"Path does not exist: {full_path}")
            exit(1)

        return [
            os.path.join(full_path, f)
            for f in os.listdir(full_path)
            if f.endswith(".bin") or f.endswith(".spm")
        ]

    @staticmethod
    def _create_record_info(path, version, architecture, platform_filter):
        """Creates a record-info dictionary for a file at the given path.

        Args:
            path (str): The path to the file
            version (str): The version of the record attachment
            architecture(str): The architecture of the the record attachment

        Returns:
            dict: A dictionary containing the record metadata
        """
        name = os.path.basename(path)
        file_type = RemoteSettingsClient._determine_file_type(name)
        source_language, target_language = RemoteSettingsClient._determine_language_pair(name)
        filter_expression = RemoteSettingsClient._determine_filter_expression(
            version, platform_filter
        )
        decompressedHash = RemoteSettingsClient._compute_sha256(path)
        decompressedSize = os.path.getsize(path)
        return {
            "id": str(uuid.uuid4()),
            "data": {
                "name": name,
                "sourceLanguage": source_language,
                "targetLanguage": target_language,
                "architecture": architecture,
                "version": version,
                "fileType": file_type,
                "filter_expression": filter_expression,
                "decompressedSize": decompressedSize,
                "decompressedHash": decompressedHash,
            },
            "attachment": {
                "path": path + ".zst",
                "mimeType": "application/zstd",
            },
        }

    def _retrieve_remote_settings_bearer_token(server):
        """
        Attempts to retrieve a Remote Settings bearer token exported to an environment
        variable called REMOTE_SETTINGS_BEARER_TOKEN.

        Exits with failure if the token cannot be retrieved.


        Args:
            server (str): The name of the server

        Returns:
            String: The bearer token.
        """

        if server == "local":
            return "local_token"

        token = os.environ.get(REMOTE_SETTINGS_BEARER_TOKEN)
        if token is None:
            print_error(f"Failed to retrieve {REMOTE_SETTINGS_BEARER_TOKEN}")
            print_help(BEARER_TOKEN_HELP_MESSAGE)
            sys.exit(1)

        # When copying the Remote Settings token from the UI, it copies in the format
        # "Bearer <token>". We want to strip just the token if the user did not strip
        # it already themselves.
        if token.startswith("Bearer "):
            return token[len("Bearer ") :]

        return token

    @staticmethod
    def _determine_filter_expression(semantic_version, platform_filter):
        """Determines the appropriate Remote Settings filter expression based on the version
        and the --platform-filter flag.

        Alpha versions are available in local builds and nightly.
        Beta versions are available in all builds except release.
        Release versions are available in all builds.
        When --platform-filter is set, the filter expression is restricted to Desktop or Android.

        Args:
            semantic_version (str): A semantic version string
            platform_filter (str): Target platform ("desktop" or "android")

        Returns:
            str: The appropriate Remote Settings filter expression based on the version
            and the `--platform-filter` flag
        """
        record_version = version.parse(semantic_version)
        base_version = record_version.base_version

        if record_version < version.parse(f"{base_version}b"):
            filter_expression = "env.channel == 'default' || env.channel == 'nightly'"
        elif record_version < version.parse(f"{base_version}"):
            filter_expression = "env.channel != 'release'"
        else:
            filter_expression = ""

        if platform_filter == "Desktop":
            if filter_expression:
                filter_expression = f"({filter_expression}) && env.appinfo.OS != 'Android'"
            else:
                filter_expression = "env.appinfo.OS != 'Android'"
        elif platform_filter == "Android":
            if filter_expression:
                filter_expression = f"({filter_expression}) && env.appinfo.OS == 'Android'"
            else:
                filter_expression = "env.appinfo.OS == 'Android'"

        return filter_expression

    @staticmethod
    def _determine_language_pair(name):
        """Determines the language pair based on the name of the file.

        Args:
            name str: The name of a file to attach to a record

        Returns:
            Tuple[str, str]: The (sourceLanguage, targetLanguage) pair for this file
        """
        segments = name.split(".")

        if len(segments) < 3:
            print_error(f"The file name '{name}' has an incorrect name scheme.")
            exit(1)

        # File names are of the following formats:
        #   - model.{lang_pair}.intgemm8.bin
        #   - lex.{lang_pair}.s2t.bin
        #   - lex.50.50.{lang_pair}.s2t.bin
        #   - trgvocab.{lang_pair}.spm
        #   - srcvocab.{lang_pair}.spm
        #   - qualityModel.{lang_pair}.bin
        #   - vocab.{lang_pair}.spm
        #
        # The lang_pair will always be in the one-index, except for
        # the lex.50.50... file, in which case it is in the three-index segment.
        lang_pair_segment = segments[1]
        if len(lang_pair_segment) < 4:
            lang_pair_segment = segments[3]
        return (lang_pair_segment[:2], lang_pair_segment[-2:])

    @staticmethod
    def _determine_file_type(name):
        """Returns the type of the file based on the file name.
        Note that this is different than the file extension.
        The resulting type will be one of the following strings:

        {"model", "lex", "vocab", "trgvocab", "srcvocab", "qualityModel"}

        Args:
            name str: The name of a file to attach to a record

        Returns:
            str: The type of the file
        """
        segments = name.split(".")
        file_type_segment = segments[0]
        return file_type_segment

    @staticmethod
    def base_dir(args):
        """Get the base directory in which to search for record attachments.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI

        Returns:
            str: The base directory for record attachments.
        """
        if args.test:
            return os.path.join("tests", "remote_settings", "attachments")
        else:
            return "models"

    def server_url(self):
        """Retrieves the url of the server that this client is connected to.

        Returns:
            str: The server url
        """
        return self._client.server_info()["url"]

    def authenticated_user(self):
        """Retrieves the user who is authenticated through this client.

        Returns:
            str: The authenticated user
        """
        if self._server == "local":
            return "local_user"
        else:
            return self._client.server_info()["user"]["id"]

    def attachment_path(self, index):
        """Retrieves the path of the attachment that will be attached to a newly created record.

        Args:
            index (int): The index of the record.

        Returns:
            str: The attachment path
        """
        return self._new_records[index]["attachment"]["path"]

    def attachment_name(self, index):
        """Retrieves the name of the attachment that will be attached to a newly created record.

        Args:
            index (int): The index of the record.

        Returns:
            str: The attachment name
        """
        return os.path.basename(self.attachment_path(index))

    def attachment_mimetype(self, index):
        """Retrieves the determined mimetype of the attachment that will be attached to a newly created record.

        Args:
            index (int): The index of the record.

        Returns:
            Union[None | str]: The determined mimetype
        """
        return self._new_records[index]["attachment"]["mimeType"]

    def attachment_content(self, index):
        """Retrieves the file content of the attachment that will be attached to a newly created record.

        Args:
            index (int): The index of the record.

        Returns:
            bytes: The content of the attachment
        """
        with open(self.attachment_path(index), "rb") as f:
            attachment_content = f.read()
        return attachment_content

    def record_count(self):
        """Returns the count of new records to be created"""
        return len(self._new_records)

    def record_info_json(self, index):
        """Returns the information of the record to be created as JSON data.

        Args:
            index (int): The index of the record.

        Returns:
            str: The JSON-formatted string containing the record info
        """

        return json.dumps(self._new_records[index], indent=2)

    def create_new_record(self, index):
        """Creates a new record in the Remote Settings server along with its file attachment.

        Args:
            index (int): The index of the record.
        """
        id = self._new_records[index]["id"]
        data = self._new_records[index]["data"]
        self._client.create_record(id=id, data=data)
        self.attach_file_to_record(index)

    def compress_record_attachment(self, args, index):
        path = self._new_records[index]["attachment"]["path"]
        uncompressed_path = path.removesuffix(".zst")
        self._compress_file_with_levels(args, uncompressed_path)

    def attach_file_to_record(self, index):
        """Attaches the file attachment to the record of the matching id.

        Args:
            index (int): The index of the record.

        Raises:
            KintoException: An exception if the record was not able to be uploaded.
        """
        headers = {"Authorization": f"Bearer {self._auth_token}"}

        attachment_endpoint = "buckets/{}/collections/{}/records/{}/attachment".format(
            self._bucket, COLLECTION, self._new_records[index]["id"]
        )

        response = requests.post(
            f"{self.server_url()}{attachment_endpoint}",
            files=[
                (
                    "attachment",
                    (
                        self.attachment_name(index),
                        self.attachment_content(index),
                        self.attachment_mimetype(index),
                    ),
                )
            ],
            headers=headers,
        )

        if response.status_code > 200:
            raise KintoException(
                f"Couldn't attach file at endpoint {self.sever_url()}{attachment_endpoint}: "
                + f"{response.content.decode('utf-8')}"
            )

    def get_records(self):
        """Fetch records from the Remote Settings collection."""
        return self._client.get_records()

    def get_record(self, index):
        base = self._new_records[index]
        data = base.get("data", {})
        return {
            **data,
            "id": base.get("id"),
            "attachment": base.get("attachment"),
            "version": base.get("version", data.get("version")),
        }
