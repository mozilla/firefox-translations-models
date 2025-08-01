"""
Type definitions for the translations data that is stored Remote Settings.

This file was copied from the following file:
https://github.com/mozilla/translations/blob/main/utils/common/remote_settings.py
"""

from pydantic import BaseModel, Field
from typing import Optional

prod_endpoint = "https://firefox.settings.services.mozilla.com"
models_collection = "translations-models-v2"
wasm_collection = "translations-wasm-v2"


def get_prod_records_url(collection: str):
    return f"{prod_endpoint}/v1/buckets/main/collections/{collection}/records"


class Attachment(BaseModel):
    """A Remote Settings attachment"""

    hash: str  # "724b358d399c6b23444de36d76e9e2630c7024c29d9e617323b820a11631535a"
    size: int  # 17141051
    filename: str  # "model.enel.intgemm.alphas.bin"
    location: str  # "main-workspace/translations-models/26dead91-e46c-442c-85d0-a6fe13fad55a.bin"
    mimetype: str  # "application/octet-stream"


class WasmRecord(BaseModel):
    """A Remote Settings WasmRecord"""

    name: str
    schema_name: Optional[int] = Field(default=None, alias="schema")
    license: str
    release: str
    version: str
    revision: str
    attachment: Optional[Attachment] = None
    fx_release: Optional[str] = None
    filter_expression: Optional[str] = None
    id: str
    last_modified: int


class WasmResponse(BaseModel):
    """The response from calling the Remote Settings records endpoint."""

    data: list[WasmRecord]


class ModelRecord(BaseModel):
    architecture: str  # "base"
    name: str  # "model.enel.intgemm.alphas.bin"
    schema_name: Optional[int] = Field(default=None, alias="schema")
    size: int  # 23
    variant: Optional[str] = None
    targetLanguage: str  # "en"
    sourceLanguage: str  # "el"
    version: str  # "1.0"
    fileType: str  # "model", "lex", "vocab"
    hash: str  # "f3888b9db780da4d681aaf987adfcd6ea54f82dd14ed2594b2b7ac7d253b6290"
    attachment: Optional[Attachment] = None
    filter_expression: Optional[
        str
    ] = None  # "env.channel == 'default' || env.channel == 'nightly'"
    id: str  # "136b1eae-9cef-4d03-a38f-74b0cb543b74"
    last_modified: int  # 1728419357986


class ModelsResponse(BaseModel):
    """The response from calling the Remote Settings records endpoint."""

    data: list[ModelRecord]
