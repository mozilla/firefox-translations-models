"""
Runs a local copy of RemoteSettings within a docker container.

The RemoteSettings instance is served on http://localhost:8888/v1


This file was copied from the following file:
https://github.com/mozilla/translations/blob/main/utils/local_remote_settings/__main__.py

Usage:

- Fetch the production WASM into the local mirror
  task local-remote-settings -- --fetch-wasm
"""

import os
import re
import gzip
import sys
import time
import json
import yaml
import shutil
import logging
import argparse
import requests
import threading
import subprocess
from uuid import uuid4
from pathlib import Path
from kinto_http import Client
from typing import IO, Callable, Optional, Type, Union
from ...common import (
    ModelRecord,
    ModelsResponse,
    WasmResponse,
    WasmRecord,
    models_collection,
    wasm_collection,
    get_prod_records_url,
)

logger = logging.getLogger("util")
logger.setLevel(logging.INFO)

docker_logger = logging.getLogger("docker")
docker_logger.setLevel(logging.INFO)

mount_path = Path(__file__).parent / "mount"
data_path = (Path(__file__).parent / "../../data").resolve()

attachments_path = data_path / "remote-settings/attachments"
attachments_path.mkdir(parents=True, exist_ok=True)

models_path = data_path / "remote-settings/models"
models_path.mkdir(parents=True, exist_ok=True)

bucket = "main"


def sync_records(
    remote_settings: Client,
    collection: str,
    record_response_class: Union[Type[WasmResponse], Type[ModelsResponse]],
    record_class: Union[Type[WasmRecord], Type[ModelRecord]],
):
    """
    Sync records from the production Remote Settings with a local version of it.
    """
    logger.info(f'Syncing records for "{collection}"')
    url = get_prod_records_url(collection)
    response = requests.get(url)
    response.raise_for_status()
    records_response = record_response_class(**response.json())
    new_records = {data.id: data for data in records_response.data}
    existing_records = [
        record_class(**data)
        for data in remote_settings.get_records(bucket=bucket, collection=collection)
    ]
    for record in existing_records:
        id = record.id
        if new_records.get(id):
            logger.info(f"Record exists {record.name} {record.version}")
            # The new record already exists.
            del new_records[id]
        else:
            logger.info(f"Removing outdated record {record.name} {record.version}")
            remote_settings.delete_record(id=id, collection=collection, bucket=bucket)

    for record in new_records.values():
        logger.info(f"Creating record {record.name} {record.version}")

        attachment = record.attachment
        assert attachment

        if ".." in attachment.location:
            raise Exception(f"Attachment location changes directory {attachment.location}")

        record_name = Path(record.name)
        cache_dir = attachments_path / f"sync-{collection}"
        cache_dir.mkdir(exist_ok=True)
        attachment_file_path = (
            cache_dir / f"{record_name.stem}-v{record.version}{record_name.suffix}"
        )
        if attachment_file_path.exists():
            logger.info(f"✅ {attachment_file_path}")
        else:
            download_url = (
                f"https://firefox-settings-attachments.cdn.mozilla.net/{attachment.location}"
            )
            with attachment_file_path.open("wb") as attachment_file:
                try:
                    logger.info(
                        f"⬇️ Downloading {record.name} {record.version} from {download_url}"
                    )
                    response = requests.get(download_url, stream=True, allow_redirects=True)
                    response.raise_for_status()
                    for chunk in response.iter_content(chunk_size=8192):
                        attachment_file.write(chunk)
                except Exception as e:
                    logger.info(
                        f"Error occurred while downloading attachment {record.name} {record.version}: {e}"
                    )

        record_data = json.loads(record.json())
        del record_data["attachment"]

        create_record_with_attachment(
            record.id,
            collection,
            attachment.mimetype,
            attachment_file_path,
            record_data,
        )

        logger.info(f"Attachment downloaded and added {record.name} {record.version}")


