# Firefox Translations models
CPU-optimized NMT models for [Firefox Translations](https://github.com/mozilla-extensions/firefox-translations).

`prod` - models that are uploaded to GCS and available to use in `https://github.com/mozilla-extensions/firefox-translations`
`dev` - models under development (can be with low quality or speed)

# Command to generate bin models:
`marian-conv -f model.esen.npz -t model.esen.bin -g float32`

# Command to generate binary shortlists:
`marian-conv --shortlist lex.esen.s2t.gz 50 50 0 --dump lex.50.50.esen.s2t.bin --vocabs vocab.esen.spm vocab.esen.spm`


# Uploading to GCS

```
cd prod
gzip -dr *
# bump version
gsutil -m cp -rZn * gs://bergamot-models-sandbox/0.2.0/
```
# Currently supported Languages
## Prod
- Spanish <-> English
- Estonian <-> English
- English -> German
- Czech <-> English
## Dev
-  Russian -> English
## Upcoming
-  German -> English
-  French <-> English
-  Polish <-> English
-  Russian <- English
-  Portuguese <-> English
