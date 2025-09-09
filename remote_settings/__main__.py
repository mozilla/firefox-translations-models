import argparse

from remote_settings.subcommands.create.command import attach_create_subcommand, command_create
from remote_settings.subcommands.list.command import attach_list_subcommand, command_list
from remote_settings.subcommands.local_server.command import (
    attach_local_server_subcommand,
    command_local_server,
)

DESCRIPTION = """\
A script to help with the management of language models in Remote Settings.

At present, this script is only capable of createing records, but we would
like to extend the functionality in the future to perform a full set of
CRUD operations.
"""


def main():
    parser = argparse.ArgumentParser(description=DESCRIPTION)
    subparsers = parser.add_subparsers(
        title="subcommands",
        dest="subcommand",
        help="the list of valid subcommands",
    )

    attach_create_subcommand(subparsers)
    attach_list_subcommand(subparsers)
    attach_local_server_subcommand(subparsers)

    args = parser.parse_args()

    if args.subcommand == "create":
        command_create(args)
    elif args.subcommand == "list":
        command_list(args)
    elif args.subcommand == "local-server":
        command_local_server(args)
    else:
        parser.print_help()


if __name__ == "__main__":
    main()
