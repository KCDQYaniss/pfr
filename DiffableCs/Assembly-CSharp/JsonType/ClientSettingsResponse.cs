namespace JsonType;

public class ClientSettingsResponse
{
	[JsonProperty("config")]
	public ClientSettingsConfig ClientSettings; //Field offset: 0x10

	public ClientSettingsResponse() { }

}

