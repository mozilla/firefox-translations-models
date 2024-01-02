#!/bin/bash

pair=$1
name=$2

mkdir -p models/dev/$pair
cd models/dev/$pair/

# aren hien
#wget -nc  https://object.pouta.csc.fi/hplt_bitextor_models/${name}.tar.gz && \
#tar -xvf ${name}.tar.gz
#mv lex.s2t.50.bin  lex.50.50.$pair.s2t.bin
#mv *.alphas.bin model.$pair.intgemm.alphas.bin
#mv *.spm vocab.$pair.spm

# or

# jaen vien
#wget https://object.pouta.csc.fi/hplt_bitextor_models/${name}.tiny.zip
#unzip -j *.zip
#mv lex.s2t.bin  lex.50.50.$pair.s2t.bin
#mv *.alphas.bin  model.$pair.intgemm.alphas.bin
#mv vocab.spm vocab.$pair.spm

# or

# swen glen
wget https://object.pouta.csc.fi/hplt_bitextor_models/${name}.zip
unzip -j *.zip
mv *.s2t.bin  lex.50.50.$pair.s2t.bin
mv *.alphas.bin  model.$pair.intgemm.alphas.bin
mv *.spm vocab.$pair.spm

# or

# zhen
#wget https://object.pouta.csc.fi/hplt_bitextor_models/${name}.zip
#unzip -j *.zip
#mv *.s2t.bin  lex.50.50.$pair.s2t.bin
#mv *.alphas.bin  model.$pair.intgemm.alphas.bin
#mv *.spm vocab.$pair.spm



find . -type f \
  -not -name "lex.50.50.$pair.s2t.bin" \
  -not -name "model.$pair.intgemm.alphas.bin" \
  -not -name "vocab.$pair.spm" \
   -delete

gzip *

