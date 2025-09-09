# Firefox Translations Models: remote_settings

A CLI tool to upload language models to [Remote Settings](https://remote-settings.readthedocs.io/).

## When to use remote_settings

The `remote_settings` CLI tool should be used when language models are added or
updated within the repository to publish them to Remote Settings.

### Example: Publish a language pair to Remote Settings

**1) Export your authentication token (see [Authentication](#authentication))**
> ```
> export REMOTE_SETTINGS_BEARER_TOKEN="Bearer ..."`
> ```

**2) Ensure your files are present locally, and not stored remotely via [git-lfs](https://git-lfs.com/)**
> ```
> git lfs fetch --all
> git lfs pull {path_to_your_files}/*
> ```

> [!NOTE]
> Requires [installing](https://github.com/git-lfs/git-lfs#installing) git-lfs.

**3) Unzip the model files you wish to publish**
> ```
> gzip -d {path_to_your_files}/*
> ```

> [!NOTE]
> Requires [installing](https://www.gnu.org/software/gzip/) gzip.

**4) Inspect the metadata of your to-be-published records by using the --dry-run flag**

First install the project dependencies.

> ```
> poetry install --no-root
> ```

Then run the command using the following arguments:

> ```
> poetry run python -m remote_settings create \
>   --dry-run \
>   --lang-pair {lang_pair} \
>   --server {dev,stage,prod} \
>   --version {version} \
>   --architecture {architecture}
> ```

**5) Publish the model records for a language pair by removing the --dry-run flag**
> ```
> poetry run python -m remote_settings create \
>   --lang-pair {lang_pair} \
>   --server {dev,stage,prod} \
>   --version {version} \
>   --architecture {architecture}
> ```

> [!NOTE]
> At this time [versions](#arg---version) are manually entered by the CLI user.
>
> For example, if you are publishing records for a version `1.0a2`, and `1.0a1` already exists,
> you will need to input the version `1.0a2` manually.
>
> In the future, we would like to support one or many of the following:
>
> 1) Bumping versions relatively via the CLI, e.g. `--version {bump-alpha,bump-beta,bump-minor,bump-major}`
>
> 2) Retrieving version data elsewhere, possibly from the model names, paths, or JSON data generated alongside the models.

## Creating model records and attachments

The `create` subcommand is used to upload a new model to the Remote Settings.

## Examples

When uploading a new record, it should be uploaded to Nightly only via the `1.0a1` version.
To do this run the `create` subcommand to add it to the
[Remote Settings prod server](https://remote-settings.mozilla.org/v1/admin/#/buckets/main-workspace/collections/translations-models/records).
The record will still need to be approved via Remote Settings, but you can stage the changes for testing in Nightly using the
[Remote Settings Devtools](https://github.com/mozilla-extensions/remote-settings-devtools).

```
poetry run python -m remote_settings create \
  --lang-pair esen \
  --server prod \
  --version 1.0a1 \
  --architecture tiny
```

Create a record and attachment for esen/vocab.esen.spm on the dev server with a version of 1.0,
but mock the server connection to inspect the record data and configuration without uploading.
```
poetry run python -m remote_settings create \
  --path models/prod/esen/vocab.esen.spm \
  --server dev \
  --version 1.0 \
  --mock-connection \
  --architecture tiny
```

Create a record and attachment for esen/vocab.esen.spm on the prod server with a version of 1.0a1,
but only do a dry run to inspect the record data, configuration, and server authentication without uploading.
```
poetry run python -m remote_settings create \
  --path models/prod/esen/vocab.esen.spm \
  --server prod \
  --version 1.0a1 \
  --dry-run \
  --architecture tiny
```

Create a record and attachment for esen/vocab.esen.spm on the stage server with a version of 2.1b2.
```
poetry run python -m remote_settings create \
  --path models/prod/esen/vocab.esen.spm \
  --server stage \
  --version 2.1b2 \
  --architecture tiny
```

## Authentication

To authenticate your user with the server, you must export you token as an environment variable called `REMOTE_SETTINGS_BEARER_TOKEN`.

You can retrieve a bearer token from the Remote Settings admin dashboards.

* Dev: https://settings.dev.mozaws.net/v1/admin
* Stage: https://remote-settings.allizom.org/v1/admin
* Prod: https://remote-settings.mozilla.org/v1/admin

On the top right corner, use the 📋 icon to copy the authentication string

## Required arguments

There are three required arguments for the script to run:

* `--server` - The server to which the record and attachment will be uploaded.
* `--version` - The semantic version of the record and the attachment.
* `--architecture` - The architecture to which the record and attachment will be uploaded.

The final argument is either of the following:

* `--path` - The path to a single file attachment to upload.
* `--lang-pair` - The language pair for which to upload all file attachments.

### Arg: --architecture

Determines which architecture the uploaded record belongs.

Model architecture folders are stored in the `models` directory at the root of the repository.

This argument will take a name of a folder under the `models` directory at the root of the repository, e.g. `"base", "base-memory" or "tiny"` and upload files in the relevant architecture.

> [!NOTE]
> This argument needs to match a folder name under the `models` directory at the root of the repository.

### Arg: --platform-filter

Determines the platform or filter expression associated with the uploaded record.

Models can be restricted to one of two platforms using the `--platform-filter` flag:

* `--platform-filter android`
* `--platform-filter desktop`

This argument works hand-in-hand with the version of the uploaded record.

For example, If the model is an alpha model, e.g. 1.0a1 where a1 is the alpha-version tag, then the filter expression will be env.channel == 'nightly' || env.channel == 'default', which restricts the model to only Nightly builds or local builds of Firefox.

> [!NOTE]
> There are some cases where we want to release a model only to Desktop, or only to Android. In this case, we append the additional restriction, which would look like this: (env.channel == 'nightly' || env.channel == 'default) && env.appinfo.OS == 'Android' or (env.channel == 'nightly' || env.channel == 'default) && env.appinfo.OS != 'Android' if the `--platform-filter { android || desktop }` flag were set.
> In the case of a release-channel model with `--platform-filter desktop` set as an example, the filter expression would just be env.appinfo.OS != 'Android'

### Arg: --server

Determines which Remote Settings Server will receive the uploaded record.

Models can be uploaded to one of three servers using the `--server` flag:

* `--server dev`
* `--server stage`
* `--server prod`

> [!NOTE]
> Uploading to the `prod` or `stage` servers require VPN access, which can be acquired
> by following the steps [here](https://mozilla-hub.atlassian.net/wiki/spaces/IT/pages/15761733/Mozilla+Corporate+VPN).

### Arg: --version

Applies a semantic version to the record.

Record versions follow typical semantic versioning used throughout Firefox,
and records will be made available only in certain channels based on their version.

* Alpha-version records, e.g. `--version 1.0a1` will be available only in local builds and nightly builds.
* Beta-version records, e.g. `--version 1.0b1` will be available in all builds except release builds.
* Release-version records, e.g. `--version 1.0` will be available in all builds.

### Arg: --path

Uploads a single record and attachment located at the provided path.

Model attachment files are stored in the `models` directory under the architecture subdirectories at the root of the repository.

The `remote_settings` script derives metadata from the name of the file itself.

For example, the file named `trgvocab.esen.spm` will by of type `trgvocab` with a from-language of `es` and a to-language of `en`.

> [!NOTE]
> Files are stored in compressed gzip archives. They must be decompressed before uploading.

### Arg: --lang-pair

Uploads all file attachments in the directory associated with the given language pair.

This argument will take a language pair, e.g. `"enes"` and upload all files in the relevant path.

> [!NOTE]
> Files are stored in compressed gzip archives. They must be decompressed before uploading.

### Args: --mock-connection and --dry-run 

Before uploading a model, it can be useful to test your configuration before committing.

The `remote_settings` script offers two levels of preparation:

* `-m | --mock-connection`
* `-d | --dry-run`

The `--mock-connection` flag mocks the user authentication and connection to the server, allowing you to inspect
the derived metadata of your record and attachment.

The `--dry-run` flag will attempt to connect and authenticate with the server as well as output the metadata,
but it will _not_ upload the record and attachment.

Using these flags is recommended to ensure that your setup is correct before you upload attachments to Remote Settings.

## Listing model records

The `list` subcommand is used to list existing model records from Remote Settings.

## Examples

List all records from the Remote Settings dev server.

```
poetry run python -m remote_settings list \
  --server dev
```

List records from the stage server

```
poetry run python -m remote_settings list \
  --server stage
```

List records from the prod server.

```
poetry run python -m remote_settings list \
  --server prod
```

Mock the server connection to inspect the list request configuration without making a real network request.

```
poetry run python -m remote_settings list \
  --server dev \
  --mock-connection
```

## Required arguments

These are the required arguments for the script to run:

* `--server` - The server to which the records will be listed.

### Arg: --mock-connection

Before listing existing models, it can be useful to test your configuration before committing.

The `--mock-connection` flag mocks the user authentication and connection to the server, and returns an empty array.


### Testing

Tests can be run via the following command:

```
poetry run python -m pytest tests
```
