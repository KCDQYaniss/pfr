namespace EFT.SeasonalPerks;

public sealed class HydrationDrainMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public HydrationDrainMultiplierPerkEffectData() { }

	public virtual HydrationDrainMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

