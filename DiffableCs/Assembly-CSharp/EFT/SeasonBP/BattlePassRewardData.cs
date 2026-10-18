namespace EFT.SeasonBP;

public sealed class BattlePassRewardData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("reward")]
	public readonly PrestigeReward Reward; //Field offset: 0x28
	[JsonProperty("cost")]
	public readonly Dictionary Cost; //Field offset: 0x30
	[JsonProperty("location")]
	public readonly RewardLocation Location; //Field offset: 0x38
	[JsonProperty("imageUrl")]
	public readonly string ImageUrl; //Field offset: 0x48
	[JsonProperty("bigImageUrl")]
	public readonly string BigImageUrl; //Field offset: 0x50

	[JsonConstructor]
	public BattlePassRewardData(MongoID id, IReadOnlyCollection rewards, Dictionary cost, string imageUrl, string bigImageUrl, RewardLocation location) { }

}

