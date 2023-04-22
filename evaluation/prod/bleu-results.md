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

| Translator/Dataset | en-pt | pt-en | en-bg | nb-en | it-en | en-et | fr-en | en-de | es-en | en-it | en-pl | en-es | pl-en | en-fr | et-en | bg-en | de-en | en-cs | cs-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 49.75 | 44.67 | 42.10 | 37.60 | 32.67 | 25.37 | 35.42 | 32.08 | 32.41 | 29.87 | 22.33 | 32.42 | 28.07 | 35.95 | 32.20 | 38.50 | 33.14 | 24.71 | 31.04 |
| google | 53.75 (+4.00, +8.04%) | 46.60 (+1.93, +4.33%) | 44.60 (+2.50, +5.94%) | 42.05 (+4.45, +11.84%) | 34.50 (+1.83, +5.59%) | 28.60 (+3.23, +12.75%) | 37.81 (+2.38, +6.73%) | 33.16 (+1.08, +3.36%) | 33.64 (+1.23, +3.81%) | 28.97 (-0.90, -3.01%) | 25.50 (+3.17, +14.18%) | 34.74 (+2.31, +7.13%) | 31.23 (+3.17, +11.28%) | 29.47 (-6.47, -18.01%) | 35.80 (+3.60, +11.18%) | 41.30 (+2.80, +7.27%) | 35.65 (+2.51, +7.56%) | 27.72 (+3.01, +12.19%) | 33.36 (+2.31, +7.45%) |
| microsoft | 50.15 (+0.40, +0.80%) | 46.47 (+1.80, +4.03%) | 38.55 (-3.55, -8.43%) | 42.90 (+5.30, +14.10%) | 34.55 (+1.88, +5.74%) | 28.47 (+3.10, +12.22%) | 39.13 (+3.71, +10.47%) | 33.54 (+1.47, +4.57%) | 32.93 (+0.52, +1.61%) | 32.30 (+2.43, +8.15%) | 24.83 (+2.50, +11.19%) | 33.76 (+1.34, +4.12%) | 31.83 (+3.77, +13.42%) | 36.48 (+0.54, +1.49%) | 36.17 (+3.97, +12.32%) | 41.20 (+2.70, +7.01%) | 37.73 (+4.58, +13.83%) | 28.26 (+3.55, +14.38%) | 34.67 (+3.63, +11.70%) |

![Results](img/avg-bleu.png)
---

## en-pt

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 50.20 | 49.30 |
| google | 53.90 (+3.70, +7.37%) | 53.60 (+4.30, +8.72%) |
| microsoft | 50.70 (+0.50, +1.00%) | 49.60 (+0.30, +0.61%) |

![Results](img/en-pt-bleu.png)
---

## pt-en

| Translator/Dataset | flores-dev | mtedx_test | flores-test |
| --- | --- | --- | --- |
| bergamot | 47.40 | 40.00 | 46.60 |
| google | 50.40 (+3.00, +6.33%) | 39.10 (-0.90, -2.25%) | 50.30 (+3.70, +7.94%) |
| microsoft | 49.80 (+2.40, +5.06%) | 41.00 (+1.00, +2.50%) | 48.60 (+2.00, +4.29%) |

![Results](img/pt-en-bleu.png)
---

## en-bg

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 42.10 | 42.10 |
| google | 44.10 (+2.00, +4.75%) | 45.10 (+3.00, +7.13%) |
| microsoft | 38.00 (-4.10, -9.74%) | 39.10 (-3.00, -7.13%) |

![Results](img/en-bg-bleu.png)
---

## nb-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 37.40 | 37.80 |
| google | 41.80 (+4.40, +11.76%) | 42.30 (+4.50, +11.90%) |
| microsoft | 42.70 (+5.30, +14.17%) | 43.10 (+5.30, +14.02%) |

![Results](img/nb-en-bleu.png)
---

## it-en

| Translator/Dataset | flores-dev | mtedx_test | wmt09 | flores-test |
| --- | --- | --- | --- | --- |
| bergamot | 30.90 | 35.80 | 33.40 | 30.60 |
| google | 33.40 (+2.50, +8.09%) | 35.90 (+0.10, +0.28%) | 35.40 (+2.00, +5.99%) | 33.30 (+2.70, +8.82%) |
| microsoft | 33.30 (+2.40, +7.77%) | 36.40 (+0.60, +1.68%) | 35.80 (+2.40, +7.19%) | 32.70 (+2.10, +6.86%) |

