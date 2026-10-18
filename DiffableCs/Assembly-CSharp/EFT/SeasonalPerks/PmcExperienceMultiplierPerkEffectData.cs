namespace EFT.SeasonalPerks;

public sealed class PmcExperienceMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public PmcExperienceMultiplierPerkEffectData() { }

	public virtual PmcExperienceMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

