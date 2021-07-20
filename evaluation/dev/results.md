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

| Translator/Dataset | ru-en |
| --- | --- |
| bergamot | 31.84 |
| marian | 31.66 (-0.18, -0.55%) |
| google | 38.06 (+6.22, +19.55%) |
| microsoft | 37.59 (+5.75, +18.06%) |

![Results](img/avg.png)

## ru-en

| Translator/Dataset | wmt13 | wmt14 | wmt15 | wmt16 | wmt17 | wmt18 | wmt19 | wmt20 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 27.10 | 34.50 | 30.60 | 29.60 | 33.60 | 28.80 | 37.00 | 33.50 |
| marian | 26.70 (-0.40, -1.48%) | 34.40 (-0.10, -0.29%) | 30.50 (-0.10, -0.33%) | 29.40 (-0.20, -0.68%) | 33.60 (0.00, 0.00%) | 28.70 (-0.10, -0.35%) | 36.90 (-0.10, -0.27%) | 33.10 (-0.40, -1.19%) |
| google | 31.40 (+4.30, +15.87%) | 41.20 (+6.70, +19.42%) | 37.50 (+6.90, +22.55%) | 36.60 (+7.00, +23.65%) | 41.50 (+7.90, +23.51%) | 36.10 (+7.30, +25.35%) | 42.50 (+5.50, +14.86%) | 37.70 (+4.20, +12.54%) |
| microsoft | 31.20 (+4.10, +15.13%) | 41.70 (+7.20, +20.87%) | 36.40 (+5.80, +18.95%) | 37.60 (+8.00, +27.03%) | 41.60 (+8.00, +23.81%) | 35.80 (+7.00, +24.31%) | 39.70 (+2.70, +7.30%) | 36.70 (+3.20, +9.55%) |

![Results](img/ru-en.png)