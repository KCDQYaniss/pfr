namespace EFT;

internal sealed class LocalGame : BaseLocalGame, IBotGame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__20_0; //Field offset: 0x10
		public static Func <>9__20_1; //Field offset: 0x18
		public static Func <>9__20_2; //Field offset: 0x20
		public static Func <>9__20_3; //Field offset: 0x28
		public static Func <>9__21_0; //Field offset: 0x30
		public static Func <>9__21_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal WildSpawnWave <Create>b__0_0(WildSpawnWave w) { }

		internal float <CreateBotByProfile>b__21_0() { }

		internal float <CreateBotByProfile>b__21_1() { }

		internal int <ModifyBossWaveSettings>b__20_0(int x) { }

		internal int <ModifyBossWaveSettings>b__20_1(int x) { }

		internal int <ModifyBossWaveSettings>b__20_2(int x) { }

		internal int <ModifyBossWaveSettings>b__20_3(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public LocalGame game; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal Task <Create>b__1(SpawnWave wave) { }

		internal void <Create>b__2(BossLocationSpawn bossWave) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Task musicTask; //Field offset: 0x10
		public Task task; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal bool <SessionRun>b__0() { }

		internal bool <SessionRun>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_1
	{
		public Task weather; //Field offset: 0x10

		public <>c__DisplayClass14_1() { }

		internal bool <SessionRun>b__2() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__Parse; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <CreateBotByProfile>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public Profile profile; //Field offset: 0x28
		public Vector3 position; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <InitSessionUI>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LocalGame <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InitSessionUI>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <LocalBotsControllerInitialization>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public BotControllerSettings controllerSettings; //Field offset: 0x28
		public ISpawnSystem spawnSystem; //Field offset: 0x40
		private BotProfileClient <profileCreator>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalBotsSpawnInitialization>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SessionRun>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LocalGame <>4__this; //Field offset: 0x20
		private <>c__DisplayClass14_1 <>8__1; //Field offset: 0x28
		private <>c__DisplayClass14_0 <>8__2; //Field offset: 0x30
		public Action runCallback; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SessionRun>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ShowCountdown>d__16 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LocalGame <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ShowCountdown>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ShowIntroVideo>d__17 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public LocalGame <>4__this; //Field offset: 0x20
		private MatchmakerIntroVideoScreenController <introVideoScreenController>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ShowIntroVideo>d__17(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private BossSpawnScenario _bossSpawnScenario; //Field offset: 0x150
	private WavesSpawnScenario _wavesSpawnScenario; //Field offset: 0x158
	private NonWavesSpawnScenario _nonWavesSpawnScenario; //Field offset: 0x160
	private readonly Dictionary _bots; //Field offset: 0x168

	public override BossSpawnScenario BossSpawnScenario
	{
		 get { } //Length: 8
	}

	private override BotsController IBotGame.BotsController
	{
		private get { } //Length: 8
	}

	public override IWeatherCurve WeatherCurve
	{
		 get { } //Length: 118
	}

	public LocalGame() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0(Action runCallback) { }

	public virtual void CleanUp() { }

	internal static LocalGame Create(IInputTree inputTree, Profile profile, GameWorld gameWorld, GameDateTime backendDateTime, InsuranceCompany insurance, GameUI gameUI, Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback callback, float fixedDeltaTime, EUpdateQueue updateQueue, IEftSession backEndSession, TimeSpan sessionTime, ClientMetricsEvents metricsEvents, ClientMetricsCollector metricsCollector, LocalRaidSettings raidSettings) { }

	[AsyncStateMachine(typeof(<CreateBotByProfile>d__21))]
	[CanBeNull]
	private Task CreateBotByProfile(GameWorld gw, Profile profile, Vector3 position) { }

	protected virtual void CreateSpawnLogger() { }

	public override BossSpawnScenario get_BossSpawnScenario() { }

	public override IWeatherCurve get_WeatherCurve() { }

	private override BotsController IBotGame.get_BotsController() { }

	[IteratorStateMachine(typeof(<InitSessionUI>d__15))]
	protected virtual IEnumerator InitSessionUI() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<LocalBotsControllerInitialization>d__13))]
	protected virtual Task LocalBotsControllerInitialization(BotControllerSettings controllerSettings, ISpawnSystem spawnSystem) { }

	[AsyncStateMachine(typeof(<LocalBotsSpawnInitialization>d__12))]
	protected virtual Task LocalBotsSpawnInitialization() { }

	private static BossLocationSpawn[] ModifyBossWaveSettings(ELocalMode localRaidMode, WavesSettings wavesSettings, BossLocationSpawn[] bossLocationSpawn) { }

	private static WildSpawnWave[] ModifySettings(WavesSettings wavesSettings, WildSpawnWave[] waves) { }

	[IteratorStateMachine(typeof(<SessionRun>d__14))]
	protected virtual IEnumerator SessionRun(Action runCallback) { }

	[IteratorStateMachine(typeof(<ShowCountdown>d__16))]
	private IEnumerator ShowCountdown() { }

	[IteratorStateMachine(typeof(<ShowIntroVideo>d__17))]
	private IEnumerator ShowIntroVideo() { }

	protected virtual void Spawn() { }

	public virtual void Stop(string profileId, ExitStatus exitStatus, string exitName, float delay = 0) { }

}

