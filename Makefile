
### Evaluation

MODELS?=
GCP_CREDS_PATH?=
AZURE_TRANSLATOR_KEY?=

build-docker:
	docker build -t bergamot-eval ./evals

run-docker:
	docker run --name bergamot-eval -it --shm-size=16gb --rm \
		  --runtime=nvidia --gpus all \
		  -v $$(pwd)/models:/models \
		  -v $(GCP_CREDS_PATH):/.gcp_creds \
		  -e GOOGLE_APPLICATION_CREDENTIALS=/.gcp_creds \
		  -e AZURE_TRANSLATOR_KEY=$(AZURE_TRANSLATOR_KEY) \
		  bergamot-eval
