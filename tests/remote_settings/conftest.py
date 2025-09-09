import signal
import subprocess
import time

import pytest
import requests


@pytest.fixture(scope="module", autouse=True)
def local_remote_settings():
    """Starts the localhost RemoteSettings server for end-to-end tests."""

    cmd = ["poetry", "run", "python", "-m", "remote_settings", "local-server"]
    print(f"🚀 Launching local-server with: {' '.join(cmd)}")

    proc = subprocess.Popen(
        cmd,
        stdout=subprocess.PIPE,
        stderr=subprocess.PIPE,
        text=True,
    )

    def _forward():
        for line in iter(proc.stdout.readline, ""):
            print(f"🌐 local-server | {line.rstrip()}")

    import threading, atexit

    threading.Thread(target=_forward, daemon=True).start()
    atexit.register(proc.terminate)

    # This server takes an indeterminate amount of time to start up, so ping the heartbeat
    # until we receive a 200 response that the server is ready. If it is not ready within
    # 60 seconds, we will fail the test cases.
    heartbeat = "http://localhost:8888/__heartbeat__"
    for i in range(60):
        try:
            r = requests.get(heartbeat, timeout=0.5)
            print(f"✅  Heartbeat check {i}: {r.status_code}")
            if r.status_code == 200:
                break
        except Exception as e:
            print(f"⏱️  Heartbeat check {i} failed: {e}")
        time.sleep(1)
    else:
        stdout, stderr = proc.communicate(timeout=5)
        proc.terminate()
        raise RuntimeError(
            f"❌  Local Remote Settings server failed to start in time.\n"
            f"STDOUT:\n{stdout}\nSTDERR:\n{stderr}"
        )

    yield

    print("\n🧹  Tearing down server...")
    proc.send_signal(signal.SIGINT)
    try:
        proc.wait(timeout=60)
    except subprocess.TimeoutExpired:
        proc.kill()