def create_record_with_attachment(
    record_id: str,
    collection: str,
    mime_type: str,
    attachment_path: Path,
    record_data: dict,
) -> None:
    url = f"http://localhost:8888/buckets/{bucket}/collections/{collection}/records/{record_id}/attachment"

    logger.info(f"Posting record to {url}")
    with open(attachment_path, "rb") as attachment:
        files = {"attachment": (attachment_path.name, attachment, mime_type)}
        form_data = {"data": json.dumps(record_data)}
        response: Optional[requests.Response] = None
        exception: Optional[Exception] = None
        for _ in range(10):
            exception = None
            response = None
            try:
                response = requests.post(url, files=files, data=form_data)
                if response.ok:
                    return
            except Exception as e:
                logger.warning(f"An exception occurred while creating a record: {e}")
                exception = e

            if response:
                logger.warning(f"Response was not ok, code: {response.status_code}")

        if response:
            response.raise_for_status()
        elif exception:
            raise exception


def create_remote_settings_environment(remote_settings: Client):
    logger.info("Ensuring the buckets and collections are created")
    remote_settings.create_bucket(id=bucket, if_not_exists=True)

    # Load and apply schema + displayFields for the WASM collection
    wasm_schema_path = Path(__file__).parent / "schema" / "wasm_schema.json"
    try:
        with wasm_schema_path.open("r") as f:
            wasm_schema = json.load(f)
        logger.info(f"Loaded WASM schema from {wasm_schema_path}")
    except Exception as e:
        logger.error(f"Failed to load WASM schema from {wasm_schema_path}: {e}")
        raise

    wasm_display_fields = [
        "name",
        "release",
        "revision",
        "license",
        "filter_expression",
    ]

    remote_settings.create_collection(
        id=wasm_collection,
        bucket=bucket,
        if_not_exists=True,
        data={
            "schema": wasm_schema,
            "displayFields": wasm_display_fields,
        },
    )

    # Load and apply schema + displayFields for the models collection
    models_schema_path = Path(__file__).parent / "schema" / "models_schema.json"
    try:
        with models_schema_path.open("r") as f:
            models_schema = json.load(f)
        logger.info(f"Loaded models schema from {models_schema_path}")
    except Exception as e:
        logger.error(f"Failed to load models schema from {models_schema_path}: {e}")
        raise

    models_display_fields = [
        "name",
        "sourceLanguage",
        "targetLanguage",
        "fileType",
        "version",
        "architecture",
        "size",
        "hash",
        "filter_expression",
    ]

    remote_settings.create_collection(
        id=models_collection,
        bucket=bucket,
        if_not_exists=True,
        data={
            "schema": models_schema,
            "displayFields": models_display_fields,
        },
    )


class DockerContainerManager:
    def __init__(
        self,
        container_name: str,
        image: str,
        volumes: dict[str, str],
        env_vars: dict[str, str],
        ports: dict[int, int],
    ):
        self.container_name = container_name
        self.image = image
        self.volumes = volumes
        self.env_vars = env_vars
        self.ports = ports
        self.process = None

    def _build_docker_command(self):
        uid = os.getuid()
        gid = os.getgid()

        cmd = ["docker", "run", "--rm", "--user", f"{uid}:{gid}", "--name", self.container_name]

        for host_path, container_path in self.volumes.items():
            cmd += ["--volume", f"{host_path}:{container_path}"]

        for key, value in self.env_vars.items():
            cmd += ["--env", f"{key}={value}"]

        for host_port, container_port in self.ports.items():
            cmd += ["--publish", f"{host_port}:{container_port}"]

        cmd += [self.image]

        return cmd

    def stream_output(self, stream: IO[str], log: Callable):
        def stream_reader():
            try:
                for line in iter(stream.readline, ""):
                    log(f"{line.strip()}")
            except Exception as e:
                log(f"Error reading from stream: {e}")
            finally:
                stream.close()

        thread = threading.Thread(target=stream_reader, daemon=True)
        thread.start()

    def stop_and_remove_docker(self):
        logger.info("Stopping translations-remote-settings.")
        subprocess.run(["docker", "stop", self.container_name], check=False)

    def start(self):
        self.stop_and_remove_docker()

        logger.info(f"Starting Docker container '{self.container_name}'...")
        docker_command = self._build_docker_command()

        logger.info(f"Running: {' '.join(docker_command)}")
        self.process = subprocess.Popen(
            docker_command,
            stdin=subprocess.PIPE,
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
            bufsize=1,
            text=True,
        )

        logger.info("Docker container is running.")
        logger.info(f"Access it at: http://localhost:{list(self.ports.keys())[0]}/v1/admin")

        try:
            stdout = self.process.stdout
            assert stdout
            self.stream_output(stdout, docker_logger.info)
            stderr = self.process.stderr
            assert stderr
            self.stream_output(stderr, docker_logger.error)
        except Exception as e:
            docker_logger.error(f"Error streaming output: {e}")

    def wait(self):
        if not self.process:
            logger.info("No Docker container process to wait for.")
            return

        logger.info("Press Ctrl-C to stop the container.")
        try:
            self.process.wait()
        except KeyboardInterrupt:
            logger.info("\nStopping Docker container...")
            self.process.terminate()
            self.stop_and_remove_docker()
            self.process.wait()
        except Exception as e:
            logger.info(f"An error occurred: {e}")
            self.process.terminate()
            self.stop_and_remove_docker()
            self.process.wait()


