namespace EFT.SeasonalPerks;

public sealed class SkillExperienceMultiplierPerkEffectData : SeasonalPerkSkillMultiplierEffectData
{

	public SkillExperienceMultiplierPerkEffectData() { }

	public virtual SkillExperienceMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

