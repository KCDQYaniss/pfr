namespace JsonType;

public class LocalServerSettings
{
	[JsonProperty("TraderServerSettings")]
	public TraderServerSettings traderSettings; //Field offset: 0x10
	[JsonProperty("BTRServerSettings")]
	public BTRServerSettings btrSettings; //Field offset: 0x18

	public LocalServerSettings() { }

}

