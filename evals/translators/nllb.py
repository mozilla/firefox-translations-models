import os

import torch
from transformers import AutoModelForSeq2SeqLM, AutoTokenizer
import sys
from mtdata import iso

from tqdm import tqdm
import toolz


device = torch.device("cuda" if torch.cuda.is_available() else "cpu")


LANG_CODE_MAP = {
    "ar": "arb_Arab",
    "az": "azj_Latn",
    "fa": "pes_Arab",
    "lv": "lvs_Latn",
    "zh": "zho_Hans",
}


def translate(texts, tokenizer, model, target):
    results = []

    if target in LANG_CODE_MAP:
        lang_code = LANG_CODE_MAP[target]
    else:
        lang_code = None
        for lang in tokenizer.additional_special_tokens:
            if lang.startswith(iso.iso3_code(target)):
                assert (
                    lang_code is None
                ), "Multiple NLLB language codes found for the same language ID, need to disambiguate!"
                lang_code = lang
        assert lang_code is not None, f"Lang code for {target} was not found"

    forced_bos_token_id = tokenizer.lang_code_to_id[lang_code]

    for partition in tqdm(list(toolz.partition_all(10, texts))):
        tokenized_src = tokenizer(partition, return_tensors="pt", padding=True).to(device)
        generated_tokens = model.generate(**tokenized_src, forced_bos_token_id=forced_bos_token_id)
        results += tokenizer.batch_decode(generated_tokens, skip_special_tokens=True)

    return results


if __name__ == "__main__":
    texts = [line.strip() for line in sys.stdin]

    source = os.environ["SRC"]
    target = os.environ["TRG"]

    tokenizer = AutoTokenizer.from_pretrained("facebook/nllb-200-distilled-600M", src_lang=source)
    model = AutoModelForSeq2SeqLM.from_pretrained("facebook/nllb-200-distilled-600M").to(device)

    translations = translate(texts, tokenizer, model, target)
    sys.stdout.write("\n".join(translations))
    sys.stdout.write("\n")