![Results](img/it-en-bleu.png)
---

## en-et

| Translator/Dataset | flores-test | wmt18 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 25.50 | 25.20 | 25.40 |
| google | 29.00 (+3.50, +13.73%) | 26.60 (+1.40, +5.56%) | 30.20 (+4.80, +18.90%) |
| microsoft | 29.20 (+3.70, +14.51%) | 27.60 (+2.40, +9.52%) | 28.60 (+3.20, +12.60%) |

![Results](img/en-et-bleu.png)
---

## fr-en

| Translator/Dataset | flores-dev | iwslt17 | wmt10 | wmt08 | mtedx_test | wmt12 | wmt15 | wmt09 | wmt14 | wmt11 | wmt13 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 43.70 | 39.80 | 31.40 | 24.60 | 42.90 | 31.90 | 37.20 | 29.10 | 37.20 | 32.00 | 33.30 | 42.00 |
| google | 48.70 (+5.00, +11.44%) | 40.60 (+0.80, +2.01%) | 34.10 (+2.70, +8.60%) | 26.60 (+2.00, +8.13%) | 42.70 (-0.20, -0.47%) | 33.80 (+1.90, +5.96%) | 39.90 (+2.70, +7.26%) | 31.20 (+2.10, +7.22%) | 40.60 (+3.40, +9.14%) | 34.30 (+2.30, +7.19%) | 34.50 (+1.20, +3.60%) | 46.70 (+4.70, +11.19%) |
| microsoft | 48.90 (+5.20, +11.90%) | 41.80 (+2.00, +5.03%) | 35.00 (+3.60, +11.46%) | 27.40 (+2.80, +11.38%) | 46.40 (+3.50, +8.16%) | 34.60 (+2.70, +8.46%) | 42.70 (+5.50, +14.78%) | 32.20 (+3.10, +10.65%) | 42.30 (+5.10, +13.71%) | 35.20 (+3.20, +10.00%) | 36.10 (+2.80, +8.41%) | 47.00 (+5.00, +11.90%) |

![Results](img/fr-en-bleu.png)
---

## en-de

| Translator/Dataset | wmt17 | wmt18 | iwslt17 | wmt13 | flores-test | wmt10 | wmt11 | wmt19 | wmt14 | wmt09 | wmt20 | wmt08 | wmt15 | wmt12 | wmt21 | flores-dev | wmt22 | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 32.10 | 47.90 | 26.60 | 28.10 | 38.90 | 26.70 | 23.40 | 44.70 | 30.00 | 23.10 | 35.90 | 23.70 | 33.20 | 24.20 | 27.60 | 39.20 | 32.20 | 39.90 |
| google | 31.50 (-0.60, -1.87%) | 47.80 (-0.10, -0.21%) | 28.90 (+2.30, +8.65%) | 28.80 (+0.70, +2.49%) | 42.30 (+3.40, +8.74%) | 26.50 (-0.20, -0.75%) | 24.10 (+0.70, +2.99%) | 43.50 (-1.20, -2.68%) | 30.90 (+0.90, +3.00%) | 23.60 (+0.50, +2.16%) | 36.50 (+0.60, +1.67%) | 23.70 (0.00, 0.00%) | 33.70 (+0.50, +1.51%) | 24.70 (+0.50, +2.07%) | 29.70 (+2.10, +7.61%) | 43.70 (+4.50, +11.48%) | 38.30 (+6.10, +18.94%) | 38.60 (-1.30, -3.26%) |
| microsoft | 33.10 (+1.00, +3.12%) | 48.70 (+0.80, +1.67%) | 28.20 (+1.60, +6.02%) | 28.80 (+0.70, +2.49%) | 42.90 (+4.00, +10.28%) | 27.20 (+0.50, +1.87%) | 23.70 (+0.30, +1.28%) | 43.80 (-0.90, -2.01%) | 32.20 (+2.20, +7.33%) | 23.90 (+0.80, +3.46%) | 36.10 (+0.20, +0.56%) | 24.00 (+0.30, +1.27%) | 34.30 (+1.10, +3.31%) | 25.30 (+1.10, +4.55%) | 29.80 (+2.20, +7.97%) | 44.00 (+4.80, +12.24%) | 37.30 (+5.10, +15.84%) | 40.50 (+0.60, +1.50%) |

