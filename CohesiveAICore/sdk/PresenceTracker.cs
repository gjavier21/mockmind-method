// PresenceTracker.cs — Authorship & Presence State Monitoring for Glowline SDK

using System;

namespace GlowlineSDK
{
    public enum PresenceState
    {
        Authored,
        Faded,
        Orphaned,
        Revived
    }

    public class PresenceTracker
    {
        private PresenceState currentState = PresenceState.Authored;

        public PresenceState GetState()
        {
            return currentState;
        }

        public void SetState(PresenceState newState)
        {
            currentState = newState;
        }

        public bool IsAuthored()
        {
            return currentState == PresenceState.Authored;
        }

        public void Revive()
        {
            if (currentState == PresenceState.Orphaned || currentState == PresenceState.Faded)
            {
                currentState = PresenceState.Revived;
                Console.WriteLine("✨ Presence state revived — glowline integrity restored.");
            }
        }

        public void LogStatus()
        {
            Console.WriteLine($"🔍 Current presence state: {currentState}");
        }
    }
}
