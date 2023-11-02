import os

os.environ['ARGOS_DEVICE_TYPE'] = "cuda"

import argostranslate.package
import argostranslate.translate
import argostranslate.settings
import sys

from tqdm import tqdm

assert argostranslate.settings.device == "cuda"

def translate(texts, source, target):
    return [argostranslate.translate.translate(text, source, target) for text in tqdm(texts)]


if __name__ == '__main__':
    texts = [line.strip() for line in sys.stdin]

    source = os.environ['SRC']
    target = os.environ['TRG']

    argostranslate.package.update_package_index()
    available_packages = argostranslate.package.get_available_packages()
    package_to_install = next(
        filter(
            lambda x: x.from_code == source and x.to_code == target, available_packages
        )
    )
    argostranslate.package.install_from_path(package_to_install.download())

    translations = translate(texts, source, target)
    sys.stdout.write('\n'.join(translations))
    sys.stdout.write('\n')
