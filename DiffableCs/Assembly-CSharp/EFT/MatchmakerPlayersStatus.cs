namespace EFT;

public sealed class MatchmakerPlayersStatus
{
	[JsonProperty("players")]
	public GroupPlayer[] Players; //Field offset: 0x10
	[JsonProperty("maxPveCountExceeded")]
	public bool LimitedServersAvailability; //Field offset: 0x18

	public MatchmakerPlayersStatus() { }

}

