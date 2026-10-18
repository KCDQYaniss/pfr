namespace EFT.Weather;

public class WeatherDebug : IWeatherCurve
{
	internal enum Direction
	{
		East = 1,
		North = 2,
		West = 3,
		South = 4,
		SE = 5,
		SW = 6,
		NW = 7,
		NE = 8,
	}

	private static WeatherDebug cachedWeather; //Field offset: 0x0
	[SerializeField]
	private bool isEnabled; //Field offset: 0x10
	public bool IsDynamicSunWeatherDebug; //Field offset: 0x11
	[Range(0, 1)]
	public float WindMagnitude; //Field offset: 0x14
	public Direction WindDirection; //Field offset: 0x18
	public Vector2 TopWindDirection; //Field offset: 0x1C
	[Range(-1, 1)]
	public float CloudDensity; //Field offset: 0x24
	[Range(0, 0.005)]
	public float Fog; //Field offset: 0x28
	[Range(0, 1)]
	public float Rain; //Field offset: 0x2C
	[Range(0, 1)]
	public float LightningThunderProbability; //Field offset: 0x30
	[Range(-50, 50)]
	public float Temperature; //Field offset: 0x34
	public bool DebugMieMultiplier; //Field offset: 0x38
	[Range(0, 10)]
	public float MieMultiplier; //Field offset: 0x3C
	public bool MBOITFog; //Field offset: 0x40
	public bool DebugMBOITFog; //Field offset: 0x41
	public Color MBOITScatterColorMultiplier; //Field offset: 0x44
	public float MBOITScatterDensityMultiplier; //Field offset: 0x54
	public float MBOITScatterDensityPower; //Field offset: 0x58
	public float ScatterDensityBias; //Field offset: 0x5C
	[Range(0, 1)]
	public float ScatterGreyscale; //Field offset: 0x60
	[Range(0.0001, 0.5)]
	public float MBOITScatterSlicesFar; //Field offset: 0x64
	public float MBOITScatterSlicesDistributionExp; //Field offset: 0x68
	public float MBOITFogSoftScale; //Field offset: 0x6C
	public float MBOITFogSoftPower; //Field offset: 0x70
	[SerializeField]
	internal TOD_CycleParameters Date; //Field offset: 0x78

	public override float CurrentNormalizedTimeValue
	{
		 get { } //Length: 4
	}

	private override float EFT.Weather.IWeatherCurve.Cloudiness
	{
		private get { } //Length: 6
	}

	private override float EFT.Weather.IWeatherCurve.Fog
	{
		private get { } //Length: 6
	}

	private override float EFT.Weather.IWeatherCurve.LightningThunderProbability
	{
		private get { } //Length: 6
	}

	private override float EFT.Weather.IWeatherCurve.Rain
	{
		private get { } //Length: 6
	}

	private override float EFT.Weather.IWeatherCurve.Temperature
	{
		private get { } //Length: 6
	}

	private override Vector2 EFT.Weather.IWeatherCurve.TopWind
	{
		private get { } //Length: 19
	}

	private override Vector2 EFT.Weather.IWeatherCurve.Wind
	{
		private get { } //Length: 142
	}

	public bool Enabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public WeatherDebug() { }

	private WeatherDebug Clone(WeatherDebug from) { }

	public void CopyParams(WeatherDebug from) { }

	public void CopyParams(IWeatherCurve curve) { }

	private override float EFT.Weather.IWeatherCurve.get_Cloudiness() { }

	private override float EFT.Weather.IWeatherCurve.get_Fog() { }

	private override float EFT.Weather.IWeatherCurve.get_LightningThunderProbability() { }

	private override float EFT.Weather.IWeatherCurve.get_Rain() { }

	private override float EFT.Weather.IWeatherCurve.get_Temperature() { }

	private override Vector2 EFT.Weather.IWeatherCurve.get_TopWind() { }

	private override Vector2 EFT.Weather.IWeatherCurve.get_Wind() { }

	public override float get_CurrentNormalizedTimeValue() { }

	public bool get_Enabled() { }

	public float GetHour() { }

	public void LoadPreset() { }

	public void SavePreset() { }

	public void set_Enabled(bool value) { }

	public void SetHour(float hour) { }

}

