namespace EFT.SeasonalPerks;

public sealed class BackendOnlyPerkEffectData : SeasonalPerkEffectData
{

	public BackendOnlyPerkEffectData() { }

	public virtual BackendOnlyPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

