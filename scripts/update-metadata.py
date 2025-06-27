"""
Scrapes all of the available information to build the metadata.json file for the model.

e.g.

{
  "architecture": "base",
  "byteSize": 42992955,
  "config": { ... },
  "hash": "f3888b9db780da4d681aaf987adfcd6ea54f82dd14ed2594b2b7ac7d253b6290",
  "modelStatistics": { ... },
  "sourceLanguage": "ar",
  "targetLanguage": "en",
  "version": "2.0"
}

It also builds the models/by-hash.json file where a model can be looked up by its hash.
"""

import logging
from pathlib import Path
from typing import Any, TypedDict
from typing import Dict, Tuple, Union, List
import argparse
import gzip
import hashlib
import json
import numpy as np
import struct
import yaml

ROOT_DIR = (Path(__file__).parent / "..").resolve()

logger = logging.getLogger("update-metadata")
logging.basicConfig(level=logging.INFO, format="[%(name)s] %(message)s")


class ModelStatistics(TypedDict):
    decoder_bytes: int
    decoder_parameters: int
    embeddings_bytes: int
    encoder_bytes: int
    encoder_parameters: int
    parameters: int


class Metadata(TypedDict):
    # For instance "base-memory" or "tiny"
    architecture: str
    # The size of the uncompressed model in bytes.
    byteSize: int
    # The flores scores, e.g. { "bleu": 39.6, "comet": 0.8649 }
    flores: dict[str, float]
    # The sha256 hash of the uncompressed model.
    hash: str
    # The Marian config for the model.
    modelConfig: dict[str, Any]
    # The number of parameters and bytes for the model's size.
    modelStatistics: ModelStatistics
    sourceLanguage: str
    targetLanguage: str
    # The version in Remote Settings, used to select the latest model.
    version: str


