namespace JsonType;

[GenerateBinarySerialization]
public sealed class InsuredProfileItems
{
	[JsonProperty("tid")]
	public string TraderId; //Field offset: 0x10
	[JsonProperty("itemId")]
	public string ItemId; //Field offset: 0x18

	public InsuredProfileItems() { }

}

