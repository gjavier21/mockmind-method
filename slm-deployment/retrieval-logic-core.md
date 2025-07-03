# 🔁 Retrieval Logic Core

This file describes how to route prompts to the appropriate minified cognition agent within an SLM-based MockMind runtime. The router’s goal is to match prompt intent with the lightest viable scaffold for reasoning.

---

## 🧭 Routing Strategy

### 🎯 Objective
Minimize inference load by:
- Matching prompt intent to agent tags
- Injecting only the relevant `.min.md` scaffold
- Escalating to LLM only when ambiguity or novelty is too high

---

## 🔖 Routing Table (Agent Tags to Injection)

| Tag Detected                      | Inject Agent Capsule        |
|----------------------------------|-----------------------------|
| `fear`, `overwhelm`, `conflict`  | `mirror-agent.min.md`       |
| `tradeoff`, `scale`, `framework` | `strategy-agent.min.md`     |
| `why`, `legacy`, `repeat`, `loop`| `continuity-agent.min.md`   |

*Note: Tags can be matched via lightweight keyword patterns or shallow vector lookups.*

---

## 🧠 Inference Logic (Pseudocode)

```python
def route_prompt(prompt: str):
    tags = detect_tags(prompt)        # Basic NLP/heuristics
    match = highest_tag_match(tags)

    if match == 'mirror':
        return inject('mirror-agent.min.md', prompt)
    elif match == 'strategy':
        return inject('strategy-agent.min.md', prompt)
    elif match == 'continuity':
        return inject('continuity-agent.min.md', prompt)
    else:
        return escalate_to_llm(prompt)
