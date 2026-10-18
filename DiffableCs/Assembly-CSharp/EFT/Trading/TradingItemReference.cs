namespace EFT.Trading;

public struct TradingItemReference
{
	[JsonProperty("Item")]
	public Item Item; //Field offset: 0x0
	[JsonProperty("Count")]
	public int Count; //Field offset: 0x8
	[JsonProperty("SchemeId")]
	public int SchemeId; //Field offset: 0xC

}

