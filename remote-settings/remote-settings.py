import argparse

DESCRIPTION = """\
A script to help with the management of language models in Remote Settings.

At present, this script is only capable of createing records, but we would
like to extend the functionality in the future to perform a full set of
CRUD operations.
"""


def main():
    parser = argparse.ArgumentParser(description=DESCRIPTION)

    args = parser.parse_args()


if __name__ == "__main__":
    main()
