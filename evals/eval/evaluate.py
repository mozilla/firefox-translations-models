import json
import re
import shutil
import subprocess
import os
from collections import defaultdict
import statistics
import traceback
from sacrebleu import dataset
import click
from toolz import groupby
from glob import glob
import pandas as pd
from mtdata import iso
from os.path import exists

EVALUATION_LANGUAGES = [
    "af",
    "am",
    "ar",
    "az",
    "be",
    "bg",
    "bn",
    "bs",
    "ca",
    "cs",
    "cy",
    "da",
    "de",
    "el",
    "es",
    "et",
    "fa",
    "fi",
    "fr",
    "gl",
    "gu",
    "he",
    "hi",
    "hr",
    "hu",
    "hy",
    "id",
    "ig",
    "is",
    "it",
    "ja",
    "kn",
    "ko",
    "lt",
    "lv",
    "ml",
    "mr",
    "ms",
    "mt",
    "my",
    "nb",
    "nl",
    "nn",
    "pl",
    "pt",
    "ro",
    "ru",
    "sk",
    "sl",
    "sq",
    "sr",
    "sv",
    "ta",
    "te",
    "th",
    "tl",
    "tr",
    "uk",
    "vi",
    "zh",
]

NO_FLORES_LANGUAGES = ["sq"]

