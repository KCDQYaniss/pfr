namespace EFT;

public sealed class ArenaEftTransferItem
{
	[JsonProperty("Id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("TemplateId")]
	public string TemplateId; //Field offset: 0x18
	[JsonProperty("Count")]
	public int Count; //Field offset: 0x20

	public ArenaEftTransferItem(Item item) { }

}

