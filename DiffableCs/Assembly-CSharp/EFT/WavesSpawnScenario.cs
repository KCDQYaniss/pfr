namespace EFT;

public sealed class WavesSpawnScenario : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8
		public static Func <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Create>b__13_0(WildSpawnWave x) { }

		internal float <Init>b__15_1(SpawnWave wave) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public WildSpawnType wildSpawnType; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <InitMinMax>b__0(MinMaxBots x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public WildSpawnType type; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal int <CheckMinCounts>b__0(WildSpawnWave x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public SpawnWave spawnWave; //Field offset: 0x10
		public ITimer timer; //Field offset: 0x18
		public WavesSpawnScenario <>4__this; //Field offset: 0x20

		public <>c__DisplayClass17_0() { }

		internal void <Run>b__0() { }

	}

	[CompilerGenerated]
	private struct <Run>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WavesSpawnScenario <>4__this; //Field offset: 0x20
		public EBotsSpawnMode spawnMode; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public BotLocationModifier BotLocationModifier; //Field offset: 0x20
	private readonly List Timers; //Field offset: 0x28
	private Func _spawnAction; //Field offset: 0x30
	private Dictionary _minCounts; //Field offset: 0x38
	public readonly List BotsCountProfiles; //Field offset: 0x40
	[CompilerGenerated]
	private SpawnWave[] <SpawnWaves>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x50

	public private bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private SpawnWave[] SpawnWaves
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public WavesSpawnScenario() { }

	[CompilerGenerated]
	private SpawnWave <Init>b__15_0(WildSpawnWave wave) { }

	private void CheckMinCounts(WildSpawnWave[] waves, WildSpawnType type) { }

	internal static WavesSpawnScenario Create(GameObject game, WildSpawnWave[] waves, Func spawnAction, Location location = null) { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	[CompilerGenerated]
	public SpawnWave[] get_SpawnWaves() { }

	public void Init(WildSpawnWave[] waves) { }

	private static void InitMinMax(Dictionary minCounts, MinMaxBots[] minMaxBots) { }

	[AsyncStateMachine(typeof(<Run>d__17))]
	public Task Run(EBotsSpawnMode spawnMode = 0) { }

	[CompilerGenerated]
	private void set_Enabled(bool value) { }

	[CompilerGenerated]
	private void set_SpawnWaves(SpawnWave[] value) { }

	public void Stop() { }

}