SUPPORTED_LANGUAGES = {
    "argos": {
        "ar": {"en"},
        "az": {"en"},
        "ca": {"en"},
        "zh": {"en"},
        "cs": {"en"},
        "da": {"en"},
        "en": {
            "ar",
            "az",
            "bg",
            "ca",
            "zh",
            "cs",
            "da",
            "nl",
            "eo",
            "fi",
            "fr",
            "el",
            "he",
            "hi",
            "hu",
            "id",
            "ga",
            "it",
            "ja",
            "ko",
            "fa",
            "pl",
            "pt",
            "ru",
            "sk",
            "sp",
            "sv",
            "tr",
            "uk",
        },
        "nl": {"en"},
        "eo": {"en"},
        "fi": {"en"},
        "fr": {"en"},
        "el": {"en"},
        "he": {"en"},
        "hi": {"en"},
        "hu": {"en"},
        "id": {"en"},
        "ga": {"en"},
        "it": {"en"},
        "ja": {"en"},
        "ko": {"en"},
        "fa": {"en"},
        "pl": {"en"},
        "pt": {"en"},
        "ru": {"en"},
        "sk": {"en"},
        "sp": {"en"},
        "sv": {"en"},
        "tr": {"en"},
        "uk": {"en"},
        "bg": {"en"},
    },
    "opusmt": {
        "af": {"sv", "fi", "ru", "nl", "de", "es", "fr", "en"},
        "am": {"sv"},
        "ar": {"he", "ru", "de", "it", "el", "pl", "tr", "es", "fr", "en"},
        "az": {"es", "tr", "en"},
        "be": {"es"},
        "bg": {"uk", "sv", "fi", "ru", "de", "it", "tr", "es", "fr", "en"},
        "bn": {"en"},
        "ca": {"uk", "nl", "pt", "it", "de", "es", "fr", "en"},
        "ceb": {"sv", "fi", "es", "fr", "en"},
        "cs": {"uk", "sv", "fi", "de", "fr", "en"},
        "cy": {"en"},
        "da": {"fi", "ru", "de", "es", "no", "fr", "en"},
        "de": {
            "af",
            "ar",
            "bg",
            "ca",
            "cs",
            "da",
            "de",
            "el",
            "en",
            "es",
            "et",
            "fi",
            "fr",
            "ha",
            "he",
            "hr",
            "ht",
            "hu",
            "ig",
            "ilo",
            "is",
            "it",
            "ln",
            "lt",
            "ms",
            "nl",
            "no",
            "pl",
            "tl",
            "uk",
            "vi",
        },
        "el": {"sv", "fi", "fr", "ar"},
        "en": {
            "af",
            "ar",
            "az",
            "bg",
            "ca",
            "ceb",
            "cs",
            "cy",
            "da",
            "de",
            "el",
            "es",
            "et",
            "fi",
            "fr",
            "ga",
            "gl",
            "ha",
            "he",
            "hi",
            "ht",
            "hu",
            "hy",
            "id",
            "ig",
            "ilo",
            "is",
            "it",
            "lg",
            "ln",
            "mg",
            "mk",
            "ml",
            "mr",
            "nl",
            "ro",
            "ru",
            "sk",
            "sq",
            "ss",
            "sv",
            "sw",
            "tl",
            "tn",
            "uk",
            "ur",
            "vi",
            "xh",
            "zh",
        },
        "es": {
            "af",
            "ar",
            "bg",
            "ca",
            "ceb",
            "cs",
            "da",
            "de",
            "el",
            "en",
            "es",
            "et",
            "fi",
            "fr",
            "gl",
            "ha",
            "he",
            "hr",
            "ht",
            "id",
            "ig",
            "ilo",
            "is",
            "it",
            "ln",
            "lt",
            "mk",
            "nl",
            "no",
            "pl",
            "ro",
            "ru",
            "sl",
            "tl",
            "tn",
            "uk",
            "vi",
            "xh",
            "yo",
        },
        "et": {"sv", "fi", "ru", "de", "es", "fr", "en"},
        "fi": {
            "af",
            "bg",
            "ceb",
            "cs",
            "de",
            "el",
            "en",
            "es",
            "et",
            "fi",
            "fr",
            "ha",
            "he",
            "hr",
            "ht",
            "hu",
            "id",
            "ig",
            "ilo",
            "is",
            "it",
            "lg",
            "ln",
            "lv",
            "mg",
            "mk",
            "nl",
            "no",
            "ro",
            "ru",
            "sk",
            "sl",
            "sq",
            "sv",
            "sw",
            "tn",
            "tr",
            "uk",
            "xh",
            "yo",
        },
        "fr": {
            "af",
            "ar",
            "bg",
            "ca",
            "ceb",
            "de",
            "el",
            "en",
            "es",
            "ha",
            "he",
            "hr",
            "ht",
            "hu",
            "id",
            "ig",
            "ilo",
            "lg",
            "ln",
            "ms",
            "no",
            "pl",
            "ro",
            "ru",
            "sk",
            "sl",
            "sv",
            "tl",
            "tn",
            "uk",
            "vi",
            "xh",
            "yo",
        },
        "ga": {"en"},
        "gl": {"es", "pt", "en"},
        "ha": {"sv", "fi", "es", "fr", "en"},
        "he": {"uk", "sv", "fi", "ru", "it", "de", "ar", "es"},
        "hi": {"ur", "en"},
        "hr": {"fi", "sv", "es", "fr"},
        "ht": {"sv", "fi", "es", "fr", "en"},
        "hu": {"uk", "sv", "fi", "de", "fr", "en"},
        "hy": {"ru", "en"},
        "id": {"sv", "fi", "es", "fr", "en"},
        "ig": {"sv", "fi", "de", "es", "fr", "en"},
        "ilo": {"sv", "fi", "de", "es", "en"},
        "is": {"sv", "fi", "de", "it", "es", "fr", "en"},
        "it": {"ar", "bg", "ca", "de", "en", "es", "fr", "is", "lt", "ms", "sv", "uk", "vi"},
        "ja": {
            "ar",
            "bg",
            "da",
            "de",
            "en",
            "es",
            "fi",
            "fr",
            "he",
            "hu",
            "it",
            "ms",
            "nl",
            "pl",
            "pt",
            "ru",
            "sv",
            "tr",
            "vi",
        },
        "ka": {"ru", "en"},
        "ko": {"sv", "fi", "ru", "de", "hu", "es", "fr", "en"},
        "lg": {"sv", "fi", "es", "fr", "en"},
        "ln": {"fr", "es", "de", "en"},
        "lt": {"sv", "ru", "it", "de", "pl", "tr", "es", "fr"},
        "lv": {"sv", "fi", "ru", "es", "fr", "en"},
        "mg": {"es", "en"},
        "mk": {"fi", "es", "fr", "en"},
        "ml": {"en"},
        "mr": {"en"},
        "ms": {"fr", "it", "ms", "de"},
        "nl": {"uk", "sv", "fi", "af", "es", "no", "ca", "fr", "en"},
        "no": {"da", "de", "es", "fi", "fr", "nl", "no", "pl", "ru", "sv", "uk"},
        "pa": {"en"},
        "pl": {"uk", "sv", "de", "ar", "es", "no", "lt", "fr", "en"},
        "pt": {"ca", "uk", "tl", "gl"},
        "ro": {"sv", "fi", "fr"},
        "ru": {
            "af",
            "ar",
            "bg",
            "da",
            "en",
            "es",
            "et",
            "fi",
            "fr",
            "he",
            "hy",
            "lt",
            "lv",
            "no",
            "sl",
            "sv",
            "uk",
            "vi",
        },
        "sk": {"sv", "fi", "es", "fr", "en"},
        "sl": {"uk", "sv", "fi", "ru", "es", "fr"},
        "sq": {"sv", "es", "en"},
        "ss": {"en"},
        "sv": {
            "af",
            "bg",
            "ceb",
            "cs",
            "el",
            "en",
            "es",
            "et",
            "fi",
            "fr",
            "ha",
            "he",
            "hr",
            "ht",
            "hu",
            "id",
            "ig",
            "ilo",
            "is",
            "lg",
            "ln",
            "lv",
            "nl",
            "no",
            "ro",
            "ru",
            "sk",
            "sl",
            "sq",
            "sv",
            "th",
            "tn",
            "uk",
            "xh",
            "yo",
        },
        "th": {"fr", "en"},
        "tl": {"pt", "es", "de", "en"},
        "tn": {"sv", "es", "fr", "en"},
        "tr": {"uk", "az", "sv", "ar", "es", "lt", "fr", "en"},
        "uk": {
            "bg",
            "ca",
            "cs",
            "de",
            "en",
            "es",
            "fi",
            "fr",
            "he",
            "hu",
            "it",
            "nl",
            "no",
            "pl",
            "pt",
            "ru",
            "sl",
            "sv",
            "tr",
        },
        "ur": {"en"},
        "vi": {"ru", "it", "de", "es", "fr", "en"},
        "xh": {"sv", "es", "fr", "en"},
        "yo": {"sv", "fi", "es", "fr", "en"},
        "zh": {"bg", "de", "en", "fi", "he", "it", "ms", "nl", "sv", "uk", "vi"},
    },
}

