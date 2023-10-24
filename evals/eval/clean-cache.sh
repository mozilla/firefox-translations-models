#!/bin/bash

set -e

# clean SacreBLEU cache to fix error
# "This could be a problem with your system output or with sacreBLEU's reference database"
test -e /root/.sacrebleu && rm -r /root/.sacrebleu
