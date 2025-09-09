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
INHA_MODEL_NAME = "model.inha.intgemm8.bin"

BASE_ATTACHMENTS_PATH = "tests/remote_settings/attachments/base/encs"
BASE_MEMORY_ATTACHMENTS_PATH = "tests/remote_settings/attachments/base-memory/enes"
TINY_ATTACHMENTS_PATH = "tests/remote_settings/attachments/tiny/esen"
INVALID_HASH_ATTACHMENTS_PATH = "tests/remote_settings/attachments/tiny/inha"
INHA_PATH = f"{INVALID_HASH_ATTACHMENTS_PATH}/{INHA_MODEL_NAME}"
LEX_PATH = f"{TINY_ATTACHMENTS_PATH}/{LEX_NAME}"
LEX_5050_PATH = f"{TINY_ATTACHMENTS_PATH}/{LEX_5050_NAME}"
MODEL_PATH = f"{TINY_ATTACHMENTS_PATH}/{MODEL_NAME}"
QUALITY_MODEL_PATH = f"{TINY_ATTACHMENTS_PATH}/{QUALITY_MODEL_NAME}"
SRCVOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{SRCVOCAB_NAME}"
TRGVOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{TRGVOCAB_NAME}"
VOCAB_PATH = f"{TINY_ATTACHMENTS_PATH}/{VOCAB_NAME}"

COLLECTION_NAME = "translations-models-v2"
DEV_SERVER_URL = "https://remote-settings-dev.allizom.org/v1"
PROD_SERVER_URL = "https://remote-settings.mozilla.org/v1"
STAGE_SERVER_URL = "https://remote-settings.allizom.org/v1"
LOCAL_SERVER_URL = "http://localhost:8888/v1"

ALPHA_FILTER_EXPRESSION = "env.channel == 'default' || env.channel == 'nightly'"
ANDROID_FILTER_EXPRESSION = "env.appinfo.OS == 'Android'"
ALPHA_AND_ANDROID_FILTER_EXPRESSION = (
    "(env.channel == 'default' || env.channel == 'nightly') && env.appinfo.OS == 'Android'"
)
ALPHA_AND_DESKTOP_FILTER_EXPRESSION = (
    "(env.channel == 'default' || env.channel == 'nightly') && env.appinfo.OS != 'Android'"
)
BETA_AND_DESKTOP_FILTER_EXPRESSION = "(env.channel != 'release') && env.appinfo.OS != 'Android'"
BETA_AND_ANDROID_FILTER_EXPRESSION = "(env.channel != 'release') && env.appinfo.OS == 'Android'"
BETA_FILTER_EXPRESSION = "env.channel != 'release'"
DESKTOP_FILTER_EXPRESSION = "env.appinfo.OS != 'Android'"
RELEASE_FILTER_EXPRESSION = ""

ZSTD_MIMETYPE = "application/zstd"

HASH_BASE_ENCS_LEX = "c530879ef492caf24850d65f58d1035f566040ab3e9fda90d16c6e9b7a76b541"
HASH_BASE_ENCS_VOCAB = "2e983ee9870947f51330515ceb2b5876a8318777f658ba5ae89053aa61843cdb"
HASH_BASE_MEMORY_ENES_LEX_50_50 = (
    "a918703c754e8d23d375ede5e98d39067f222955adf3a5561830dbe6dc84a987"
)
HASH_BASE_MEMORY_ENES_LEX = "680ac8b545256a98de318967e04bd33980a27f2c6ab121ba1f118867f84b69f6"
HASH_BASE_MEMORY_ENES_QUALITY_MODEL = (
    "8e40bd80dfcb2c2b5026c8778db646396a24b0ff9cb5310a185f5df7e3bb5c1b"
)
HASH_BASE_MEMORY_ENES_SRCVOCAB = "16e72113efd2e6afa5d39a7358f26fce71562ee040db3529fcafba6fd8a630de"
HASH_BASE_MEMORY_ENES_TRGVOCAB = "640f4c61a213ae32a8f7e70b5ed438500f1ef79471f9d0cba52de6ab32ca2550"
HASH_BASE_MEMORY_ENES_VOCAB = "8897ed2fb14538dd7deab98474e86df03906ad1e8837ae80e30297e74efec093"
HASH_TINY_ESEN_LEX_50_50 = "f528f07e8cf7e35ef440655a4ceb76dd9b2012b20323e5db1606cd9b0372ecae"
HASH_TINY_ESEN_LEX = "69d814ca36482572f354dd4067475be55dcf88b3377a81c5d640c289adc1e838"
HASH_TINY_ESEN_QUALITY_MODEL = "79e6eaa2bfbe5603dbd1b4d33936e87ca6fddb71b35d1359e4c4f1507a7335ca"
HASH_TINY_ESEN_SRCVOCAB = "2acc5f75cdaa3df276ec8b9440b582cd5e1b8cf2f19860992e334438b5f57a2b"
HASH_TINY_ESEN_TRGVOCAB = "35aaa1e05ed0c78c57d21647aa70debb8bf3b22fcd42542b2948b7460ed93979"
HASH_TINY_ESEN_VOCAB = "19d30d5a26a22c964368e44947808888ecab565381dc4c9b8bd4da1374d05757"


def next_minor_version(current):
    parsed = version.parse(current)
    return f"{parsed.major}.{parsed.minor + 1}"
