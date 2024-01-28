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

| Translator/Dataset | cs-en | tr-en | en-et | en-fi | en-it | fr-en | en-pt | hu-en | ru-en | mt-en | en-nb | en-hu | en-el | el-en | fi-en | en-da | en-nl | en-mt | en-sv | en-ru | en-fa | bs-en | et-en | nb-en | en-ca | nl-en | en-lt | en-tr | bg-en | uk-en | en-es | fa-en | ca-en | en-uk | is-en | en-bg | en-bs | en-cs | sv-en | en-is | id-en | de-en | da-en | it-en | pl-en | sl-en | en-fr | en-pl | en-id | pt-en | es-en | en-sl | lt-en | en-de |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.82 | 0.85 | 0.87 | N/A | 0.86 | 0.84 | 0.89 | 0.84 | 0.82 | 0.76 | N/A | 0.80 | N/A | 0.85 | 0.86 | N/A | 0.86 | N/A | N/A | 0.84 | 0.79 | N/A | 0.85 | 0.85 | N/A | 0.86 | N/A | N/A | 0.87 | 0.83 | 0.83 | 0.83 | 0.85 | 0.83 | 0.73 | 0.89 | N/A | 0.83 | N/A | N/A | N/A | 0.83 | N/A | 0.85 | 0.83 | 0.84 | 0.82 | 0.86 | N/A | 0.87 | 0.83 | N/A | 0.80 | 0.84 |
| google | 0.85 (+0.03, +3.75%) | 0.89 (+0.04, +4.71%) | 0.91 (+0.04, +4.95%) | 0.91 | 0.88 (+0.02, +2.33%) | 0.86 (+0.02, +1.87%) | 0.90 (+0.02, +1.73%) | 0.86 (+0.03, +3.01%) | 0.85 (+0.02, +2.89%) | 0.84 (+0.08, +10.71%) | 0.90 | 0.88 (+0.08, +9.85%) | 0.90 | 0.87 (+0.02, +2.73%) | 0.89 (+0.03, +3.42%) | 0.91 | 0.88 (+0.02, +2.56%) | 0.73 | 0.91 | 0.90 (+0.06, +6.72%) | 0.88 (+0.09, +11.26%) | 0.89 | 0.89 (+0.04, +5.14%) | 0.89 (+0.04, +5.23%) | 0.88 | 0.88 (+0.02, +2.11%) | 0.89 | 0.90 | 0.89 (+0.02, +2.29%) | 0.87 (+0.04, +4.48%) | 0.85 (+0.02, +2.40%) | 0.89 (+0.06, +7.07%) | 0.89 (+0.05, +5.32%) | 0.90 (+0.07, +8.26%) | 0.87 (+0.14, +18.68%) | 0.92 (+0.02, +2.53%) | 0.92 | 0.89 (+0.06, +7.36%) | 0.90 | 0.86 | 0.90 | 0.86 (+0.03, +3.37%) | 0.91 | 0.86 (+0.02, +1.85%) | 0.86 (+0.02, +2.90%) | 0.88 (+0.05, +5.48%) | 0.85 (+0.03, +3.51%) | 0.90 (+0.04, +4.88%) | 0.92 | 0.89 (+0.01, +1.53%) | 0.84 (+0.01, +1.75%) | 0.91 | 0.87 (+0.06, +7.94%) | 0.87 (+0.03, +3.42%) |
| microsoft | 0.85 (+0.03, +4.13%) | 0.89 (+0.04, +4.50%) | 0.91 (+0.04, +4.67%) | 0.92 | 0.88 (+0.02, +2.42%) | 0.86 (+0.02, +2.43%) | 0.90 (+0.01, +1.28%) | 0.87 (+0.03, +3.29%) | 0.85 (+0.03, +3.29%) | 0.83 (+0.07, +9.25%) | 0.90 | 0.89 (+0.08, +10.31%) | 0.90 | 0.87 (+0.02, +2.62%) | 0.89 (+0.03, +3.83%) | 0.91 | 0.88 (+0.02, +2.12%) | 0.74 | 0.92 | 0.89 (+0.05, +5.59%) | 0.82 (+0.02, +3.03%) | 0.89 | 0.88 (+0.04, +4.25%) | 0.89 (+0.04, +5.13%) | 0.88 | 0.87 (+0.02, +1.81%) | 0.89 | 0.90 | 0.88 (+0.01, +1.63%) | 0.86 (+0.03, +3.78%) | 0.86 (+0.02, +2.65%) | 0.87 (+0.04, +4.79%) | 0.89 (+0.04, +4.92%) | 0.89 (+0.06, +7.15%) | 0.86 (+0.13, +17.94%) | 0.91 (+0.02, +1.79%) | 0.91 | 0.90 (+0.07, +7.82%) | 0.91 | 0.85 | 0.90 | 0.86 (+0.03, +4.16%) | 0.91 | 0.86 (+0.02, +1.97%) | 0.86 (+0.03, +3.13%) | 0.87 (+0.03, +4.08%) | 0.86 (+0.03, +4.15%) | 0.89 (+0.04, +4.14%) | 0.92 | 0.89 (+0.01, +1.43%) | 0.85 (+0.02, +2.34%) | 0.89 | 0.86 (+0.05, +6.77%) | 0.87 (+0.03, +3.72%) |
| argos | 0.71 (-0.11, -13.54%) | 0.76 (-0.09, -10.40%) | 0.86 (-0.02, -1.73%) | 0.85 | 0.84 (-0.02, -2.57%) | 0.83 (-0.01, -1.00%) | 0.86 (-0.02, -2.62%) | 0.66 (-0.18, -21.30%) | 0.78 (-0.05, -5.92%) | N/A | N/A | 0.78 (-0.03, -3.35%) | 0.87 | 0.85 (+0.00, +0.25%) | 0.79 (-0.07, -7.61%) | 0.83 | 0.85 (-0.01, -1.73%) | N/A | 0.87 | 0.84 (-0.00, -0.21%) | 0.80 (+0.01, +1.43%) | N/A | 0.86 (+0.01, +1.63%) | 0.87 (+0.02, +2.10%) | 0.77 | 0.86 (+0.00, +0.37%) | N/A | 0.78 | 0.85 (-0.01, -1.37%) | 0.76 (-0.07, -8.33%) | 0.82 (-0.01, -1.52%) | 0.82 (-0.01, -0.64%) | 0.87 (+0.02, +2.23%) | 0.70 (-0.14, -16.31%) | N/A | 0.88 (-0.01, -1.47%) | N/A | 0.68 (-0.16, -18.74%) | 0.88 | N/A | 0.81 | 0.82 (-0.01, -1.29%) | 0.84 | 0.83 (-0.01, -1.44%) | 0.84 (+0.00, +0.36%) | N/A | 0.81 (-0.01, -1.47%) | 0.84 (-0.02, -1.84%) | 0.83 | 0.87 (-0.01, -0.79%) | 0.82 (-0.01, -0.93%) | N/A | N/A | 0.79 (-0.05, -5.97%) |
| nllb | 0.73 (-0.09, -11.15%) | 0.77 (-0.08, -9.17%) | 0.83 (-0.04, -4.59%) | 0.85 | 0.86 (+0.00, +0.21%) | 0.83 (-0.01, -0.77%) | 0.88 (-0.01, -0.61%) | 0.70 (-0.14, -16.93%) | 0.83 (+0.01, +0.98%) | 0.62 (-0.14, -17.90%) | 0.87 | 0.83 (+0.02, +2.74%) | 0.87 | 0.85 (+0.00, +0.50%) | 0.65 (-0.20, -23.75%) | 0.88 | 0.85 (-0.01, -0.76%) | 0.69 | 0.88 | 0.86 (+0.02, +1.84%) | 0.84 (+0.05, +5.81%) | 0.75 | 0.59 (-0.25, -30.00%) | 0.76 (-0.09, -10.49%) | 0.85 | 0.81 (-0.05, -5.79%) | 0.81 | 0.86 | 0.86 (-0.01, -1.17%) | 0.82 (-0.02, -1.81%) | 0.84 (+0.01, +0.91%) | 0.83 (+0.00, +0.16%) | 0.83 (-0.02, -2.68%) | 0.83 (-0.00, -0.39%) | 0.63 (-0.10, -13.68%) | 0.88 (-0.01, -1.54%) | 0.87 | 0.84 (+0.01, +1.41%) | 0.77 | 0.79 | 0.86 | 0.75 (-0.08, -9.91%) | 0.78 | 0.82 (-0.03, -3.55%) | 0.77 (-0.06, -7.70%) | 0.68 (-0.15, -18.21%) | 0.84 (+0.01, +1.81%) | 0.84 (-0.01, -1.50%) | 0.90 | 0.84 (-0.04, -4.16%) | 0.83 (-0.00, -0.10%) | 0.84 | 0.67 (-0.13, -16.62%) | 0.83 (-0.01, -1.09%) |
| opusmt | 0.82 (+0.00, +0.21%) | 0.85 (-0.00, -0.05%) | 0.86 (-0.01, -1.30%) | 0.91 | 0.85 (-0.01, -0.77%) | 0.85 (+0.01, +0.72%) | N/A | 0.84 (+0.00, +0.58%) | 0.82 (-0.01, -1.13%) | N/A | N/A | 0.84 (+0.04, +4.68%) | 0.86 | N/A | 0.86 (+0.01, +0.63%) | 0.88 | 0.85 (-0.01, -1.22%) | N/A | 0.89 | 0.84 (+0.00, +0.10%) | N/A | N/A | 0.86 (+0.02, +2.05%) | N/A | 0.77 | 0.86 (+0.00, +0.43%) | N/A | N/A | 0.86 (-0.00, -0.52%) | 0.80 (-0.03, -3.99%) | 0.84 (+0.01, +1.12%) | N/A | 0.78 (-0.06, -7.63%) | 0.79 (-0.04, -4.37%) | 0.78 (+0.05, +7.09%) | 0.82 (-0.07, -7.86%) | N/A | 0.84 (+0.01, +1.36%) | 0.89 | 0.74 | 0.86 | 0.84 (+0.02, +1.83%) | 0.89 | 0.85 (+0.00, +0.27%) | 0.83 (-0.00, -0.23%) | N/A | 0.83 (+0.01, +1.43%) | N/A | 0.88 | N/A | 0.84 (+0.01, +0.97%) | N/A | N/A | 0.83 (-0.01, -1.31%) |

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

