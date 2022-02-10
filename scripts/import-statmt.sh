#!/bin/bash

pair=$1

mkdir -P models/prod/$pair

# directory structure is not consistent on statmt
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/$pair/$pair.student.tiny11/lex.s2t.bin
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/$pair/$pair.student.tiny11/model.intgemm.alphas.bin
#wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/$pair/$pair.student.tiny11/vocab.$pair.spm
wget -nc -P models/prod/$pair/ http://data.statmt.org/bergamot/models/$pair/vocab.nben.spm

# follow our naming convention
mv models/prod/$pair/lex.s2t.bin models/prod/$pair/lex.50.50.$pair.s2t.bin
mv models/prod/$pair/model.intgemm.alphas.bin models/prod/$pair/model.$pair.intgemm.alphas.bin

gzip models/prod/$pair/*
