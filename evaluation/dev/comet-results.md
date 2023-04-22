# What is COMET

COMET is a neural framework its developers present for training multilingual machine translation evaluation models. The framework has been reported to obtain new state-of-the-art levels of correlation with human judgments. Recent breakthroughs in cross-lingual pre-trained language modeling have been leveraged by the framework resulting in highly multilingual and adaptable MT evaluation models.

Three models with different human judgments have been trained to showcase the framework. These include Direct Assessments, Human-mediated Translation Edit Rate, and Multidimensional Quality Metrics. These models are designed to exploit information from source input and a target-language reference translation to more accurately predict MT quality.

The models developed by COMET have achieved new state-of-the-art performance on the WMT 2019 Metrics shared task, demonstrating robustness to high-performing systems.

## Interpreting Scores:

When using COMET to evaluate machine translation, it's important to understand how to interpret the scores it produces.

In general, COMET models are trained to predict quality scores for translations. These scores are typically normalized using a z-score transformation to account for individual differences among annotators. While the raw score itself does not have a direct interpretation, it is useful for ranking translations and systems according to their quality.

However, for the latest COMET models like Unbabel/wmt22-comet-da, we have introduced a new training approach that scales the scores between 0 and 1. This makes it easier to interpret the scores: a score close to 1 indicates a high-quality translation, while a score close to 0 indicates a translation that is no better than random chance.

It's worth noting that when using COMET to compare the performance of two different translation systems, it's important to run the comet-compare command to obtain statistical significance measures. This command compares the output of two systems using a statistical hypothesis test, providing an estimate of the probability that the observed difference in scores between the systems is due to chance. This is an important step to ensure that any differences in scores between systems are statistically significant.

Overall, the added interpretability of scores in the latest COMET models, combined with the ability to assess statistical significance between systems using comet-compare, make COMET a valuable tool for evaluating machine translation.

Source: https://aclanthology.org/2020.emnlp-main.213.pdf

Tool: https://github.com/Unbabel/COMET

# What are these benchmarks

## Translators

