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
        "-q",
        "--quiet",
        action="store_true",
        help="do not print informational non-error output to the terminal",
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


def command_create(args):
    """Creates a new record based on args, and uploads it to Remote Settings.

    Args:
        args (argparse.Namespace): The arguments passed to the create subcommand
    """

    client = RemoteSettingsClient.init_for_create(args)

    print_info(args)
    print_info(args, f"User: {client.authenticated_user()}")
    print_info(args, f"Server: {client.server_url()}")

    if client.record_count() == 0:
        print_error("No records found.")
        print_help("You may need to unzip the archives in the desired directory.")
        exit(1)

    print_info(args)

    for i in range(client.record_count()):
        print_info(args, f"Record: {client.record_info_json(i)}")

        if not (args.dry_run or args.mock_connection):
            print_info(args, "Creating record...")
            client.create_new_record(i)
            print_info(args, f"{client.attachment_name(i)} created")

        print_info(args)

    print_info(args)
