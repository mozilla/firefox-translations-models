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

| Translator/Dataset | en-pt | pt-en | en-bg | nb-en | it-en | en-et | fr-en | en-de | es-en | en-it | en-pl | en-es | pl-en | en-fr | et-en | bg-en | de-en | en-cs | cs-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.75 | 0.80 | 0.64 | 0.62 | 0.86 | 0.59 | 0.52 | 0.55 | 0.68 | 0.66 | 0.61 | 0.57 | 0.56 | 0.60 | 0.68 | 0.50 | 0.62 | 0.49 |
| google | 0.93 (+0.06, +7.40%) | 0.80 (+0.05, +6.71%) | 0.88 (+0.09, +10.76%) | 0.81 (+0.17, +25.95%) | 0.68 (+0.06, +9.86%) | 1.07 (+0.21, +24.32%) | 0.65 (+0.06, +10.61%) | 0.60 (+0.09, +16.84%) | 0.62 (+0.06, +11.72%) | 0.76 (+0.08, +11.99%) | 0.82 (+0.16, +24.51%) | 0.69 (+0.08, +12.88%) | 0.66 (+0.09, +16.30%) | 0.67 (+0.11, +20.08%) | 0.77 (+0.17, +27.59%) | 0.75 (+0.07, +10.49%) | 0.61 (+0.11, +22.61%) | 0.83 (+0.21, +34.06%) | 0.61 (+0.13, +26.01%) |
| microsoft | 0.91 (+0.05, +5.52%) | 0.79 (+0.05, +6.06%) | 0.86 (+0.07, +8.18%) | 0.81 (+0.16, +25.25%) | 0.68 (+0.06, +9.86%) | 1.05 (+0.19, +22.39%) | 0.67 (+0.08, +13.04%) | 0.61 (+0.10, +19.11%) | 0.63 (+0.07, +13.54%) | 0.76 (+0.08, +12.50%) | 0.80 (+0.14, +20.59%) | 0.70 (+0.08, +13.71%) | 0.66 (+0.10, +16.85%) | 0.69 (+0.13, +23.12%) | 0.74 (+0.14, +22.89%) | 0.73 (+0.05, +7.05%) | 0.63 (+0.13, +26.46%) | 0.84 (+0.22, +36.42%) | 0.62 (+0.13, +27.19%) |

![Results](img/avg-comet.png)
---

## en-pt

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.87 | 0.86 |
| google | 0.93 (+0.06, +7.48%) | 0.92 (+0.06, +7.32%) |
| microsoft | 0.91 (+0.04, +4.96%) | 0.91 (+0.05, +6.08%) |

![Results](img/en-pt-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-pt](en-pt/flores-dev.en-pt.cometcompare)

#### [flores-test.en-pt](en-pt/flores-test.en-pt.cometcompare)

---

## pt-en

| Translator/Dataset | flores-dev | flores-test | mtedx_test |
| --- | --- | --- | --- |
| bergamot | 0.81 | 0.80 | 0.64 |
| google | 0.85 (+0.04, +4.46%) | 0.85 (+0.05, +6.07%) | 0.70 (+0.07, +10.37%) |
| microsoft | 0.84 (+0.03, +4.24%) | 0.85 (+0.05, +6.07%) | 0.69 (+0.05, +8.35%) |

![Results](img/pt-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.pt-en](pt-en/flores-dev.pt-en.cometcompare)

#### [flores-test.pt-en](pt-en/flores-test.pt-en.cometcompare)

#### [mtedx_test.pt-en](pt-en/mtedx_test.pt-en.cometcompare)

---

## en-bg

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.80 | 0.79 |
| google | 0.89 (+0.09, +10.77%) | 0.88 (+0.09, +10.75%) |
| microsoft | 0.87 (+0.07, +8.37%) | 0.86 (+0.06, +7.99%) |

![Results](img/en-bg-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-bg](en-bg/flores-test.en-bg.cometcompare)

#### [flores-dev.en-bg](en-bg/flores-dev.en-bg.cometcompare)

---

