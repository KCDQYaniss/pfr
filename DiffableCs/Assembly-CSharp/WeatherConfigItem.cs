//Type is in global namespace

public class WeatherConfigItem
{
	public string id; //Field offset: 0x10
	public bool lockWeather; //Field offset: 0x18
	public bool updateWeatherTime; //Field offset: 0x19
	public WeatherFinalConfig WeatherConfig; //Field offset: 0x20
	public CloudLayer cloudLayer; //Field offset: 0x28

	public WeatherConfigItem() { }

}

