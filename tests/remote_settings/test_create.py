import pytest
import subprocess

SUCCESS = 0
ERROR = 1
INVALID_USE = 2

PROD_LANG_PAIR = "esen"
DEV_LANG_PAIR = "enes"

LEX_TYPE = "lex"
MODEL_TYPE = "model"
QUALITY_MODEL_TYPE = "qualityModel"
TRGVOCAB_TYPE = "trgvocab"
SRCVOCAB_TYPE = "srcvocab"
VOCAB_TYPE = "vocab"

LEX_NAME = "lex.esen.s2t.zst"
LEX_5050_NAME = "lex.50.50.esen.s2t.zst"
MODEL_NAME = "model.esen.intgemm8.zst"
QUALITY_MODEL_NAME = "qualityModel.esen.zst"
SRCVOCAB_NAME = "srcvocab.esen.zst"
TRGVOCAB_NAME = "trgvocab.esen.zst"
VOCAB_NAME = "vocab.esen.zst"

DEV_ATTACHMENTS_PATH = "tests/remote_settings/attachments/dev/enes"
PROD_ATTACHMENTS_PATH = "tests/remote_settings/attachments/prod/esen"
LEX_PATH = f"{PROD_ATTACHMENTS_PATH}/{LEX_NAME}"
LEX_5050_PATH = f"{PROD_ATTACHMENTS_PATH}/{LEX_5050_NAME}"
MODEL_PATH = f"{PROD_ATTACHMENTS_PATH}/{MODEL_NAME}"
QUALITY_MODEL_PATH = f"{PROD_ATTACHMENTS_PATH}/{QUALITY_MODEL_NAME}"
SRCVOCAB_PATH = f"{PROD_ATTACHMENTS_PATH}/{SRCVOCAB_NAME}"
TRGVOCAB_PATH = f"{PROD_ATTACHMENTS_PATH}/{TRGVOCAB_NAME}"
VOCAB_PATH = f"{PROD_ATTACHMENTS_PATH}/{VOCAB_NAME}"

DEV_SERVER_URL = "https://remote-settings-dev.allizom.org/v1"
PROD_SERVER_URL = "https://remote-settings.mozilla.org/v1"
STAGE_SERVER_URL = "https://remote-settings.allizom.org/v1"

ALPHA_FILTER_EXPRESSION = "env.channel == 'default' || env.channel == 'nightly'"
BETA_FILTER_EXPRESSION = "env.channel != 'release'"
RELEASE_FILTER_EXPRESSION = ""

ZSTD_MIME = "application/zstd"


class CreateCommand:
    def __init__(self):
        self._server = None
        self._version = None
        self._lang_pair = None
        self._path = None
        self._quiet = None

    def with_server(self, server):
        self._server = server
        return self

    def with_version(self, version):
        self._version = version
        return self

    def with_lang_pair(self, lang_pair):
        self._lang_pair = lang_pair
        return self

    def with_path(self, path):
        self._path = path
        return self

    def quiet(self):
        self._quiet = True
        return self

    def run(self):
        command = [
            "poetry",
            "run",
            "python",
            "-m",
            "remote_settings",
            "create",
            "--test",
            "--mock-connection",
        ]
        command.extend(["--server", self._server] if self._server else [])
        command.extend(["--version", self._version] if self._version else [])
        command.extend(["--lang-pair", self._lang_pair] if self._lang_pair else [])
        command.extend(["--path", self._path] if self._path else [])
        command.extend(["--quiet"] if self._quiet else [])
        return subprocess.run(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)


