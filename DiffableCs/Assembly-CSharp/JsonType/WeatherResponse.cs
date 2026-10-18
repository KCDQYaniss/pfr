namespace JsonType;

public class WeatherResponse
{
	[JsonProperty("season")]
	public ESeason Season; //Field offset: 0x10
	public SeasonsSettings SeasonsSettings; //Field offset: 0x18
	[JsonProperty("weather")]
	public WeatherNode[] Weathers; //Field offset: 0x20

	public WeatherResponse() { }

}

