namespace EFT;

public sealed class SeasonalRewardTemplate
{
	[JsonProperty("id")]
	public MongoID Id; //Field offset: 0x10
	[JsonProperty("seasonId")]
	public MongoID SeasonId; //Field offset: 0x28
	[JsonProperty("conditions")]
	public List Conditions; //Field offset: 0x40
	[JsonProperty("rewards")]
	public PrestigeReward[] Rewards; //Field offset: 0x48
	[JsonProperty("imageUrl")]
	public string ImageUrl; //Field offset: 0x50
	[JsonProperty("bigImageUrl")]
	public string BigImageUrl; //Field offset: 0x58
	[JsonProperty("location")]
	public RewardLocation Location; //Field offset: 0x60

	public string Name
	{
		 get { } //Length: 123
	}

	public string NameLocaleKey
	{
		 get { } //Length: 176
	}

	public SeasonalRewardTemplate() { }

	public string get_Name() { }

	public string get_NameLocaleKey() { }

}

