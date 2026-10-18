namespace EFT.Game.Spawning;

internal sealed class SpawnSystem : ISpawnSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_1; //Field offset: 0x8
		public static Func <>9__17_0; //Field offset: 0x10
		public static Func <>9__17_2; //Field offset: 0x18
		public static Func <>9__17_4; //Field offset: 0x20
		public static Func <>9__19_0; //Field offset: 0x28
		public static Func <>9__20_0; //Field offset: 0x30
		public static Func <>9__20_4; //Field offset: 0x38
		public static Func <>9__21_0; //Field offset: 0x40
		public static Func <>9__21_4; //Field offset: 0x48
		public static Func <>9__22_0; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal string <AllAlivePotentialEnemiesPlayers>b__22_0(Player player) { }

		internal bool <EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint>b__11_1(ISpawnPoint sp) { }

		internal string <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__17_0(IPlayer player) { }

		internal string <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__17_2(ISpawnPoint point) { }

		internal string <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__17_4(ISpawnPoint point) { }

		internal bool <GetBossOrFollowerSpawnPoints>b__19_0(ISpawnPoint spawnPoint) { }

		internal bool <GetPmcSpawnPoints>b__21_0(ISpawnPoint spawnPoint) { }

		internal bool <GetPmcSpawnPoints>b__21_4(Player alivePlayer) { }

		internal bool <GetSeason01SpawnPoints>b__20_0(ISpawnPoint spawnPoint) { }

		internal bool <GetSeason01SpawnPoints>b__20_4(Player alivePlayer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public IPlayer[] noneGroupPlayers; //Field offset: 0x10
		public ESpawnCategory category; //Field offset: 0x18
		public EPlayerSide side; //Field offset: 0x1C
		public string infiltration; //Field offset: 0x20

		public <>c__DisplayClass11_0() { }

		internal bool <EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint>b__2(ISpawnPoint spawnPoint) { }

		internal bool <EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint>b__3(ISpawnPoint spawnPoint) { }

		internal bool <EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint>b__4(ISpawnPoint spawnPoint) { }

		internal ISpawnPoint <EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint>g__SelectInvalidSpawnPoint|0(IReadOnlyList list) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Nullable closestBossPos; //Field offset: 0x10
		public float time; //Field offset: 0x20
		public BotCreationData profileData; //Field offset: 0x28
		public SpawnSystemDebugCollector debugCollector; //Field offset: 0x30
		public IPlayer[] allPlayers; //Field offset: 0x38

		public <>c__DisplayClass16_0() { }

		internal float <SelectAISpawnPoints>b__0(ISpawnPoint spawnPoint) { }

		internal bool <SelectAISpawnPoints>b__1(ISpawnPoint sp) { }

		internal float <SelectAISpawnPoints>b__2(ISpawnPoint sp) { }

		internal bool <SelectAISpawnPoints>b__3(ISpawnPoint sp) { }

		internal bool <SelectAISpawnPoints>b__4(ISpawnPoint sp) { }

		internal bool <SelectAISpawnPoints>b__8(ISpawnPoint sp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_1
	{
		public IPlayer[] enemies; //Field offset: 0x10
		public ArtilleryShellingControllerServer artilleryController; //Field offset: 0x18
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass16_1() { }

		internal bool <SelectAISpawnPoints>b__5(ISpawnPoint sp) { }

		internal bool <SelectAISpawnPoints>b__6(ISpawnPoint sp) { }

		internal bool <SelectAISpawnPoints>b__7(ISpawnPoint sp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public HashSet playersToCheck; //Field offset: 0x10
		public List collidedIds; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal bool <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__1(ISpawnPoint point) { }

		internal float <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__3(ISpawnPoint point) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public ISpawnPoint point; //Field offset: 0x10

		public <>c__DisplayClass17_1() { }

		internal float <EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition>b__5(IPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Nullable position; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal float <GetBossOrFollowerSpawnPoints>b__1(ISpawnPoint sp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public float time; //Field offset: 0x10
		public BotCreationData creationData; //Field offset: 0x18
		public List allPotentialEnemiesPlayers; //Field offset: 0x20
		public float dinstancesSum; //Field offset: 0x28
		public List alivePmcPlayers; //Field offset: 0x30

		public <>c__DisplayClass20_0() { }

		internal bool <GetSeason01SpawnPoints>b__1(ISpawnPoint point) { }

		internal bool <GetSeason01SpawnPoints>b__2(ISpawnPoint sp) { }

		internal bool <GetSeason01SpawnPoints>b__3(ISpawnPoint sp) { }

		internal float <GetSeason01SpawnPoints>g__FarestFromAlivePmcPlayersComparer|5(ISpawnPoint point) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public float time; //Field offset: 0x10
		public BotCreationData creationData; //Field offset: 0x18
		public List allPotentialEnemiesPlayers; //Field offset: 0x20
		public float dinstancesSum; //Field offset: 0x28
		public List alivePmcPlayers; //Field offset: 0x30

		public <>c__DisplayClass21_0() { }

		internal bool <GetPmcSpawnPoints>b__1(ISpawnPoint point) { }

		internal bool <GetPmcSpawnPoints>b__2(ISpawnPoint sp) { }

		internal bool <GetPmcSpawnPoints>b__3(ISpawnPoint sp) { }

		internal float <GetPmcSpawnPoints>g__FarestFromAlivePmcPlayersComparer|5(ISpawnPoint point) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public HashSet warnAndEmemiesBotTypes; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <AllAlivePotentialEnemiesPlayers>b__1(Player player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public SpawnSystemDebugCollector debugLoggerCollector; //Field offset: 0x10
		public float time; //Field offset: 0x18
		public IGetProfileData profileData; //Field offset: 0x20
		public IReadOnlyCollection carePlayers; //Field offset: 0x28
		public float distanceSqr; //Field offset: 0x30
		public ArtilleryShellingControllerServer artilleryController; //Field offset: 0x38

		public <>c__DisplayClass24_0() { }

		internal bool <GetSpawnPoint>b__0(ISpawnPoint sp) { }

		internal bool <GetSpawnPoint>b__1(ISpawnPoint sp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_1
	{
		public Vector3 playersCenter; //Field offset: 0x10

		public <>c__DisplayClass24_1() { }

		internal float <GetSpawnPoint>b__2(ISpawnPoint sp) { }

	}

	public sealed class InvalidSpawnPoint : ISpawnPoint, IPositionPoint, ISpawnPointCollider
	{
		public static readonly InvalidSpawnPoint Instance; //Field offset: 0x0
		[CompilerGenerated]
		private readonly string <Id>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly string <Name>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private bool <SpawnBlocked>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private readonly Vector3 <Position>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private readonly Quaternion <Rotation>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private readonly EPlayerSideMask <Sides>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private readonly ESpawnCategoryMask <Categories>k__BackingField; //Field offset: 0x44
		[CompilerGenerated]
		private readonly string <Infiltration>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private readonly string <BotZoneName>k__BackingField; //Field offset: 0x50
		[CompilerGenerated]
		private readonly bool <IsSnipeZone>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private readonly float <DelayToCanSpawnSec>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		private float <NextBornTime>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private int <CorePointId>k__BackingField; //Field offset: 0x64
		[CompilerGenerated]
		private readonly ISpawnPointCollider <Collider>k__BackingField; //Field offset: 0x68

		public override string BotZoneName
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override ESpawnCategoryMask Categories
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public override ISpawnPointCollider Collider
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override int CorePointId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public override float DelayToCanSpawnSec
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		public override string Id
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override string Infiltration
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override bool IsSnipeZone
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override string Name
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override float NextBornTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		public override Vector3 Position
		{
			[CompilerGenerated]
			 get { } //Length: 19
		}

		public override Quaternion Rotation
		{
			[CompilerGenerated]
			 get { } //Length: 11
		}

		public override EPlayerSideMask Sides
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public override bool SpawnBlocked
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		private static InvalidSpawnPoint() { }

		private InvalidSpawnPoint() { }

		public override float CalcMultiSpawnDelay(float additionalDelay, BotCreationData creactionData) { }

		public override string DebugInfo() { }

		public override void Dispose() { }

		private override bool EFT.Game.Spawning.ISpawnPointCollider.Contains(Vector3 point) { }

		[CompilerGenerated]
		public override string get_BotZoneName() { }

		[CompilerGenerated]
		public override ESpawnCategoryMask get_Categories() { }

		[CompilerGenerated]
		public override ISpawnPointCollider get_Collider() { }

		[CompilerGenerated]
		public override int get_CorePointId() { }

		[CompilerGenerated]
		public override float get_DelayToCanSpawnSec() { }

		[CompilerGenerated]
		public override string get_Id() { }

		[CompilerGenerated]
		public override string get_Infiltration() { }

		[CompilerGenerated]
		public override bool get_IsSnipeZone() { }

		[CompilerGenerated]
		public override string get_Name() { }

		[CompilerGenerated]
		public override float get_NextBornTime() { }

		[CompilerGenerated]
		public override Vector3 get_Position() { }

		[CompilerGenerated]
		public override Quaternion get_Rotation() { }

		[CompilerGenerated]
		public override EPlayerSideMask get_Sides() { }

		[CompilerGenerated]
		public override bool get_SpawnBlocked() { }

		public override void IncreaseUsedPlayerSpawnsForNearestPlayer(BotCreationData creationData) { }

		public override bool IsInPlayersIndividualLimits(BotCreationData creationData) { }

		public override bool IsNotCollidedArtillery(ArtilleryShellingControllerServer artilleryShelling) { }

		[CompilerGenerated]
		public override void set_CorePointId(int value) { }

		[CompilerGenerated]
		public override void set_NextBornTime(float value) { }

		[CompilerGenerated]
		public override void set_SpawnBlocked(bool value) { }

	}

	public sealed class Logger : AbstractLogger
	{
		private readonly SpawnSystem _system; //Field offset: 0x48

		internal Logger(SpawnSystem system) { }

		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		internal void Filtered(IReadOnlyCollection spawnPoints, string sourceName = null, ValueTuple[] args) { }

		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		internal void Filtered(IReadOnlyCollection persons, string sourceName = null, ValueTuple[] args) { }

		internal void InvalidSpawnPointSelected(string message = null) { }

		public bool IsTraceEnable() { }

		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		internal void LogNextBornTime(ISpawnPoint spawnPoint, float currentTime, bool isPlayer = false) { }

		[Conditional("SERVER")]
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		internal void Source(IReadOnlyCollection spawnPoints, string sourceName = null) { }

		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[Conditional("SERVER")]
		internal void Source(IReadOnlyCollection persons, string sourceName = null) { }

		public void TraceSpawnIsNotCollided(ISpawnPoint spawnPoint, IPlayer[] exceptAIPlayers, bool isValid) { }

		public void TraceSpawnSide(ISpawnPoint spawnPoint, Nullable profileDataSide, bool isValid) { }

		public void TraceSpawnTime(ISpawnPoint spawnPoint, float time, bool isValid) { }

	}

	private class SpawnPointsFilteredCollection
	{
		private readonly List _spawnPointsInternal; //Field offset: 0x10
		private readonly List _sortingCache; //Field offset: 0x18
		[CompilerGenerated]
		private int <ValidPointsCount>k__BackingField; //Field offset: 0x20

		public IReadOnlyList AllPoints
		{
			 get { } //Length: 5
		}

		public IReadOnlyList ValidPointsAlloc
		{
			 get { } //Length: 79
		}

		public private int ValidPointsCount
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public SpawnPointsFilteredCollection() { }

		public void ApplyFilter(Func predicate) { }

		public void ApplySorting(Func comparer) { }

		public void ApplySortingToNonValid(Func comparer) { }

		public void ClampPointsCountToMaximum(int maxCount) { }

		public void Clear() { }

		public IReadOnlyList get_AllPoints() { }

		public IReadOnlyList get_ValidPointsAlloc() { }

		[CompilerGenerated]
		public int get_ValidPointsCount() { }

		public void Insert(ISpawnPoint point) { }

		public void InsertRange(IEnumerable points) { }

		public void MultiplicatePointOnIndex(int index, int times) { }

		public void ResetAllToValid() { }

		[CompilerGenerated]
		private void set_ValidPointsCount(int value) { }

		public void Shuffle() { }

	}

	private static Logger _logger; //Field offset: 0x0
	private readonly SpawnSystemSettings _settings; //Field offset: 0x10
	private readonly Func _time; //Field offset: 0x28
	private readonly IPlayersCollection _players; //Field offset: 0x30
	private IBotZoneCollection _zones; //Field offset: 0x38
	private ISpawnPointsCollection _spawnPoints; //Field offset: 0x40
	private readonly SpawnPointsFilteredCollection _filteredPointsCache; //Field offset: 0x48

	private override AbstractLogger EFT.Game.Spawning.ISpawnSystem.Logger
	{
		private get { } //Length: 59
	}

	internal SpawnSystem(SpawnSystemSettings settings, Func time, IPlayersCollection players, IBotZoneCollection zones, ISpawnPointsCollection spawnPoints) { }

	private static List AllAlivePotentialEnemiesPlayers(BotDifficulty difficulty, WildSpawnType role, string debugCtxTag) { }

	public override void Dispose() { }

	private override bool EFT.Game.Spawning.ISpawnSystem.CheckFarthestFromOtherPlayers(IPlayer player) { }

	private override AbstractLogger EFT.Game.Spawning.ISpawnSystem.get_Logger() { }

	private override List EFT.Game.Spawning.ISpawnSystem.SelectAISpawnPoints(BotCreationData profileData, BotZone zone, int maxCount, Nullable closestBossPos, ActionIfNotEnoughPoints mode = 1, List spawnProcess = null) { }

	private override ISpawnPoint EFT.Game.Spawning.ISpawnSystem.SelectPlayerSavageSpawn(ESpawnCategory category, string groupId, string teamId, IPlayer person, string zoneName, string profileId) { }

	private override ISpawnPoint EFT.Game.Spawning.ISpawnSystem.SelectSpawnPoint(ESpawnCategory category, EPlayerSide side, string groupId, string teamId, IPlayer person, string infiltration, string profileId) { }

	private override bool EFT.Game.Spawning.ISpawnSystem.ValidateSpawnPosition(ref Vector3 position, BotZone zone, IPlayer person, BotCreationData data) { }

	[NotNull]
	private static void GetBossOrFollowerSpawnPoints(SpawnPointsFilteredCollection filteredPoints, int maxCount, BotZone zone, IBotZoneCollection zones, Nullable closestBossPos) { }

	[NotNull]
	private static void GetBossOrFollowerSpawnPoints2(SpawnPointsFilteredCollection filteredPoints, BotZone zone, IBotZoneCollection zones, Nullable closestBossPos) { }

	private static void GetPmcSpawnPoints(SpawnPointsFilteredCollection filteredPoints, int maxCount, BotZone zone, BotCreationData creationData, float time) { }

	private static void GetSeason01SpawnPoints(SpawnPointsFilteredCollection filteredPoints, int maxCount, BotZone zone, BotCreationData creationData, float time) { }

	[CanBeNull]
	private static ISpawnPoint GetSpawnPoint(IReadOnlyCollection zoneSpawnPoints, IReadOnlyCollection allSpawnPoints, IGetProfileData profileData, IReadOnlyCollection groupPlayers, IReadOnlyCollection noneGroupPlayers, IReadOnlyCollection carePlayers, float distanceSqr, float time, string profileId) { }

	public override bool IsValidSpawn(ISpawnPoint spawnPoint, BotCreationData profileData, float time) { }

	[CanBeNull]
	private List SelectAISpawnPoints(BotCreationData profileData, BotZone zone, int maxCount, float time, Nullable closestBossPos = null, ActionIfNotEnoughPoints mode = 1) { }

	private static void SetKdToSpawnPoints(BotCreationData profileData, List selectedPoints, float currentTime) { }

	public override bool TryGetSpawnPointById(string id, out ISpawnPoint spawnPoint) { }

	public override void Validate() { }

}