![Results](img/en-de-bleu.png)
---

## es-en

| Translator/Dataset | flores-dev | wmt10 | wmt08 | mtedx_test | wmt12 | wmt09 | wmt11 | wmt13 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.30 | 35.80 | 27.30 | 36.90 | 38.30 | 29.50 | 34.40 | 35.10 | 27.10 |
| google | 30.50 (+3.20, +11.72%) | 37.00 (+1.20, +3.35%) | 28.30 (+1.00, +3.66%) | 35.40 (-1.50, -4.07%) | 38.80 (+0.50, +1.31%) | 31.60 (+2.10, +7.12%) | 35.20 (+0.80, +2.33%) | 35.70 (+0.60, +1.71%) | 30.30 (+3.20, +11.81%) |
| microsoft | 30.30 (+3.00, +10.99%) | 35.40 (-0.40, -1.12%) | 26.80 (-0.50, -1.83%) | 37.60 (+0.70, +1.90%) | 37.80 (-0.50, -1.31%) | 29.60 (+0.10, +0.34%) | 33.70 (-0.70, -2.03%) | 35.30 (+0.20, +0.57%) | 29.90 (+2.80, +10.33%) |

![Results](img/es-en-bleu.png)
---

## en-it

| Translator/Dataset | flores-test | wmt09 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 29.40 | 31.00 | 29.20 |
| google | 29.60 (+0.20, +0.68%) | 28.80 (-2.20, -7.10%) | 28.50 (-0.70, -2.40%) |
| microsoft | 32.10 (+2.70, +9.18%) | 33.70 (+2.70, +8.71%) | 31.10 (+1.90, +6.51%) |

![Results](img/en-it-bleu.png)
---

## en-pl

| Translator/Dataset | flores-test | wmt20 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 21.10 | 25.30 | 20.60 |
| google | 24.40 (+3.30, +15.64%) | 27.90 (+2.60, +10.28%) | 24.20 (+3.60, +17.48%) |
| microsoft | 23.80 (+2.70, +12.80%) | 27.70 (+2.40, +9.49%) | 23.00 (+2.40, +11.65%) |

![Results](img/en-pl-bleu.png)
---

## en-es

| Translator/Dataset | wmt11 | wmt08 | wmt12 | wmt09 | flores-dev | wmt13 | wmt10 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 37.80 | 29.10 | 39.10 | 29.90 | 25.80 | 34.90 | 36.70 | 26.10 |
| google | 39.90 (+2.10, +5.56%) | 30.00 (+0.90, +3.09%) | 40.50 (+1.40, +3.58%) | 30.90 (+1.00, +3.34%) | 30.50 (+4.70, +18.22%) | 36.90 (+2.00, +5.73%) | 38.80 (+2.10, +5.72%) | 30.40 (+4.30, +16.48%) |
| microsoft | 39.10 (+1.30, +3.44%) | 29.90 (+0.80, +2.75%) | 40.00 (+0.90, +2.30%) | 30.70 (+0.80, +2.68%) | 28.40 (+2.60, +10.08%) | 35.70 (+0.80, +2.29%) | 37.80 (+1.10, +3.00%) | 28.50 (+2.40, +9.20%) |

![Results](img/en-es-bleu.png)
---

## pl-en

| Translator/Dataset | flores-dev | wmt20 | flores-test |
| --- | --- | --- | --- |
| bergamot | 26.90 | 31.40 | 25.90 |
| google | 30.00 (+3.10, +11.52%) | 34.10 (+2.70, +8.60%) | 29.60 (+3.70, +14.29%) |
| microsoft | 30.10 (+3.20, +11.90%) | 35.50 (+4.10, +13.06%) | 29.90 (+4.00, +15.44%) |

![Results](img/pl-en-bleu.png)
---

## en-fr

