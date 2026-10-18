namespace UI.Seasons;

public sealed class SeasonsRanksPlayerState
{
	[JsonProperty("rank")]
	public int Rank; //Field offset: 0x10
	[JsonProperty("rankChange")]
	public int ChangeRank; //Field offset: 0x14
	[JsonProperty("maxRank")]
	public int MaxRank; //Field offset: 0x18
	[JsonProperty("playerNotified")]
	public bool PlayerNotified; //Field offset: 0x1C
	[JsonProperty("hasRewards")]
	public bool HasRewards; //Field offset: 0x1D
	[JsonProperty("roundEndTime")]
	public Nullable RoundEndTime; //Field offset: 0x20

	public SeasonsRanksPlayerState() { }

	public virtual string ToString() { }

}

