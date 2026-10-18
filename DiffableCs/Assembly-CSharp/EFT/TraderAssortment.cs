namespace EFT;

public sealed class TraderAssortment : ExchangeRateDTO
{
	[JsonProperty("items")]
	public FlatItem[] Items; //Field offset: 0x18
	[JsonProperty("barter_scheme")]
	public Dictionary BarterScheme; //Field offset: 0x20
	[JsonProperty("loyal_level_items")]
	public Dictionary LoyaltyLevelItems; //Field offset: 0x28
	[JsonProperty("nextResupply")]
	public int NextResupply; //Field offset: 0x30

	public TraderAssortment() { }

}

