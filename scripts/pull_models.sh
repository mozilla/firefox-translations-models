#!/bin/bash

# Downloads models from snakepit cluster

SRC=ru
TRG=en
EXPERIMENT=all_mtdata_and_opus2
ROOT_DIR="bergamot-training/models"

SNAKEPIT_DIR="${ROOT_DIR}/${SRC}-${TRG}/${EXPERIMENT}/exported"
LOCAL_DIR="../models/dev/${SRC}${TRG}"

rm -rf "${LOCAL_DIR}"
mkdir "${LOCAL_DIR}"

pit pull home "${SNAKEPIT_DIR}/lex.50.50.${SRC}${TRG}.s2t.bin.gz" "${LOCAL_DIR}"
pit pull home "${SNAKEPIT_DIR}/model.${SRC}${TRG}.intgemm.alphas.bin.gz" "${LOCAL_DIR}"
pit pull home "${SNAKEPIT_DIR}/vocab.${SRC}${TRG}.spm.gz" "${LOCAL_DIR}"