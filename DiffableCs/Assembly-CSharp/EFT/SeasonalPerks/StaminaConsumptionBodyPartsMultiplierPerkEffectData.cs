namespace EFT.SeasonalPerks;

public sealed class StaminaConsumptionBodyPartsMultiplierPerkEffectData : SeasonalPerkBodyPartsEffectData
{
	[JsonProperty("multiplicator")]
	public readonly float Multiplier; //Field offset: 0x18

	public StaminaConsumptionBodyPartsMultiplierPerkEffectData() { }

	public virtual StaminaConsumptionBodyPartsMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

