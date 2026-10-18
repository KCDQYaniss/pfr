namespace EFT.SeasonalPerks;

public sealed class SkillMaxLevelCapPerkEffect : SeasonalPassivePerkEffect
{

	public SkillMaxLevelCapPerkEffect(SkillMaxLevelCapPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

