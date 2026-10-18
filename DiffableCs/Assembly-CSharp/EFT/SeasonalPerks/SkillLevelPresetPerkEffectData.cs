namespace EFT.SeasonalPerks;

public sealed class SkillLevelPresetPerkEffectData : SeasonalPerkSkillIntValueEffectData
{

	public SkillLevelPresetPerkEffectData() { }

	public virtual SkillLevelPresetPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

