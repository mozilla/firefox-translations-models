#!/bin/bash

pair=$1

mkdir -p models/prod/$pair

# directory structure is not consistent on statmt
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/fren/$pair/tiny11/lex.s2t.bin
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/fren/$pair/tiny11/model.intgemm.alphas.bin
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/fren/$pair/tiny11/vocab.fren.spm

# follow our naming convention
mv models/prod/$pair/lex.s2t.bin models/prod/$pair/lex.50.50.$pair.s2t.bin
mv models/prod/$pair/model.intgemm.alphas.bin models/prod/$pair/model.$pair.intgemm.alphas.bin

gzip models/prod/$pair/*
