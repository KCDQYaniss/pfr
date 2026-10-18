namespace EFT;

[GenerateBinarySerialization]
public sealed class FoundInRaidItem
{
	[JsonProperty("QuestId")]
	public string QuestId; //Field offset: 0x10
	[JsonProperty("ItemId")]
	public MongoID ItemId; //Field offset: 0x18

	public FoundInRaidItem() { }

	public FoundInRaidItem(string questId, string itemId) { }

}

