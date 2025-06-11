import json
import subprocess

from ..test_constants import *


class ListCommand:
    def __init__(self):
        self._server = None
        self._version = None
        self._lang_pair = None
        self._quiet = None

    def with_server(self, server):
        self._server = server
        return self

    def run(self):
        command = [
            "poetry",
            "run",
            "python",
            "-m",
            "remote_settings",
            "list",
            "--test",
            "--mock-connection",
        ]
        command.extend(["--server", self._server] if self._server else [])
        return subprocess.run(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)


def test_list_command_dev_server_url():
    result = ListCommand().with_server("dev").run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert result.stderr == "", "The standard error stream should be empty"

    output = json.loads(result.stdout)
    assert output["server"] == DEV_SERVER_URL, f"The server should be {DEV_SERVER_URL}"


def test_list_command_prod_server_url():
    result = ListCommand().with_server("prod").run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert result.stderr == "", "The standard error stream should be empty"

    output = json.loads(result.stdout)
    assert output["server"] == PROD_SERVER_URL, f"The server should be {PROD_SERVER_URL}"


def test_list_command_stage_server_url():
    result = ListCommand().with_server("stage").run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert result.stderr == "", "The standard error stream should be empty"

    output = json.loads(result.stdout)
    assert output["server"] == STAGE_SERVER_URL, f"The server should be {STAGE_SERVER_URL}"
