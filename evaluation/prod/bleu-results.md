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

| Translator/Dataset | cs-en | en-et | en-it | fr-en | en-pt | et-en | nb-en | bg-en | en-es | en-bg | en-cs | de-en | it-en | pl-en | en-fr | en-pl | pt-en | es-en | en-de |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.07 | 25.50 | 29.77 | 35.43 | 49.85 | 32.37 | 37.60 | 38.50 | 32.41 | 42.10 | 24.76 | 33.16 | 32.67 | 27.87 | 36.01 | 22.27 | 44.87 | 32.38 | 32.01 |
| google | 33.36 (+2.29, +7.36%) | 28.60 (+3.10, +12.16%) | 28.97 (-0.80, -2.69%) | 37.81 (+2.38, +6.70%) | 53.75 (+3.90, +7.82%) | 35.80 (+3.43, +10.61%) | 42.05 (+4.45, +11.84%) | 41.30 (+2.80, +7.27%) | 34.74 (+2.32, +7.17%) | 44.60 (+2.50, +5.94%) | 27.72 (+2.96, +11.95%) | 35.65 (+2.49, +7.52%) | 34.50 (+1.83, +5.59%) | 31.23 (+3.37, +12.08%) | 29.47 (-6.54, -18.15%) | 25.50 (+3.23, +14.52%) | 46.60 (+1.73, +3.86%) | 33.64 (+1.27, +3.91%) | 33.16 (+1.14, +3.58%) |
| microsoft | 34.67 (+3.61, +11.61%) | 28.47 (+2.97, +11.63%) | 32.30 (+2.53, +8.51%) | 39.13 (+3.70, +10.44%) | 50.15 (+0.30, +0.60%) | 36.17 (+3.80, +11.74%) | 42.90 (+5.30, +14.10%) | 41.20 (+2.70, +7.01%) | 33.76 (+1.35, +4.17%) | 38.55 (-3.55, -8.43%) | 28.26 (+3.50, +14.14%) | 37.73 (+4.57, +13.79%) | 34.55 (+1.88, +5.74%) | 31.83 (+3.97, +14.23%) | 36.48 (+0.47, +1.31%) | 24.83 (+2.57, +11.53%) | 46.47 (+1.60, +3.57%) | 32.93 (+0.56, +1.72%) | 33.54 (+1.53, +4.79%) |

![Results](img/avg-bleu.png)
---

## cs-en

| Translator/Dataset | wmt08 | wmt17 | wmt10 | flores-dev | wmt22 | flores-test | wmt12 | wmt11 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt09 | wmt21 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.50 | 30.20 | 28.20 | 35.30 | 44.50 | 35.30 | 26.50 | 28.10 | 35.00 | 32.00 | 33.40 | 30.30 | 31.30 | 27.60 | 27.90 | 27.00 |
| google | 26.30 (+1.80, +7.35%) | 31.20 (+1.00, +3.31%) | 30.50 (+2.30, +8.16%) | 38.60 (+3.30, +9.35%) | 49.40 (+4.90, +11.01%) | 39.00 (+3.70, +10.48%) | 28.60 (+2.10, +7.92%) | 30.20 (+2.10, +7.47%) | 38.00 (+3.00, +8.57%) | 33.60 (+1.60, +5.00%) | 34.80 (+1.40, +4.19%) | 32.40 (+2.10, +6.93%) | 32.10 (+0.80, +2.56%) | 29.90 (+2.30, +8.33%) | 30.70 (+2.80, +10.04%) | 28.40 (+1.40, +5.19%) |
| microsoft | 26.40 (+1.90, +7.76%) | 33.60 (+3.40, +11.26%) | 30.70 (+2.50, +8.87%) | 40.00 (+4.70, +13.31%) | 54.90 (+10.40, +23.37%) | 40.30 (+5.00, +14.16%) | 29.70 (+3.20, +12.08%) | 30.90 (+2.80, +9.96%) | 39.90 (+4.90, +14.00%) | 34.70 (+2.70, +8.44%) | 38.30 (+4.90, +14.67%) | 33.40 (+3.10, +10.23%) | 34.30 (+3.00, +9.58%) | 29.60 (+2.00, +7.25%) | 30.50 (+2.60, +9.32%) | 27.60 (+0.60, +2.22%) |

