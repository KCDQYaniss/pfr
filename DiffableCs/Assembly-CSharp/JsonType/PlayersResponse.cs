namespace JsonType;

public sealed class PlayersResponse
{
	[JsonProperty("summoned")]
	public SummonedProfile[] Summoned; //Field offset: 0x10
	[JsonProperty("leaved")]
	public string[] Leaved; //Field offset: 0x18
	[JsonProperty("gameDate")]
	public string Date; //Field offset: 0x20
	[JsonProperty("gameTime")]
	public string Time; //Field offset: 0x28
	[JsonProperty("gameTimeAcceleration")]
	public float Acceleration; //Field offset: 0x30
	[JsonProperty("halloweenEvent")]
	public HalloweenEventResponse HalloweenEvent; //Field offset: 0x38
	[JsonProperty("season")]
	public ESeason Season; //Field offset: 0x40
	[JsonProperty("event")]
	public AirdropEventResponse AirdropEvent; //Field offset: 0x48
	[JsonProperty("excludedBosses")]
	public string[] excludedBosses; //Field offset: 0x50

	public PlayersResponse() { }

}

