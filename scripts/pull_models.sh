#!/bin/bash
#
# Downloads exported models from Taskcluster artifacts
#
# Example:  SRC=lt TRG=en TASK_ID=SjPZGW9CRYeb9PQr68jCUw bash pull_models.sh
#

[[ -z "${SRC}" ]] && echo "SRC is empty"
[[ -z "${TRG}" ]] && echo "TRG is empty"
# Taskcluster "export-<src>-<trg>" task ID
[[ -z "${TASK_ID}" ]] && echo "TASK_ID is empty"

LOCAL_DIR="../models/dev/${SRC}${TRG}"
TC_PREFIX="https://firefox-ci-tc.services.mozilla.com/api/queue/v1/task"

rm -rf "${LOCAL_DIR}"
mkdir "${LOCAL_DIR}"

wget -O "${LOCAL_DIR}"/lex.50.50.${SRC}${TRG}.s2t.bin.gz \
  ${TC_PREFIX}/${TASK_ID}/runs/0/artifacts/public%2Fbuild%2Flex.50.50.${SRC}${TRG}.s2t.bin.gz
wget -O "${LOCAL_DIR}"/model.${SRC}${TRG}.intgemm.alphas.bin.gz \
  ${TC_PREFIX}/${TASK_ID}/runs/0/artifacts/public%2Fbuild%2Fmodel.${SRC}${TRG}.intgemm.alphas.bin.gz
wget -O "${LOCAL_DIR}"/vocab.${SRC}${TRG}.spm.gz \
 ${TC_PREFIX}/${TASK_ID}/runs/0/artifacts/public%2Fbuild%2Fvocab.${SRC}${TRG}.spm.gz

git add "${LOCAL_DIR}"/*

