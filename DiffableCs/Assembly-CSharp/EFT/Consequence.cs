namespace EFT;

public sealed class Consequence
{
	[JsonProperty("index")]
	public int Index; //Field offset: 0x10
	[JsonProperty("viewId")]
	public string ViewId; //Field offset: 0x18
	[JsonProperty("localizationKeyCaptionPVP")]
	public string LocalizationKeyCaptionPVP; //Field offset: 0x20
	[JsonProperty("localizationKeyCaptionPVE")]
	public string LocalizationKeyCaptionPVE; //Field offset: 0x28

	public Consequence() { }

}

