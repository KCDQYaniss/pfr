namespace EFT.Quests;

public sealed class QuestChainsResponse
{
	[JsonProperty("elements")]
	public Dictionary Elements; //Field offset: 0x10

	public QuestChainsResponse() { }

}

