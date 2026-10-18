namespace EFT.SeasonalPerks;

public sealed class SeasonalPerkItemFilterRule
{
	[JsonProperty("field")]
	public readonly EPerkItemFilterField Field; //Field offset: 0x10
	[JsonProperty("value")]
	public readonly MongoID Value; //Field offset: 0x18

	public SeasonalPerkItemFilterRule() { }

}