## nb-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.64 | 0.64 |
| google | 0.81 (+0.17, +26.72%) | 0.81 (+0.16, +25.19%) |
| microsoft | 0.81 (+0.17, +25.77%) | 0.80 (+0.16, +24.74%) |

![Results](img/nb-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.nb-en](nb-en/flores-dev.nb-en.cometcompare)

#### [flores-test.nb-en](nb-en/flores-test.nb-en.cometcompare)

---

## it-en

| Translator/Dataset | flores-dev | flores-test | mtedx_test | wmt09 |
| --- | --- | --- | --- | --- |
| bergamot | 0.72 | 0.70 | 0.55 | 0.53 |
| google | 0.76 (+0.04, +5.92%) | 0.76 (+0.06, +8.86%) | 0.62 (+0.07, +12.19%) | 0.60 (+0.07, +14.12%) |
| microsoft | 0.76 (+0.04, +6.09%) | 0.76 (+0.06, +8.33%) | 0.61 (+0.06, +10.72%) | 0.61 (+0.09, +16.11%) |

![Results](img/it-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.it-en](it-en/flores-dev.it-en.cometcompare)

#### [flores-test.it-en](it-en/flores-test.it-en.cometcompare)

#### [mtedx_test.it-en](it-en/mtedx_test.it-en.cometcompare)

#### [wmt09.it-en](it-en/wmt09.it-en.cometcompare)

---

## en-et

| Translator/Dataset | wmt18 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.84 | 0.87 | 0.87 |
| google | 1.03 (+0.20, +23.60%) | 1.07 (+0.20, +23.11%) | 1.09 (+0.23, +26.23%) |
| microsoft | 1.02 (+0.18, +21.97%) | 1.07 (+0.20, +22.59%) | 1.06 (+0.20, +22.60%) |

![Results](img/en-et-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt18.en-et](en-et/wmt18.en-et.cometcompare)

#### [flores-test.en-et](en-et/flores-test.en-et.cometcompare)

#### [flores-dev.en-et](en-et/flores-dev.en-et.cometcompare)

---

## fr-en

| Translator/Dataset | wmt13 | iwslt17 | wmt10 | wmt14 | wmt11 | flores-dev | flores-test | wmt15 | wmt08 | mtedx_test | wmt12 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.58 | 0.68 | 0.53 | 0.65 | 0.51 | 0.77 | 0.77 | 0.56 | 0.44 | 0.62 | 0.50 | 0.50 |
| google | 0.63 (+0.04, +7.32%) | 0.71 (+0.04, +5.64%) | 0.61 (+0.08, +15.82%) | 0.71 (+0.06, +9.32%) | 0.57 (+0.06, +11.73%) | 0.82 (+0.05, +6.97%) | 0.82 (+0.05, +6.00%) | 0.66 (+0.09, +16.85%) | 0.52 (+0.09, +19.87%) | 0.69 (+0.07, +11.00%) | 0.55 (+0.05, +10.05%) | 0.57 (+0.07, +13.86%) |
| microsoft | 0.65 (+0.07, +11.46%) | 0.73 (+0.06, +8.15%) | 0.63 (+0.10, +18.74%) | 0.72 (+0.08, +12.17%) | 0.60 (+0.09, +17.28%) | 0.82 (+0.05, +7.06%) | 0.82 (+0.05, +6.41%) | 0.66 (+0.10, +17.46%) | 0.53 (+0.10, +22.58%) | 0.69 (+0.07, +11.55%) | 0.58 (+0.08, +16.56%) | 0.58 (+0.08, +16.78%) |

![Results](img/fr-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt13.fr-en](fr-en/wmt13.fr-en.cometcompare)

#### [iwslt17.fr-en](fr-en/iwslt17.fr-en.cometcompare)

#### [wmt10.fr-en](fr-en/wmt10.fr-en.cometcompare)

#### [wmt14.fr-en](fr-en/wmt14.fr-en.cometcompare)

#### [wmt11.fr-en](fr-en/wmt11.fr-en.cometcompare)

#### [flores-dev.fr-en](fr-en/flores-dev.fr-en.cometcompare)

