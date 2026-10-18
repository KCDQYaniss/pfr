namespace EFT.SeasonalPerks;

public sealed class TraderPricesByTraderMultiplierPerkEffectData : SeasonalPerkMultiplierEffectData
{
	[JsonProperty("traderIds", NullValueHandling = NullValueHandling::Ignore (1))]
	public readonly MongoID[] TraderIds; //Field offset: 0x18
	[JsonProperty("tradeAction")]
	public readonly EPerkTradeAction TradeAction; //Field offset: 0x20

	public TraderPricesByTraderMultiplierPerkEffectData() { }

	public virtual TraderPricesByTraderMultiplierPerkEffect CreateEffect(ISeasonalPerk parent, SeasonalPerkEffectParametersData effectParameters) { }

}