HOME_DIR = "./"
EVAL_DIR = os.path.join(HOME_DIR, "eval")
CLEAN_CACHE_PATH = os.path.join(EVAL_DIR, "clean-cache.sh")

CUSTOM_DATASETS = ["flores-dev", "flores-test"]
CUSTOM_DATA_DIR = os.path.join(HOME_DIR, "data")
FLORES_PATH = os.path.join(CUSTOM_DATA_DIR, "flores.sh")

BERGAMOT_APP_PATH = os.path.join(HOME_DIR, "bergamot-translator", "build", "app", "bergamot")
BERGAMOT_EVAL_PATH = os.path.join(HOME_DIR, "translators", "bergamot.sh")


TRANS_ORDER = {"bergamot": 0, "google": 1, "microsoft": 2, "argos": 3, "nllb": 4, "opusmt": 5}


def fill_bergamot_supported_languages(models_dir):
    SUPPORTED_LANGUAGES["bergamot"] = {}
    for pair in os.listdir(models_dir):
        if pair[:2] in SUPPORTED_LANGUAGES["bergamot"]:
            SUPPORTED_LANGUAGES["bergamot"][pair[:2]].add(pair[-2:])
        else:
            SUPPORTED_LANGUAGES["bergamot"][pair[:2]] = {pair[-2:]}


def get_dataset_prefix(dataset_name, pair, results_dir):
    dataset_name = dataset_name.replace("/", "_")
    return os.path.join(results_dir, f"{pair[0]}-{pair[1]}", f"{dataset_name}")


def get_bleu_path(dataset_name, pair, results_dir, translator, evaluation_engine):
    prefix = get_dataset_prefix(dataset_name, pair, results_dir)
    return f"{prefix}.{translator}.{pair[1]}.{evaluation_engine}"


# Custom data


def download_custom_data():
    print("Downloading Flores dataset")
    os.makedirs(CUSTOM_DATA_DIR, exist_ok=True)
    subprocess.run(["bash", FLORES_PATH, CUSTOM_DATA_DIR])


