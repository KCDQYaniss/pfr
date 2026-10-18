namespace EFT.UI;

public sealed class SeasonRankRewardData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("reward")]
	public readonly PrestigeReward Reward; //Field offset: 0x28
	[JsonProperty("location")]
	public readonly RewardLocation Location; //Field offset: 0x30
	[JsonProperty("imageUrl")]
	public readonly string ImageUrl; //Field offset: 0x40

	[JsonConstructor]
	public SeasonRankRewardData(MongoID id, PrestigeReward reward, RewardLocation location, string imageUrl) { }

	public SeasonRankRewardData Copy() { }

}

