//Type is in global namespace

public class BotBossSpawn
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8
		public static Func <>9__16_1; //Field offset: 0x10
		public static Func <>9__16_2; //Field offset: 0x18
		public static Func <>9__21_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__16_0(BotZone x) { }

		internal bool <.ctor>b__16_1(BotZone x) { }

		internal bool <.ctor>b__16_2(BotZone x) { }

		internal string <TrySpawn>b__21_0(BotZone zone) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public BotBossSpawn <>4__this; //Field offset: 0x10
		public BossSpawnProcess spawnProcessData; //Field offset: 0x18
		public BotCreationData creationData; //Field offset: 0x20
		public BotZone botZone; //Field offset: 0x28
		public int followersCount; //Field offset: 0x30
		public BotSpawnParams spawnParams; //Field offset: 0x38
		public BossLocationSpawn wave; //Field offset: 0x40
		public EPlayerSide side; //Field offset: 0x48
		public List openedPositions; //Field offset: 0x50

		public <>c__DisplayClass24_0() { }

		internal void <SpawnBossAndFollowers>b__0(BotOwner owner) { }

		internal void <SpawnBossAndFollowers>g__OnBossSpawn|1(BotOwner botBoss) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_1
	{
		public BotOwner owner; //Field offset: 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass24_1() { }

		internal void <SpawnBossAndFollowers>g__BotStateChange|2(EBotState state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_2
	{
		public BotOwner botBoss; //Field offset: 0x10
		public <>c__DisplayClass24_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass24_2() { }

		internal void <SpawnBossAndFollowers>g__BotStateChange|3(EBotState state) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public GetProfileDataParams data; //Field offset: 0x10
		public int followers; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass28_0() { }

		internal void <SpawnBossMain>b__0(BotOwner ownerBoss) { }

	}

	[CompilerGenerated]
	private struct <Spawn>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossLocationSpawn wave; //Field offset: 0x20
		public BotBossSpawn <>4__this; //Field offset: 0x28
		public BotCreationData data; //Field offset: 0x30
		public BotSpawnParams spawnParams; //Field offset: 0x38
		private BotDifficulty <difficulty>5__2; //Field offset: 0x40
		private int <followersCount>5__3; //Field offset: 0x44
		private bool <canSpawnByMax>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBossAndFollowers>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotBossSpawn <>4__this; //Field offset: 0x20
		public BotCreationData creationData; //Field offset: 0x28
		public BotZone botZone; //Field offset: 0x30
		public int followersCount; //Field offset: 0x38
		public BotSpawnParams spawnParams; //Field offset: 0x40
		public BossLocationSpawn wave; //Field offset: 0x48
		public List openedPositions; //Field offset: 0x50
		private <>c__DisplayClass24_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBossMain>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GetProfileDataParams data; //Field offset: 0x20
		public int followers; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		public ISpawnPoint point; //Field offset: 0x38
		public BotBossSpawn <>4__this; //Field offset: 0x40
		public BotZone ss; //Field offset: 0x48
		public BotCreationData creationData; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBossSupports>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossLocationSpawn wave; //Field offset: 0x20
		public int followersCount; //Field offset: 0x28
		public BotBossSpawn <>4__this; //Field offset: 0x30
		public BotCreationData bossCreationData; //Field offset: 0x38
		public BotZone zone; //Field offset: 0x40
		public EPlayerSide side; //Field offset: 0x48
		public BotSpawnParams spawnParams; //Field offset: 0x50
		public List pointsToSpawn; //Field offset: 0x58
		public bool forceSpawn; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnEscort>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossLocationSpawn wave; //Field offset: 0x20
		public List pointsToSpawn; //Field offset: 0x28
		public List escorts; //Field offset: 0x30
		public EPlayerSide side; //Field offset: 0x38
		public BotSpawnParams spawnParams; //Field offset: 0x40
		public BotBossSpawn <>4__this; //Field offset: 0x48
		public BotZone zone; //Field offset: 0x50
		public bool forceSpawn; //Field offset: 0x58
		private Enumerator <>7__wrap1; //Field offset: 0x60
		private List <pointForType>5__3; //Field offset: 0x78
		private TaskAwaiter <>u__1; //Field offset: 0x80
		private YieldAwaiter <>u__2; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class BossSpawnProcess
	{
		public readonly BossLocationSpawn Wave; //Field offset: 0x10
		public readonly BotZone BotZone; //Field offset: 0x18
		public readonly ISpawnPoint PotentialSpawnPoint; //Field offset: 0x20

		public BossSpawnProcess(BossLocationSpawn wave, BotZone botZone, ISpawnPoint bossPoint) { }

	}

	private const float DELAY_BOSS_CHECK_TIME = 20; //Field offset: 0x0
	public readonly List AvailableZonesPmc; //Field offset: 0x10
	public readonly List AvailableZonesSeason01; //Field offset: 0x18
	private readonly List _spawnProcess; //Field offset: 0x20
	private readonly BotSpawner _spawner; //Field offset: 0x28
	private readonly ISpawnSystem _spawnSystem; //Field offset: 0x30
	private readonly List _availableZones; //Field offset: 0x38
	private readonly BotZone[] _allZones; //Field offset: 0x40
	private readonly SpawnDelaysService _spawnDelaysService; //Field offset: 0x48
	private readonly List _noneSectantBossList; //Field offset: 0x50
	private readonly List _sectantsList; //Field offset: 0x58
	private float _lastTimeSpawnedBoss; //Field offset: 0x60
	private WildSpawnType _lastBossSpan; //Field offset: 0x64
	private BotZone _lastZone; //Field offset: 0x68
	private readonly IBotCreator _botCreator; //Field offset: 0x70

	public BotBossSpawn(ISpawnSystem spawnSystem, BotSpawner spawner, IBotCreator botCreator, BotZone[] allZones, SpawnDelaysService spawnDelaysService) { }

	private static void AppendZonesTo(StringBuilder sb, string key, IReadOnlyList zones) { }

	private void CheckSpawnAfterDelay(BossSpawnDelayModel spawnDelayModel) { }

	private void DelayBossSpawn(BossLocationSpawn wave, BotSpawnParams spawnParams, BotCreationData creationData) { }

	private bool GroupContaisnBossNonEqual(BotsGroup botsGroup, List ignoreRoles) { }

	public void InitBossSpawnDebug() { }

	private void LogBossSpawnZoneSelectionError(string reason, BossLocationSpawn wave, bool isPmcBot, IReadOnlyList botZones, IReadOnlyList shuffled) { }

	[AsyncStateMachine(typeof(<Spawn>d__18))]
	public Task Spawn(BossLocationSpawn wave, BotSpawnParams spawnParams, BotCreationData data = null) { }

	[AsyncStateMachine(typeof(<SpawnBossAndFollowers>d__24))]
	private Task SpawnBossAndFollowers(BotCreationData creationData, BossLocationSpawn wave, BotSpawnParams spawnParams, int followersCount, BotZone botZone, List openedPositions) { }

	[AsyncStateMachine(typeof(<SpawnBossMain>d__28))]
	private Task SpawnBossMain(BotCreationData creationData, ISpawnPoint point, BotZone ss, int followers, GetProfileDataParams data, Action callback) { }

	[AsyncStateMachine(typeof(<SpawnBossSupports>d__26))]
	private Task SpawnBossSupports(BotCreationData bossCreationData, BotZone zone, int followersCount, BotSpawnParams spawnParams, BossLocationSpawn wave, EPlayerSide side, List pointsToSpawn, bool forceSpawn) { }

	[AsyncStateMachine(typeof(<SpawnEscort>d__27))]
	private Task SpawnEscort(BotCreationData creationData, BotZone zone, EPlayerSide side, BossLocationSpawn wave, List escorts, BotSpawnParams spawnParams, List pointsToSpawn, bool forceSpawn) { }

	private bool TrySpawn(BossLocationSpawn wave, BotSpawnParams spawnParams, BotDifficulty difficulty, int followersCount, BotCreationData creationData, List spawnProcess) { }

}

