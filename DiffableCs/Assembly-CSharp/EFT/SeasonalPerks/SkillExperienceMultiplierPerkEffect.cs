namespace EFT.SeasonalPerks;

public sealed class SkillExperienceMultiplierPerkEffect : SeasonalPassivePerkEffect
{

	public SkillExperienceMultiplierPerkEffect(SkillExperienceMultiplierPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

