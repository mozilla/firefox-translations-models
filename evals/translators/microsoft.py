# Pricing:
# https://azure.microsoft.com/en-us/pricing/details/cognitive-services/translator/

import requests, uuid
import os
import sys
import toolz
from tqdm import tqdm


subscription_key = os.environ['AZURE_TRANSLATOR_KEY']
location = os.getenv("AZURE_LOCATION", 'global')
url = "https://api.cognitive.microsofttranslator.com/translate"
headers = {
    'Ocp-Apim-Subscription-Key': subscription_key,
    'Ocp-Apim-Subscription-Region': location,
    'Content-type': 'application/json',
    'X-ClientTraceId': str(uuid.uuid4())
}


def translate(texts):
    source = os.environ['SRC']
    target = os.environ['TRG']

    params = {
        'api-version': '3.0',
        'from': source,
        'to': [target]
    }

    results = []
    # decrease partition size if hitting limit of max 10000 characters per request
    for partition in tqdm(list(toolz.partition_all(20, texts))):
        body = [{'text': text} for text in partition]
        response = requests.post(url, params=params, headers=headers, json=body)

        if response.status_code != 200:
            raise ValueError(f'Incorrect response. code: {response.status_code} body: {response.json()}')

        results += [r['translations'][0]['text'] for r in response.json()]

    return results


if __name__ == '__main__':
    texts = [line.strip() for line in sys.stdin]
    translations = translate(texts)
    sys.stdout.write('\n'.join(translations))
    sys.stdout.write('\n')
