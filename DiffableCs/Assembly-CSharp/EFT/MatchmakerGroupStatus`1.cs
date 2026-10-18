namespace EFT;

public sealed class MatchmakerGroupStatus`1
{
	[JsonProperty("squad")]
	public GroupPlayer[] Players; //Field offset: 0x0
	[JsonProperty("raidSettings")]
	public TRaidSettings RaidSettings; //Field offset: 0x0

	public MatchmakerGroupStatus`1() { }

}

