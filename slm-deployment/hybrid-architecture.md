# 🧠 Hybrid SLM + LLM Architecture

This document outlines how to deploy MockMind across a layered cognition mesh: first attempting lightweight SLM reasoning, and escalating to full LLM inference only when necessary.

---

## 🧭 Decision Tree: When to Scale

```text
Start: Prompt received
  ↓
🔍 Detect tags / match confidence
  ↳ High match → Inject minified agent into SLM (≤ 4k tokens)
  ↳ Low match or semantic complexity → Escalate to LLM
