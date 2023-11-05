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

| Translator/Dataset | hu-en | ru-en | en-hu | fi-en | en-nl | en-ru | en-fa | nl-en | uk-en | fa-en | ca-en | en-uk | is-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 26.53 | 33.69 | 20.32 | 29.44 | 27.30 | 29.44 | 17.30 | 29.65 | 35.93 | 28.70 | 38.00 | 26.30 | 23.40 |
| google | 31.30 (+4.77, +18.00%) | 38.20 (+4.51, +13.38%) | 24.80 (+4.48, +22.02%) | 33.20 (+3.76, +12.76%) | 29.30 (+2.00, +7.33%) | 34.49 (+5.05, +17.15%) | 27.80 (+10.50, +60.69%) | 33.05 (+3.40, +11.47%) | 42.43 (+6.50, +18.09%) | 40.85 (+12.15, +42.33%) | 48.95 (+10.95, +28.82%) | 32.63 (+6.33, +24.08%) | 38.90 (+15.50, +66.24%) |
| microsoft | 31.03 (+4.50, +16.97%) | 38.38 (+4.68, +13.90%) | 26.05 (+5.73, +28.17%) | 35.09 (+5.64, +19.17%) | 28.80 (+1.50, +5.49%) | 33.62 (+4.18, +14.21%) | 20.50 (+3.20, +18.50%) | 32.60 (+2.95, +9.95%) | 42.30 (+6.37, +17.72%) | 36.15 (+7.45, +25.96%) | 46.50 (+8.50, +22.37%) | 32.03 (+5.73, +21.80%) | 38.17 (+14.77, +63.11%) |
| argos | 12.97 (-13.55, -51.08%) | 25.76 (-7.93, -23.54%) | 17.40 (-2.93, -14.39%) | 22.14 (-7.30, -24.79%) | 24.90 (-2.40, -8.79%) | 27.89 (-1.55, -5.26%) | 21.30 (+4.00, +23.12%) | 29.90 (+0.25, +0.84%) | 26.27 (-9.67, -26.90%) | 27.90 (-0.80, -2.79%) | 42.30 (+4.30, +11.32%) | 15.73 (-10.57, -40.18%) | N/A |

![Results](img/avg-bleu.png)
---

## hu-en

| Translator/Dataset | wmt08 | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- | --- |
| bergamot | 20.00 | 32.20 | 31.60 | 22.30 |
| google | 22.40 (+2.40, +12.00%) | 39.40 (+7.20, +22.36%) | 38.00 (+6.40, +20.25%) | 25.40 (+3.10, +13.90%) |
| microsoft | 22.60 (+2.60, +13.00%) | 38.50 (+6.30, +19.57%) | 38.20 (+6.60, +20.89%) | 24.80 (+2.50, +11.21%) |
| argos | 9.70 (-10.30, -51.50%) | 15.90 (-16.30, -50.62%) | 15.40 (-16.20, -51.27%) | 10.90 (-11.40, -51.12%) |

![Results](img/hu-en-bleu.png)
---

## ru-en

| Translator/Dataset | mtedx_test | flores-dev | wmt14 | wmt19 | wmt17 | wmt21 | wmt15 | wmt22 | wmt18 | flores-test | wmt16 | wmt13 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.00 | 31.90 | 37.80 | 39.10 | 37.60 | 35.40 | 33.50 | 38.50 | 31.90 | 31.00 | 33.00 | 29.30 | 35.00 |
| google | 25.10 (+1.10, +4.58%) | 38.40 (+6.50, +20.38%) | 42.70 (+4.90, +12.96%) | 42.80 (+3.70, +9.46%) | 42.70 (+5.10, +13.56%) | 39.80 (+4.40, +12.43%) | 38.60 (+5.10, +15.22%) | 43.70 (+5.20, +13.51%) | 37.30 (+5.40, +16.93%) | 37.30 (+6.30, +20.32%) | 37.60 (+4.60, +13.94%) | 32.20 (+2.90, +9.90%) | 38.40 (+3.40, +9.71%) |
| microsoft | 26.20 (+2.20, +9.17%) | 36.50 (+4.60, +14.42%) | 44.10 (+6.30, +16.67%) | 43.80 (+4.70, +12.02%) | 43.70 (+6.10, +16.22%) | 39.00 (+3.60, +10.17%) | 38.50 (+5.00, +14.93%) | 43.90 (+5.40, +14.03%) | 37.40 (+5.50, +17.24%) | 36.10 (+5.10, +16.45%) | 38.40 (+5.40, +16.36%) | 32.50 (+3.20, +10.92%) | 38.80 (+3.80, +10.86%) |
| argos | 21.40 (-2.60, -10.83%) | 25.70 (-6.20, -19.44%) | 28.20 (-9.60, -25.40%) | 26.70 (-12.40, -31.71%) | 28.90 (-8.70, -23.14%) | 24.90 (-10.50, -29.66%) | 25.50 (-8.00, -23.88%) | 27.10 (-11.40, -29.61%) | 24.70 (-7.20, -22.57%) | 26.40 (-4.60, -14.84%) | 25.40 (-7.60, -23.03%) | 24.50 (-4.80, -16.38%) | 25.50 (-9.50, -27.14%) |

