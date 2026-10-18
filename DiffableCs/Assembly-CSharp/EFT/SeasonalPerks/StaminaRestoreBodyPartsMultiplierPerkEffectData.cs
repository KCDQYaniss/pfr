namespace EFT.SeasonalPerks;

public sealed class StaminaRestoreBodyPartsMultiplierPerkEffectData : SeasonalPerkBodyPartsEffectData
{
	[JsonProperty("multiplicator")]
	public readonly float Multiplier; //Field offset: 0x18

	public StaminaRestoreBodyPartsMultiplierPerkEffectData() { }

	public virtual StaminaRestoreBodyPartsMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

