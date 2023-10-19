#!/bin/bash

# Downloads and compiles Bergamot translator and Marian
# See https://marian-nmt.github.io/docs/#installation for requirements

set -e

if [ -e "bergamot-translator" ]; then
    echo "already cloned"
else
    echo "Cloning https://github.com/mozilla/bergamot-translator.git"
    git clone https://github.com/mozilla/bergamot-translator.git
fi

cd bergamot-translator

echo "Compiling bergamot-translator"
mkdir -p build
cd build
cmake ../ -DUSE_WASM_COMPATIBLE_SOURCES=off -DCMAKE_BUILD_TYPE=Release
make -j$(nproc)