#### [flores-test.fr-en](fr-en/flores-test.fr-en.cometcompare)

#### [wmt15.fr-en](fr-en/wmt15.fr-en.cometcompare)

#### [wmt08.fr-en](fr-en/wmt08.fr-en.cometcompare)

#### [mtedx_test.fr-en](fr-en/mtedx_test.fr-en.cometcompare)

#### [wmt12.fr-en](fr-en/wmt12.fr-en.cometcompare)

#### [wmt09.fr-en](fr-en/wmt09.fr-en.cometcompare)

---

## en-de

| Translator/Dataset | wmt12 | wmt16 | wmt15 | flores-dev | wmt21 | wmt17 | wmt10 | flores-test | wmt08 | wmt18 | wmt22 | wmt20 | wmt19 | wmt09 | wmt11 | wmt13 | wmt14 | iwslt17 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.44 | 0.60 | 0.55 | 0.61 | 0.46 | 0.55 | 0.49 | 0.62 | 0.43 | 0.66 | 0.46 | 0.50 | 0.55 | 0.44 | 0.41 | 0.51 | 0.56 | 0.43 |
| google | 0.52 (+0.07, +16.77%) | 0.67 (+0.07, +11.42%) | 0.64 (+0.09, +16.54%) | 0.70 (+0.09, +14.75%) | 0.52 (+0.07, +14.61%) | 0.64 (+0.09, +15.87%) | 0.57 (+0.07, +14.40%) | 0.70 (+0.08, +12.93%) | 0.52 (+0.10, +23.13%) | 0.72 (+0.07, +10.06%) | 0.62 (+0.16, +34.06%) | 0.60 (+0.10, +19.39%) | 0.62 (+0.07, +13.04%) | 0.53 (+0.09, +20.46%) | 0.50 (+0.09, +22.41%) | 0.59 (+0.07, +14.58%) | 0.66 (+0.10, +17.52%) | 0.52 (+0.09, +20.25%) |
| microsoft | 0.54 (+0.09, +21.40%) | 0.69 (+0.08, +13.96%) | 0.64 (+0.10, +17.47%) | 0.70 (+0.09, +14.93%) | 0.55 (+0.09, +20.33%) | 0.64 (+0.10, +17.47%) | 0.59 (+0.09, +18.46%) | 0.71 (+0.08, +13.43%) | 0.54 (+0.11, +26.18%) | 0.73 (+0.08, +11.66%) | 0.63 (+0.16, +35.49%) | 0.61 (+0.11, +21.95%) | 0.64 (+0.09, +15.99%) | 0.54 (+0.10, +23.47%) | 0.52 (+0.11, +27.26%) | 0.60 (+0.09, +16.88%) | 0.66 (+0.10, +18.46%) | 0.52 (+0.09, +20.46%) |

![Results](img/en-de-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt12.en-de](en-de/wmt12.en-de.cometcompare)

#### [wmt16.en-de](en-de/wmt16.en-de.cometcompare)

#### [wmt15.en-de](en-de/wmt15.en-de.cometcompare)

#### [flores-dev.en-de](en-de/flores-dev.en-de.cometcompare)

#### [wmt21.en-de](en-de/wmt21.en-de.cometcompare)

#### [wmt17.en-de](en-de/wmt17.en-de.cometcompare)

#### [wmt10.en-de](en-de/wmt10.en-de.cometcompare)

#### [flores-test.en-de](en-de/flores-test.en-de.cometcompare)

#### [wmt08.en-de](en-de/wmt08.en-de.cometcompare)

#### [wmt18.en-de](en-de/wmt18.en-de.cometcompare)

#### [wmt22.en-de](en-de/wmt22.en-de.cometcompare)

#### [wmt20.en-de](en-de/wmt20.en-de.cometcompare)

#### [wmt19.en-de](en-de/wmt19.en-de.cometcompare)

#### [wmt09.en-de](en-de/wmt09.en-de.cometcompare)

#### [wmt11.en-de](en-de/wmt11.en-de.cometcompare)

