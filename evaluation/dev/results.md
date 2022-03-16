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

| Translator/Dataset | en-it | en-pt | ru-en | en-ru | en-fa | fa-en | is-en | it-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.53 | 46.55 | 33.37 | 30.47 | 17.30 | 28.70 | 23.50 | 32.30 |
| google | 29.47 (-0.07, -0.23%) | 56.05 (+9.50, +20.41%) | 36.53 (+3.15, +9.45%) | 33.72 (+3.25, +10.67%) | 27.70 (+10.40, +60.12%) | 36.05 (+7.35, +25.61%) | 34.95 (+11.45, +48.72%) | 34.50 (+2.20, +6.81%) |
| microsoft | 32.20 (+2.67, +9.03%) | 50.25 (+3.70, +7.95%) | 36.87 (+3.50, +10.49%) | 33.68 (+3.21, +10.53%) | 20.50 (+3.20, +18.50%) | 36.15 (+7.45, +25.96%) | 34.90 (+11.40, +48.51%) | 34.55 (+2.25, +6.97%) |

![Results](img/avg.png)

## en-it

| Translator/Dataset | flores-test | flores-dev | wmt09 |
| --- | --- | --- | --- |
| bergamot | 29.20 | 28.40 | 31.00 |
| google | 30.10 (+0.90, +3.08%) | 29.00 (+0.60, +2.11%) | 29.30 (-1.70, -5.48%) |
| microsoft | 32.00 (+2.80, +9.59%) | 31.00 (+2.60, +9.15%) | 33.60 (+2.60, +8.39%) |

![Results](img/en-it.png)

## en-pt

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 46.20 | 46.90 |
| google | 55.70 (+9.50, +20.56%) | 56.40 (+9.50, +20.26%) |
| microsoft | 50.70 (+4.50, +9.74%) | 49.80 (+2.90, +6.18%) |

![Results](img/en-pt.png)

## ru-en

| Translator/Dataset | mtedx_test | wmt19 | wmt17 | flores-dev | flores-test | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.20 | 39.30 | 37.90 | 31.90 | 31.50 | 38.00 | 33.70 | 33.40 | 29.50 | 32.30 | 35.40 |
| google | 25.00 (+0.80, +3.31%) | 42.40 (+3.10, +7.89%) | 41.50 (+3.60, +9.50%) | 37.00 (+5.10, +15.99%) | 35.50 (+4.00, +12.70%) | 41.20 (+3.20, +8.42%) | 37.50 (+3.80, +11.28%) | 36.60 (+3.20, +9.58%) | 31.40 (+1.90, +6.44%) | 36.00 (+3.70, +11.46%) | 37.70 (+2.30, +6.50%) |
| microsoft | 26.10 (+1.90, +7.85%) | 42.60 (+3.30, +8.40%) | 41.60 (+3.70, +9.76%) | 36.20 (+4.30, +13.48%) | 36.10 (+4.60, +14.60%) | 41.70 (+3.70, +9.74%) | 37.80 (+4.10, +12.17%) | 37.60 (+4.20, +12.57%) | 31.20 (+1.70, +5.76%) | 36.90 (+4.60, +14.24%) | 37.80 (+2.40, +6.78%) |

![Results](img/ru-en.png)

## en-ru

| Translator/Dataset | wmt16 | wmt15 | flores-dev | wmt18 | wmt14 | wmt17 | wmt20 | wmt13 | wmt19 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.60 | 31.80 | 30.20 | 29.00 | 38.50 | 34.10 | 22.00 | 26.70 | 31.70 | 29.10 |
| google | 34.00 (+2.40, +7.59%) | 35.00 (+3.20, +10.06%) | 33.60 (+3.40, +11.26%) | 34.10 (+5.10, +17.59%) | 43.40 (+4.90, +12.73%) | 37.30 (+3.20, +9.38%) | 26.40 (+4.40, +20.00%) | 27.60 (+0.90, +3.37%) | 32.20 (+0.50, +1.58%) | 33.60 (+4.50, +15.46%) |
| microsoft | 33.80 (+2.20, +6.96%) | 35.60 (+3.80, +11.95%) | 33.20 (+3.00, +9.93%) | 33.20 (+4.20, +14.48%) | 44.10 (+5.60, +14.55%) | 38.10 (+4.00, +11.73%) | 26.00 (+4.00, +18.18%) | 27.10 (+0.40, +1.50%) | 32.70 (+1.00, +3.15%) | 33.00 (+3.90, +13.40%) |

![Results](img/en-ru.png)

## en-fa

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 17.40 | 17.20 |
| google | 28.20 (+10.80, +62.07%) | 27.20 (+10.00, +58.14%) |
| microsoft | 21.10 (+3.70, +21.26%) | 19.90 (+2.70, +15.70%) |

![Results](img/en-fa.png)

## fa-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.10 | 28.30 |
| google | 36.70 (+7.60, +26.12%) | 35.40 (+7.10, +25.09%) |
| microsoft | 36.50 (+7.40, +25.43%) | 35.80 (+7.50, +26.50%) |

![Results](img/fa-en.png)

## is-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 23.60 | 23.40 |
| google | 35.50 (+11.90, +50.42%) | 34.40 (+11.00, +47.01%) |
| microsoft | 35.10 (+11.50, +48.73%) | 34.70 (+11.30, +48.29%) |

![Results](img/is-en.png)

## it-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- | --- |
| bergamot | 35.50 | 30.70 | 29.90 | 33.10 |
| google | 35.90 (+0.40, +1.13%) | 33.40 (+2.70, +8.79%) | 33.30 (+3.40, +11.37%) | 35.40 (+2.30, +6.95%) |
| microsoft | 36.40 (+0.90, +2.54%) | 33.30 (+2.60, +8.47%) | 32.70 (+2.80, +9.36%) | 35.80 (+2.70, +8.16%) |

![Results](img/it-en.png)