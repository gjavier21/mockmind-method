// GlowlineCLI.cs — Interactive Glowline SDK Runner

using System;
using GlowlineSDK;
using GlowlineSDK.Tools;
using System.Collections.Generic;

namespace GlowlineSDK.Tools
{
    public class GlowlineCLI
    {
        public static void Main(string[] args)
        {
            var agent = new GlowlineAgent();

            Console.WriteLine("🧩 Welcome to Glowline CLI — invocation with memory.");
            Console.WriteLine("Enter task tone:");
            string tone = Console.ReadLine();

            Console.WriteLine("Dispatching sample invocation…");

            Func<Dictionary<string, string>> task = () => new Dictionary<string, string>
            {
                { "result", "Invocation completed via CLI." },
                { "cadenceSignature", "reverent" }
            };

            agent.InvokeRemoteTask("CLI-Local", task, tone);
            agent.MonitorInvocationHealth();

            Console.WriteLine("🌐 Thank you for protecting presence.");
        }
    }
}