#### [wmt13.en-de](en-de/wmt13.en-de.cometcompare)

#### [wmt14.en-de](en-de/wmt14.en-de.cometcompare)

#### [iwslt17.en-de](en-de/iwslt17.en-de.cometcompare)

---

## es-en

| Translator/Dataset | wmt13 | wmt10 | wmt11 | flores-dev | flores-test | wmt08 | mtedx_test | wmt12 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.60 | 0.58 | 0.52 | 0.66 | 0.65 | 0.46 | 0.44 | 0.57 | 0.47 |
| google | 0.65 (+0.04, +7.39%) | 0.65 (+0.06, +11.14%) | 0.57 (+0.04, +8.27%) | 0.74 (+0.08, +12.83%) | 0.74 (+0.08, +12.65%) | 0.52 (+0.06, +12.45%) | 0.53 (+0.09, +21.03%) | 0.61 (+0.04, +7.04%) | 0.55 (+0.07, +15.21%) |
| microsoft | 0.67 (+0.06, +10.71%) | 0.66 (+0.07, +12.47%) | 0.60 (+0.07, +13.91%) | 0.73 (+0.07, +11.02%) | 0.73 (+0.08, +11.54%) | 0.53 (+0.07, +14.55%) | 0.54 (+0.10, +23.36%) | 0.63 (+0.07, +11.60%) | 0.55 (+0.08, +16.58%) |

![Results](img/es-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt13.es-en](es-en/wmt13.es-en.cometcompare)

#### [wmt10.es-en](es-en/wmt10.es-en.cometcompare)

#### [wmt11.es-en](es-en/wmt11.es-en.cometcompare)

#### [flores-dev.es-en](es-en/flores-dev.es-en.cometcompare)

#### [flores-test.es-en](es-en/flores-test.es-en.cometcompare)

#### [wmt08.es-en](es-en/wmt08.es-en.cometcompare)

#### [mtedx_test.es-en](es-en/mtedx_test.es-en.cometcompare)

#### [wmt12.es-en](es-en/wmt12.es-en.cometcompare)

#### [wmt09.es-en](es-en/wmt09.es-en.cometcompare)

---

## en-it

| Translator/Dataset | wmt09 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.65 | 0.69 | 0.70 |
| google | 0.72 (+0.07, +10.99%) | 0.78 (+0.10, +13.97%) | 0.78 (+0.08, +10.98%) |
| microsoft | 0.73 (+0.09, +13.53%) | 0.78 (+0.09, +13.60%) | 0.78 (+0.07, +10.49%) |

![Results](img/en-it-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt09.en-it](en-it/wmt09.en-it.cometcompare)

#### [flores-test.en-it](en-it/flores-test.en-it.cometcompare)

#### [flores-dev.en-it](en-it/flores-dev.en-it.cometcompare)

---

## en-pl

| Translator/Dataset | wmt20 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.63 | 0.67 | 0.68 |
| google | 0.78 (+0.16, +24.86%) | 0.84 (+0.17, +25.25%) | 0.85 (+0.16, +23.46%) |
| microsoft | 0.77 (+0.14, +22.46%) | 0.81 (+0.14, +21.35%) | 0.81 (+0.12, +18.13%) |

![Results](img/en-pl-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt20.en-pl](en-pl/wmt20.en-pl.cometcompare)

#### [flores-test.en-pl](en-pl/flores-test.en-pl.cometcompare)

#### [flores-dev.en-pl](en-pl/flores-dev.en-pl.cometcompare)

---

## en-es

| Translator/Dataset | flores-test | wmt12 | flores-dev | wmt13 | wmt10 | wmt11 | wmt09 | wmt08 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.65 | 0.63 | 0.65 | 0.65 | 0.65 | 0.58 | 0.59 | 0.51 |
| google | 0.76 (+0.11, +17.55%) | 0.69 (+0.06, +9.01%) | 0.75 (+0.10, +16.17%) | 0.71 (+0.06, +8.59%) | 0.72 (+0.08, +12.00%) | 0.66 (+0.07, +12.82%) | 0.65 (+0.06, +10.53%) | 0.60 (+0.09, +16.85%) |
| microsoft | 0.74 (+0.10, +14.77%) | 0.71 (+0.08, +12.32%) | 0.74 (+0.09, +13.92%) | 0.72 (+0.07, +10.66%) | 0.73 (+0.08, +12.85%) | 0.68 (+0.09, +15.98%) | 0.66 (+0.07, +12.59%) | 0.60 (+0.09, +17.42%) |