![Results](img/cs-en-bleu.png)
---

## en-et

| Translator/Dataset | flores-dev | flores-test | wmt18 |
| --- | --- | --- | --- |
| bergamot | 25.60 | 25.70 | 25.20 |
| google | 30.20 (+4.60, +17.97%) | 29.00 (+3.30, +12.84%) | 26.60 (+1.40, +5.56%) |
| microsoft | 28.60 (+3.00, +11.72%) | 29.20 (+3.50, +13.62%) | 27.60 (+2.40, +9.52%) |

![Results](img/en-et-bleu.png)
---

## en-it

| Translator/Dataset | flores-test | flores-dev | wmt09 |
| --- | --- | --- | --- |
| bergamot | 29.30 | 29.20 | 30.80 |
| google | 29.60 (+0.30, +1.02%) | 28.50 (-0.70, -2.40%) | 28.80 (-2.00, -6.49%) |
| microsoft | 32.10 (+2.80, +9.56%) | 31.10 (+1.90, +6.51%) | 33.70 (+2.90, +9.42%) |

![Results](img/en-it-bleu.png)
---

## fr-en

| Translator/Dataset | wmt08 | mtedx_test | iwslt17 | wmt10 | flores-dev | flores-test | wmt12 | wmt11 | wmt14 | wmt15 | wmt13 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.50 | 42.80 | 39.80 | 31.40 | 43.80 | 42.10 | 31.90 | 32.00 | 37.30 | 37.20 | 33.30 | 29.10 |
| google | 26.60 (+2.10, +8.57%) | 42.70 (-0.10, -0.23%) | 40.60 (+0.80, +2.01%) | 34.10 (+2.70, +8.60%) | 48.70 (+4.90, +11.19%) | 46.70 (+4.60, +10.93%) | 33.80 (+1.90, +5.96%) | 34.30 (+2.30, +7.19%) | 40.60 (+3.30, +8.85%) | 39.90 (+2.70, +7.26%) | 34.50 (+1.20, +3.60%) | 31.20 (+2.10, +7.22%) |
| microsoft | 27.40 (+2.90, +11.84%) | 46.40 (+3.60, +8.41%) | 41.80 (+2.00, +5.03%) | 35.00 (+3.60, +11.46%) | 48.90 (+5.10, +11.64%) | 47.00 (+4.90, +11.64%) | 34.60 (+2.70, +8.46%) | 35.20 (+3.20, +10.00%) | 42.30 (+5.00, +13.40%) | 42.70 (+5.50, +14.78%) | 36.10 (+2.80, +8.41%) | 32.20 (+3.10, +10.65%) |

![Results](img/fr-en-bleu.png)
---

## en-pt

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 50.30 | 49.40 |
| google | 53.90 (+3.60, +7.16%) | 53.60 (+4.20, +8.50%) |
| microsoft | 50.70 (+0.40, +0.80%) | 49.60 (+0.20, +0.40%) |

![Results](img/en-pt-bleu.png)
---

## et-en

| Translator/Dataset | flores-dev | flores-test | wmt18 |
| --- | --- | --- | --- |
| bergamot | 33.50 | 32.70 | 30.90 |
| google | 38.30 (+4.80, +14.33%) | 37.00 (+4.30, +13.15%) | 32.10 (+1.20, +3.88%) |
| microsoft | 37.40 (+3.90, +11.64%) | 37.00 (+4.30, +13.15%) | 34.10 (+3.20, +10.36%) |

![Results](img/et-en-bleu.png)
---

## nb-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 37.40 | 37.80 |
| google | 41.80 (+4.40, +11.76%) | 42.30 (+4.50, +11.90%) |
| microsoft | 42.70 (+5.30, +14.17%) | 43.10 (+5.30, +14.02%) |

![Results](img/nb-en-bleu.png)
---

## bg-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 39.10 | 37.90 |
| google | 41.90 (+2.80, +7.16%) | 40.70 (+2.80, +7.39%) |
| microsoft | 42.10 (+3.00, +7.67%) | 40.30 (+2.40, +6.33%) |

![Results](img/bg-en-bleu.png)
---

