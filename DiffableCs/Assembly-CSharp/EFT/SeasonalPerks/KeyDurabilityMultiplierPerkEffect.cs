namespace EFT.SeasonalPerks;

public sealed class KeyDurabilityMultiplierPerkEffect : SeasonalPassivePerkEffect
{

	public KeyDurabilityMultiplierPerkEffect(KeyDurabilityMultiplierPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

