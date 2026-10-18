namespace EFT;

[GenerateBinarySerialization]
public sealed class SeasonalPerkEffectParametersData
{
	[JsonProperty("allergy", NullValueHandling = NullValueHandling::Ignore (1))]
	public Dictionary Allergy; //Field offset: 0x10

	public SeasonalPerkEffectParametersData() { }

}

