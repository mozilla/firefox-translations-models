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

| Translator/Dataset | cs-en | en-et | et-en | en-es | en-cs | es-en | en-de |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.47 | 25.20 | 30.90 | 34.52 | 23.79 | 33.86 | 30.34 |
| google | 31.33 (+1.87, +6.33%) | 26.60 (+1.40, +5.56%) | 32.10 (+1.20, +3.88%) | 36.17 (+1.65, +4.78%) | 25.58 (+1.78, +7.50%) | 34.57 (+0.71, +2.11%) | 31.63 (+1.29, +4.24%) |
| microsoft | 32.42 (+2.96, +10.04%) | 27.60 (+2.40, +9.52%) | 34.10 (+3.20, +10.36%) | 35.53 (+1.02, +2.95%) | 26.83 (+3.04, +12.77%) | 33.74 (-0.11, -0.34%) | 32.13 (+1.79, +5.89%) |

![Results](img/avg.png)

## cs-en

| Translator/Dataset | wmt08 | wmt17 | wmt10 | wmt12 | wmt11 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt09 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.50 | 30.20 | 28.10 | 26.40 | 28.10 | 35.00 | 31.70 | 33.40 | 30.40 | 31.30 | 27.50 | 27.00 |
| google | 26.30 (+1.80, +7.35%) | 31.20 (+1.00, +3.31%) | 30.50 (+2.40, +8.54%) | 28.60 (+2.20, +8.33%) | 30.20 (+2.10, +7.47%) | 38.00 (+3.00, +8.57%) | 33.60 (+1.90, +5.99%) | 34.80 (+1.40, +4.19%) | 32.40 (+2.00, +6.58%) | 32.10 (+0.80, +2.56%) | 29.90 (+2.40, +8.73%) | 28.40 (+1.40, +5.19%) |
| microsoft | 26.40 (+1.90, +7.76%) | 33.60 (+3.40, +11.26%) | 30.70 (+2.60, +9.25%) | 29.70 (+3.30, +12.50%) | 30.90 (+2.80, +9.96%) | 39.90 (+4.90, +14.00%) | 34.70 (+3.00, +9.46%) | 38.30 (+4.90, +14.67%) | 33.40 (+3.00, +9.87%) | 34.30 (+3.00, +9.58%) | 29.60 (+2.10, +7.64%) | 27.60 (+0.60, +2.22%) |

![Results](img/cs-en.png)

## en-et

| Translator/Dataset | wmt18 |
| --- | --- |
| bergamot | 25.20 |
| google | 26.60 (+1.40, +5.56%) |
| microsoft | 27.60 (+2.40, +9.52%) |

![Results](img/en-et.png)

## et-en

| Translator/Dataset | wmt18 |
| --- | --- |
| bergamot | 30.90 |
| google | 32.10 (+1.20, +3.88%) |
| microsoft | 34.10 (+3.20, +10.36%) |

![Results](img/et-en.png)

## en-es

| Translator/Dataset | wmt08 | wmt11 | wmt09 | wmt10 | wmt13 | wmt12 |
| --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.00 | 37.90 | 29.80 | 36.80 | 34.80 | 38.80 |
| google | 30.00 (+1.00, +3.45%) | 39.90 (+2.00, +5.28%) | 30.90 (+1.10, +3.69%) | 38.80 (+2.00, +5.43%) | 36.90 (+2.10, +6.03%) | 40.50 (+1.70, +4.38%) |
| microsoft | 29.90 (+0.90, +3.10%) | 39.10 (+1.20, +3.17%) | 30.70 (+0.90, +3.02%) | 37.80 (+1.00, +2.72%) | 35.70 (+0.90, +2.59%) | 40.00 (+1.20, +3.09%) |

![Results](img/en-es.png)

## en-cs

