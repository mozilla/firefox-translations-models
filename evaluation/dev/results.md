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

| Translator/Dataset | ru-en | en-ru | it-en | pt-en |
| --- | --- | --- | --- | --- |
| bergamot | 33.74 | 28.51 | 34.30 | 39.70 |
| google | 36.59 (+2.84, +8.43%) | 33.75 (+5.24, +18.37%) | 35.65 (+1.35, +3.94%) | 38.90 (-0.80, -2.02%) |
| microsoft | 37.03 (+3.29, +9.75%) | 33.83 (+5.31, +18.63%) | 36.10 (+1.80, +5.25%) | 40.90 (+1.20, +3.02%) |

![Results](img/avg.png)

## ru-en

| Translator/Dataset | mtedx_test | wmt19 | wmt17 | wmt14 | wmt15 | wmt16 | wmt13 | wmt18 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 24.20 | 39.30 | 37.90 | 38.00 | 33.70 | 33.40 | 29.50 | 32.30 | 35.40 |
| google | 25.00 (+0.80, +3.31%) | 42.40 (+3.10, +7.89%) | 41.50 (+3.60, +9.50%) | 41.20 (+3.20, +8.42%) | 37.50 (+3.80, +11.28%) | 36.60 (+3.20, +9.58%) | 31.40 (+1.90, +6.44%) | 36.00 (+3.70, +11.46%) | 37.70 (+2.30, +6.50%) |
| microsoft | 26.10 (+1.90, +7.85%) | 42.60 (+3.30, +8.40%) | 41.60 (+3.70, +9.76%) | 41.70 (+3.70, +9.74%) | 37.80 (+4.10, +12.17%) | 37.60 (+4.20, +12.57%) | 31.20 (+1.70, +5.76%) | 36.90 (+4.60, +14.24%) | 37.80 (+2.40, +6.78%) |

![Results](img/ru-en.png)

## en-ru

| Translator/Dataset | wmt16 | wmt15 | wmt18 | wmt14 | wmt17 | wmt20 | wmt13 | wmt19 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 28.80 | 29.70 | 26.50 | 35.30 | 31.60 | 21.00 | 25.20 | 30.00 |
| google | 34.00 (+5.20, +18.06%) | 35.00 (+5.30, +17.85%) | 34.10 (+7.60, +28.68%) | 43.40 (+8.10, +22.95%) | 37.30 (+5.70, +18.04%) | 26.40 (+5.40, +25.71%) | 27.60 (+2.40, +9.52%) | 32.20 (+2.20, +7.33%) |
| microsoft | 33.80 (+5.00, +17.36%) | 35.60 (+5.90, +19.87%) | 33.20 (+6.70, +25.28%) | 44.10 (+8.80, +24.93%) | 38.10 (+6.50, +20.57%) | 26.00 (+5.00, +23.81%) | 27.10 (+1.90, +7.54%) | 32.70 (+2.70, +9.00%) |

![Results](img/en-ru.png)

## it-en

| Translator/Dataset | mtedx_test | wmt09 |
| --- | --- | --- |
| bergamot | 35.50 | 33.10 |
| google | 35.90 (+0.40, +1.13%) | 35.40 (+2.30, +6.95%) |
| microsoft | 36.40 (+0.90, +2.54%) | 35.80 (+2.70, +8.16%) |

![Results](img/it-en.png)

## pt-en

| Translator/Dataset | mtedx_test |
| --- | --- |
| bergamot | 39.70 |
| google | 38.90 (-0.80, -2.02%) |
| microsoft | 40.90 (+1.20, +3.02%) |

![Results](img/pt-en.png)