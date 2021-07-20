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

| Translator/Dataset | cs-en | en-cs | en-de | en-es | en-et | es-en | et-en |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 29.49 | 23.80 | 30.56 | 34.37 | 25.20 | 33.40 | 31.00 |
| marian | 29.35 (-0.14, -0.48%) | 23.56 (-0.24, -1.00%) | 30.56 (0.00, 0.00%) | 34.42 (+0.05, +0.15%) | 25.30 (+0.10, +0.40%) | 33.43 (+0.03, +0.10%) | 31.10 (+0.10, +0.32%) |
| google | 31.33 (+1.84, +6.24%) | 25.58 (+1.78, +7.47%) | 31.84 (+1.28, +4.18%) | 36.17 (+1.80, +5.24%) | 26.60 (+1.40, +5.56%) | 34.43 (+1.03, +3.09%) | 32.10 (+1.10, +3.55%) |
| microsoft | 32.42 (+2.93, +9.95%) | 26.83 (+3.03, +12.73%) | 32.43 (+1.87, +6.12%) | 35.53 (+1.17, +3.39%) | 27.60 (+2.40, +9.52%) | 33.10 (-0.30, -0.90%) | 34.10 (+3.10, +10.00%) |

![Results](img/avg.png)

## cs-en

| Translator/Dataset | wmt08 | wmt09 | wmt10 | wmt11 | wmt12 | wmt13 | wmt14 | wmt15 | wmt16 | wmt17 | wmt18 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.30 | 27.50 | 28.10 | 28.40 | 26.70 | 30.40 | 35.00 | 31.70 | 33.40 | 30.30 | 31.30 | 26.80 |
| marian | 24.40 (+0.10, +0.41%) | 27.50 (0.00, 0.00%) | 27.90 (-0.20, -0.71%) | 28.10 (-0.30, -1.06%) | 26.60 (-0.10, -0.37%) | 30.20 (-0.20, -0.66%) | 34.90 (-0.10, -0.29%) | 31.60 (-0.10, -0.32%) | 33.30 (-0.10, -0.30%) | 30.10 (-0.20, -0.66%) | 31.30 (0.00, 0.00%) | 26.30 (-0.50, -1.87%) |
| google | 26.30 (+2.00, +8.23%) | 29.90 (+2.40, +8.73%) | 30.50 (+2.40, +8.54%) | 30.20 (+1.80, +6.34%) | 28.60 (+1.90, +7.12%) | 32.40 (+2.00, +6.58%) | 38.00 (+3.00, +8.57%) | 33.60 (+1.90, +5.99%) | 34.80 (+1.40, +4.19%) | 31.20 (+0.90, +2.97%) | 32.10 (+0.80, +2.56%) | 28.40 (+1.60, +5.97%) |
| microsoft | 26.40 (+2.10, +8.64%) | 29.60 (+2.10, +7.64%) | 30.70 (+2.60, +9.25%) | 30.90 (+2.50, +8.80%) | 29.70 (+3.00, +11.24%) | 33.40 (+3.00, +9.87%) | 39.90 (+4.90, +14.00%) | 34.70 (+3.00, +9.46%) | 38.30 (+4.90, +14.67%) | 33.60 (+3.30, +10.89%) | 34.30 (+3.00, +9.58%) | 27.60 (+0.80, +2.99%) |

![Results](img/cs-en.png)

## en-cs

| Translator/Dataset | wmt08 | wmt09 | wmt10 | wmt11 | wmt12 | wmt13 | wmt14 | wmt15 | wmt16 | wmt17 | wmt18 | wmt19 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 19.00 | 20.90 | 21.00 | 20.50 | 19.00 | 23.30 | 28.80 | 25.20 | 25.70 | 23.40 | 22.70 | 27.20 | 32.70 |
| marian | 19.00 (0.00, 0.00%) | 20.80 (-0.10, -0.48%) | 20.90 (-0.10, -0.48%) | 20.40 (-0.10, -0.49%) | 18.90 (-0.10, -0.53%) | 23.10 (-0.20, -0.86%) | 28.60 (-0.20, -0.69%) | 24.90 (-0.30, -1.19%) | 25.40 (-0.30, -1.17%) | 23.10 (-0.30, -1.28%) | 22.60 (-0.10, -0.44%) | 26.70 (-0.50, -1.84%) | 31.90 (-0.80, -2.45%) |
| google | 20.50 (+1.50, +7.89%) | 22.60 (+1.70, +8.13%) | 22.40 (+1.40, +6.67%) | 23.00 (+2.50, +12.20%) | 20.70 (+1.70, +8.95%) | 25.20 (+1.90, +8.15%) | 31.20 (+2.40, +8.33%) | 26.80 (+1.60, +6.35%) | 28.30 (+2.60, +10.12%) | 24.70 (+1.30, +5.56%) | 24.40 (+1.70, +7.49%) | 27.20 (0.00, 0.00%) | 35.50 (+2.80, +8.56%) |
| microsoft | 22.60 (+3.60, +18.95%) | 25.00 (+4.10, +19.62%) | 24.30 (+3.30, +15.71%) | 25.30 (+4.80, +23.41%) | 22.90 (+3.90, +20.53%) | 27.70 (+4.40, +18.88%) | 31.90 (+3.10, +10.76%) | 27.40 (+2.20, +8.73%) | 29.90 (+4.20, +16.34%) | 25.60 (+2.20, +9.40%) | 24.90 (+2.20, +9.69%) | 27.20 (0.00, 0.00%) | 34.10 (+1.40, +4.28%) |