class BrowserMTBinaryParser:
    """
    Parse the browsermt/marian binary format, which is unique from the upstream Marian
    format.
    """

    def __init__(self, data: bytes):
        self._data = data
        self._parsed: Dict[str, Tuple[str, List[int], np.ndarray]] = {}

    def parse(self) -> Dict[str, Tuple[str, List[int], np.ndarray]]:
        if self._parsed:
            return self._parsed

        SIGNED = 0x0100
        UNSIGNED = 0x0200
        FLOAT = 0x0400
        PACKED = 0x0800
        AVX2 = 0x1000
        AVX512 = 0x2000
        INTGEMM = 0x4000

        type_table: Dict[int, Tuple[str, np.dtype]] = {
            SIGNED + 1: ("int8", np.int8),
            SIGNED + 2: ("int16", np.int16),
            SIGNED + 4: ("int32", np.int32),
            SIGNED + 8: ("int64", np.int64),
            UNSIGNED + 1: ("uint8", np.uint8),
            UNSIGNED + 2: ("uint16", np.uint16),
            UNSIGNED + 4: ("uint32", np.uint32),
            UNSIGNED + 8: ("uint64", np.uint64),
            FLOAT + 2: ("float16", np.uint8),
            FLOAT + 4: ("float32", np.float32),
            FLOAT + 8: ("float64", np.float64),
            PACKED + 2: ("packed16", np.uint16),
            PACKED + 1 + AVX2: ("packed8avx2", np.uint8),
            PACKED + 1 + AVX512: ("packed8avx512", np.uint8),
            SIGNED + 1 + INTGEMM: ("intgemm8", np.uint8),
            SIGNED + 2 + INTGEMM: ("intgemm16", np.uint16),
        }

        offset = 0
        version, offset = self._read_uint64(offset)
        if version != 1:
            raise ValueError(f"Unsupported version: {version:x}")

        header_count, offset = self._read_uint64(offset)
        headers = []
        for _ in range(header_count):
            name_size, offset = self._read_uint64(offset)
            type_id, offset = self._read_uint64(offset)
            shape_size, offset = self._read_uint64(offset)
            byte_size, offset = self._read_uint64(offset)
            headers.append(
                {
                    "name_size": name_size,
                    "type_id": type_id,
                    "shape_size": shape_size,
                    "byte_size": byte_size,
                    "name": "",
                    "shape": [],
                }
            )

        for header in headers:
            header["name"], offset = self._read_string(offset, header["name_size"])

        for header in headers:
            for _ in range(header["shape_size"]):
                dim, offset = self._read_int32(offset)
                header["shape"].append(dim)

        offset = self._align_to(offset, 256)

        result = {}
        for header in headers:
            type_id = header["type_id"]
            if type_id not in type_table:
                raise ValueError(f"Unknown BrowserMT type ID: 0x{type_id:x}")

            dtype_name, np_type = type_table[type_id]
            shape = header["shape"]
            count = np.prod(shape)

            if dtype_name == "float16":
                count *= 2

            arr = np.frombuffer(self._data, dtype=np_type, count=count, offset=offset)
            offset += header["byte_size"]
            result[header["name"]] = (dtype_name, shape, arr.reshape(shape))

        self._parsed = result
        return result

    def get_yaml_config_string(self) -> Union[str, None]:
        tensors = self.parse()
        entry = tensors.get("special:model.yml") or tensors.get("special:model.yml.npy")
        if entry is None:
            return None

        _, _, arr = entry
        text = arr.tobytes().decode("utf-8", errors="ignore")
        return text.rstrip("\x00")

    def get_yaml_config(self) -> Union[dict, None]:
        text = self.get_yaml_config_string()
        if text is None:
            return None
        return yaml.safe_load(text)

    def get_model_statistics(self) -> Dict[str, Union[int, Dict[str, int]]]:
        tensors = self.parse()

        total_params = 0
        encoder_params = 0
        decoder_params = 0
        encoder_bytes = 0
        decoder_bytes = 0
        embedding_bytes = 0

        type_size = {
            "int8": 1,
            "uint8": 1,
            "int16": 2,
            "uint16": 2,
            "int32": 4,
            "uint32": 4,
            "int64": 8,
            "uint64": 8,
            "float16": 2,
            "float32": 4,
            "float64": 8,
            "packed16": 2,
            "packed8avx2": 1,
            "packed8avx512": 1,
            "intgemm8": 1,
            "intgemm16": 2,
        }

        for name, (dtype, shape, _array) in tensors.items():
            if name.startswith("special:"):
                continue

            param_count = np.prod(shape)
            total_params += param_count
            dtype_size = type_size.get(dtype)
            if dtype_size is None:
                raise ValueError(f"Unknown dtype size for: {dtype}")

            byte_size = param_count * dtype_size

            if name.startswith("encoder_"):
                encoder_params += param_count
                encoder_bytes += byte_size
            elif name.startswith("decoder_"):
                decoder_params += param_count
                decoder_bytes += byte_size
            elif name == "Wemb":
                embedding_bytes += byte_size

        return {
            "parameters": int(total_params),
            "encoder_parameters": int(encoder_params),
            "decoder_parameters": int(decoder_params),
            "encoder_bytes": int(encoder_bytes),
            "decoder_bytes": int(decoder_bytes),
            "embeddings_bytes": int(embedding_bytes),
        }

    def _read_uint64(self, offset: int) -> Tuple[int, int]:
        val = struct.unpack_from("<Q", self._data, offset)[0]
        return val, offset + 8

    def _read_int32(self, offset: int) -> Tuple[int, int]:
        val = struct.unpack_from("<i", self._data, offset)[0]
        return val, offset + 4

    def _read_string(self, offset: int, size: int) -> Tuple[str, int]:
        raw = self._data[offset : offset + size - 1]
        return raw.decode("utf-8"), offset + size

    def _align_to(self, offset: int, alignment: int) -> int:
        return offset + ((alignment - (offset % alignment)) % alignment)


def compute_model_hash(file_path: Path, chunk_size: int = 8192) -> str:
    hasher = hashlib.sha256()
    with gzip.open(file_path, "rb") as f:
        for chunk in iter(lambda: f.read(chunk_size), b""):
            hasher.update(chunk)
    return hasher.hexdigest()