def test_create_command_quiet_flag():
    result = (
        CreateCommand().with_server("dev").with_version("1.0").with_path(MODEL_PATH).quiet().run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "" == result.stderr, "The standard error stream should be empty"


def test_create_command_missing_server():
    result = CreateCommand().with_version("1.0").with_path(MODEL_PATH).quiet().run()
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "the following arguments are required: --server" in result.stderr


def test_create_command_missing_version():
    result = CreateCommand().with_server("dev").with_path(MODEL_PATH).quiet().run()
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "the following arguments are required: --version" in result.stderr


def test_create_command_missing_path_or_lang_pair():
    result = CreateCommand().with_server("dev").with_version("1.0").quiet().run()
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "one of the arguments --path --lang-pair is required" in result.stderr


def test_create_command_with_path_and_lang_pair():
    result = (
        CreateCommand()
        .with_server("dev")
        .with_path(MODEL_PATH)
        .with_lang_pair(PROD_LANG_PAIR)
        .with_version("1.0")
        .quiet()
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --path: not allowed with argument --lang-pair" in result.stderr


def test_create_command_invalid_server():
    result = (
        CreateCommand()
        .with_server("invalid_server")
        .with_version("1.0")
        .with_path(MODEL_PATH)
        .quiet()
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert (
        "argument --server: invalid choice: 'invalid_server' (choose from 'dev', 'stage', 'prod')"
        in result.stderr
    )


def test_create_command_invalid_version():
    result = (
        CreateCommand()
        .with_server("dev")
        .with_version("invalid_version")
        .with_path(MODEL_PATH)
        .quiet()
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert (
        "argument --version: invalid value 'invalid_version' (use a valid semantic version number)"
        in result.stderr
    )


def test_create_command_invalid_path():
    result = (
        CreateCommand()
        .with_server("dev")
        .with_version("1.0")
        .with_path("invalid_path")
        .quiet()
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --path: invalid value 'invalid_path' (path does not exist)" in result.stderr


def test_create_command_lang_pair_too_short():
    result = (
        CreateCommand().with_server("dev").with_version("1.0").with_lang_pair("ese").quiet().run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --lang-pair: invalid language pair 'ese'" in result.stderr


def test_create_command_lang_pair_too_long():
    result = (
        CreateCommand()
        .with_server("dev")
        .with_version("1.0")
        .with_lang_pair("esene")
        .quiet()
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --lang-pair: invalid language pair 'esene'" in result.stderr


def test_create_command_lang_pair_does_not_exist_in_dev():
    result = (
        CreateCommand()
        .with_server("dev")
        .with_version("1.0a1")
        .with_lang_pair("esen")
        .quiet()
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "Path does not exist: tests/remote_settings/attachments/dev/esen" in result.stderr


def test_create_command_lang_pair_does_not_exist_in_prod():
    result = (
        CreateCommand().with_server("dev").with_version("1.0").with_lang_pair("enes").quiet().run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "Path does not exist: tests/remote_settings/attachments/prod/enes" in result.stderr


def test_create_command_display_authenticated_user():
    result = CreateCommand().with_server("dev").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert "User: mocked_user" in result.stdout


def test_create_command_dev_server_url():
    result = CreateCommand().with_server("dev").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f"Server: {DEV_SERVER_URL}" in result.stdout


def test_create_command_prod_server_url():
    result = CreateCommand().with_server("prod").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f"Server: {PROD_SERVER_URL}" in result.stdout


def test_create_command_stage_server_url():
    result = CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f"Server: {STAGE_SERVER_URL}" in result.stdout


def test_create_command_alpha_filter_expression():
    result = CreateCommand().with_server("stage").with_version("1.0a1").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_beta_filter_expression():
    result = CreateCommand().with_server("stage").with_version("1.0b1").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{BETA_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_release_filter_expression():
    result = CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_lex_5050_esen():
    result = (
        CreateCommand().with_server("stage").with_version("1.0").with_path(LEX_5050_PATH).run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{LEX_5050_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{LEX_5050_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_lex_esen():
    result = CreateCommand().with_server("stage").with_version("1.0").with_path(LEX_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{LEX_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{LEX_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_model_esen():
    result = CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{MODEL_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{MODEL_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_quality_model_esen():
    result = (
        CreateCommand()
        .with_server("stage")
        .with_version("1.0")
        .with_path(QUALITY_MODEL_PATH)
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{QUALITY_MODEL_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{QUALITY_MODEL_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_srcvocab_esen():
    result = (
        CreateCommand().with_server("stage").with_version("1.0").with_path(SRCVOCAB_PATH).run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{SRCVOCAB_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{SRCVOCAB_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_trgvocab_esen():
    result = (
        CreateCommand().with_server("stage").with_version("1.0").with_path(TRGVOCAB_PATH).run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{TRGVOCAB_NAME}"' in result.stdout
    assert f'"fromLang": "es"' in result.stdout
    assert f'"toLang": "en"' in result.stdout
    assert f'"version": "1.0"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"path": "{TRGVOCAB_PATH}"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIME}"' in result.stdout


def test_create_command_lang_pair_esen():
    result = CreateCommand().with_server("stage").with_version("1.0").with_lang_pair("esen").run()
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f"{PROD_ATTACHMENTS_PATH}" in result.stdout
    assert f"{DEV_ATTACHMENTS_PATH}" not in result.stdout

    assert f'"name": "{LEX_NAME}"' in result.stdout
    assert f'"name": "{LEX_5050_NAME}"' in result.stdout
    assert f'"name": "{MODEL_NAME}"' in result.stdout
    assert f'"name": "{QUALITY_MODEL_NAME}"' in result.stdout
    assert f'"name": "{SRCVOCAB_NAME}"' in result.stdout
    assert f'"name": "{TRGVOCAB_NAME}"' in result.stdout
    assert f'"name": "{VOCAB_NAME}"' in result.stdout

    assert f'"fromLang": "es"' in result.stdout
    assert f'"fromLang": "en"' not in result.stdout

    assert f'"toLang": "en"' in result.stdout
    assert f'"toLang": "es"' not in result.stdout

    assert f'"version": "1.0"' in result.stdout
    assert f'"version": "1.0a1"' not in result.stdout

    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{VOCAB_TYPE}"' in result.stdout

    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout

    assert f'"path": "{LEX_PATH}"' in result.stdout
    assert f'"path": "{LEX_5050_PATH}"' in result.stdout
    assert f'"path": "{MODEL_PATH}"' in result.stdout
    assert f'"path": "{QUALITY_MODEL_PATH}"' in result.stdout
    assert f'"path": "{SRCVOCAB_PATH}"' in result.stdout
    assert f'"path": "{TRGVOCAB_PATH}"' in result.stdout
    assert f'"path": "{VOCAB_PATH}"' in result.stdout


def test_create_command_lang_pair_enes():
    result = (
        CreateCommand().with_server("stage").with_version("1.0a1").with_lang_pair("enes").run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f"{DEV_ATTACHMENTS_PATH}" in result.stdout
    assert f"{PROD_ATTACHMENTS_PATH}" not in result.stdout

    assert f'"name": "{LEX_NAME}"' not in result.stdout
    assert f'"name": "{LEX_5050_NAME}"' not in result.stdout
    assert f'"name": "{MODEL_NAME}"' not in result.stdout
    assert f'"name": "{QUALITY_MODEL_NAME}"' not in result.stdout
    assert f'"name": "{SRCVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{TRGVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{VOCAB_NAME}"' not in result.stdout

    assert f'"fromLang": "en"' in result.stdout
    assert f'"fromLang": "es"' not in result.stdout

    assert f'"toLang": "es"' in result.stdout
    assert f'"toLang": "en"' not in result.stdout

    assert f'"version": "1.0a1"' in result.stdout
    assert f'"version": "1.0"' not in result.stdout

    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{VOCAB_TYPE}"' in result.stdout

    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_command_no_files_in_directory():
    result = (
        CreateCommand().with_server("stage").with_version("1.0a1").with_lang_pair("emty").run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "No records found" in result.stderr
    assert "You may need to unzip" in result.stdout