def copy_flores_lang(dataset_name, lang, eval_prefix):
    flores_dataset = "dev" if dataset_name == "flores-dev" else "devtest"

    if lang == "zh" or lang == "zh-Hans":
        lang_code = "zho_simpl"
    elif lang == "zh-Hant":
        lang_code = "zho_trad"
    elif lang == "nb":
        lang_code = "nob"
    elif lang == "az":
        lang_code = "azj"
    else:
        lang_code = iso.iso3_code(lang)

    os.makedirs(os.path.dirname(eval_prefix), exist_ok=True)
    shutil.copy(
        os.path.join(
            CUSTOM_DATA_DIR, "flores101_dataset", flores_dataset, f"{lang_code}.{flores_dataset}"
        ),
        f"{eval_prefix}.{lang}",
    )


def copy_custom_data(dataset_name, pair, results_dir):
    src, trg = pair
    eval_prefix = get_dataset_prefix(dataset_name, pair, results_dir)

    if dataset_name.startswith("flores"):
        copy_flores_lang(dataset_name, src, eval_prefix)
        copy_flores_lang(dataset_name, trg, eval_prefix)
    else:
        raise ValueError(f"Unsupported custom dataset: {dataset_name}")


# Evaluation


def find_datasets(pair):
    formatted_pair = f"{pair[0]}-{pair[1]}"
    datasets = []
    if not any(
        no_flores_lang == pair[0] or no_flores_lang == pair[1]
        for no_flores_lang in NO_FLORES_LANGUAGES
    ):
        datasets += CUSTOM_DATASETS

    for dataset_name, descr in dataset.DATASETS.items():
        is_wmt_official = dataset_name.startswith("wmt") and len(dataset_name) == 5
        is_other_accepted = dataset_name == "iwslt17" or dataset_name == "mtedx/test"

        if not (is_wmt_official or is_other_accepted) or formatted_pair not in descr.langpairs:
            continue

        datasets.append(dataset_name)

    return datasets


def evaluate(pair, set_name, translator, evaluation_engine, gpus, models_dir, results_dir):
    source, target = pair

    my_env = os.environ.copy()
    my_env["SRC"] = source
    my_env["TRG"] = target
    eval_prefix = get_dataset_prefix(set_name, pair, results_dir)

    if translator == "bergamot":
        my_env["MODEL_DIR"] = os.path.join(models_dir, f"{source}{target}")
        my_env["APP_PATH"] = BERGAMOT_APP_PATH
        cmd = ["bash", BERGAMOT_EVAL_PATH]
    elif translator == "google":
        cmd = ["python3", os.path.join(HOME_DIR, "translators", "google_translate.py")]
    elif translator == "microsoft":
        cmd = ["python3", os.path.join(HOME_DIR, "translators", "microsoft.py")]
    elif translator == "argos":
        cmd = ["python3", os.path.join(HOME_DIR, "translators", "argos.py")]
    elif translator == "nllb":
        cmd = ["python3", os.path.join(HOME_DIR, "translators", "nllb.py")]
    elif translator == "opusmt":
        cmd = ["python3", os.path.join(HOME_DIR, "translators", "opusmt.py")]
    else:
        raise ValueError(f"Translator is not supported: {translator}")

    COMET_PATTERN = re.compile(r"score: (.+)")

    os.makedirs(os.path.dirname(eval_prefix), exist_ok=True)

    source_file = f"{eval_prefix}.{source}"
    reference_file = f"{eval_prefix}.{target}"
    translated_file = f"{eval_prefix}.{translator}.{target}"
    result_file = f"{eval_prefix}.{translator}.{target}.{evaluation_engine}"

    if set_name not in CUSTOM_DATASETS:
        if not os.path.exists(source_file):
            with open(source_file, "w") as output_file:
                subprocess.run(
                    ["sacrebleu", "-t", set_name, "-l", f"{source}-{target}", "--echo", "src"],
                    stdout=output_file,
                    text=True,
                    check=True,
                )

    if not os.path.exists(translated_file):
        with open(source_file, "rb") as input_file:
            with open(translated_file, "wb") as output_file:
                subprocess.run(cmd, stdin=input_file, stdout=output_file, env=my_env, check=True)

    retries = 3
    while True:
        try:
            if evaluation_engine == "bleu":
                if set_name in CUSTOM_DATASETS:
                    dataset_params = [reference_file]
                else:
                    dataset_params = ["-t", set_name]

                if not os.path.exists(result_file):
                    with open(translated_file, "r") as input_file:
                        with open(result_file, "w") as output_file:
                            subprocess.run(
                                ["sacrebleu", "--score-only", "-q", "-l", f"{source}-{target}"]
                                + dataset_params,
                                stdin=input_file,
                                stdout=output_file,
                                text=True,
                                check=True,
                            )

            if evaluation_engine == "comet":
                if set_name in CUSTOM_DATASETS:
                    dataset_params = ["-s", source_file, "-r", reference_file]
                else:
                    dataset_params = ["-d", f"{set_name}:{source}-{target}"]

                completed_process = subprocess.run(
                    [
                        "comet-score",
                        "--gpus",
                        gpus,
                        "--quiet",
                        "--only_system",
                        "-t",
                        translated_file,
                    ]
                    + dataset_params,
                    capture_output=True,
                    text=True,
                    check=True,
                )
                match = COMET_PATTERN.search(completed_process.stdout)
                if match:
                    with open(result_file, "w") as output_file:
                        output_file.write(f"{match.group(1)}\n")
                else:
                    raise Exception("Unable to find Comet score in output")

            with open(result_file, "r") as f:
                return float(f.read())
        except:
            traceback.print_exc()
            if retries == 0:
                raise
            retries -= 1
            subprocess.run(["bash", CLEAN_CACHE_PATH])
            print("Attempt failed, retrying")


