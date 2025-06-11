import argparse
import json

from remote_settings.client import RemoteSettingsClient


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
        "--server",
        type=str,
        choices=["dev", "stage", "prod", "local"],
        help="Specify which Remote Settings server to fetch records from.",
        required=True,
    )
    list_parser.add_argument(
        "--test",
        action="store_true",
        help=argparse.SUPPRESS,
    )


def command_list(args):
    """Fetch and display a list of records from Remote Settings."""

    client = RemoteSettingsClient.init_for_list(args)

    all_records = client.get_records()

    print(
        json.dumps(
            {
                "server": client.server_url(),
                "records": all_records,
                "total": len(all_records),
            }
        )
    )
    exit(0)
