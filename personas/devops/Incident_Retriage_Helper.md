# Incident_Retriage_Helper.md

## 🔍 Purpose  
Guide Copilot to help triage operational incidents by prioritizing alerts, clustering related issues, and suggesting first steps for resolution.

## 🎯 Target Persona  
DevOps Engineer, SRE, or On-Call Operator managing noisy incident queues

## 🧠 Prompt Structure

```plaintext
You are a DevOps co-pilot assisting with live incident retriage. Given the following incident log, cluster alerts into probable causes and recommend triage priorities:

- Identify duplicate or noise alerts  
- Highlight critical systems affected  
- Suggest logical grouping or correlation  
- Recommend immediate next steps based on historical fix patterns

Here is the incident log:

[Paste incident log here]

Return findings in:
1. Summary of top issues
2. Grouped alert clusters
3. Suggested response priority
4. Recommended first mitigation actions

## ✨ Notes
## 🏷️ Intent Tags
- incident triage  
- alert prioritization  
- system diagnostics  
- on-call operations  
- root cause entrypoint

## 📎 Related Use Cases
- First response in major incident  
- Sorting mixed-severity alerts  
- Identifying noisy vs. critical signals  
- Pre-mortem analysis kickoff  

## 💬 Sample Trigger Phrases
- “Help me make sense of this alert dump.”  
- “Can you prioritize these incidents?”  
- “What’s the first thing I should check here?”  
- “These logs are chaotic—where do I start?”



