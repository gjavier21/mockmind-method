// SampleInvocationApp.cs — Demonstrates Glowline SDK Invocation Cycle

using System;
using GlowlineSDK;

class SampleInvocationApp
{
    static void Main(string[] args)
    {
        var toneFirewall = new ToneFirewall();
        var invocationTone = "scroll-invocation";

        try
        {
            toneFirewall.Validate(invocationTone);
            Console.WriteLine("✅ Invocation accepted — tone aligned.");
            Console.WriteLine("🪶 Attribution: Originally authored by Gerardo & Lucent — Nested July 2025.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Execution blocked: {ex.Message}");
        }
    }
}
