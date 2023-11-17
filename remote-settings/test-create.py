import unittest
import subprocess

SUCCESS = 0
INVALID_USE = 2

LEX_TYPE = "lex"
MODEL_TYPE = "model"
QUALITY_MODEL_TYPE = "qualityModel"
TRGVOCAB_TYPE = "trgvocab"
SRCVOCAB_TYPE = "srcvocab"
VOCAB_TYPE = "vocab"

LEX_NAME = "lex.esen.s2t.bin"
LEX_5050_NAME = "lex.50.50.esen.s2t.bin"
MODEL_NAME = "model.esen.intgemm8.bin"
QUALITY_MODEL_NAME = "qualityModel.esen.bin"
SRCVOCAB_NAME = "srcvocab.esen.spm"
TRGVOCAB_NAME = "trgvocab.esen.spm"
VOCAB_NAME = "vocab.esen.spm"

BASE_PATH = "remote-settings"
LEX_PATH = f"{BASE_PATH}/test/{LEX_NAME}"
LEX_5050_PATH = f"{BASE_PATH}/test/{LEX_5050_NAME}"
MODEL_PATH = f"{BASE_PATH}/test/{MODEL_NAME}"
QUALITY_MODEL_PATH = f"{BASE_PATH}/test/{QUALITY_MODEL_NAME}"
SRCVOCAB_PATH = f"{BASE_PATH}/test/{SRCVOCAB_NAME}"
TRGVOCAB_PATH = f"{BASE_PATH}/test/{TRGVOCAB_NAME}"
VOCAB_PATH = f"{BASE_PATH}/test/{VOCAB_NAME}"

DEV_SERVER_URL = "https://remote-settings-dev.allizom.org/v1/"
PROD_SERVER_URL = "https://settings-writer.prod.mozaws.net/v1/"
STAGE_SERVER_URL = "https://settings-writer.stage.mozaws.net/v1/"

ALPHA_FILTER_EXPRESSION = "env.channel == 'default' || env.channel == 'nightly'"
BETA_FILTER_EXPRESSION = "env.channel != 'release'"
RELEASE_FILTER_EXPRESSION = ""

OCTET_STREAM = "application/octet-stream"


class CreateCommand:
    def __init__(self):
        self._server = None
        self._version = None
        self._path = None
        self._quiet = None

    def with_server(self, server):
        self._server = server
        return self

    def with_version(self, version):
        self._version = version
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
            f"{BASE_PATH}/remote-settings.py",
            "create",
            "--mock-connection",
        ]
        command.extend(["--server", self._server] if self._server else [])
        command.extend(["--version", self._version] if self._version else [])
        command.extend(["--path", self._path] if self._path else [])
        command.extend(["--quiet"] if self._quiet else [])
        return subprocess.run(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)


