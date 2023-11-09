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
4. **argos** - uses [Argos Translate](https://github.com/argosopentech/argos-translate)
5. **nllb** - uses [No Language Left Behind (NLLB)](https://github.com/facebookresearch/fairseq/tree/nllb)

## Method

We use official WMT ([Conference on Machine Translation](http://statmt.org/wmt21/)) parallel datasets. Available datasets are discovered automatically based on a language pair.

We perform the translation from source to target language using one of the three translation systems, compare the result with the dataset reference, and then calculate the [COMET](https://github.com/Unbabel/COMET) score.

Both absolute and relative differences in the scores between Bergamot and other systems are reported.

We also compare the systems using the `comet-compare` tool that calculates the statistical significance with Paired T-Test and bootstrap resampling.

# Evaluation results

`avg` = average on all datasets



## avg

| Translator/Dataset | hu-en | ru-en | en-hu | fi-en | en-nl | en-ru | en-fa | nl-en | uk-en | fa-en | ca-en | en-uk | is-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.66 | 0.53 | 0.80 | 0.86 | 0.58 | 0.54 | 0.31 | 0.63 | 0.52 | 0.50 | 0.65 | 0.51 | 0.50 |
| google | 0.66 (+0.00, +0.28%) | 0.61 (+0.08, +14.35%) | 0.88 (+0.08, +9.86%) | 0.89 (+0.03, +3.42%) | 0.67 (+0.08, +14.30%) | 0.76 (+0.21, +39.38%) | 0.70 (+0.39, +126.54%) | 0.70 (+0.07, +10.71%) | 0.67 (+0.15, +28.26%) | 0.74 (+0.24, +48.00%) | 0.82 (+0.16, +24.78%) | 0.79 (+0.27, +53.31%) | 0.70 (+0.20, +39.11%) |
| microsoft | 0.66 (+0.00, +0.74%) | 0.60 (+0.07, +12.66%) | 0.89 (+0.08, +10.31%) | 0.89 (+0.03, +3.83%) | 0.65 (+0.06, +11.05%) | 0.72 (+0.18, +32.36%) | 0.41 (+0.10, +31.65%) | 0.69 (+0.06, +9.12%) | 0.64 (+0.12, +23.16%) | 0.66 (+0.16, +32.78%) | 0.79 (+0.14, +21.22%) | 0.75 (+0.23, +45.60%) | 0.67 (+0.17, +34.03%) |
| argos | 0.66 (+0.00, +0.16%) | 0.78 (+0.25, +46.41%) | 0.78 (-0.03, -3.35%) | 0.79 (-0.07, -7.61%) | 0.85 (+0.26, +44.66%) | 0.84 (+0.29, +54.14%) | 0.80 (+0.49, +158.50%) | 0.86 (+0.23, +35.76%) | 0.76 (+0.24, +45.72%) | 0.82 (+0.32, +64.73%) | 0.87 (+0.21, +32.59%) | 0.70 (+0.18, +35.56%) | N/A |
| nllb | 0.70 (+0.04, +5.73%) | 0.83 (+0.30, +57.14%) | 0.83 (+0.02, +2.74%) | 0.65 (-0.20, -23.75%) | 0.85 (+0.27, +46.08%) | 0.86 (+0.31, +57.30%) | 0.84 (+0.53, +169.64%) | 0.81 (+0.17, +27.43%) | 0.82 (+0.29, +56.09%) | 0.83 (+0.33, +66.05%) | 0.83 (+0.17, +26.22%) | 0.83 (+0.31, +61.35%) | 0.63 (+0.13, +25.54%) |

![Results](img/avg-comet.png)
---

## hu-en

| Translator/Dataset | flores-test | wmt08 | wmt09 | flores-dev |
| --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.44 | 0.47 | 0.86 |
| google | 0.76 (-0.09, -11.00%) | 0.54 (+0.10, +22.47%) | 0.57 (+0.10, +20.66%) | 0.77 (-0.09, -10.89%) |
| microsoft | 0.76 (-0.10, -11.10%) | 0.55 (+0.11, +23.95%) | 0.57 (+0.10, +21.81%) | 0.77 (-0.09, -10.77%) |
| argos | 0.68 (-0.18, -20.43%) | 0.63 (+0.19, +42.83%) | 0.63 (+0.16, +34.99%) | 0.69 (-0.17, -20.04%) |
| nllb | 0.70 (-0.16, -18.26%) | 0.68 (+0.24, +53.99%) | 0.69 (+0.22, +46.34%) | 0.72 (-0.15, -17.07%) |

![Results](img/hu-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.hu-en](hu-en/flores-test.hu-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [wmt08.hu-en](hu-en/wmt08.hu-en.cometcompare)
- wmt08.microsoft.en outperforms wmt08.bergamot.en.
- wmt08.google.en outperforms wmt08.bergamot.en.

#### [wmt09.hu-en](hu-en/wmt09.hu-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.

#### [flores-dev.hu-en](hu-en/flores-dev.hu-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## ru-en

| Translator/Dataset | wmt17 | wmt22 | flores-test | wmt15 | wmt20 | mtedx_test | wmt18 | wmt14 | wmt16 | wmt13 | wmt19 | wmt21 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.53 | 0.47 | 0.84 | 0.50 | 0.53 | 0.19 | 0.47 | 0.56 | 0.49 | 0.44 | 0.48 | 0.52 | 0.85 |
| google | 0.64 (+0.11, +20.17%) | 0.61 (+0.14, +29.75%) | 0.67 (-0.17, -20.22%) | 0.61 (+0.11, +21.38%) | 0.61 (+0.08, +14.10%) | 0.30 (+0.10, +51.95%) | 0.60 (+0.12, +26.13%) | 0.67 (+0.11, +19.24%) | 0.59 (+0.11, +22.02%) | 0.53 (+0.09, +19.35%) | 0.56 (+0.08, +16.67%) | 0.61 (+0.09, +18.09%) | 0.87 (+0.03, +3.43%) |
| microsoft | 0.65 (+0.11, +21.50%) | 0.62 (+0.15, +31.74%) | 0.66 (-0.18, -21.64%) | 0.62 (+0.11, +22.51%) | 0.62 (+0.09, +16.50%) | 0.30 (+0.10, +53.96%) | 0.60 (+0.13, +27.21%) | 0.68 (+0.11, +19.91%) | 0.60 (+0.11, +22.55%) | 0.54 (+0.10, +22.66%) | 0.59 (+0.11, +22.70%) | 0.62 (+0.10, +20.00%) | 0.67 (-0.18, -21.24%) |
| argos | 0.78 (+0.25, +47.16%) | 0.75 (+0.28, +59.64%) | 0.80 (-0.04, -4.99%) | 0.78 (+0.28, +55.54%) | 0.77 (+0.24, +45.05%) | 0.73 (+0.54, +277.47%) | 0.78 (+0.31, +64.92%) | 0.79 (+0.23, +40.75%) | 0.78 (+0.29, +59.37%) | 0.77 (+0.33, +75.37%) | 0.76 (+0.28, +57.69%) | 0.77 (+0.25, +48.64%) | 0.80 (-0.04, -4.86%) |
| nllb | 0.84 (+0.31, +57.59%) | 0.82 (+0.35, +73.54%) | 0.85 (+0.01, +1.03%) | 0.84 (+0.33, +66.28%) | 0.84 (+0.30, +56.83%) | 0.78 (+0.58, +299.18%) | 0.83 (+0.36, +76.62%) | 0.85 (+0.29, +50.56%) | 0.84 (+0.35, +71.50%) | 0.83 (+0.38, +86.80%) | 0.83 (+0.35, +72.58%) | 0.83 (+0.32, +61.13%) | 0.86 (+0.01, +1.31%) |

![Results](img/ru-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt17.ru-en](ru-en/wmt17.ru-en.cometcompare)
- wmt17.microsoft.en outperforms wmt17.bergamot.en.
- wmt17.google.en outperforms wmt17.bergamot.en.
- wmt17.microsoft.en outperforms wmt17.google.en.

#### [wmt22.ru-en](ru-en/wmt22.ru-en.cometcompare)
- wmt22.microsoft.en outperforms wmt22.bergamot.en.
- wmt22.google.en outperforms wmt22.bergamot.en.

#### [flores-test.ru-en](ru-en/flores-test.ru-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [wmt15.ru-en](ru-en/wmt15.ru-en.cometcompare)
- wmt15.microsoft.en outperforms wmt15.bergamot.en.
- wmt15.google.en outperforms wmt15.bergamot.en.

#### [wmt20.ru-en](ru-en/wmt20.ru-en.cometcompare)
- wmt20.microsoft.en outperforms wmt20.bergamot.en.
- wmt20.google.en outperforms wmt20.bergamot.en.
- wmt20.microsoft.en outperforms wmt20.google.en.

#### [mtedx_test.ru-en](ru-en/mtedx_test.ru-en.cometcompare)
- mtedx_test.microsoft.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.bergamot.en.

#### [wmt18.ru-en](ru-en/wmt18.ru-en.cometcompare)
- wmt18.microsoft.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.bergamot.en.

#### [wmt14.ru-en](ru-en/wmt14.ru-en.cometcompare)
- wmt14.microsoft.en outperforms wmt14.bergamot.en.
- wmt14.google.en outperforms wmt14.bergamot.en.

#### [wmt16.ru-en](ru-en/wmt16.ru-en.cometcompare)
- wmt16.microsoft.en outperforms wmt16.bergamot.en.
- wmt16.google.en outperforms wmt16.bergamot.en.

#### [wmt13.ru-en](ru-en/wmt13.ru-en.cometcompare)
- wmt13.microsoft.en outperforms wmt13.bergamot.en.
- wmt13.google.en outperforms wmt13.bergamot.en.
- wmt13.microsoft.en outperforms wmt13.google.en.

#### [wmt19.ru-en](ru-en/wmt19.ru-en.cometcompare)
- wmt19.microsoft.en outperforms wmt19.bergamot.en.
- wmt19.google.en outperforms wmt19.bergamot.en.
- wmt19.microsoft.en outperforms wmt19.google.en.

#### [wmt21.ru-en](ru-en/wmt21.ru-en.cometcompare)
- wmt21.microsoft.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.bergamot.en.

#### [flores-dev.ru-en](ru-en/flores-dev.ru-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## en-hu

| Translator/Dataset | flores-dev | wmt09 | flores-test | wmt08 |
| --- | --- | --- | --- | --- |
| bergamot | 0.81 | 0.79 | 0.82 | 0.79 |
| google | 0.90 (+0.09, +10.96%) | 0.86 (+0.08, +9.95%) | 0.90 (+0.08, +9.28%) | 0.87 (+0.07, +9.26%) |
| microsoft | 0.90 (+0.09, +11.20%) | 0.87 (+0.09, +10.91%) | 0.90 (+0.08, +9.62%) | 0.87 (+0.08, +9.51%) |
| argos | 0.79 (-0.02, -2.65%) | 0.77 (-0.02, -2.39%) | 0.79 (-0.04, -4.26%) | 0.76 (-0.03, -4.09%) |
| nllb | 0.84 (+0.02, +2.98%) | 0.81 (+0.03, +3.45%) | 0.84 (+0.02, +2.02%) | 0.81 (+0.02, +2.52%) |

![Results](img/en-hu-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-hu](en-hu/flores-dev.en-hu.cometcompare)
- flores-dev.microsoft.hu outperforms flores-dev.bergamot.hu.
- flores-dev.google.hu outperforms flores-dev.bergamot.hu.

#### [wmt09.en-hu](en-hu/wmt09.en-hu.cometcompare)
- wmt09.microsoft.hu outperforms wmt09.bergamot.hu.
- wmt09.google.hu outperforms wmt09.bergamot.hu.
- wmt09.microsoft.hu outperforms wmt09.google.hu.

#### [flores-test.en-hu](en-hu/flores-test.en-hu.cometcompare)
- flores-test.microsoft.hu outperforms flores-test.bergamot.hu.
- flores-test.google.hu outperforms flores-test.bergamot.hu.
- flores-test.microsoft.hu outperforms flores-test.google.hu.

#### [wmt08.en-hu](en-hu/wmt08.en-hu.cometcompare)
- wmt08.microsoft.hu outperforms wmt08.bergamot.hu.
- wmt08.google.hu outperforms wmt08.bergamot.hu.

---

## fi-en

| Translator/Dataset | wmt17 | flores-test | wmt15 | wmt18 | wmt16 | wmt19 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.87 | 0.85 | 0.84 | 0.85 | 0.85 | 0.87 |
| google | 0.89 (+0.03, +3.33%) | 0.90 (+0.03, +3.46%) | 0.88 (+0.03, +3.40%) | 0.86 (+0.02, +2.89%) | 0.88 (+0.03, +3.48%) | 0.88 (+0.03, +3.89%) | 0.90 (+0.03, +3.50%) |
| microsoft | 0.90 (+0.03, +3.68%) | 0.90 (+0.03, +3.57%) | 0.89 (+0.04, +4.14%) | 0.87 (+0.03, +3.79%) | 0.89 (+0.03, +3.93%) | 0.89 (+0.04, +4.16%) | 0.90 (+0.03, +3.54%) |
| argos | 0.79 (-0.07, -8.26%) | 0.82 (-0.05, -5.96%) | 0.79 (-0.06, -7.43%) | 0.78 (-0.06, -7.50%) | 0.78 (-0.07, -8.29%) | 0.77 (-0.08, -9.90%) | 0.82 (-0.05, -6.01%) |
| nllb | 0.66 (-0.21, -24.25%) | 0.66 (-0.21, -23.86%) | 0.65 (-0.20, -23.43%) | 0.64 (-0.20, -23.42%) | 0.66 (-0.19, -22.27%) | 0.63 (-0.22, -25.67%) | 0.67 (-0.20, -23.33%) |

![Results](img/fi-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt17.fi-en](fi-en/wmt17.fi-en.cometcompare)
- wmt17.microsoft.en outperforms wmt17.bergamot.en.
- wmt17.google.en outperforms wmt17.bergamot.en.
- wmt17.microsoft.en outperforms wmt17.google.en.

#### [flores-test.fi-en](fi-en/flores-test.fi-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [wmt15.fi-en](fi-en/wmt15.fi-en.cometcompare)
- wmt15.microsoft.en outperforms wmt15.bergamot.en.
- wmt15.google.en outperforms wmt15.bergamot.en.
- wmt15.microsoft.en outperforms wmt15.google.en.

#### [wmt18.fi-en](fi-en/wmt18.fi-en.cometcompare)
- wmt18.microsoft.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.bergamot.en.
- wmt18.microsoft.en outperforms wmt18.google.en.

#### [wmt16.fi-en](fi-en/wmt16.fi-en.cometcompare)
- wmt16.microsoft.en outperforms wmt16.bergamot.en.
- wmt16.google.en outperforms wmt16.bergamot.en.
- wmt16.microsoft.en outperforms wmt16.google.en.

#### [wmt19.fi-en](fi-en/wmt19.fi-en.cometcompare)
- wmt19.microsoft.en outperforms wmt19.bergamot.en.
- wmt19.google.en outperforms wmt19.bergamot.en.
- wmt19.microsoft.en outperforms wmt19.google.en.

#### [flores-dev.fi-en](fi-en/flores-dev.fi-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## en-nl

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.59 | 0.58 |
| google | 0.67 (+0.08, +13.04%) | 0.67 (+0.09, +15.59%) |
| microsoft | 0.64 (+0.05, +8.90%) | 0.65 (+0.08, +13.25%) |
| argos | 0.84 (+0.25, +42.71%) | 0.85 (+0.27, +46.65%) |
| nllb | 0.85 (+0.26, +44.23%) | 0.86 (+0.28, +47.97%) |

![Results](img/en-nl-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-nl](en-nl/flores-dev.en-nl.cometcompare)
- flores-dev.microsoft.nl outperforms flores-dev.bergamot.nl.
- flores-dev.google.nl outperforms flores-dev.bergamot.nl.
- flores-dev.google.nl outperforms flores-dev.microsoft.nl.

#### [flores-test.en-nl](en-nl/flores-test.en-nl.cometcompare)
- flores-test.microsoft.nl outperforms flores-test.bergamot.nl.
- flores-test.google.nl outperforms flores-test.bergamot.nl.
- flores-test.google.nl outperforms flores-test.microsoft.nl.

---

## en-ru

| Translator/Dataset | wmt19 | wmt21 | wmt15 | wmt13 | wmt20 | wmt16 | wmt22 | wmt14 | flores-dev | flores-test | wmt18 | wmt17 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.47 | 0.40 | 0.64 | 0.52 | 0.41 | 0.59 | 0.43 | 0.70 | 0.57 | 0.57 | 0.59 | 0.64 |
| google | 0.72 (+0.25, +53.03%) | 0.64 (+0.23, +57.93%) | 0.84 (+0.20, +31.50%) | 0.69 (+0.17, +32.58%) | 0.64 (+0.23, +57.66%) | 0.78 (+0.18, +31.02%) | 0.73 (+0.30, +70.07%) | 0.88 (+0.18, +26.42%) | 0.76 (+0.20, +34.95%) | 0.77 (+0.20, +34.81%) | 0.81 (+0.22, +37.57%) | 0.84 (+0.20, +30.61%) |
| microsoft | 0.70 (+0.22, +47.24%) | 0.59 (+0.19, +46.32%) | 0.81 (+0.17, +26.31%) | 0.67 (+0.14, +27.63%) | 0.59 (+0.18, +44.41%) | 0.74 (+0.15, +25.24%) | 0.67 (+0.25, +57.60%) | 0.86 (+0.16, +22.72%) | 0.72 (+0.15, +26.80%) | 0.73 (+0.16, +27.74%) | 0.77 (+0.18, +30.02%) | 0.81 (+0.17, +26.32%) |
| argos | 0.81 (+0.34, +71.05%) | 0.80 (+0.39, +97.94%) | 0.86 (+0.22, +34.53%) | 0.85 (+0.32, +61.92%) | 0.81 (+0.41, +100.84%) | 0.85 (+0.25, +42.61%) | 0.81 (+0.38, +89.10%) | 0.88 (+0.18, +25.45%) | 0.85 (+0.28, +50.02%) | 0.85 (+0.27, +47.70%) | 0.86 (+0.27, +45.08%) | 0.86 (+0.22, +34.19%) |
| nllb | 0.84 (+0.36, +76.97%) | 0.83 (+0.42, +105.22%) | 0.87 (+0.23, +36.19%) | 0.86 (+0.33, +63.79%) | 0.84 (+0.44, +107.42%) | 0.86 (+0.27, +45.56%) | 0.83 (+0.41, +95.02%) | 0.89 (+0.19, +26.95%) | 0.86 (+0.29, +51.80%) | 0.86 (+0.29, +49.86%) | 0.87 (+0.28, +47.74%) | 0.87 (+0.23, +35.91%) |

![Results](img/en-ru-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt19.en-ru](en-ru/wmt19.en-ru.cometcompare)
- wmt19.microsoft.ru outperforms wmt19.bergamot.ru.
- wmt19.google.ru outperforms wmt19.bergamot.ru.
- wmt19.google.ru outperforms wmt19.microsoft.ru.

#### [wmt21.en-ru](en-ru/wmt21.en-ru.cometcompare)
- wmt21.microsoft.ru outperforms wmt21.bergamot.ru.
- wmt21.google.ru outperforms wmt21.bergamot.ru.
- wmt21.google.ru outperforms wmt21.microsoft.ru.

#### [wmt15.en-ru](en-ru/wmt15.en-ru.cometcompare)
- wmt15.microsoft.ru outperforms wmt15.bergamot.ru.
- wmt15.google.ru outperforms wmt15.bergamot.ru.
- wmt15.google.ru outperforms wmt15.microsoft.ru.

#### [wmt13.en-ru](en-ru/wmt13.en-ru.cometcompare)
- wmt13.microsoft.ru outperforms wmt13.bergamot.ru.
- wmt13.google.ru outperforms wmt13.bergamot.ru.
- wmt13.google.ru outperforms wmt13.microsoft.ru.

#### [wmt20.en-ru](en-ru/wmt20.en-ru.cometcompare)
- wmt20.microsoft.ru outperforms wmt20.bergamot.ru.
- wmt20.google.ru outperforms wmt20.bergamot.ru.
- wmt20.google.ru outperforms wmt20.microsoft.ru.

#### [wmt16.en-ru](en-ru/wmt16.en-ru.cometcompare)
- wmt16.microsoft.ru outperforms wmt16.bergamot.ru.
- wmt16.google.ru outperforms wmt16.bergamot.ru.
- wmt16.google.ru outperforms wmt16.microsoft.ru.

#### [wmt22.en-ru](en-ru/wmt22.en-ru.cometcompare)
- wmt22.microsoft.ru outperforms wmt22.bergamot.ru.
- wmt22.google.ru outperforms wmt22.bergamot.ru.
- wmt22.google.ru outperforms wmt22.microsoft.ru.

#### [wmt14.en-ru](en-ru/wmt14.en-ru.cometcompare)
- wmt14.microsoft.ru outperforms wmt14.bergamot.ru.
- wmt14.google.ru outperforms wmt14.bergamot.ru.
- wmt14.google.ru outperforms wmt14.microsoft.ru.

#### [flores-dev.en-ru](en-ru/flores-dev.en-ru.cometcompare)
- flores-dev.microsoft.ru outperforms flores-dev.bergamot.ru.
- flores-dev.google.ru outperforms flores-dev.bergamot.ru.
- flores-dev.google.ru outperforms flores-dev.microsoft.ru.

#### [flores-test.en-ru](en-ru/flores-test.en-ru.cometcompare)
- flores-test.microsoft.ru outperforms flores-test.bergamot.ru.
- flores-test.google.ru outperforms flores-test.bergamot.ru.
- flores-test.google.ru outperforms flores-test.microsoft.ru.

#### [wmt18.en-ru](en-ru/wmt18.en-ru.cometcompare)
- wmt18.microsoft.ru outperforms wmt18.bergamot.ru.
- wmt18.google.ru outperforms wmt18.bergamot.ru.
- wmt18.google.ru outperforms wmt18.microsoft.ru.

#### [wmt17.en-ru](en-ru/wmt17.en-ru.cometcompare)
- wmt17.microsoft.ru outperforms wmt17.bergamot.ru.
- wmt17.google.ru outperforms wmt17.bergamot.ru.
- wmt17.google.ru outperforms wmt17.microsoft.ru.

---

## en-fa

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.32 | 0.30 |
| google | 0.71 (+0.39, +119.58%) | 0.70 (+0.40, +134.13%) |
| microsoft | 0.42 (+0.10, +29.43%) | 0.40 (+0.10, +34.06%) |
| argos | 0.80 (+0.48, +148.27%) | 0.80 (+0.50, +169.64%) |
| nllb | 0.84 (+0.51, +158.18%) | 0.84 (+0.54, +182.13%) |

![Results](img/en-fa-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-fa](en-fa/flores-test.en-fa.cometcompare)
- flores-test.microsoft.fa outperforms flores-test.bergamot.fa.
- flores-test.google.fa outperforms flores-test.bergamot.fa.
- flores-test.google.fa outperforms flores-test.microsoft.fa.

#### [flores-dev.en-fa](en-fa/flores-dev.en-fa.cometcompare)
- flores-dev.microsoft.fa outperforms flores-dev.bergamot.fa.
- flores-dev.google.fa outperforms flores-dev.bergamot.fa.
- flores-dev.google.fa outperforms flores-dev.microsoft.fa.

---

## nl-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.64 | 0.63 |
| google | 0.70 (+0.07, +10.23%) | 0.70 (+0.07, +11.21%) |
| microsoft | 0.69 (+0.06, +8.75%) | 0.69 (+0.06, +9.49%) |
| argos | 0.86 (+0.22, +34.80%) | 0.86 (+0.23, +36.73%) |
| nllb | 0.81 (+0.17, +26.70%) | 0.81 (+0.18, +28.17%) |

![Results](img/nl-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.nl-en](nl-en/flores-test.nl-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [flores-dev.nl-en](nl-en/flores-dev.nl-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## uk-en

| Translator/Dataset | wmt22 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.38 | 0.60 | 0.59 |
| google | 0.61 (+0.23, +60.58%) | 0.71 (+0.11, +18.39%) | 0.70 (+0.10, +17.39%) |
| microsoft | 0.56 (+0.18, +47.84%) | 0.69 (+0.09, +15.47%) | 0.68 (+0.09, +15.01%) |
| argos | 0.70 (+0.32, +82.64%) | 0.80 (+0.20, +33.48%) | 0.80 (+0.20, +34.29%) |
| nllb | 0.78 (+0.40, +105.38%) | 0.83 (+0.24, +39.82%) | 0.83 (+0.24, +40.76%) |

![Results](img/uk-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt22.uk-en](uk-en/wmt22.uk-en.cometcompare)
- wmt22.microsoft.en outperforms wmt22.bergamot.en.
- wmt22.google.en outperforms wmt22.bergamot.en.
- wmt22.google.en outperforms wmt22.microsoft.en.

#### [flores-test.uk-en](uk-en/flores-test.uk-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [flores-dev.uk-en](uk-en/flores-dev.uk-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## fa-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.51 | 0.49 |
| google | 0.74 (+0.23, +45.97%) | 0.74 (+0.25, +50.08%) |
| microsoft | 0.67 (+0.16, +32.25%) | 0.66 (+0.16, +33.31%) |
| argos | 0.82 (+0.32, +62.82%) | 0.82 (+0.33, +66.69%) |
| nllb | 0.83 (+0.32, +64.24%) | 0.83 (+0.34, +67.90%) |

![Results](img/fa-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.fa-en](fa-en/flores-test.fa-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [flores-dev.fa-en](fa-en/flores-dev.fa-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## ca-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.64 | 0.67 |
| google | 0.81 (+0.17, +26.99%) | 0.82 (+0.15, +22.68%) |
| microsoft | 0.79 (+0.15, +23.44%) | 0.80 (+0.13, +19.11%) |
| argos | 0.86 (+0.23, +35.50%) | 0.87 (+0.20, +29.83%) |
| nllb | 0.82 (+0.19, +28.99%) | 0.83 (+0.16, +23.57%) |

![Results](img/ca-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.ca-en](ca-en/flores-test.ca-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [flores-dev.ca-en](ca-en/flores-dev.ca-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## en-uk

| Translator/Dataset | flores-test | flores-dev | wmt22 |
| --- | --- | --- | --- |
| bergamot | 0.60 | 0.58 | 0.36 |
| google | 0.82 (+0.23, +38.00%) | 0.81 (+0.23, +40.14%) | 0.73 (+0.36, +99.31%) |
| microsoft | 0.79 (+0.20, +32.94%) | 0.78 (+0.20, +34.26%) | 0.67 (+0.31, +84.35%) |
| argos | 0.70 (+0.10, +17.21%) | 0.70 (+0.12, +21.09%) | 0.69 (+0.32, +88.61%) |
| nllb | 0.84 (+0.24, +40.79%) | 0.84 (+0.27, +45.87%) | 0.80 (+0.44, +119.60%) |

![Results](img/en-uk-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-uk](en-uk/flores-test.en-uk.cometcompare)
- flores-test.microsoft.uk outperforms flores-test.bergamot.uk.
- flores-test.google.uk outperforms flores-test.bergamot.uk.
- flores-test.google.uk outperforms flores-test.microsoft.uk.

#### [flores-dev.en-uk](en-uk/flores-dev.en-uk.cometcompare)
- flores-dev.microsoft.uk outperforms flores-dev.bergamot.uk.
- flores-dev.google.uk outperforms flores-dev.bergamot.uk.
- flores-dev.google.uk outperforms flores-dev.microsoft.uk.

#### [wmt22.en-uk](en-uk/wmt22.en-uk.cometcompare)
- wmt22.microsoft.uk outperforms wmt22.bergamot.uk.
- wmt22.google.uk outperforms wmt22.bergamot.uk.
- wmt22.google.uk outperforms wmt22.microsoft.uk.

---

## is-en

| Translator/Dataset | flores-test | wmt21 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.75 | 0.02 | 0.74 |
| google | 0.71 (-0.04, -5.15%) | 0.67 (+0.66, +4185.35%) | 0.71 (-0.03, -3.92%) |
| microsoft | 0.68 (-0.07, -8.98%) | 0.66 (+0.64, +4101.27%) | 0.68 (-0.06, -8.60%) |
| argos | N/A | N/A | N/A |
| nllb | 0.63 (-0.12, -16.34%) | 0.63 (+0.62, +3926.11%) | 0.63 (-0.11, -14.70%) |

![Results](img/is-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.is-en](is-en/flores-test.is-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [wmt21.is-en](is-en/wmt21.is-en.cometcompare)
- wmt21.microsoft.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.microsoft.en.

#### [flores-dev.is-en](is-en/flores-dev.is-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---