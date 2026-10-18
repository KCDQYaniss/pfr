namespace EFT.SeasonalPerks;

public sealed class InsuranceDisabledPerkEffectData : SeasonalPerkEffectData
{

	public InsuranceDisabledPerkEffectData() { }

	public virtual InsuranceDisabledPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

