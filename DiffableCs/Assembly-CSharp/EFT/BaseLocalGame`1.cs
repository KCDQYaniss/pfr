namespace EFT;

internal abstract class BaseLocalGame`1 : AbstractGame, IGame, IGame, IGame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__61_0; //Field offset: 0x0
		public static Func <>9__61_2; //Field offset: 0x0
		public static Func <>9__61_3; //Field offset: 0x0
		public static Func <>9__67_0; //Field offset: 0x0
		public static Func <>9__67_1; //Field offset: 0x0
		public static Func <>9__85_3; //Field offset: 0x0
		public static Func <>9__85_0; //Field offset: 0x0
		public static Func <>9__85_1; //Field offset: 0x0
		public static Func <>9__85_2; //Field offset: 0x0
		public static Func <>9__93_0; //Field offset: 0x0
		public static Func <>9__93_1; //Field offset: 0x0
		public static Func <>9__93_2; //Field offset: 0x0
		public static Action <>9__95_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <GameEnd>b__95_1() { }

		internal Item <GetLostInsuredItems>b__93_0(LootItem x) { }

		internal Item <GetLostInsuredItems>b__93_1(LootableContainer x) { }

		internal string <GetLostInsuredItems>b__93_2(InsuredProfileItems item) { }

		internal float <PlayerFactory>b__67_0() { }

		internal float <PlayerFactory>b__67_1() { }

		internal float <Run>b__61_0() { }

		internal float <Run>b__61_2() { }

		internal float <Run>b__61_3() { }

		internal Item <SpawnLoot>b__85_0(JsonLootItem x) { }

		internal bool <SpawnLoot>b__85_1(Item x) { }

		internal IEnumerable <SpawnLoot>b__85_2(Item x) { }

		internal bool <SpawnLoot>b__85_3(JsonLootItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0`1
	{
		public TGameType game; //Field offset: 0x0
		public IInputTree inputTree; //Field offset: 0x0
		public InsuranceCompany insurance; //Field offset: 0x0
		public IEftSession backEndSession; //Field offset: 0x0
		public GameUI gameUI; //Field offset: 0x0
		public Location location; //Field offset: 0x0

		public <>c__DisplayClass13_0`1() { }

		internal TPlayerOwner <Create>b__0(LocalPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		private struct <<Run>b__1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public <>c__DisplayClass61_0 <>4__this; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public BaseLocalGame <>4__this; //Field offset: 0x0
		public ISpawnSystem spawnSystem; //Field offset: 0x0

		public <>c__DisplayClass61_0() { }

		[AsyncStateMachine(typeof(<<Run>b__1>d))]
		internal Task <Run>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public string profileId; //Field offset: 0x0
		public ExitStatus exitStatus; //Field offset: 0x0
		public string exitName; //Field offset: 0x0
		public float delay; //Field offset: 0x0

		public <>c__DisplayClass92_0() { }

		internal void <Stop>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public ExitStatus exitStatus; //Field offset: 0x0
		public TimeSpan duration; //Field offset: 0x0

		public <>c__DisplayClass95_0() { }

		internal void <GameEnd>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static UpdateFunction <0>__CustomUpdate; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <GameEnd>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public ExitStatus exitStatus; //Field offset: 0x0
		public string exitName; //Field offset: 0x0
		private <>c__DisplayClass95_0 <>8__1; //Field offset: 0x0
		public float delay; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalBotsControllerInitialization>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalBotsSpawnInitialization>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayerFactory>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Profile profile; //Field offset: 0x0
		public IEftSession session; //Field offset: 0x0
		public GameWorld gameWorld; //Field offset: 0x0
		public int playerId; //Field offset: 0x0
		public Vector3 position; //Field offset: 0x0
		public Quaternion rotation; //Field offset: 0x0
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public EUpdateMode armsUpdateMode; //Field offset: 0x0
		public ELocalMode localMode; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public BotControllerSettings botsSettings; //Field offset: 0x0
		private Location <location>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private Token <>7__wrap2; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SessionRun>d__72 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public BaseLocalGame <>4__this; //Field offset: 0x0
		public Action runCallback; //Field offset: 0x0

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
		public <SessionRun>d__72(int <>1__state) { }

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
	private struct <SpawnLoot>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Location location; //Field offset: 0x0
		public BaseLocalGame <>4__this; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private PlayerLoopSystem <currentLoop>5__3; //Field offset: 0x0
		private PlayerLoopSystem <parent>5__4; //Field offset: 0x0
		private int <index>5__5; //Field offset: 0x0
		private PlayerLoopSystem[] <originalSubsystems>5__6; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class CustomUpdateTextureStreamingManager
	{

		public CustomUpdateTextureStreamingManager() { }

	}

	private bool _spiritWasUsed; //Field offset: 0x0
	[CompilerGenerated]
	private Profile <Profile>k__BackingField; //Field offset: 0x0
	protected readonly BotsController BotsController; //Field offset: 0x0
	private readonly Dictionary _specialTimeResolver; //Field offset: 0x0
	private int _nextPlayerId; //Field offset: 0x0
	protected SpawnsLogger _spawnsLogger; //Field offset: 0x0
	protected readonly Dictionary _players; //Field offset: 0x0
	private string _entryPoint; //Field offset: 0x0
	private EDateTime _selectedDateTime; //Field offset: 0x0
	private DateTime _localDateTime; //Field offset: 0x0
	private Action _removeConsoleCommand; //Field offset: 0x0
	protected LocalRaidSettings _raidSettings; //Field offset: 0x0
	protected ClientMetricsEvents _metricsEvents; //Field offset: 0x0
	protected ClientMetricsCollector _metricsCollector; //Field offset: 0x0
	protected ReleaseProfilerSpikeAnalyser _releaseProfilerSpikeAnalyser; //Field offset: 0x0
	protected TPlayerOwner _playerOwner; //Field offset: 0x0
	private Func _ownerFactory; //Field offset: 0x0
	private Func _playerFactory; //Field offset: 0x0
	private EndByTimerScenario _endByTimerScenario; //Field offset: 0x0
	private EndByExitTrigerScenario _endByExitTrigerScenario; //Field offset: 0x0
	private Callback _callback; //Field offset: 0x0
	protected IEftSession _backEnd; //Field offset: 0x0
	private GameUI _gameUI; //Field offset: 0x0
	private GameDateTime _backendDateTime; //Field offset: 0x0
	protected DateTime SessionStartTime; //Field offset: 0x0
	[CompilerGenerated]
	private LocalPlayer <LocalPlayer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private GameWorld <GameWorld>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private GameDateTime <GameDateTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Location <Location>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Action UpdateByUnity; //Field offset: 0x0

	public override event Action UpdateByUnity
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public List AllPlayers
	{
		 get { } //Length: 542
	}

	public private override GameDateTime GameDateTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected virtual GameUI GameUi
	{
		 get { } //Length: 8
	}

	protected private GameWorld GameWorld
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private LocalPlayer LocalPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override Location Location
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual string LocationId
	{
		 get { } //Length: 30
	}

	public virtual string LocationObjectId
	{
		 get { } //Length: 30
	}

	public TPlayerOwner PlayerOwner
	{
		 get { } //Length: 8
	}

	protected private Profile Profile
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected virtual string ProfileId
	{
		 get { } //Length: 30
	}

	protected virtual int RaidID
	{
		 get { } //Length: 44
	}

	protected BaseLocalGame`1() { }

	[CompilerGenerated]
	internal static Task <LoadLocation>g__Parse|69_0(UnparsedData unparsedData) { }

	[CompilerGenerated]
	private void <LocalLeaveGame>b__71_0() { }

	[CompilerGenerated]
	private bool <OnStatusChangedHandler>b__70_0(Player x) { }

	[CompilerGenerated]
	private void <Spawn>g__Action|80_0(EDamageType controller) { }

	[CompilerGenerated]
	private void <SpawnLoot>b__85_4(InitLevelProgress p) { }

	[CompilerGenerated]
	public override void add_UpdateByUnity(Action value) { }

	public override Task BotDespawn(BotOwner botOwner) { }

	protected static void CleanUp(IDictionary players) { }

	public override void CleanUp() { }

	protected override ClientMetrics CollectMetrics() { }

	private override Task CommonAssets.Scripts.Game.EndByExitTrigerScenario.IGame.StopSession(int playerRaidId, ExitStatus exitStatus, string exitName) { }

	private override Task CommonAssets.Scripts.Game.EndByExitTrigerScenario.IGame.StopSession(string profileId, ExitStatus exitStatus, string exitName) { }

	protected static TGameType Create(IInputTree inputTree, Profile profile, GameWorld gameWorld, GameDateTime backendDateTime, InsuranceCompany insurance, GameUI gameUI, Location location, TimeAndWeatherSettings timeAndWeather, WavesSettings wavesSettings, EDateTime dateTime, Callback callback, float fixedDeltaTime, EUpdateQueue updateQueue, IEftSession backEndSession, Nullable sessionTime, ClientMetricsEvents metricsEvents, ClientMetricsCollector metricsCollector, LocalRaidSettings raidSettings) { }

	protected override void CreateSpawnLogger() { }

	private static void CustomUpdate() { }

	private override void EFT.EndByTimerScenario.IGame.StopGame() { }

	private override GameObject EFT.IGame.get_gameObject() { }

	[AsyncStateMachine(typeof(<GameEnd>d__95))]
	private Task GameEnd(string profileId, ExitStatus exitStatus, string exitName, float delay) { }

	public List get_AllPlayers() { }

	[CompilerGenerated]
	public override GameDateTime get_GameDateTime() { }

	protected virtual GameUI get_GameUi() { }

	[CompilerGenerated]
	protected GameWorld get_GameWorld() { }

	[CompilerGenerated]
	protected LocalPlayer get_LocalPlayer() { }

	[CompilerGenerated]
	public override Location get_Location() { }

	public virtual string get_LocationId() { }

	public virtual string get_LocationObjectId() { }

	public TPlayerOwner get_PlayerOwner() { }

	[CompilerGenerated]
	protected Profile get_Profile() { }

	protected virtual string get_ProfileId() { }

	protected virtual int get_RaidID() { }

	private FlatItem[] GetLostInsuredItems() { }

	private Dictionary GetTransferItems() { }

	private void InitiateGameStopping() { }

	protected abstract IEnumerator InitSessionUI() { }

	private void InitWeather(TimeAndWeatherSettings timeAndWeather) { }

	public void ItemPlaced(DroppedItem droppedItem, string profileId) { }

	public void ItemRemoved(DroppedItem droppedItem) { }

	private Task LoadLocation(string backendUrl) { }

	[AsyncStateMachine(typeof(<LocalBotsControllerInitialization>d__64))]
	protected override Task LocalBotsControllerInitialization(BotControllerSettings controllerSettings, ISpawnSystem spawnSystem) { }

	[AsyncStateMachine(typeof(<LocalBotsSpawnInitialization>d__63))]
	protected override Task LocalBotsSpawnInitialization() { }

	protected override void LocalLeaveGame() { }

	private static void ModifyBotsOnLoaction(Location location, WavesSettings wavesSettings) { }

	protected int NextPlayerId() { }

	private void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus) { }

	[AsyncStateMachine(typeof(<PlayerFactory>d__67))]
	protected override Task PlayerFactory(GameWorld gameWorld, int playerId, Vector3 position, Quaternion rotation, string layerName, string prefix, EPointOfView pointOfView, Profile profile, bool aiControl, EUpdateQueue updateQueue, EUpdateMode armsUpdateMode, EUpdateMode bodyUpdateMode, Mode characterControllerMode, Func getSensitivity, Func getAimingSensitivity, IStatisticsManager statisticsManager, IEftSession session, ELocalMode localMode) { }

	private Task PrepareSession() { }

	[CompilerGenerated]
	public override void remove_UpdateByUnity(Action value) { }

	private static bool ReplaceSystem(ref PlayerLoopSystem system, PlayerLoopSystem replacement) { }

	[AsyncStateMachine(typeof(<Run>d__61))]
	internal Task Run(BotControllerSettings botsSettings, string backendUrl, InventoryController inventoryController) { }

	[IteratorStateMachine(typeof(<SessionRun>d__72))]
	protected override IEnumerator SessionRun(Action runCallback) { }

	protected override void SessionRun() { }

	[CompilerGenerated]
	private void set_GameDateTime(GameDateTime value) { }

	[CompilerGenerated]
	private void set_GameWorld(GameWorld value) { }

	[CompilerGenerated]
	private void set_LocalPlayer(LocalPlayer value) { }

	[CompilerGenerated]
	private void set_Location(Location value) { }

	[CompilerGenerated]
	private void set_Profile(Profile value) { }

	protected virtual void SetMatchmakerStatus(EMatchingStage stage, Nullable progress = null) { }

	protected override void Spawn() { }

	[AsyncStateMachine(typeof(<SpawnLoot>d__85))]
	private Task SpawnLoot(Location location) { }

	public void StartGameTimer() { }

	public override void Stop(string profileId, ExitStatus exitStatus, string exitName, float delay = 0) { }

	private void Update() { }

	private void UpdateShotStatistic(Item item, Ammo ammo) { }

	private void UploadLocationToCache(string backendUrl, string locationId, int variantId) { }

}

