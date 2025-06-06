import argparse
import json

from remote_settings.client import RemoteSettingsClient
from remote_settings.format import print_info, print_error, print_help


def attach_list_subcommand(subparsers):
    list_parser = subparsers.add_parser(
        "list",
        help="list records from Remote Settings",
        formatter_class=argparse.MetavarTypeHelpFormatter,
    )
    list_parser.add_argument(
        "-m",
        "--mock-connection",
        action="store_true",
        help="mock the connection to the server for testing",
    )
    list_parser.add_argument(
        "-q",
        "--quiet",
        action="store_true",
        help="do not print informational non-error output to the terminal",
    )
    list_parser.add_argument(
        "--server",
        type=str,
        choices=["dev", "stage", "prod", "local"],
        help="Specify which Remote Settings server to fetch records from.",
        required=True,
    )


def command_list(args):
    """Fetch and display a list of records from Remote Settings."""

    client = RemoteSettingsClient.init_for_list(args)

    print()
    print_info(args, f"User: {client.authenticated_user()}")
    print_info(args, f"Server: {client.server_url()}")
    print()

    if client.get_record_count() == 0:
        print_error("No records found.")
        print_help("You may need to create a record first.")
        exit(1)

    all_records = []

    for i in range(client.get_record_count()):
        record = client._fetched_records[i]
        all_records.append(record)

    print(json.dumps(all_records, indent=2))
    print()
    print_info(args, f"Total records: {len(all_records)}")
