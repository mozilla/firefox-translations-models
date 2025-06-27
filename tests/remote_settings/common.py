from packaging import version


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

LEX_NAME = "lex.esen.s2t.bin"
LEX_5050_NAME = "lex.50.50.esen.s2t.bin"
MODEL_NAME = "model.esen.intgemm8.bin"
QUALITY_MODEL_NAME = "qualityModel.esen.bin"
SRCVOCAB_NAME = "srcvocab.esen.spm"
TRGVOCAB_NAME = "trgvocab.esen.spm"
VOCAB_NAME = "vocab.esen.spm"

BASE_ATTACHMENTS_PATH = "tests/remote_settings/attachments/base/encs"
BASE_MEMORY_ATTACHMENTS_PATH = "tests/remote_settings/attachments/base-memory/enes"
TINY_ATTACHMENTS_PATH = "tests/remote_settings/attachments/tiny/esen"
LEX_PATH = f"{TINY_ATTACHMENTS_PATH}/{LEX_NAME}"
LEX_5050_PATH = f"{TINY_ATTACHMENTS_PATH}/{LEX_5050_NAME}"
MODEL_PATH = f"{TINY_ATTACHMENTS_PATH}/{MODEL_NAME}"
QUALITY_MODEL_PATH = f"{TINY_ATTACHMENTS_PATH}/{QUALITY_MODEL_NAME}"
SRCVOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{SRCVOCAB_NAME}"
TRGVOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{TRGVOCAB_NAME}"
VOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{VOCAB_NAME}"

DEV_SERVER_URL = "https://remote-settings-dev.allizom.org/v1"
PROD_SERVER_URL = "https://remote-settings.mozilla.org/v1"
STAGE_SERVER_URL = "https://remote-settings.allizom.org/v1"
LOCAL_SERVER_URL = "http://localhost:8888/v1"

ALPHA_FILTER_EXPRESSION = "env.channel == 'default' || env.channel == 'nightly'"
BETA_FILTER_EXPRESSION = "env.channel != 'release'"
RELEASE_FILTER_EXPRESSION = ""

OCTET_STREAM = "application/octet-stream"


def next_minor_version(current):
    parsed = version.parse(current)
    return f"{parsed.major}.{parsed.minor + 1}"
