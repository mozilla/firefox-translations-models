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
| bergamot | 29.49 | 25.20 | 31.00 | 34.37 | 23.80 | 33.86 | 30.23 |
| google | 31.33 (+1.84, +6.24%) | 26.60 (+1.40, +5.56%) | 32.10 (+1.10, +3.55%) | 36.17 (+1.80, +5.24%) | 25.58 (+1.78, +7.47%) | 34.57 (+0.71, +2.11%) | 31.63 (+1.40, +4.63%) |
| microsoft | 32.42 (+2.93, +9.95%) | 27.60 (+2.40, +9.52%) | 34.10 (+3.10, +10.00%) | 35.53 (+1.17, +3.39%) | 26.83 (+3.03, +12.73%) | 33.74 (-0.11, -0.34%) | 32.13 (+1.90, +6.29%) |

![Results](img/avg.png)

## cs-en

| Translator/Dataset | wmt08 | wmt17 | wmt10 | wmt12 | wmt11 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt09 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.30 | 30.30 | 28.10 | 26.70 | 28.40 | 35.00 | 31.70 | 33.40 | 30.40 | 31.30 | 27.50 | 26.80 |
| google | 26.30 (+2.00, +8.23%) | 31.20 (+0.90, +2.97%) | 30.50 (+2.40, +8.54%) | 28.60 (+1.90, +7.12%) | 30.20 (+1.80, +6.34%) | 38.00 (+3.00, +8.57%) | 33.60 (+1.90, +5.99%) | 34.80 (+1.40, +4.19%) | 32.40 (+2.00, +6.58%) | 32.10 (+0.80, +2.56%) | 29.90 (+2.40, +8.73%) | 28.40 (+1.60, +5.97%) |
| microsoft | 26.40 (+2.10, +8.64%) | 33.60 (+3.30, +10.89%) | 30.70 (+2.60, +9.25%) | 29.70 (+3.00, +11.24%) | 30.90 (+2.50, +8.80%) | 39.90 (+4.90, +14.00%) | 34.70 (+3.00, +9.46%) | 38.30 (+4.90, +14.67%) | 33.40 (+3.00, +9.87%) | 34.30 (+3.00, +9.58%) | 29.60 (+2.10, +7.64%) | 27.60 (+0.80, +2.99%) |

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
| bergamot | 31.00 |
| google | 32.10 (+1.10, +3.55%) |
| microsoft | 34.10 (+3.10, +10.00%) |

![Results](img/et-en.png)

## en-es

| Translator/Dataset | wmt08 | wmt11 | wmt09 | wmt10 | wmt13 | wmt12 |
| --- | --- | --- | --- | --- | --- | --- |
| bergamot | 28.90 | 37.70 | 29.70 | 36.60 | 34.70 | 38.60 |
| google | 30.00 (+1.10, +3.81%) | 39.90 (+2.20, +5.84%) | 30.90 (+1.20, +4.04%) | 38.80 (+2.20, +6.01%) | 36.90 (+2.20, +6.34%) | 40.50 (+1.90, +4.92%) |
| microsoft | 29.90 (+1.00, +3.46%) | 39.10 (+1.40, +3.71%) | 30.70 (+1.00, +3.37%) | 37.80 (+1.20, +3.28%) | 35.70 (+1.00, +2.88%) | 40.00 (+1.40, +3.63%) |

![Results](img/en-es.png)

## en-cs

