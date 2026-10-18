namespace Audio.AudioWeatherSystem;

public class WeatherAmbientContainer
{
	[SerializeField]
	private DayTimeAmbientSeasonClips _soundsByWeather; //Field offset: 0x10

	public WeatherAmbientContainer() { }

	public bool TryGetDayTimeSoundContainer(ESeasonStatus status, out DayTimeAmbientSoundContainer soundContainer) { }

}

