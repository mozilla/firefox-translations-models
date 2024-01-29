#!/bin/bash
# Uploads the model files for a language pair to Remote Settings to release the model
# dev models are released to nightly only and prod models are released to all channels
#
# arguments:
#   model category (dev or prod)
#   language pair
#
# Example: bash release.sh dev elen
#
# Requires export REMOTE_SETTINGS_BEARER_TOKEN="Bearer ..."

set -x
set -euo pipefail

if [[ -z "${REMOTE_SETTINGS_BEARER_TOKEN:-}" ]]; then
    echo "Error: The REMOTE_SETTINGS_BEARER_TOKEN environment variable was not provided."
    exit 1
fi

dir=$1
pair=$2

if [ ${dir} == "prod" ]; then
  version=1.0
else
  version=1.0a1
fi

gzip -df  models/${dir}/${pair}/*.gz

for filepath in models/${dir}/${pair}/*; do
  poetry run python -m remote_settings create --path ${filepath} --server prod  --version ${version}
done