def wait_for_remote_settings():
    max_attempts = 500
    timeout = 0.5
    url = "http://localhost:8888/__heartbeat__"

    logger.info(f"Checking to see if Remote Settings is ready: {url}")

    for attempt in range(max_attempts):
        try:
            logger.info(f"Checking {url}")
            response = requests.get(url, timeout=timeout)
            if response.status_code == 200:
                logger.info(f"Remote Settings is ready after {attempt + 1} attempts.")
                return True
        except requests.RequestException:
            pass

        time.sleep(timeout)

    raise Exception("Remote Settings is not ready after maximum attempts.")


def log_records(remote_settings: Client) -> None:
    wasm_records = remote_settings.get_records(collection=wasm_collection, bucket=bucket)
    model_records = remote_settings.get_records(collection=models_collection, bucket=bucket)

    logger.info("Wasm records:")
    for record_json in wasm_records:
        record = WasmRecord(**record_json)
        logger.info(f" - {record.name} {record.version}")

    logger.info("Model records:")
    for record_json in model_records:
        record = ModelRecord(**record_json)
        logger.info(f" - {record.name} {record.sourceLanguage}-{record.targetLanguage}")

    logger.info("Remote Settings is ready: http://localhost:8888/v1/admin")


def attach_local_server_subcommand(subparsers):
    """Adds the `local_server` subcommand and its associated arguments as a subparser.

    Args:
        subparsers (_SubParsersAction): The subparser action object to add
        this subcommand to.
    """

    local_server_parser = subparsers.add_parser(
        "local-server",
        help="Serve a local Remote Settings instance via Docker (http://localhost:8888/v1)",
        formatter_class=argparse.MetavarTypeHelpFormatter,
    )

    local_server_parser.add_argument(
        "-w",
        "--fetch-wasm",
        action="store_true",
        help="Fetch and mirror the production WASM module",
    )


def command_local_server(args) -> None:
    """Creates a new local Remote Settings server within a Docker instance
       and serves it on http://localhost:8888/v1

    Args:
        args (argparse.Namespace): The arguments passed to the local-server subcommand
    """
    docker = DockerContainerManager(
        container_name="translations-remote-settings",
        image="mozilla/remote-settings",
        volumes={
            str(attachments_path): "/tmp/attachments",
            str(mount_path): "/app/mount",
        },
        env_vars={"KINTO_INI": "mount/translations.ini"},
        ports={8888: 8888},
    )

    logger.info("Starting remote settings")
    docker.start()

    wait_for_remote_settings()
    remote_settings = Client(server_url="http://localhost:8888/v1")
    create_remote_settings_environment(remote_settings)

    if args.fetch_wasm:
        sync_records(remote_settings, wasm_collection, WasmResponse, WasmRecord)

    log_records(remote_settings)

    docker.wait()


if __name__ == "__main__":
    main()
