import argparse


def attach_list_subcommand(subparsers):
    list_parser = subparsers.add_parser(
        "list",
        help="list records from Remote Settings",
        formatter_class=argparse.MetavarTypeHelpFormatter,
    )
    list_parser.add_argument(
        "--server",
        type=str,
        choices=["dev", "stage", "prod", "local"],
        help="Specify which Remote Settings server to fetch records from.",
        required=True,
    )


def command_list(args):
    """Stub for the 'list' subcommand. Will later list records from Remote Settings."""
    print(f"List command selected. Server: {args.server}")
