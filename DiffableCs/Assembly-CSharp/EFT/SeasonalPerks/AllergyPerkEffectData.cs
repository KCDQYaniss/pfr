namespace EFT.SeasonalPerks;

public sealed class AllergyPerkEffectData : SeasonalPerkFilteredEffectData
{
	[JsonProperty("randomSlotCount")]
	public readonly int RandomSlotCount; //Field offset: 0x18
	[JsonProperty("subEffects", NullValueHandling = NullValueHandling::Ignore (1))]
	public readonly SeasonalPerkAllergySubEffects SubEffects; //Field offset: 0x20

	public AllergyPerkEffectData() { }

	public virtual AllergyPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

