#!/bin/bash
##
# Downloads flores dataset
#

set -x
set -euo pipefail

dir=$1

mkdir -p "${dir}"

test -s "${dir}/flores101_dataset.tar.gz" ||
  wget -O "${dir}/flores101_dataset.tar.gz" "https://dl.fbaipublicfiles.com/flores101/dataset/flores101_dataset.tar.gz"

test -s "${dir}/flores101_dataset/dev/eng.dev" ||
 tar -xzf "${dir}/flores101_dataset.tar.gz" -C "${dir}" --no-same-owner