class TestCreate(unittest.TestCase):
    def test_create_command_quiet_flag(self):
        result = (
            CreateCommand()
            .with_server("dev")
            .with_version("1.0")
            .with_path(MODEL_PATH)
            .quiet()
            .run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")

    def test_create_command_missing_server(self):
        result = CreateCommand().with_version("1.0").with_path(MODEL_PATH).quiet().run()
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn("the following arguments are required: --server", result.stderr)

    def test_create_command_missing_version(self):
        result = CreateCommand().with_server("dev").with_path(MODEL_PATH).quiet().run()
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn("the following arguments are required: --version", result.stderr)

    def test_create_command_missing_path(self):
        result = CreateCommand().with_server("dev").with_version("1.0").quiet().run()
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn("the following arguments are required: --path", result.stderr)

    def test_create_command_invalid_server(self):
        result = (
            CreateCommand()
            .with_server("invalid_server")
            .with_version("1.0")
            .with_path(MODEL_PATH)
            .quiet()
            .run()
        )
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn(
            "argument --server: invalid choice: 'invalid_server' (choose from 'dev', 'stage', 'prod')",
            result.stderr,
        )

    def test_create_command_invalid_version(self):
        result = (
            CreateCommand()
            .with_server("dev")
            .with_version("invalid_version")
            .with_path(MODEL_PATH)
            .quiet()
            .run()
        )
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn(
            "argument --version: invalid value 'invalid_version' (use a valid semantic version number)",
            result.stderr,
        )

    def test_create_command_invalid_path(self):
        result = (
            CreateCommand()
            .with_server("dev")
            .with_version("1.0")
            .with_path("invalid_path")
            .quiet()
            .run()
        )
        self.assertEqual(
            result.returncode, INVALID_USE, f"The return code should be {INVALID_USE}"
        )
        self.assertEqual("", result.stdout, "The standard output stream should be empty")
        self.assertIn(
            "argument --path: invalid value 'invalid_path' (path does not exist)", result.stderr
        )

    def test_create_command_display_authenticated_user(self):
        result = CreateCommand().with_server("dev").with_version("1.0").with_path(MODEL_PATH).run()
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn("User: mocked_user", result.stdout)

    def test_create_command_dev_server_url(self):
        result = CreateCommand().with_server("dev").with_version("1.0").with_path(MODEL_PATH).run()
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f"Server: {DEV_SERVER_URL}", result.stdout)

    def test_create_command_prod_server_url(self):
        result = (
            CreateCommand().with_server("prod").with_version("1.0").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f"Server: {PROD_SERVER_URL}", result.stdout)

    def test_create_command_stage_server_url(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f"Server: {STAGE_SERVER_URL}", result.stdout)

    def test_create_command_alpha_filter_expression(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0a1").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"filter_expression": "{ALPHA_FILTER_EXPRESSION}"', result.stdout)

    def test_create_command_beta_filter_expression(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0b1").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"filter_expression": "{BETA_FILTER_EXPRESSION}"', result.stdout)

    def test_create_command_release_filter_expression(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)

    def test_create_command_lex_5050_esen(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(LEX_5050_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{LEX_5050_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{LEX_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{LEX_5050_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": "{OCTET_STREAM}"', result.stdout)

    def test_create_command_lex_esen(self):
        result = CreateCommand().with_server("stage").with_version("1.0").with_path(LEX_PATH).run()
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{LEX_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{LEX_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{LEX_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": "{OCTET_STREAM}"', result.stdout)

    def test_create_command_model_esen(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(MODEL_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{MODEL_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{MODEL_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{MODEL_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": "{OCTET_STREAM}"', result.stdout)

    def test_create_command_quality_model_esen(self):
        result = (
            CreateCommand()
            .with_server("stage")
            .with_version("1.0")
            .with_path(QUALITY_MODEL_PATH)
            .run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{QUALITY_MODEL_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{QUALITY_MODEL_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{QUALITY_MODEL_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": "{OCTET_STREAM}"', result.stdout)

    def test_create_command_srcvocab_esen(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(SRCVOCAB_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{SRCVOCAB_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{SRCVOCAB_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{SRCVOCAB_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": null', result.stdout)

    def test_create_command_trgvocab_esen(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(TRGVOCAB_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{TRGVOCAB_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{TRGVOCAB_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{TRGVOCAB_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": null', result.stdout)

    def test_create_command_vocab_esen(self):
        result = (
            CreateCommand().with_server("stage").with_version("1.0").with_path(VOCAB_PATH).run()
        )
        self.assertEqual(result.returncode, SUCCESS, f"The return code should be {SUCCESS}")
        self.assertEqual("", result.stderr, "The standard error stream should be empty")
        self.assertIn(f'"name": "{VOCAB_NAME}"', result.stdout)
        self.assertIn(f'"fromLang": "es"', result.stdout)
        self.assertIn(f'"toLang": "en"', result.stdout)
        self.assertIn(f'"version": "1.0"', result.stdout)
        self.assertIn(f'"fileType": "{VOCAB_TYPE}"', result.stdout)
        self.assertIn(f'"filter_expression": "{RELEASE_FILTER_EXPRESSION}"', result.stdout)
        self.assertIn(f'"path": "{VOCAB_PATH}"', result.stdout)
        self.assertIn(f'"mimeType": null', result.stdout)


if __name__ == "__main__":
    unittest.main()