1. **bergamot** - uses compiled  [bergamot-translator](https://github.com/mozilla/bergamot-translator)  (wrapper for marian that is used by Firefox Translations web extension)
2. **google** - uses Google Translation [API](https://cloud.google.com/translate)
3. **microsoft** - uses Azure Cognitive Services Translator [API](https://azure.microsoft.com/en-us/services/cognitive-services/translator/)

## Method

We use official WMT ([Conference on Machine Translation](http://statmt.org/wmt21/)) parallel datasets. Available datasets are discovered automatically based on a language pair.

We perform the translation from source to target language using one of the three translation systems, compare the result with the dataset reference, and then calculate the [COMET](https://github.com/Unbabel/COMET) score.

Both absolute and relative differences in the scores between Bergamot and other systems are reported.

We also compare the systems using the `comet-compare` tool that calculates the statistical significance with Paired T-Test and bootstrap resampling.

# Evaluation results

`avg` = average on all datasets



## avg

| Translator/Dataset | en-ru | ca-en | ru-en | en-nl | fa-en | uk-en | en-fa | is-en | nl-en | en-uk |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.55 | 0.65 | 0.49 | 0.59 | 0.50 | 0.52 | 0.31 | 0.15 | 0.64 | 0.52 |
| google | 0.76 (+0.21, +37.78%) | 0.82 (+0.16, +24.75%) | 0.59 (+0.10, +20.11%) | 0.67 (+0.08, +14.11%) | 0.74 (+0.24, +47.56%) | 0.67 (+0.15, +27.90%) | 0.70 (+0.39, +126.18%) | 0.70 (+0.55, +359.56%) | 0.70 (+0.07, +10.35%) | 0.79 (+0.27, +52.74%) |
| microsoft | 0.72 (+0.17, +30.83%) | 0.79 (+0.14, +21.20%) | 0.60 (+0.11, +21.41%) | 0.65 (+0.06, +10.87%) | 0.66 (+0.16, +32.38%) | 0.64 (+0.12, +22.81%) | 0.41 (+0.10, +31.44%) | 0.67 (+0.52, +342.77%) | 0.69 (+0.06, +8.76%) | 0.75 (+0.23, +45.06%) |

![Results](img/avg-comet.png)
---

## en-ru

| Translator/Dataset | wmt18 | wmt21 | wmt20 | wmt16 | flores-test | wmt22 | wmt14 | wmt15 | wmt13 | flores-dev | wmt19 | wmt17 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.60 | 0.41 | 0.41 | 0.60 | 0.58 | 0.44 | 0.71 | 0.65 | 0.53 | 0.57 | 0.48 | 0.65 |
| google | 0.81 (+0.22, +36.20%) | 0.64 (+0.23, +55.68%) | 0.64 (+0.23, +55.17%) | 0.78 (+0.18, +29.62%) | 0.77 (+0.20, +33.79%) | 0.73 (+0.29, +67.07%) | 0.88 (+0.18, +25.38%) | 0.84 (+0.20, +30.16%) | 0.69 (+0.17, +31.25%) | 0.76 (+0.19, +32.84%) | 0.72 (+0.25, +51.24%) | 0.84 (+0.19, +29.16%) |
| microsoft | 0.77 (+0.17, +28.73%) | 0.59 (+0.18, +44.24%) | 0.59 (+0.17, +42.14%) | 0.74 (+0.14, +23.90%) | 0.73 (+0.15, +26.77%) | 0.67 (+0.24, +54.81%) | 0.86 (+0.15, +21.71%) | 0.81 (+0.16, +25.02%) | 0.67 (+0.14, +26.35%) | 0.72 (+0.14, +24.82%) | 0.70 (+0.22, +45.52%) | 0.81 (+0.16, +24.91%) |

![Results](img/en-ru-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt18.en-ru](en-ru/wmt18.en-ru.cometcompare)

#### [wmt21.en-ru](en-ru/wmt21.en-ru.cometcompare)

#### [wmt20.en-ru](en-ru/wmt20.en-ru.cometcompare)

#### [wmt16.en-ru](en-ru/wmt16.en-ru.cometcompare)

#### [flores-test.en-ru](en-ru/flores-test.en-ru.cometcompare)

#### [wmt22.en-ru](en-ru/wmt22.en-ru.cometcompare)

#### [wmt14.en-ru](en-ru/wmt14.en-ru.cometcompare)

#### [wmt15.en-ru](en-ru/wmt15.en-ru.cometcompare)

#### [wmt13.en-ru](en-ru/wmt13.en-ru.cometcompare)

#### [flores-dev.en-ru](en-ru/flores-dev.en-ru.cometcompare)

#### [wmt19.en-ru](en-ru/wmt19.en-ru.cometcompare)

#### [wmt17.en-ru](en-ru/wmt17.en-ru.cometcompare)

---

## ca-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.67 | 0.64 |
| google | 0.82 (+0.15, +22.91%) | 0.81 (+0.17, +26.67%) |
| microsoft | 0.80 (+0.13, +19.34%) | 0.79 (+0.15, +23.14%) |

![Results](img/ca-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.ca-en](ca-en/flores-dev.ca-en.cometcompare)

#### [flores-test.ca-en](ca-en/flores-test.ca-en.cometcompare)

---

## ru-en

| Translator/Dataset | wmt16 | wmt13 | wmt17 | wmt21 | wmt14 | wmt19 | flores-dev | wmt22 | wmt20 | flores-test | wmt15 | mtedx_test | wmt18 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.49 | 0.45 | 0.54 | 0.52 | 0.57 | 0.49 | 0.58 | 0.48 | 0.54 | 0.58 | 0.51 | 0.20 | 0.47 |
| google | 0.59 (+0.10, +21.08%) | 0.53 (+0.08, +18.47%) | 0.64 (+0.10, +19.61%) | 0.61 (+0.09, +17.18%) | 0.67 (+0.11, +18.97%) | 0.56 (+0.08, +15.52%) | 0.67 (+0.10, +16.62%) | 0.61 (+0.14, +28.84%) | 0.61 (+0.07, +13.76%) | 0.67 (+0.09, +15.67%) | 0.61 (+0.10, +20.18%) | 0.30 (+0.10, +51.10%) | 0.60 (+0.12, +25.75%) |
| microsoft | 0.60 (+0.11, +21.60%) | 0.54 (+0.10, +21.75%) | 0.65 (+0.11, +20.94%) | 0.62 (+0.10, +19.08%) | 0.68 (+0.11, +19.64%) | 0.59 (+0.10, +21.49%) | 0.67 (+0.09, +15.12%) | 0.62 (+0.15, +30.82%) | 0.62 (+0.09, +16.15%) | 0.66 (+0.08, +13.61%) | 0.62 (+0.11, +21.30%) | 0.30 (+0.10, +53.09%) | 0.60 (+0.13, +26.83%) |

![Results](img/ru-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt16.ru-en](ru-en/wmt16.ru-en.cometcompare)

#### [wmt13.ru-en](ru-en/wmt13.ru-en.cometcompare)

#### [wmt17.ru-en](ru-en/wmt17.ru-en.cometcompare)

#### [wmt21.ru-en](ru-en/wmt21.ru-en.cometcompare)

#### [wmt14.ru-en](ru-en/wmt14.ru-en.cometcompare)

#### [wmt19.ru-en](ru-en/wmt19.ru-en.cometcompare)

#### [flores-dev.ru-en](ru-en/flores-dev.ru-en.cometcompare)

#### [wmt22.ru-en](ru-en/wmt22.ru-en.cometcompare)

#### [wmt20.ru-en](ru-en/wmt20.ru-en.cometcompare)

#### [flores-test.ru-en](ru-en/flores-test.ru-en.cometcompare)

#### [wmt15.ru-en](ru-en/wmt15.ru-en.cometcompare)

#### [mtedx_test.ru-en](ru-en/mtedx_test.ru-en.cometcompare)

#### [wmt18.ru-en](ru-en/wmt18.ru-en.cometcompare)

---

## en-nl

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.58 | 0.59 |
| google | 0.67 (+0.09, +15.27%) | 0.67 (+0.08, +12.98%) |
| microsoft | 0.65 (+0.07, +12.94%) | 0.64 (+0.05, +8.84%) |

![Results](img/en-nl-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-nl](en-nl/flores-test.en-nl.cometcompare)

#### [flores-dev.en-nl](en-nl/flores-dev.en-nl.cometcompare)

---

## fa-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.49 | 0.51 |
| google | 0.74 (+0.25, +49.90%) | 0.74 (+0.23, +45.28%) |
| microsoft | 0.66 (+0.16, +33.15%) | 0.67 (+0.16, +31.63%) |

![Results](img/fa-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.fa-en](fa-en/flores-dev.fa-en.cometcompare)

#### [flores-test.fa-en](fa-en/flores-test.fa-en.cometcompare)

---

## uk-en

| Translator/Dataset | flores-dev | wmt22 | flores-test |
| --- | --- | --- | --- |
| bergamot | 0.59 | 0.38 | 0.60 |
| google | 0.70 (+0.10, +17.23%) | 0.61 (+0.23, +59.62%) | 0.71 (+0.11, +18.13%) |
| microsoft | 0.68 (+0.09, +14.85%) | 0.56 (+0.18, +46.95%) | 0.69 (+0.09, +15.22%) |

![Results](img/uk-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.uk-en](uk-en/flores-dev.uk-en.cometcompare)

#### [wmt22.uk-en](uk-en/wmt22.uk-en.cometcompare)

#### [flores-test.uk-en](uk-en/flores-test.uk-en.cometcompare)

---

## en-fa

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.30 | 0.32 |
| google | 0.70 (+0.40, +133.58%) | 0.71 (+0.39, +119.38%) |
| microsoft | 0.40 (+0.10, +33.75%) | 0.42 (+0.09, +29.31%) |

![Results](img/en-fa-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-fa](en-fa/flores-dev.en-fa.cometcompare)

#### [flores-test.en-fa](en-fa/flores-test.en-fa.cometcompare)

---

## is-en

| Translator/Dataset | wmt21 | flores-dev | flores-test |
| --- | --- | --- | --- |
| bergamot | 0.02 | 0.21 | 0.22 |
| google | 0.67 (+0.65, +3000.46%) | 0.71 (+0.50, +233.91%) | 0.71 (+0.49, +221.60%) |
| microsoft | 0.66 (+0.64, +2939.63%) | 0.68 (+0.47, +217.66%) | 0.68 (+0.46, +208.62%) |

![Results](img/is-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt21.is-en](is-en/wmt21.is-en.cometcompare)

#### [flores-dev.is-en](is-en/flores-dev.is-en.cometcompare)

#### [flores-test.is-en](is-en/flores-test.is-en.cometcompare)

---

## nl-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.63 | 0.64 |
| google | 0.70 (+0.07, +10.89%) | 0.70 (+0.06, +9.81%) |
| microsoft | 0.69 (+0.06, +9.18%) | 0.69 (+0.05, +8.35%) |

![Results](img/nl-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.nl-en](nl-en/flores-dev.nl-en.cometcompare)

#### [flores-test.nl-en](nl-en/flores-test.nl-en.cometcompare)

---

## en-uk

| Translator/Dataset | wmt22 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.37 | 0.60 | 0.58 |
| google | 0.73 (+0.36, +98.06%) | 0.82 (+0.23, +38.27%) | 0.81 (+0.23, +39.01%) |
| microsoft | 0.67 (+0.30, +83.20%) | 0.79 (+0.20, +33.20%) | 0.78 (+0.19, +33.17%) |

![Results](img/en-uk-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt22.en-uk](en-uk/wmt22.en-uk.cometcompare)

#### [flores-test.en-uk](en-uk/flores-test.en-uk.cometcompare)

#### [flores-dev.en-uk](en-uk/flores-dev.en-uk.cometcompare)

---