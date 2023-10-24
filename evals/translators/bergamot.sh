#!/bin/bash

set -x
set -euo pipefail

SRCVOCAB=$(find "${MODEL_DIR}" -name srcvocab.*.spm)
TRGVOCAB=$(find "${MODEL_DIR}" -name trgvocab.*.spm)
VOCAB=$(find "${MODEL_DIR}" -name vocab.*.spm)
MODEL=$(find "${MODEL_DIR}" -name model.${SRC}${TRG}.*.bin)
SHORTLIST=$(find "${MODEL_DIR}" -name *${SRC}${TRG}.s2t.bin)
CONFIG="/tmp/bergamot.config.${SRC}${TRG}.yml"

if [[ ${MODEL} == *.intgemm.alphas.bin ]]; then
  PRECISION=int8shiftAlphaAll
elif [[ ${MODEL} == *.intgemm8.bin ]]; then
  PRECISION=int8shiftAll
else
  echo "Unknown model name pattern: ${MODEL}"
  exit 1
fi

cp translators/bergamot.config.yml "${CONFIG}"
sed -i -e "s+MODEL+${MODEL}+g" "${CONFIG}"
sed -i -e "s+SRCVOCAB+${SRCVOCAB:-$VOCAB}+g" "${CONFIG}"
sed -i -e "s+TRGVOCAB+${TRGVOCAB:-$VOCAB}+g" "${CONFIG}"
sed -i -e "s+SHORTLIST+${SHORTLIST}+g" "${CONFIG}"
sed -i -e "s+PRECISION+${PRECISION}+g" "${CONFIG}"

$APP_PATH --model-config-paths "${CONFIG}" --log-level=info
