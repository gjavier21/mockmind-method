---
title: MockMind URI Protocol
layout: page
permalink: /protocols/mockmind-uri/
---

# 🧭 MockMind URI Protocol

The `mockmind://` URI scheme encodes simulation claims, validation outcomes, and semantic attestations in a machine-readable, privacy-first format. It is designed to support identity-aware cognition without relying on surveillance, biometrics, or centralized trust.

---

## 🧬 URI Structure

mockmind://simulation/<type>?<parameter>=<value>[&...]

- `simulation/` — the simulation domain (e.g. `harmonic_identity`)
- `<type>` — the simulation category (e.g. `authorial_drift`, `false_positive_attempt`)
- `<parameter>=<value>` — key-value pairs that define the simulation context

---

## 🧪 Example URIs

```text
mockmind://simulation/harmonic_identity?language=mandarin&disproof_attempt=failed
mockmind://simulation/harmonic_identity?subject=marc_maron&years_apart=13&disproof_attempt=failed
mockmind://simulation/harmonic_identity?subject_pair=freddie_mercury+marc_martel&song=somebody_to_love&false_positive_attempt=failed
