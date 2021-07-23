#!/bin/bash

set -e

bash firefox-translations-evaluation/install/install-bergamot-translator.sh

python3 firefox-translations-evaluation/eval/evaluate.py \
  --translators=bergamot,microsoft,google \
  --pairs=all --skip-existing \
  --results-dir=evaluation/dev --models-dir=models/dev

python3 firefox-translations-evaluation/eval/evaluate.py \
  --translators=bergamot,microsoft,google \
  --pairs=all --skip-existing \
  --results-dir=evaluation/prod --models-dir=models/prod