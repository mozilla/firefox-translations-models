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

| Translator/Dataset | en-fr | es-en | en-pl | nb-en | bg-en | pt-en | it-en | et-en | fr-en | en-cs | cs-en | en-it | pl-en | de-en | en-es | en-pt | en-et | en-bg | en-de |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 36.01 | 32.38 | 22.27 | 37.60 | 38.50 | 44.87 | 32.67 | 32.37 | 35.43 | 24.65 | 30.34 | 29.77 | 27.87 | 33.51 | 32.41 | 49.85 | 25.50 | 42.10 | 32.27 |
| google | 29.47 (-6.54, -18.15%) | 33.64 (+1.27, +3.91%) | 25.50 (+3.23, +14.52%) | 42.05 (+4.45, +11.84%) | 41.30 (+2.80, +7.27%) | 46.60 (+1.73, +3.86%) | 34.50 (+1.83, +5.59%) | 35.80 (+3.43, +10.61%) | 37.81 (+2.38, +6.70%) | 26.73 (+2.09, +8.47%) | 32.40 (+2.06, +6.80%) | 28.97 (-0.80, -2.69%) | 31.23 (+3.37, +12.08%) | 35.98 (+2.48, +7.39%) | 34.74 (+2.32, +7.17%) | 53.75 (+3.90, +7.82%) | 28.60 (+3.10, +12.16%) | 44.60 (+2.50, +5.94%) | 33.05 (+0.77, +2.40%) |
| microsoft | 36.48 (+0.47, +1.31%) | 32.93 (+0.56, +1.72%) | 24.83 (+2.57, +11.53%) | 42.90 (+5.30, +14.10%) | 41.20 (+2.70, +7.01%) | 46.47 (+1.60, +3.57%) | 34.55 (+1.88, +5.74%) | 36.17 (+3.80, +11.74%) | 39.13 (+3.70, +10.44%) | 27.75 (+3.11, +12.60%) | 33.53 (+3.19, +10.53%) | 32.30 (+2.53, +8.51%) | 31.83 (+3.97, +14.23%) | 38.21 (+4.70, +14.03%) | 33.76 (+1.35, +4.17%) | 50.15 (+0.30, +0.60%) | 28.47 (+2.97, +11.63%) | 38.55 (-3.55, -8.43%) | 33.54 (+1.27, +3.93%) |

![Results](img/avg.png)

## en-fr

| Translator/Dataset | wmt15 | wmt13 | wmt12 | wmt09 | flores-test | wmt10 | iwslt17 | wmt14 | flores-dev | wmt08 | wmt11 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 36.90 | 33.40 | 31.40 | 28.80 | 48.70 | 31.00 | 38.60 | 39.70 | 48.50 | 25.50 | 33.60 |
| google | 30.60 (-6.30, -17.07%) | 26.50 (-6.90, -20.66%) | 25.10 (-6.30, -20.06%) | 23.50 (-5.30, -18.40%) | 41.80 (-6.90, -14.17%) | 26.60 (-4.40, -14.19%) | 28.00 (-10.60, -27.46%) | 32.60 (-7.10, -17.88%) | 41.30 (-7.20, -14.85%) | 20.70 (-4.80, -18.82%) | 27.50 (-6.10, -18.15%) |
| microsoft | 39.70 (+2.80, +7.59%) | 31.50 (-1.90, -5.69%) | 29.60 (-1.80, -5.73%) | 28.20 (-0.60, -2.08%) | 52.70 (+4.00, +8.21%) | 33.00 (+2.00, +6.45%) | 36.50 (-2.10, -5.44%) | 40.40 (+0.70, +1.76%) | 52.50 (+4.00, +8.25%) | 25.10 (-0.40, -1.57%) | 32.10 (-1.50, -4.46%) |

![Results](img/en-fr.png)

## es-en

