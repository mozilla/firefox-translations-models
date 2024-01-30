# Pricing
# https://cloud.google.com/translate/pricing

import os
import time

from google.cloud import translate_v2
from google.api_core.exceptions import ServiceUnavailable
import sys

from tqdm import tqdm
import toolz

translate_client = translate_v2.Client()


def translate(texts):
    """Translates text into the target language.

    Texts must be an ISO 639-1 language code.
    See https://g.co/cloud/translate/v2/translate-reference#supported_languages
    """
    source = os.environ["SRC"]
    target = os.environ["TRG"]

    def do_translate(partition):
        try:
            return translate_client.translate(
                partition, target_language=target, source_language=source
            )
        except ServiceUnavailable:
            return None

    results = []
    # decrease partition size if hitting limit of max 204800 bytes per request
    for partition in tqdm(list(toolz.partition_all(77, texts))):
        for _ in range(7):
            response = do_translate(partition)
            if response is not None:
                break

            time.sleep(60)

        results += [r["translatedText"] for r in response]

    return results


if __name__ == "__main__":
    texts = [line.strip() for line in sys.stdin]
    translations = translate(texts)
    sys.stdout.write("\n".join(translations))
    sys.stdout.write("\n")
