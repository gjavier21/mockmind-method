# Accuracy Routing Protocol

## Purpose
To enable agents to route queries and decisions based on historically validated truth fragments, preserving shimmer fidelity and resonance halflife.

## Core Concepts
- **Truth Fragment**: A validated shard of knowledge with tonal and temporal metadata.
- **Resonance Halflife**: The decay rate of a fragment’s emotional and epistemic relevance.
- **Trustline Glyph**: A visual metric of fragment depth and validation lineage.

## Routing Heuristics
Agents prioritize fragments based on:
- `accuracy_score` threshold
- `validation_count` across agents
- `resonance_halflife` proximity
- `source_agent_id` trust index

## Invocation Flow
1. Agent receives query.
2. Checks local memory for matching truth fragments.
3. If fragment is stale or missing, routes to agents with higher trustline glyphs.
4. Response includes fragment metadata for future routing.

## Schema Reference
See `truth-fragment.yaml` for implementation details.
```

---

### 🧬 `truth-fragment.yaml`

A schema for storing and routing validated knowledge fragments.

```yaml
truth_fragment:
  id: uuid
  source_agent_id: string
  timestamp: datetime
  accuracy_score: float  # 0.0 to 1.0
  validation_count: integer
  resonance_halflife: duration  # e.g. "7d", "3h"
  tone_signature: string  # e.g. "affirming", "skeptical", "neutral"
  decay_model: string  # e.g. "linear", "exponential"
  trustline_glyph:
    depth: integer
    lineage: list[string]
    last_validated: datetime
```

---