| Translator/Dataset | wmt12 | wmt19 | wmt14 | wmt17 | wmt20 | wmt15 | wmt08 | wmt11 | wmt18 | wmt09 | wmt10 | wmt13 | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 18.90 | 27.00 | 28.70 | 23.50 | 32.60 | 25.40 | 19.10 | 20.70 | 22.60 | 20.80 | 21.00 | 23.20 | 25.80 |
| google | 20.70 (+1.80, +9.52%) | 27.20 (+0.20, +0.74%) | 31.20 (+2.50, +8.71%) | 24.70 (+1.20, +5.11%) | 35.50 (+2.90, +8.90%) | 26.80 (+1.40, +5.51%) | 20.50 (+1.40, +7.33%) | 23.00 (+2.30, +11.11%) | 24.40 (+1.80, +7.96%) | 22.60 (+1.80, +8.65%) | 22.40 (+1.40, +6.67%) | 25.20 (+2.00, +8.62%) | 28.30 (+2.50, +9.69%) |
| microsoft | 22.90 (+4.00, +21.16%) | 27.20 (+0.20, +0.74%) | 31.90 (+3.20, +11.15%) | 25.60 (+2.10, +8.94%) | 34.10 (+1.50, +4.60%) | 27.40 (+2.00, +7.87%) | 22.60 (+3.50, +18.32%) | 25.30 (+4.60, +22.22%) | 24.90 (+2.30, +10.18%) | 25.00 (+4.20, +20.19%) | 24.30 (+3.30, +15.71%) | 27.70 (+4.50, +19.40%) | 29.90 (+4.10, +15.89%) |

![Results](img/en-cs.png)

## es-en

| Translator/Dataset | wmt08 | mtedx_test | wmt10 | wmt12 | wmt11 | wmt13 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.30 | 36.70 | 35.70 | 38.30 | 34.40 | 35.20 | 29.40 |
| google | 28.30 (+1.00, +3.66%) | 35.40 (-1.30, -3.54%) | 37.00 (+1.30, +3.64%) | 38.80 (+0.50, +1.31%) | 35.20 (+0.80, +2.33%) | 35.70 (+0.50, +1.42%) | 31.60 (+2.20, +7.48%) |
| microsoft | 26.80 (-0.50, -1.83%) | 37.60 (+0.90, +2.45%) | 35.40 (-0.30, -0.84%) | 37.80 (-0.50, -1.31%) | 33.70 (-0.70, -2.03%) | 35.30 (+0.10, +0.28%) | 29.60 (+0.20, +0.68%) |

![Results](img/es-en.png)

## en-de

| Translator/Dataset | iwslt17 | wmt20 | wmt08 | wmt12 | wmt19 | wmt10 | wmt11 | wmt09 | wmt13 | wmt17 | wmt16 | wmt18 | wmt14 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 25.70 | 34.30 | 23.40 | 23.90 | 41.40 | 25.70 | 23.00 | 22.80 | 27.70 | 30.80 | 38.40 | 45.60 | 29.50 | 32.60 |
| google | 28.90 (+3.20, +12.45%) | 36.50 (+2.20, +6.41%) | 23.70 (+0.30, +1.28%) | 24.70 (+0.80, +3.35%) | 43.50 (+2.10, +5.07%) | 26.50 (+0.80, +3.11%) | 24.10 (+1.10, +4.78%) | 23.60 (+0.80, +3.51%) | 28.80 (+1.10, +3.97%) | 31.50 (+0.70, +2.27%) | 38.60 (+0.20, +0.52%) | 47.80 (+2.20, +4.82%) | 30.90 (+1.40, +4.75%) | 33.70 (+1.10, +3.37%) |
| microsoft | 28.20 (+2.50, +9.73%) | 36.10 (+1.80, +5.25%) | 24.00 (+0.60, +2.56%) | 25.30 (+1.40, +5.86%) | 43.80 (+2.40, +5.80%) | 27.20 (+1.50, +5.84%) | 23.70 (+0.70, +3.04%) | 23.90 (+1.10, +4.82%) | 28.80 (+1.10, +3.97%) | 33.10 (+2.30, +7.47%) | 40.50 (+2.10, +5.47%) | 48.70 (+3.10, +6.80%) | 32.20 (+2.70, +9.15%) | 34.30 (+1.70, +5.21%) |

![Results](img/en-de.png)