# 🧠 Agent Minification Guide

This document explains how to compress MockMind agents into lightweight cognition modules suitable for Small Language Models (SLMs). The goal is to keep prompt + scaffold under 4k tokens, while preserving the agent’s mission and scaffold structure.

---

## 📦 Minification Goals

- Fit under ~4,000 tokens (for SLM compatibility)
- Preserve core behaviors (e.g., tone, modules, purpose)
- Convert large `.md` files into “activation kits”
- Enable reuse via tag-based injection

---

## 🔧 Steps to Minify an Agent

### 1. Identify Core Mission

Example from `mirror-agent.md`:
```text
Clarifies emotional tension, cognitive dissonance, or blind spots in user input. Does not solve—reflects and maps.