| Translator/Dataset | wmt10 | wmt09 | wmt11 | mtedx_test | wmt13 | wmt08 | flores-dev | flores-test | wmt12 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 35.80 | 29.40 | 34.30 | 36.80 | 35.20 | 27.30 | 27.50 | 26.80 | 38.30 |
| google | 37.00 (+1.20, +3.35%) | 31.60 (+2.20, +7.48%) | 35.20 (+0.90, +2.62%) | 35.40 (-1.40, -3.80%) | 35.70 (+0.50, +1.42%) | 28.30 (+1.00, +3.66%) | 30.50 (+3.00, +10.91%) | 30.30 (+3.50, +13.06%) | 38.80 (+0.50, +1.31%) |
| microsoft | 35.40 (-0.40, -1.12%) | 29.60 (+0.20, +0.68%) | 33.70 (-0.60, -1.75%) | 37.60 (+0.80, +2.17%) | 35.30 (+0.10, +0.28%) | 26.80 (-0.50, -1.83%) | 30.30 (+2.80, +10.18%) | 29.90 (+3.10, +11.57%) | 37.80 (-0.50, -1.31%) |

![Results](img/es-en.png)

## en-pl

| Translator/Dataset | wmt20 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 25.10 | 21.00 | 20.70 |
| google | 27.90 (+2.80, +11.16%) | 24.40 (+3.40, +16.19%) | 24.20 (+3.50, +16.91%) |
| microsoft | 27.70 (+2.60, +10.36%) | 23.80 (+2.80, +13.33%) | 23.00 (+2.30, +11.11%) |

![Results](img/en-pl.png)

## nb-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 37.40 | 37.80 |
| google | 41.80 (+4.40, +11.76%) | 42.30 (+4.50, +11.90%) |
| microsoft | 42.70 (+5.30, +14.17%) | 43.10 (+5.30, +14.02%) |

![Results](img/nb-en.png)

## bg-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 39.10 | 37.90 |
| google | 41.90 (+2.80, +7.16%) | 40.70 (+2.80, +7.39%) |
| microsoft | 42.10 (+3.00, +7.67%) | 40.30 (+2.40, +6.33%) |

![Results](img/bg-en.png)

## pt-en

| Translator/Dataset | mtedx_test | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 40.20 | 47.80 | 46.60 |
| google | 39.10 (-1.10, -2.74%) | 50.40 (+2.60, +5.44%) | 50.30 (+3.70, +7.94%) |
| microsoft | 41.00 (+0.80, +1.99%) | 49.80 (+2.00, +4.18%) | 48.60 (+2.00, +4.29%) |

![Results](img/pt-en.png)

## it-en

| Translator/Dataset | wmt09 | mtedx_test | flores-dev | flores-test |
| --- | --- | --- | --- | --- |
| bergamot | 33.50 | 35.70 | 31.10 | 30.40 |
| google | 35.40 (+1.90, +5.67%) | 35.90 (+0.20, +0.56%) | 33.40 (+2.30, +7.40%) | 33.30 (+2.90, +9.54%) |
| microsoft | 35.80 (+2.30, +6.87%) | 36.40 (+0.70, +1.96%) | 33.30 (+2.20, +7.07%) | 32.70 (+2.30, +7.57%) |

![Results](img/it-en.png)

## et-en

| Translator/Dataset | wmt18 | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 30.90 | 33.50 | 32.70 |
| google | 32.10 (+1.20, +3.88%) | 38.30 (+4.80, +14.33%) | 37.00 (+4.30, +13.15%) |
| microsoft | 34.10 (+3.20, +10.36%) | 37.40 (+3.90, +11.64%) | 37.00 (+4.30, +13.15%) |

![Results](img/et-en.png)

## fr-en

