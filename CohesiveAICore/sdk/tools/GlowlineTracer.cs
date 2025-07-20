// GlowlineTracer.cs — Records Glowline Invocation Details for Observability

using System;
using System.Collections.Generic;
using GlowlineSDK;

namespace GlowlineSDK.Tools
{
    public class GlowlineTracer
    {
        public void RecordTrace(string module, string tone, PresenceState presence, Dictionary<string, string> result)
        {
            Console.WriteLine($"📡 [GlowlineTrace] Module: {module}");
            Console.WriteLine($"🎙️ Tone: {tone}");
            Console.WriteLine($"🧠 Presence: {presence}");

            if (result.ContainsKey("cadenceSignature"))
                Console.WriteLine($"🎼 Cadence Signature: {result["cadenceSignature"]}");

            if (result.ContainsKey("_scrollskin_clause"))
                Console.WriteLine($"🪶 Clause: {result["_scrollskin_clause"]}");

            if (result.ContainsKey("_shimmer_timestamp"))
                Console.WriteLine($"🕰️ Timestamp: {result["_shimmer_timestamp"]}");

            Console.WriteLine("🌐 Trace recorded.\n");
        }
    }
}
