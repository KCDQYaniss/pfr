namespace JsonType;

[Obfuscation(Exclude = True)]
public class LocationWeatherTime
{
	[JsonProperty("season")]
	public ESeason Season; //Field offset: 0x10
	public SeasonsSettings SeasonsSettings; //Field offset: 0x18
	[JsonProperty("weather")]
	public WeatherNode Weather; //Field offset: 0x20
	[JsonProperty("acceleration")]
	public float Acceleration; //Field offset: 0x28
	[JsonProperty("date")]
	public string Date; //Field offset: 0x30
	[JsonProperty("time")]
	public string Time; //Field offset: 0x38

	public LocationWeatherTime(WeatherNode node, float acceleration, string date, string time) { }

	public static LocationWeatherTime CreateDefault() { }

}

