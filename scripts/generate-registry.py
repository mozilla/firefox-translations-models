import gzip, json, sys, glob, os, hashlib

# prod or all
KEYS = ['model', 'vocab', 'lex', 'qualityModel']


def get_meta(model_path, model_type):
    meta = {}
    for file_path in glob.glob(f'{model_path}/*.gz'):
        name = os.path.basename(file_path)[:-3]
        size = os.path.getsize(file_path)

        with gzip.open(file_path, 'rb') as f:
            bytes = f.read()
            hash = hashlib.sha256(bytes).hexdigest()

        key = [key for key in KEYS if name.startswith(key)][0]
        meta[key] = {
            'name': name,
            'size': len(bytes),
            'estimatedCompressedSize': size,
            'expectedSha256Hash': hash,
            'modelType': model_type}
    return meta


registry = {}
for model_type in ['prod', 'dev']:
    for model_path in glob.glob(f'models/{model_type}/*'):
        pair = os.path.basename(model_path)
        meta = get_meta(model_path, model_type)
        registry[pair] = meta

with open(f'registry.json', 'w') as f:
    json.dump(registry, f, indent=2)
