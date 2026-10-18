namespace EFT;

public sealed class WeatherEventSettings
{
	public int Hour; //Field offset: 0x10
	public int Minute; //Field offset: 0x14
	public float Cloudness; //Field offset: 0x18
	public int WindDirection; //Field offset: 0x1C
	public float Wind; //Field offset: 0x20
	public float Rain; //Field offset: 0x24
	public float RainRandomness; //Field offset: 0x28
	public float ScaterringFogDensity; //Field offset: 0x2C
	public Vector2 TopWindDirection; //Field offset: 0x30

	public WeatherEventSettings() { }

}

