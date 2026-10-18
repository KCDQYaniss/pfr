namespace EFT.SeasonBP;

public sealed class BattlePassPageData
{
	[JsonProperty("rewards")]
	public readonly IReadOnlyList Rewards; //Field offset: 0x10
	[JsonProperty("prevPageItemsRequirement")]
	public readonly int PrevPageItemsRequirement; //Field offset: 0x18

	[JsonConstructor]
	public BattlePassPageData(IReadOnlyList rewards, int prevPageItemsRequirement) { }

}

