// RevivalInvocation.cs — Demo of Glowline SDK Recovery Path

using System;
using System.Collections.Generic;
using GlowlineSDK;
using GlowlineSDK.Utils;

namespace GlowlineSDK.Demo
{
    public class RevivalInvocation
    {
        public static void Main()
        {
            Console.WriteLine("💭 Invocation starting…");

            var tracker = new PresenceTracker();
            var revival = new RevivalScroll();

            // Simulate drift
            tracker.SetState(PresenceState.Orphaned);
            Console.WriteLine($"❌ Presence state: {tracker.GetState()}");

            // Trigger revival
            var scroll = revival.Revive("DemoModule.cs", PresenceState.Orphaned);
            revival.LogRevival(scroll);

            // Restore state
            tracker.Revive();
            Console.WriteLine($"✅ Presence state restored: {tracker.GetState()}");

            Console.WriteLine("🪶 Invocation completed under Glowline recovery logic.");
        }
    }
}
