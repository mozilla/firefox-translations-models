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
| bergamot | 29.51 | 25.20 | 30.90 | 34.53 | 23.80 | 33.87 | 30.32 |
| google | 31.33 (+1.82, +6.18%) | 26.60 (+1.40, +5.56%) | 32.10 (+1.20, +3.88%) | 36.17 (+1.63, +4.73%) | 25.58 (+1.78, +7.47%) | 34.57 (+0.70, +2.07%) | 31.63 (+1.31, +4.31%) |
| microsoft | 32.42 (+2.92, +9.88%) | 27.60 (+2.40, +9.52%) | 34.10 (+3.20, +10.36%) | 35.53 (+1.00, +2.90%) | 26.83 (+3.03, +12.73%) | 33.74 (-0.13, -0.38%) | 32.13 (+1.81, +5.96%) |

![Results](img/avg.png)

## cs-en

| Translator/Dataset | wmt08 | wmt17 | wmt10 | wmt12 | wmt11 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt09 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.50 | 30.20 | 28.20 | 26.50 | 28.10 | 35.00 | 32.00 | 33.40 | 30.30 | 31.30 | 27.60 | 27.00 |
| google | 26.30 (+1.80, +7.35%) | 31.20 (+1.00, +3.31%) | 30.50 (+2.30, +8.16%) | 28.60 (+2.10, +7.92%) | 30.20 (+2.10, +7.47%) | 38.00 (+3.00, +8.57%) | 33.60 (+1.60, +5.00%) | 34.80 (+1.40, +4.19%) | 32.40 (+2.10, +6.93%) | 32.10 (+0.80, +2.56%) | 29.90 (+2.30, +8.33%) | 28.40 (+1.40, +5.19%) |
| microsoft | 26.40 (+1.90, +7.76%) | 33.60 (+3.40, +11.26%) | 30.70 (+2.50, +8.87%) | 29.70 (+3.20, +12.08%) | 30.90 (+2.80, +9.96%) | 39.90 (+4.90, +14.00%) | 34.70 (+2.70, +8.44%) | 38.30 (+4.90, +14.67%) | 33.40 (+3.10, +10.23%) | 34.30 (+3.00, +9.58%) | 29.60 (+2.00, +7.25%) | 27.60 (+0.60, +2.22%) |

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
| bergamot | 29.00 | 37.90 | 29.90 | 36.70 | 34.80 | 38.90 |
| google | 30.00 (+1.00, +3.45%) | 39.90 (+2.00, +5.28%) | 30.90 (+1.00, +3.34%) | 38.80 (+2.10, +5.72%) | 36.90 (+2.10, +6.03%) | 40.50 (+1.60, +4.11%) |
| microsoft | 29.90 (+0.90, +3.10%) | 39.10 (+1.20, +3.17%) | 30.70 (+0.80, +2.68%) | 37.80 (+1.10, +3.00%) | 35.70 (+0.90, +2.59%) | 40.00 (+1.10, +2.83%) |

![Results](img/en-es.png)

## en-cs

| Translator/Dataset | wmt12 | wmt19 | wmt14 | wmt17 | wmt20 | wmt15 | wmt08 | wmt11 | wmt18 | wmt09 | wmt10 | wmt13 | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 18.80 | 27.10 | 28.70 | 23.40 | 32.70 | 25.40 | 19.00 | 20.70 | 22.70 | 20.80 | 20.90 | 23.40 | 25.80 |
| google | 20.70 (+1.90, +10.11%) | 27.20 (+0.10, +0.37%) | 31.20 (+2.50, +8.71%) | 24.70 (+1.30, +5.56%) | 35.50 (+2.80, +8.56%) | 26.80 (+1.40, +5.51%) | 20.50 (+1.50, +7.89%) | 23.00 (+2.30, +11.11%) | 24.40 (+1.70, +7.49%) | 22.60 (+1.80, +8.65%) | 22.40 (+1.50, +7.18%) | 25.20 (+1.80, +7.69%) | 28.30 (+2.50, +9.69%) |
| microsoft | 22.90 (+4.10, +21.81%) | 27.20 (+0.10, +0.37%) | 31.90 (+3.20, +11.15%) | 25.60 (+2.20, +9.40%) | 34.10 (+1.40, +4.28%) | 27.40 (+2.00, +7.87%) | 22.60 (+3.60, +18.95%) | 25.30 (+4.60, +22.22%) | 24.90 (+2.20, +9.69%) | 25.00 (+4.20, +20.19%) | 24.30 (+3.40, +16.27%) | 27.70 (+4.30, +18.38%) | 29.90 (+4.10, +15.89%) |

![Results](img/en-cs.png)

## es-en

| Translator/Dataset | wmt08 | mtedx_test | wmt10 | wmt12 | wmt11 | wmt13 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.30 | 36.80 | 35.80 | 38.30 | 34.30 | 35.20 | 29.40 |
| google | 28.30 (+1.00, +3.66%) | 35.40 (-1.40, -3.80%) | 37.00 (+1.20, +3.35%) | 38.80 (+0.50, +1.31%) | 35.20 (+0.90, +2.62%) | 35.70 (+0.50, +1.42%) | 31.60 (+2.20, +7.48%) |
| microsoft | 26.80 (-0.50, -1.83%) | 37.60 (+0.80, +2.17%) | 35.40 (-0.40, -1.12%) | 37.80 (-0.50, -1.31%) | 33.70 (-0.60, -1.75%) | 35.30 (+0.10, +0.28%) | 29.60 (+0.20, +0.68%) |

![Results](img/es-en.png)

## en-de

| Translator/Dataset | iwslt17 | wmt20 | wmt08 | wmt12 | wmt19 | wmt10 | wmt11 | wmt09 | wmt13 | wmt17 | wmt16 | wmt18 | wmt14 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 25.70 | 34.10 | 23.40 | 24.00 | 41.50 | 25.80 | 23.00 | 22.80 | 27.60 | 30.80 | 38.20 | 45.60 | 29.50 | 32.50 |
| google | 28.90 (+3.20, +12.45%) | 36.50 (+2.40, +7.04%) | 23.70 (+0.30, +1.28%) | 24.70 (+0.70, +2.92%) | 43.50 (+2.00, +4.82%) | 26.50 (+0.70, +2.71%) | 24.10 (+1.10, +4.78%) | 23.60 (+0.80, +3.51%) | 28.80 (+1.20, +4.35%) | 31.50 (+0.70, +2.27%) | 38.60 (+0.40, +1.05%) | 47.80 (+2.20, +4.82%) | 30.90 (+1.40, +4.75%) | 33.70 (+1.20, +3.69%) |
| microsoft | 28.20 (+2.50, +9.73%) | 36.10 (+2.00, +5.87%) | 24.00 (+0.60, +2.56%) | 25.30 (+1.30, +5.42%) | 43.80 (+2.30, +5.54%) | 27.20 (+1.40, +5.43%) | 23.70 (+0.70, +3.04%) | 23.90 (+1.10, +4.82%) | 28.80 (+1.20, +4.35%) | 33.10 (+2.30, +7.47%) | 40.50 (+2.30, +6.02%) | 48.70 (+3.10, +6.80%) | 32.20 (+2.70, +9.15%) | 34.30 (+1.80, +5.54%) |

![Results](img/en-de.png)