# 🧠 Standalone Cognition Runner Guide

This guide explains how to run `standalone-runner.py` to enable 24/7 local cognition using minified `.md` agents.

---

## 🧭 Purpose

The runner monitors a folder of prompt files, routes each to the correct agent, and writes structured `.md` insight files—offline, continuously, and securely.

---

## 📁 Required Structure

/mockmind-method/ 
├── tools/standalone-runner.py 
├── inbox/prompts/ 	# Input .txt prompts 
├── memory/insights/ # Output .md insights 
├── slm-deployment/minified-agents/




---

## 📝 Prompt Format

Each file in `/inbox/prompts/` should be a plain `.txt` file with a natural-language prompt.

Example: `team_engagement.txt`

---

## ⚙️ How It Works

1. Script wakes every 5 seconds
2. Reads all `.txt` files in `/inbox/prompts/`
3. Routes each prompt to a minified agent based on keyword tags
4. Writes `.md` insight to `/memory/insights/`
5. Archives original prompt as `.processed`

---

## 🧠 Agent Matching Logic (Default)

| Keyword Match               | Agent Triggered         |
|-----------------------------|--------------------------|
| “feel”, “confused”          | `mirror-agent.min.md`    |
| “decide”, “tradeoff”        | `strategy-agent.min.md`  |
| “remember”, “past decision” | `continuity-agent.min.md`|

You can customize this logic in the `route_prompt()` function.

---

## ✅ First Run

```bash
python3 tools/standalone-runner.py
