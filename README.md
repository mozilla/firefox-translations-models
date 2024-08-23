# Firefox Translations models
CPU-optimized NMT models for Firefox Translations.

The model files are hosted using [Git LFS](https://docs.github.com/en/github/managing-large-files/versioning-large-files/about-git-large-file-storage).

[prod](models/prod) - higher quality models 

[dev](models/dev) - test models under development (can be of low quality or speed). 

When a dev model has satisfactory quality, it is moved to prod.

# Automatic quality evaluation

[BLEU scores](evaluation/bleu-results.md), [COMET scores](evaluation/comet-results.md)

The evaluation is run as part of a pull request in CI.
The PR should include the models in the `models/dev` or `models/prod` category.
The evaluation will automatically run, and then commits will be added to the pull request.
The evaluation uses Microsoft and Google translation APIs, Argos Translate, NLLB and Opus-MT models and pushes results back to the branch (not available for forks).
It is performed using the [evals](/evals) tool.

# Model training

Use [Firefox Translations training pipeline](https://github.com/mozilla/firefox-translations-training) or [browsermt/students](https://github.com/browsermt/students/tree/master/train-student) recipe to train CPU-optimized models. They should have similar size and inference speed to already submitted models.

## Training data

Do not use [SacreBLEU](https://github.com/mjpost/sacrebleu) or [Flores](https://github.com/facebookresearch/flores) datasets as a part of training data, otherwise evaluation will not be correct.

To see SacreBLEU datasets run `sacrebleu --list`.

# Model contribution

All models should be contributed to `dev` folder first.

## Maintainers adding models

Create a pull request to the `main` branch from another branch in this repo (not a fork).
This pull request should include the models, and the evaluation will be added as extra commits in the CI task.

## Contributors adding models

Create a pull request to the `contrib` branch.
When it is reviewed and merged, a maintainer should create a pull request from `contrib` to `main`.
This second PR will run the automatic evaluation and add the evaluation commits.

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

# Downloading a model from Taskcluster

Example:
```
cd scripts
SRC=lt TRG=en TASK_ID=SjPZGW9CRYeb9PQr68jCUw bash pull_models.sh
```
Where `TASK_ID` is a Taskcluster ID of the `export` task.

# Model deployment

Models are deployed to Remote Settings to be delivered to Firefox.

Records and attachments are uploaded via a CLI tool which lives in the
`remote_settings` directory in this repository.

View the `remote_settings` [README](https://github.com/mozilla/firefox-translations-models/blob/main/remote_settings/README.md) for more details on publishing models.

# Currently supported Languages

Prod models are available in all Firefox channels including Release. 
Dev models are available in Nightly only.

## Prod
- Bulgarian <-> English
- Catalan <-> English
- Croatian -> English
- Czech -> English
- Danish <-> English
- Dutch <-> English
- Estonian <-> English
- Finnish <-> English
- French <-> English
- German <-> English
- Greek -> English
- Hungarian <-> English
- Indonesian -> English
- Italian <-> English
- Latvian (Lettish) -> English
- Lithuanian -> English
- Polish <-> English
- Portuguese <-> English
- Romanian -> English
- Russian -> English
- Serbian -> English
- Slovak -> English
- Slovenian <-> English
- Spanish <-> English
- Turkish <-> English
- Ukrainian -> English
- Vietnamese -> English

## Dev
- Bosnian -> English
- Croatian <- English
- Czech <- English
- Icelandic -> English
- Latvian (Lettish) <- English
- Maltese -> English
- Norwegian Bokmål -> English
- Norwegian Nynorsk -> English
- Persian (Farsi) <-> English
- Russian <- English
- Slovak <- English
- Ukrainian <- English