def run_dir(
    lang_pairs, skip_existing, translators, evaluation_engines, gpus, results_dir, models_dir
):
    reordered = sorted(translators.split(","), key=lambda x: TRANS_ORDER[x])

    for evaluation_engine in evaluation_engines.split(","):
        for pair in lang_pairs:
            if "nn" in pair:
                print(
                    "There are no evaluation datasets for Norwegian Nynorsk "
                    "and it is not supported by Google and Microsoft API. Skipping evaluation"
                )
                continue

            for dataset_name in find_datasets(pair):
                for translator in reordered:
                    if translator in SUPPORTED_LANGUAGES and pair[1] not in SUPPORTED_LANGUAGES[
                        translator
                    ].get(pair[0], {}):
                        continue

                    print(
                        f"Evaluation for dataset: {dataset_name}, translator: {translator}, pair: {pair[0]}-{pair[1]}, evaluation engine: {evaluation_engine}"
                    )

                    res_path = get_bleu_path(
                        dataset_name, pair, results_dir, translator, evaluation_engine
                    )
                    print(f"Searching for {res_path}")

                    if (
                        skip_existing
                        and os.path.isfile(res_path)
                        and os.stat(res_path).st_size > 0
                    ):
                        print(f"Already exists, skipping ({res_path})")
                        with open(res_path) as f:
                            score = float(f.read().strip())
                    else:
                        print("Not found, running evaluation...")
                        if dataset_name in CUSTOM_DATASETS:
                            copy_custom_data(dataset_name, pair, results_dir)
                        score = evaluate(
                            pair,
                            dataset_name,
                            translator,
                            evaluation_engine,
                            gpus,
                            results_dir=results_dir,
                            models_dir=models_dir,
                        )

                    print(f"Result {evaluation_engine}: {score}\n")


def run_comet_compare(lang_pairs, skip_existing, translators, gpus, models_dir, results_dir):
    for pair in lang_pairs:
        if "nn" in pair:
            print(
                "There are no evaluation datasets for Norwegian Nynorsk "
                "and it is not supported by Google and Microsoft API. Skipping comparison"
            )
            continue

        source, target = pair

        for dataset_name in find_datasets(pair):
            original_dataset_name = dataset_name
            dataset_name = dataset_name.replace("/", "_")
            print(f"Comparison for dataset: {dataset_name}, pair: {source}-{target}")
            working_folder = f"{results_dir}/{source}-{target}/"
            output_filename = f"{working_folder}/{dataset_name}.{source}-{target}.cometcompare"
            if (
                skip_existing
                and os.path.isfile(output_filename)
                and os.stat(output_filename).st_size > 0
            ):
                print(f"Comparison exists. Skipping...")
                continue

            source_dataset = f"{dataset_name}.{source}"
            targets = ""
            for translator in translators.split(","):
                targets += f"{dataset_name}.{translator}.{target} "
            command = ""
            if dataset_name in CUSTOM_DATASETS:
                reference = f"{dataset_name}.{target}"
                command = f"comet-compare --gpus {gpus} -s {source_dataset} -t {targets.strip()} -r {reference}"
            else:
                command = f"comet-compare --gpus {gpus} -d {original_dataset_name}:{source}-{target} -t {targets.strip()}"
            res = subprocess.run(
                command.split(" "),
                cwd=working_folder,
                stdout=subprocess.PIPE,
                stderr=subprocess.PIPE,
            )
            stdout = res.stdout.decode("utf-8")
            with open(output_filename, "w") as f:
                f.write(stdout)
            print("stdout: ", res.stdout.decode("utf-8"))
            print("stderr: ", res.stderr.decode("utf-8"))


