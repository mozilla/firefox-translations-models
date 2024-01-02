import argparse

from remote_settings.subcommands.create import attach_create_subcommand, do_create

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

    args = parser.parse_args()

    if args.subcommand == "create":
        do_create(args)
    else:
        parser.print_help()


if __name__ == "__main__":
    main()
