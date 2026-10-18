namespace EFT.SeasonalPerks;

public sealed class SkillNotGrowingPerkEffect : SeasonalPassivePerkEffect
{

	public SkillNotGrowingPerkEffect(SkillNotGrowingPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

