namespace EFT.Hideout;

public sealed class HideoutCustomizationGlobalOffer : HideoutCustomizationOffer
{
	[JsonProperty("itemId")]
	public MongoID ItemId; //Field offset: 0x68

	public HideoutCustomizationGlobalOffer() { }

}

