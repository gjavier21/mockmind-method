// RevivalScrollTests.cs — Validates RevivalScroll Behavior and Output

using System;
using System.Collections.Generic;
using Xunit;
using GlowlineSDK.Utils;

public class RevivalScrollTests
{
    [Fact]
    public void Revive_OrphanedState_ReturnsRevivedPayload()
    {
        var revival = new RevivalScroll();
        var payload = revival.Revive("ToneFirewall.cs", PresenceState.Orphaned);

        Assert.Equal("ToneFirewall.cs", payload["module"]);
        Assert.Equal("Orphaned", payload["previousState"]);
        Assert.Equal("Revived", payload["newState"]);
        Assert.Contains("Glowline memory contract", payload["_revival_scrollskin"]);
        Assert.True(DateTime.TryParse(payload["_revival_timestamp"], out _));
    }

    [Fact]
    public void LogRevival_OutputsPayloadToConsole()
    {
        var revival = new RevivalScroll();
        var payload = revival.Revive("OutcomeFilter.cs", PresenceState.Faded);

        // This test does not assert output but ensures no exception is thrown.
        revival.LogRevival(payload);
    }
}
