namespace EFT.Hideout;

public sealed class ProductionScheme : BaseHideoutScheme
{
	[JsonProperty("endProduct")]
	public MongoID endProduct; //Field offset: 0x50
	[JsonProperty("isEncoded")]
	public bool isEncoded; //Field offset: 0x68

	public ProductionScheme() { }

}

