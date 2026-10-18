namespace EFT.SeasonalPerks;

public sealed class CraftTimeMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public CraftTimeMultiplierPerkEffectData() { }

	public virtual CraftTimeMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

