namespace JsonType;

public class LocalSettings
{
	[JsonProperty("serverId")]
	public string serverId; //Field offset: 0x10
	[JsonProperty("serverSettings")]
	public LocalServerSettings settings; //Field offset: 0x18
	[JsonProperty("profile")]
	public ProfileInsurance profileInsurance; //Field offset: 0x20
	[JsonProperty("locationLoot")]
	public Location locationLoot; //Field offset: 0x28
	[JsonProperty("excludedBosses")]
	public string[] excludedBosses; //Field offset: 0x30
	[JsonProperty("transition")]
	public TransitSettings transitionSettings; //Field offset: 0x38

	public LocalSettings() { }

}