| Translator/Dataset | wmt13 | wmt14 | flores-test | wmt08 | wmt09 | flores-dev | iwslt17 | wmt12 | wmt10 | wmt15 | wmt11 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 33.50 | 39.70 | 48.50 | 25.50 | 28.80 | 48.50 | 38.40 | 31.20 | 31.00 | 36.70 | 33.60 |
| google | 26.50 (-7.00, -20.90%) | 32.60 (-7.10, -17.88%) | 41.80 (-6.70, -13.81%) | 20.70 (-4.80, -18.82%) | 23.50 (-5.30, -18.40%) | 41.30 (-7.20, -14.85%) | 28.00 (-10.40, -27.08%) | 25.10 (-6.10, -19.55%) | 26.60 (-4.40, -14.19%) | 30.60 (-6.10, -16.62%) | 27.50 (-6.10, -18.15%) |
| microsoft | 31.50 (-2.00, -5.97%) | 40.40 (+0.70, +1.76%) | 52.70 (+4.20, +8.66%) | 25.10 (-0.40, -1.57%) | 28.20 (-0.60, -2.08%) | 52.50 (+4.00, +8.25%) | 36.50 (-1.90, -4.95%) | 29.60 (-1.60, -5.13%) | 33.00 (+2.00, +6.45%) | 39.70 (+3.00, +8.17%) | 32.10 (-1.50, -4.46%) |

![Results](img/en-fr-bleu.png)
---

## et-en

| Translator/Dataset | flores-dev | wmt18 | flores-test |
| --- | --- | --- | --- |
| bergamot | 33.50 | 30.80 | 32.30 |
| google | 38.30 (+4.80, +14.33%) | 32.10 (+1.30, +4.22%) | 37.00 (+4.70, +14.55%) |
| microsoft | 37.40 (+3.90, +11.64%) | 34.10 (+3.30, +10.71%) | 37.00 (+4.70, +14.55%) |

![Results](img/et-en-bleu.png)
---

## bg-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 39.00 | 38.00 |
| google | 41.90 (+2.90, +7.44%) | 40.70 (+2.70, +7.11%) |
| microsoft | 42.10 (+3.10, +7.95%) | 40.30 (+2.30, +6.05%) |

![Results](img/bg-en-bleu.png)
---

## de-en

| Translator/Dataset | flores-dev | iwslt17 | wmt10 | wmt08 | wmt18 | wmt20 | wmt19 | wmt12 | wmt15 | wmt09 | wmt17 | wmt14 | wmt11 | wmt16 | wmt22 | wmt13 | flores-test | wmt21 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 39.40 | 28.60 | 29.20 | 26.10 | 43.20 | 38.60 | 39.00 | 27.70 | 33.30 | 26.40 | 35.00 | 33.60 | 26.40 | 39.60 | 29.20 | 30.90 | 38.90 | 31.50 |
| google | 43.10 (+3.70, +9.39%) | 30.10 (+1.50, +5.24%) | 32.10 (+2.90, +9.93%) | 27.60 (+1.50, +5.75%) | 46.20 (+3.00, +6.94%) | 41.80 (+3.20, +8.29%) | 41.10 (+2.10, +5.38%) | 29.50 (+1.80, +6.50%) | 36.10 (+2.80, +8.41%) | 27.20 (+0.80, +3.03%) | 38.70 (+3.70, +10.57%) | 37.40 (+3.80, +11.31%) | 27.30 (+0.90, +3.41%) | 42.30 (+2.70, +6.82%) | 33.30 (+4.10, +14.04%) | 32.40 (+1.50, +4.85%) | 42.80 (+3.90, +10.03%) | 32.70 (+1.20, +3.81%) |
| microsoft | 44.90 (+5.50, +13.96%) | 32.50 (+3.90, +13.64%) | 33.40 (+4.20, +14.38%) | 29.40 (+3.30, +12.64%) | 49.60 (+6.40, +14.81%) | 43.60 (+5.00, +12.95%) | 43.80 (+4.80, +12.31%) | 31.30 (+3.60, +13.00%) | 38.10 (+4.80, +14.41%) | 29.10 (+2.70, +10.23%) | 40.80 (+5.80, +16.57%) | 39.20 (+5.60, +16.67%) | 29.20 (+2.80, +10.61%) | 46.30 (+6.70, +16.92%) | 33.50 (+4.30, +14.73%) | 34.30 (+3.40, +11.00%) | 45.80 (+6.90, +17.74%) | 34.30 (+2.80, +8.89%) |