![Results](img/ru-en-bleu.png)
---

## en-hu

| Translator/Dataset | flores-dev | wmt09 | wmt08 | flores-test |
| --- | --- | --- | --- | --- |
| bergamot | 25.40 | 16.40 | 14.40 | 25.10 |
| google | 30.20 (+4.80, +18.90%) | 21.00 (+4.60, +28.05%) | 17.90 (+3.50, +24.31%) | 30.10 (+5.00, +19.92%) |
| microsoft | 31.80 (+6.40, +25.20%) | 22.20 (+5.80, +35.37%) | 18.70 (+4.30, +29.86%) | 31.50 (+6.40, +25.50%) |
| argos | 21.40 (-4.00, -15.75%) | 14.80 (-1.60, -9.76%) | 12.60 (-1.80, -12.50%) | 20.80 (-4.30, -17.13%) |

![Results](img/en-hu-bleu.png)
---

## fi-en

| Translator/Dataset | flores-dev | wmt19 | wmt17 | wmt15 | wmt18 | flores-test | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.70 | 29.50 | 33.10 | 26.50 | 24.10 | 30.60 | 30.60 |
| google | 37.00 (+5.30, +16.72%) | 32.50 (+3.00, +10.17%) | 37.70 (+4.60, +13.90%) | 29.90 (+3.40, +12.83%) | 25.40 (+1.30, +5.39%) | 35.60 (+5.00, +16.34%) | 34.30 (+3.70, +12.09%) |
| microsoft | 38.00 (+6.30, +19.87%) | 34.20 (+4.70, +15.93%) | 39.40 (+6.30, +19.03%) | 31.70 (+5.20, +19.62%) | 28.60 (+4.50, +18.67%) | 37.20 (+6.60, +21.57%) | 36.50 (+5.90, +19.28%) |
| argos | 25.30 (-6.40, -20.19%) | 21.10 (-8.40, -28.47%) | 23.90 (-9.20, -27.79%) | 20.10 (-6.40, -24.15%) | 18.00 (-6.10, -25.31%) | 24.60 (-6.00, -19.61%) | 22.00 (-8.60, -28.10%) |

![Results](img/fi-en-bleu.png)
---

## en-nl

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 27.60 | 27.00 |
| google | 29.40 (+1.80, +6.52%) | 29.20 (+2.20, +8.15%) |
| microsoft | 29.00 (+1.40, +5.07%) | 28.60 (+1.60, +5.93%) |
| argos | 25.10 (-2.50, -9.06%) | 24.70 (-2.30, -8.52%) |

![Results](img/en-nl-bleu.png)
---

## en-ru

| Translator/Dataset | wmt16 | wmt15 | wmt21 | flores-dev | wmt22 | wmt18 | wmt14 | wmt17 | wmt20 | wmt13 | wmt19 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 30.90 | 31.40 | 25.50 | 29.90 | 26.50 | 28.50 | 38.20 | 33.60 | 22.00 | 26.20 | 31.40 | 29.20 |
| google | 35.00 (+4.10, +13.27%) | 36.90 (+5.50, +17.52%) | 30.00 (+4.50, +17.65%) | 34.90 (+5.00, +16.72%) | 35.00 (+8.50, +32.08%) | 35.00 (+6.50, +22.81%) | 45.70 (+7.50, +19.63%) | 38.90 (+5.30, +15.77%) | 27.20 (+5.20, +23.64%) | 28.00 (+1.80, +6.87%) | 32.90 (+1.50, +4.78%) | 34.40 (+5.20, +17.81%) |
| microsoft | 34.20 (+3.30, +10.68%) | 36.10 (+4.70, +14.97%) | 29.20 (+3.70, +14.51%) | 33.50 (+3.60, +12.04%) | 33.10 (+6.60, +24.91%) | 33.70 (+5.20, +18.25%) | 44.70 (+6.50, +17.02%) | 38.60 (+5.00, +14.88%) | 26.30 (+4.30, +19.55%) | 27.30 (+1.10, +4.20%) | 33.20 (+1.80, +5.73%) | 33.60 (+4.40, +15.07%) |
| argos | 28.50 (-2.40, -7.77%) | 30.40 (-1.00, -3.18%) | 23.20 (-2.30, -9.02%) | 27.90 (-2.00, -6.69%) | 27.20 (+0.70, +2.64%) | 27.00 (-1.50, -5.26%) | 36.80 (-1.40, -3.66%) | 31.90 (-1.70, -5.06%) | 22.00 (0.00, 0.00%) | 24.10 (-2.10, -8.02%) | 28.10 (-3.30, -10.51%) | 27.60 (-1.60, -5.48%) |

