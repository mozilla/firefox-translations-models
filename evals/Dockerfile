FROM nvidia/cuda:11.4.3-runtime-ubuntu20.04

WORKDIR workspace

ARG DEBIAN_FRONTEND=noninteractive

RUN apt update && \
  apt -y install sudo git cmake

# See https://marian-nmt.github.io/docs/#installation for Marian requirements
RUN apt-get install -y build-essential \
    libboost-all-dev libprotobuf17 protobuf-compiler \
    libprotobuf-dev libssl-dev libgoogle-perftools-dev

# Intel MKL - for Marian usage on CPU
RUN apt install wget && \
    wget -qO- 'https://apt.repos.intel.com/intel-gpg-keys/GPG-PUB-KEY-INTEL-SW-PRODUCTS-2023.PUB' |  apt-key add -
RUN sh -c 'echo deb https://apt.repos.intel.com/mkl all main > /etc/apt/sources.list.d/intel-mkl.list' && \
    apt-get update && \
    apt-get install -y intel-mkl-64bit-2020.0-088

# Bergamot
# pcre2 is requried to build berrgamot-translator with -DUSE_WASM_COMPATIBLE_SOURCES=off
RUN apt-get install -y libpcre2-dev

# Compile bergamot translator
ADD ./install/install-bergamot-translator.sh ./
RUN bash ./install-bergamot-translator.sh

# SacreBLEU and python dependencies
RUN apt-get update && apt-get install -y python3 python3-venv python3-pip
ADD ./requirements.txt ./
RUN pip3 install -r requirements.txt

ADD ./eval ./eval
ADD ./translators ./translators
ADD ./data ./data

CMD ["/bin/bash"]
