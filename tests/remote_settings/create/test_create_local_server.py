import subprocess

from ..common import *


class CreateCommand:
    # Store the next version which will be used for the next record by bumping it's minor version eg. 1.0 -> 1.1.
    # It starts at "1.0" to match the initial versioning scheme.
    _next_version = "1.0"

    def __init__(self):
        self._architecture = None
        self._server = None
        self._version = None
        self._lang_pair = None
        self._path = None
        self._platform_filter = None

    def with_architecture(self, architecture):
        self._architecture = architecture
        return self

    def next_available_version():
        return CreateCommand._next_version

    def with_platform_filter(self, platform_filter):
        self._platform_filter = platform_filter
        return self

    def with_server(self, server):
        self._server = server
        return self

    def with_version(self, version):
        if self._version is not None:
            raise ValueError("Version is already set.")
        self._version = version
        return self

    def with_next_minor_version(self):
        if self._version is not None:
            raise ValueError("Minor version is already set.")
        self._version = CreateCommand._next_version
        CreateCommand._next_version = next_minor_version(CreateCommand._next_version)
        return self

    def with_lang_pair(self, lang_pair):
        self._lang_pair = lang_pair
        return self

    def with_path(self, path):
        self._path = path
        return self

    def run(self):
        cmd = [
            "poetry",
            "run",
            "python",
            "-m",
            "remote_settings",
            "create",
            "--test",
        ]
        cmd.extend(["--server", self._server] if self._server else [])
        cmd.extend(["--version", self._version] if self._version else [])
        cmd.extend(["--lang-pair", self._lang_pair] if self._lang_pair else [])
        cmd.extend(["--path", self._path] if self._path else [])
        cmd.extend(["--architecture", self._architecture] if self._architecture else [])
        cmd.extend(["--platform-filter", self._platform_filter] if self._platform_filter else [])

        return subprocess.run(cmd, text=True, capture_output=True)


