# What is BLEU

[BLEU (BiLingual Evaluation Understudy)](https://en.wikipedia.org/wiki/BLEU) is a metric for automatically evaluating machine-translated text. The BLEU score is a number between zero and one that measures the similarity of the machine-translated text to a set of high quality reference translations. A value of 0 means that the machine-translated output has no overlap with the reference translation (low quality) while a value of 1 means there is perfect overlap with the reference translations (high quality).

It has been shown that BLEU scores correlate well with human judgment of translation quality. Note that even human translators do not achieve a perfect score of 1.0.

BLEU scores are expressed as a percentage rather than a decimal between 0 and 1.
Trying to compare BLEU scores across different corpora and languages is strongly discouraged. Even comparing BLEU scores for the same corpus but with different numbers of reference translations can be highly misleading.

However, as a rough guideline, the following interpretation of BLEU scores (expressed as percentages rather than decimals) might be helpful.

BLEU Score |	Interpretation
--- | ---
< 10 |	Almost useless
10 - 19 |	Hard to get the gist
20 - 29 |	The gist is clear, but has significant grammatical errors
30 - 40 |	Understandable to good translations
40 - 50 |	High quality translations
50 - 60 |	Very high quality, adequate, and fluent translations
\> 60 |	Quality often better than human

[More mathematical details](https://cloud.google.com/translate/automl/docs/evaluate#the_mathematical_details)

Source: https://cloud.google.com/translate/automl/docs/evaluate#bleu


BLEU is the most popular becnhmark in academia, so using BLEU allows us also to compare with reserach papers results and competitions (see [Conference on Machine Translation Conference (WMT)](http://statmt.org/wmt21/)).

Read [this article](https://www.rws.com/blog/understanding-mt-quality-bleu-scores/) to better understand what BLEU is and why it is not perfect.

# What are these benchmarks

## Translators

1. **bergamot** - uses compiled  [bergamot-translator](https://github.com/mozilla/bergamot-translator)  (wrapper for marian that is used by Firefox Translations web extension)
2. **marian** - uses compiled [marian](https://github.com/marian-nmt/marian-dev) (translation engine bergamot-translator is based on)
3. **google** - uses Google Translation [API](https://cloud.google.com/translate)
4. **microsoft** - uses Azure Cognitive Services Translator [API](https://azure.microsoft.com/en-us/services/cognitive-services/translator/)

Translation quality of Marian and Bergamot is supposed to be very similar.

## Method

We use official WMT ([Conference on Machine Translation](http://statmt.org/wmt21/)) parallel datasets. Available datsets are discovered automatically based on a language pair.

We perform translation from source to target langauge using one of 4 translation systems and then compare the result with the dataset reference and calculate BLEU score.

Evaluation is done using [SacreBLEU](https://github.com/mjpost/sacrebleu) tool which is reliable and widely used in academic world.

Both absolute and relative differences in BLEU scores between Bergamot and other systems are reported.

# Evaluation results

`avg` = average on all datasets



## avg

| Translator/Dataset | ru-en |
| --- | --- |
| bergamot | 32.39 |
| google | 36.59 (+4.20, +12.97%) |
| microsoft | 37.03 (+4.64, +14.34%) |

![Results](img/avg.png)

## ru-en

| Translator/Dataset | mtedx_test | wmt19 | wmt17 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 23.00 | 37.90 | 35.90 | 35.60 | 32.50 | 32.10 | 28.80 | 31.30 | 34.40 |
| google | 25.00 (+2.00, +8.70%) | 42.40 (+4.50, +11.87%) | 41.50 (+5.60, +15.60%) | 41.20 (+5.60, +15.73%) | 37.50 (+5.00, +15.38%) | 36.60 (+4.50, +14.02%) | 31.40 (+2.60, +9.03%) | 36.00 (+4.70, +15.02%) | 37.70 (+3.30, +9.59%) |
| microsoft | 26.10 (+3.10, +13.48%) | 42.60 (+4.70, +12.40%) | 41.60 (+5.70, +15.88%) | 41.70 (+6.10, +17.13%) | 37.80 (+5.30, +16.31%) | 37.60 (+5.50, +17.13%) | 31.20 (+2.40, +8.33%) | 36.90 (+5.60, +17.89%) | 37.80 (+3.40, +9.88%) |

![Results](img/ru-en.png)