namespace EFT;

public struct TimeAndWeatherSettings
{
	[JsonProperty("isRandomTime")]
	public bool IsRandomTime; //Field offset: 0x0
	[JsonProperty("isRandomWeather")]
	public bool IsRandomWeather; //Field offset: 0x1
	[JsonProperty("cloudinessType")]
	public ECloudinessType CloudinessType; //Field offset: 0x4
	[JsonProperty("rainType")]
	public ERainType RainType; //Field offset: 0x8
	[JsonProperty("windType")]
	public EWindSpeed WindType; //Field offset: 0xC
	[JsonProperty("fogType")]
	public EFogType FogType; //Field offset: 0x10
	[JsonProperty("timeFlowType")]
	public ETimeFlowType TimeFlowType; //Field offset: 0x14
	[JsonProperty("hourOfDay")]
	public int HourOfDay; //Field offset: 0x18

	public TimeAndWeatherSettings(bool randomTime, bool randomWeather, int cloudinessType, int rainType, int windSpeed, int fogType, int timeFlowType, int hourOfDay = -1) { }

}