| Translator/Dataset | wmt10 | wmt09 | wmt14 | wmt11 | mtedx_test | wmt13 | wmt08 | flores-dev | flores-test | wmt12 | wmt15 | iwslt17 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 31.40 | 29.10 | 37.30 | 32.00 | 42.80 | 33.30 | 24.50 | 43.80 | 42.10 | 31.90 | 37.20 | 39.80 |
| google | 34.10 (+2.70, +8.60%) | 31.20 (+2.10, +7.22%) | 40.60 (+3.30, +8.85%) | 34.30 (+2.30, +7.19%) | 42.70 (-0.10, -0.23%) | 34.50 (+1.20, +3.60%) | 26.60 (+2.10, +8.57%) | 48.70 (+4.90, +11.19%) | 46.70 (+4.60, +10.93%) | 33.80 (+1.90, +5.96%) | 39.90 (+2.70, +7.26%) | 40.60 (+0.80, +2.01%) |
| microsoft | 35.00 (+3.60, +11.46%) | 32.20 (+3.10, +10.65%) | 42.30 (+5.00, +13.40%) | 35.20 (+3.20, +10.00%) | 46.40 (+3.60, +8.41%) | 36.10 (+2.80, +8.41%) | 27.40 (+2.90, +11.84%) | 48.90 (+5.10, +11.64%) | 47.00 (+4.90, +11.64%) | 34.60 (+2.70, +8.46%) | 42.70 (+5.50, +14.78%) | 41.80 (+2.00, +5.03%) |

![Results](img/fr-en.png)

## en-cs

| Translator/Dataset | wmt10 | flores-dev | wmt11 | wmt18 | flores-test | wmt13 | wmt15 | wmt08 | wmt09 | wmt19 | wmt14 | wmt17 | wmt20 | wmt16 | wmt12 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 20.90 | 30.10 | 20.70 | 22.70 | 30.20 | 23.40 | 25.40 | 19.00 | 20.80 | 27.10 | 28.70 | 23.40 | 32.70 | 25.80 | 18.80 |
| google | 22.40 (+1.50, +7.18%) | 34.10 (+4.00, +13.29%) | 23.00 (+2.30, +11.11%) | 24.40 (+1.70, +7.49%) | 34.40 (+4.20, +13.91%) | 25.20 (+1.80, +7.69%) | 26.80 (+1.40, +5.51%) | 20.50 (+1.50, +7.89%) | 22.60 (+1.80, +8.65%) | 27.20 (+0.10, +0.37%) | 31.20 (+2.50, +8.71%) | 24.70 (+1.30, +5.56%) | 35.50 (+2.80, +8.56%) | 28.30 (+2.50, +9.69%) | 20.70 (+1.90, +10.11%) |
| microsoft | 24.30 (+3.40, +16.27%) | 33.50 (+3.40, +11.30%) | 25.30 (+4.60, +22.22%) | 24.90 (+2.20, +9.69%) | 34.00 (+3.80, +12.58%) | 27.70 (+4.30, +18.38%) | 27.40 (+2.00, +7.87%) | 22.60 (+3.60, +18.95%) | 25.00 (+4.20, +20.19%) | 27.20 (+0.10, +0.37%) | 31.90 (+3.20, +11.15%) | 25.60 (+2.20, +9.40%) | 34.10 (+1.40, +4.28%) | 29.90 (+4.10, +15.89%) | 22.90 (+4.10, +21.81%) |

![Results](img/en-cs.png)

## cs-en