![Results](img/en-es-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-es](en-es/flores-test.en-es.cometcompare)

#### [wmt12.en-es](en-es/wmt12.en-es.cometcompare)

#### [flores-dev.en-es](en-es/flores-dev.en-es.cometcompare)

#### [wmt13.en-es](en-es/wmt13.en-es.cometcompare)

#### [wmt10.en-es](en-es/wmt10.en-es.cometcompare)

#### [wmt11.en-es](en-es/wmt11.en-es.cometcompare)

#### [wmt09.en-es](en-es/wmt09.en-es.cometcompare)

#### [wmt08.en-es](en-es/wmt08.en-es.cometcompare)

---

## pl-en

| Translator/Dataset | flores-dev | wmt20 | flores-test |
| --- | --- | --- | --- |
| bergamot | 0.59 | 0.53 | 0.58 |
| google | 0.68 (+0.09, +14.95%) | 0.62 (+0.09, +17.28%) | 0.68 (+0.10, +16.78%) |
| microsoft | 0.67 (+0.08, +13.54%) | 0.64 (+0.11, +20.61%) | 0.68 (+0.10, +16.78%) |

![Results](img/pl-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.pl-en](pl-en/flores-dev.pl-en.cometcompare)

#### [wmt20.pl-en](pl-en/wmt20.pl-en.cometcompare)

#### [flores-test.pl-en](pl-en/flores-test.pl-en.cometcompare)

---

## en-fr

| Translator/Dataset | wmt10 | flores-dev | iwslt17 | flores-test | wmt14 | wmt09 | wmt11 | wmt08 | wmt13 | wmt15 | wmt12 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.52 | 0.74 | 0.59 | 0.71 | 0.63 | 0.48 | 0.53 | 0.40 | 0.55 | 0.50 | 0.49 |
| google | 0.63 (+0.12, +22.88%) | 0.83 (+0.10, +13.08%) | 0.67 (+0.08, +13.88%) | 0.84 (+0.13, +17.98%) | 0.75 (+0.12, +18.77%) | 0.59 (+0.11, +21.79%) | 0.62 (+0.09, +17.70%) | 0.54 (+0.13, +33.20%) | 0.64 (+0.10, +17.59%) | 0.67 (+0.17, +34.34%) | 0.58 (+0.09, +18.24%) |
| microsoft | 0.65 (+0.14, +26.42%) | 0.85 (+0.11, +15.04%) | 0.69 (+0.10, +16.57%) | 0.85 (+0.14, +19.16%) | 0.78 (+0.15, +22.98%) | 0.61 (+0.13, +26.35%) | 0.64 (+0.11, +21.40%) | 0.54 (+0.14, +34.81%) | 0.66 (+0.11, +21.01%) | 0.68 (+0.18, +35.90%) | 0.61 (+0.12, +23.99%) |

![Results](img/en-fr-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt10.en-fr](en-fr/wmt10.en-fr.cometcompare)

#### [flores-dev.en-fr](en-fr/flores-dev.en-fr.cometcompare)

#### [iwslt17.en-fr](en-fr/iwslt17.en-fr.cometcompare)

#### [flores-test.en-fr](en-fr/flores-test.en-fr.cometcompare)

#### [wmt14.en-fr](en-fr/wmt14.en-fr.cometcompare)

#### [wmt09.en-fr](en-fr/wmt09.en-fr.cometcompare)

#### [wmt11.en-fr](en-fr/wmt11.en-fr.cometcompare)

#### [wmt08.en-fr](en-fr/wmt08.en-fr.cometcompare)

#### [wmt13.en-fr](en-fr/wmt13.en-fr.cometcompare)

