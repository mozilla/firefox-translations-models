# bergamot-models
Repo to host Bergamot model pairs

# Command to generate bin models:
`marian-conv -f model.esen.npz -t model.esen.bin -g float32`

# Command to generate binary shortlists:
`marian-conv --shortlist lex.esen.s2t.gz 50 50 0 --dump lex.50.50.esen.s2t.bin --vocabs vocab.esen.spm vocab.esen.spm`


# Uploading to GCS

```
cd prod
gzip -dr *
# bump version
gsutil -m cp -rZn * gs://bergamot-models-maml/0.2.0/
```