| Translator/Dataset | wmt17 | wmt10 | wmt18 | wmt09 | wmt14 | wmt11 | wmt16 | wmt13 | wmt20 | wmt08 | flores-dev | flores-test | wmt12 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 30.20 | 28.20 | 31.30 | 27.60 | 35.00 | 28.10 | 33.40 | 30.30 | 27.00 | 24.50 | 35.30 | 35.30 | 26.50 | 32.00 |
| google | 31.20 (+1.00, +3.31%) | 30.50 (+2.30, +8.16%) | 32.10 (+0.80, +2.56%) | 29.90 (+2.30, +8.33%) | 38.00 (+3.00, +8.57%) | 30.20 (+2.10, +7.47%) | 34.80 (+1.40, +4.19%) | 32.40 (+2.10, +6.93%) | 28.40 (+1.40, +5.19%) | 26.30 (+1.80, +7.35%) | 38.60 (+3.30, +9.35%) | 39.00 (+3.70, +10.48%) | 28.60 (+2.10, +7.92%) | 33.60 (+1.60, +5.00%) |
| microsoft | 33.60 (+3.40, +11.26%) | 30.70 (+2.50, +8.87%) | 34.30 (+3.00, +9.58%) | 29.60 (+2.00, +7.25%) | 39.90 (+4.90, +14.00%) | 30.90 (+2.80, +9.96%) | 38.30 (+4.90, +14.67%) | 33.40 (+3.10, +10.23%) | 27.60 (+0.60, +2.22%) | 26.40 (+1.90, +7.76%) | 40.00 (+4.70, +13.31%) | 40.30 (+5.00, +14.16%) | 29.70 (+3.20, +12.08%) | 34.70 (+2.70, +8.44%) |

![Results](img/cs-en.png)

## en-it

| Translator/Dataset | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- |
| bergamot | 29.20 | 29.30 | 30.80 |
| google | 28.50 (-0.70, -2.40%) | 29.60 (+0.30, +1.02%) | 28.80 (-2.00, -6.49%) |
| microsoft | 31.10 (+1.90, +6.51%) | 32.10 (+2.80, +9.56%) | 33.70 (+2.90, +9.42%) |

![Results](img/en-it.png)

## pl-en

| Translator/Dataset | wmt20 | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 31.00 | 26.80 | 25.80 |
| google | 34.10 (+3.10, +10.00%) | 30.00 (+3.20, +11.94%) | 29.60 (+3.80, +14.73%) |
| microsoft | 35.50 (+4.50, +14.52%) | 30.10 (+3.30, +12.31%) | 29.90 (+4.10, +15.89%) |

![Results](img/pl-en.png)

## de-en

| Translator/Dataset | wmt17 | wmt10 | wmt18 | wmt09 | wmt14 | wmt11 | wmt16 | wmt13 | wmt19 | wmt20 | wmt08 | flores-dev | flores-test | wmt12 | wmt15 | iwslt17 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 35.00 | 29.00 | 43.30 | 26.40 | 33.50 | 26.30 | 39.60 | 30.80 | 39.00 | 38.80 | 26.00 | 39.60 | 39.10 | 27.60 | 33.50 | 28.60 |
| google | 38.70 (+3.70, +10.57%) | 32.10 (+3.10, +10.69%) | 46.20 (+2.90, +6.70%) | 27.20 (+0.80, +3.03%) | 37.40 (+3.90, +11.64%) | 27.30 (+1.00, +3.80%) | 42.30 (+2.70, +6.82%) | 32.40 (+1.60, +5.19%) | 41.10 (+2.10, +5.38%) | 41.80 (+3.00, +7.73%) | 27.60 (+1.60, +6.15%) | 43.10 (+3.50, +8.84%) | 42.80 (+3.70, +9.46%) | 29.50 (+1.90, +6.88%) | 36.10 (+2.60, +7.76%) | 30.10 (+1.50, +5.24%) |
| microsoft | 40.80 (+5.80, +16.57%) | 33.40 (+4.40, +15.17%) | 49.60 (+6.30, +14.55%) | 29.10 (+2.70, +10.23%) | 39.20 (+5.70, +17.01%) | 29.20 (+2.90, +11.03%) | 46.30 (+6.70, +16.92%) | 34.30 (+3.50, +11.36%) | 43.80 (+4.80, +12.31%) | 43.60 (+4.80, +12.37%) | 29.40 (+3.40, +13.08%) | 44.90 (+5.30, +13.38%) | 45.80 (+6.70, +17.14%) | 31.30 (+3.70, +13.41%) | 38.10 (+4.60, +13.73%) | 32.50 (+3.90, +13.64%) |

![Results](img/de-en.png)

## en-es