# Report generation


def build_report(res_dir, evaluation_engines):
    os.makedirs(os.path.join(res_dir, "img"), exist_ok=True)

    for evaluation_engine in evaluation_engines.split(","):
        results = read_results(res_dir, evaluation_engine)
        with open(os.path.join(EVAL_DIR, evaluation_engine + "-results.md")) as f:
            lines = [l.strip() for l in f.readlines()]

        avg_results = get_avg_scores(results)
        build_section(avg_results, "avg", lines, res_dir, evaluation_engine)

        results_json_path = os.path.join(res_dir, evaluation_engine + "-results.json")
        with open(results_json_path, "w") as file:
            json.dump(results, file, sort_keys=True, indent=2)
            print(f"Results are written to {results_json_path}")

        for lang_pair, datasets in results.items():
            build_section(datasets, lang_pair, lines, res_dir, evaluation_engine)

        results_path = os.path.join(res_dir, evaluation_engine + "-results.md")
        with open(results_path, "w+") as f:
            f.write("\n".join(lines))
            print(f"Results are written to {results_path}")


def build_section(datasets, key, lines, res_dir, evaluation_engine):
    lines.append(f"\n## {key}\n")
    lines.append(f'| Translator/Dataset | {" | ".join(datasets.keys())} |')
    lines.append(f"| {' | '.join(['---' for _ in range(len(datasets) + 1)])} |")

    inverted_formatted = defaultdict(dict)
    inverted_scores = defaultdict(dict)
    comet_comparisons = defaultdict(dict)
    for dataset_name, translators in datasets.items():
        bergamot_res = translators.get("bergamot")
        reordered = sorted(translators.items(), key=lambda x: TRANS_ORDER[x[0]])

        for translator, score in reordered:
            if score == 0:
                formatted_score = "N/A"
            elif translator != "bergamot" and bergamot_res:
                change_perc = (score - bergamot_res) / bergamot_res * 100
                change = score - bergamot_res
                sign = "+" if change > 0 else ""
                formatted_score = f"{score:.2f} ({sign}{change:.2f}, {sign}{change_perc:.2f}%)"
            else:
                formatted_score = f"{score:.2f}"

            inverted_formatted[translator][dataset_name] = formatted_score
            inverted_scores[translator][dataset_name] = score

        # if this is a non-avg comet report, and a cometcompare report exists, we print it
        cometcompare_path = "{}/{}/{}.{}.cometcompare".format(res_dir, key, dataset_name, key)
        if (
            evaluation_engine == "comet"
            and key != "avg"
            and "{}.{}".format(dataset_name, key) not in comet_comparisons
            and exists(cometcompare_path)
        ):
            cometcompare_file = open(cometcompare_path)
            filelines = cometcompare_file.readlines()
            final_report = ""
            for line in filelines:
                if "outperforms" in line:
                    final_report += f"- {line}"
            comet_comparisons["{}.{}".format(dataset_name, key)] = final_report

    for translator, scores in inverted_formatted.items():
        lines.append(f'| {translator} | {" | ".join(scores.values())} |')

    img_path = os.path.join(res_dir, "img", f"{key}-{evaluation_engine}.png")
    plot_lang_pair(datasets, inverted_scores, img_path, evaluation_engine)

    img_relative_path = "/".join(img_path.split("/")[-2:])
    lines.append(f"\n![Results]({img_relative_path})")

    printed_header = False
    for dataset in comet_comparisons:
        if not printed_header:
            lines.append("### Comparisons between systems")
            lines.append(
                "*If a comparison is omitted, the systems have equal averages (tie). Click on the dataset for a complete report*"
            )
            printed_header = True

        lines.append(f"#### [{dataset}]({key}/{dataset}.cometcompare)")
        lines.append(f"{comet_comparisons[dataset]}")

    lines.append("---")


