namespace EFT.SeasonalPerks;

[JsonObject(MemberSerialization::OptIn (1))]
public abstract class SeasonalPerkEffectData`2 : ISeasonalPerkEffectData
{

	protected SeasonalPerkEffectData`2() { }

	public abstract TPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

	private override ISeasonalPerkEffect EFT.SeasonalPerks.ISeasonalPerkEffectData.CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