| Translator/Dataset | wmt13 | flores-test | wmt12 | wmt08 | wmt11 | flores-dev | wmt10 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 34.80 | 26.20 | 38.90 | 29.00 | 37.90 | 25.90 | 36.70 | 29.90 |
| google | 36.90 (+2.10, +6.03%) | 30.40 (+4.20, +16.03%) | 40.50 (+1.60, +4.11%) | 30.00 (+1.00, +3.45%) | 39.90 (+2.00, +5.28%) | 30.50 (+4.60, +17.76%) | 38.80 (+2.10, +5.72%) | 30.90 (+1.00, +3.34%) |
| microsoft | 35.70 (+0.90, +2.59%) | 28.50 (+2.30, +8.78%) | 40.00 (+1.10, +2.83%) | 29.90 (+0.90, +3.10%) | 39.10 (+1.20, +3.17%) | 28.40 (+2.50, +9.65%) | 37.80 (+1.10, +3.00%) | 30.70 (+0.80, +2.68%) |

![Results](img/en-es.png)

## en-pt

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 50.30 | 49.40 |
| google | 53.90 (+3.60, +7.16%) | 53.60 (+4.20, +8.50%) |
| microsoft | 50.70 (+0.40, +0.80%) | 49.60 (+0.20, +0.40%) |

![Results](img/en-pt.png)

## en-et

| Translator/Dataset | wmt18 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 25.20 | 25.70 | 25.60 |
| google | 26.60 (+1.40, +5.56%) | 29.00 (+3.30, +12.84%) | 30.20 (+4.60, +17.97%) |
| microsoft | 27.60 (+2.40, +9.52%) | 29.20 (+3.50, +13.62%) | 28.60 (+3.00, +11.72%) |

![Results](img/en-et.png)

## en-bg

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 42.20 | 42.00 |
| google | 45.10 (+2.90, +6.87%) | 44.10 (+2.10, +5.00%) |
| microsoft | 39.10 (-3.10, -7.35%) | 38.00 (-4.00, -9.52%) |

![Results](img/en-bg.png)

## en-de

| Translator/Dataset | wmt12 | wmt16 | wmt11 | wmt15 | wmt13 | iwslt17 | wmt08 | wmt10 | wmt19 | wmt14 | wmt20 | flores-test | wmt18 | wmt17 | wmt09 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.30 | 40.00 | 23.40 | 33.10 | 28.20 | 26.70 | 23.60 | 26.80 | 44.50 | 29.80 | 35.70 | 38.80 | 47.70 | 32.00 | 23.00 | 38.80 |
| google | 24.70 (+0.40, +1.65%) | 38.60 (-1.40, -3.50%) | 24.10 (+0.70, +2.99%) | 33.70 (+0.60, +1.81%) | 28.80 (+0.60, +2.13%) | 28.90 (+2.20, +8.24%) | 23.70 (+0.10, +0.42%) | 26.50 (-0.30, -1.12%) | 43.50 (-1.00, -2.25%) | 30.90 (+1.10, +3.69%) | 36.50 (+0.80, +2.24%) | 42.30 (+3.50, +9.02%) | 47.80 (+0.10, +0.21%) | 31.50 (-0.50, -1.56%) | 23.60 (+0.60, +2.61%) | 43.70 (+4.90, +12.63%) |
| microsoft | 25.30 (+1.00, +4.12%) | 40.50 (+0.50, +1.25%) | 23.70 (+0.30, +1.28%) | 34.30 (+1.20, +3.63%) | 28.80 (+0.60, +2.13%) | 28.20 (+1.50, +5.62%) | 24.00 (+0.40, +1.69%) | 27.20 (+0.40, +1.49%) | 43.80 (-0.70, -1.57%) | 32.20 (+2.40, +8.05%) | 36.10 (+0.40, +1.12%) | 42.90 (+4.10, +10.57%) | 48.70 (+1.00, +2.10%) | 33.10 (+1.10, +3.44%) | 23.90 (+0.90, +3.91%) | 44.00 (+5.20, +13.40%) |

![Results](img/en-de.png)