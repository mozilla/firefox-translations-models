#!/bin/bash

set -e

python3 eval/evaluate.py \
  --translators=bergamot,microsoft,google \
  --pairs=all --skip-existing \
  --results-dir=/models/evaluation --models-dir=/models/models/tiny \
  --gpus=1 --evaluation-engine=comet,bleu

python3 eval/evaluate.py \
  --translators=bergamot,microsoft,google \
  --pairs=all --skip-existing \
  --results-dir=/models/evaluation --models-dir=/models/models/base \
  --gpus=1 --evaluation-engine=comet,bleu


python3 eval/evaluate.py \
  --translators=bergamot,microsoft,google \
  --pairs=all --skip-existing \
  --results-dir=/models/evaluation --models-dir=/models/models/base-memory \
  --gpus=1 --evaluation-engine=comet,bleu
