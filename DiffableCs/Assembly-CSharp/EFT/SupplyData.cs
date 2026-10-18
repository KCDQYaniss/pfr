namespace EFT;

public sealed class SupplyData : IBasePriceSource
{
	[JsonProperty("supplyNextTime")]
	public int SupplyNextTime; //Field offset: 0x10
	[JsonProperty("prices")]
	public Dictionary MarketPrices; //Field offset: 0x18
	[JsonProperty("currencyCourses")]
	public Dictionary CurrencyCourses; //Field offset: 0x20

	public SupplyData() { }

	public override double GetBasePrice(MongoID itemId) { }

}

