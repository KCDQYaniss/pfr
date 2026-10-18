namespace EFT;

[GenerateBinarySerialization]
public sealed class DroppedItem
{
	[JsonProperty("QuestId")]
	public string QuestId; //Field offset: 0x10
	[JsonProperty("ItemId")]
	public MongoID ItemId; //Field offset: 0x18
	[JsonProperty("ZoneId")]
	public string ZoneId; //Field offset: 0x30

	public DroppedItem() { }

	public DroppedItem(string questId, string itemId, string zoneId) { }

	public bool Equals(string[] itemIds, string zoneId, string questId) { }

	public bool Equals(string[] itemIds, string[] zoneIds, string questId) { }

}