def get_uncompressed_size_gz(filepath: Path) -> int:
    """
    Decompresses the .gz file and returns the total uncompressed size in bytes.

    Args:
        filepath: Path to the .gz file.
        chunk_size: Number of bytes to read at a time from the decompressed stream.

    Returns:
        Total uncompressed size in bytes.
    """
    total_size = 0
    with gzip.open(filepath, "rb") as f:
        while chunk := f.read(8192):
            total_size += len(chunk)
    return total_size


def update_model_metadata():
    """
    Write out all of the pertinent information about a model to the metadata.json file.
    This file can be used to look up information about a model.
    """
    with (ROOT_DIR / "evaluation/comet-results.json").open() as f:
        comet_results = json.load(f)
    with (ROOT_DIR / "evaluation/bleu-results.json").open() as f:
        bleu_results = json.load(f)

    for model_file in (ROOT_DIR / "models").rglob("*.intgemm.alphas.bin.gz"):
        logger.info(f"Visiting model {model_file.name}")
        model_dir = model_file.parent
        metadata_json = model_dir / "metadata.json"

        needs_saving: bool = False

        if metadata_json.exists():
            metadata: Metadata = json.load(metadata_json.open())
        else:
            needs_saving = True
            metadata = {"sourceLanguage": model_dir.name[:2], "targetLanguage": model_dir.name[2:]}

        src = metadata["sourceLanguage"]
        trg = metadata["targetLanguage"]

        architecture = metadata.get("architecture")

        if not architecture:
            needs_saving = True
            architecture = metadata_json.parent.parent.name
            metadata["architecture"] = metadata_json.parent.parent.name

        if not metadata.get("byteSize"):
            needs_saving = True
            metadata["byteSize"] = get_uncompressed_size_gz(model_file)

        if not metadata.get("hash"):
            needs_saving = True
            metadata["hash"] = compute_model_hash(model_file)

        def get_parser():
            with gzip.open(model_file, "rb") as f:
                model_data = f.read()
                logger.info(f" - Parsing {model_file}")
                parser = BrowserMTBinaryParser(model_data)
                return parser

        if not metadata.get("modelConfig"):
            metadata["modelConfig"] = get_parser().get_yaml_config()
            needs_saving = True

        if not metadata.get("modelStatistics"):
            metadata["modelStatistics"] = get_parser().get_model_statistics()
            needs_saving = True

        if not metadata.get("flores"):
            results_key = f"bergamot-{architecture}"
            metadata["flores"] = {
                "comet": comet_results.get(f"{src}-{trg}", {})
                .get("flores-dev", {})
                .get(results_key),
                "bleu": bleu_results.get(f"{src}-{trg}", {})
                .get("flores-dev", {})
                .get(results_key),
            }
            needs_saving = True

        if needs_saving:
            logger.info(f" - Saving modified json: {metadata_json}")
            with metadata_json.open("w") as outfile:
                json.dump(metadata, outfile, indent=2, sort_keys=True)
                outfile.write("\n")


def create_models_by_hash() -> None:
    """
    Creates a mapping from a hash of the model to the metadata.json. Remote Settings contains
    the hash information in the attachments, so it allows for looking information about
    a specific model.
    """
    models_dir = ROOT_DIR / "models"
    by_hash_json = models_dir / "by-hash.json"

    # A map of the hash to the path to the data.json file.
    models_by_hash: dict[str, str] = {}
    for data_json in models_dir.rglob("**/*/metadata.json"):
        with data_json.open() as file:
            hash = json.load(file)["hash"]
            models_by_hash[hash] = str(data_json.relative_to(ROOT_DIR))

    logger.info(f"Writing out {by_hash_json}")
    with by_hash_json.open("w") as outfile:
        json.dump(models_by_hash, outfile, indent=2)


def main() -> None:
    parser = argparse.ArgumentParser(
        description=__doc__,
        # Preserves whitespace in the help text.
        formatter_class=argparse.RawTextHelpFormatter,
    )
    # Just provide --help documentation for running the script.
    parser.parse_args()

    update_model_metadata()
    create_models_by_hash()


if __name__ == "__main__":
    main()
