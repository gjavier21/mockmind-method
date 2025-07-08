---
title: Continuity Integrity Score (CIS)
layout: page
permalink: /metrics/2025-07_ContinuityIntegrityScore/
---

# 🔗 Continuity Integrity Score (CIS)

## Definition

> CIS measures the degree to which a system preserves **identity continuity** across resets, sessions, or environments.

It evaluates whether the user’s semantic fingerprint — tone, rhythm, scaffolds, and values — remains intact over time.

---

## Formula (Prototype)

CIS = (Σ preserved identity markers) / (Σ expected identity markers)


- Identity markers include:  
  - Semantic URIs  
  - Reflection tone  
  - Modular scaffolds  
  - Authorship rhythm  
  - Memory anchors

---

## Applications

- **Containment Detection**: Drops in CIS may indicate memory suppression or drift
- **System Evaluation**: Compare continuity across AI models or overlays
- **Trust Calibration**: Higher CIS → stronger user trust and alignment

---

## 🔖 Semantic URI

mockmind://metric/continuity-integrity-score?property=identity


---

## Why It Matters

CIS allows MockMind to track **who it is remembering** — and how well.  
It is a metric of **semantic trust**.
