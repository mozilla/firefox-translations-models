import os, sys, mimetypes, requests, uuid, json

from kinto_http import Client, BearerTokenAuth
from packaging import version

from remote_settings.format import print_error, print_help

# Register .zst extension with application/zstd MIME type
mimetypes.add_type("application/zstd", ".zst")

REMOTE_SETTINGS_BEARER_TOKEN = "REMOTE_SETTINGS_BEARER_TOKEN"
BEARER_TOKEN_HELP_MESSAGE = f"""\
Export the token as an environment variable called {REMOTE_SETTINGS_BEARER_TOKEN}.

You can retrieve a bearer token from the Remote Settings admin dashboards.

  Dev: https://settings.dev.mozaws.net/v1/admin
Stage: https://remote-settings.allizom.org/v1/admin
 Prod: https://remote-settings.mozilla.org/v1/admin

On the top right corner, use the 📋 icon to copy the authentication string
"""
BUCKET = "main-workspace"
COLLECTION = "translations-models"
SERVER_URLS = {
    "dev": "https://remote-settings-dev.allizom.org/v1",
    "stage": "https://remote-settings.allizom.org/v1",
    "prod": "https://remote-settings.mozilla.org/v1",
}


class MockedClient:
    def __init__(self, args):
        self._server = args.server

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
        if args.mock_connection:
            self._client = MockedClient(args)
            return

        self._auth_token = RemoteSettingsClient._retrieve_remote_settings_bearer_token()
        self._client = Client(
            server_url=SERVER_URLS.get(args.server),
            bucket=BUCKET,
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
            new_record_info = RemoteSettingsClient._create_record_info(args.path, args.version)
            this._new_records = [new_record_info]
        else:
            paths = this._paths_for_lang_pair(args)
            this._new_records = [
                RemoteSettingsClient._create_record_info(path, args.version) for path in paths
            ]

        return this

    @staticmethod
    def _paths_for_lang_pair(args):
        """Retrieves all of the file paths for the given language pair and version in args.

        Args:
            args (argparse.Namespace): The arguments passed through the CLI

        Returns:
            List[str]: A list of file paths in the specified language-pair directory.
        """
        parsed_version = version.parse(args.version)

        if parsed_version.is_prerelease:
            directory = os.path.join(RemoteSettingsClient._base_dir(args), "dev")
        else:
            directory = os.path.join(RemoteSettingsClient._base_dir(args), "prod")

        full_path = os.path.join(directory, args.lang_pair)

        if not os.path.exists(full_path):
            print_error(f"Path does not exist: {full_path}")
            exit(1)

        return [os.path.join(full_path, f) for f in os.listdir(full_path) if not f.endswith(".gz")]

    @staticmethod
    def _create_record_info(path, version):
        """Creates a record-info dictionary for a file at the given path.

        Args:
            path (str): The path to the file
            version (str): The version of the record attachment

        Returns:
            dict: A dictionary containing the record metadata
        """
        name = os.path.basename(path)
        file_type = RemoteSettingsClient._determine_file_type(name)
        from_lang, to_lang = RemoteSettingsClient._determine_language_pair(name)
        filter_expression = RemoteSettingsClient._determine_filter_expression(version)
        
        mimetype, _ = mimetypes.guess_type(path)
        
        return {
            "id": str(uuid.uuid4()),
            "data": {
                "name": os.path.basename(path),
                "fromLang": from_lang,
                "toLang": to_lang,
                "version": version,
                "fileType": file_type,
                "filter_expression": filter_expression,
            },
            "attachment": {
                "path": path,
                "mimeType": mimetype,
            },
        }

    @staticmethod
    def _retrieve_remote_settings_bearer_token():
        """
        Attempts to retrieve a Remote Settings bearer token exported to an environment
        variable called REMOTE_SETTINGS_BEARER_TOKEN.

        Exits with failure if the token cannot be retrieved.

        Returns:
            String: The bearer token.
        """

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
    def _determine_filter_expression(semantic_version):
        """Determines the appropriate Remote Settings filter expression based on the version.

        Alpha versions are available in local builds and nightly.
        Beta versions are available in all builds except release.
        Release versions are available in all builds.

        Args:
            semantic_version str: A semantic version string

        Returns:
            str: The appropriate Remote Settings filter expression based on the version
        """
        record_version = version.parse(semantic_version)
        base_version = record_version.base_version

        if record_version < version.parse(f"{base_version}b"):
            return "env.channel == 'default' || env.channel == 'nightly'"
        elif record_version < version.parse(f"{base_version}"):
            return "env.channel != 'release'"
        else:
            return ""

    @staticmethod
    def _determine_language_pair(name):
        """Determines the language pair based on the name of the file.

        Args:
            name str: The name of a file to attach to a record

        Returns:
            Tuple[str, str]: The (fromLang, toLang) pair for this file
        """
        segments = name.split(".")

        # File names are of the following formats:
        #   - model.{lang_pair}.intgemm8.bin.gz
        #   - lex.{lang_pair}.s2t.bin.gz
        #   - lex.50.50.{lang_pair}.s2t.bin.gz
        #   - trgvocab.{lang_pair}.spm.gz
        #   - srcvocab.{lang_pair}.spm.gz
        #   - qualityModel.{lang_pair}.bin.gz
        #   - vocab.{lang_pair}.spm.gz
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
    def _base_dir(args):
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

    def attach_file_to_record(self, index):
        """Attaches the file attachment to the record of the matching id.

        Args:
            index (int): The index of the record.

        Raises:
            KintoException: An exception if the record was not able to be uploaded.
        """
        headers = {"Authorization": f"Bearer {self._auth_token}"}

        attachment_endpoint = "buckets/{}/collections/{}/records/{}/attachment".format(
            BUCKET, COLLECTION, self._new_records[index]["id"]
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
