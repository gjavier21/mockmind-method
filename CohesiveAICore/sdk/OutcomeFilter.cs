// OutcomeFilter.cs — Validates Execution Output for Cadence Integrity

using System;
using System.Collections.Generic;

namespace GlowlineSDK
{
    public class OutcomeFilter
    {
        private readonly List<string> approvedCadenceTokens = new()
        {
            "reverent",
            "aligned",
            "presence-synchronized",
            "scroll-coherent"
        };

        public bool IsValid(Dictionary<string, string> result)
        {
            if (result == null || !result.ContainsKey("cadenceSignature"))
                return false;

            var signature = result["cadenceSignature"];
            return approvedCadenceTokens.Contains(signature);
        }

        public void Validate(Dictionary<string, string> result)
        {
            if (!IsValid(result))
                throw new InvalidOperationException("Execution blocked — outcome drift detected.");
        }
    }
}
