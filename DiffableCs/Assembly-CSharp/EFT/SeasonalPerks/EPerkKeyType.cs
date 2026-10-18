namespace EFT.SeasonalPerks;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.SeasonalPerks.EPerkKeyType>))]
public enum EPerkKeyType
{
	Mechanical = 0,
	Electronic = 1,
}

