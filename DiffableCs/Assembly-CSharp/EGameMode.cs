//Type is in global namespace

[JsonConverter(typeof(EFT.EnumConverter`1<EGameMode>))]
public enum EGameMode
{
	Regular = 0,
	Pve = 1,
	PvpSeason = 2,
}

