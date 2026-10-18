namespace EFT.Weather;

public static class WeatherEventProvider
{

	public static GameDateTime GameDateTime
	{
		 get { } //Length: 100
	}

	public static GameDateTime get_GameDateTime() { }

	public static void LockWeatherTime() { }

	public static void SetTime(int hour, int minute, out DateTime targetTime) { }

	public static void SetWeather(WeatherNode node, DateTime dateTime, bool updateWeatherTime) { }

	public static void SetWeatherTime(WeatherNode node, int hour, int minute, bool updateWeatherTime = true) { }

	public static void UnlockWeatherTime() { }

}

