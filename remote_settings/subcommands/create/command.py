import argparse, os

from packaging import version

from remote_settings.client import RemoteSettingsClient
from remote_settings.format import print_info, print_error, print_help


def attach_create_subcommand(subparsers):
    """Adds the `create` subcommand and its associated arguments as a subparser.

    Args:
        subparsers (_SubParsersAction): The subparser action object to add
        this subcommand to.
    """

    create_parser = subparsers.add_parser(
        "create",
        help="create and upload a new record to Remote Settings",
        formatter_class=argparse.MetavarTypeHelpFormatter,
    )
    create_parser.add_argument(
        "-a",
        "--architecture",
        type=str,
        help="The architecture of the model must match a folder name inside the models directory",
        required=True,
    )
    create_parser.add_argument(
        "-d",
        "--dry-run",
        action="store_true",
        help="verify the authentication and record data, but do not create",
    )
    create_parser.add_argument(
        "-m",
        "--mock-connection",
        action="store_true",
        help="mock the connection to the server for testing",
    )
    create_parser.add_argument(
        "--server",
        type=str,
        choices=["dev", "stage", "prod", "local"],
        help="the server where records will be created",
        required=True,
    )
    create_parser.add_argument(
        "--version",
        metavar="VERSION",
        type=validate_version,
        help="the semantic version of the record",
        required=True,
    )
    create_parser.add_argument(
        "--test",
        action="store_true",
        help=argparse.SUPPRESS,
    )

    group = create_parser.add_mutually_exclusive_group(required=True)
    group.add_argument(
        "--path",
        metavar="PATH",
        type=validate_path,
        help="the path to the file attachment to upload",
    )
    group.add_argument(
        "--lang-pair",
        metavar="PAIR",
        type=validate_lang_pair,
        help="the language pair for which to publish all associated files, e.g. 'enes'",
    )


def is_duplicate_record(record, existing_records):
    """Check if a record with the same identifying fields already exists."""
    for existing in existing_records:
        if (
            existing.get("name") == record.get("name")
            and existing.get("version") == record.get("version")
            and existing.get("sourceLanguage") == record.get("sourceLanguage")
            and existing.get("targetLanguage") == record.get("targetLanguage")
            and existing.get("architecture") == record.get("architecture")
            and existing.get("fileType") == record.get("fileType")
        ):
            return True
    return False


def validate_path(value):
    if not os.path.exists(value):
        raise argparse.ArgumentTypeError(f"invalid value '{value}' (path does not exist)")
    return value


def validate_lang_pair(value):
    if len(value) != 4:
        raise argparse.ArgumentTypeError(
            f"invalid language pair '{value}', expected only four letters, e.g. 'enes'"
        )
    return value


def validate_version(value):
    try:
        version.parse(value)
    except:
        raise argparse.ArgumentTypeError(
            f"invalid value '{value}' (use a valid semantic version number)"
        )
    return value


def validate_uncompressed_model_file_hash(record):
    path = record["attachment"]["path"]
    uncompressed_file_path = path.removesuffix(".zst")
    expected = RemoteSettingsClient.get_expected_model_file_hash(uncompressed_file_path)
    actual = record["decompressedHash"]

    if expected != actual:
        print_error(
            f"Hash mismatch for {uncompressed_file_path}\n\nExpected: {expected}\n  Actual: {actual}"
        )
        print_help("Ensure that the file was exported with the correct metadata.json")
        exit(1)


def command_create(args):
    """Creates a new record based on args, and uploads it to Remote Settings.

    Args:
        args (argparse.Namespace): The arguments passed to the create subcommand
    """

    client = RemoteSettingsClient.init_for_create(args)

    print_info()
    print_info(f"User: {client.authenticated_user()}")
    print_info(f"Server: {client.server_url()}")

    if client.record_count() == 0:
        print_error("No records found.")
        print_help("You may need to unzip the archives in the desired directory.")
        exit(1)

    existing_records = client.get_records()

    print_info()

    for i in range(client.record_count()):
        record = client.get_record(i)

        file_type = record["fileType"]

        print_info(f"Validating record: {record['name']}")

        if is_duplicate_record(record, existing_records):
            print_error(
                f"Record {record['name']} already exists with version {record['version']}."
            )
            print_help("Use a different name or version.")
            exit(1)

        if file_type == "model":
            validate_uncompressed_model_file_hash(record)

    for i in range(client.record_count()):
        client.compress_record_attachment(args, i)

    for i in range(client.record_count()):
        record = client.get_record(i)

        print_info(f"Record: {client.record_info_json(i)}")

        if not (args.dry_run or args.mock_connection):
            print_info("Creating record...")
            client.create_new_record(i)
            print_info(f"{client.attachment_name(i)} created")

        print_info()

    print_info()
