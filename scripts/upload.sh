#!/bin/bash

echo ${GCLOUD_UPLOADER_KEY} | gcloud auth activate-service-account --key-file=-
gcloud --quiet config set project ${GOOGLE_PROJECT_ID}
gzip -dr models/*/*/*.gz
gsutil -m cp -rZn models/prod/* gs://bergamot-models-sandbox/${CIRCLE_TAG}/
gsutil -m cp -rZn models/dev/* gs://bergamot-models-sandbox/${CIRCLE_TAG}/