#### [wmt15.en-fr](en-fr/wmt15.en-fr.cometcompare)

#### [wmt12.en-fr](en-fr/wmt12.en-fr.cometcompare)

---

## et-en

| Translator/Dataset | flores-dev | flores-test | wmt18 |
| --- | --- | --- | --- |
| bergamot | 0.64 | 0.64 | 0.53 |
| google | 0.81 (+0.17, +27.28%) | 0.79 (+0.15, +23.50%) | 0.70 (+0.17, +32.95%) |
| microsoft | 0.78 (+0.14, +22.47%) | 0.76 (+0.12, +18.90%) | 0.67 (+0.15, +28.27%) |

![Results](img/et-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.et-en](et-en/flores-dev.et-en.cometcompare)

#### [flores-test.et-en](et-en/flores-test.et-en.cometcompare)

#### [wmt18.et-en](et-en/wmt18.et-en.cometcompare)

---

## bg-en

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.68 | 0.68 |
| google | 0.75 (+0.07, +10.78%) | 0.75 (+0.07, +10.20%) |
| microsoft | 0.73 (+0.05, +7.24%) | 0.73 (+0.05, +6.85%) |

![Results](img/bg-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.bg-en](bg-en/flores-dev.bg-en.cometcompare)

#### [flores-test.bg-en](bg-en/flores-test.bg-en.cometcompare)

---

## de-en

| Translator/Dataset | wmt16 | wmt13 | iwslt17 | wmt10 | wmt17 | wmt21 | wmt14 | wmt19 | wmt11 | flores-dev | wmt22 | wmt20 | flores-test | wmt15 | wmt08 | wmt12 | wmt09 | wmt18 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.56 | 0.51 | 0.48 | 0.45 | 0.52 | 0.48 | 0.49 | 0.42 | 0.39 | 0.68 | 0.40 | 0.54 | 0.68 | 0.52 | 0.40 | 0.39 | 0.41 | 0.59 |
| google | 0.67 (+0.11, +19.14%) | 0.59 (+0.09, +17.02%) | 0.57 (+0.09, +17.90%) | 0.57 (+0.12, +26.30%) | 0.65 (+0.13, +24.59%) | 0.61 (+0.13, +26.55%) | 0.62 (+0.13, +26.73%) | 0.56 (+0.14, +33.82%) | 0.48 (+0.09, +23.84%) | 0.76 (+0.08, +11.20%) | 0.56 (+0.16, +39.97%) | 0.66 (+0.12, +21.72%) | 0.76 (+0.08, +11.39%) | 0.64 (+0.12, +22.16%) | 0.51 (+0.11, +28.55%) | 0.52 (+0.13, +32.01%) | 0.51 (+0.10, +24.67%) | 0.70 (+0.11, +18.64%) |
| microsoft | 0.69 (+0.13, +22.61%) | 0.62 (+0.11, +22.04%) | 0.58 (+0.10, +20.38%) | 0.59 (+0.14, +31.49%) | 0.66 (+0.14, +26.89%) | 0.62 (+0.14, +29.45%) | 0.63 (+0.14, +28.91%) | 0.59 (+0.17, +40.49%) | 0.53 (+0.13, +34.47%) | 0.77 (+0.09, +13.35%) | 0.55 (+0.15, +38.39%) | 0.69 (+0.15, +27.66%) | 0.77 (+0.09, +13.01%) | 0.65 (+0.13, +24.18%) | 0.53 (+0.13, +33.38%) | 0.55 (+0.16, +39.30%) | 0.54 (+0.12, +30.32%) | 0.72 (+0.13, +22.61%) |

![Results](img/de-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt16.de-en](de-en/wmt16.de-en.cometcompare)

#### [wmt13.de-en](de-en/wmt13.de-en.cometcompare)

#### [iwslt17.de-en](de-en/iwslt17.de-en.cometcompare)

#### [wmt10.de-en](de-en/wmt10.de-en.cometcompare)

#### [wmt17.de-en](de-en/wmt17.de-en.cometcompare)

