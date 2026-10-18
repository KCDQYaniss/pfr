namespace EFT.Weather;

public class WeatherNode
{
	public static readonly Vector2[] WindDirections; //Field offset: 0x0
	public long Time; //Field offset: 0x10
	public float Cloudness; //Field offset: 0x18
	public float Wind; //Field offset: 0x1C
	public int WindDirection; //Field offset: 0x20
	public float Turbulence; //Field offset: 0x24
	public float Rain; //Field offset: 0x28
	public float RainRandomness; //Field offset: 0x2C
	public float ScaterringFogDensity; //Field offset: 0x30
	public float ScaterringFogHeight; //Field offset: 0x34
	public float GlobalFogDensity; //Field offset: 0x38
	public float GlobalFogHeight; //Field offset: 0x3C
	public float Temperature; //Field offset: 0x40
	public float AtmospherePressure; //Field offset: 0x44
	public Vector2 MainWindPosition; //Field offset: 0x48
	public Vector2 MainWindDirection; //Field offset: 0x50
	public Vector2 TopWindPosition; //Field offset: 0x58
	public Vector2 TopWindDirection; //Field offset: 0x60
	public float LyingWater; //Field offset: 0x68

	private static WeatherNode() { }

	public WeatherNode() { }

	public static WeatherNode CreateDefault() { }

	public static WeatherNode[] GetFineTestWeatherNodes() { }

	private static WeatherNode GetFineWeatherNode(DateTime dateTime) { }

	public static WeatherNode GetHalloweenWeatherNode(int secDuration) { }

	public static WeatherNode[] GetRandomTestWeatherNodes(int nodeDurationSeconds = 600, int nodeCount = 12) { }

	private static WeatherNode GetRandomWeatherNode(DateTime dateTime) { }

	private static WeatherNode GetTestWeatherNode(DateTime dateTime) { }

	public EWeatherType GetWeatherTypeByNode() { }

	public virtual string ToString() { }

}

