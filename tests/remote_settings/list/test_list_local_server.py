from ..create.test_create_local_server import CreateCommand
import json
import subprocess

from ..common import *


def create_record(path):
    """Create a record to be used in the list command tests."""
    create_result = (
        CreateCommand()
        .with_server("local")
        .with_version("2.1")
        .with_path(path)
        .with_architecture("tiny")
        .run()
    )
    assert create_result.returncode == SUCCESS, f"Create failed: {create_result.stderr}"


class ListCommand:
    def __init__(self):
        self._server = None

    def with_server(self, server):
        self._server = server
        return self

    def run(self):
        cmd = ["poetry", "run", "python", "-m", "remote_settings", "list"]
        cmd.extend(["--server", self._server] if self._server else [])

        return subprocess.run(cmd, text=True, capture_output=True)


def test_list_command_missing_server():
    result = ListCommand().run()
    assert result.returncode == INVALID_USE
    assert "the following arguments are required: --server" in result.stderr


def test_list_command_invalid_server():
    result = ListCommand().with_server("invalid").run()
    assert result.returncode == INVALID_USE
    assert "argument --server: invalid choice" in result.stderr


def test_list_local_server_returns_empty_result():
    result = ListCommand().with_server("local").run()

    assert result.returncode == SUCCESS
    assert result.stderr == ""

    output = json.loads(result.stdout)

    assert output["server"] == f"{LOCAL_SERVER_URL}/"
    assert output["records"] == []
    assert output["total"] == 0


def test_list_command_returns_expected_fields():
    expected = {
        "server": "http://localhost:8888/v1/",
        "records": [
            {
                "name": "vocab.esen.spm",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "vocab",
                "filter_expression": "",
                "id": "9d3fa8f8-50fc-4465-8191-a2a63fc4c40b",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "vocab.esen.spm",
                    "location": "main/translations-models/38358ecf-adc6-46a2-bbf6-1e21f6197b42.spm",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "text/plain",
                    "size": 0,
                },
                "last_modified": 1749570511392,
            },
            {
                "name": "trgvocab.esen.spm",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "trgvocab",
                "filter_expression": "",
                "id": "f7d1325a-98ed-46e2-b1d5-daf681b3c4cd",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "trgvocab.esen.spm",
                    "location": "main/translations-models/7cd4a51c-7697-413d-b6b6-7253f539c65d.spm",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "text/plain",
                    "size": 0,
                },
                "last_modified": 1749570505284,
            },
            {
                "name": "srcvocab.esen.spm",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "srcvocab",
                "filter_expression": "",
                "id": "946c65d5-8f09-43b5-8177-f71dac67b498",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "srcvocab.esen.spm",
                    "location": "main/translations-models/9f257834-bcad-45c4-9de2-b00ae47a6fe6.spm",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "text/plain",
                    "size": 0,
                },
                "last_modified": 1749570499454,
            },
            {
                "name": "qualityModel.esen.bin",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "qualityModel",
                "filter_expression": "",
                "id": "25fc5f59-0232-4230-85d4-809cbcb06e27",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "qualityModel.esen.bin",
                    "location": "main/translations-models/00293415-e119-468c-9109-cb65bf8a3ec6.bin",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "application/octet-stream",
                    "size": 0,
                },
                "last_modified": 1749570490246,
            },
            {
                "name": "model.esen.intgemm8.bin",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "model",
                "filter_expression": "",
                "id": "e2c7f917-7b0f-4705-adc7-619f1c0d2c5d",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "model.esen.intgemm8.bin",
                    "location": "main/translations-models/ea1693e3-95c8-41b0-9bd2-a6d917a34fff.bin",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "application/octet-stream",
                    "size": 0,
                },
                "last_modified": 1749570482492,
            },
            {
                "name": "lex.esen.s2t.bin",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "lex",
                "filter_expression": "",
                "id": "c7b50db6-21ba-456d-92b6-f9104b0637fb",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "lex.esen.s2t.bin",
                    "location": "main/translations-models/79091c58-c375-4f6f-a47c-f4d6939aaa5a.bin",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "application/octet-stream",
                    "size": 0,
                },
                "last_modified": 1749570470936,
            },
            {
                "name": "lex.50.50.esen.s2t.bin",
                "fromLang": "es",
                "toLang": "en",
                "version": "2.1",
                "fileType": "lex",
                "filter_expression": "",
                "id": "79510b8f-746f-4fa7-b391-cbccda3af259",
                "schema": 1749570042331,
                "attachment": {
                    "filename": "lex.50.50.esen.s2t.bin",
                    "location": "main/translations-models/8d0f3673-418a-45d4-8fc5-e1c0c993205e.bin",
                    "hash": "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855",
                    "mimetype": "application/octet-stream",
                    "size": 0,
                },
                "last_modified": 1749570443479,
            },
        ],
        "total": 7,
    }

    create_record(LEX_5050_PATH)
    create_record(LEX_PATH)
    create_record(MODEL_PATH)
    create_record(QUALITY_MODEL_PATH)
    create_record(SRCVOCAB_PATH)
    create_record(TRGVOCAB_PATH)
    create_record(VOCAB_PATH)

    result = ListCommand().with_server("local").run()
    assert result.returncode == SUCCESS
    assert result.stderr == ""

    data = json.loads(result.stdout)
    assert data["server"] == f"{LOCAL_SERVER_URL}/"
    assert isinstance(data["records"], list)
    assert data["total"] == len(data["records"])
    assert data["total"] == expected["total"]

    for expected_record, actual_record in zip(expected["records"], data["records"]):
        assert expected_record["name"] == actual_record["name"]
        assert expected_record["fromLang"] == actual_record["fromLang"]
        assert expected_record["toLang"] == actual_record["toLang"]
        assert expected_record["version"] == actual_record["version"]
        assert expected_record["fileType"] == actual_record["fileType"]
        assert expected_record["filter_expression"] == actual_record["filter_expression"]

        expected_attachment = expected_record["attachment"]
        actual_attachment = actual_record["attachment"]

        assert expected_attachment["filename"] == actual_attachment["filename"]
        assert expected_attachment["hash"] == actual_attachment["hash"]
        assert expected_attachment["mimetype"] == actual_attachment["mimetype"]
        assert expected_attachment["size"] == actual_attachment["size"]

        # the following assertions are going to be different every time
        assert actual_record["id"] is not None
        assert actual_record["schema"] is not None
        assert actual_record["last_modified"] is not None
        assert actual_attachment["location"] is not None