![Results](img/en-ru-bleu.png)
---

## en-fa

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 17.40 | 17.20 |
| google | 28.40 (+11.00, +63.22%) | 27.20 (+10.00, +58.14%) |
| microsoft | 21.10 (+3.70, +21.26%) | 19.90 (+2.70, +15.70%) |
| argos | 21.80 (+4.40, +25.29%) | 20.80 (+3.60, +20.93%) |

![Results](img/en-fa-bleu.png)
---

## nl-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.70 | 29.60 |
| google | 33.00 (+3.30, +11.11%) | 33.10 (+3.50, +11.82%) |
| microsoft | 32.40 (+2.70, +9.09%) | 32.80 (+3.20, +10.81%) |
| argos | 30.40 (+0.70, +2.36%) | 29.40 (-0.20, -0.68%) |

![Results](img/nl-en-bleu.png)
---

## uk-en

| Translator/Dataset | flores-dev | wmt22 | flores-test |
| --- | --- | --- | --- |
| bergamot | 35.60 | 36.60 | 35.60 |
| google | 43.10 (+7.50, +21.07%) | 41.60 (+5.00, +13.66%) | 42.60 (+7.00, +19.66%) |
| microsoft | 41.80 (+6.20, +17.42%) | 44.40 (+7.80, +21.31%) | 40.70 (+5.10, +14.33%) |
| argos | 27.90 (-7.70, -21.63%) | 22.70 (-13.90, -37.98%) | 28.20 (-7.40, -20.79%) |

![Results](img/uk-en-bleu.png)
---

## fa-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 29.10 | 28.30 |
| google | 42.00 (+12.90, +44.33%) | 39.70 (+11.40, +40.28%) |
| microsoft | 36.50 (+7.40, +25.43%) | 35.80 (+7.50, +26.50%) |
| argos | 28.40 (-0.70, -2.41%) | 27.40 (-0.90, -3.18%) |

![Results](img/fa-en-bleu.png)
---

## ca-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 38.70 | 37.30 |
| google | 49.60 (+10.90, +28.17%) | 48.30 (+11.00, +29.49%) |
| microsoft | 46.80 (+8.10, +20.93%) | 46.20 (+8.90, +23.86%) |
| argos | 42.80 (+4.10, +10.59%) | 41.80 (+4.50, +12.06%) |

![Results](img/ca-en-bleu.png)
---

## en-uk

| Translator/Dataset | flores-dev | flores-test | wmt22 |
| --- | --- | --- | --- |
| bergamot | 27.90 | 28.20 | 22.80 |
| google | 32.80 (+4.90, +17.56%) | 33.10 (+4.90, +17.38%) | 32.00 (+9.20, +40.35%) |
| microsoft | 32.20 (+4.30, +15.41%) | 33.50 (+5.30, +18.79%) | 30.40 (+7.60, +33.33%) |
| argos | 16.40 (-11.50, -41.22%) | 15.80 (-12.40, -43.97%) | 15.00 (-7.80, -34.21%) |

![Results](img/en-uk-bleu.png)
---

## is-en

| Translator/Dataset | flores-dev | flores-test | wmt21 |
| --- | --- | --- | --- |
| bergamot | 23.60 | 23.40 | 23.20 |
| google | 39.40 (+15.80, +66.95%) | 38.60 (+15.20, +64.96%) | 38.70 (+15.50, +66.81%) |
| microsoft | 37.30 (+13.70, +58.05%) | 36.70 (+13.30, +56.84%) | 40.50 (+17.30, +74.57%) |
| argos | N/A | N/A | N/A |

![Results](img/is-en-bleu.png)
---