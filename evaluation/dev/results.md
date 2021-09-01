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

| Translator/Dataset | en-it | en-pt | ru-en | en-ru | it-en | pt-en |
| --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.53 | 46.55 | 33.37 | 28.40 | 32.30 | 43.43 |
| google | 29.47 (-0.07, -0.23%) | 56.05 (+9.50, +20.41%) | 36.53 (+3.15, +9.45%) | 33.72 (+5.32, +18.73%) | 34.50 (+2.20, +6.81%) | 45.77 (+2.33, +5.37%) |
| microsoft | 32.20 (+2.67, +9.03%) | 50.25 (+3.70, +7.95%) | 36.87 (+3.50, +10.49%) | 33.68 (+5.28, +18.59%) | 34.55 (+2.25, +6.97%) | 46.43 (+3.00, +6.91%) |

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
| bergamot | 28.80 | 29.70 | 28.20 | 26.50 | 35.30 | 31.60 | 21.00 | 25.20 | 30.00 | 27.70 |
| google | 34.00 (+5.20, +18.06%) | 35.00 (+5.30, +17.85%) | 33.60 (+5.40, +19.15%) | 34.10 (+7.60, +28.68%) | 43.40 (+8.10, +22.95%) | 37.30 (+5.70, +18.04%) | 26.40 (+5.40, +25.71%) | 27.60 (+2.40, +9.52%) | 32.20 (+2.20, +7.33%) | 33.60 (+5.90, +21.30%) |
| microsoft | 33.80 (+5.00, +17.36%) | 35.60 (+5.90, +19.87%) | 33.20 (+5.00, +17.73%) | 33.20 (+6.70, +25.28%) | 44.10 (+8.80, +24.93%) | 38.10 (+6.50, +20.57%) | 26.00 (+5.00, +23.81%) | 27.10 (+1.90, +7.54%) | 32.70 (+2.70, +9.00%) | 33.00 (+5.30, +19.13%) |

![Results](img/en-ru.png)

## it-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- | --- |
| bergamot | 35.50 | 30.70 | 29.90 | 33.10 |
| google | 35.90 (+0.40, +1.13%) | 33.40 (+2.70, +8.79%) | 33.30 (+3.40, +11.37%) | 35.40 (+2.30, +6.95%) |
| microsoft | 36.40 (+0.90, +2.54%) | 33.30 (+2.60, +8.47%) | 32.70 (+2.80, +9.36%) | 35.80 (+2.70, +8.16%) |

![Results](img/it-en.png)

## pt-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 39.70 | 45.90 | 44.70 |
| google | 38.90 (-0.80, -2.02%) | 49.50 (+3.60, +7.84%) | 48.90 (+4.20, +9.40%) |
| microsoft | 40.90 (+1.20, +3.02%) | 49.80 (+3.90, +8.50%) | 48.60 (+3.90, +8.72%) |

![Results](img/pt-en.png)