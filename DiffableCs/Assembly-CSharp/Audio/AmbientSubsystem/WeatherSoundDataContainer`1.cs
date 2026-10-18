namespace Audio.AmbientSubsystem;

[DefaultMember("Item")]
public class WeatherSoundDataContainer`1 : IEnumerable
{
	[HideInInspector]
	[SerializeField]
	private List _commonWeatherSoundData; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 26
	}

	public WeatherSoundData Item
	{
		 get { } //Length: 64
	}

	public WeatherSoundDataContainer`1() { }

	public void Add(WeatherSoundData weatherData) { }

	public bool CheckDuplicates() { }

	public int get_Count() { }

	public WeatherSoundData get_Item(int i) { }

	public IEnumerator GetEnumerator() { }

	public void Remove(WeatherSoundData weatherData) { }

	public void RemoveAt(int index) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetCurrentWeatherData(EWindSpeed windSpeed, ERainIntensity rainIntensity, out WeatherSoundData weatherData) { }

}

