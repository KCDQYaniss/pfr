namespace EFT;

[GenerateBinarySerialization]
public sealed class AllergyPerkEffectParametersData
{
	[JsonProperty("targetItems", NullValueHandling = NullValueHandling::Ignore (1))]
	public List TargetItems; //Field offset: 0x10

	public AllergyPerkEffectParametersData() { }

}

