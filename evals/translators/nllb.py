import os

import torch
from transformers import AutoModelForSeq2SeqLM, AutoTokenizer
import sys

from tqdm import tqdm
import toolz


lang_to_lang_code = {
    "bg": "bul_Cyrl",
    "ca": "cat_Latn",
    "cs": "ces_Latn",
    "de": "deu_Latn",
    "en": "eng_Latn",
    "es": "spa_Latn",
    "et": "est_Latn",
    "fa": "pes_Arab",
    "fi": "fin_Latn",
    "fr": "fra_Latn",
    "hu": "hun_Latn",
    "is": "isl_Latn",
    "it": "ita_Latn",
    "nb": "nob_Latn",
    "nl": "nld_Latn",
    "nn": "nno_Latn",
    "pl": "pol_Latn",
    "pt": "por_Latn",
    "ru": "rus_Cyrl",
    "uk": "ukr_Cyrl",
}

device = torch.device("cuda" if torch.cuda.is_available() else "cpu")

def translate(texts, tokenizer, model, target):
    results = []

    forced_bos_token_id=tokenizer.lang_code_to_id[lang_to_lang_code[target]]

    for partition in tqdm(list(toolz.partition_all(10, texts))):
        tokenized_src = tokenizer(partition, return_tensors="pt", padding=True)
        tokenized_src = {k: v.to(device) for k, v in tokenized_src.items()}
        generated_tokens = model.generate(**tokenized_src, forced_bos_token_id=forced_bos_token_id)
        results += tokenizer.batch_decode(generated_tokens, skip_special_tokens=True)

    return results


if __name__ == '__main__':
    texts = [line.strip() for line in sys.stdin]

    source = os.environ['SRC']
    target = os.environ['TRG']

    tokenizer = AutoTokenizer.from_pretrained("facebook/nllb-200-distilled-600M", src_lang=source)
    model = AutoModelForSeq2SeqLM.from_pretrained("facebook/nllb-200-distilled-600M").to(device)

    translations = translate(texts, tokenizer, model, target)
    sys.stdout.write('\n'.join(translations))
    sys.stdout.write('\n')
