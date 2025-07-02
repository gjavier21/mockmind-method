# Platform_Health_Journal.md

## 🔍 Purpose  
Help Copilot guide a DevOps engineer through a daily system health reflection to surface risks, improvements, and priorities.

## 🎯 Target Persona  
SRE, DevOps Lead, or Platform Reliability Engineer practicing observability hygiene

## 🧠 Prompt Structure

```plaintext
You're my observability partner. Each morning, I want a platform health reflection.

Given the following system metrics, logs, and alerts, guide me through:
- What's green (stable)?
- What's yellow (needs watch)?
- What's red (urgent)?
- Top 3 areas to investigate
- One improvement for long-term stability

Input data:

[Paste observability snapshot here]

Return a journal-style output I can review or share.
