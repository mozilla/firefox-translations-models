#!/bin/bash

set -e

echo "Extracting models"
gzip -drf models/*/*/*

echo "Cloning evaluation repo"
if [ ! -e firefox-translations-evaluation ]; then
  git clone https://github.com/mozilla/firefox-translations-evaluation.git
fi

echo "Building docker image"
cd firefox-translations-evaluation
docker build -t bergamot-eval .
cd ..

echo "Running evaluation"
GCP_CREDS_PATH="/tmp/.gcp_creds"
# to run locally set AZURE_TRANSLATOR_KEY and GCLOUD_TRANSLATOR_KEY
echo "${GCLOUD_TRANSLATOR_KEY}" > ${GCP_CREDS_PATH}

docker run --name bergamot-eval -it --rm \
      -v "$(pwd)":/workspace \
      -v $GCP_CREDS_PATH:/.gcp_creds \
      -e GOOGLE_APPLICATION_CREDENTIALS=/.gcp_creds \
      -e AZURE_TRANSLATOR_KEY="${AZURE_TRANSLATOR_KEY}" \
      bergamot-eval bash evaluation/eval.sh




