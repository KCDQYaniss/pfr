namespace EFT.SeasonalPerks;

public sealed class InsuranceDisabledPerkEffect : SeasonalPassivePerkEffect
{

	public InsuranceDisabledPerkEffect(InsuranceDisabledPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

