# Firefox Translations models
CPU-optimized NMT models for [Firefox Translations](https://github.com/mozilla-extensions/firefox-translations).

The model files are hosted using [Git LFS](https://docs.github.com/en/github/managing-large-files/versioning-large-files/about-git-large-file-storage).

[prod](models/prod) - production quality models 

[dev](models/dev) - test models under development (can be of low quality or speed). 

When a dev model has satisfactory quality, it is moved to prod.

# Automatic quality evaluation

[Results for prod models](evaluation/prod/results.md)

[Resutls for dev models](evaluation/dev/results.md)

Automatic evaluation is a part of pull request CI. 
It uses Microsoft and Google translation APIs and pushes results back to the branch (not available for forks).
It is performed using [firefox-translations-evaluation](https://github.com/mozilla/firefox-translations-evaluation) tool.

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

# Model deployment

Create a new release with a version tag `x.y.z` following semantic versioning.

The models will be automatically uploaded to GCS bucket `gs://bergamot-models-sandbox/x.y.z/`. 

# Currently supported Languages
## Prod
- Spanish <-> English
- Estonian <-> English
- English <-> German
- Czech <-> English
- Bulgarian <-> English
- Norwegian Bokmål -> English
- Portuguese -> English
- Italian -> English
## Dev
- Russian <-> English
- Portuguese <- English
- Italian <- English
- Persian (Farsi) <-> English
- Icelandic -> English
- Norwegian Nynorsk -> English
## Upcoming
-  French <-> English
-  Polish <-> English
