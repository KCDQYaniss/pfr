namespace EFT.Hideout;

public sealed class HideoutCustomizationSlotOffer : HideoutCustomizationOffer
{
	[JsonProperty("slotId")]
	public string SlotId; //Field offset: 0x68
	[JsonProperty("areaTypeId")]
	public EAreaType AreaType; //Field offset: 0x70

	public HideoutCustomizationSlotOffer() { }

}