#### [wmt21.de-en](de-en/wmt21.de-en.cometcompare)

#### [wmt14.de-en](de-en/wmt14.de-en.cometcompare)

#### [wmt19.de-en](de-en/wmt19.de-en.cometcompare)

#### [wmt11.de-en](de-en/wmt11.de-en.cometcompare)

#### [flores-dev.de-en](de-en/flores-dev.de-en.cometcompare)

#### [wmt22.de-en](de-en/wmt22.de-en.cometcompare)

#### [wmt20.de-en](de-en/wmt20.de-en.cometcompare)

#### [flores-test.de-en](de-en/flores-test.de-en.cometcompare)

#### [wmt15.de-en](de-en/wmt15.de-en.cometcompare)

#### [wmt08.de-en](de-en/wmt08.de-en.cometcompare)

#### [wmt12.de-en](de-en/wmt12.de-en.cometcompare)

#### [wmt09.de-en](de-en/wmt09.de-en.cometcompare)

#### [wmt18.de-en](de-en/wmt18.de-en.cometcompare)

---

## en-cs

| Translator/Dataset | wmt13 | wmt08 | wmt20 | wmt18 | wmt12 | flores-test | wmt22 | wmt15 | wmt19 | flores-dev | wmt10 | wmt21 | wmt11 | wmt17 | wmt16 | wmt14 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.69 | 0.54 | 0.56 | 0.64 | 0.56 | 0.71 | 0.62 | 0.67 | 0.52 | 0.69 | 0.62 | 0.47 | 0.57 | 0.63 | 0.64 | 0.75 | 0.60 |
| google | 0.85 (+0.16, +23.48%) | 0.78 (+0.23, +42.55%) | 0.78 (+0.22, +40.24%) | 0.81 (+0.17, +27.29%) | 0.76 (+0.20, +35.71%) | 0.94 (+0.22, +31.15%) | 0.97 (+0.35, +56.87%) | 0.86 (+0.19, +28.21%) | 0.72 (+0.19, +36.99%) | 0.93 (+0.24, +35.25%) | 0.81 (+0.20, +31.98%) | 0.65 (+0.18, +39.55%) | 0.77 (+0.21, +36.28%) | 0.81 (+0.18, +28.54%) | 0.85 (+0.20, +31.30%) | 0.95 (+0.20, +26.09%) | 0.81 (+0.21, +35.50%) |
| microsoft | 0.87 (+0.18, +26.24%) | 0.78 (+0.24, +43.93%) | 0.81 (+0.26, +46.36%) | 0.82 (+0.19, +29.54%) | 0.78 (+0.22, +39.87%) | 0.93 (+0.22, +30.79%) | 0.94 (+0.32, +51.72%) | 0.87 (+0.20, +29.32%) | 0.77 (+0.25, +47.26%) | 0.93 (+0.24, +35.06%) | 0.83 (+0.21, +34.19%) | 0.69 (+0.22, +47.65%) | 0.80 (+0.23, +41.09%) | 0.83 (+0.19, +30.58%) | 0.85 (+0.21, +32.08%) | 0.97 (+0.22, +28.96%) | 0.82 (+0.22, +36.38%) |

![Results](img/en-cs-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt13.en-cs](en-cs/wmt13.en-cs.cometcompare)

#### [wmt08.en-cs](en-cs/wmt08.en-cs.cometcompare)

#### [wmt20.en-cs](en-cs/wmt20.en-cs.cometcompare)

#### [wmt18.en-cs](en-cs/wmt18.en-cs.cometcompare)

#### [wmt12.en-cs](en-cs/wmt12.en-cs.cometcompare)

#### [flores-test.en-cs](en-cs/flores-test.en-cs.cometcompare)

#### [wmt22.en-cs](en-cs/wmt22.en-cs.cometcompare)

#### [wmt15.en-cs](en-cs/wmt15.en-cs.cometcompare)

#### [wmt19.en-cs](en-cs/wmt19.en-cs.cometcompare)

#### [flores-dev.en-cs](en-cs/flores-dev.en-cs.cometcompare)

