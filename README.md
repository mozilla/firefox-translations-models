# Firefox Translations models
CPU-optimized NMT models for Firefox Translations.

The model files are hosted using [Git LFS](https://docs.github.com/en/github/managing-large-files/versioning-large-files/about-git-large-file-storage).

[prod](models/prod) - higher quality models 

[dev](models/dev) - test models under development (can be of low quality or speed). 

When a dev model has satisfactory quality, it is moved to prod.

# Automatic quality evaluation

Results for prod models: [BLEU](evaluation/prod/bleu-results.md), [COMET](evaluation/prod/comet-results.md)

Results for dev models: [BLEU](evaluation/dev/bleu-results.md), [COMET](evaluation/dev/comet-results.md)

Automatic evaluation is a part of pull request CI. 
It uses Microsoft and Google translation APIs, Argos Translate, NLLB and Opus-MT models and pushes results back to the branch (not available for forks).
It is performed using the [evals](/evals) tool.

# Model training

Use [Firefox Translations training pipeline](https://github.com/mozilla/firefox-translations-training) or [browsermt/students](https://github.com/browsermt/students/tree/master/train-student) recipe to train CPU-optimized models. They should have similar size and inference speed to already submitted models.

## Training data

Do not use [SacreBLEU](https://github.com/mjpost/sacrebleu) or [Flores](https://github.com/facebookresearch/flores) datasets as a part of training data, otherwise evaluation will not be correct.

To see SacreBLEU datasets run `sacrebleu --list`.

# Model contribution

All models should be contributed to `dev` folder first.

## By maintainers

Create a pull Request to `main` branch from another branch in this repo.

## From forks

Create a Pull Request to `contrib` branch. 
When it is reviewed and merged, another pull request to `main` branch will be created by a maintainer to kick off automatic evaluation.

## Local testing

You can run model evaluation locally by running `bash scripts/update-results.sh`. 
Make sure to set environment variables `GCP_CREDS_PATH` and `AZURE_TRANSLATOR_KEY` to use Google and Microsoft APIs.
If you want to run it with `bergamot` only, remove mentions of those variables from `bash scripts/update-results.sh` and remove `microsoft,google` from `scripts/eval.sh`. 

# Model types

## Vocabulary

Prefix of the vocabulary file in the model registry:
- `vocab.` - vocabulary is reused for the source and target languages
- `srcvocab.` and `trgvocab.` - different vocabularies for the source and target languages

## GEMM precision

Suffix of the model file in the registry:
- `intgemm8.bin`  - supports `gemm-precision: int8shiftAll` inference setting
- `intgemm.alphas.bin` - supports `gemm-precision: int8shiftAlphaAll` inference setting

# Model deployment

Models are deployed to Remote Settings to be delivered to Firefox.

Records and attachments are uploaded via a CLI tool which lives in the
`remote_settings` directory in this repository.

At present, records are uploaded by invoking the script manually, but we would
like to automate this process whenever we merge a PR that adds new language models.

Run `poetry run python -m remote_settings --help` to see more information.

# Currently supported Languages

The prod/dev labels in this repo correspond to the labels in the [legacy web extension](https://github.com/mozilla/firefox-translations) and are not related to the native integration in Firefox.

## Prod
- Bulgarian <-> English
- Dutch <-> English
- French <-> English
- German <-> English
- Italian <-> English
- Polish <-> English
- Portuguese <-> English
- Spanish <-> English

## Dev
- Catalan -> English
- Czech <-> English
- Estonian <-> English
- Finnish -> English
- Greek -> English
- Hungarian <-> English
- Icelandic -> English
- Lithuanian -> English
- Maltese -> English
- Norwegian Bokmål -> English
- Norwegian Nynorsk -> English
- Persian (Farsi) <-> English
- Russian <-> English
- Slovenian -> English
- Turkish -> English
- Ukrainian <-> English




