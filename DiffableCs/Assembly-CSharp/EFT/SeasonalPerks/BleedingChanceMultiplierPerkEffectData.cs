namespace EFT.SeasonalPerks;

public sealed class BleedingChanceMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public BleedingChanceMultiplierPerkEffectData() { }

	public virtual BleedingChanceMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

