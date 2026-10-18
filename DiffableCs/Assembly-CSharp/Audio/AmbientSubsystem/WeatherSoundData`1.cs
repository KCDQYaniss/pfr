namespace Audio.AmbientSubsystem;

public class WeatherSoundData`1 : IEquatable
{
	public bool includeWindSpeed; //Field offset: 0x0
	public EWindSpeed windSpeed; //Field offset: 0x0
	public bool includeRainIntensity; //Field offset: 0x0
	public ERainIntensity rainIntensity; //Field offset: 0x0
	public Vector2 randomDelayRange; //Field offset: 0x0
	public T soundContent; //Field offset: 0x0

	public WeatherSoundData`1() { }

	public override bool Equals(WeatherSoundData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

