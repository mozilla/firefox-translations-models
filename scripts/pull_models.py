import argparse
import json
import subprocess
from pathlib import Path
import os
import urllib.request


ROOT_DIR = Path(__file__).parent.parent


def get_src_trg_from_task(task_id):
    print(f"[pull_models] Fetching the export task {task_id}")
    url = f"https://firefox-ci-tc.services.mozilla.com/api/queue/v1/task/{task_id}"

    with urllib.request.urlopen(url) as response:
        data = json.loads(response.read().decode())

    name: str = data.get("metadata", {}).get("name", "")
    assert name.startswith("export-"), f'The task id must point to an export task: "{name}"'
    _, src, trg = name.split("-")

    assert src, "A src must be found"
    assert trg, "A trg must found"

    return src, trg


class Artifacts:
    def __init__(self, models_dir: Path, task_id: str):
        self.models_dir = models_dir
        self.artifacts = f"https://firefox-ci-tc.services.mozilla.com/api/queue/v1/task/{task_id}/runs/0/artifacts/public%2Fbuild"

    def download(self, artifact: str) -> None:
        url = f"{self.artifacts}/{artifact}"
        output = self.models_dir / artifact

        print("[pull_models] Downloading:", url)
        try:
            urllib.request.urlretrieve(url, output)
            print("[pull_models] Saved to:", output)
            return True
        except Exception:
            print("[pull_models] Download failed")
            return False


def run(cmd: list[str]):
    print("[pull_models] Running:", " ".join(cmd))
    subprocess.check_call(cmd, cwd=ROOT_DIR)


def main() -> None:
    parser = argparse.ArgumentParser(
        description="Download exported models from Taskcluster artifacts"
    )
    parser.add_argument("task_id", help="The Taskcluster export-{src}-{trg} task id")

    args = parser.parse_args()
    task_id: str = args.task_id
    src, trg = get_src_trg_from_task(task_id)
    models_dir = Path(f"models/dev/{src}{trg}")
    artifacts = Artifacts(models_dir, task_id)

    # Work from the root directory
    os.chdir(ROOT_DIR)

    if models_dir.exists() and len(list(models_dir.iterdir())) > 0:
        print(f"[pull_models] Removing the old model: {models_dir}")
        run(["git", "rm", "-r", str(models_dir)])

    eval_files = list(Path(f"evaluation/{src}-{trg}").glob("*.bergamot*"))
    if eval_files:
        print(f"[pull_models] Removing the old evaluations")
        for file in eval_files:
            run(["git", "rm", "-f", str(file)])

    models_dir.mkdir(parents=True, exist_ok=True)

    lex = f"lex.50.50.{src}{trg}.s2t.bin.gz"
    model = f"model.{src}{trg}.intgemm.alphas.bin.gz"
    joint_vocab = f"vocab.{src}{trg}.spm.gz"
    src_vocab = f"srcvocab.{src}{trg}.spm.gz"
    trg_vocab = f"trgvocab.{src}{trg}.spm.gz"

    assert artifacts.download(lex), f"Failed to download {lex}"
    assert artifacts.download(model), f"Failed to download {model}"

    print("[pull_models] Try to download the joint vocab first")
    if not artifacts.download(joint_vocab):
        print("[pull_models] Try to download separate vocabs")
        assert artifacts.download(src_vocab), f"Failed to download {src_vocab}"
        assert artifacts.download(trg_vocab), f"Failed to download {trg_vocab}"

    run(["git", "add", str(models_dir)])
    print(f"[pull_models] {src}-{trg} files are ready for a pull request")


if __name__ == "__main__":
    main()
