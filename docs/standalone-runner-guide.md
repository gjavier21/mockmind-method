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

