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
6. **opus-mt** - uses [Opus-MT models](https://github.com/Helsinki-NLP/Opus-MT)

## Method

We use official WMT ([Conference on Machine Translation](http://statmt.org/wmt21/)) parallel datasets. Available datasets are discovered automatically based on a language pair.

We perform the translation from source to target language using one of the three translation systems, compare the result with the dataset reference, and then calculate the [COMET](https://github.com/Unbabel/COMET) score.

Both absolute and relative differences in the scores between Bergamot and other systems are reported.

We also compare the systems using the `comet-compare` tool that calculates the statistical significance with Paired T-Test and bootstrap resampling.

# Evaluation results

`avg` = average on all datasets



## avg

| Translator/Dataset | cs-en | tr-en | en-et | hu-en | ru-en | mt-en | en-hu | el-en | fi-en | en-ru | en-fa | et-en | nb-en | uk-en | fa-en | ca-en | en-uk | is-en | en-cs | sl-en | lt-en |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.82 | 0.85 | 0.87 | 0.84 | 0.82 | 0.76 | 0.80 | 0.85 | 0.86 | 0.84 | 0.79 | 0.85 | 0.85 | 0.83 | 0.83 | 0.85 | 0.83 | 0.73 | 0.83 | 0.84 | 0.80 |
| google | 0.85 (+0.03, +3.75%) | 0.89 (+0.04, +4.71%) | 0.91 (+0.04, +4.95%) | 0.86 (+0.03, +3.01%) | 0.85 (+0.02, +2.89%) | 0.84 (+0.08, +10.71%) | 0.88 (+0.08, +9.85%) | 0.87 (+0.02, +2.73%) | 0.89 (+0.03, +3.42%) | 0.90 (+0.06, +6.72%) | 0.88 (+0.09, +11.26%) | 0.89 (+0.04, +5.14%) | 0.89 (+0.04, +5.23%) | 0.87 (+0.04, +4.48%) | 0.89 (+0.06, +7.07%) | 0.89 (+0.05, +5.32%) | 0.90 (+0.07, +8.26%) | 0.87 (+0.14, +18.68%) | 0.89 (+0.06, +7.36%) | 0.88 (+0.05, +5.48%) | 0.87 (+0.06, +7.94%) |
| microsoft | 0.85 (+0.03, +4.13%) | 0.89 (+0.04, +4.50%) | 0.91 (+0.04, +4.67%) | 0.87 (+0.03, +3.29%) | 0.85 (+0.03, +3.29%) | 0.83 (+0.07, +9.25%) | 0.89 (+0.08, +10.31%) | 0.87 (+0.02, +2.62%) | 0.89 (+0.03, +3.83%) | 0.89 (+0.05, +5.59%) | 0.82 (+0.02, +3.03%) | 0.88 (+0.04, +4.25%) | 0.89 (+0.04, +5.13%) | 0.86 (+0.03, +3.78%) | 0.87 (+0.04, +4.79%) | 0.89 (+0.04, +4.92%) | 0.89 (+0.06, +7.15%) | 0.86 (+0.13, +17.94%) | 0.90 (+0.07, +7.82%) | 0.87 (+0.03, +4.08%) | 0.86 (+0.05, +6.77%) |
| argos | 0.71 (-0.11, -13.54%) | 0.76 (-0.09, -10.40%) | 0.86 (-0.02, -1.73%) | 0.66 (-0.18, -21.30%) | 0.78 (-0.05, -5.92%) | N/A | 0.78 (-0.03, -3.35%) | 0.85 (+0.00, +0.25%) | 0.79 (-0.07, -7.61%) | 0.84 (-0.00, -0.21%) | 0.80 (+0.01, +1.43%) | 0.86 (+0.01, +1.63%) | 0.87 (+0.02, +2.10%) | 0.76 (-0.07, -8.33%) | 0.82 (-0.01, -0.64%) | 0.87 (+0.02, +2.23%) | 0.70 (-0.14, -16.31%) | N/A | 0.68 (-0.16, -18.74%) | N/A | N/A |
| nllb | 0.73 (-0.09, -11.15%) | 0.77 (-0.08, -9.17%) | 0.83 (-0.04, -4.59%) | 0.70 (-0.14, -16.93%) | 0.83 (+0.01, +0.98%) | 0.62 (-0.14, -17.90%) | 0.83 (+0.02, +2.74%) | 0.85 (+0.00, +0.50%) | 0.65 (-0.20, -23.75%) | 0.86 (+0.02, +1.84%) | 0.84 (+0.05, +5.81%) | 0.59 (-0.25, -30.00%) | 0.76 (-0.09, -10.49%) | 0.82 (-0.02, -1.81%) | 0.83 (+0.00, +0.16%) | 0.83 (-0.02, -2.68%) | 0.83 (-0.00, -0.39%) | 0.63 (-0.10, -13.68%) | 0.84 (+0.01, +1.41%) | 0.68 (-0.15, -18.21%) | 0.67 (-0.13, -16.62%) |
| opusmt | 0.82 (+0.00, +0.21%) | 0.85 (-0.00, -0.05%) | 0.86 (-0.01, -1.30%) | 0.84 (+0.00, +0.58%) | 0.82 (-0.01, -1.13%) | N/A | 0.84 (+0.04, +4.68%) | N/A | 0.86 (+0.01, +0.63%) | 0.84 (+0.00, +0.10%) | N/A | 0.86 (+0.02, +2.05%) | N/A | 0.80 (-0.03, -3.99%) | N/A | 0.78 (-0.06, -7.63%) | 0.79 (-0.04, -4.37%) | 0.78 (+0.05, +7.09%) | 0.84 (+0.01, +1.36%) | N/A | N/A |

![Results](img/avg-comet.png)
---

## cs-en

| Translator/Dataset | wmt20 | wmt17 | wmt22 | flores-test | wmt08 | wmt12 | wmt15 | wmt21 | wmt11 | wmt18 | wmt09 | wmt14 | wmt10 | wmt16 | wmt13 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.78 | 0.82 | 0.83 | 0.86 | 0.80 | 0.81 | 0.82 | 0.82 | 0.80 | 0.82 | 0.81 | 0.84 | 0.81 | 0.82 | 0.83 | 0.86 |
| google | 0.82 (+0.03, +4.36%) | 0.85 (+0.03, +3.80%) | 0.87 (+0.04, +4.39%) | 0.89 (+0.03, +3.55%) | 0.83 (+0.04, +4.81%) | 0.84 (+0.03, +3.58%) | 0.85 (+0.03, +3.69%) | 0.85 (+0.03, +3.37%) | 0.83 (+0.03, +3.40%) | 0.85 (+0.03, +3.03%) | 0.84 (+0.03, +3.68%) | 0.87 (+0.03, +3.69%) | 0.84 (+0.03, +4.18%) | 0.85 (+0.03, +4.09%) | 0.85 (+0.03, +3.26%) | 0.89 (+0.03, +3.25%) |
| microsoft | 0.82 (+0.04, +4.71%) | 0.85 (+0.03, +3.96%) | 0.87 (+0.04, +4.93%) | 0.89 (+0.03, +3.49%) | 0.84 (+0.04, +4.86%) | 0.84 (+0.04, +4.41%) | 0.86 (+0.03, +4.19%) | 0.85 (+0.03, +3.43%) | 0.84 (+0.04, +4.42%) | 0.85 (+0.03, +3.64%) | 0.84 (+0.03, +4.14%) | 0.88 (+0.04, +4.33%) | 0.84 (+0.04, +4.33%) | 0.85 (+0.03, +4.21%) | 0.86 (+0.03, +4.09%) | 0.89 (+0.03, +3.14%) |
| argos | 0.65 (-0.14, -17.44%) | 0.70 (-0.11, -13.92%) | 0.68 (-0.15, -18.40%) | 0.78 (-0.08, -9.61%) | 0.69 (-0.10, -13.01%) | 0.70 (-0.11, -13.11%) | 0.70 (-0.12, -15.01%) | 0.70 (-0.12, -14.71%) | 0.71 (-0.09, -11.66%) | 0.70 (-0.12, -14.90%) | 0.70 (-0.11, -13.11%) | 0.72 (-0.12, -14.22%) | 0.71 (-0.10, -12.24%) | 0.71 (-0.11, -13.40%) | 0.73 (-0.10, -12.16%) | 0.77 (-0.09, -10.17%) |
| nllb | 0.67 (-0.11, -14.16%) | 0.72 (-0.10, -11.67%) | 0.71 (-0.13, -15.04%) | 0.78 (-0.07, -8.65%) | 0.72 (-0.07, -9.30%) | 0.72 (-0.08, -10.34%) | 0.72 (-0.11, -13.05%) | 0.72 (-0.10, -11.81%) | 0.72 (-0.08, -10.00%) | 0.72 (-0.10, -12.44%) | 0.73 (-0.08, -10.34%) | 0.74 (-0.10, -11.54%) | 0.73 (-0.08, -9.44%) | 0.72 (-0.10, -11.81%) | 0.74 (-0.09, -10.44%) | 0.79 (-0.07, -8.56%) |
| opusmt | 0.76 (-0.02, -2.19%) | 0.82 (-0.00, -0.23%) | 0.83 (-0.00, -0.12%) | 0.87 (+0.01, +0.73%) | 0.80 (+0.01, +0.85%) | 0.82 (+0.01, +0.89%) | 0.82 (+0.00, +0.13%) | 0.82 (-0.00, -0.15%) | 0.81 (+0.01, +0.86%) | 0.82 (-0.00, -0.36%) | 0.82 (+0.01, +0.85%) | 0.84 (+0.00, +0.04%) | 0.81 (+0.01, +0.64%) | 0.82 (+0.00, +0.16%) | 0.83 (+0.01, +0.76%) | 0.86 (+0.00, +0.43%) |

![Results](img/cs-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt20.cs-en](cs-en/wmt20.cs-en.cometcompare)
- wmt20.microsoft.en outperforms wmt20.bergamot.en.
- wmt20.google.en outperforms wmt20.bergamot.en.

#### [wmt17.cs-en](cs-en/wmt17.cs-en.cometcompare)
- wmt17.microsoft.en outperforms wmt17.bergamot.en.
- wmt17.google.en outperforms wmt17.bergamot.en.

#### [wmt22.cs-en](cs-en/wmt22.cs-en.cometcompare)
- wmt22.microsoft.en outperforms wmt22.bergamot.en.
- wmt22.google.en outperforms wmt22.bergamot.en.
- wmt22.microsoft.en outperforms wmt22.google.en.

#### [flores-test.cs-en](cs-en/flores-test.cs-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [wmt08.cs-en](cs-en/wmt08.cs-en.cometcompare)
- wmt08.microsoft.en outperforms wmt08.bergamot.en.
- wmt08.google.en outperforms wmt08.bergamot.en.

#### [wmt12.cs-en](cs-en/wmt12.cs-en.cometcompare)
- wmt12.microsoft.en outperforms wmt12.bergamot.en.
- wmt12.google.en outperforms wmt12.bergamot.en.
- wmt12.microsoft.en outperforms wmt12.google.en.

#### [wmt15.cs-en](cs-en/wmt15.cs-en.cometcompare)
- wmt15.microsoft.en outperforms wmt15.bergamot.en.
- wmt15.google.en outperforms wmt15.bergamot.en.

#### [wmt21.cs-en](cs-en/wmt21.cs-en.cometcompare)
- wmt21.microsoft.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.microsoft.en.

#### [wmt11.cs-en](cs-en/wmt11.cs-en.cometcompare)
- wmt11.microsoft.en outperforms wmt11.bergamot.en.
- wmt11.google.en outperforms wmt11.bergamot.en.
- wmt11.microsoft.en outperforms wmt11.google.en.

#### [wmt18.cs-en](cs-en/wmt18.cs-en.cometcompare)
- wmt18.microsoft.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.bergamot.en.
- wmt18.microsoft.en outperforms wmt18.google.en.

#### [wmt09.cs-en](cs-en/wmt09.cs-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.
- wmt09.microsoft.en outperforms wmt09.google.en.

#### [wmt14.cs-en](cs-en/wmt14.cs-en.cometcompare)
- wmt14.microsoft.en outperforms wmt14.bergamot.en.
- wmt14.google.en outperforms wmt14.bergamot.en.
- wmt14.microsoft.en outperforms wmt14.google.en.

#### [wmt10.cs-en](cs-en/wmt10.cs-en.cometcompare)
- wmt10.microsoft.en outperforms wmt10.bergamot.en.
- wmt10.google.en outperforms wmt10.bergamot.en.

#### [wmt16.cs-en](cs-en/wmt16.cs-en.cometcompare)
- wmt16.microsoft.en outperforms wmt16.bergamot.en.
- wmt16.google.en outperforms wmt16.bergamot.en.

#### [wmt13.cs-en](cs-en/wmt13.cs-en.cometcompare)
- wmt13.microsoft.en outperforms wmt13.bergamot.en.
- wmt13.google.en outperforms wmt13.bergamot.en.
- wmt13.microsoft.en outperforms wmt13.google.en.

#### [flores-dev.cs-en](cs-en/flores-dev.cs-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## tr-en

| Translator/Dataset | wmt17 | flores-test | wmt18 | wmt16 | flores-dev |
| --- | --- | --- | --- | --- | --- |
| bergamot | 0.84 | 0.87 | 0.83 | 0.83 | 0.87 |
| google | 0.88 (+0.04, +5.24%) | 0.90 (+0.04, +4.21%) | 0.88 (+0.04, +5.07%) | 0.88 (+0.04, +5.32%) | 0.90 (+0.03, +3.79%) |
| microsoft | 0.88 (+0.04, +4.81%) | 0.90 (+0.04, +4.07%) | 0.88 (+0.04, +5.21%) | 0.87 (+0.04, +4.88%) | 0.90 (+0.03, +3.58%) |
| argos | 0.74 (-0.10, -12.03%) | 0.79 (-0.08, -8.95%) | 0.73 (-0.10, -12.05%) | 0.74 (-0.09, -11.05%) | 0.80 (-0.07, -8.08%) |
| nllb | 0.75 (-0.09, -10.70%) | 0.80 (-0.07, -8.00%) | 0.75 (-0.08, -9.69%) | 0.75 (-0.08, -9.69%) | 0.80 (-0.07, -7.89%) |
| opusmt | 0.83 (-0.01, -0.91%) | 0.87 (+0.00, +0.52%) | 0.83 (+0.00, +0.08%) | 0.83 (-0.00, -0.19%) | 0.87 (+0.00, +0.22%) |

![Results](img/tr-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt17.tr-en](tr-en/wmt17.tr-en.cometcompare)

#### [flores-test.tr-en](tr-en/flores-test.tr-en.cometcompare)

#### [wmt18.tr-en](tr-en/wmt18.tr-en.cometcompare)

#### [wmt16.tr-en](tr-en/wmt16.tr-en.cometcompare)

#### [flores-dev.tr-en](tr-en/flores-dev.tr-en.cometcompare)

---

## en-et

| Translator/Dataset | flores-dev | wmt18 | flores-test |
| --- | --- | --- | --- |
| bergamot | 0.87 | 0.86 | 0.87 |
| google | 0.92 (+0.05, +5.24%) | 0.91 (+0.04, +4.78%) | 0.92 (+0.04, +4.84%) |
| microsoft | 0.91 (+0.04, +4.66%) | 0.91 (+0.04, +4.72%) | 0.91 (+0.04, +4.63%) |
| argos | 0.86 (-0.01, -1.54%) | 0.85 (-0.02, -2.20%) | 0.86 (-0.01, -1.46%) |
| nllb | 0.84 (-0.04, -4.27%) | 0.83 (-0.04, -4.50%) | 0.83 (-0.04, -5.00%) |
| opusmt | 0.86 (-0.01, -1.20%) | 0.85 (-0.01, -1.55%) | 0.86 (-0.01, -1.16%) |

![Results](img/en-et-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-et](en-et/flores-dev.en-et.cometcompare)
- flores-dev.microsoft.et outperforms flores-dev.bergamot.et.
- flores-dev.google.et outperforms flores-dev.bergamot.et.
- flores-dev.google.et outperforms flores-dev.microsoft.et.

#### [wmt18.en-et](en-et/wmt18.en-et.cometcompare)
- wmt18.microsoft.et outperforms wmt18.bergamot.et.
- wmt18.google.et outperforms wmt18.bergamot.et.
- wmt18.google.et outperforms wmt18.microsoft.et.

#### [flores-test.en-et](en-et/flores-test.en-et.cometcompare)
- flores-test.microsoft.et outperforms flores-test.bergamot.et.
- flores-test.google.et outperforms flores-test.bergamot.et.

---

## hu-en

| Translator/Dataset | flores-test | wmt08 | wmt09 | flores-dev |
| --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.81 | 0.82 | 0.86 |
| google | 0.89 (+0.03, +3.28%) | 0.83 (+0.03, +3.13%) | 0.84 (+0.02, +2.69%) | 0.89 (+0.03, +2.95%) |
| microsoft | 0.89 (+0.03, +3.33%) | 0.84 (+0.03, +3.55%) | 0.84 (+0.03, +3.23%) | 0.89 (+0.03, +3.07%) |
| argos | 0.68 (-0.18, -20.43%) | 0.63 (-0.18, -22.34%) | 0.63 (-0.18, -22.53%) | 0.69 (-0.17, -20.04%) |
| nllb | 0.70 (-0.16, -18.26%) | 0.68 (-0.13, -16.27%) | 0.69 (-0.13, -16.02%) | 0.72 (-0.15, -17.07%) |
| opusmt | 0.86 (+0.00, +0.45%) | 0.81 (+0.01, +0.68%) | 0.82 (+0.01, +0.67%) | 0.87 (+0.00, +0.51%) |

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

| Translator/Dataset | wmt20 | wmt17 | wmt22 | flores-test | wmt15 | wmt21 | mtedx_test | wmt18 | wmt14 | wmt16 | wmt13 | wmt19 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.83 | 0.83 | 0.82 | 0.84 | 0.83 | 0.83 | 0.77 | 0.82 | 0.84 | 0.82 | 0.82 | 0.82 | 0.85 |
| google | 0.85 (+0.02, +2.05%) | 0.86 (+0.03, +3.05%) | 0.85 (+0.03, +3.98%) | 0.87 (+0.02, +2.82%) | 0.85 (+0.02, +3.00%) | 0.85 (+0.02, +2.78%) | 0.79 (+0.02, +2.88%) | 0.85 (+0.03, +3.33%) | 0.87 (+0.03, +3.09%) | 0.85 (+0.03, +3.12%) | 0.84 (+0.02, +2.41%) | 0.84 (+0.02, +2.08%) | 0.87 (+0.02, +2.95%) |
| microsoft | 0.86 (+0.02, +2.68%) | 0.86 (+0.03, +3.40%) | 0.85 (+0.04, +4.32%) | 0.87 (+0.02, +2.68%) | 0.85 (+0.03, +3.37%) | 0.86 (+0.03, +3.37%) | 0.79 (+0.02, +3.22%) | 0.85 (+0.03, +3.80%) | 0.87 (+0.03, +3.40%) | 0.85 (+0.03, +3.40%) | 0.84 (+0.02, +3.02%) | 0.85 (+0.03, +3.40%) | 0.87 (+0.02, +2.72%) |
| argos | 0.77 (-0.06, -7.05%) | 0.78 (-0.05, -5.85%) | 0.75 (-0.06, -7.69%) | 0.80 (-0.04, -4.99%) | 0.78 (-0.04, -5.41%) | 0.77 (-0.06, -7.07%) | 0.73 (-0.03, -4.40%) | 0.78 (-0.04, -5.28%) | 0.79 (-0.05, -5.66%) | 0.78 (-0.05, -5.64%) | 0.77 (-0.04, -5.12%) | 0.76 (-0.07, -7.94%) | 0.80 (-0.04, -4.86%) |
| nllb | 0.84 (+0.00, +0.50%) | 0.84 (+0.01, +0.83%) | 0.82 (+0.00, +0.34%) | 0.85 (+0.01, +1.03%) | 0.84 (+0.01, +1.12%) | 0.83 (+0.01, +0.74%) | 0.78 (+0.01, +1.09%) | 0.83 (+0.01, +1.43%) | 0.85 (+0.01, +0.92%) | 0.84 (+0.01, +1.54%) | 0.83 (+0.01, +1.07%) | 0.83 (+0.01, +0.75%) | 0.86 (+0.01, +1.31%) |
| opusmt | 0.81 (-0.02, -2.34%) | 0.82 (-0.01, -1.10%) | 0.80 (-0.02, -2.09%) | 0.84 (-0.00, -0.56%) | 0.82 (-0.01, -0.67%) | 0.81 (-0.02, -2.17%) | 0.77 (+0.00, +0.01%) | 0.82 (-0.00, -0.38%) | 0.83 (-0.01, -1.03%) | 0.82 (-0.01, -0.86%) | 0.81 (-0.00, -0.43%) | 0.80 (-0.02, -2.40%) | 0.84 (-0.01, -0.60%) |

![Results](img/ru-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt20.ru-en](ru-en/wmt20.ru-en.cometcompare)
- wmt20.microsoft.en outperforms wmt20.bergamot.en.
- wmt20.google.en outperforms wmt20.bergamot.en.
- wmt20.microsoft.en outperforms wmt20.google.en.

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

#### [wmt21.ru-en](ru-en/wmt21.ru-en.cometcompare)
- wmt21.microsoft.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.bergamot.en.

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

#### [flores-dev.ru-en](ru-en/flores-dev.ru-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## mt-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.76 | 0.76 |
| google | 0.84 (+0.08, +10.41%) | 0.85 (+0.08, +11.01%) |
| microsoft | 0.83 (+0.07, +9.12%) | 0.83 (+0.07, +9.38%) |
| argos | N/A | N/A |
| nllb | 0.62 (-0.14, -19.03%) | 0.63 (-0.13, -16.76%) |
| opusmt | N/A | N/A |

![Results](img/mt-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.mt-en](mt-en/flores-test.mt-en.cometcompare)

#### [flores-dev.mt-en](mt-en/flores-dev.mt-en.cometcompare)

---

## en-hu

| Translator/Dataset | flores-dev | wmt09 | flores-test | wmt08 |
| --- | --- | --- | --- | --- |
| bergamot | 0.81 | 0.79 | 0.82 | 0.79 |
| google | 0.90 (+0.09, +10.94%) | 0.86 (+0.08, +9.95%) | 0.90 (+0.08, +9.28%) | 0.87 (+0.07, +9.25%) |
| microsoft | 0.90 (+0.09, +11.20%) | 0.87 (+0.09, +10.91%) | 0.90 (+0.08, +9.62%) | 0.87 (+0.08, +9.51%) |
| argos | 0.79 (-0.02, -2.65%) | 0.77 (-0.02, -2.39%) | 0.79 (-0.04, -4.26%) | 0.76 (-0.03, -4.09%) |
| nllb | 0.84 (+0.02, +2.98%) | 0.81 (+0.03, +3.45%) | 0.84 (+0.02, +2.02%) | 0.81 (+0.02, +2.52%) |
| opusmt | 0.85 (+0.04, +4.91%) | 0.83 (+0.05, +6.00%) | 0.85 (+0.03, +3.32%) | 0.83 (+0.04, +4.57%) |

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

## el-en

| Translator/Dataset | flores-test | mtedx_test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.86 | 0.82 | 0.86 |
| google | 0.88 (+0.02, +2.80%) | 0.84 (+0.02, +2.56%) | 0.89 (+0.02, +2.82%) |
| microsoft | 0.88 (+0.02, +2.38%) | 0.84 (+0.03, +3.08%) | 0.88 (+0.02, +2.43%) |
| argos | 0.86 (+0.00, +0.06%) | 0.82 (+0.00, +0.46%) | 0.86 (+0.00, +0.24%) |
| nllb | 0.86 (+0.01, +0.64%) | 0.82 (+0.00, +0.22%) | 0.87 (+0.01, +0.61%) |
| opusmt | N/A | N/A | N/A |

![Results](img/el-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.el-en](el-en/flores-test.el-en.cometcompare)

#### [mtedx_test.el-en](el-en/mtedx_test.el-en.cometcompare)

#### [flores-dev.el-en](el-en/flores-dev.el-en.cometcompare)

---

## fi-en

| Translator/Dataset | wmt17 | flores-test | wmt15 | wmt18 | wmt16 | wmt19 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.87 | 0.85 | 0.84 | 0.85 | 0.85 | 0.87 |
| google | 0.89 (+0.03, +3.33%) | 0.90 (+0.03, +3.46%) | 0.88 (+0.03, +3.40%) | 0.86 (+0.02, +2.89%) | 0.88 (+0.03, +3.49%) | 0.88 (+0.03, +3.89%) | 0.90 (+0.03, +3.49%) |
| microsoft | 0.90 (+0.03, +3.68%) | 0.90 (+0.03, +3.57%) | 0.89 (+0.04, +4.15%) | 0.87 (+0.03, +3.79%) | 0.89 (+0.03, +3.93%) | 0.89 (+0.04, +4.16%) | 0.90 (+0.03, +3.54%) |
| argos | 0.79 (-0.07, -8.26%) | 0.82 (-0.05, -5.96%) | 0.79 (-0.06, -7.43%) | 0.78 (-0.06, -7.50%) | 0.78 (-0.07, -8.29%) | 0.77 (-0.08, -9.90%) | 0.82 (-0.05, -6.01%) |
| nllb | 0.66 (-0.21, -24.25%) | 0.66 (-0.21, -23.86%) | 0.65 (-0.20, -23.43%) | 0.64 (-0.20, -23.42%) | 0.66 (-0.19, -22.27%) | 0.63 (-0.22, -25.67%) | 0.67 (-0.20, -23.33%) |
| opusmt | 0.87 (+0.00, +0.34%) | 0.88 (+0.01, +1.15%) | 0.86 (+0.01, +0.92%) | 0.85 (+0.01, +0.80%) | 0.86 (+0.00, +0.41%) | 0.85 (-0.00, -0.50%) | 0.88 (+0.01, +1.27%) |

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

## en-ru

| Translator/Dataset | wmt16 | wmt17 | wmt19 | wmt21 | wmt15 | wmt13 | wmt14 | wmt18 | wmt20 | wmt22 | flores-dev | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.85 | 0.86 | 0.81 | 0.81 | 0.86 | 0.84 | 0.88 | 0.86 | 0.82 | 0.81 | 0.85 | 0.85 |
| google | 0.90 (+0.05, +6.10%) | 0.91 (+0.05, +6.00%) | 0.88 (+0.07, +8.50%) | 0.87 (+0.07, +8.15%) | 0.91 (+0.05, +6.13%) | 0.89 (+0.04, +5.22%) | 0.92 (+0.05, +5.35%) | 0.91 (+0.05, +6.31%) | 0.88 (+0.06, +7.55%) | 0.89 (+0.08, +9.39%) | 0.90 (+0.05, +6.15%) | 0.90 (+0.05, +6.20%) |
| microsoft | 0.89 (+0.04, +5.03%) | 0.90 (+0.04, +5.14%) | 0.88 (+0.06, +7.52%) | 0.86 (+0.05, +6.61%) | 0.90 (+0.04, +5.17%) | 0.88 (+0.04, +4.53%) | 0.92 (+0.04, +4.59%) | 0.90 (+0.05, +5.35%) | 0.87 (+0.05, +6.11%) | 0.87 (+0.06, +7.58%) | 0.89 (+0.04, +4.77%) | 0.89 (+0.04, +5.00%) |
| argos | 0.85 (-0.00, -0.21%) | 0.86 (+0.00, +0.05%) | 0.81 (-0.00, -0.56%) | 0.80 (-0.01, -1.23%) | 0.86 (+0.00, +0.30%) | 0.85 (+0.00, +0.47%) | 0.88 (+0.00, +0.22%) | 0.86 (-0.00, -0.04%) | 0.81 (-0.01, -0.65%) | 0.81 (-0.00, -0.58%) | 0.85 (-0.00, -0.25%) | 0.85 (-0.00, -0.18%) |
| nllb | 0.86 (+0.02, +1.85%) | 0.87 (+0.01, +1.33%) | 0.84 (+0.02, +2.87%) | 0.83 (+0.02, +2.41%) | 0.87 (+0.01, +1.54%) | 0.86 (+0.01, +1.64%) | 0.89 (+0.01, +1.42%) | 0.87 (+0.02, +1.80%) | 0.84 (+0.02, +2.61%) | 0.83 (+0.02, +2.53%) | 0.86 (+0.01, +0.94%) | 0.86 (+0.01, +1.28%) |
| opusmt | 0.85 (-0.00, -0.18%) | 0.86 (+0.00, +0.08%) | 0.82 (+0.00, +0.58%) | 0.81 (+0.00, +0.12%) | 0.86 (+0.00, +0.07%) | 0.85 (+0.01, +0.92%) | 0.87 (-0.00, -0.09%) | 0.86 (+0.00, +0.29%) | 0.82 (+0.00, +0.35%) | 0.81 (-0.00, -0.59%) | 0.85 (-0.00, -0.20%) | 0.85 (-0.00, -0.21%) |

![Results](img/en-ru-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt16.en-ru](en-ru/wmt16.en-ru.cometcompare)
- wmt16.microsoft.ru outperforms wmt16.bergamot.ru.
- wmt16.google.ru outperforms wmt16.bergamot.ru.
- wmt16.google.ru outperforms wmt16.microsoft.ru.

#### [wmt17.en-ru](en-ru/wmt17.en-ru.cometcompare)
- wmt17.microsoft.ru outperforms wmt17.bergamot.ru.
- wmt17.google.ru outperforms wmt17.bergamot.ru.
- wmt17.google.ru outperforms wmt17.microsoft.ru.

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

#### [wmt14.en-ru](en-ru/wmt14.en-ru.cometcompare)
- wmt14.microsoft.ru outperforms wmt14.bergamot.ru.
- wmt14.google.ru outperforms wmt14.bergamot.ru.
- wmt14.google.ru outperforms wmt14.microsoft.ru.

#### [wmt18.en-ru](en-ru/wmt18.en-ru.cometcompare)
- wmt18.microsoft.ru outperforms wmt18.bergamot.ru.
- wmt18.google.ru outperforms wmt18.bergamot.ru.
- wmt18.google.ru outperforms wmt18.microsoft.ru.

#### [wmt20.en-ru](en-ru/wmt20.en-ru.cometcompare)
- wmt20.microsoft.ru outperforms wmt20.bergamot.ru.
- wmt20.google.ru outperforms wmt20.bergamot.ru.
- wmt20.google.ru outperforms wmt20.microsoft.ru.

#### [wmt22.en-ru](en-ru/wmt22.en-ru.cometcompare)
- wmt22.microsoft.ru outperforms wmt22.bergamot.ru.
- wmt22.google.ru outperforms wmt22.bergamot.ru.
- wmt22.google.ru outperforms wmt22.microsoft.ru.

#### [flores-dev.en-ru](en-ru/flores-dev.en-ru.cometcompare)
- flores-dev.microsoft.ru outperforms flores-dev.bergamot.ru.
- flores-dev.google.ru outperforms flores-dev.bergamot.ru.
- flores-dev.google.ru outperforms flores-dev.microsoft.ru.

#### [flores-test.en-ru](en-ru/flores-test.en-ru.cometcompare)
- flores-test.microsoft.ru outperforms flores-test.bergamot.ru.
- flores-test.google.ru outperforms flores-test.bergamot.ru.
- flores-test.google.ru outperforms flores-test.microsoft.ru.

---

## en-fa

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.79 | 0.79 |
| google | 0.88 (+0.09, +10.88%) | 0.88 (+0.09, +11.64%) |
| microsoft | 0.82 (+0.02, +2.58%) | 0.81 (+0.03, +3.49%) |
| argos | 0.80 (+0.01, +1.14%) | 0.80 (+0.01, +1.73%) |
| nllb | 0.84 (+0.04, +5.18%) | 0.84 (+0.05, +6.44%) |
| opusmt | N/A | N/A |

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

## et-en

| Translator/Dataset | flores-test | wmt18 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.86 | 0.83 | 0.85 |
| google | 0.90 (+0.04, +4.70%) | 0.88 (+0.04, +5.16%) | 0.90 (+0.05, +5.55%) |
| microsoft | 0.89 (+0.03, +3.77%) | 0.87 (+0.04, +4.50%) | 0.89 (+0.04, +4.49%) |
| argos | 0.87 (+0.01, +1.24%) | 0.85 (+0.01, +1.61%) | 0.87 (+0.02, +2.04%) |
| nllb | 0.60 (-0.26, -29.85%) | 0.58 (-0.25, -30.42%) | 0.60 (-0.25, -29.76%) |
| opusmt | 0.87 (+0.01, +1.54%) | 0.85 (+0.02, +1.98%) | 0.88 (+0.02, +2.63%) |

![Results](img/et-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.et-en](et-en/flores-test.et-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [wmt18.et-en](et-en/wmt18.et-en.cometcompare)
- wmt18.microsoft.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.microsoft.en.

#### [flores-dev.et-en](et-en/flores-dev.et-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## nb-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.85 | 0.85 |
| google | 0.89 (+0.04, +4.91%) | 0.89 (+0.05, +5.56%) |
| microsoft | 0.89 (+0.04, +4.86%) | 0.89 (+0.05, +5.39%) |
| argos | 0.86 (+0.01, +1.72%) | 0.87 (+0.02, +2.48%) |
| nllb | 0.75 (-0.10, -11.46%) | 0.77 (-0.08, -9.51%) |
| opusmt | N/A | N/A |

![Results](img/nb-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.nb-en](nb-en/flores-test.nb-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [flores-dev.nb-en](nb-en/flores-dev.nb-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## uk-en

| Translator/Dataset | wmt22 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.80 | 0.85 | 0.85 |
| google | 0.86 (+0.05, +6.86%) | 0.88 (+0.03, +3.34%) | 0.88 (+0.03, +3.38%) |
| microsoft | 0.85 (+0.04, +5.61%) | 0.87 (+0.02, +2.89%) | 0.87 (+0.02, +2.94%) |
| argos | 0.70 (-0.10, -13.02%) | 0.80 (-0.05, -6.13%) | 0.80 (-0.05, -6.10%) |
| nllb | 0.78 (-0.02, -2.19%) | 0.83 (-0.01, -1.67%) | 0.83 (-0.01, -1.58%) |
| opusmt | 0.77 (-0.03, -3.87%) | 0.82 (-0.03, -3.86%) | 0.81 (-0.04, -4.23%) |

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
| bergamot | 0.83 | 0.83 |
| google | 0.89 (+0.06, +6.83%) | 0.89 (+0.06, +7.32%) |
| microsoft | 0.87 (+0.04, +4.73%) | 0.87 (+0.04, +4.86%) |
| argos | 0.82 (-0.01, -0.81%) | 0.82 (-0.00, -0.47%) |
| nllb | 0.83 (+0.00, +0.06%) | 0.83 (+0.00, +0.25%) |
| opusmt | N/A | N/A |

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
| bergamot | 0.85 | 0.85 |
| google | 0.89 (+0.05, +5.53%) | 0.89 (+0.04, +5.11%) |
| microsoft | 0.89 (+0.04, +5.23%) | 0.89 (+0.04, +4.60%) |
| argos | 0.86 (+0.02, +2.31%) | 0.87 (+0.02, +2.16%) |
| nllb | 0.82 (-0.02, -2.60%) | 0.83 (-0.02, -2.76%) |
| opusmt | 0.78 (-0.06, -7.51%) | 0.79 (-0.07, -7.75%) |

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
| bergamot | 0.85 | 0.85 | 0.80 |
| google | 0.91 (+0.06, +6.83%) | 0.91 (+0.06, +7.12%) | 0.89 (+0.09, +11.00%) |
| microsoft | 0.90 (+0.05, +5.90%) | 0.90 (+0.05, +6.20%) | 0.87 (+0.08, +9.48%) |
| argos | 0.70 (-0.15, -17.64%) | 0.70 (-0.15, -17.24%) | 0.69 (-0.11, -13.92%) |
| nllb | 0.84 (-0.01, -1.06%) | 0.84 (-0.00, -0.31%) | 0.80 (+0.00, +0.23%) |
| opusmt | 0.82 (-0.03, -3.92%) | 0.81 (-0.03, -3.97%) | 0.76 (-0.04, -5.27%) |

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
| bergamot | 0.75 | 0.70 | 0.74 |
| google | 0.87 (+0.12, +16.35%) | 0.86 (+0.16, +22.76%) | 0.87 (+0.13, +17.18%) |
| microsoft | 0.86 (+0.11, +15.31%) | 0.86 (+0.16, +22.66%) | 0.86 (+0.12, +16.15%) |
| argos | N/A | N/A | N/A |
| nllb | 0.63 (-0.12, -16.34%) | 0.63 (-0.07, -9.75%) | 0.63 (-0.11, -14.70%) |
| opusmt | 0.80 (+0.05, +6.64%) | 0.75 (+0.05, +7.62%) | 0.80 (+0.05, +7.03%) |

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

## en-cs

| Translator/Dataset | wmt11 | wmt20 | wmt13 | flores-test | wmt08 | wmt21 | wmt14 | wmt17 | wmt22 | wmt12 | wmt18 | wmt15 | wmt10 | flores-dev | wmt16 | wmt19 | wmt09 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.82 | 0.82 | 0.85 | 0.85 | 0.82 | 0.80 | 0.86 | 0.84 | 0.83 | 0.82 | 0.84 | 0.84 | 0.83 | 0.85 | 0.84 | 0.81 | 0.83 |
| google | 0.88 (+0.06, +7.56%) | 0.89 (+0.07, +8.36%) | 0.90 (+0.05, +5.65%) | 0.91 (+0.06, +7.37%) | 0.88 (+0.07, +8.33%) | 0.86 (+0.06, +7.72%) | 0.92 (+0.05, +6.37%) | 0.89 (+0.05, +6.41%) | 0.91 (+0.09, +10.46%) | 0.88 (+0.06, +7.43%) | 0.89 (+0.05, +6.25%) | 0.90 (+0.06, +6.65%) | 0.89 (+0.06, +7.25%) | 0.92 (+0.07, +7.80%) | 0.89 (+0.06, +6.76%) | 0.87 (+0.06, +7.57%) | 0.89 (+0.06, +7.40%) |
| microsoft | 0.89 (+0.07, +8.48%) | 0.90 (+0.08, +9.47%) | 0.90 (+0.05, +6.23%) | 0.91 (+0.06, +7.21%) | 0.89 (+0.07, +8.63%) | 0.87 (+0.07, +8.81%) | 0.92 (+0.06, +6.99%) | 0.89 (+0.06, +6.82%) | 0.91 (+0.08, +9.58%) | 0.89 (+0.07, +8.12%) | 0.90 (+0.06, +6.65%) | 0.90 (+0.06, +6.84%) | 0.89 (+0.06, +7.65%) | 0.92 (+0.07, +7.76%) | 0.90 (+0.06, +7.13%) | 0.89 (+0.08, +9.25%) | 0.89 (+0.06, +7.64%) |
| argos | 0.69 (-0.13, -15.65%) | 0.59 (-0.23, -28.19%) | 0.72 (-0.13, -15.75%) | 0.71 (-0.14, -16.52%) | 0.66 (-0.15, -18.62%) | 0.59 (-0.21, -26.15%) | 0.69 (-0.17, -19.58%) | 0.68 (-0.16, -18.56%) | 0.74 (-0.09, -10.71%) | 0.67 (-0.15, -18.11%) | 0.68 (-0.16, -19.19%) | 0.68 (-0.16, -18.90%) | 0.68 (-0.15, -17.82%) | 0.72 (-0.13, -15.26%) | 0.68 (-0.15, -18.12%) | 0.60 (-0.21, -25.60%) | 0.69 (-0.14, -16.45%) |
| nllb | 0.84 (+0.02, +2.84%) | 0.83 (+0.01, +0.92%) | 0.86 (+0.01, +1.11%) | 0.87 (+0.01, +1.74%) | 0.84 (+0.02, +2.64%) | 0.81 (+0.01, +1.10%) | 0.87 (+0.01, +0.66%) | 0.84 (+0.01, +0.69%) | 0.85 (+0.02, +2.21%) | 0.84 (+0.02, +1.96%) | 0.85 (+0.01, +0.79%) | 0.85 (+0.00, +0.56%) | 0.85 (+0.02, +2.07%) | 0.86 (+0.01, +1.75%) | 0.84 (+0.01, +0.80%) | 0.82 (+0.01, +0.70%) | 0.84 (+0.01, +1.50%) |
| opusmt | 0.84 (+0.03, +3.41%) | 0.81 (-0.01, -0.89%) | 0.87 (+0.02, +1.99%) | 0.86 (+0.01, +0.89%) | 0.83 (+0.02, +2.11%) | 0.80 (-0.01, -0.69%) | 0.87 (+0.01, +1.26%) | 0.85 (+0.01, +1.25%) | 0.85 (+0.02, +2.95%) | 0.84 (+0.02, +2.44%) | 0.85 (+0.01, +1.29%) | 0.86 (+0.01, +1.57%) | 0.85 (+0.02, +2.20%) | 0.86 (+0.01, +1.26%) | 0.85 (+0.01, +1.21%) | 0.80 (-0.01, -1.33%) | 0.85 (+0.02, +2.19%) |

![Results](img/en-cs-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt11.en-cs](en-cs/wmt11.en-cs.cometcompare)
- wmt11.microsoft.cs outperforms wmt11.bergamot.cs.
- wmt11.google.cs outperforms wmt11.bergamot.cs.
- wmt11.microsoft.cs outperforms wmt11.google.cs.

#### [wmt20.en-cs](en-cs/wmt20.en-cs.cometcompare)
- wmt20.microsoft.cs outperforms wmt20.bergamot.cs.
- wmt20.google.cs outperforms wmt20.bergamot.cs.
- wmt20.microsoft.cs outperforms wmt20.google.cs.

#### [wmt13.en-cs](en-cs/wmt13.en-cs.cometcompare)
- wmt13.microsoft.cs outperforms wmt13.bergamot.cs.
- wmt13.google.cs outperforms wmt13.bergamot.cs.
- wmt13.microsoft.cs outperforms wmt13.google.cs.

#### [flores-test.en-cs](en-cs/flores-test.en-cs.cometcompare)
- flores-test.microsoft.cs outperforms flores-test.bergamot.cs.
- flores-test.google.cs outperforms flores-test.bergamot.cs.

#### [wmt08.en-cs](en-cs/wmt08.en-cs.cometcompare)
- wmt08.microsoft.cs outperforms wmt08.bergamot.cs.
- wmt08.google.cs outperforms wmt08.bergamot.cs.

#### [wmt21.en-cs](en-cs/wmt21.en-cs.cometcompare)
- wmt21.microsoft.cs outperforms wmt21.bergamot.cs.
- wmt21.google.cs outperforms wmt21.bergamot.cs.
- wmt21.microsoft.cs outperforms wmt21.google.cs.

#### [wmt14.en-cs](en-cs/wmt14.en-cs.cometcompare)
- wmt14.microsoft.cs outperforms wmt14.bergamot.cs.
- wmt14.google.cs outperforms wmt14.bergamot.cs.
- wmt14.microsoft.cs outperforms wmt14.google.cs.

#### [wmt17.en-cs](en-cs/wmt17.en-cs.cometcompare)
- wmt17.microsoft.cs outperforms wmt17.bergamot.cs.
- wmt17.google.cs outperforms wmt17.bergamot.cs.
- wmt17.microsoft.cs outperforms wmt17.google.cs.

#### [wmt22.en-cs](en-cs/wmt22.en-cs.cometcompare)
- wmt22.microsoft.cs outperforms wmt22.bergamot.cs.
- wmt22.google.cs outperforms wmt22.bergamot.cs.
- wmt22.google.cs outperforms wmt22.microsoft.cs.

#### [wmt12.en-cs](en-cs/wmt12.en-cs.cometcompare)
- wmt12.microsoft.cs outperforms wmt12.bergamot.cs.
- wmt12.google.cs outperforms wmt12.bergamot.cs.
- wmt12.microsoft.cs outperforms wmt12.google.cs.

#### [wmt18.en-cs](en-cs/wmt18.en-cs.cometcompare)
- wmt18.microsoft.cs outperforms wmt18.bergamot.cs.
- wmt18.google.cs outperforms wmt18.bergamot.cs.
- wmt18.microsoft.cs outperforms wmt18.google.cs.

#### [wmt15.en-cs](en-cs/wmt15.en-cs.cometcompare)
- wmt15.microsoft.cs outperforms wmt15.bergamot.cs.
- wmt15.google.cs outperforms wmt15.bergamot.cs.

#### [wmt10.en-cs](en-cs/wmt10.en-cs.cometcompare)
- wmt10.microsoft.cs outperforms wmt10.bergamot.cs.
- wmt10.google.cs outperforms wmt10.bergamot.cs.
- wmt10.microsoft.cs outperforms wmt10.google.cs.

#### [flores-dev.en-cs](en-cs/flores-dev.en-cs.cometcompare)
- flores-dev.microsoft.cs outperforms flores-dev.bergamot.cs.
- flores-dev.google.cs outperforms flores-dev.bergamot.cs.

#### [wmt16.en-cs](en-cs/wmt16.en-cs.cometcompare)
- wmt16.microsoft.cs outperforms wmt16.bergamot.cs.
- wmt16.google.cs outperforms wmt16.bergamot.cs.

#### [wmt19.en-cs](en-cs/wmt19.en-cs.cometcompare)
- wmt19.microsoft.cs outperforms wmt19.bergamot.cs.
- wmt19.google.cs outperforms wmt19.bergamot.cs.
- wmt19.microsoft.cs outperforms wmt19.google.cs.

#### [wmt09.en-cs](en-cs/wmt09.en-cs.cometcompare)
- wmt09.microsoft.cs outperforms wmt09.bergamot.cs.
- wmt09.google.cs outperforms wmt09.bergamot.cs.

---

## sl-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.84 | 0.84 |
| google | 0.88 (+0.05, +5.41%) | 0.88 (+0.05, +5.56%) |
| microsoft | 0.87 (+0.03, +4.02%) | 0.87 (+0.03, +4.15%) |
| argos | N/A | N/A |
| nllb | 0.68 (-0.16, -18.61%) | 0.69 (-0.15, -17.81%) |
| opusmt | N/A | N/A |

![Results](img/sl-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.sl-en](sl-en/flores-test.sl-en.cometcompare)

#### [flores-dev.sl-en](sl-en/flores-dev.sl-en.cometcompare)

---

## lt-en

| Translator/Dataset | flores-test | wmt19 | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.80 | 0.80 | 0.80 |
| google | 0.87 (+0.07, +8.53%) | 0.85 (+0.05, +6.61%) | 0.87 (+0.07, +8.67%) |
| microsoft | 0.86 (+0.06, +6.93%) | 0.85 (+0.05, +6.35%) | 0.86 (+0.06, +7.03%) |
| argos | N/A | N/A | N/A |
| nllb | 0.66 (-0.14, -17.70%) | 0.68 (-0.12, -15.19%) | 0.67 (-0.14, -16.97%) |
| opusmt | N/A | N/A | N/A |

![Results](img/lt-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.lt-en](lt-en/flores-test.lt-en.cometcompare)

#### [wmt19.lt-en](lt-en/wmt19.lt-en.cometcompare)

#### [flores-dev.lt-en](lt-en/flores-dev.lt-en.cometcompare)

---