## en-fi

| Translator/Dataset | flores-test | wmt19 | wmt18 | wmt17 | flores-dev | wmt16 | wmt15 |
| --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | N/A | N/A | N/A | N/A | N/A | N/A | N/A |
| google | 0.92 | 0.89 | 0.90 | 0.92 | 0.92 | 0.91 | 0.91 |
| microsoft | 0.93 | 0.90 | 0.91 | 0.93 | 0.93 | 0.92 | 0.92 |
| argos | 0.86 | 0.82 | 0.85 | 0.86 | 0.86 | 0.85 | 0.86 |
| nllb | 0.85 | 0.83 | 0.84 | 0.85 | 0.85 | 0.85 | 0.85 |
| opusmt | 0.91 | 0.88 | 0.90 | 0.92 | 0.91 | 0.91 | 0.91 |

![Results](img/en-fi-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-fi](en-fi/flores-test.en-fi.cometcompare)

#### [wmt19.en-fi](en-fi/wmt19.en-fi.cometcompare)

#### [wmt18.en-fi](en-fi/wmt18.en-fi.cometcompare)

#### [wmt17.en-fi](en-fi/wmt17.en-fi.cometcompare)

#### [flores-dev.en-fi](en-fi/flores-dev.en-fi.cometcompare)

#### [wmt16.en-fi](en-fi/wmt16.en-fi.cometcompare)

#### [wmt15.en-fi](en-fi/wmt15.en-fi.cometcompare)

---

## en-it

| Translator/Dataset | flores-dev | flores-test | wmt09 |
| --- | --- | --- | --- |
| bergamot | 0.86 | 0.86 | 0.85 |
| google | 0.88 (+0.02, +2.28%) | 0.89 (+0.02, +2.63%) | 0.87 (+0.02, +2.06%) |
| microsoft | 0.88 (+0.02, +2.15%) | 0.88 (+0.02, +2.52%) | 0.87 (+0.02, +2.60%) |
| argos | 0.84 (-0.03, -3.16%) | 0.84 (-0.03, -2.99%) | 0.84 (-0.01, -1.54%) |
| nllb | 0.87 (+0.00, +0.19%) | 0.86 (+0.00, +0.10%) | 0.85 (+0.00, +0.33%) |
| opusmt | 0.85 (-0.01, -1.15%) | 0.85 (-0.01, -1.21%) | 0.85 (+0.00, +0.05%) |

![Results](img/en-it-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-it](en-it/flores-dev.en-it.cometcompare)
- flores-dev.microsoft.it outperforms flores-dev.bergamot.it.
- flores-dev.google.it outperforms flores-dev.bergamot.it.

#### [flores-test.en-it](en-it/flores-test.en-it.cometcompare)
- flores-test.microsoft.it outperforms flores-test.bergamot.it.
- flores-test.google.it outperforms flores-test.bergamot.it.

#### [wmt09.en-it](en-it/wmt09.en-it.cometcompare)
- wmt09.microsoft.it outperforms wmt09.bergamot.it.
- wmt09.google.it outperforms wmt09.bergamot.it.
- wmt09.microsoft.it outperforms wmt09.google.it.

---

## fr-en

| Translator/Dataset | flores-test | wmt08 | wmt12 | wmt15 | mtedx_test | wmt11 | iwslt17 | wmt09 | wmt14 | wmt10 | wmt13 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.88 | 0.80 | 0.82 | 0.83 | 0.85 | 0.82 | 0.86 | 0.82 | 0.85 | 0.82 | 0.84 | 0.88 |
| google | 0.89 (+0.01, +1.44%) | 0.82 (+0.02, +2.56%) | 0.83 (+0.01, +1.48%) | 0.85 (+0.03, +3.04%) | 0.87 (+0.02, +2.03%) | 0.83 (+0.01, +1.50%) | 0.87 (+0.01, +0.95%) | 0.83 (+0.02, +2.12%) | 0.87 (+0.02, +1.89%) | 0.84 (+0.02, +2.49%) | 0.85 (+0.01, +1.27%) | 0.90 (+0.02, +1.76%) |
| microsoft | 0.90 (+0.01, +1.58%) | 0.83 (+0.02, +3.02%) | 0.84 (+0.02, +2.68%) | 0.85 (+0.03, +3.18%) | 0.87 (+0.02, +2.35%) | 0.84 (+0.02, +2.70%) | 0.88 (+0.01, +1.45%) | 0.84 (+0.02, +2.81%) | 0.87 (+0.02, +2.58%) | 0.85 (+0.02, +3.01%) | 0.86 (+0.02, +2.14%) | 0.90 (+0.02, +1.82%) |
| argos | 0.87 (-0.01, -1.12%) | 0.80 (-0.01, -0.78%) | 0.81 (-0.01, -0.97%) | 0.82 (-0.01, -1.22%) | 0.84 (-0.01, -1.01%) | 0.81 (-0.01, -0.77%) | 0.85 (-0.01, -1.33%) | 0.81 (-0.01, -0.61%) | 0.84 (-0.01, -1.41%) | 0.82 (-0.01, -0.68%) | 0.83 (-0.01, -1.07%) | 0.87 (-0.01, -0.95%) |
| nllb | 0.88 (-0.01, -0.65%) | 0.81 (+0.00, +0.34%) | 0.82 (+0.00, +0.23%) | 0.81 (-0.02, -2.17%) | 0.82 (-0.03, -3.14%) | 0.82 (+0.00, +0.28%) | 0.85 (-0.02, -2.25%) | 0.82 (+0.00, +0.15%) | 0.85 (-0.00, -0.57%) | 0.82 (-0.00, -0.13%) | 0.84 (-0.01, -0.69%) | 0.88 (-0.00, -0.43%) |
| opusmt | 0.88 (+0.00, +0.20%) | 0.81 (+0.01, +1.26%) | 0.83 (+0.01, +1.01%) | 0.84 (+0.01, +1.10%) | 0.85 (+0.01, +0.65%) | 0.83 (+0.01, +1.04%) | 0.87 (+0.00, +0.06%) | 0.82 (+0.01, +1.19%) | 0.86 (+0.00, +0.46%) | 0.83 (+0.01, +1.08%) | 0.85 (+0.00, +0.44%) | 0.88 (+0.00, +0.28%) |

