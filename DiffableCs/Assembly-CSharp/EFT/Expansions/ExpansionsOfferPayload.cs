namespace EFT.Expansions;

public sealed class ExpansionsOfferPayload
{
	[JsonProperty("offerId")]
	public string OfferId; //Field offset: 0x10
	[JsonProperty("bonusTypes")]
	public EBonusType[] BonusTypes; //Field offset: 0x18

	public ExpansionsOfferPayload() { }

}