![Results](img/de-en-bleu.png)
---

## en-cs

| Translator/Dataset | wmt21 | wmt11 | wmt09 | wmt19 | wmt16 | wmt20 | flores-dev | wmt13 | wmt08 | wmt15 | wmt18 | wmt10 | wmt12 | wmt22 | wmt14 | wmt17 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 19.50 | 20.50 | 20.80 | 27.10 | 25.30 | 32.40 | 30.10 | 23.10 | 18.80 | 25.20 | 22.60 | 20.90 | 18.90 | 31.80 | 28.60 | 23.60 | 30.80 |
| google | 21.80 (+2.30, +11.79%) | 23.00 (+2.50, +12.20%) | 22.60 (+1.80, +8.65%) | 27.20 (+0.10, +0.37%) | 28.30 (+3.00, +11.86%) | 35.50 (+3.10, +9.57%) | 34.10 (+4.00, +13.29%) | 25.20 (+2.10, +9.09%) | 20.50 (+1.70, +9.04%) | 26.80 (+1.60, +6.35%) | 24.40 (+1.80, +7.96%) | 22.40 (+1.50, +7.18%) | 20.70 (+1.80, +9.52%) | 48.40 (+16.60, +52.20%) | 31.20 (+2.60, +9.09%) | 24.70 (+1.10, +4.66%) | 34.40 (+3.60, +11.69%) |
| microsoft | 22.00 (+2.50, +12.82%) | 25.30 (+4.80, +23.41%) | 25.00 (+4.20, +20.19%) | 27.20 (+0.10, +0.37%) | 29.90 (+4.60, +18.18%) | 34.10 (+1.70, +5.25%) | 33.50 (+3.40, +11.30%) | 27.70 (+4.60, +19.91%) | 22.60 (+3.80, +20.21%) | 27.40 (+2.20, +8.73%) | 24.90 (+2.30, +10.18%) | 24.30 (+3.40, +16.27%) | 22.90 (+4.00, +21.16%) | 42.10 (+10.30, +32.39%) | 31.90 (+3.30, +11.54%) | 25.60 (+2.00, +8.47%) | 34.00 (+3.20, +10.39%) |

![Results](img/en-cs-bleu.png)
---

## cs-en

| Translator/Dataset | flores-dev | wmt10 | wmt08 | wmt18 | wmt20 | wmt12 | wmt15 | wmt09 | wmt17 | wmt14 | wmt11 | wmt16 | wmt22 | wmt13 | flores-test | wmt21 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 35.30 | 28.10 | 24.50 | 31.30 | 26.90 | 26.50 | 31.80 | 27.50 | 30.50 | 34.90 | 28.20 | 33.30 | 44.70 | 30.30 | 34.90 | 28.00 |
| google | 38.60 (+3.30, +9.35%) | 30.50 (+2.40, +8.54%) | 26.30 (+1.80, +7.35%) | 32.10 (+0.80, +2.56%) | 28.40 (+1.50, +5.58%) | 28.60 (+2.10, +7.92%) | 33.60 (+1.80, +5.66%) | 29.90 (+2.40, +8.73%) | 31.20 (+0.70, +2.30%) | 38.00 (+3.10, +8.88%) | 30.20 (+2.00, +7.09%) | 34.80 (+1.50, +4.50%) | 49.40 (+4.70, +10.51%) | 32.40 (+2.10, +6.93%) | 39.00 (+4.10, +11.75%) | 30.70 (+2.70, +9.64%) |
| microsoft | 40.00 (+4.70, +13.31%) | 30.70 (+2.60, +9.25%) | 26.40 (+1.90, +7.76%) | 34.30 (+3.00, +9.58%) | 27.60 (+0.70, +2.60%) | 29.70 (+3.20, +12.08%) | 34.70 (+2.90, +9.12%) | 29.60 (+2.10, +7.64%) | 33.60 (+3.10, +10.16%) | 39.90 (+5.00, +14.33%) | 30.90 (+2.70, +9.57%) | 38.30 (+5.00, +15.02%) | 54.90 (+10.20, +22.82%) | 33.40 (+3.10, +10.23%) | 40.30 (+5.40, +15.47%) | 30.50 (+2.50, +8.93%) |

![Results](img/cs-en-bleu.png)
---