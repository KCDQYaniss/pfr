namespace JsonType;

public class GameServer
{
	[JsonProperty("ip")]
	public string Address; //Field offset: 0x10
	[JsonProperty("port")]
	public string Port; //Field offset: 0x18

	public GameServer() { }

}

