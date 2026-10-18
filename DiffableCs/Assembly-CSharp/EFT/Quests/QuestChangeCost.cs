namespace EFT.Quests;

public struct QuestChangeCost
{
	[JsonProperty("templateId")]
	public MongoID TemplateId; //Field offset: 0x0
	[JsonProperty("count")]
	public int Count; //Field offset: 0x18

}