## en-es

| Translator/Dataset | wmt08 | wmt11 | wmt09 | flores-dev | wmt10 | wmt13 | wmt12 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.00 | 37.90 | 29.90 | 25.90 | 36.70 | 34.80 | 38.90 | 26.20 |
| google | 30.00 (+1.00, +3.45%) | 39.90 (+2.00, +5.28%) | 30.90 (+1.00, +3.34%) | 30.50 (+4.60, +17.76%) | 38.80 (+2.10, +5.72%) | 36.90 (+2.10, +6.03%) | 40.50 (+1.60, +4.11%) | 30.40 (+4.20, +16.03%) |
| microsoft | 29.90 (+0.90, +3.10%) | 39.10 (+1.20, +3.17%) | 30.70 (+0.80, +2.68%) | 28.40 (+2.50, +9.65%) | 37.80 (+1.10, +3.00%) | 35.70 (+0.90, +2.59%) | 40.00 (+1.10, +2.83%) | 28.50 (+2.30, +8.78%) |

![Results](img/en-es-bleu.png)
---

## en-bg

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 42.00 | 42.20 |
| google | 44.10 (+2.10, +5.00%) | 45.10 (+2.90, +6.87%) |
| microsoft | 38.00 (-4.00, -9.52%) | 39.10 (-3.10, -7.35%) |

![Results](img/en-bg-bleu.png)
---

## en-cs

| Translator/Dataset | wmt12 | flores-dev | wmt19 | wmt21 | wmt14 | wmt17 | wmt20 | wmt15 | wmt22 | wmt08 | wmt11 | wmt18 | wmt09 | wmt10 | flores-test | wmt13 | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 18.80 | 30.10 | 27.10 | 19.50 | 28.70 | 23.40 | 32.70 | 25.40 | 31.70 | 19.00 | 20.70 | 22.70 | 20.80 | 20.90 | 30.20 | 23.40 | 25.80 |
| google | 20.70 (+1.90, +10.11%) | 34.10 (+4.00, +13.29%) | 27.20 (+0.10, +0.37%) | 21.80 (+2.30, +11.79%) | 31.20 (+2.50, +8.71%) | 24.70 (+1.30, +5.56%) | 35.50 (+2.80, +8.56%) | 26.80 (+1.40, +5.51%) | 48.40 (+16.70, +52.68%) | 20.50 (+1.50, +7.89%) | 23.00 (+2.30, +11.11%) | 24.40 (+1.70, +7.49%) | 22.60 (+1.80, +8.65%) | 22.40 (+1.50, +7.18%) | 34.40 (+4.20, +13.91%) | 25.20 (+1.80, +7.69%) | 28.30 (+2.50, +9.69%) |
| microsoft | 22.90 (+4.10, +21.81%) | 33.50 (+3.40, +11.30%) | 27.20 (+0.10, +0.37%) | 22.00 (+2.50, +12.82%) | 31.90 (+3.20, +11.15%) | 25.60 (+2.20, +9.40%) | 34.10 (+1.40, +4.28%) | 27.40 (+2.00, +7.87%) | 42.10 (+10.40, +32.81%) | 22.60 (+3.60, +18.95%) | 25.30 (+4.60, +22.22%) | 24.90 (+2.20, +9.69%) | 25.00 (+4.20, +20.19%) | 24.30 (+3.40, +16.27%) | 34.00 (+3.80, +12.58%) | 27.70 (+4.30, +18.38%) | 29.90 (+4.10, +15.89%) |

![Results](img/en-cs-bleu.png)
---

## de-en

