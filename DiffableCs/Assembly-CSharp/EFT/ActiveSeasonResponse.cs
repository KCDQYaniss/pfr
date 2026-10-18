namespace EFT;

public sealed class ActiveSeasonResponse
{
	[JsonProperty("season")]
	public SeasonData Season; //Field offset: 0x10

	public ActiveSeasonResponse() { }

}

