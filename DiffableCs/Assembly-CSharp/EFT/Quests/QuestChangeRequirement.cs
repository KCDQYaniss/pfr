namespace EFT.Quests;

public struct QuestChangeRequirement
{
	[JsonProperty("changeCost")]
	public QuestChangeCost[] ChangeCosts; //Field offset: 0x0
	[JsonProperty("changeStandingCost")]
	public double ChangeStandingCost; //Field offset: 0x8

}

