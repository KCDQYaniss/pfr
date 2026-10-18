namespace EFT;

public sealed class CutscenesGlobalConfig
{
	[JsonProperty("EvacuateTime")]
	public int EvacuateTime; //Field offset: 0x10
	[JsonProperty("WaitingRoomTime")]
	public int WaitingRoomTime; //Field offset: 0x14
	[JsonProperty("SeatsRandom")]
	public Vector2 SeatsRandom; //Field offset: 0x18
	[JsonProperty("MinPlayersToEvac")]
	public int MinPlayersToEvac; //Field offset: 0x20
	[JsonProperty("TimeOutTimer")]
	public int TimeOutTimer; //Field offset: 0x24
	[JsonProperty("FinalCutscenesByQuest")]
	public CutsceneVariant[] FinalCutscenesByQuest; //Field offset: 0x28
	[JsonProperty("LagTimeCompensation")]
	public float LagTimeCompensation; //Field offset: 0x30
	[JsonProperty("WeatherConfig")]
	public WeatherFinalConfig WeatherConfig; //Field offset: 0x38

	public CutscenesGlobalConfig() { }

}