#### [wmt10.en-cs](en-cs/wmt10.en-cs.cometcompare)

#### [wmt21.en-cs](en-cs/wmt21.en-cs.cometcompare)

#### [wmt11.en-cs](en-cs/wmt11.en-cs.cometcompare)

#### [wmt17.en-cs](en-cs/wmt17.en-cs.cometcompare)

#### [wmt16.en-cs](en-cs/wmt16.en-cs.cometcompare)

#### [wmt14.en-cs](en-cs/wmt14.en-cs.cometcompare)

#### [wmt09.en-cs](en-cs/wmt09.en-cs.cometcompare)

---

## cs-en

| Translator/Dataset | wmt16 | wmt13 | wmt10 | wmt17 | wmt21 | wmt14 | wmt11 | flores-dev | wmt22 | wmt20 | flores-test | wmt15 | wmt08 | wmt12 | wmt09 | wmt18 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.49 | 0.50 | 0.44 | 0.45 | 0.48 | 0.58 | 0.42 | 0.65 | 0.56 | 0.35 | 0.65 | 0.49 | 0.37 | 0.43 | 0.43 | 0.48 |
| google | 0.62 (+0.14, +28.02%) | 0.61 (+0.11, +22.27%) | 0.57 (+0.13, +29.34%) | 0.58 (+0.12, +27.16%) | 0.60 (+0.13, +26.57%) | 0.70 (+0.12, +21.51%) | 0.53 (+0.12, +28.57%) | 0.76 (+0.10, +15.57%) | 0.70 (+0.15, +26.20%) | 0.51 (+0.16, +45.11%) | 0.77 (+0.11, +17.54%) | 0.62 (+0.13, +25.73%) | 0.52 (+0.15, +40.50%) | 0.54 (+0.12, +27.53%) | 0.56 (+0.13, +30.04%) | 0.59 (+0.11, +21.91%) |
| microsoft | 0.62 (+0.14, +27.98%) | 0.63 (+0.13, +26.54%) | 0.58 (+0.13, +30.17%) | 0.57 (+0.12, +27.05%) | 0.59 (+0.11, +23.82%) | 0.72 (+0.14, +23.88%) | 0.56 (+0.14, +34.49%) | 0.75 (+0.10, +14.81%) | 0.72 (+0.16, +29.08%) | 0.50 (+0.15, +43.38%) | 0.76 (+0.11, +16.39%) | 0.63 (+0.13, +27.25%) | 0.52 (+0.15, +40.53%) | 0.56 (+0.14, +32.00%) | 0.57 (+0.14, +31.69%) | 0.60 (+0.12, +24.30%) |

![Results](img/cs-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt16.cs-en](cs-en/wmt16.cs-en.cometcompare)

#### [wmt13.cs-en](cs-en/wmt13.cs-en.cometcompare)

#### [wmt10.cs-en](cs-en/wmt10.cs-en.cometcompare)

#### [wmt17.cs-en](cs-en/wmt17.cs-en.cometcompare)

#### [wmt21.cs-en](cs-en/wmt21.cs-en.cometcompare)

#### [wmt14.cs-en](cs-en/wmt14.cs-en.cometcompare)

#### [wmt11.cs-en](cs-en/wmt11.cs-en.cometcompare)

#### [flores-dev.cs-en](cs-en/flores-dev.cs-en.cometcompare)

#### [wmt22.cs-en](cs-en/wmt22.cs-en.cometcompare)

#### [wmt20.cs-en](cs-en/wmt20.cs-en.cometcompare)

#### [flores-test.cs-en](cs-en/flores-test.cs-en.cometcompare)

#### [wmt15.cs-en](cs-en/wmt15.cs-en.cometcompare)

#### [wmt08.cs-en](cs-en/wmt08.cs-en.cometcompare)

#### [wmt12.cs-en](cs-en/wmt12.cs-en.cometcompare)

#### [wmt09.cs-en](cs-en/wmt09.cs-en.cometcompare)

#### [wmt18.cs-en](cs-en/wmt18.cs-en.cometcompare)

---