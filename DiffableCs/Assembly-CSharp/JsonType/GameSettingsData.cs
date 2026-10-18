namespace JsonType;

public class GameSettingsData
{
	[JsonProperty("gameDate")]
	public string Date; //Field offset: 0x10
	[JsonProperty("gameTime")]
	public string Time; //Field offset: 0x18
	[JsonProperty("gameTimeAcceleration")]
	public float Acceleration; //Field offset: 0x20

	public GameSettingsData() { }

}

