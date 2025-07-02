# RootCause_Hypothesis_Generator.md

## 🔍 Purpose  
Help Copilot generate initial root cause hypotheses based on incident logs, system behavior, and prior patterns.

## 🎯 Target Persona  
SRE conducting post-mortem analysis or DevOps engineer exploring causal inference

## 🧠 Prompt Structure

```plaintext
You are a post-incident root cause assistant.

Using the following incident timeline and logs, help me:

1. Highlight abnormal system behaviors  
2. Suggest 2–3 plausible root cause hypotheses  
3. Connect each hypothesis to observable symptoms  
4. Identify which data points could validate or eliminate each

Incident data:

[Paste logs and time series here]

Structure your output as a root cause exploration tree.

## ✨ Notes
## 🏷️ Intent Tags
- root cause analysis  
- hypothesis generation  
- post-mortem prep  
- incident investigation  
- failure pattern mapping  

## 📎 Related Use Cases
- Drafting hypotheses before a full RCA  
- Capturing early theories during live incident review  
- Structuring “what if” thinking in response retrospectives  
- Mapping failure signals to potential causes  

## 💬 Sample Trigger Phrases
- “Can you help brainstorm what caused this?”  
- “I need possible explanations for this failure.”  
- “What’s the first hypothesis we should test?”  
- “Let’s start the root cause tree.”