![Results](img/en-cs.png)

## en-de

| Translator/Dataset | wmt08 | wmt09 | wmt10 | wmt11 | wmt12 | wmt13 | wmt14 | wmt15 | wmt16 | wmt17 | wmt18 | wmt19 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 23.30 | 22.70 | 25.80 | 22.90 | 23.90 | 27.60 | 29.30 | 32.30 | 38.40 | 30.70 | 45.10 | 41.40 | 33.90 |
| marian | 23.50 (+0.20, +0.86%) | 22.90 (+0.20, +0.88%) | 25.90 (+0.10, +0.39%) | 23.00 (+0.10, +0.44%) | 23.90 (0.00, 0.00%) | 27.70 (+0.10, +0.36%) | 29.50 (+0.20, +0.68%) | 32.30 (0.00, 0.00%) | 38.50 (+0.10, +0.26%) | 30.80 (+0.10, +0.33%) | 45.10 (0.00, 0.00%) | 41.60 (+0.20, +0.48%) | 32.60 (-1.30, -3.83%) |
| google | 23.70 (+0.40, +1.72%) | 23.60 (+0.90, +3.96%) | 26.50 (+0.70, +2.71%) | 24.10 (+1.20, +5.24%) | 24.70 (+0.80, +3.35%) | 28.80 (+1.20, +4.35%) | 30.90 (+1.60, +5.46%) | 33.70 (+1.40, +4.33%) | 38.60 (+0.20, +0.52%) | 31.50 (+0.80, +2.61%) | 47.80 (+2.70, +5.99%) | 43.50 (+2.10, +5.07%) | 36.50 (+2.60, +7.67%) |
| microsoft | 24.00 (+0.70, +3.00%) | 23.90 (+1.20, +5.29%) | 27.20 (+1.40, +5.43%) | 23.70 (+0.80, +3.49%) | 25.30 (+1.40, +5.86%) | 28.80 (+1.20, +4.35%) | 32.20 (+2.90, +9.90%) | 34.30 (+2.00, +6.19%) | 40.50 (+2.10, +5.47%) | 33.10 (+2.40, +7.82%) | 48.70 (+3.60, +7.98%) | 43.80 (+2.40, +5.80%) | 36.10 (+2.20, +6.49%) |

![Results](img/en-de.png)

## en-es

| Translator/Dataset | wmt08 | wmt09 | wmt10 | wmt11 | wmt12 | wmt13 |
| --- | --- | --- | --- | --- | --- | --- |
| bergamot | 28.90 | 29.70 | 36.60 | 37.70 | 38.60 | 34.70 |
| marian | 28.90 (0.00, 0.00%) | 29.80 (+0.10, +0.34%) | 36.70 (+0.10, +0.27%) | 37.70 (0.00, 0.00%) | 38.70 (+0.10, +0.26%) | 34.70 (0.00, 0.00%) |
| google | 30.00 (+1.10, +3.81%) | 30.90 (+1.20, +4.04%) | 38.80 (+2.20, +6.01%) | 39.90 (+2.20, +5.84%) | 40.50 (+1.90, +4.92%) | 36.90 (+2.20, +6.34%) |
| microsoft | 29.90 (+1.00, +3.46%) | 30.70 (+1.00, +3.37%) | 37.80 (+1.20, +3.28%) | 39.10 (+1.40, +3.71%) | 40.00 (+1.40, +3.63%) | 35.70 (+1.00, +2.88%) |

![Results](img/en-es.png)

## en-et

| Translator/Dataset | wmt18 |
| --- | --- |
| bergamot | 25.20 |
| marian | 25.30 (+0.10, +0.40%) |
| google | 26.60 (+1.40, +5.56%) |
| microsoft | 27.60 (+2.40, +9.52%) |

![Results](img/en-et.png)

## es-en

| Translator/Dataset | wmt08 | wmt09 | wmt10 | wmt11 | wmt12 | wmt13 |
| --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.20 | 29.50 | 35.90 | 34.30 | 38.20 | 35.30 |
| marian | 27.20 (0.00, 0.00%) | 29.50 (0.00, 0.00%) | 35.90 (0.00, 0.00%) | 34.40 (+0.10, +0.29%) | 38.20 (0.00, 0.00%) | 35.40 (+0.10, +0.28%) |
| google | 28.30 (+1.10, +4.04%) | 31.60 (+2.10, +7.12%) | 37.00 (+1.10, +3.06%) | 35.20 (+0.90, +2.62%) | 38.80 (+0.60, +1.57%) | 35.70 (+0.40, +1.13%) |
| microsoft | 26.80 (-0.40, -1.47%) | 29.60 (+0.10, +0.34%) | 35.40 (-0.50, -1.39%) | 33.70 (-0.60, -1.75%) | 37.80 (-0.40, -1.05%) | 35.30 (0.00, 0.00%) |

![Results](img/es-en.png)

## et-en

| Translator/Dataset | wmt18 |
| --- | --- |
| bergamot | 31.00 |
| marian | 31.10 (+0.10, +0.32%) |
| google | 32.10 (+1.10, +3.55%) |
| microsoft | 34.10 (+3.10, +10.00%) |

![Results](img/et-en.png)