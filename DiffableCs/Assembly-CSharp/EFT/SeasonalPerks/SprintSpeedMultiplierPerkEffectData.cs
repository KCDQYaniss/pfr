namespace EFT.SeasonalPerks;

public sealed class SprintSpeedMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public SprintSpeedMultiplierPerkEffectData() { }

	public virtual SprintSpeedMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

