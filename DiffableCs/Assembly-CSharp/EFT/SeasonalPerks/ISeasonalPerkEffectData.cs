namespace EFT.SeasonalPerks;

[JsonConverter(typeof(SeasonalPerkEffectJsonConverter))]
public interface ISeasonalPerkEffectData
{

	public ISeasonalPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

