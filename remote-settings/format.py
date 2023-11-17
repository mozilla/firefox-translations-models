import sys

from termcolor import colored

ERROR = colored("\nError:", "red")
HELP = colored("\nHelp:", "green")


def print_error(*args, **kwargs):
    """Prints a message to stderr with the prefix 'Error:'"""
    print(ERROR, end=" ", file=sys.stderr)
    print(*args, file=sys.stderr, **kwargs)


def print_help(*args, **kwargs):
    """Prints a message with the prefix 'Help:'"""
    print(HELP, end=" ")
    print(*args, **kwargs)


def print_info(cmd_args, *args, **kwargs):
    """Possibly prints a message based on the cmd_args"""
    if cmd_args.quiet:
        return
    print(*args, **kwargs)
