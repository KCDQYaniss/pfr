namespace EFT.Customization;

public class CustomizationOffer
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	[JsonProperty("suiteId")]
	public string SuiteId; //Field offset: 0x18
	[JsonProperty("externalObtain")]
	public bool ExternalObtain; //Field offset: 0x20
	[JsonProperty("internalObtain")]
	public bool InternalObtain; //Field offset: 0x21
	[JsonProperty("isActive")]
	public bool IsActive; //Field offset: 0x22
	[JsonProperty("requirements")]
	public OfferRequirements Requirements; //Field offset: 0x28
	[JsonProperty("relatedBattlePassSeason")]
	public Nullable RelatedBattlePassSeason; //Field offset: 0x30

	public CustomizationOffer() { }

}

