namespace EFT;

public class BotsController : IBotZoneCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__92_0; //Field offset: 0x8
		public static Func <>9__93_0; //Field offset: 0x10
		public static Func <>9__94_0; //Field offset: 0x18
		public static Func <>9__95_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <ActivateBotsByWave>b__94_0(Player player) { }

		internal string <ActivateBotsByWave>b__95_0(Player player) { }

		internal IEnumerable <EFT.Game.Spawning.IBotZoneCollection.AllZonesSpawnPoints>b__93_0(BotZone zone) { }

		internal string <EFT.Game.Spawning.IBotZoneCollection.ZoneNames>b__92_0(BotZone zone) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public Vector3 requestedPosition; //Field offset: 0x10
		public GroupPoint closetsGroupPoint; //Field offset: 0x20
		public List botsWithSameCG; //Field offset: 0x28

		public <>c__DisplayClass118_0() { }

		internal bool <DevelopmentTeleportBot>b__0(BotOwner x) { }

		internal Vector3 <DevelopmentTeleportBot>b__1(int i) { }

	}

	[CompilerGenerated]
	private struct <ActivateBotsByWave>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpawnWave wave; //Field offset: 0x20
		public BotsController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static WildSpawnType[] _allTypes; //Field offset: 0x0
	private static readonly Stopwatch _updateMeasureSw; //Field offset: 0x8
	public BotOnlineDependenceSettings OnlineDependenceSettings; //Field offset: 0x10
	public readonly BotsList Bots; //Field offset: 0x18
	private bool _canSpawn; //Field offset: 0x20
	private BotSpawner _botSpawner; //Field offset: 0x28
	public AICoreController AICoreController; //Field offset: 0x30
	[CompilerGenerated]
	private AITaskManager <AiTaskManager>k__BackingField; //Field offset: 0x38
	public AIStationaryController StationaryWeapons; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnSpawnerSetted; //Field offset: 0x48
	[CompilerGenerated]
	private BotsEventsController <EventsController>k__BackingField; //Field offset: 0x50
	private BotsConnections _connections; //Field offset: 0x58
	private AICoversData _coversData; //Field offset: 0x60
	[CompilerGenerated]
	private IBotGame <BotGame>k__BackingField; //Field offset: 0x68
	public BotZonesLeaveController ZonesLeaveController; //Field offset: 0x70
	public BotArtilleryZonesController ArtilleryZonesController; //Field offset: 0x78
	public readonly Dictionary AILayerLookObstaclesCache; //Field offset: 0x80
	private int _maxCount; //Field offset: 0x88
	public BotLocationModifier BotLocationModifier; //Field offset: 0x90
	public NavMeshCutController CutController; //Field offset: 0x98
	private WavesCountControlScenario _spawnControlScenario; //Field offset: 0xA0
	private BotPreset[] _botPresets; //Field offset: 0xA8
	private BotWeaponScattering[] _botScatterings; //Field offset: 0xB0
	[CompilerGenerated]
	private IPlayersCollection <Players>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private BotsPlantedMinesController <PlantedMines>k__BackingField; //Field offset: 0xC0
	private BotTradersServices _botTradersServices; //Field offset: 0xC8
	[CompilerGenerated]
	private BotSpawnLimiter <BotSpawnLimiter>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private BotsSmokesVisionSystem <BotSmokesVisionSystem>k__BackingField; //Field offset: 0xD8

	public event Action OnSpawnerSetted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private AITaskManager AiTaskManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int AliveAndLoadingBotsCount
	{
		 get { } //Length: 85
	}

	public int AliveLoadingDelayedBotsCount
	{
		 get { } //Length: 189
	}

	public static WildSpawnType[] AllTypes
	{
		 get { } //Length: 584
	}

	public private IBotGame BotGame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotsSmokesVisionSystem BotSmokesVisionSystem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotSpawner BotSpawner
	{
		 get { } //Length: 5
	}

	public private BotSpawnLimiter BotSpawnLimiter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BotTradersServices BotTradersServices
	{
		 get { } //Length: 8
	}

	public bool CanSpawn
	{
		 get { } //Length: 5
	}

	public AICoversData CoversData
	{
		 get { } //Length: 5
	}

	public private BotsEventsController EventsController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public GameDateTime GameDateTime
	{
		 get { } //Length: 73
	}

	public bool IsEnable
	{
		 get { } //Length: 9
	}

	public bool IsPvE
	{
		 get { } //Length: 145
	}

	public private BotsPlantedMinesController PlantedMines
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IPlayersCollection Players
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static BotsController() { }

	public BotsController() { }

	[AsyncStateMachine(typeof(<ActivateBotsByWave>d__94))]
	public Task ActivateBotsByWave(SpawnWave wave) { }

	public void ActivateBotsByWave(BossLocationSpawn wave) { }

	public void ActivateBotsWithoutWave(int count, IGetProfileData data) { }

	[CompilerGenerated]
	public void add_OnSpawnerSetted(Action value) { }

	public void AddActivePLayer(Player player) { }

	public void AddEnemyToAllGroupsInBotZone(IPlayer aggressor, IPlayer groupOwner, IPlayer target) { }

	private void AIPlacesInit() { }

	private void ApplyBTRSupport(List passengers) { }

	private void ApplyFriendlyUsecs(Player player) { }

	private void ApplyFriendlyZryachiy(Player player) { }

	public void BotDied(BotOwner botOwner) { }

	private Dictionary CachedPatrolsZones(BotZone[] zones) { }

	private void CheckNavMesh() { }

	[CanBeNull]
	public BotOwner ClosestBotToPoint(Vector3 p) { }

	public bool DebugChangeParameter(string cls, string prm, object val) { }

	public void DebugLogsAboultRemoveEnemies() { }

	public void DebugSpawnErrorCase() { }

	public void DebugSpawnServerAnyway() { }

	public bool DebugUpdateSettingsToAllBots() { }

	public void DestroyInfo(Player player) { }

	public void DevelopmentTeleportBot(Vector3 requestedPosition) { }

	public void DevelopmentTeleportBot(BotOwner ownerToMove, Vector3 requestedPosition) { }

	public void Disable() { }

	private override ISpawnPoint[] EFT.Game.Spawning.IBotZoneCollection.AllZonesSpawnPoints(bool canBeSnipe) { }

	private override Nullable EFT.Game.Spawning.IBotZoneCollection.GetBossPosition(BotZone zone, Nullable closestBossPos) { }

	private override IEnumerable EFT.Game.Spawning.IBotZoneCollection.ZoneNames(bool canBeSnipe) { }

	private override ISpawnPoint[] EFT.Game.Spawning.IBotZoneCollection.ZoneSpawnPoints(string zoneName) { }

	public static BotsController FindBotControllerEditorOnly() { }

	public string FullBotsCountInfo() { }

	[CompilerGenerated]
	public AITaskManager get_AiTaskManager() { }

	public int get_AliveAndLoadingBotsCount() { }

	public int get_AliveLoadingDelayedBotsCount() { }

	public static WildSpawnType[] get_AllTypes() { }

	[CompilerGenerated]
	public IBotGame get_BotGame() { }

	[CompilerGenerated]
	public BotsSmokesVisionSystem get_BotSmokesVisionSystem() { }

	public BotSpawner get_BotSpawner() { }

	[CompilerGenerated]
	public BotSpawnLimiter get_BotSpawnLimiter() { }

	public BotTradersServices get_BotTradersServices() { }

	public bool get_CanSpawn() { }

	public AICoversData get_CoversData() { }

	[CompilerGenerated]
	public BotsEventsController get_EventsController() { }

	public GameDateTime get_GameDateTime() { }

	public bool get_IsEnable() { }

	public bool get_IsPvE() { }

	[CompilerGenerated]
	public BotsPlantedMinesController get_PlantedMines() { }

	[CompilerGenerated]
	public IPlayersCollection get_Players() { }

	public List GetAllBossPlayers() { }

	public BotZone GetClosestZone(Vector3 position, out float dist) { }

	public BotSpawner GetSpawner() { }

	public BotZoneGroupsDictionary Groups() { }

	public void Init(IBotGame botGame, IBotCreator botCreator, BotZone[] botZones, ISpawnSystem spawnSystem, BotLocationModifier botLocationModifier, bool botEnable, bool freeForAll, bool enableWaveControl, bool online, bool haveSectants, IPlayersCollection players, string openZones, BotLocationEvents events) { }

	private void InterruptBTRSupportByBetrayer(Player player) { }

	private static void MeasureUpdateStep(string stepName, Action action) { }

	private void OnBeingHit(DamageInfo damageInfo, Player target) { }

	private void OnGrenadeExplosive(Vector3 explosionPosition, int playerRaidIDWhoThrew, bool isSmoke, float smokeRadius, float smokeLifeTime, int throwableId) { }

	private void OnGrenadeThrow(Grenade grenade, Vector3 position, Vector3 force, float mass) { }

	private void OnKill(IPlayer killer, IPlayer target) { }

	private void OnRocketExplosive(Vector3 explosionPosition, int playerRaidIDWhoThrew) { }

	[CompilerGenerated]
	public void remove_OnSpawnerSetted(Action value) { }

	public void ResetGameDateTime(int hour) { }

	[CompilerGenerated]
	private void set_AiTaskManager(AITaskManager value) { }

	[CompilerGenerated]
	private void set_BotGame(IBotGame value) { }

	[CompilerGenerated]
	private void set_BotSmokesVisionSystem(BotsSmokesVisionSystem value) { }

	[CompilerGenerated]
	private void set_BotSpawnLimiter(BotSpawnLimiter value) { }

	[CompilerGenerated]
	private void set_EventsController(BotsEventsController value) { }

	[CompilerGenerated]
	private void set_PlantedMines(BotsPlantedMinesController value) { }

	[CompilerGenerated]
	private void set_Players(IPlayersCollection value) { }

	public void SetAllPlayersPursuitDebug() { }

	public void SetSettings(int maxCount, BotPreset[] botPresets, BotWeaponScattering[] botScatterings) { }

	private static void SpatialControllerActivate() { }

	public void SpawnBossDebug() { }

	private void StopBTRSupport() { }

	public void StopGettingInfo() { }

	private void UpdateByUnity() { }

}

