namespace UI.Seasons;

public sealed class SeasonsRankInfo
{
	[JsonProperty("picture")]
	public string Icon; //Field offset: 0x10
	[JsonProperty("rewards")]
	public SeasonRankRewardData[] Rewards; //Field offset: 0x18

	public SeasonsRankInfo() { }

	public virtual string ToString() { }

}