| Translator/Dataset | wmt08 | wmt19 | wmt17 | iwslt17 | wmt10 | flores-dev | wmt22 | flores-test | wmt12 | wmt11 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt09 | wmt21 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 26.00 | 39.00 | 35.00 | 28.60 | 29.00 | 39.60 | 29.20 | 39.10 | 27.60 | 26.30 | 33.50 | 33.50 | 39.60 | 30.80 | 43.30 | 26.40 | 31.50 | 38.80 |
| google | 27.60 (+1.60, +6.15%) | 41.10 (+2.10, +5.38%) | 38.70 (+3.70, +10.57%) | 30.10 (+1.50, +5.24%) | 32.10 (+3.10, +10.69%) | 43.10 (+3.50, +8.84%) | 33.30 (+4.10, +14.04%) | 42.80 (+3.70, +9.46%) | 29.50 (+1.90, +6.88%) | 27.30 (+1.00, +3.80%) | 37.40 (+3.90, +11.64%) | 36.10 (+2.60, +7.76%) | 42.30 (+2.70, +6.82%) | 32.40 (+1.60, +5.19%) | 46.20 (+2.90, +6.70%) | 27.20 (+0.80, +3.03%) | 32.70 (+1.20, +3.81%) | 41.80 (+3.00, +7.73%) |
| microsoft | 29.40 (+3.40, +13.08%) | 43.80 (+4.80, +12.31%) | 40.80 (+5.80, +16.57%) | 32.50 (+3.90, +13.64%) | 33.40 (+4.40, +15.17%) | 44.90 (+5.30, +13.38%) | 33.50 (+4.30, +14.73%) | 45.80 (+6.70, +17.14%) | 31.30 (+3.70, +13.41%) | 29.20 (+2.90, +11.03%) | 39.20 (+5.70, +17.01%) | 38.10 (+4.60, +13.73%) | 46.30 (+6.70, +16.92%) | 34.30 (+3.50, +11.36%) | 49.60 (+6.30, +14.55%) | 29.10 (+2.70, +10.23%) | 34.30 (+2.80, +8.89%) | 43.60 (+4.80, +12.37%) |

![Results](img/de-en-bleu.png)
---

## it-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- | --- |
| bergamot | 35.70 | 31.10 | 30.40 | 33.50 |
| google | 35.90 (+0.20, +0.56%) | 33.40 (+2.30, +7.40%) | 33.30 (+2.90, +9.54%) | 35.40 (+1.90, +5.67%) |
| microsoft | 36.40 (+0.70, +1.96%) | 33.30 (+2.20, +7.07%) | 32.70 (+2.30, +7.57%) | 35.80 (+2.30, +6.87%) |

![Results](img/it-en-bleu.png)
---

## pl-en

| Translator/Dataset | flores-dev | flores-test | wmt20 |
| --- | --- | --- | --- |
| bergamot | 26.80 | 25.80 | 31.00 |
| google | 30.00 (+3.20, +11.94%) | 29.60 (+3.80, +14.73%) | 34.10 (+3.10, +10.00%) |
| microsoft | 30.10 (+3.30, +12.31%) | 29.90 (+4.10, +15.89%) | 35.50 (+4.50, +14.52%) |

![Results](img/pl-en-bleu.png)
---

## en-fr

| Translator/Dataset | iwslt17 | wmt13 | wmt09 | wmt11 | wmt10 | wmt08 | wmt12 | flores-test | wmt14 | wmt15 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 38.60 | 33.40 | 28.80 | 33.60 | 31.00 | 25.50 | 31.40 | 48.70 | 39.70 | 36.90 | 48.50 |
| google | 28.00 (-10.60, -27.46%) | 26.50 (-6.90, -20.66%) | 23.50 (-5.30, -18.40%) | 27.50 (-6.10, -18.15%) | 26.60 (-4.40, -14.19%) | 20.70 (-4.80, -18.82%) | 25.10 (-6.30, -20.06%) | 41.80 (-6.90, -14.17%) | 32.60 (-7.10, -17.88%) | 30.60 (-6.30, -17.07%) | 41.30 (-7.20, -14.85%) |
| microsoft | 36.50 (-2.10, -5.44%) | 31.50 (-1.90, -5.69%) | 28.20 (-0.60, -2.08%) | 32.10 (-1.50, -4.46%) | 33.00 (+2.00, +6.45%) | 25.10 (-0.40, -1.57%) | 29.60 (-1.80, -5.73%) | 52.70 (+4.00, +8.21%) | 40.40 (+0.70, +1.76%) | 39.70 (+2.80, +7.59%) | 52.50 (+4.00, +8.25%) |

![Results](img/en-fr-bleu.png)
---

## en-pl

