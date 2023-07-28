#!/bin/bash

# example:
# bash scripts/import-statmt.sh isen isen isen.student.tiny11 dev

pair=$1
vocab_pair=$2
model=$3
folder=$4


mkdir -p models/$folder/$pair


# directory structure is not consistent on statmt
wget -nc -P models/$folder/$pair/ http://data.statmt.org/bergamot/models/$pair/$model/lex.s2t.bin
wget -nc -P models/$folder/$pair/ http://data.statmt.org/bergamot/models/$pair/$model/model.intgemm.alphas.bin
wget -nc -P models/$folder/$pair/ http://data.statmt.org/bergamot/models/$pair/$model/vocab.$vocab_pair.spm

# follow our naming convention
mv models/$folder/$pair/lex.s2t.bin models/$folder/$pair/lex.50.50.$pair.s2t.bin
mv models/$folder/$pair/model.intgemm.alphas.bin models/$folder/$pair/model.$pair.intgemm.alphas.bin

gzip models/$folder/$pair/*
