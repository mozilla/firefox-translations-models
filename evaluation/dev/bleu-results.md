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
2. **google** - uses Google Translation [API](https://cloud.google.com/translate)
3. **microsoft** - uses Azure Cognitive Services Translator [API](https://azure.microsoft.com/en-us/services/cognitive-services/translator/)

Translation quality of Marian and Bergamot is supposed to be very similar.

## Method

We use official WMT ([Conference on Machine Translation](http://statmt.org/wmt21/)) parallel datasets. Available datasets are discovered automatically based on a language pair.

We perform translation from source to target language using one of three translation systems and then compare the result with the dataset reference and calculate BLEU score.

Evaluation is done using [SacreBLEU](https://github.com/mjpost/sacrebleu) tool which is reliable and widely used in academic world.

Both absolute and relative differences in BLEU scores between Bergamot and other systems are reported.

# Evaluation results

`avg` = average on all datasets



## avg

| Translator/Dataset | en-ru | ru-en | en-nl | fa-en | uk-en | en-fa | is-en | nl-en | en-uk |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.44 | 33.69 | 27.30 | 28.70 | 35.93 | 17.30 | 23.40 | 29.65 | 26.30 |
| google | 34.49 (+5.05, +17.15%) | 38.20 (+4.51, +13.38%) | 29.30 (+2.00, +7.33%) | 40.85 (+12.15, +42.33%) | 42.43 (+6.50, +18.09%) | 27.80 (+10.50, +60.69%) | 38.90 (+15.50, +66.24%) | 33.05 (+3.40, +11.47%) | 32.63 (+6.33, +24.08%) |
| microsoft | 33.62 (+4.18, +14.21%) | 38.38 (+4.68, +13.90%) | 28.80 (+1.50, +5.49%) | 36.15 (+7.45, +25.96%) | 42.30 (+6.37, +17.72%) | 20.50 (+3.20, +18.50%) | 38.17 (+14.77, +63.11%) | 32.60 (+2.95, +9.95%) | 32.03 (+5.73, +21.80%) |

![Results](img/avg-bleu.png)
---

## en-ru

| Translator/Dataset | wmt20 | wmt13 | flores-test | flores-dev | wmt21 | wmt19 | wmt17 | wmt16 | wmt15 | wmt14 | wmt22 | wmt18 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 22.00 | 26.20 | 29.20 | 29.90 | 25.50 | 31.40 | 33.60 | 30.90 | 31.40 | 38.20 | 26.50 | 28.50 |
| google | 27.20 (+5.20, +23.64%) | 28.00 (+1.80, +6.87%) | 34.40 (+5.20, +17.81%) | 34.90 (+5.00, +16.72%) | 30.00 (+4.50, +17.65%) | 32.90 (+1.50, +4.78%) | 38.90 (+5.30, +15.77%) | 35.00 (+4.10, +13.27%) | 36.90 (+5.50, +17.52%) | 45.70 (+7.50, +19.63%) | 35.00 (+8.50, +32.08%) | 35.00 (+6.50, +22.81%) |
| microsoft | 26.30 (+4.30, +19.55%) | 27.30 (+1.10, +4.20%) | 33.60 (+4.40, +15.07%) | 33.50 (+3.60, +12.04%) | 29.20 (+3.70, +14.51%) | 33.20 (+1.80, +5.73%) | 38.60 (+5.00, +14.88%) | 34.20 (+3.30, +10.68%) | 36.10 (+4.70, +14.97%) | 44.70 (+6.50, +17.02%) | 33.10 (+6.60, +24.91%) | 33.70 (+5.20, +18.25%) |

![Results](img/en-ru-bleu.png)
---

## ru-en

| Translator/Dataset | flores-dev | mtedx_test | wmt18 | wmt20 | wmt19 | wmt15 | wmt17 | wmt14 | wmt16 | wmt22 | wmt13 | flores-test | wmt21 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.90 | 24.00 | 31.90 | 35.00 | 39.10 | 33.50 | 37.60 | 37.80 | 33.00 | 38.50 | 29.30 | 31.00 | 35.40 |
| google | 38.40 (+6.50, +20.38%) | 25.10 (+1.10, +4.58%) | 37.30 (+5.40, +16.93%) | 38.40 (+3.40, +9.71%) | 42.80 (+3.70, +9.46%) | 38.60 (+5.10, +15.22%) | 42.70 (+5.10, +13.56%) | 42.70 (+4.90, +12.96%) | 37.60 (+4.60, +13.94%) | 43.70 (+5.20, +13.51%) | 32.20 (+2.90, +9.90%) | 37.30 (+6.30, +20.32%) | 39.80 (+4.40, +12.43%) |
| microsoft | 36.50 (+4.60, +14.42%) | 26.20 (+2.20, +9.17%) | 37.40 (+5.50, +17.24%) | 38.80 (+3.80, +10.86%) | 43.80 (+4.70, +12.02%) | 38.50 (+5.00, +14.93%) | 43.70 (+6.10, +16.22%) | 44.10 (+6.30, +16.67%) | 38.40 (+5.40, +16.36%) | 43.90 (+5.40, +14.03%) | 32.50 (+3.20, +10.92%) | 36.10 (+5.10, +16.45%) | 39.00 (+3.60, +10.17%) |

![Results](img/ru-en-bleu.png)
---

## en-nl

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 27.00 | 27.60 |
| google | 29.20 (+2.20, +8.15%) | 29.40 (+1.80, +6.52%) |
| microsoft | 28.60 (+1.60, +5.93%) | 29.00 (+1.40, +5.07%) |

![Results](img/en-nl-bleu.png)
---

## fa-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.10 | 28.30 |
| google | 42.00 (+12.90, +44.33%) | 39.70 (+11.40, +40.28%) |
| microsoft | 36.50 (+7.40, +25.43%) | 35.80 (+7.50, +26.50%) |

![Results](img/fa-en-bleu.png)
---

## uk-en

| Translator/Dataset | flores-dev | wmt22 | flores-test |
| --- | --- | --- | --- |
| bergamot | 35.60 | 36.60 | 35.60 |
| google | 43.10 (+7.50, +21.07%) | 41.60 (+5.00, +13.66%) | 42.60 (+7.00, +19.66%) |
| microsoft | 41.80 (+6.20, +17.42%) | 44.40 (+7.80, +21.31%) | 40.70 (+5.10, +14.33%) |

![Results](img/uk-en-bleu.png)
---

## en-fa

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 17.20 | 17.40 |
| google | 27.20 (+10.00, +58.14%) | 28.40 (+11.00, +63.22%) |
| microsoft | 19.90 (+2.70, +15.70%) | 21.10 (+3.70, +21.26%) |

![Results](img/en-fa-bleu.png)
---

## is-en

| Translator/Dataset | flores-dev | flores-test | wmt21 |
| --- | --- | --- | --- |
| bergamot | 23.60 | 23.40 | 23.20 |
| google | 39.40 (+15.80, +66.95%) | 38.60 (+15.20, +64.96%) | 38.70 (+15.50, +66.81%) |
| microsoft | 37.30 (+13.70, +58.05%) | 36.70 (+13.30, +56.84%) | 40.50 (+17.30, +74.57%) |

![Results](img/is-en-bleu.png)
---

## nl-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.70 | 29.60 |
| google | 33.00 (+3.30, +11.11%) | 33.10 (+3.50, +11.82%) |
| microsoft | 32.40 (+2.70, +9.09%) | 32.80 (+3.20, +10.81%) |

![Results](img/nl-en-bleu.png)
---

## en-uk

| Translator/Dataset | flores-test | wmt22 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 28.20 | 22.80 | 27.90 |
| google | 33.10 (+4.90, +17.38%) | 32.00 (+9.20, +40.35%) | 32.80 (+4.90, +17.56%) |
| microsoft | 33.50 (+5.30, +18.79%) | 30.40 (+7.60, +33.33%) | 32.20 (+4.30, +15.41%) |

![Results](img/en-uk-bleu.png)
---