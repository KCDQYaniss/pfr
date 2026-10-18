namespace EFT.SeasonalPerks;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkBodyPartType>))]
public enum EPerkBodyPartType
{
	Arms = 0,
	Legs = 1,
}