| Translator/Dataset | wmt12 | wmt19 | wmt14 | wmt17 | wmt20 | wmt15 | wmt08 | wmt11 | wmt18 | wmt09 | wmt10 | wmt13 | wmt16 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 19.00 | 27.20 | 28.80 | 23.40 | 32.70 | 25.20 | 19.00 | 20.50 | 22.70 | 20.90 | 21.00 | 23.30 | 25.70 |
| google | 20.70 (+1.70, +8.95%) | 27.20 (0.00, 0.00%) | 31.20 (+2.40, +8.33%) | 24.70 (+1.30, +5.56%) | 35.50 (+2.80, +8.56%) | 26.80 (+1.60, +6.35%) | 20.50 (+1.50, +7.89%) | 23.00 (+2.50, +12.20%) | 24.40 (+1.70, +7.49%) | 22.60 (+1.70, +8.13%) | 22.40 (+1.40, +6.67%) | 25.20 (+1.90, +8.15%) | 28.30 (+2.60, +10.12%) |
| microsoft | 22.90 (+3.90, +20.53%) | 27.20 (0.00, 0.00%) | 31.90 (+3.10, +10.76%) | 25.60 (+2.20, +9.40%) | 34.10 (+1.40, +4.28%) | 27.40 (+2.20, +8.73%) | 22.60 (+3.60, +18.95%) | 25.30 (+4.80, +23.41%) | 24.90 (+2.20, +9.69%) | 25.00 (+4.10, +19.62%) | 24.30 (+3.30, +15.71%) | 27.70 (+4.40, +18.88%) | 29.90 (+4.20, +16.34%) |

![Results](img/en-cs.png)

## es-en

| Translator/Dataset | wmt08 | mtedx_test | wmt10 | wmt12 | wmt11 | wmt13 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.20 | 36.60 | 35.90 | 38.20 | 34.30 | 35.30 | 29.50 |
| google | 28.30 (+1.10, +4.04%) | 35.40 (-1.20, -3.28%) | 37.00 (+1.10, +3.06%) | 38.80 (+0.60, +1.57%) | 35.20 (+0.90, +2.62%) | 35.70 (+0.40, +1.13%) | 31.60 (+2.10, +7.12%) |
| microsoft | 26.80 (-0.40, -1.47%) | 37.60 (+1.00, +2.73%) | 35.40 (-0.50, -1.39%) | 37.80 (-0.40, -1.05%) | 33.70 (-0.60, -1.75%) | 35.30 (0.00, 0.00%) | 29.60 (+0.10, +0.34%) |

![Results](img/es-en.png)

## en-de

| Translator/Dataset | iwslt17 | wmt20 | wmt08 | wmt12 | wmt19 | wmt10 | wmt11 | wmt09 | wmt13 | wmt17 | wmt16 | wmt18 | wmt14 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 25.90 | 33.90 | 23.30 | 23.90 | 41.40 | 25.80 | 22.90 | 22.70 | 27.60 | 30.70 | 38.40 | 45.10 | 29.30 | 32.30 |
| google | 28.90 (+3.00, +11.58%) | 36.50 (+2.60, +7.67%) | 23.70 (+0.40, +1.72%) | 24.70 (+0.80, +3.35%) | 43.50 (+2.10, +5.07%) | 26.50 (+0.70, +2.71%) | 24.10 (+1.20, +5.24%) | 23.60 (+0.90, +3.96%) | 28.80 (+1.20, +4.35%) | 31.50 (+0.80, +2.61%) | 38.60 (+0.20, +0.52%) | 47.80 (+2.70, +5.99%) | 30.90 (+1.60, +5.46%) | 33.70 (+1.40, +4.33%) |
| microsoft | 28.20 (+2.30, +8.88%) | 36.10 (+2.20, +6.49%) | 24.00 (+0.70, +3.00%) | 25.30 (+1.40, +5.86%) | 43.80 (+2.40, +5.80%) | 27.20 (+1.40, +5.43%) | 23.70 (+0.80, +3.49%) | 23.90 (+1.20, +5.29%) | 28.80 (+1.20, +4.35%) | 33.10 (+2.40, +7.82%) | 40.50 (+2.10, +5.47%) | 48.70 (+3.60, +7.98%) | 32.20 (+2.90, +9.90%) | 34.30 (+2.00, +6.19%) |

![Results](img/en-de.png)