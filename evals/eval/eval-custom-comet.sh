#!/bin/bash


set -e
set -o pipefail

$TRANSLATOR_CMD < "$EVAL_PREFIX.$SRC" \
  | tee "$EVAL_PREFIX.$TRANSLATOR.$TRG" \
  ; comet-score --quiet --only_system --gpus "$GPUS" -s "$EVAL_PREFIX.$SRC" -t "$EVAL_PREFIX.$TRANSLATOR.$TRG" -r "$EVAL_PREFIX.$TRG" \
  | awk -F"score: " '{print $2}' \
  | tee "$EVAL_PREFIX.$TRANSLATOR.$TRG.comet"
