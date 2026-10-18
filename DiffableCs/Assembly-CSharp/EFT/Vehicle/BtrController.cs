namespace EFT.Vehicle;

public sealed class BtrController : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__64_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <InitBTRServer>b__64_0(PathConfig x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public string locationId; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal bool <InitServer>b__0(KeyValuePair x) { }

		internal bool <InitServer>b__1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public string locationId; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal bool <InitClient>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public string subServiceId; //Field offset: 0x10

		public <>c__DisplayClass83_0() { }

		internal bool <GetPlayerTaxiPriceForProfile>b__0(SubService x) { }

	}

	[CompilerGenerated]
	private struct <InitClient>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BtrController <>4__this; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitController>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BtrController <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitServer>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BtrController <>4__this; //Field offset: 0x20
		private <>c__DisplayClass55_0 <>8__1; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InteractWithBtrView>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BtrController <>4__this; //Field offset: 0x20
		public Player player; //Field offset: 0x28
		public InteractWithBtrPacket packet; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x3C
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegisterBotShooterBTR>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BtrController <>4__this; //Field offset: 0x28
		public BotOwner owner; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string BTR_INTERACTION_MESSAGE_KEY = "Btr/InteractionMessage"; //Field offset: 0x0
	private const string BTR_SERVICE_PURCHASED = "Btr/ServicePurchased"; //Field offset: 0x0
	private const string MAP_PATH_CONFIGURATIONS_ROOT_DIRECTORY = "MapPathsConfigurations"; //Field offset: 0x0
	private const string MAP_LOAD_PATH_POSTFIX = "MapPathsConfiguration"; //Field offset: 0x0
	private const string BTR_SERVER_TEMPLATE_PATH = "BTRTemplates/Server/BTRTemplate"; //Field offset: 0x0
	private const string BTR_CLIENT_TEMPLATE_ROOT_PATH = "BTRTemplates/Client/BTRView/Variants"; //Field offset: 0x0
	private const string BTR_VIEW_NAME_BASE = "BTRView"; //Field offset: 0x0
	[CompilerGenerated]
	private static BtrController <Instance>k__BackingField; //Field offset: 0x0
	private readonly GameWorld _gameWorld; //Field offset: 0x10
	[CompilerGenerated]
	private TransferItemsController <TransferItemsController>k__BackingField; //Field offset: 0x18
	private Dictionary destinationPrices; //Field offset: 0x20
	public Vector2 WaitForPassengerRange; //Field offset: 0x28
	private float _chanceSpawnBTR; //Field offset: 0x30
	private Vector2 _spawnPeriod; //Field offset: 0x34
	private int _calculatedSpawnTime; //Field offset: 0x3C
	private bool _spawnBTR; //Field offset: 0x40
	private bool _offlineGame; //Field offset: 0x41
	[CompilerGenerated]
	private BTRVehicle <BtrVehicle>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private BTRView <BtrView>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsBtrPaid>k__BackingField; //Field offset: 0x58
	public MapPathConfig MapPathsConfiguration; //Field offset: 0x60
	private CancellationTokenSource _initializeCancellationTokenSource; //Field offset: 0x68
	private Action _unsubscribeBtrServicePurchased; //Field offset: 0x70
	private Action _unsubscribeBtrNotificationInteractionMessage; //Field offset: 0x78
	private Action _unsubscribeBtrReadyViewMessage; //Field offset: 0x80
	private BTRGlobalSettings _btrGlobalSettings; //Field offset: 0x88
	[CompilerGenerated]
	private BotOwner <BotShooterBtr>k__BackingField; //Field offset: 0x90
	private BTRServerSettings _btrServerSettings; //Field offset: 0x98
	private bool _botCoverPaid; //Field offset: 0xA0
	private bool _serverInited; //Field offset: 0xA1
	private ShapshotBTRMessage _offlineSyncPacket; //Field offset: 0xA4

	public private BotOwner BotShooterBtr
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BTRVehicle BtrVehicle
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BTRView BtrView
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private static BtrController Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 151
	}

	public private bool IsBtrPaid
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private TransferItemsController TransferItemsController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BtrController(GameWorld gameWorld) { }

	[CompilerGenerated]
	private bool <InitBTRServer>b__64_1(KeyValuePair x) { }

	public void BotCoverPurchase() { }

	private void BtrImplementationsPhysicsIgnore() { }

	private void CalculatePricesToDestination(PathDestination currentDestinationPoint, bool lastRoutePoint) { }

	private void ClientNotificationInteractionMessageHandler(BtrNotificationInteractionMessageEvent notificationInteractionMessage) { }

	private void ClientSyncServicePurchaseEvent(BtrServicePurchaseEvent servicePurchaseEvent) { }

	private void CreateFakeBtrServerSettings() { }

	public override void Dispose() { }

	public void ExplosionCheck(Collider affectedCollider, Vector3 explosionPosition, int playerId) { }

	private void GenerateChanceSpawnBtr() { }

	[CompilerGenerated]
	public BotOwner get_BotShooterBtr() { }

	[CompilerGenerated]
	public BTRVehicle get_BtrVehicle() { }

	[CompilerGenerated]
	public BTRView get_BtrView() { }

	[CompilerGenerated]
	public static BtrController get_Instance() { }

	[CompilerGenerated]
	public bool get_IsBtrPaid() { }

	[CompilerGenerated]
	public TransferItemsController get_TransferItemsController() { }

	public int GetBotCoverPriceForProfile(string profileId) { }

	private void GetBtrTraderServiceData(string profileId) { }

	private int GetNearestDestinationIndex(string destinationID, int currentDestinationIndex) { }

	private void GetOrUpdateTraderServiceData(Player player) { }

	public int GetPlayerTaxiPriceForProfile(string subServiceId, string profileId) { }

	public void HandleReconnectOnClient(string profileId) { }

	public void HitFromPlayer(Player player) { }

	private void InitBTROnClient() { }

	private void InitBTRServer() { }

	[AsyncStateMachine(typeof(<InitClient>d__59))]
	private Task InitClient() { }

	[AsyncStateMachine(typeof(<InitController>d__54))]
	private Task InitController(CancellationToken cancellationToken) { }

	public bool Initiated() { }

	[AsyncStateMachine(typeof(<InitServer>d__55))]
	private Task InitServer(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<InteractWithBtrView>d__85))]
	public Task InteractWithBtrView(Player player, InteractWithBtrPacket packet) { }

	private void LoadBTRVehicle() { }

	private void LoadBTRView(string btrVariantString) { }

	private void LoadMapPathsConfiguration(string locationID) { }

	public void LocalBtrInteraction(Player player, InteractWithBtrPacket packet) { }

	public void LocalGoIn(Player player, byte side, byte placeId, bool fast) { }

	public void LocalGoOut(Player player, byte side, byte placeId, bool fast) { }

	public void MoveToDestination(string idPathDestination, int playerId = -1) { }

	private void NotifyPurchaseService(List playersToNotify, ETraderServiceType serviceType) { }

	private void OnIncomingToDestination(PathDestination destinationPoint, bool isFirst, bool isFinal, bool lastRoutePoint) { }

	private void OnPlayerAddedToBtr(Player player) { }

	private void OnPlayerRemovedFromBtr(Player player) { }

	private void OnReadyClientView(BtrViewReadyEvent readyEvent) { }

	private void OnUpdate(float deltaTime) { }

	[AsyncStateMachine(typeof(<RegisterBotShooterBTR>d__53))]
	public void RegisterBotShooterBTR(BotOwner owner) { }

	[CompilerGenerated]
	private void set_BotShooterBtr(BotOwner value) { }

	[CompilerGenerated]
	private void set_BtrVehicle(BTRVehicle value) { }

	[CompilerGenerated]
	private void set_BtrView(BTRView value) { }

	[CompilerGenerated]
	private static void set_Instance(BtrController value) { }

	[CompilerGenerated]
	private void set_IsBtrPaid(bool value) { }

	[CompilerGenerated]
	private void set_TransferItemsController(TransferItemsController value) { }

	private void SyncBtrOffline() { }

	public void SyncBTRVehicleFromServer(ShapshotBTRMessage snapshotMessage) { }

	private void TriggerNearbyTripwires() { }

}

