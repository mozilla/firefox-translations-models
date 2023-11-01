import os

import torch
from transformers import MarianMTModel, MarianTokenizer
import sys

from tqdm import tqdm
import toolz

device = torch.device("cuda" if torch.cuda.is_available() else "cpu")

def translate(texts, tokenizer, model):
    results = []

    for partition in tqdm(list(toolz.partition_all(10, texts))):
        tokenized_src = tokenizer(partition, return_tensors="pt", padding=True)
        tokenized_src = {k: v.to(device) for k, v in tokenized_src.items()}
        generated_tokens = model.generate(**tokenized_src)
        results += tokenizer.batch_decode(generated_tokens, skip_special_tokens=True)

    return results


if __name__ == '__main__':
    texts = [line.strip() for line in sys.stdin]

    source = os.environ['SRC']
    target = os.environ['TRG']

    tokenizer = MarianTokenizer.from_pretrained(f"Helsinki-NLP/opus-mt-{source}-{target}")
    model = MarianMTModel.from_pretrained(f"Helsinki-NLP/opus-mt-{source}-{target}").to(device)

    translations = translate(texts, tokenizer, model)
    sys.stdout.write('\n'.join(translations))
    sys.stdout.write('\n')