def read_results(res_dir, evaluation_engine):
    results = defaultdict(dict)
    all_translators = set()
    for bleu_file in glob(res_dir + "/*/*." + evaluation_engine):
        (
            dataset_name,
            translator,
        ) = os.path.basename(bleu_file).split(
            "."
        )[:2]
        pair = bleu_file.split("/")[-2]
        with open(bleu_file) as f:
            score = float(f.read().strip())

        if dataset_name not in results[pair]:
            results[pair][dataset_name] = {}
        results[pair][dataset_name][translator] = score
        all_translators.add(translator)

    # fix missing translators
    for _, datasets in results.items():
        for _, translators in datasets.items():
            for translator in all_translators:
                if translator not in translators:
                    translators[translator] = 0

    return results


def get_avg_scores(results):
    scores = {}
    for lang_pair, datasets in results.items():
        tran_scores = [
            (tran, score) for data, trans in datasets.items() for tran, score in trans.items()
        ]
        avg_scores = {
            tran: statistics.mean([s for _, s in scores])
            for tran, scores in groupby(lambda x: x[0], tran_scores).items()
        }
        scores[lang_pair] = avg_scores
    return scores


def plot_lang_pair(datasets, inverted_scores, img_path, evaluation_engine):
    trans_scores = {t: s.values() for t, s in inverted_scores.items()}
    translators = [t for t in TRANS_ORDER.keys() if t in inverted_scores]

    df = pd.DataFrame(trans_scores, index=datasets, columns=translators)
    fig = df.plot.bar(ylabel=evaluation_engine).get_figure()
    fig.set_size_inches(18.5, 10.5)
    fig.savefig(img_path, bbox_inches="tight")


# Main


@click.command()
@click.option(
    "--pairs", default="all", help="Comma separated language pairs or `all`. Example: es-en,de-et"
)
@click.option(
    "--translators",
    default="bergamot",
    help="Comma separated translators. Example: bergamot,google",
)
@click.option("--results-dir", help="Directory for results")
@click.option("--models-dir", help="Directory with models")
@click.option(
    "--skip-existing",
    default=False,
    is_flag=True,
    help="Whether to skip already calculated scores. "
    "They are located in `results/xx-xx` folders as *.bleu or *.comet files.",
)
@click.option(
    "--evaluation-engine",
    default="bleu",
    help="Determine which evaluation engine to use: bleu or comet",
)
@click.option(
    "--comet-compare",
    default=False,
    help="Determine if comet-compare should be executed or not. Default: True",
)
@click.option(
    "--gpus",
    default="0",
    help="Determine the number of GPUs used by the comet engine (if applicable). Default: 0",
)
def run(
    pairs,
    translators,
    results_dir,
    models_dir,
    skip_existing,
    evaluation_engine,
    gpus,
    comet_compare,
):
    fill_bergamot_supported_languages(models_dir)

    # Ensure we don't forget adding Bergamot models to EVALUATION_LANGUAGES.
    for source, targets in SUPPORTED_LANGUAGES["bergamot"].items():
        if source != "en":
            assert source in EVALUATION_LANGUAGES, f"{source} missing in EVALUATION_LANGUAGES"
        for lang in targets:
            if lang != "en":
                assert lang in EVALUATION_LANGUAGES, f"{lang} missing in EVALUATION_LANGUAGES"

    if pairs == "all":
        lang_pairs = sum(([("en", lang), (lang, "en")] for lang in EVALUATION_LANGUAGES), [])
    else:
        lang_pairs = [(pair[:2], pair[-2:]) for pair in pairs.split(",")]

    print(f"Language pairs to evaluate: {lang_pairs}")
    download_custom_data()
    run_dir(
        lang_pairs,
        skip_existing,
        translators,
        evaluation_engine,
        gpus,
        models_dir=models_dir,
        results_dir=results_dir,
    )
    if comet_compare:
        run_comet_compare(
            lang_pairs,
            skip_existing,
            translators,
            gpus,
            models_dir=models_dir,
            results_dir=results_dir,
        )
    build_report(results_dir, evaluation_engine)


if __name__ == "__main__":
    run()
