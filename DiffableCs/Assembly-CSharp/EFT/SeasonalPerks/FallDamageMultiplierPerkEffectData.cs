namespace EFT.SeasonalPerks;

public sealed class FallDamageMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public FallDamageMultiplierPerkEffectData() { }

	public virtual FallDamageMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

