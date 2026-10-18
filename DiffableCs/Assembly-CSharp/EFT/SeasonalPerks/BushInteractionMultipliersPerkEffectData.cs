namespace EFT.SeasonalPerks;

public sealed class BushInteractionMultipliersPerkEffectData : SeasonalPerkEffectData
{
	[JsonProperty("multiplicatorPrimary")]
	public readonly float MultiplierPrimary; //Field offset: 0x10
	[JsonProperty("multiplicatorSecondary")]
	public readonly float MultiplierSecondary; //Field offset: 0x14

	public BushInteractionMultipliersPerkEffectData() { }

	public virtual BushInteractionMultipliersPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

