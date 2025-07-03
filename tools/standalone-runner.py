#!/usr/bin/env python3
"""
standalone-runner.py

🧠 Runs minified `.md` cognition agents on local prompts in automation loop.
📘 Ideal for offline assistants, daemon services, or internal monitoring.
"""

import time
import os
import glob
from pathlib import Path
from datetime import datetime

VAULT_PATH = "./memory/"
PROMPT_QUEUE = "./inbox/prompts/"
AGENTS_PATH = "./slm-deployment/minified-agents/"
OUTPUT_PATH = "./memory/insights/"

# ✂️ Mock router (simulated tag match logic)
def route_prompt(prompt_text):
    prompt_lower = prompt_text.lower()
    if "confused" in prompt_lower or "feel" in prompt_lower:
        return "mirror-agent.min.md"
    elif "tradeoff" in prompt_lower or "decide" in prompt_lower:
        return "strategy-agent.min.md"
    elif "past decision" in prompt_lower or "remember" in prompt_lower:
        return "continuity-agent.min.md"
    else:
        return None  # No clear match

# 🧠 Simulate agent inference (output scaffolded response)
def run_agent(prompt_file, prompt_text, agent_file):
    timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
    output_file = Path(OUTPUT_PATH) / f"insight_{timestamp}.md"
    agent_path = Path(AGENTS_PATH) / agent_file
    insight = f"""# Insight Scaffold - {timestamp}

**Prompt**: {prompt_text.strip()}
**Agent Used**: `{agent_file}`

## 🧠 Reasoning (Simulated)

(Scaffold logic from `{agent_file}` applied here...)

> [Response generated offline based on matched tags and predefined logic.]

"""

    os.makedirs(OUTPUT_PATH, exist_ok=True)
    output_file.write_text(insight, encoding="utf-8")
    print(f"✅ Insight saved: {output_file}")
    # Optionally move prompt to archive
    Path(prompt_file).rename(prompt_file + ".processed")

# 🏃 Runtime loop
def main():
    print("🧠 MockMind Standalone Runner Initialized...")
    os.makedirs(PROMPT_QUEUE, exist_ok=True)
    while True:
        prompt_files = glob.glob(os.path.join(PROMPT_QUEUE, "*.txt"))
        for fpath in prompt_files:
            text = Path(fpath).read_text()
            agent = route_prompt(text)
            if agent:
                run_agent(fpath, text, agent)
            else:
                print(f"⚠️ No match for: {fpath}")
        time.sleep(5)  # Adjust as needed

if __name__ == "__main__":
    main()