def test_create_command_missing_server():
    result = (
        CreateCommand()
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "the following arguments are required: --server" in result.stderr


def test_create_command_missing_version():
    result = (
        CreateCommand().with_server("local").with_path(MODEL_PATH).with_architecture("tiny").run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "the following arguments are required: --version" in result.stderr


def test_create_command_missing_path_or_lang_pair():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "one of the arguments --path --lang-pair is required" in result.stderr


def test_create_command_with_path_and_lang_pair():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_lang_pair(PROD_LANG_PAIR)
        .with_next_minor_version()
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --path: not allowed with argument --lang-pair" in result.stderr


def test_create_command_invalid_server():
    result = (
        CreateCommand()
        .with_server("invalid_server")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --server: invalid choice: 'invalid_server'" in result.stderr


def test_create_command_invalid_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("invalid_version")
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
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
        .with_server("local")
        .with_next_minor_version()
        .with_path("invalid_path")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --path: invalid value 'invalid_path' (path does not exist)" in result.stderr


def test_create_command_lang_pair_too_short():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_lang_pair("ese")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --lang-pair: invalid language pair 'ese'" in result.stderr


def test_create_command_lang_pair_too_long():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_lang_pair("esene")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --lang-pair: invalid language pair 'esene'" in result.stderr


def test_create_command_lang_pair_does_not_exist_in_base():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0a1")
        .with_lang_pair("esen")
        .with_architecture("base")
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "Path does not exist: tests/remote_settings/attachments/base/esen" in result.stderr


def test_create_command_lang_pair_does_not_exist_in_base_memory():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_lang_pair("esen")
        .with_architecture("base-memory")
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert (
        "Path does not exist: tests/remote_settings/attachments/base-memory/esen" in result.stderr
    )


def test_create_command_lang_pair_does_not_exist_in_tiny():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_lang_pair("enhu")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "Path does not exist: tests/remote_settings/attachments/tiny/enhu" in result.stderr


def test_create_command_display_authenticated_user():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert "User: local_user" in result.stdout


def test_create_command_local_server_url():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f"Server: {LOCAL_SERVER_URL}" in result.stdout


def test_create_command_alpha_filter_expression():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0a1")
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_beta_filter_expression():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0b1")
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{BETA_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_release_filter_expression():
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout


def test_create_command_lex_5050_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(LEX_5050_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{LEX_5050_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 22' in result.stdout
    assert f'"decompressedHash": "{HASH_TINY_ESEN_LEX_50_50}"' in result.stdout
    assert f'"path": "{LEX_5050_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_lex_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(LEX_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{LEX_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 16' in result.stdout
    assert f'"decompressedHash": "{HASH_TINY_ESEN_LEX}"' in result.stdout
    assert f'"path": "{LEX_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_model_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{MODEL_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 23' in result.stdout
    assert (
        f'"decompressedHash": "f57ffa166aaed3e3be4fb334b73922fbdb21988e67c4abbe165a2a2e140898c3"'
        in result.stdout
    )
    assert f'"path": "{MODEL_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_quality_model_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(QUALITY_MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{QUALITY_MODEL_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 21' in result.stdout
    assert f'"decompressedHash": "{HASH_TINY_ESEN_QUALITY_MODEL}"' in result.stdout
    assert f'"path": "{QUALITY_MODEL_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_srcvocab_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(SRCVOCAB_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{SRCVOCAB_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 17' in result.stdout
    assert f'"decompressedHash": "{HASH_TINY_ESEN_SRCVOCAB}"' in result.stdout
    assert f'"path": "{SRCVOCAB_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_trgvocab_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(TRGVOCAB_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"
    assert f'"name": "{TRGVOCAB_NAME}"' in result.stdout
    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"architecture": "tiny"' in result.stdout
    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"decompressedSize": 17' in result.stdout
    assert f'"decompressedHash": "{HASH_TINY_ESEN_TRGVOCAB}"' in result.stdout
    assert f'"path": "{TRGVOCAB_PATH}.zst"' in result.stdout
    assert f'"mimeType": "{ZSTD_MIMETYPE}"' in result.stdout


def test_create_command_lang_pair_esen():
    expected_version = CreateCommand.next_available_version()
    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_lang_pair("esen")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f"{TINY_ATTACHMENTS_PATH}" in result.stdout
    assert f"{BASE_ATTACHMENTS_PATH}" not in result.stdout
    assert f"{BASE_MEMORY_ATTACHMENTS_PATH}" not in result.stdout

    assert f'"name": "{LEX_NAME}"' in result.stdout
    assert f'"name": "{LEX_5050_NAME}"' in result.stdout
    assert f'"name": "{MODEL_NAME}"' in result.stdout
    assert f'"name": "{QUALITY_MODEL_NAME}"' in result.stdout
    assert f'"name": "{SRCVOCAB_NAME}"' in result.stdout
    assert f'"name": "{TRGVOCAB_NAME}"' in result.stdout
    assert f'"name": "{VOCAB_NAME}"' in result.stdout

    assert f'"sourceLanguage": "es"' in result.stdout
    assert f'"sourceLanguage": "en"' not in result.stdout

    assert f'"targetLanguage": "en"' in result.stdout
    assert f'"targetLanguage": "es"' not in result.stdout

    assert f'"architecture": "tiny"' in result.stdout
    assert f'"architecture": "base"' not in result.stdout
    assert f'"architecture": "base-memory"' not in result.stdout

    assert f'"version": "{expected_version}"' in result.stdout
    assert f'"version": "1.0a1"' not in result.stdout

    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{VOCAB_TYPE}"' in result.stdout

    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout

    assert (
        f'"decompressedHash": "f57ffa166aaed3e3be4fb334b73922fbdb21988e67c4abbe165a2a2e140898c3"'
        in result.stdout
    )
    assert f'"decompressedHash": "{HASH_BASE_ENCS_VOCAB}"' not in result.stdout

    assert f'"path": "{LEX_PATH}.zst"' in result.stdout
    assert f'"path": "{LEX_5050_PATH}.zst"' in result.stdout
    assert f'"path": "{MODEL_PATH}.zst"' in result.stdout
    assert f'"path": "{QUALITY_MODEL_PATH}.zst"' in result.stdout
    assert f'"path": "{SRCVOCAB_PATH}.zst"' in result.stdout
    assert f'"path": "{TRGVOCAB_PATH}.zst"' in result.stdout
    assert f'"path": "{VOCAB_PATH}.zst"' in result.stdout


def test_create_command_lang_pair_enes():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0a2")
        .with_lang_pair("enes")
        .with_architecture("base-memory")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f"{BASE_MEMORY_ATTACHMENTS_PATH}" in result.stdout
    assert f"{BASE_ATTACHMENTS_PATH}" not in result.stdout
    assert f"{TINY_ATTACHMENTS_PATH}" not in result.stdout

    assert f'"name": "{LEX_NAME}"' not in result.stdout
    assert f'"name": "{LEX_5050_NAME}"' not in result.stdout
    assert f'"name": "{MODEL_NAME}"' not in result.stdout
    assert f'"name": "{QUALITY_MODEL_NAME}"' not in result.stdout
    assert f'"name": "{SRCVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{TRGVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{VOCAB_NAME}"' not in result.stdout

    assert f'"sourceLanguage": "en"' in result.stdout
    assert f'"sourceLanguage": "es"' not in result.stdout

    assert f'"targetLanguage": "es"' in result.stdout
    assert f'"targetLanguage": "en"' not in result.stdout

    assert f'"architecture": "base-memory"' in result.stdout
    assert f'"architecture": "base"' not in result.stdout
    assert f'"architecture": "tiny"' not in result.stdout

    assert f'"version": "1.0a2"' in result.stdout
    assert f'"version": "{CreateCommand.next_available_version()}"' not in result.stdout

    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{QUALITY_MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{SRCVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{TRGVOCAB_TYPE}"' in result.stdout
    assert f'"fileType": "{VOCAB_TYPE}"' in result.stdout

    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout

    assert (
        f'"decompressedHash": "2bc2474bc48b41cf1bac8db42636fa403d1fbbe8237133ed1bb609e20171b381"'
        in result.stdout
    )
    assert f'"decompressedHash": "{HASH_TINY_ESEN_TRGVOCAB}"' not in result.stdout


def test_create_command_lang_pair_encs():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0a2")
        .with_lang_pair("encs")
        .with_architecture("base")
        .run()
    )
    assert result.returncode == SUCCESS, f"The return code should be {SUCCESS}"
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f"{BASE_ATTACHMENTS_PATH}" in result.stdout
    assert f"{BASE_MEMORY_ATTACHMENTS_PATH}" not in result.stdout
    assert f"{TINY_ATTACHMENTS_PATH}" not in result.stdout

    assert f'"name": "{LEX_NAME}"' not in result.stdout
    assert f'"name": "{LEX_5050_NAME}"' not in result.stdout
    assert f'"name": "{MODEL_NAME}"' not in result.stdout
    assert f'"name": "{QUALITY_MODEL_NAME}"' not in result.stdout
    assert f'"name": "{SRCVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{TRGVOCAB_NAME}"' not in result.stdout
    assert f'"name": "{VOCAB_NAME}"' not in result.stdout

    assert f'"sourceLanguage": "en"' in result.stdout
    assert f'"sourceLanguage": "cs"' not in result.stdout

    assert f'"targetLanguage": "cs"' in result.stdout
    assert f'"targetLanguage": "en"' not in result.stdout

    assert f'"architecture": "base"' in result.stdout
    assert f'"architecture": "base-memory"' not in result.stdout
    assert f'"architecture": "tiny"' not in result.stdout

    assert f'"version": "1.0a2"' in result.stdout
    assert f'"version": "{CreateCommand.next_available_version()}"' not in result.stdout

    assert f'"fileType": "{LEX_TYPE}"' in result.stdout
    assert f'"fileType": "{MODEL_TYPE}"' in result.stdout
    assert f'"fileType": "{VOCAB_TYPE}"' in result.stdout

    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout

    assert (
        f'"decompressedHash": "eeedb736639b03303e915c792210d39a5dc17a443b4dd3f80dc5502fc7d38d14"'
        in result.stdout
    )
    assert f'"decompressedHash": "{HASH_TINY_ESEN_TRGVOCAB}"' not in result.stdout


def test_create_command_no_files_in_directory():
    result = (
        CreateCommand()
        .with_server("local")
        .with_version("1.0a1")
        .with_lang_pair("emty")
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "No records found" in result.stderr
    assert "You may need to unzip" in result.stdout


def test_create_command_duplicate_record():
    version_used = CreateCommand.next_available_version()

    result = (
        CreateCommand()
        .with_server("local")
        .with_next_minor_version()
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    # Explicitly uses the stored version again
    duplicate_result = (
        CreateCommand()
        .with_server("local")
        .with_version(version_used)
        .with_path(MODEL_PATH)
        .with_architecture("tiny")
        .run()
    )
    assert duplicate_result.returncode == ERROR
    assert (
        f"Record {MODEL_NAME} already exists with version {version_used}"
        in duplicate_result.stderr
    )


def test_create_command_fails_on_invalid_file_hash():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(INHA_PATH)
        .with_next_minor_version()
        .with_architecture("tiny")
        .run()
    )
    assert result.returncode == ERROR, f"The return code should be {ERROR}"
    assert "Hash mismatch" in result.stderr


def test_create_desktop_only_command_with_alpha_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_version("1.0a3")
        .with_architecture("tiny")
        .with_platform_filter("desktop")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_desktop_only_command_with_beta_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_version("1.0b2")
        .with_architecture("tiny")
        .with_platform_filter("desktop")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{BETA_AND_DESKTOP_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_desktop_only_command_with_release_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_next_minor_version()
        .with_architecture("tiny")
        .with_platform_filter("desktop")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_android_only_command_with_alpha_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_version("1.0a4")
        .with_architecture("tiny")
        .with_platform_filter("android")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_android_only_command_with_beta_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_version("1.0b3")
        .with_architecture("tiny")
        .with_platform_filter("android")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_android_only_command_with_release_version():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_next_minor_version()
        .with_architecture("tiny")
        .with_platform_filter("android")
        .run()
    )
    assert result.returncode == SUCCESS
    assert "" == result.stderr, "The standard error stream should be empty"

    assert f'"filter_expression": "{ANDROID_FILTER_EXPRESSION}"' in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_ANDROID_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{BETA_AND_DESKTOP_FILTER_EXPRESSION}"' not in result.stdout
    assert f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"' not in result.stdout


def test_create_invalid_platform_filter():
    result = (
        CreateCommand()
        .with_server("local")
        .with_path(MODEL_PATH)
        .with_next_minor_version()
        .with_architecture("tiny")
        .with_platform_filter("invalid_filter")
        .run()
    )
    assert result.returncode == INVALID_USE, f"The return code should be {INVALID_USE}"
    assert "" == result.stdout, "The standard output stream should be empty"
    assert "argument --platform-filter: Invalid platform filter 'invalid_filter" in result.stderr
