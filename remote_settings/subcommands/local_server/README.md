This subcommand starts a new instance of a local RemoteSettings server within a Docker container.

The server is hosted on http://localhost:8888/v1/admin

For now, this is mostly a pared-down fork of https://github.com/mozilla/translations/tree/main/utils/local_remote_settings

However, when we eventually merge this repo into the aforementioned main `translations` repo, this tool may likely replace
the former tool. Though we must ensure that it has feature parity before doing so.