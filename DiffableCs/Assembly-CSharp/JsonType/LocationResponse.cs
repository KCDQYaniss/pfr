namespace JsonType;

public sealed class LocationResponse : WeatherResponse
{
	[JsonProperty("location")]
	public Location Location; //Field offset: 0x28

	public LocationResponse() { }

}

