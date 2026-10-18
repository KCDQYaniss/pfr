namespace EFT.SeasonalPerks;

public sealed class EnergyDrainMultiplierPerkEffect : SeasonalPassivePerkEffect
{

	public EnergyDrainMultiplierPerkEffect(EnergyDrainMultiplierPerkEffectData template, ISeasonalPerk parent) { }

	public virtual bool TryApply(PerkRuntimeState state) { }

}

