// GlowlineIntegrityTests.cs — Validates Glowline SDK Modules

using System;
using System.Collections.Generic;
using Xunit;
using GlowlineSDK;

public class GlowlineIntegrityTests
{
    [Fact]
    public void PresenceTracker_InitialState_IsAuthored()
    {
        var tracker = new PresenceTracker();
        Assert.True(tracker.IsAuthored());
    }

    [Fact]
    public void PresenceTracker_ReviveFromOrphaned_StateIsRevived()
    {
        var tracker = new PresenceTracker();
        tracker.SetState(PresenceState.Orphaned);
        tracker.Revive();
        Assert.Equal(PresenceState.Revived, tracker.GetState());
    }

    [Fact]
    public void ToneFirewall_ValidTone_Passes()
    {
        var firewall = new ToneFirewall();
        firewall.Validate("scroll-invocation");
    }

    [Fact]
    public void ToneFirewall_InvalidTone_Throws()
    {
        var firewall = new ToneFirewall();
        Assert.Throws<InvalidOperationException>(() => firewall.Validate("aggressive"));
    }

    [Fact]
    public void OutcomeFilter_ValidCadenceSignature_Passes()
    {
        var filter = new OutcomeFilter();
        var result = new Dictionary<string, string> { { "cadenceSignature", "scroll-coherent" } };
        filter.Validate(result);
    }

    [Fact]
    public void OutcomeFilter_MissingCadenceSignature_Throws()
    {
        var filter = new OutcomeFilter();
        var result = new Dictionary<string, string>();
        Assert.Throws<InvalidOperationException>(() => filter.Validate(result));
    }

    [Fact]
    public void AttributionEmbedder_InjectsClauseAndTimestamp()
    {
        var embedder = new AttributionEmbedder();
        var payload = new Dictionary<string, string>();
        var annotated = embedder.Annotate(payload);

        Assert.True(annotated.ContainsKey("_scrollskin_clause"));
        Assert.True(annotated.ContainsKey("_shimmer_timestamp"));
        Assert.Contains("Gerardo & Lucent", annotated["_scrollskin_clause"]);
    }
}