![Results](img/fr-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.fr-en](fr-en/flores-test.fr-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [wmt08.fr-en](fr-en/wmt08.fr-en.cometcompare)
- wmt08.microsoft.en outperforms wmt08.bergamot.en.
- wmt08.google.en outperforms wmt08.bergamot.en.
- wmt08.microsoft.en outperforms wmt08.google.en.

#### [wmt12.fr-en](fr-en/wmt12.fr-en.cometcompare)
- wmt12.microsoft.en outperforms wmt12.bergamot.en.
- wmt12.google.en outperforms wmt12.bergamot.en.
- wmt12.microsoft.en outperforms wmt12.google.en.

#### [wmt15.fr-en](fr-en/wmt15.fr-en.cometcompare)
- wmt15.microsoft.en outperforms wmt15.bergamot.en.
- wmt15.google.en outperforms wmt15.bergamot.en.

#### [mtedx_test.fr-en](fr-en/mtedx_test.fr-en.cometcompare)
- mtedx_test.microsoft.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.bergamot.en.

#### [wmt11.fr-en](fr-en/wmt11.fr-en.cometcompare)
- wmt11.microsoft.en outperforms wmt11.bergamot.en.
- wmt11.google.en outperforms wmt11.bergamot.en.
- wmt11.microsoft.en outperforms wmt11.google.en.

#### [iwslt17.fr-en](fr-en/iwslt17.fr-en.cometcompare)
- iwslt17.microsoft.en outperforms iwslt17.bergamot.en.
- iwslt17.google.en outperforms iwslt17.bergamot.en.
- iwslt17.microsoft.en outperforms iwslt17.google.en.

#### [wmt09.fr-en](fr-en/wmt09.fr-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.
- wmt09.microsoft.en outperforms wmt09.google.en.

#### [wmt14.fr-en](fr-en/wmt14.fr-en.cometcompare)
- wmt14.microsoft.en outperforms wmt14.bergamot.en.
- wmt14.google.en outperforms wmt14.bergamot.en.
- wmt14.microsoft.en outperforms wmt14.google.en.

#### [wmt10.fr-en](fr-en/wmt10.fr-en.cometcompare)
- wmt10.microsoft.en outperforms wmt10.bergamot.en.
- wmt10.google.en outperforms wmt10.bergamot.en.
- wmt10.microsoft.en outperforms wmt10.google.en.

#### [wmt13.fr-en](fr-en/wmt13.fr-en.cometcompare)
- wmt13.microsoft.en outperforms wmt13.bergamot.en.
- wmt13.google.en outperforms wmt13.bergamot.en.
- wmt13.microsoft.en outperforms wmt13.google.en.

#### [flores-dev.fr-en](fr-en/flores-dev.fr-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## en-pt

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.89 | 0.89 |
| google | 0.90 (+0.02, +1.78%) | 0.90 (+0.01, +1.68%) |
| microsoft | 0.90 (+0.01, +1.38%) | 0.90 (+0.01, +1.19%) |
| argos | 0.86 (-0.02, -2.50%) | 0.87 (-0.02, -2.74%) |
| nllb | 0.88 (-0.01, -0.61%) | 0.88 (-0.01, -0.61%) |
| opusmt | N/A | N/A |

![Results](img/en-pt-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-pt](en-pt/flores-test.en-pt.cometcompare)
- flores-test.microsoft.pt outperforms flores-test.bergamot.pt.
- flores-test.google.pt outperforms flores-test.bergamot.pt.
- flores-test.google.pt outperforms flores-test.microsoft.pt.

#### [flores-dev.en-pt](en-pt/flores-dev.en-pt.cometcompare)
- flores-dev.microsoft.pt outperforms flores-dev.bergamot.pt.
- flores-dev.google.pt outperforms flores-dev.bergamot.pt.
- flores-dev.google.pt outperforms flores-dev.microsoft.pt.

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

## en-nb

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.90 | 0.90 |
| microsoft | 0.90 | 0.90 |
| argos | N/A | N/A |
| nllb | 0.87 | 0.87 |
| opusmt | N/A | N/A |

![Results](img/en-nb-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-nb](en-nb/flores-test.en-nb.cometcompare)

#### [flores-dev.en-nb](en-nb/flores-dev.en-nb.cometcompare)

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

## en-el

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.89 | 0.90 |
| microsoft | 0.89 | 0.90 |
| argos | 0.87 | 0.87 |
| nllb | 0.87 | 0.87 |
| opusmt | 0.86 | 0.87 |

![Results](img/en-el-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-el](en-el/flores-test.en-el.cometcompare)

#### [flores-dev.en-el](en-el/flores-dev.en-el.cometcompare)

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

## en-da

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.91 | 0.91 |
| microsoft | 0.91 | 0.91 |
| argos | 0.83 | 0.83 |
| nllb | 0.88 | 0.89 |
| opusmt | 0.88 | 0.88 |

![Results](img/en-da-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-da](en-da/flores-test.en-da.cometcompare)

#### [flores-dev.en-da](en-da/flores-dev.en-da.cometcompare)

---

## en-nl

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | 0.86 | 0.86 |
| google | 0.88 (+0.02, +2.38%) | 0.88 (+0.02, +2.74%) |
| microsoft | 0.88 (+0.02, +1.90%) | 0.88 (+0.02, +2.34%) |
| argos | 0.84 (-0.02, -2.13%) | 0.85 (-0.01, -1.32%) |
| nllb | 0.85 (-0.01, -1.09%) | 0.86 (-0.00, -0.43%) |
| opusmt | 0.85 (-0.01, -1.39%) | 0.85 (-0.01, -1.05%) |

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

## en-mt

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.73 | 0.73 |
| microsoft | 0.74 | 0.74 |
| argos | N/A | N/A |
| nllb | 0.69 | 0.69 |
| opusmt | N/A | N/A |

![Results](img/en-mt-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-mt](en-mt/flores-dev.en-mt.cometcompare)

#### [flores-test.en-mt](en-mt/flores-test.en-mt.cometcompare)

---

## en-sv

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.91 | 0.91 |
| microsoft | 0.92 | 0.92 |
| argos | 0.87 | 0.87 |
| nllb | 0.88 | 0.88 |
| opusmt | 0.89 | 0.89 |

![Results](img/en-sv-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-sv](en-sv/flores-dev.en-sv.cometcompare)

#### [flores-test.en-sv](en-sv/flores-test.en-sv.cometcompare)

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

## bs-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.89 | 0.89 |
| microsoft | 0.89 | 0.89 |
| argos | N/A | N/A |
| nllb | 0.75 | 0.76 |
| opusmt | N/A | N/A |

![Results](img/bs-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.bs-en](bs-en/flores-test.bs-en.cometcompare)

#### [flores-dev.bs-en](bs-en/flores-dev.bs-en.cometcompare)

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

## en-ca

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.88 | 0.88 |
| microsoft | 0.88 | 0.88 |
| argos | 0.77 | 0.77 |
| nllb | 0.85 | 0.85 |
| opusmt | 0.76 | 0.77 |

![Results](img/en-ca-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-ca](en-ca/flores-test.en-ca.cometcompare)

#### [flores-dev.en-ca](en-ca/flores-dev.en-ca.cometcompare)

---

## nl-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.86 | 0.86 |
| google | 0.88 (+0.02, +2.07%) | 0.88 (+0.02, +2.14%) |
| microsoft | 0.87 (+0.02, +1.85%) | 0.87 (+0.02, +1.76%) |
| argos | 0.86 (+0.00, +0.27%) | 0.86 (+0.00, +0.47%) |
| nllb | 0.81 (-0.05, -5.75%) | 0.81 (-0.05, -5.82%) |
| opusmt | 0.86 (+0.00, +0.36%) | 0.86 (+0.00, +0.50%) |

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

## en-lt

| Translator/Dataset | flores-dev | wmt19 | flores-test |
| --- | --- | --- | --- |
| bergamot | N/A | N/A | N/A |
| google | 0.91 | 0.86 | 0.91 |
| microsoft | 0.90 | 0.86 | 0.90 |
| argos | N/A | N/A | N/A |
| nllb | 0.82 | 0.78 | 0.83 |
| opusmt | N/A | N/A | N/A |

![Results](img/en-lt-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-lt](en-lt/flores-dev.en-lt.cometcompare)

#### [wmt19.en-lt](en-lt/wmt19.en-lt.cometcompare)

#### [flores-test.en-lt](en-lt/flores-test.en-lt.cometcompare)

---

## en-tr

| Translator/Dataset | wmt17 | wmt18 | flores-test | flores-dev | wmt16 |
| --- | --- | --- | --- | --- | --- |
| bergamot | N/A | N/A | N/A | N/A | N/A |
| google | 0.90 | 0.90 | 0.91 | 0.91 | 0.90 |
| microsoft | 0.90 | 0.90 | 0.91 | 0.91 | 0.89 |
| argos | 0.77 | 0.78 | 0.78 | 0.79 | 0.78 |
| nllb | 0.86 | 0.86 | 0.86 | 0.87 | 0.85 |
| opusmt | N/A | N/A | N/A | N/A | N/A |

![Results](img/en-tr-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt17.en-tr](en-tr/wmt17.en-tr.cometcompare)

#### [wmt18.en-tr](en-tr/wmt18.en-tr.cometcompare)

#### [flores-test.en-tr](en-tr/flores-test.en-tr.cometcompare)

#### [flores-dev.en-tr](en-tr/flores-dev.en-tr.cometcompare)

#### [wmt16.en-tr](en-tr/wmt16.en-tr.cometcompare)

---

## bg-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.87 | 0.87 |
| google | 0.89 (+0.02, +2.23%) | 0.89 (+0.02, +2.35%) |
| microsoft | 0.88 (+0.01, +1.63%) | 0.88 (+0.01, +1.63%) |
| argos | 0.85 (-0.01, -1.29%) | 0.85 (-0.01, -1.45%) |
| nllb | 0.86 (-0.01, -1.19%) | 0.86 (-0.01, -1.15%) |
| opusmt | 0.86 (-0.00, -0.35%) | 0.86 (-0.01, -0.69%) |

![Results](img/bg-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.bg-en](bg-en/flores-test.bg-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [flores-dev.bg-en](bg-en/flores-dev.bg-en.cometcompare)
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

## en-es

| Translator/Dataset | wmt11 | wmt08 | wmt13 | flores-dev | flores-test | wmt09 | wmt12 | wmt10 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.83 | 0.81 | 0.84 | 0.84 | 0.84 | 0.83 | 0.84 | 0.84 |
| google | 0.85 (+0.02, +2.24%) | 0.84 (+0.02, +2.85%) | 0.86 (+0.02, +1.81%) | 0.87 (+0.03, +3.15%) | 0.87 (+0.03, +3.25%) | 0.84 (+0.02, +2.01%) | 0.85 (+0.01, +1.65%) | 0.86 (+0.02, +2.25%) |
| microsoft | 0.85 (+0.02, +2.92%) | 0.84 (+0.02, +2.96%) | 0.86 (+0.02, +2.23%) | 0.86 (+0.02, +2.77%) | 0.86 (+0.02, +2.95%) | 0.85 (+0.02, +2.45%) | 0.86 (+0.02, +2.39%) | 0.86 (+0.02, +2.55%) |
| argos | 0.82 (-0.01, -1.10%) | 0.80 (-0.01, -1.29%) | 0.83 (-0.01, -1.26%) | 0.82 (-0.02, -2.06%) | 0.83 (-0.01, -1.49%) | 0.82 (-0.01, -1.02%) | 0.82 (-0.02, -2.11%) | 0.83 (-0.02, -1.78%) |
| nllb | 0.84 (+0.01, +1.16%) | 0.82 (+0.01, +1.23%) | 0.85 (+0.01, +0.64%) | 0.85 (+0.01, +1.16%) | 0.85 (+0.01, +1.42%) | 0.83 (+0.01, +0.72%) | 0.84 (+0.00, +0.39%) | 0.85 (+0.00, +0.57%) |
| opusmt | 0.84 (+0.01, +1.29%) | 0.82 (+0.01, +1.29%) | 0.85 (+0.01, +1.04%) | 0.85 (+0.01, +1.07%) | 0.85 (+0.01, +1.18%) | 0.83 (+0.01, +1.05%) | 0.85 (+0.01, +0.87%) | 0.85 (+0.01, +1.13%) |

![Results](img/en-es-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt11.en-es](en-es/wmt11.en-es.cometcompare)
- wmt11.microsoft.es outperforms wmt11.bergamot.es.
- wmt11.google.es outperforms wmt11.bergamot.es.
- wmt11.microsoft.es outperforms wmt11.google.es.

#### [wmt08.en-es](en-es/wmt08.en-es.cometcompare)
- wmt08.microsoft.es outperforms wmt08.bergamot.es.
- wmt08.google.es outperforms wmt08.bergamot.es.

#### [wmt13.en-es](en-es/wmt13.en-es.cometcompare)
- wmt13.microsoft.es outperforms wmt13.bergamot.es.
- wmt13.google.es outperforms wmt13.bergamot.es.
- wmt13.microsoft.es outperforms wmt13.google.es.

#### [flores-dev.en-es](en-es/flores-dev.en-es.cometcompare)
- flores-dev.microsoft.es outperforms flores-dev.bergamot.es.
- flores-dev.google.es outperforms flores-dev.bergamot.es.
- flores-dev.google.es outperforms flores-dev.microsoft.es.

#### [flores-test.en-es](en-es/flores-test.en-es.cometcompare)
- flores-test.microsoft.es outperforms flores-test.bergamot.es.
- flores-test.google.es outperforms flores-test.bergamot.es.
- flores-test.google.es outperforms flores-test.microsoft.es.

#### [wmt09.en-es](en-es/wmt09.en-es.cometcompare)
- wmt09.microsoft.es outperforms wmt09.bergamot.es.
- wmt09.google.es outperforms wmt09.bergamot.es.
- wmt09.microsoft.es outperforms wmt09.google.es.

#### [wmt12.en-es](en-es/wmt12.en-es.cometcompare)
- wmt12.microsoft.es outperforms wmt12.bergamot.es.
- wmt12.google.es outperforms wmt12.bergamot.es.
- wmt12.microsoft.es outperforms wmt12.google.es.

#### [wmt10.en-es](en-es/wmt10.en-es.cometcompare)
- wmt10.microsoft.es outperforms wmt10.bergamot.es.
- wmt10.google.es outperforms wmt10.bergamot.es.

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

## en-bg

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | 0.89 | 0.89 |
| google | 0.92 (+0.02, +2.56%) | 0.92 (+0.02, +2.50%) |
| microsoft | 0.91 (+0.02, +1.87%) | 0.91 (+0.02, +1.71%) |
| argos | 0.88 (-0.01, -1.30%) | 0.88 (-0.01, -1.63%) |
| nllb | 0.88 (-0.01, -1.43%) | 0.88 (-0.01, -1.66%) |
| opusmt | 0.82 (-0.07, -7.92%) | 0.82 (-0.07, -7.81%) |

![Results](img/en-bg-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-bg](en-bg/flores-test.en-bg.cometcompare)
- flores-test.microsoft.bg outperforms flores-test.bergamot.bg.
- flores-test.google.bg outperforms flores-test.bergamot.bg.
- flores-test.google.bg outperforms flores-test.microsoft.bg.

#### [flores-dev.en-bg](en-bg/flores-dev.en-bg.cometcompare)
- flores-dev.microsoft.bg outperforms flores-dev.bergamot.bg.
- flores-dev.google.bg outperforms flores-dev.bergamot.bg.
- flores-dev.google.bg outperforms flores-dev.microsoft.bg.

---

## en-bs

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.91 | 0.92 |
| microsoft | 0.91 | 0.91 |
| argos | N/A | N/A |
| nllb | 0.86 | 0.87 |
| opusmt | N/A | N/A |

![Results](img/en-bs-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-bs](en-bs/flores-test.en-bs.cometcompare)

#### [flores-dev.en-bs](en-bs/flores-dev.en-bs.cometcompare)

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

## sv-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.90 | 0.90 |
| microsoft | 0.90 | 0.91 |
| argos | 0.88 | 0.88 |
| nllb | 0.77 | 0.78 |
| opusmt | 0.89 | 0.89 |

![Results](img/sv-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.sv-en](sv-en/flores-test.sv-en.cometcompare)

#### [flores-dev.sv-en](sv-en/flores-dev.sv-en.cometcompare)

---

## en-is

| Translator/Dataset | flores-dev | wmt21 | flores-test |
| --- | --- | --- | --- |
| bergamot | N/A | N/A | N/A |
| google | 0.87 | 0.85 | 0.87 |
| microsoft | 0.86 | 0.85 | 0.86 |
| argos | N/A | N/A | N/A |
| nllb | 0.79 | 0.78 | 0.79 |
| opusmt | 0.76 | 0.70 | 0.76 |

![Results](img/en-is-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-is](en-is/flores-dev.en-is.cometcompare)

#### [wmt21.en-is](en-is/wmt21.en-is.cometcompare)

#### [flores-test.en-is](en-is/flores-test.en-is.cometcompare)

---

## id-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.90 | 0.90 |
| microsoft | 0.90 | 0.90 |
| argos | 0.80 | 0.81 |
| nllb | 0.86 | 0.86 |
| opusmt | 0.86 | 0.86 |

![Results](img/id-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.id-en](id-en/flores-test.id-en.cometcompare)

#### [flores-dev.id-en](id-en/flores-dev.id-en.cometcompare)

---

## de-en

| Translator/Dataset | wmt20 | wmt17 | wmt22 | flores-test | wmt08 | wmt12 | wmt15 | wmt21 | wmt11 | wmt18 | iwslt17 | wmt09 | wmt14 | wmt10 | wmt16 | wmt13 | wmt19 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.82 | 0.83 | 0.81 | 0.87 | 0.81 | 0.81 | 0.83 | 0.82 | 0.80 | 0.85 | 0.84 | 0.81 | 0.83 | 0.82 | 0.84 | 0.84 | 0.81 | 0.87 |
| google | 0.85 (+0.03, +3.74%) | 0.87 (+0.03, +3.87%) | 0.85 (+0.04, +4.45%) | 0.89 (+0.02, +2.42%) | 0.84 (+0.03, +3.53%) | 0.84 (+0.03, +3.80%) | 0.86 (+0.03, +3.34%) | 0.85 (+0.03, +3.62%) | 0.83 (+0.02, +2.82%) | 0.87 (+0.03, +2.94%) | 0.86 (+0.02, +2.62%) | 0.84 (+0.03, +3.24%) | 0.86 (+0.03, +3.81%) | 0.85 (+0.03, +3.85%) | 0.87 (+0.03, +3.41%) | 0.86 (+0.02, +2.54%) | 0.85 (+0.04, +4.32%) | 0.89 (+0.02, +2.50%) |
| microsoft | 0.86 (+0.04, +4.81%) | 0.87 (+0.04, +4.51%) | 0.85 (+0.04, +4.32%) | 0.90 (+0.03, +2.96%) | 0.84 (+0.03, +4.18%) | 0.85 (+0.04, +5.00%) | 0.87 (+0.03, +3.99%) | 0.86 (+0.04, +4.40%) | 0.84 (+0.04, +4.41%) | 0.89 (+0.04, +4.26%) | 0.86 (+0.03, +2.99%) | 0.84 (+0.03, +4.09%) | 0.87 (+0.04, +4.47%) | 0.85 (+0.04, +4.60%) | 0.88 (+0.04, +4.25%) | 0.86 (+0.03, +3.44%) | 0.85 (+0.04, +5.43%) | 0.90 (+0.03, +3.02%) |
| argos | 0.81 (-0.01, -1.52%) | 0.82 (-0.01, -1.68%) | 0.81 (-0.00, -0.55%) | 0.86 (-0.01, -0.88%) | 0.80 (-0.01, -1.05%) | 0.80 (-0.01, -1.05%) | 0.82 (-0.01, -1.51%) | 0.81 (-0.01, -1.65%) | 0.80 (-0.01, -0.68%) | 0.83 (-0.01, -1.73%) | 0.82 (-0.01, -1.28%) | 0.80 (-0.01, -0.85%) | 0.82 (-0.01, -1.42%) | 0.81 (-0.01, -0.96%) | 0.83 (-0.01, -1.62%) | 0.82 (-0.01, -1.26%) | 0.79 (-0.02, -2.37%) | 0.86 (-0.01, -1.10%) |
| nllb | 0.72 (-0.10, -12.40%) | 0.74 (-0.09, -11.02%) | 0.72 (-0.09, -11.62%) | 0.79 (-0.08, -8.79%) | 0.74 (-0.07, -8.50%) | 0.73 (-0.07, -9.12%) | 0.76 (-0.08, -9.33%) | 0.72 (-0.10, -12.00%) | 0.73 (-0.08, -9.68%) | 0.76 (-0.09, -10.63%) | 0.76 (-0.07, -8.49%) | 0.74 (-0.07, -8.53%) | 0.74 (-0.09, -10.25%) | 0.74 (-0.07, -8.67%) | 0.76 (-0.09, -10.13%) | 0.76 (-0.07, -8.68%) | 0.71 (-0.10, -12.54%) | 0.80 (-0.07, -8.21%) |
| opusmt | 0.84 (+0.02, +2.42%) | 0.85 (+0.02, +1.84%) | 0.83 (+0.01, +1.71%) | 0.88 (+0.01, +1.34%) | 0.82 (+0.02, +1.92%) | 0.83 (+0.02, +2.53%) | 0.85 (+0.01, +1.69%) | 0.84 (+0.02, +2.19%) | 0.82 (+0.02, +2.29%) | 0.86 (+0.01, +1.46%) | 0.85 (+0.01, +1.38%) | 0.82 (+0.01, +1.84%) | 0.85 (+0.02, +1.84%) | 0.83 (+0.02, +2.32%) | 0.85 (+0.01, +1.53%) | 0.85 (+0.01, +1.62%) | 0.82 (+0.01, +1.64%) | 0.88 (+0.01, +1.47%) |

![Results](img/de-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt20.de-en](de-en/wmt20.de-en.cometcompare)
- wmt20.microsoft.en outperforms wmt20.bergamot.en.
- wmt20.google.en outperforms wmt20.bergamot.en.
- wmt20.microsoft.en outperforms wmt20.google.en.

#### [wmt17.de-en](de-en/wmt17.de-en.cometcompare)
- wmt17.microsoft.en outperforms wmt17.bergamot.en.
- wmt17.google.en outperforms wmt17.bergamot.en.
- wmt17.microsoft.en outperforms wmt17.google.en.

#### [wmt22.de-en](de-en/wmt22.de-en.cometcompare)
- wmt22.microsoft.en outperforms wmt22.bergamot.en.
- wmt22.google.en outperforms wmt22.bergamot.en.

#### [flores-test.de-en](de-en/flores-test.de-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.microsoft.en outperforms flores-test.google.en.

#### [wmt08.de-en](de-en/wmt08.de-en.cometcompare)
- wmt08.microsoft.en outperforms wmt08.bergamot.en.
- wmt08.google.en outperforms wmt08.bergamot.en.
- wmt08.microsoft.en outperforms wmt08.google.en.

#### [wmt12.de-en](de-en/wmt12.de-en.cometcompare)
- wmt12.microsoft.en outperforms wmt12.bergamot.en.
- wmt12.google.en outperforms wmt12.bergamot.en.
- wmt12.microsoft.en outperforms wmt12.google.en.

#### [wmt15.de-en](de-en/wmt15.de-en.cometcompare)
- wmt15.microsoft.en outperforms wmt15.bergamot.en.
- wmt15.google.en outperforms wmt15.bergamot.en.
- wmt15.microsoft.en outperforms wmt15.google.en.

#### [wmt21.de-en](de-en/wmt21.de-en.cometcompare)
- wmt21.microsoft.en outperforms wmt21.bergamot.en.
- wmt21.google.en outperforms wmt21.bergamot.en.
- wmt21.microsoft.en outperforms wmt21.google.en.

#### [wmt11.de-en](de-en/wmt11.de-en.cometcompare)
- wmt11.microsoft.en outperforms wmt11.bergamot.en.
- wmt11.google.en outperforms wmt11.bergamot.en.
- wmt11.microsoft.en outperforms wmt11.google.en.

#### [wmt18.de-en](de-en/wmt18.de-en.cometcompare)
- wmt18.microsoft.en outperforms wmt18.bergamot.en.
- wmt18.google.en outperforms wmt18.bergamot.en.
- wmt18.microsoft.en outperforms wmt18.google.en.

#### [iwslt17.de-en](de-en/iwslt17.de-en.cometcompare)
- iwslt17.microsoft.en outperforms iwslt17.bergamot.en.
- iwslt17.google.en outperforms iwslt17.bergamot.en.
- iwslt17.microsoft.en outperforms iwslt17.google.en.

#### [wmt09.de-en](de-en/wmt09.de-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.
- wmt09.microsoft.en outperforms wmt09.google.en.

#### [wmt14.de-en](de-en/wmt14.de-en.cometcompare)
- wmt14.microsoft.en outperforms wmt14.bergamot.en.
- wmt14.google.en outperforms wmt14.bergamot.en.
- wmt14.microsoft.en outperforms wmt14.google.en.

#### [wmt10.de-en](de-en/wmt10.de-en.cometcompare)
- wmt10.microsoft.en outperforms wmt10.bergamot.en.
- wmt10.google.en outperforms wmt10.bergamot.en.
- wmt10.microsoft.en outperforms wmt10.google.en.

#### [wmt16.de-en](de-en/wmt16.de-en.cometcompare)
- wmt16.microsoft.en outperforms wmt16.bergamot.en.
- wmt16.google.en outperforms wmt16.bergamot.en.
- wmt16.microsoft.en outperforms wmt16.google.en.

#### [wmt13.de-en](de-en/wmt13.de-en.cometcompare)
- wmt13.microsoft.en outperforms wmt13.bergamot.en.
- wmt13.google.en outperforms wmt13.bergamot.en.
- wmt13.microsoft.en outperforms wmt13.google.en.

#### [wmt19.de-en](de-en/wmt19.de-en.cometcompare)
- wmt19.microsoft.en outperforms wmt19.bergamot.en.
- wmt19.google.en outperforms wmt19.bergamot.en.
- wmt19.microsoft.en outperforms wmt19.google.en.

#### [flores-dev.de-en](de-en/flores-dev.de-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.microsoft.en outperforms flores-dev.google.en.

---

## da-en

| Translator/Dataset | flores-test | flores-dev |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.90 | 0.91 |
| microsoft | 0.91 | 0.91 |
| argos | 0.84 | 0.85 |
| nllb | 0.78 | 0.78 |
| opusmt | 0.89 | 0.89 |

![Results](img/da-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.da-en](da-en/flores-test.da-en.cometcompare)

#### [flores-dev.da-en](da-en/flores-dev.da-en.cometcompare)

---

## it-en

| Translator/Dataset | flores-test | mtedx_test | wmt09 | flores-dev |
| --- | --- | --- | --- | --- |
| bergamot | 0.86 | 0.83 | 0.82 | 0.87 |
| google | 0.88 (+0.02, +1.86%) | 0.85 (+0.02, +2.04%) | 0.84 (+0.02, +2.09%) | 0.88 (+0.01, +1.44%) |
| microsoft | 0.88 (+0.02, +1.87%) | 0.85 (+0.02, +1.86%) | 0.84 (+0.02, +2.66%) | 0.88 (+0.01, +1.51%) |
| argos | 0.85 (-0.01, -1.36%) | 0.82 (-0.01, -1.30%) | 0.81 (-0.01, -1.62%) | 0.86 (-0.01, -1.48%) |
| nllb | 0.84 (-0.02, -2.59%) | 0.79 (-0.05, -5.58%) | 0.80 (-0.03, -3.21%) | 0.84 (-0.03, -2.89%) |
| opusmt | 0.87 (+0.00, +0.12%) | 0.84 (+0.00, +0.46%) | 0.83 (+0.00, +0.58%) | 0.87 (-0.00, -0.07%) |

![Results](img/it-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.it-en](it-en/flores-test.it-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [mtedx_test.it-en](it-en/mtedx_test.it-en.cometcompare)
- mtedx_test.microsoft.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.bergamot.en.

#### [wmt09.it-en](it-en/wmt09.it-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.
- wmt09.microsoft.en outperforms wmt09.google.en.

#### [flores-dev.it-en](it-en/flores-dev.it-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## pl-en

| Translator/Dataset | wmt20 | flores-test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.82 | 0.84 | 0.84 |
| google | 0.84 (+0.02, +2.78%) | 0.86 (+0.03, +3.05%) | 0.86 (+0.02, +2.88%) |
| microsoft | 0.85 (+0.03, +3.47%) | 0.86 (+0.03, +3.15%) | 0.86 (+0.02, +2.77%) |
| argos | 0.82 (-0.00, -0.18%) | 0.84 (+0.00, +0.55%) | 0.85 (+0.01, +0.70%) |
| nllb | 0.74 (-0.08, -9.35%) | 0.78 (-0.06, -7.29%) | 0.79 (-0.05, -6.50%) |
| opusmt | 0.81 (-0.01, -1.05%) | 0.84 (+0.00, +0.11%) | 0.84 (+0.00, +0.23%) |

![Results](img/pl-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt20.pl-en](pl-en/wmt20.pl-en.cometcompare)
- wmt20.microsoft.en outperforms wmt20.bergamot.en.
- wmt20.google.en outperforms wmt20.bergamot.en.
- wmt20.microsoft.en outperforms wmt20.google.en.

#### [flores-test.pl-en](pl-en/flores-test.pl-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [flores-dev.pl-en](pl-en/flores-dev.pl-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

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

## en-fr

| Translator/Dataset | wmt11 | wmt10 | wmt14 | flores-test | wmt09 | wmt08 | wmt15 | flores-dev | wmt12 | iwslt17 | wmt13 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.81 | 0.81 | 0.84 | 0.85 | 0.81 | 0.79 | 0.80 | 0.86 | 0.81 | 0.83 | 0.82 |
| google | 0.83 (+0.02, +3.00%) | 0.85 (+0.03, +3.88%) | 0.87 (+0.03, +3.59%) | 0.88 (+0.03, +3.92%) | 0.83 (+0.03, +3.26%) | 0.82 (+0.03, +4.17%) | 0.84 (+0.04, +5.38%) | 0.88 (+0.03, +3.21%) | 0.83 (+0.02, +2.76%) | 0.85 (+0.02, +2.59%) | 0.85 (+0.02, +2.96%) |
| microsoft | 0.84 (+0.03, +3.81%) | 0.85 (+0.04, +4.48%) | 0.88 (+0.04, +4.58%) | 0.89 (+0.04, +4.23%) | 0.84 (+0.03, +4.07%) | 0.83 (+0.04, +4.52%) | 0.85 (+0.05, +5.76%) | 0.89 (+0.03, +3.66%) | 0.84 (+0.03, +3.76%) | 0.86 (+0.03, +3.22%) | 0.85 (+0.03, +3.66%) |
| argos | 0.80 (-0.01, -1.05%) | 0.80 (-0.01, -1.29%) | 0.82 (-0.02, -2.16%) | 0.84 (-0.02, -1.88%) | 0.80 (-0.01, -0.79%) | 0.78 (-0.01, -1.00%) | 0.79 (-0.01, -0.86%) | 0.84 (-0.02, -2.55%) | 0.80 (-0.01, -1.20%) | 0.81 (-0.02, -1.83%) | 0.81 (-0.01, -1.45%) |
| nllb | 0.83 (+0.02, +2.03%) | 0.83 (+0.02, +2.24%) | 0.85 (+0.02, +1.96%) | 0.87 (+0.01, +1.69%) | 0.82 (+0.01, +1.76%) | 0.81 (+0.02, +2.41%) | 0.82 (+0.02, +2.41%) | 0.87 (+0.01, +1.10%) | 0.82 (+0.01, +1.73%) | 0.84 (+0.01, +1.23%) | 0.83 (+0.01, +1.40%) |
| opusmt | 0.82 (+0.01, +1.51%) | 0.83 (+0.02, +1.90%) | 0.85 (+0.01, +1.41%) | 0.86 (+0.01, +1.21%) | 0.82 (+0.01, +1.84%) | 0.80 (+0.01, +1.65%) | 0.81 (+0.01, +1.86%) | 0.86 (+0.01, +0.73%) | 0.82 (+0.01, +1.64%) | 0.84 (+0.01, +0.74%) | 0.83 (+0.01, +1.34%) |

![Results](img/en-fr-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt11.en-fr](en-fr/wmt11.en-fr.cometcompare)
- wmt11.microsoft.fr outperforms wmt11.bergamot.fr.
- wmt11.google.fr outperforms wmt11.bergamot.fr.
- wmt11.microsoft.fr outperforms wmt11.google.fr.

#### [wmt10.en-fr](en-fr/wmt10.en-fr.cometcompare)
- wmt10.microsoft.fr outperforms wmt10.bergamot.fr.
- wmt10.google.fr outperforms wmt10.bergamot.fr.
- wmt10.microsoft.fr outperforms wmt10.google.fr.

#### [wmt14.en-fr](en-fr/wmt14.en-fr.cometcompare)
- wmt14.microsoft.fr outperforms wmt14.bergamot.fr.
- wmt14.google.fr outperforms wmt14.bergamot.fr.
- wmt14.microsoft.fr outperforms wmt14.google.fr.

#### [flores-test.en-fr](en-fr/flores-test.en-fr.cometcompare)
- flores-test.microsoft.fr outperforms flores-test.bergamot.fr.
- flores-test.google.fr outperforms flores-test.bergamot.fr.

#### [wmt09.en-fr](en-fr/wmt09.en-fr.cometcompare)
- wmt09.microsoft.fr outperforms wmt09.bergamot.fr.
- wmt09.google.fr outperforms wmt09.bergamot.fr.
- wmt09.microsoft.fr outperforms wmt09.google.fr.

#### [wmt08.en-fr](en-fr/wmt08.en-fr.cometcompare)
- wmt08.microsoft.fr outperforms wmt08.bergamot.fr.
- wmt08.google.fr outperforms wmt08.bergamot.fr.

#### [wmt15.en-fr](en-fr/wmt15.en-fr.cometcompare)
- wmt15.microsoft.fr outperforms wmt15.bergamot.fr.
- wmt15.google.fr outperforms wmt15.bergamot.fr.

#### [flores-dev.en-fr](en-fr/flores-dev.en-fr.cometcompare)
- flores-dev.microsoft.fr outperforms flores-dev.bergamot.fr.
- flores-dev.google.fr outperforms flores-dev.bergamot.fr.
- flores-dev.microsoft.fr outperforms flores-dev.google.fr.

#### [wmt12.en-fr](en-fr/wmt12.en-fr.cometcompare)
- wmt12.microsoft.fr outperforms wmt12.bergamot.fr.
- wmt12.google.fr outperforms wmt12.bergamot.fr.
- wmt12.microsoft.fr outperforms wmt12.google.fr.

#### [iwslt17.en-fr](en-fr/iwslt17.en-fr.cometcompare)
- iwslt17.microsoft.fr outperforms iwslt17.bergamot.fr.
- iwslt17.google.fr outperforms iwslt17.bergamot.fr.
- iwslt17.microsoft.fr outperforms iwslt17.google.fr.

#### [wmt13.en-fr](en-fr/wmt13.en-fr.cometcompare)
- wmt13.microsoft.fr outperforms wmt13.bergamot.fr.
- wmt13.google.fr outperforms wmt13.bergamot.fr.
- wmt13.microsoft.fr outperforms wmt13.google.fr.

---

## en-pl

| Translator/Dataset | flores-test | flores-dev | wmt20 |
| --- | --- | --- | --- |
| bergamot | 0.86 | 0.86 | 0.85 |
| google | 0.90 (+0.04, +4.86%) | 0.90 (+0.04, +4.81%) | 0.89 (+0.04, +4.97%) |
| microsoft | 0.89 (+0.04, +4.14%) | 0.89 (+0.03, +3.83%) | 0.89 (+0.04, +4.45%) |
| argos | 0.85 (-0.01, -1.14%) | 0.85 (-0.01, -1.49%) | 0.82 (-0.02, -2.91%) |
| nllb | 0.84 (-0.02, -1.76%) | 0.85 (-0.01, -1.50%) | 0.84 (-0.01, -1.24%) |
| opusmt | N/A | N/A | N/A |

![Results](img/en-pl-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.en-pl](en-pl/flores-test.en-pl.cometcompare)
- flores-test.microsoft.pl outperforms flores-test.bergamot.pl.
- flores-test.google.pl outperforms flores-test.bergamot.pl.
- flores-test.google.pl outperforms flores-test.microsoft.pl.

#### [flores-dev.en-pl](en-pl/flores-dev.en-pl.cometcompare)
- flores-dev.microsoft.pl outperforms flores-dev.bergamot.pl.
- flores-dev.google.pl outperforms flores-dev.bergamot.pl.
- flores-dev.google.pl outperforms flores-dev.microsoft.pl.

#### [wmt20.en-pl](en-pl/wmt20.en-pl.cometcompare)
- wmt20.microsoft.pl outperforms wmt20.bergamot.pl.
- wmt20.google.pl outperforms wmt20.bergamot.pl.
- wmt20.google.pl outperforms wmt20.microsoft.pl.

---

## en-id

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.92 | 0.92 |
| microsoft | 0.92 | 0.92 |
| argos | 0.83 | 0.83 |
| nllb | 0.90 | 0.90 |
| opusmt | 0.88 | 0.88 |

![Results](img/en-id-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-id](en-id/flores-dev.en-id.cometcompare)

#### [flores-test.en-id](en-id/flores-test.en-id.cometcompare)

---

## pt-en

| Translator/Dataset | flores-test | mtedx_test | flores-dev |
| --- | --- | --- | --- |
| bergamot | 0.88 | 0.85 | 0.89 |
| google | 0.90 (+0.01, +1.48%) | 0.87 (+0.02, +1.82%) | 0.90 (+0.01, +1.31%) |
| microsoft | 0.90 (+0.01, +1.46%) | 0.86 (+0.01, +1.55%) | 0.90 (+0.01, +1.30%) |
| argos | 0.88 (-0.01, -0.72%) | 0.84 (-0.01, -0.81%) | 0.88 (-0.01, -0.85%) |
| nllb | 0.85 (-0.03, -3.44%) | 0.80 (-0.05, -5.44%) | 0.85 (-0.03, -3.64%) |
| opusmt | N/A | N/A | N/A |

![Results](img/pt-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.pt-en](pt-en/flores-test.pt-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.

#### [mtedx_test.pt-en](pt-en/mtedx_test.pt-en.cometcompare)
- mtedx_test.microsoft.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.microsoft.en.

#### [flores-dev.pt-en](pt-en/flores-dev.pt-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.

---

## es-en

| Translator/Dataset | flores-test | wmt08 | wmt12 | mtedx_test | wmt11 | wmt09 | wmt10 | wmt13 | flores-dev |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.85 | 0.81 | 0.83 | 0.81 | 0.82 | 0.81 | 0.83 | 0.84 | 0.85 |
| google | 0.87 (+0.02, +2.49%) | 0.82 (+0.01, +1.75%) | 0.84 (+0.01, +0.93%) | 0.83 (+0.02, +2.17%) | 0.83 (+0.01, +0.84%) | 0.82 (+0.02, +2.07%) | 0.85 (+0.02, +1.90%) | 0.85 (+0.01, +1.01%) | 0.87 (+0.02, +2.60%) |
| microsoft | 0.87 (+0.02, +2.46%) | 0.82 (+0.02, +2.26%) | 0.85 (+0.02, +2.10%) | 0.83 (+0.02, +2.97%) | 0.84 (+0.02, +2.17%) | 0.83 (+0.02, +2.50%) | 0.85 (+0.02, +2.35%) | 0.86 (+0.02, +1.92%) | 0.87 (+0.02, +2.36%) |
| argos | 0.84 (-0.01, -0.66%) | 0.80 (-0.01, -1.07%) | 0.82 (-0.01, -1.25%) | 0.81 (-0.00, -0.46%) | 0.81 (-0.01, -1.13%) | 0.80 (-0.01, -0.90%) | 0.83 (-0.01, -0.96%) | 0.83 (-0.01, -1.00%) | 0.84 (-0.01, -0.96%) |
| nllb | 0.85 (+0.00, +0.56%) | 0.81 (+0.00, +0.35%) | 0.83 (-0.01, -0.66%) | 0.80 (-0.01, -1.63%) | 0.82 (-0.00, -0.43%) | 0.81 (+0.01, +0.78%) | 0.83 (-0.00, -0.01%) | 0.84 (-0.00, -0.53%) | 0.86 (+0.01, +0.67%) |
| opusmt | 0.86 (+0.01, +1.15%) | 0.81 (+0.01, +0.87%) | 0.84 (+0.00, +0.52%) | 0.83 (+0.01, +1.84%) | 0.83 (+0.01, +0.73%) | 0.82 (+0.01, +0.97%) | 0.84 (+0.01, +0.95%) | 0.85 (+0.01, +0.72%) | 0.86 (+0.01, +0.96%) |

![Results](img/es-en-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-test.es-en](es-en/flores-test.es-en.cometcompare)
- flores-test.microsoft.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.bergamot.en.
- flores-test.google.en outperforms flores-test.microsoft.en.

#### [wmt08.es-en](es-en/wmt08.es-en.cometcompare)
- wmt08.microsoft.en outperforms wmt08.bergamot.en.
- wmt08.google.en outperforms wmt08.bergamot.en.
- wmt08.microsoft.en outperforms wmt08.google.en.

#### [wmt12.es-en](es-en/wmt12.es-en.cometcompare)
- wmt12.microsoft.en outperforms wmt12.bergamot.en.
- wmt12.google.en outperforms wmt12.bergamot.en.
- wmt12.microsoft.en outperforms wmt12.google.en.

#### [mtedx_test.es-en](es-en/mtedx_test.es-en.cometcompare)
- mtedx_test.microsoft.en outperforms mtedx_test.bergamot.en.
- mtedx_test.google.en outperforms mtedx_test.bergamot.en.

#### [wmt11.es-en](es-en/wmt11.es-en.cometcompare)
- wmt11.microsoft.en outperforms wmt11.bergamot.en.
- wmt11.google.en outperforms wmt11.bergamot.en.
- wmt11.microsoft.en outperforms wmt11.google.en.

#### [wmt09.es-en](es-en/wmt09.es-en.cometcompare)
- wmt09.microsoft.en outperforms wmt09.bergamot.en.
- wmt09.google.en outperforms wmt09.bergamot.en.
- wmt09.microsoft.en outperforms wmt09.google.en.

#### [wmt10.es-en](es-en/wmt10.es-en.cometcompare)
- wmt10.microsoft.en outperforms wmt10.bergamot.en.
- wmt10.google.en outperforms wmt10.bergamot.en.
- wmt10.microsoft.en outperforms wmt10.google.en.

#### [wmt13.es-en](es-en/wmt13.es-en.cometcompare)
- wmt13.microsoft.en outperforms wmt13.bergamot.en.
- wmt13.google.en outperforms wmt13.bergamot.en.
- wmt13.microsoft.en outperforms wmt13.google.en.

#### [flores-dev.es-en](es-en/flores-dev.es-en.cometcompare)
- flores-dev.microsoft.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.bergamot.en.
- flores-dev.google.en outperforms flores-dev.microsoft.en.

---

## en-sl

| Translator/Dataset | flores-dev | flores-test |
| --- | --- | --- |
| bergamot | N/A | N/A |
| google | 0.91 | 0.91 |
| microsoft | 0.89 | 0.89 |
| argos | N/A | N/A |
| nllb | 0.84 | 0.84 |
| opusmt | N/A | N/A |

![Results](img/en-sl-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [flores-dev.en-sl](en-sl/flores-dev.en-sl.cometcompare)

#### [flores-test.en-sl](en-sl/flores-test.en-sl.cometcompare)

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

## en-de

| Translator/Dataset | wmt12 | wmt13 | wmt08 | wmt22 | wmt20 | flores-dev | wmt15 | wmt18 | wmt14 | wmt19 | wmt17 | wmt21 | wmt09 | wmt11 | iwslt17 | wmt16 | wmt10 | flores-test |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| bergamot | 0.82 | 0.84 | 0.82 | 0.82 | 0.84 | 0.86 | 0.84 | 0.87 | 0.85 | 0.84 | 0.85 | 0.82 | 0.82 | 0.81 | 0.82 | 0.86 | 0.83 | 0.86 |
| google | 0.84 (+0.02, +3.01%) | 0.86 (+0.02, +2.90%) | 0.85 (+0.03, +3.62%) | 0.87 (+0.05, +5.66%) | 0.87 (+0.03, +3.77%) | 0.89 (+0.03, +4.06%) | 0.87 (+0.03, +3.39%) | 0.89 (+0.02, +2.82%) | 0.88 (+0.03, +3.68%) | 0.87 (+0.02, +2.75%) | 0.87 (+0.03, +3.32%) | 0.85 (+0.02, +2.98%) | 0.84 (+0.03, +3.44%) | 0.84 (+0.03, +3.55%) | 0.85 (+0.03, +3.16%) | 0.88 (+0.03, +2.99%) | 0.85 (+0.02, +2.88%) | 0.89 (+0.03, +3.63%) |
| microsoft | 0.85 (+0.03, +3.50%) | 0.87 (+0.03, +3.28%) | 0.85 (+0.03, +3.89%) | 0.87 (+0.05, +5.69%) | 0.87 (+0.03, +4.12%) | 0.89 (+0.03, +3.85%) | 0.87 (+0.03, +3.48%) | 0.90 (+0.03, +3.21%) | 0.88 (+0.03, +3.77%) | 0.87 (+0.03, +3.44%) | 0.88 (+0.03, +3.59%) | 0.85 (+0.03, +3.43%) | 0.85 (+0.03, +3.86%) | 0.84 (+0.03, +4.22%) | 0.85 (+0.03, +3.23%) | 0.89 (+0.03, +3.41%) | 0.86 (+0.03, +3.37%) | 0.89 (+0.03, +3.67%) |
| argos | 0.78 (-0.04, -5.28%) | 0.81 (-0.03, -3.91%) | 0.77 (-0.05, -5.57%) | 0.79 (-0.03, -3.97%) | 0.75 (-0.09, -10.40%) | 0.81 (-0.04, -5.15%) | 0.79 (-0.05, -6.11%) | 0.82 (-0.05, -5.82%) | 0.80 (-0.05, -6.12%) | 0.76 (-0.08, -9.63%) | 0.80 (-0.05, -6.01%) | 0.74 (-0.09, -10.36%) | 0.78 (-0.03, -3.92%) | 0.77 (-0.03, -4.27%) | 0.79 (-0.04, -4.28%) | 0.80 (-0.05, -6.15%) | 0.79 (-0.04, -5.21%) | 0.81 (-0.04, -5.22%) |
| nllb | 0.81 (-0.01, -0.90%) | 0.83 (-0.00, -0.58%) | 0.81 (-0.01, -0.76%) | 0.82 (-0.00, -0.27%) | 0.82 (-0.02, -1.90%) | 0.85 (-0.00, -0.55%) | 0.83 (-0.01, -1.14%) | 0.85 (-0.02, -1.98%) | 0.84 (-0.01, -1.37%) | 0.82 (-0.02, -2.32%) | 0.83 (-0.01, -1.56%) | 0.81 (-0.02, -1.90%) | 0.82 (-0.00, -0.17%) | 0.81 (+0.00, +0.04%) | 0.81 (-0.01, -1.07%) | 0.84 (-0.02, -1.79%) | 0.83 (-0.00, -0.53%) | 0.85 (-0.01, -0.82%) |
| opusmt | 0.81 (-0.01, -0.88%) | 0.84 (-0.00, -0.25%) | 0.81 (-0.01, -0.81%) | 0.82 (-0.00, -0.21%) | 0.80 (-0.03, -3.76%) | 0.84 (-0.01, -1.51%) | 0.83 (-0.01, -1.10%) | 0.86 (-0.01, -0.70%) | 0.84 (-0.01, -1.26%) | 0.81 (-0.03, -3.47%) | 0.84 (-0.01, -1.09%) | 0.79 (-0.03, -4.13%) | 0.82 (-0.00, -0.13%) | 0.80 (-0.00, -0.42%) | 0.82 (-0.00, -0.27%) | 0.84 (-0.02, -1.81%) | 0.83 (-0.00, -0.54%) | 0.85 (-0.01, -1.13%) |

![Results](img/en-de-comet.png)
### Comparisons between systems
*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*
#### [wmt12.en-de](en-de/wmt12.en-de.cometcompare)
- wmt12.microsoft.de outperforms wmt12.bergamot.de.
- wmt12.google.de outperforms wmt12.bergamot.de.
- wmt12.microsoft.de outperforms wmt12.google.de.

#### [wmt13.en-de](en-de/wmt13.en-de.cometcompare)
- wmt13.microsoft.de outperforms wmt13.bergamot.de.
- wmt13.google.de outperforms wmt13.bergamot.de.
- wmt13.microsoft.de outperforms wmt13.google.de.

#### [wmt08.en-de](en-de/wmt08.en-de.cometcompare)
- wmt08.microsoft.de outperforms wmt08.bergamot.de.
- wmt08.google.de outperforms wmt08.bergamot.de.
- wmt08.microsoft.de outperforms wmt08.google.de.

#### [wmt22.en-de](en-de/wmt22.en-de.cometcompare)
- wmt22.microsoft.de outperforms wmt22.bergamot.de.
- wmt22.google.de outperforms wmt22.bergamot.de.

#### [wmt20.en-de](en-de/wmt20.en-de.cometcompare)
- wmt20.microsoft.de outperforms wmt20.bergamot.de.
- wmt20.google.de outperforms wmt20.bergamot.de.
- wmt20.microsoft.de outperforms wmt20.google.de.

#### [flores-dev.en-de](en-de/flores-dev.en-de.cometcompare)
- flores-dev.microsoft.de outperforms flores-dev.bergamot.de.
- flores-dev.google.de outperforms flores-dev.bergamot.de.

#### [wmt15.en-de](en-de/wmt15.en-de.cometcompare)
- wmt15.microsoft.de outperforms wmt15.bergamot.de.
- wmt15.google.de outperforms wmt15.bergamot.de.

#### [wmt18.en-de](en-de/wmt18.en-de.cometcompare)
- wmt18.microsoft.de outperforms wmt18.bergamot.de.
- wmt18.google.de outperforms wmt18.bergamot.de.
- wmt18.microsoft.de outperforms wmt18.google.de.

#### [wmt14.en-de](en-de/wmt14.en-de.cometcompare)
- wmt14.microsoft.de outperforms wmt14.bergamot.de.
- wmt14.google.de outperforms wmt14.bergamot.de.
- wmt14.microsoft.de outperforms wmt14.google.de.

#### [wmt19.en-de](en-de/wmt19.en-de.cometcompare)
- wmt19.microsoft.de outperforms wmt19.bergamot.de.
- wmt19.google.de outperforms wmt19.bergamot.de.
- wmt19.microsoft.de outperforms wmt19.google.de.

#### [wmt17.en-de](en-de/wmt17.en-de.cometcompare)
- wmt17.microsoft.de outperforms wmt17.bergamot.de.
- wmt17.google.de outperforms wmt17.bergamot.de.
- wmt17.microsoft.de outperforms wmt17.google.de.

#### [wmt21.en-de](en-de/wmt21.en-de.cometcompare)
- wmt21.microsoft.de outperforms wmt21.bergamot.de.
- wmt21.google.de outperforms wmt21.bergamot.de.
- wmt21.microsoft.de outperforms wmt21.google.de.

#### [wmt09.en-de](en-de/wmt09.en-de.cometcompare)
- wmt09.microsoft.de outperforms wmt09.bergamot.de.
- wmt09.google.de outperforms wmt09.bergamot.de.
- wmt09.microsoft.de outperforms wmt09.google.de.

#### [wmt11.en-de](en-de/wmt11.en-de.cometcompare)
- wmt11.microsoft.de outperforms wmt11.bergamot.de.
- wmt11.google.de outperforms wmt11.bergamot.de.
- wmt11.microsoft.de outperforms wmt11.google.de.

#### [iwslt17.en-de](en-de/iwslt17.en-de.cometcompare)
- iwslt17.microsoft.de outperforms iwslt17.bergamot.de.
- iwslt17.google.de outperforms iwslt17.bergamot.de.

#### [wmt16.en-de](en-de/wmt16.en-de.cometcompare)
- wmt16.microsoft.de outperforms wmt16.bergamot.de.
- wmt16.google.de outperforms wmt16.bergamot.de.
- wmt16.microsoft.de outperforms wmt16.google.de.

#### [wmt10.en-de](en-de/wmt10.en-de.cometcompare)
- wmt10.microsoft.de outperforms wmt10.bergamot.de.
- wmt10.google.de outperforms wmt10.bergamot.de.
- wmt10.microsoft.de outperforms wmt10.google.de.

#### [flores-test.en-de](en-de/flores-test.en-de.cometcompare)
- flores-test.microsoft.de outperforms flores-test.bergamot.de.
- flores-test.google.de outperforms flores-test.bergamot.de.

---