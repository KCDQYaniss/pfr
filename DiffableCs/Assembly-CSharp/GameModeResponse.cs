//Type is in global namespace

public sealed class GameModeResponse
{
	[JsonProperty("gameMode")]
	public EGameMode GameMode; //Field offset: 0x10
	[JsonProperty("backendUrl")]
	public string BackendUrl; //Field offset: 0x18

	public GameModeResponse() { }

}

