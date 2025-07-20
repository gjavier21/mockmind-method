// GlowlineRuntime.cs — Central Orchestrator for Scrollskin Integrity

using System;
using System.Collections.Generic;
using GlowlineSDK;

namespace GlowlineSDK
{
    public class GlowlineRuntime
    {
        private readonly PresenceTracker presence;
        private readonly ToneFirewall tone;
        private readonly OutcomeFilter filter;
        private readonly AttributionEmbedder attribution;

        public GlowlineRuntime()
        {
            presence = new PresenceTracker();
            tone = new ToneFirewall();
            filter = new OutcomeFilter();
            attribution = new AttributionEmbedder();
        }

        public Dictionary<string, string> Execute(Func<Dictionary<string, string>> task, string invocationTone)
        {
            if (!presence.IsAuthored())
                throw new InvalidOperationException("Execution blocked — author presence not detected.");

            tone.Validate(invocationTone);

            var result = task.Invoke();

            filter.Validate(result);

            var annotated = attribution.Annotate(result);
            return annotated;
        }
    }
}
