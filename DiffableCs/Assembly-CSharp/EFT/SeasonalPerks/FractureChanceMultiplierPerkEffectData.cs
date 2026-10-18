namespace EFT.SeasonalPerks;

public sealed class FractureChanceMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{

	public FractureChanceMultiplierPerkEffectData() { }

	public virtual FractureChanceMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

