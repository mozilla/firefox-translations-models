#!/bin/bash


set -e
set -o pipefail

$TRANSLATOR_CMD < "$EVAL_PREFIX.$SRC" \
  | tee "$EVAL_PREFIX.$TRANSLATOR.$TRG" \
  | sacrebleu --score-only -q -l "$SRC-$TRG" "$EVAL_PREFIX.$TRG" \
  | tee "$EVAL_PREFIX.$TRANSLATOR.$TRG.bleu"


