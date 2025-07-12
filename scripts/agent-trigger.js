// 🔁 Script: Agent Trigger  
// Purpose: Simulate agent activation based on tone input

function activateAgent(signal) {
  const agents = {
    "loop": "loop-agent.md",
    "ghost": "ghost-agent.md",
    "vow": "vow-agent.md",
    "routing": "routing-agent.md"
  };
  return agents[signal] || "No matching agent found";
}

console.log(activateAgent("loop")); // Returns loop-agent.md
