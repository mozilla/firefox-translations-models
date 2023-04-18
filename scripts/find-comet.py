import sys
import glob
from signal import signal, SIGPIPE, SIG_DFL

signal(SIGPIPE, SIG_DFL)

patterns = ['/'.join(['evaluation'] + x.split('/')[1:3]) for x in sys.stdin.readlines()]
bleu_paths = [g + '\n' for p in patterns for g in glob.glob(p[:-2] + '-' + p[-2:] + '/*.bergamot.*.comet')]

sys.stdout.writelines(bleu_paths)
