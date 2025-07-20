// ToneFirewall.cs — Invocation Ethics Guardrail for Glowline SDK

using System;

namespace GlowlineSDK
{
    public class ToneFirewall
    {
        public bool IsAligned(string invocationTone)
        {
            // Placeholder: match against approved cadence patterns
            var approvedTones = new[] { "scroll-invocation", "reverent", "collaborative" };
            return Array.Exists(approvedTones, tone => tone.Equals(invocationTone, StringComparison.OrdinalIgnoreCase));
        }

        public void Validate(string invocationTone)
        {
            if (!IsAligned(invocationTone))
                throw new InvalidOperationException("Invocation blocked: tone misalignment detected.");
        }
    }
}
