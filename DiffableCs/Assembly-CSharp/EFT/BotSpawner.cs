namespace EFT;

public abstract class BotSpawner : ITokenGetter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__58_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetAllBossPLayers>b__58_0(Player x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public BotSpawner <>4__this; //Field offset: 0x10
		public BotCreationData data; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		public bool shallBeGroup; //Field offset: 0x28
		public Stopwatch stopWatch; //Field offset: 0x30

		public <>c__DisplayClass102_0() { }

		internal void <ActivateBotFromPool>b__0(BotOwner bot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public bool canBeSnipe; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal bool <GetRandomBotZone>b__0(BotZone x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <GetBotDebugData>b__0(BotOwner x) { }

		internal bool <GetBotDebugData>b__1(Player x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public SpawnWave wave; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal bool <ActivateBotsByWave>b__0(BotZone zone) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <GetZoneByName>b__0(BotZone x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public bool canBeSnipe; //Field offset: 0x10

		public <>c__DisplayClass82_0() { }

		internal bool <SpawnZones>b__0(BotZone x) { }

	}

	[CompilerGenerated]
	private struct <ActivateBots>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotCreationData data; //Field offset: 0x20
		public List spawnPoints; //Field offset: 0x28
		public BotSpawner <>4__this; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public BotZone botZone; //Field offset: 0x40
		public Action callback; //Field offset: 0x48
		public BotSpawnBossAndGroupParams bossAndGroup; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x52

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ActivateBotsByWave>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpawnWave wave; //Field offset: 0x20
		public BotSpawner <>4__this; //Field offset: 0x28
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x30
		private bool <isFreeSpawn>5__2; //Field offset: 0x38
		private IGetProfileData <data>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ActivateBotsWithoutWave>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IGetProfileData data; //Field offset: 0x20
		public BotSpawner <>4__this; //Field offset: 0x28
		public int count; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DebugSpawnAnyway>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotSpawner <>4__this; //Field offset: 0x20
		private BotZone <rndZone>5__2; //Field offset: 0x28
		private SpawnPointMarker <rndBorn>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnAndActivateNowDebugClient>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DebugBotProfileChooser profileType; //Field offset: 0x20
		public BotSpawner <>4__this; //Field offset: 0x28
		public EPlayerSide side; //Field offset: 0x30
		public BotZone zone; //Field offset: 0x38
		public bool ignoreConditions; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnAndActivateNowDebugFromLocalFilesServer>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnAndActivateNowDebugServer>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WildSpawnType profileType; //Field offset: 0x20
		public BotDifficulty botDifficulty; //Field offset: 0x24
		public bool forcedSpawn; //Field offset: 0x28
		public BotSpawner <>4__this; //Field offset: 0x30
		public EPlayerSide side; //Field offset: 0x38
		public BotZone zone; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBotBTR>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotSpawner <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBotByTypeForce>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotSpawner <>4__this; //Field offset: 0x20
		public WildSpawnType botType; //Field offset: 0x28
		public BotDifficulty dif; //Field offset: 0x2C
		public BotSpawnParams spawnParams; //Field offset: 0x30
		public int count; //Field offset: 0x38
		private BotZone <botZone>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly BotBossSpawn BossSpawner; //Field offset: 0x10
	protected readonly BotsList _bots; //Field offset: 0x18
	protected BotZone[] _allBotZones; //Field offset: 0x20
	protected HashSet _openedZones; //Field offset: 0x28
	protected Dictionary _zonesPatrols; //Field offset: 0x30
	protected Dictionary _zonesPatrolsSnipe; //Field offset: 0x38
	protected readonly SpawnDelaysService SpawnDelaysService; //Field offset: 0x40
	protected readonly List _allPlayers; //Field offset: 0x48
	private bool _gameEnd; //Field offset: 0x50
	private bool _freeForAll; //Field offset: 0x51
	private readonly IBotCreator _botCreator; //Field offset: 0x58
	private readonly DeadBodiesController _deadBodiesController; //Field offset: 0x60
	private ISpawnSystem _spawnSystem; //Field offset: 0x68
	private int _allBotsCount; //Field offset: 0x70
	private int _followersBotsCount; //Field offset: 0x74
	private int _bossBotsCount; //Field offset: 0x78
	private int _inSpawnProcess; //Field offset: 0x7C
	private int _prevBotId; //Field offset: 0x80
	private readonly HashSet _deletedPlayers; //Field offset: 0x88
	private readonly HashSet _addedPlayers; //Field offset: 0x90
	private readonly HashSet _blockedRoles; //Field offset: 0x98
	private readonly CancellationTokenSource _cancellationTokenSource; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnBotCreated; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnBotRemoved; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnSpawnedWave; //Field offset: 0xB8
	[CompilerGenerated]
	private int <MaxBots>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly BotZoneGroupsDictionary <Groups>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private readonly IBotGame <BotGame>k__BackingField; //Field offset: 0xD0

	public event Action OnBotCreated
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnBotRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpawnedWave
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public int AliveAndLoadingBotsCount
	{
		 get { } //Length: 79
	}

	public int AllBotsWithDelayed
	{
		 get { } //Length: 180
	}

	public int AllBotsWithLoaded
	{
		 get { } //Length: 7
	}

	public IBotGame BotGame
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int BotsDelayed
	{
		 get { } //Length: 106
	}

	public BotZoneGroupsDictionary Groups
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool IsProfilesLoaded
	{
		 get { } //Length: 78
	}

	public private int MaxBots
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int PlayersCount
	{
		 get { } //Length: 65
	}

	protected BotSpawner(IBotCreator botCreator, IBotGame game, BotZone[] botZones, BotsList bots, ISpawnSystem spawnSystem, int maxBots, bool freeForAll, Dictionary allZonesPatrols, string openZones) { }

	private void ActivateBotCallback(BotOwner bot, BotCreationData data, Action callback, bool shallBeGroup, Stopwatch stopWatch) { }

	private void ActivateBotFromPool(BotZone zone, BotCreationData data, Action callback, CancellationToken cancellationToken, BotSpawnBossAndGroupParams bossAndGroup) { }

	[AsyncStateMachine(typeof(<ActivateBots>d__99))]
	private Task ActivateBots(List spawnPoints, BotZone botZone, BotCreationData data, Action callback, BotSpawnBossAndGroupParams bossAndGroup, CancellationToken cancellationToken) { }

	public void ActivateBotsByWave(BossLocationSpawn wave) { }

	[AsyncStateMachine(typeof(<ActivateBotsByWave>d__67))]
	public Task ActivateBotsByWave(SpawnWave wave) { }

	[AsyncStateMachine(typeof(<ActivateBotsWithoutWave>d__66))]
	public Task ActivateBotsWithoutWave(int count, IGetProfileData data) { }

	[CompilerGenerated]
	public void add_OnBotCreated(Action value) { }

	[CompilerGenerated]
	public void add_OnBotRemoved(Action value) { }

	[CompilerGenerated]
	public void add_OnSpawnedWave(Action value) { }

	public void AddPlayer(Player player) { }

	public void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	public void AddZoneToPossibleZones(BotZone zone) { }

	private void AfterCreation(BotOwner bot) { }

	public void BotDied(BotOwner bot) { }

	public bool CanSpawnRole(IGetProfileData data) { }

	public void CheckOnMax(int wantSpawn, out int toDelay, out int toSpawn, bool calcOnlySimpleBots = false) { }

	private void CheckSpawnOnFreeAfterDelay(SimpleBotSpawnDelayModel delayedBotsInfo) { }

	[CanBeNull]
	public BotOwner ClosestBotToPoint(Vector3 t) { }

	public BotsGroup CreateNewGroup(BotOwner bot, BotZone zone, bool isBossOrFollower = false) { }

	public void DebugLogsAboultRemoveEnemies() { }

	[AsyncStateMachine(typeof(<DebugSpawnAnyway>d__75))]
	public Task DebugSpawnAnyway() { }

	public void DeletePlayer(Player player) { }

	public void FillProfilesData(DebugBotProfilesStructContainer resultCache) { }

	public string FullBotsCountInfo() { }

	public int get_AliveAndLoadingBotsCount() { }

	public int get_AllBotsWithDelayed() { }

	public int get_AllBotsWithLoaded() { }

	[CompilerGenerated]
	public IBotGame get_BotGame() { }

	public int get_BotsDelayed() { }

	[CompilerGenerated]
	public BotZoneGroupsDictionary get_Groups() { }

	public bool get_IsProfilesLoaded() { }

	[CompilerGenerated]
	public int get_MaxBots() { }

	public int get_PlayersCount() { }

	public List GetAllBossPLayers() { }

	public List GetAllBotsNearTarget(Vector3 t, float dist) { }

	public DebugBotStruct GetBotDebugData(IPlayer currentPlayer, string profileId) { }

	public override CancellationToken GetCancelToken() { }

	public BotZone GetClosestZone(Vector3 position, out float dist) { }

	protected BotZone GetClosestZone(Vector3 position, Dictionary testingZones, out float dist) { }

	public DebugBotSpawnStruct GetDebugSpawnsData() { }

	public BotsGroup GetGroupAndSetEnemies(BotOwner bot, BotZone zone, BotSpawnBossAndGroupParams spawnBossGroup) { }

	public Player GetPlayer(int index) { }

	public List GetPmcZones() { }

	public BotZone GetRandomBotZone(bool canBeSnipe) { }

	public List GetSeason01Zones() { }

	public BotZone GetZoneByName(string name) { }

	private bool IsSame(SimpleBotSpawnDelayModel v1, SimpleBotSpawnDelayModel v2) { }

	private StringBuilder LogsByZones(Dictionary zones) { }

	private void OnBecomeScavAttacker(AIData aiData) { }

	[CompilerGenerated]
	public void remove_OnBotCreated(Action value) { }

	[CompilerGenerated]
	public void remove_OnBotRemoved(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpawnedWave(Action value) { }

	public void RemoveZoneToPossibleZones(BotZone zone) { }

	private HashSet ResetOpenZones(string openZones, BotZone[] botZones) { }

	[CompilerGenerated]
	private void set_MaxBots(int value) { }

	public void SetAllPlayersPursuitDebug() { }

	public void SetBlockedRoles(string[] resultExcludedBosses) { }

	public void SetMaxBots(int maxCount) { }

	[AsyncStateMachine(typeof(<SpawnAndActivateNowDebugClient>d__95))]
	internal Task SpawnAndActivateNowDebugClient(EPlayerSide side, BotZone zone, DebugBotProfileChooser profileType = 0, bool ignoreConditions = false) { }

	[AsyncStateMachine(typeof(<SpawnAndActivateNowDebugFromLocalFilesServer>d__96))]
	internal Task SpawnAndActivateNowDebugFromLocalFilesServer(EPlayerSide side, BotZone zone, int count, DebugBotProfileChooser profileType = 0, bool ignoreConditions = false) { }

	[AsyncStateMachine(typeof(<SpawnAndActivateNowDebugServer>d__97))]
	internal Task SpawnAndActivateNowDebugServer(EPlayerSide side, BotZone zone, WildSpawnType profileType = 1, BotDifficulty botDifficulty = 1, bool forcedSpawn = false) { }

	[AsyncStateMachine(typeof(<SpawnBotBTR>d__70))]
	public Task SpawnBotBTR() { }

	[AsyncStateMachine(typeof(<SpawnBotByTypeForce>d__71))]
	public Task SpawnBotByTypeForce(int count, WildSpawnType botType, BotDifficulty dif, BotSpawnParams spawnParams) { }

	public void SpawnBotsInZoneOnPositions(List openedPositions, BotZone botZone, BotCreationData data, Action callback, BotSpawnBossAndGroupParams bossAndGroup) { }

	public IEnumerable SpawnZones(bool canBeSnipe) { }

	public void Stop() { }

	public void TraceLogsOpenedZones() { }

	protected void TrySpawnFreeAndDelay(BotCreationData data, bool newWave) { }

	protected abstract SimpleBotSpawnDelayModel TrySpawnFreeInner(BotCreationData data, bool newWave, Action checkSpawnOnFreeAfterDelay) { }

	public void TryToSpawnInZoneAndDelay(BotZone botZone, BotCreationData data, bool withCheckMinMax, bool newWave, List pointsToSpawn = null, bool forcedSpawn = false) { }

	public SimpleBotSpawnDelayModel TryToSpawnInZoneInner(BotZone botZone, BotCreationData data, int count, bool withCheckMinMax, bool newWave, List pointsToSpawn = null, bool forcedSpawn = false) { }

}

