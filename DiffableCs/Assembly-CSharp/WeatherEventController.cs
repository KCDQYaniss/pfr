//Type is in global namespace

public sealed class WeatherEventController : MonoBehaviour
{
	public static WeatherEventController Instance; //Field offset: 0x0
	public const string WEATHER_EVENT = "weatherEvent"; //Field offset: 0x0
	public const int PRAY_ANIMATION_LAYER = 17; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <ChangeTimeInProgress>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <EventActive>k__BackingField; //Field offset: 0x20
	private float _defaultTimeFactor; //Field offset: 0x24
	[CompilerGenerated]
	private int <DesiredHour>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <DesiredMinute>k__BackingField; //Field offset: 0x2C
	public float SecToChange; //Field offset: 0x30
	private DateTime _desiredDateTime; //Field offset: 0x38
	[CompilerGenerated]
	private readonly WeatherNode <DestWeatherNode>k__BackingField; //Field offset: 0x40
	public float currentPercantage; //Field offset: 0x48
	private long _startTicks; //Field offset: 0x50
	private float _defaultUpdateInterval; //Field offset: 0x58

	public private static bool ChangeTimeInProgress
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 65
	}

	public private int DesiredHour
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int DesiredMinute
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public WeatherNode DestWeatherNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool EventActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GameDateTime GameDateTime
	{
		 get { } //Length: 100
	}

	public WeatherEventController() { }

	public void Activate(bool val, int fromPercent = 0, bool force = false) { }

	private void ActivateNow() { }

	private void Awake() { }

	[CompilerGenerated]
	public static bool get_ChangeTimeInProgress() { }

	[CompilerGenerated]
	public int get_DesiredHour() { }

	[CompilerGenerated]
	public int get_DesiredMinute() { }

	[CompilerGenerated]
	public WeatherNode get_DestWeatherNode() { }

	[CompilerGenerated]
	public bool get_EventActive() { }

	public GameDateTime get_GameDateTime() { }

	private void OnDestroy() { }

	[CompilerGenerated]
	private static void set_ChangeTimeInProgress(bool value) { }

	[CompilerGenerated]
	private void set_DesiredHour(int value) { }

	[CompilerGenerated]
	private void set_DesiredMinute(int value) { }

	[CompilerGenerated]
	public void set_EventActive(bool value) { }

	public void SetWeather(WeatherEventSettings weatherSettings) { }

	public void SetWeather(int hours, int minutes, float cloudness, int windDirection, float wind, float rain, float rainRandomness, float scaterringFogDensity, Vector2 topWindDirection) { }

	private void Update() { }

}

