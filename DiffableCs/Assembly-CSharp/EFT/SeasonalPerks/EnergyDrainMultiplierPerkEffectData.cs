namespace EFT.SeasonalPerks;

public sealed class EnergyDrainMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public EnergyDrainMultiplierPerkEffectData() { }

	public virtual EnergyDrainMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

