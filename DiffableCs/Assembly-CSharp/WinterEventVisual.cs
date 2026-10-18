//Type is in global namespace

public sealed class WinterEventVisual : MonoBehaviour, IWinterEventVisual
{
	[CompilerGenerated]
	private struct <CloudsSetup>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WeatherDebug weather; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <cloudDensity>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FogSetup>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WeatherDebug weather; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <fog>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpaquenessSetup>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public RainController rainController; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <opaqueness>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SnowFlakesSetup>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WeatherDebug weather; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <snowFlakes>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SnowFlakesSideSpeedSetup>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float delaySeconds; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public RainController rainController; //Field offset: 0x30
		public float incrementSeconds; //Field offset: 0x38
		public float maximum; //Field offset: 0x3C
		private float <time>5__2; //Field offset: 0x40
		private float <sideSpeed>5__3; //Field offset: 0x44
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SnowySetup>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public RainController rainController; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <wetting>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StormSetup>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WeatherDebug weather; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WindSetup>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WinterEventVisual <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WeatherDebug weather; //Field offset: 0x30
		private float <incrementSeconds>5__2; //Field offset: 0x38
		private float <time>5__3; //Field offset: 0x3C
		private float <windMagnitude>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public WeatherObstacle WinterWeatherObstacle; //Field offset: 0x20
	[Range(0, 1)]
	public float WIND_MAX; //Field offset: 0x28
	[Range(0, 1)]
	public float CLOUDS_MAX; //Field offset: 0x2C
	[Range(0, 0.255)]
	public float FOG_MAX; //Field offset: 0x30
	[Range(0, 1)]
	public float SNOW_FLAKES_MAX; //Field offset: 0x34
	[Range(0, 1)]
	public float SNOWY_MAX; //Field offset: 0x38
	public Vector2 Common; //Field offset: 0x3C
	public Vector2 Wind; //Field offset: 0x44
	public Vector2 Clouds; //Field offset: 0x4C
	public Vector2 Fog; //Field offset: 0x54
	public Vector2 SnowFlakes; //Field offset: 0x5C
	public Vector2 Snowy; //Field offset: 0x64
	public Vector2 Opaqueness; //Field offset: 0x6C
	public float SnowFlakesSideSpeedIncrementSeconds; //Field offset: 0x74
	public float SnowFlakesSideSpeedMaximum; //Field offset: 0x78
	private Task _task; //Field offset: 0x80
	private CancellationTokenSource _cancellationTokenSource; //Field offset: 0x88

	private override WeatherObstacle IWinterEventVisual.WinterWeatherObstacle
	{
		private get { } //Length: 5
	}

	private float Max
	{
		private get { } //Length: 6
	}

	private float Min
	{
		private get { } //Length: 6
	}

	private static AbstractLogger WinterLogger
	{
		private get { } //Length: 7
	}

	public WinterEventVisual() { }

	[AsyncStateMachine(typeof(<CloudsSetup>d__34))]
	private Task CloudsSetup(WeatherDebug weather, CancellationToken token) { }

	[AsyncStateMachine(typeof(<FogSetup>d__35))]
	private Task FogSetup(WeatherDebug weather, CancellationToken token) { }

	private float get_Max() { }

	private float get_Min() { }

	private static AbstractLogger get_WinterLogger() { }

	private static WeatherDebug InitWeather() { }

	private override WeatherObstacle IWinterEventVisual.get_WinterWeatherObstacle() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<OpaquenessSetup>d__39))]
	private Task OpaquenessSetup(RainController rainController, CancellationToken token) { }

	private void Register(ISeasonsController controller) { }

	[AsyncStateMachine(typeof(<SnowFlakesSetup>d__36))]
	private Task SnowFlakesSetup(WeatherDebug weather, CancellationToken token) { }

	[AsyncStateMachine(typeof(<SnowFlakesSideSpeedSetup>d__37))]
	private static Task SnowFlakesSideSpeedSetup(RainController rainController, float delaySeconds, float incrementSeconds, float maximum, CancellationToken token) { }

	[AsyncStateMachine(typeof(<SnowySetup>d__38))]
	private Task SnowySetup(RainController rainController, CancellationToken token) { }

	private void Start() { }

	public override void StormSetup() { }

	[AsyncStateMachine(typeof(<StormSetup>d__32))]
	private Task StormSetup(WeatherDebug weather, CancellationToken token) { }

	public override void StormSetupOnReconnect() { }

	private void StormSetupOnReconnect(WeatherDebug weather) { }

	[AsyncStateMachine(typeof(<WindSetup>d__33))]
	private Task WindSetup(WeatherDebug weather, CancellationToken token) { }

}

