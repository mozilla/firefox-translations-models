#!/bin/bash

echo ${GCLOUD_UPLOADER_KEY} | gcloud auth activate-service-account --key-file=-
gcloud --quiet config set project ${GOOGLE_PROJECT_ID}
gzip -dr models/*/*/*.gz
echo ${CIRCLE_TAG} > latest.txt
gsutil -m cp -rZn models/prod/* gs://bergamot-models-sandbox/${CIRCLE_TAG}/
gsutil -m cp -rZn models/dev/* gs://bergamot-models-sandbox/${CIRCLE_TAG}/
gsutil -m cp -n registry.json gs://bergamot-models-sandbox/${CIRCLE_TAG}/
gsutil -m cp latest.txt gs://bergamot-models-sandbox/