| Translator/Dataset | wmt20 | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 25.10 | 20.70 | 21.00 |
| google | 27.90 (+2.80, +11.16%) | 24.20 (+3.50, +16.91%) | 24.40 (+3.40, +16.19%) |
| microsoft | 27.70 (+2.60, +10.36%) | 23.00 (+2.30, +11.11%) | 23.80 (+2.80, +13.33%) |

![Results](img/en-pl-bleu.png)
---

## pt-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 40.20 | 47.80 | 46.60 |
| google | 39.10 (-1.10, -2.74%) | 50.40 (+2.60, +5.44%) | 50.30 (+3.70, +7.94%) |
| microsoft | 41.00 (+0.80, +1.99%) | 49.80 (+2.00, +4.18%) | 48.60 (+2.00, +4.29%) |

![Results](img/pt-en-bleu.png)
---

## es-en

| Translator/Dataset | wmt08 | mtedx_test | wmt10 | flores-dev | flores-test | wmt12 | wmt11 | wmt13 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.30 | 36.80 | 35.80 | 27.50 | 26.80 | 38.30 | 34.30 | 35.20 | 29.40 |
| google | 28.30 (+1.00, +3.66%) | 35.40 (-1.40, -3.80%) | 37.00 (+1.20, +3.35%) | 30.50 (+3.00, +10.91%) | 30.30 (+3.50, +13.06%) | 38.80 (+0.50, +1.31%) | 35.20 (+0.90, +2.62%) | 35.70 (+0.50, +1.42%) | 31.60 (+2.20, +7.48%) |
| microsoft | 26.80 (-0.50, -1.83%) | 37.60 (+0.80, +2.17%) | 35.40 (-0.40, -1.12%) | 30.30 (+2.80, +10.18%) | 29.90 (+3.10, +11.57%) | 37.80 (-0.50, -1.31%) | 33.70 (-0.60, -1.75%) | 35.30 (+0.10, +0.28%) | 29.60 (+0.20, +0.68%) |

![Results](img/es-en-bleu.png)
---

## en-de

| Translator/Dataset | flores-test | wmt22 | iwslt17 | wmt20 | wmt08 | wmt12 | wmt19 | wmt10 | wmt11 | flores-dev | wmt09 | wmt13 | wmt17 | wmt16 | wmt18 | wmt14 | wmt21 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 38.80 | 32.10 | 26.70 | 35.70 | 23.60 | 24.30 | 44.50 | 26.80 | 23.40 | 38.80 | 23.00 | 28.20 | 32.00 | 40.00 | 47.70 | 29.80 | 27.70 | 33.10 |
| google | 42.30 (+3.50, +9.02%) | 38.30 (+6.20, +19.31%) | 28.90 (+2.20, +8.24%) | 36.50 (+0.80, +2.24%) | 23.70 (+0.10, +0.42%) | 24.70 (+0.40, +1.65%) | 43.50 (-1.00, -2.25%) | 26.50 (-0.30, -1.12%) | 24.10 (+0.70, +2.99%) | 43.70 (+4.90, +12.63%) | 23.60 (+0.60, +2.61%) | 28.80 (+0.60, +2.13%) | 31.50 (-0.50, -1.56%) | 38.60 (-1.40, -3.50%) | 47.80 (+0.10, +0.21%) | 30.90 (+1.10, +3.69%) | 29.70 (+2.00, +7.22%) | 33.70 (+0.60, +1.81%) |
| microsoft | 42.90 (+4.10, +10.57%) | 37.30 (+5.20, +16.20%) | 28.20 (+1.50, +5.62%) | 36.10 (+0.40, +1.12%) | 24.00 (+0.40, +1.69%) | 25.30 (+1.00, +4.12%) | 43.80 (-0.70, -1.57%) | 27.20 (+0.40, +1.49%) | 23.70 (+0.30, +1.28%) | 44.00 (+5.20, +13.40%) | 23.90 (+0.90, +3.91%) | 28.80 (+0.60, +2.13%) | 33.10 (+1.10, +3.44%) | 40.50 (+0.50, +1.25%) | 48.70 (+1.00, +2.10%) | 32.20 (+2.40, +8.05%) | 29.80 (+2.10, +7.58%) | 34.30 (+1.20, +3.63%) |

![Results](img/en-de-bleu.png)
---