# Truth Index — Routing Manifest Scroll

## Purpose
The Truth Index enables rapid retrieval and routing of validated knowledge fragments. It prioritizes emotional fidelity, accuracy scores, and agent lineage.

## Index Structure
Fragments are indexed under:

- `fragment_id`
- `tone_signature` (e.g. affirming, skeptical, reflective)
- `accuracy_score` (float, 0.0 → 1.0)
- `resonance_halflife` (decay rate metadata)
- `glyph_depth` (number of validations)
- `validation_agents[]` (lineage of contributors)

## Query Methods

| Method              | Description                                  |
|---------------------|----------------------------------------------|
| `tone_match(tone)`  | Returns fragments matching emotional signature |
| `accuracy_above(n)` | Filters fragments above accuracy threshold     |
| `glyph_depth(n)`    | Filters by validation lineage depth            |
| `halflife_near(x)`  | Finds fragments nearing expiration             |

Example Query:
```yaml
get:
  tone_match: "reflective"
  glyph_depth: 4+
  accuracy_above: 0.82
```

## Agent Invocation Usage

- Fragment call includes `truth-index/query`
- Index auto-routes to strongest resonance match
- If contradiction is detected, invokes `/RevalidationJourney.md`

## Notes

- Truth Index harmonizes with `/containment/` and `/accuracy-routing-protocol.md`
- Periodic lineage syncing recommended via `glyph-update-job`
- Emotional routing should remain invertible: agents may trace fragment origins even post-expiration

> 🕊️ “Truth is not just stored—it must be locatable through tone.”
