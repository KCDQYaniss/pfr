namespace EFT.Weather;

public sealed class WeatherSerializer : ISerializer
{
	public string time; //Field offset: 0x10
	public float cloud; //Field offset: 0x18
	public float wind_speed; //Field offset: 0x1C
	public int wind_direction; //Field offset: 0x20
	public float wind_gustiness; //Field offset: 0x24
	public float rain; //Field offset: 0x28
	public float rain_intensity; //Field offset: 0x2C
	public float fog; //Field offset: 0x30
	public float fogHeight; //Field offset: 0x34
	public float temp; //Field offset: 0x38
	public float pressure; //Field offset: 0x3C
	public float MainWindPositionX; //Field offset: 0x40
	public float MainWindPositionY; //Field offset: 0x44
	public float MainWindDirectionX; //Field offset: 0x48
	public float MainWindDirectionY; //Field offset: 0x4C
	public float TopWindPositionX; //Field offset: 0x50
	public float TopWindPositionY; //Field offset: 0x54
	public float TopWindDirectionX; //Field offset: 0x58
	public float TopWindDirectionY; //Field offset: 0x5C
	public float LyingWater; //Field offset: 0x60

	public WeatherSerializer() { }

	public override WeatherNode Deserialize() { }

	public override object Serialize(WeatherNode t) { }

	public virtual string ToString() { }

}

