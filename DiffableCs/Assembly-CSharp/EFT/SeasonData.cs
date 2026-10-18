namespace EFT;

public sealed class SeasonData
{
	[JsonProperty("id")]
	public MongoID Id; //Field offset: 0x10
	[JsonProperty("startTs")]
	public int StartTimestamp; //Field offset: 0x28
	[JsonProperty("endTs")]
	public int EndTimestamp; //Field offset: 0x2C
	[JsonProperty("seasonalRewards")]
	public SeasonalRewardTemplate[] SeasonalRewards; //Field offset: 0x30

	public SeasonData() { }

}

