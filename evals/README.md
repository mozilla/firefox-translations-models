# Firefox Translations Evaluation
Calculates BLEU and COMET scores for Firefox Translations [models](https://github.com/mozilla/firefox-translations-models)
using [bergamot-translator](https://github.com/mozilla/bergamot-translator) and compares them to other translation systems.

## Running

We recommend running this on a Linux machine with at least one GPU, and inside a docker container. 
If you intend to run it on macOS, run the `eval/evaluate.py ` script standalone inside a virtualenv, and skip the `Start docker` section below. 
You might need to manually install the correspondent packages in the `Dockerfile` in your system and virtual environment.

### Install NVIDIA Container Toolkit

https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html

### Start docker
Recommended memory size for Docker is **16gb**.

Run from the repo root directory:
```
export MODELS=<absolute path to a local directory with models>

# Specify Azure key and location if you want to add Azure Translator API for comparison
export AZURE_TRANSLATOR_KEY=<Azure translator resource API key>
# optional, specify if it's different than default 'global'
export AZURE_LOCATION=<location>

# Specify GCP credentials json path if you want to add Google Translator API for comparison
export GCP_CREDS_PATH=<absolute path to .json>

# Build and run docker container
make build-docker
make start-docker
```

On completion, your terminal should be attached to the launched container.

### Run evaluation
From inside docker container run:
```
python3 eval/evaluate.py \
    --translators=bergamot,microsoft,google \
    --pairs=all \
    --skip-existing \
    --gpus=1 \
    --evaluation-engine=comet,bleu \
    --models-dir=/models/models/tiny \
    --results-dir=/models/evaluation
```

If you don't have a GPU, use `0` in the `--gpus` argument.

More options:
```
python3 eval/evaluate.py --help
```

## Details
### Installation scripts
`install/install-bergamot-translator.sh` - clones and compiles [bergamot-translator](https://github.com/mozilla/bergamot-translator) and [marian](https://github.com/marian-nmt/marian-dev) (launched in docker image).

`install/download-models.sh` - downloads current Mozilla production [models](https://github.com/mozilla/firefox-translations-models).

### Docker & CUDA
The COMET evaluation framework supports CUDA, and you can enable it by setting the `--gpus` argument in the `eval\evaluate.py` script to the number of GPUs you wish to utilize (`0` disables it).
If you are using it, make sure you have the [nvidia container toolkit enabled](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/install-guide.html#docker) in your docker setup.

### Translators
1. **bergamot** - uses compiled [bergamot-translator](https://github.com/mozilla/bergamot-translator) in wasm mode
2. **google** - users Google Translation [API](https://cloud.google.com/translate)
3. **microsoft** - users Azure Cognitive Services Translator [API](https://azure.microsoft.com/en-us/services/cognitive-services/translator/)

### Reuse already calculated scores
Use `--skip-existing` option to reuse already calculated scores saved as `results/xx-xx/*.bleu` files.
It is useful to continue evaluation if it was interrupted
or to rebuild a full report reevaluating only selected translators.

### Datasets
[SacreBLEU](https://github.com/mjpost/sacrebleu) - all available datasets for a language pair are used for evaluation.

[Flores](https://github.com/facebookresearch/flores) - parallel evaluation dataset for 101 languages.

### Language pairs
With option `--pairs=all`, language pairs will be discovered
in the specified models folder (option `--models-dir`)
and evaluation will run for all of them.

### Results
Results will be written to the specified directory (option `--results-dir`).
