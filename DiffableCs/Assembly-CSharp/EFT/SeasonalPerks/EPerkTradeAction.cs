namespace EFT.SeasonalPerks;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkTradeAction>))]
public enum EPerkTradeAction
{
	Buy = 0,
	Sell = 1,
	Repair = 2,
	Insurance = 3,
	Treatment = 4,
}

