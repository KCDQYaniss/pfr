//Type is in global namespace

public class BossSpawnScenario
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__17_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <SetShuffledPmcBotZones>b__17_0(BossLocationSpawn wave) { }

		internal bool <SetShuffledSeason01Zones>b__16_0(BossLocationSpawn wave) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public BossLocationSpawn wave; //Field offset: 0x10
		public BossSpawnScenario <>4__this; //Field offset: 0x18
		public ITimer timer; //Field offset: 0x20

		public <>c__DisplayClass18_0() { }

		internal void <ActivateWavesAfterGameStarted>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public BossSpawnScenario <>4__this; //Field offset: 0x10
		public BossLocationSpawn wave; //Field offset: 0x18
		public ITimer timer; //Field offset: 0x20
		public Action onEvent; //Field offset: 0x28
		public WorldInteractiveObjectDelegate delActions; //Field offset: 0x30

		public <>c__DisplayClass19_0() { }

		internal void <SubscribeWave>b__0(string eventId) { }

		internal void <SubscribeWave>b__1(string eventId, Vector3 position) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public BossSpawnScenario <>4__this; //Field offset: 0x10
		public BossLocationSpawn wave; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <ActivateWave>b__0() { }

	}

	private readonly List Timers; //Field offset: 0x10
	private Action _spawnBossAction; //Field offset: 0x18
	public readonly List BotsCountProfiles; //Field offset: 0x20
	[CompilerGenerated]
	private BossLocationSpawn[] <BossSpawnWaves>k__BackingField; //Field offset: 0x28
	private BossSpawnsByQuests _questsSpanws; //Field offset: 0x30
	[CompilerGenerated]
	private bool <HaveSectants>k__BackingField; //Field offset: 0x38
	private bool _isSubscribed; //Field offset: 0x39

	public private BossLocationSpawn[] BossSpawnWaves
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool HaveSectants
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BossSpawnScenario() { }

	private bool ActivateByTriggerId(BossLocationSpawn wave, string trgId, ITimer timer) { }

	private void ActivateWave(BossLocationSpawn wave) { }

	private void ActivateWavesAfterGameStarted(BossLocationSpawn wave) { }

	internal static BossSpawnScenario Create(BossLocationSpawn[] bossWaves, Action spawnBossAction) { }

	[CompilerGenerated]
	public BossLocationSpawn[] get_BossSpawnWaves() { }

	[CompilerGenerated]
	public bool get_HaveSectants() { }

	private void Init(BossLocationSpawn[] bossWaves) { }

	public void Run(List pmcZones, List s01Zones, EBotsSpawnMode spawnMode = 0) { }

	[CompilerGenerated]
	private void set_BossSpawnWaves(BossLocationSpawn[] value) { }

	[CompilerGenerated]
	private void set_HaveSectants(bool value) { }

	private void SetShuffledPmcBotZones(List pmcZones) { }

	private void SetShuffledSeason01Zones(List s01Zones) { }

	public void Stop() { }

	private void SubscribeWave(BossLocationSpawn wave, ITimer timer) { }

}

