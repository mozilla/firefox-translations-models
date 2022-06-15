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

| Translator/Dataset | en-uk | fa-en | ru-en | en-ru | uk-en | en-fa | is-en |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 28.00 | 28.70 | 33.37 | 30.47 | 35.65 | 17.30 | 23.50 |
| google | 32.40 (+4.40, +15.71%) | 36.05 (+7.35, +25.61%) | 36.53 (+3.15, +9.45%) | 33.72 (+3.25, +10.67%) | 38.90 (+3.25, +9.12%) | 27.70 (+10.40, +60.12%) | 34.95 (+11.45, +48.72%) |
| microsoft | 31.05 (+3.05, +10.89%) | 36.15 (+7.45, +25.96%) | 36.87 (+3.50, +10.49%) | 33.68 (+3.21, +10.53%) | 39.00 (+3.35, +9.40%) | 20.50 (+3.20, +18.50%) | 34.90 (+11.40, +48.51%) |

![Results](img/avg.png)

## en-uk

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 28.30 | 27.70 |
| google | 33.00 (+4.70, +16.61%) | 31.80 (+4.10, +14.80%) |
| microsoft | 31.40 (+3.10, +10.95%) | 30.70 (+3.00, +10.83%) |

![Results](img/en-uk.png)

## fa-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.10 | 28.30 |
| google | 36.70 (+7.60, +26.12%) | 35.40 (+7.10, +25.09%) |
| microsoft | 36.50 (+7.40, +25.43%) | 35.80 (+7.50, +26.50%) |

![Results](img/fa-en.png)

## ru-en

| Translator/Dataset | wmt17 | wmt18 | wmt14 | mtedx_test | wmt16 | wmt13 | wmt19 | wmt20 | flores-dev | flores-test | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 37.90 | 32.30 | 38.00 | 24.20 | 33.40 | 29.50 | 39.30 | 35.40 | 31.90 | 31.50 | 33.70 |
| google | 41.50 (+3.60, +9.50%) | 36.00 (+3.70, +11.46%) | 41.20 (+3.20, +8.42%) | 25.00 (+0.80, +3.31%) | 36.60 (+3.20, +9.58%) | 31.40 (+1.90, +6.44%) | 42.40 (+3.10, +7.89%) | 37.70 (+2.30, +6.50%) | 37.00 (+5.10, +15.99%) | 35.50 (+4.00, +12.70%) | 37.50 (+3.80, +11.28%) |
| microsoft | 41.60 (+3.70, +9.76%) | 36.90 (+4.60, +14.24%) | 41.70 (+3.70, +9.74%) | 26.10 (+1.90, +7.85%) | 37.60 (+4.20, +12.57%) | 31.20 (+1.70, +5.76%) | 42.60 (+3.30, +8.40%) | 37.80 (+2.40, +6.78%) | 36.20 (+4.30, +13.48%) | 36.10 (+4.60, +14.60%) | 37.80 (+4.10, +12.17%) |

![Results](img/ru-en.png)

## en-ru

| Translator/Dataset | wmt15 | flores-dev | wmt13 | wmt16 | wmt20 | flores-test | wmt19 | wmt17 | wmt18 | wmt14 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.80 | 30.20 | 26.70 | 31.60 | 22.00 | 29.10 | 31.70 | 34.10 | 29.00 | 38.50 |
| google | 35.00 (+3.20, +10.06%) | 33.60 (+3.40, +11.26%) | 27.60 (+0.90, +3.37%) | 34.00 (+2.40, +7.59%) | 26.40 (+4.40, +20.00%) | 33.60 (+4.50, +15.46%) | 32.20 (+0.50, +1.58%) | 37.30 (+3.20, +9.38%) | 34.10 (+5.10, +17.59%) | 43.40 (+4.90, +12.73%) |
| microsoft | 35.60 (+3.80, +11.95%) | 33.20 (+3.00, +9.93%) | 27.10 (+0.40, +1.50%) | 33.80 (+2.20, +6.96%) | 26.00 (+4.00, +18.18%) | 33.00 (+3.90, +13.40%) | 32.70 (+1.00, +3.15%) | 38.10 (+4.00, +11.73%) | 33.20 (+4.20, +14.48%) | 44.10 (+5.60, +14.55%) |

![Results](img/en-ru.png)

## uk-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 35.60 | 35.70 |
| google | 39.30 (+3.70, +10.39%) | 38.50 (+2.80, +7.84%) |
| microsoft | 39.10 (+3.50, +9.83%) | 38.90 (+3.20, +8.96%) |

![Results](img/uk-en.png)

## en-fa

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 17.20 | 17.40 |
| google | 27.20 (+10.00, +58.14%) | 28.20 (+10.80, +62.07%) |
| microsoft | 19.90 (+2.70, +15.70%) | 21.10 (+3.70, +21.26%) |

![Results](img/en-fa.png)

## is-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 23.60 | 23.40 |
| google | 35.50 (+11.90, +50.42%) | 34.40 (+11.00, +47.01%) |
| microsoft | 35.10 (+11.50, +48.73%) | 34.70 (+11.30, +48.29%) |

![Results](img/is-en.png)