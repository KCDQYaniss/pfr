namespace EFT.SeasonalPerks;

public sealed class ItemResourceDrainMultiplierPerkEffectData : SeasonalPerkFilteredMultiplierEffectData
{

	public ItemResourceDrainMultiplierPerkEffectData() { }

	public virtual ItemResourceDrainMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

