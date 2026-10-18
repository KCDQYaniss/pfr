namespace EFT.Expansions;

public sealed class ExpansionsLabelsUpdatedPayload
{
	[JsonProperty("newOffers")]
	public int NewOffersCount; //Field offset: 0x10
	[JsonProperty("freeOffers")]
	public int FreeOffersCount; //Field offset: 0x14
	[JsonProperty("saleOffers")]
	public int SaleOffersCount; //Field offset: 0x18

	public ExpansionsLabelsUpdatedPayload() { }

}

