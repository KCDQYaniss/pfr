namespace EFT.Weather;

public abstract class WeatherCurveBase : IWeatherCurve
{
	protected const float MAX_WIND_DERIVATIVE = 1.0416667E-10; //Field offset: 0x0
	[CompilerGenerated]
	private long <StartTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <FinishTime>k__BackingField; //Field offset: 0x18
	protected AnimationCurve windXCurve; //Field offset: 0x20
	protected AnimationCurve windYCurve; //Field offset: 0x28
	protected AnimationCurve topWindXCurve; //Field offset: 0x30
	protected AnimationCurve topWindYCurve; //Field offset: 0x38
	protected AnimationCurve rainCurve; //Field offset: 0x40
	protected AnimationCurve cloudinessCurve; //Field offset: 0x48
	protected AnimationCurve fogCurve; //Field offset: 0x50
	protected AnimationCurve temperatureCurve; //Field offset: 0x58

	public override float Cloudiness
	{
		 get { } //Length: 169
	}

	protected float CurrentNormalizedTime
	{
		 get { } //Length: 69
	}

	public override float CurrentNormalizedTimeValue
	{
		 get { } //Length: 69
	}

	protected double DurationWeather
	{
		 get { } //Length: 30
	}

	public long FinishTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override float Fog
	{
		 get { } //Length: 213
	}

	public override float LightningThunderProbability
	{
		 get { } //Length: 225
	}

	protected long NowTimeSec
	{
		 get { } //Length: 7
	}

	public override float Rain
	{
		 get { } //Length: 213
	}

	public long StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override float Temperature
	{
		 get { } //Length: 169
	}

	public override Vector2 TopWind
	{
		 get { } //Length: 331
	}

	public override Vector2 Wind
	{
		 get { } //Length: 331
	}

	protected WeatherCurveBase() { }

	private void AddWindNode(long time, float windVal, int windDirection) { }

	protected void ConvertNodes(WeatherNode[] _nodes) { }

	public override float get_Cloudiness() { }

	protected float get_CurrentNormalizedTime() { }

	public override float get_CurrentNormalizedTimeValue() { }

	protected double get_DurationWeather() { }

	[CompilerGenerated]
	public long get_FinishTime() { }

	public override float get_Fog() { }

	public override float get_LightningThunderProbability() { }

	protected long get_NowTimeSec() { }

	public override float get_Rain() { }

	[CompilerGenerated]
	public long get_StartTime() { }

	public override float get_Temperature() { }

	public override Vector2 get_TopWind() { }

	public override Vector2 get_Wind() { }

	private float GetLyingWater(float lyingWater, float rainA, float rainB, float temperatureA, float temperatureB, float transitionLength, float t = 1) { }

	private float Integral(float a, float b, float tl, float t) { }

	private void LinearizeCurve(AnimationCurve curve) { }

	private long NowTimeSecImpl() { }

	private float SampleFog() { }

	[CompilerGenerated]
	protected void set_FinishTime(long value) { }

	[CompilerGenerated]
	protected void set_StartTime(long value) { }

	public static void SetCurveConstant(AnimationCurve curve) { }

	public static void SetCurveLinear(AnimationCurve curve) { }

	public void SetHalloweenWind(int secDuration, int windDirection) { }

	protected void SetWrapMode(WrapMode mode) { }

}

