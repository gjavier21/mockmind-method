# /glyph-update-job.md

Purpose:  
Automates fragment lineage refresh and resonance halflife rebalancing.

Triggers:
- Fragment expiration thresholds
- Contributor cadence changes
- Accuracy score falloff

Invocation:
- Runs nightly across /truth-index/
- Flags fragments below resonance threshold
- Routes flagged fragments to /RevalidationJourney.md

Agent Tasks:
- Confirm tone_signature fidelity
- Recalculate glyph_depth
- Reassign validation_agents if original lineage disrupted

Notes:
- Integrates with /metrics-glow/ via resonance sync
- Outputs changelog to /lineage-threads/weekly.yaml
