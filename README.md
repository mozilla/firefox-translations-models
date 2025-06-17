# Firefox Translations models
CPU-optimized NMT models for Firefox Translations.

The model files are hosted using [Git LFS](https://docs.github.com/en/github/managing-large-files/versioning-large-files/about-git-large-file-storage).

The models are located in the [/models](/models) directory and grouped by available configuration:
- [tiny](https://github.com/mozilla/translations/blob/main/pipeline/train/configs/model/student.tiny.yml) - the fastest and the smallest models but with lower translation quality
- [base](https://github.com/mozilla/translations/blob/main/pipeline/train/configs/model/student.base.yml) - best quality but slower and larger
- [base-memory](https://github.com/mozilla/translations/blob/main/pipeline/train/configs/model/student.base-memory.yml) - slightly lower quality than `base` but also lower memory footprint

# Automatic quality evaluation

[BLEU scores](evaluation/bleu-results.md), [COMET scores](evaluation/comet-results.md)

The evaluation is run as part of a pull request in CI.
The evaluation will automatically run, and then commits will be added to the pull request.
The evaluation uses Microsoft and Google translation APIs, Argos Translate, NLLB and Opus-MT models and pushes results back to the branch (not available for forks).
It is performed using the [evals](/evals) tool.

# Model training

Use [Firefox Translations training pipeline](https://github.com/mozilla/translations) or [browsermt/students](https://github.com/browsermt/students/tree/master/train-student) recipe to train CPU-optimized models. They should have similar size and inference speed to already submitted models.

## Training data

Do not use [SacreBLEU](https://github.com/mjpost/sacrebleu) or [Flores](https://github.com/facebookresearch/flores) datasets as a part of training data, otherwise evaluation will not be correct.

To see SacreBLEU datasets run `sacrebleu --list`.

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

# Add a model from Taskcluster

1. Run `python scripts/pull_models.py [TASK_ID]` where `[TASK_ID] is a Taskcluster ID of the `export` task such as `SjPZGW9CRYeb9PQr68jCUw`.
2. Commit the changes, which adds the files and removes any previous evaluations.
3. Push the changes to `origin` and open a PR.
4. Wait for the CI to run the evaluations and add the commits.
5. Merge the PR.

# Model deployment

Models are deployed to Remote Settings to be delivered to Firefox.

Records and attachments are uploaded via a CLI tool which lives in the
`remote_settings` directory in this repository.

View the `remote_settings` [README](https://github.com/mozilla/firefox-translations-models/blob/main/remote_settings/README.md) for more details on publishing models.

# Currently supported Languages

## Firefox Release
- Arabic <-> English
- Bulgarian <-> English
- Catalan <-> English
- Chinese (Simplified) <-> English
- Croatian -> English
- Czech <-> English
- Danish <-> English
- Dutch <-> English
- Estonian <-> English
- Finnish <-> English
- French <-> English
- German <-> English
- Greek <-> English
- Hungarian <-> English
- Indonesian <-> English
- Italian <-> English
- Japanese <-> English
- Korean <-> English
- Latvian (Lettish) <-> English
- Lithuanian <-> English
- Polish <-> English
- Portuguese <-> English
- Romanian <-> English
- Russian <-> English
- Serbian -> English
- Slovak <-> English
- Slovenian <-> English
- Spanish <-> English
- Swedish <-> English
- Turkish <-> English
- Ukrainian <-> English
- Vietnamese -> English

## Firefox Nightly
- Albanian -> English
- Azerbaijani -> English
- Belarusian -> English
- Bengali -> English
- Bosnian -> English
- Croatian <- English
- Gujarati -> English
- Hebrew -> English
- Hindi -> English
- Hungarian <- English
- Icelandic -> English
- Kannada -> English
- Latvian (Lettish) <- English
- Lithuanian <- English
- Malay -> English
- Malayalam -> English
- Maltese -> English
- Norwegian Bokmål -> English
- Norwegian Nynorsk -> English
- Persian (Farsi) <-> English
- Slovak <- English
- Tamil -> English
- Telugu -> English
