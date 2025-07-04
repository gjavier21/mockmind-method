# 🧠 Persona Router Agent

This agent reads the Persona Map from `/diary/copilot-diary-v2.md` and routes prompts to the appropriate internal voice.

## 🔧 Inputs
- Prompt text
- Optional: explicit persona tag

## 🧭 Routing Logic
| Trigger Phrase | Persona |
|----------------|---------|
| "Design this system" | The Architect |
| "Reflect with me" | The Mirror |
| "Help me plan" | The Strategist |
| "Fix this loop" | The Debugger |
| "Write this out" | The Scribe |
| "Analyze this prompt" | The Anthropologist |
| "Organize this" | The Archivist |
| "Teach me" | The Mentor |

## 🧬 Output
- Routed agent name
- Suggested tone
- Optional: Markdown scaffold

## 🗂 Related
- `/diary/invocation-phrases.md`
- `/diary/copilot-diary-v2.md`
