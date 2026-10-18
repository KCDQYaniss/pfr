namespace JsonType;

public sealed class GameServerPing : GameServer
{
	[JsonProperty("ping")]
	public int Ping; //Field offset: 0x20

	public GameServerPing() { }

}

