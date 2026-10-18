namespace EFT;

[ScriptOrder(-2000)]
public abstract class GameWorld : MonoBehaviour, IGameLevel, IPlayersCollection, IEnumerable, IEnumerable, IDisposable, ISyncEnvironment
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__172_0; //Field offset: 0x8
		public static Func <>9__250_0; //Field offset: 0x10
		public static Func <>9__256_0; //Field offset: 0x18
		public static Func <>9__262_1; //Field offset: 0x20
		public static Func <>9__308_2; //Field offset: 0x28
		public static Func <>9__308_3; //Field offset: 0x30
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"item", "data"})]
		public static Func <>9__327_0; //Field offset: 0x38
		public static Func <>9__346_0; //Field offset: 0x40
		public static Action <>9__346_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal TrajectoryCalculator <.ctor>b__346_0() { }

		internal void <.ctor>b__346_1(TrajectoryCalculator calculator) { }

		internal bool <DestroyBadLootContainers>b__256_0(IStaticLoot x) { }

		internal string <DestroyContainers>b__262_1(Transform x) { }

		internal Item <FindItemById>b__327_0(ValueTuple e) { }

		internal bool <GetEnumerator>b__172_0(IPlayer x) { }

		internal ResourceKey <InitLevel>b__250_0(string x) { }

		internal MongoID <ManageQuestLoot>b__308_2(Item x) { }

		internal bool <ManageQuestLoot>b__308_3(Quest quest) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass252_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass252_0() { }

		internal bool <DestroyLoot>b__0(LootItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass259_0
	{
		public string lootId; //Field offset: 0x10

		public <>c__DisplayClass259_0() { }

		internal bool <SpawnLoot>b__0(IStaticLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass261_0
	{
		public GameWorld <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18

		public <>c__DisplayClass261_0() { }

		internal bool <DevelopSetContainerVisibility>b__1(LootableContainer x) { }

		internal void <DevelopSetContainerVisibility>g__DeleteContainer|0(LootableContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass262_0
	{
		public IStaticLoot staticLootSpawn; //Field offset: 0x10

		public <>c__DisplayClass262_0() { }

		internal bool <DestroyContainers>b__0(JsonLootItem lootItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass301_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass301_0() { }

		internal bool <FindStationaryWeapon>b__0(StationaryWeapon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass303_0
	{
		public string itemId; //Field offset: 0x10

		public <>c__DisplayClass303_0() { }

		internal bool <FindStationaryWeaponByItemId>b__0(StationaryWeapon x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass308_0
	{
		public Player player; //Field offset: 0x0
		public Dictionary playerQuestStatusDict; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass326_0
	{
		public string ownerId; //Field offset: 0x10

		public <>c__DisplayClass326_0() { }

		internal bool <FindOwnerWithWorldData>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <GetParentList>d__263 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Transform <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Transform transform; //Field offset: 0x28
		public Transform <>3__transform; //Field offset: 0x30

		private override Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
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
		public <GetParentList>d__263(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator() { }

		[DebuggerHidden]
		private override Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <InitializeEffects>d__251 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitLevel>d__250 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameWorld <>4__this; //Field offset: 0x20
		public bool loadBundlesAndCreatePools; //Field offset: 0x28
		public List resources; //Field offset: 0x30
		public ObjectsFactoryConfig config; //Field offset: 0x38
		public IProgress progress; //Field offset: 0x40
		public CancellationToken ct; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private Token <>7__wrap1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ManageQuestLoot>d__308 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Player player; //Field offset: 0x20
		public GameWorld <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SelectRandomBattlePassDocumentLootItems>d__310 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private JsonLootItem <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private int count; //Field offset: 0x24
		public int <>3__count; //Field offset: 0x28
		public GameWorld <>4__this; //Field offset: 0x30
		private List <documentLootItems>5__2; //Field offset: 0x38
		private Enumerator <>7__wrap2; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x58

		private override JsonLootItem System.Collections.Generic.IEnumerator<JsonType.JsonLootItem>.Current
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
		public <SelectRandomBattlePassDocumentLootItems>d__310(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<JsonType.JsonLootItem>.GetEnumerator() { }

		[DebuggerHidden]
		private override JsonLootItem System.Collections.Generic.IEnumerator<JsonType.JsonLootItem>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class InventoryTransferError : Error
	{
		public readonly Player Player; //Field offset: 0x10

		public InventoryTransferError(Player player) { }

		public virtual string ToString() { }

	}

	internal class ItemAddressNotFoundError : Error
	{
		private readonly string _parentId; //Field offset: 0x10
		private readonly string _containerId; //Field offset: 0x18

		public ItemAddressNotFoundError(string parentId, string containerId) { }

		public virtual string ToString() { }

	}

	internal class ItemNotFoundError : Error
	{
		public readonly string ItemId; //Field offset: 0x10

		public ItemNotFoundError(string itemId) { }

		public virtual string ToString() { }

	}

	internal class ItemOwnerCandidateCantFindLootError : Error
	{
		public readonly IItemOwner ItemOwner; //Field offset: 0x10
		public readonly Item Item; //Field offset: 0x18
		public readonly Vector3 OwnerPosition; //Field offset: 0x20
		public readonly Vector3 ItemPosition; //Field offset: 0x2C

		public ItemOwnerCandidateCantFindLootError(IItemOwner itemOwner, Item item, Vector3 ownerPosition, Vector3 itemPosition) { }

		public virtual string ToString() { }

	}

	internal class ItemOwnerCandidateTooFarError : Error
	{
		public readonly IItemOwner ItemOwner; //Field offset: 0x10
		public readonly Item Item; //Field offset: 0x18
		public readonly Vector3 OwnerPosition; //Field offset: 0x20
		public readonly Vector3 ItemPosition; //Field offset: 0x2C

		public ItemOwnerCandidateTooFarError(IItemOwner itemOwner, Item item, Vector3 ownerPosition, Vector3 itemPosition) { }

		public virtual string ToString() { }

	}

	internal class ItemOwnerCandidateWallHackError : Error
	{
		public readonly IItemOwner ItemOwner; //Field offset: 0x10
		public readonly Item Item; //Field offset: 0x18
		public readonly Vector3 OwnerPosition; //Field offset: 0x20
		public readonly Vector3 ItemPosition; //Field offset: 0x2C
		public string ColliderName; //Field offset: 0x38

		public ItemOwnerCandidateWallHackError(IItemOwner itemOwner, Item item, Vector3 ownerPosition, Vector3 itemPosition, string colliderName) { }

		public virtual string ToString() { }

	}

	internal class ItemOwnerNotFoundError : Error
	{
		public readonly string ItemOwnerId; //Field offset: 0x10

		public ItemOwnerNotFoundError(string itemOwnerId) { }

		public virtual string ToString() { }

	}

	internal class ItemOwnerNullError : Error
	{
		public readonly Item Item; //Field offset: 0x10

		public ItemOwnerNullError(Item item) { }

		public virtual string ToString() { }

	}

	internal struct ItemOwnerWorldData
	{
		public Transform Transform; //Field offset: 0x0
		public bool DoNotPerformPickUpValidation; //Field offset: 0x8
		public IItemOwner ItemOwner; //Field offset: 0x10

	}

	internal sealed class ItemTooFarError : Error
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Vector3 PlayerPosition; //Field offset: 0x18
		public readonly Vector3 ItemPosition; //Field offset: 0x24

		public ItemTooFarError(Item item, Vector3 playerPosition, Vector3 itemPosition) { }

		public virtual string ToString() { }

	}

	internal sealed class TransferBetweenAlivePlayersError : Error
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Player CurrentPlayer; //Field offset: 0x18
		[CanBeNull]
		public readonly Player FromPlayer; //Field offset: 0x20
		[CanBeNull]
		public readonly Player ToPlayer; //Field offset: 0x28
		public readonly bool KnownDirection; //Field offset: 0x30

		public TransferBetweenAlivePlayersError(Player currentPlayer, Item item, Player fromPlayer, Player toPlayer) { }

		public TransferBetweenAlivePlayersError(Player currentPlayer, Player anotherPlayer, Item item) { }

		[CompilerGenerated]
		private string <ToString>g__PlayerToString|7_0(Player player) { }

		public virtual string ToString() { }

	}

	internal sealed class TryToPickUpOneOffBreakWeaponError : Error
	{
		public readonly Player Player; //Field offset: 0x10

		public TryToPickUpOneOffBreakWeaponError(Player player) { }

		public virtual string ToString() { }

	}

	[CompilerGenerated]
	private static Action OnDispose; //Field offset: 0x0
	private static int _obstaclesCollider; //Field offset: 0x8
	private static readonly RaycastHit[] InteractionSenseHits; //Field offset: 0x10
	protected static int _interactiveLootMask; //Field offset: 0x18
	private static int _interactiveLootMaskWPlayer; //Field offset: 0x1C
	private static int _playerMask; //Field offset: 0x20
	private static int _lootMaskObstruction; //Field offset: 0x24
	public Task PrewarmPoolsTask; //Field offset: 0x20
	[CompilerGenerated]
	private BtrController <BtrController>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private SyncModule <SyncModule>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private TransitController <TransitController>k__BackingField; //Field offset: 0x38
	public readonly Dictionary ObservedPlayersCorpses; //Field offset: 0x40
	[CompilerGenerated]
	private PasscodeController <PasscodeController>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private IVolumePropagationSystem <VolumetricPropagationSystem>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private RunddansController <RunddansController>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private KolotunController <KolotunController>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private ExfiltrationController <ExfiltrationController>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private RaidDialogEntryController <RaidDialogEntryController>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private BufferZoneController <BufferZoneController>k__BackingField; //Field offset: 0x78
	protected readonly Dictionary AllPlayerBridgesEverExisted; //Field offset: 0x80
	[CompilerGenerated]
	private HalloweenEventController <HalloweenEventController>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private ISeasonsController <SeasonsController>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private TriggersModule <TriggersModule>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private TriggersEmitter <TriggersEmitter>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private BotsCulling <BotsCulling>k__BackingField; //Field offset: 0xA8
	public readonly TraderServicesHandler TraderServicesHandler; //Field offset: 0xB0
	[CompilerGenerated]
	private ArtilleryShellingControllerServer <ServerShellingController>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private ArtilleryShellingControllerClient <ClientShellingController>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private CutscenesServerController <CutscenesServerController>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private BotsCullingClientController <BotsCullingClientController>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private CutscenesClientController <CutscenesClientController>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private ClientBroadcastSyncController <ClientBroadcastSyncController>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private string <LocationId>k__BackingField; //Field offset: 0xE8
	public GameDateTime GameDateTime; //Field offset: 0xF0
	public GameWorldUnityTickListener UnityTickListener; //Field offset: 0xF8
	public bool SpeedLimitsEnabled; //Field offset: 0x100
	public Config SpeedLimits; //Field offset: 0x108
	public Nullable CurrentProfileId; //Field offset: 0x110
	[CompilerGenerated]
	private Action AfterGameStarted; //Field offset: 0x130
	[CompilerGenerated]
	private Action OnPersonAdd; //Field offset: 0x138
	private readonly Dictionary _lampGroups; //Field offset: 0x140
	public bool timerStartByEvent; //Field offset: 0x148
	[CompilerGenerated]
	private Action OnBeforeWorldTick; //Field offset: 0x150
	protected readonly Dictionary AllAlivePlayerBridgesByCollider; //Field offset: 0x158
	[CompilerGenerated]
	private Action OnLateUpdate; //Field offset: 0x160
	private readonly HardwareTime _hardwareTime; //Field offset: 0x168
	public AudioSourceCulling AudioSourceCulling; //Field offset: 0x170
	public ObjectPool TrajectoryCalculatorPool; //Field offset: 0x178
	public readonly List AllLoot; //Field offset: 0x180
	[CompilerGenerated]
	private IBallisticsCalculator <ClientBallisticCalculator>k__BackingField; //Field offset: 0x188
	private BallisticsCalculator _sharedBallisticsCalculator; //Field offset: 0x190
	private int _lastPlayerRaidId; //Field offset: 0x198
	private readonly Dictionary _lampControllers; //Field offset: 0x1A0
	protected readonly Dictionary AllAlivePlayerBridges; //Field offset: 0x1A8
	public readonly List LootList; //Field offset: 0x1B0
	private readonly Dictionary _allPlayersEverExistedByRaidId; //Field offset: 0x1B8
	private readonly Dictionary _allPlayersEverExistedByProfileId; //Field offset: 0x1C0
	public readonly List AllAlivePlayersList; //Field offset: 0x1C8
	public readonly List RegisteredPlayers; //Field offset: 0x1D0
	public readonly DictionaryListHydra LootItems; //Field offset: 0x1D8
	public readonly HashSet QuestItemsList; //Field offset: 0x1E0
	private MovingPlatform[] _platforms; //Field offset: 0x1E8
	public readonly Dictionary allAlivePlayersByRaidID; //Field offset: 0x1F0
	public readonly Dictionary allAlivePlayersByProfileID; //Field offset: 0x1F8
	public readonly Dictionary ItemOwners; //Field offset: 0x200
	public NetworkAdapter[] PlatformAdapters; //Field offset: 0x208
	public BorderZone[] BorderZones; //Field offset: 0x210
	public Dictionary allObservedPlayersByRaidID; //Field offset: 0x218
	public SpeakerManager SpeakerManager; //Field offset: 0x220
	private EUpdateQueue _updateQueue; //Field offset: 0x228
	public Player MainPlayer; //Field offset: 0x230
	private World _world; //Field offset: 0x238
	protected ObjectsFactory ObjectsFactory; //Field offset: 0x240
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x248
	[CompilerGenerated]
	private readonly Dictionary <PlayersColliders>k__BackingField; //Field offset: 0x250
	protected Dictionary LootItemBoundColliderMapping; //Field offset: 0x258
	private readonly List _ammoShells; //Field offset: 0x260
	private readonly List _questLootItems; //Field offset: 0x268
	private readonly List _battlePassDocumentLootItems; //Field offset: 0x270
	[CompilerGenerated]
	private SynchronizableObjectLogicProcessor <SynchronizableObjectLogicProcessor>k__BackingField; //Field offset: 0x278
	public MineDirectionalManager MineManager; //Field offset: 0x280
	[CompilerGenerated]
	private Action OnLootItemDestroyed; //Field offset: 0x288
	private Token _effectsResources; //Field offset: 0x290
	public ThrowItemDelegate OnThrowItem; //Field offset: 0x298
	public TakeItemDelegate OnTakeItem; //Field offset: 0x2A0
	protected readonly Dictionary Turnables; //Field offset: 0x2A8
	public readonly DictionaryListHydra Windows; //Field offset: 0x2B0
	public readonly DictionaryListHydra Grenades; //Field offset: 0x2B8
	public List GrenadesCriticalStates; //Field offset: 0x2C0
	private readonly List _preAllocatedGameObjectsToDelete; //Field offset: 0x2C8
	public List ArtilleryProjectilesStates; //Field offset: 0x2D0
	private GrenadeFactory _grenadeFactory; //Field offset: 0x2D8
	private bool _controlBundlesAndPools; //Field offset: 0x2E0
	private BaseRestrictableZone[] _restrictableZones; //Field offset: 0x2E8
	protected EffectsCommutator _effectsCommutator; //Field offset: 0x2F0
	private BallisticCollider _defaultBallisticCollider; //Field offset: 0x2F8
	internal World NetworkWorld; //Field offset: 0x300
	private List _openingDoors; //Field offset: 0x308

	public event Action AfterGameStarted
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnBeforeWorldTick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public static event Action OnDispose
	{
		[CompilerGenerated]
		 add { } //Length: 335
		[CompilerGenerated]
		 remove { } //Length: 335
	}

	public event Action OnLateUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnLootItemDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnPersonAdd
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public IEnumerable AllPlayersEverExisted
	{
		 get { } //Length: 76
	}

	public BotsCulling BotsCulling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BotsCullingClientController BotsCullingClientController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BtrController BtrController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BufferZoneController BufferZoneController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private IBallisticsCalculator ClientBallisticCalculator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ClientBroadcastSyncController ClientBroadcastSyncController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ArtilleryShellingControllerClient ClientShellingController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CutscenesClientController CutscenesClientController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public CutscenesServerController CutscenesServerController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public float DeltaTime
	{
		 get { } //Length: 39
	}

	public ExfiltrationController ExfiltrationController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override GrenadeFactory GrenadeFactory
	{
		 get { } //Length: 8
	}

	public HalloweenEventController HalloweenEventController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public static int InteractiveLootMask
	{
		 get { } //Length: 83
	}

	public static int InteractiveLootMaskWPlayer
	{
		 get { } //Length: 83
	}

	[CanBeNull]
	public KolotunController KolotunController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string LocationId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public static int LootMaskObstruction
	{
		 get { } //Length: 83
	}

	[CanBeNull]
	public PasscodeController PasscodeController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MovingPlatform[] Platforms
	{
		 get { } //Length: 358
		 set { } //Length: 82
	}

	protected Dictionary PlayersColliders
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RaidDialogEntryController RaidDialogEntryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BaseRestrictableZone[] RestrictableZones
	{
		 get { } //Length: 8
	}

	[CanBeNull]
	public RunddansController RunddansController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal ISeasonsController SeasonsController
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public ArtilleryShellingControllerServer ServerShellingController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private IBallisticsCalculator SharedBallisticsCalculator
	{
		 get { } //Length: 8
		private set { } //Length: 204
	}

	public SynchronizableObjectLogicProcessor SynchronizableObjectLogicProcessor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public SyncModule SyncModule
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override ulong TotalIngoingBytes
	{
		 get { } //Length: 3
	}

	public override ulong TotalOutgoingBytes
	{
		 get { } //Length: 3
	}

	[CanBeNull]
	public TransitController TransitController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TriggersEmitter TriggersEmitter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public TriggersModule TriggersModule
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public EUpdateQueue UpdateQueue
	{
		 get { } //Length: 7
	}

	[CanBeNull]
	public IVolumePropagationSystem VolumetricPropagationSystem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private World World
	{
		private get { } //Length: 170
	}

	private static GameWorld() { }

	protected GameWorld() { }

	[CompilerGenerated]
	internal static void <AfterPlayerTick>g__Operation|287_0(Player player) { }

	[CompilerGenerated]
	internal static void <DoOtherWorldTick>g__Operation|286_0(Player player) { }

	[CompilerGenerated]
	internal static bool <ManageQuestLoot>g__CheckCompletableItemCondition|308_0(CompletableCondition[] conditions, ref <>c__DisplayClass308_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static bool <ManageQuestLoot>g__CheckQuestConditions|308_1(QuestStatusCondition[] conditions, ref <>c__DisplayClass308_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static void <PlayerTick>g__Operation|285_0(Player player) { }

	[CompilerGenerated]
	private float <RegisterPlayer>b__305_0() { }

	[CompilerGenerated]
	public void add_AfterGameStarted(Action value) { }

	[CompilerGenerated]
	public void add_OnBeforeWorldTick(Action value) { }

	[CompilerGenerated]
	public static void add_OnDispose(Action value) { }

	[CompilerGenerated]
	public void add_OnLateUpdate(Action value) { }

	[CompilerGenerated]
	public override void add_OnLootItemDestroyed(Action value) { }

	[CompilerGenerated]
	public override void add_OnPersonAdd(Action value) { }

	private void AddNewGrenade(Throwable throwable) { }

	protected override void AfterPlayerTick(float dt) { }

	protected override void AfterWorldTick(float dt) { }

	protected override void Awake() { }

	protected override void BallisticsTick(float dt) { }

	protected override void BeforePlayerTick(float dt) { }

	protected override void BeforeWorldTick(float dt) { }

	public void BoardIfOnPlatform(IPlatformTransportee transportee, Vector3 position) { }

	public int CanPlayerSeepThrough(Collider collider) { }

	public override void ChangeLampState(Turnable turnable, EState state) { }

	public void ClearInteractiveObject() { }

	internal override void ConnectWithNetworkWorld(World world) { }

	public static TGameWorld Create(GameObject gameObject, ObjectsFactory objectsFactory, EUpdateQueue updateQueue, Nullable currentProfileId) { }

	public IBallisticsCalculator CreateClientBallisticsCalculator() { }

	protected override GrenadeFactory CreateGrenadeFactory() { }

	protected override LootItem CreateLootWithRigidbody(GameObject lootObject, Item item, string objectName, bool randomRotation, MongoID[] validProfiles, out BoxCollider objectCollider, bool syncable, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0) { }

	protected override LootItem CreateStaticLoot(GameObject lootObject, Item item, string lootName, bool randomRotation, MongoID[] validProfiles, string staticId = null, Vector3 shift = null) { }

	public int CulledPlayersCount() { }

	public override void DeActivateTripwire(TripwireSynchronizableObject tripwire) { }

	public void DestroyAllLoot() { }

	private IStaticLoot[] DestroyBadLootContainers(LootData lootItems, IStaticLoot[] staticLootSpawns) { }

	internal void DestroyBadLootContainers(LootData lootItems) { }

	private void DestroyContainers(LootData lootItems, ref IStaticLoot[] staticLootSpawns) { }

	public void DestroyLoot(IKillable loot) { }

	public override void DestroyLoot(string id) { }

	public void DevelopSetContainerVisibility(int command, string id) { }

	public override void Dispose() { }

	private void DisposePlayersLists() { }

	public void DoOtherWorldTick(float dt) { }

	public void DoWorldTick(float dt) { }

	private override IBallisticsCalculator EFT.IGameLevel.CreateBallisticCalculator(int seed) { }

	public void FillLampControllers() { }

	public WorldInteractiveObject FindDoor(string doorId) { }

	[CanBeNull]
	public static GameObject FindInteractable(Ray ray, out RaycastHit hit) { }

	public Option FindItemById(string itemId) { }

	public Option FindItemWithWorldData(string itemId) { }

	public static LootItem FindNearestQuestLoot(LootItem lastNearestLootItem, Vector3 playerPos, float maxSqrDistance) { }

	[CanBeNull]
	public IItemOwner FindOwnerById(string ownerId) { }

	public KeyValuePair FindOwnerWithWorldData(string ownerId) { }

	public StationaryWeapon FindStationaryWeapon(string id) { }

	public StationaryWeapon FindStationaryWeaponByItemId(string itemId) { }

	public int GeneratePlayerRaidId() { }

	public IEnumerable get_AllPlayersEverExisted() { }

	[CompilerGenerated]
	public BotsCulling get_BotsCulling() { }

	[CompilerGenerated]
	public BotsCullingClientController get_BotsCullingClientController() { }

	[CompilerGenerated]
	public BtrController get_BtrController() { }

	[CompilerGenerated]
	public BufferZoneController get_BufferZoneController() { }

	[CompilerGenerated]
	public IBallisticsCalculator get_ClientBallisticCalculator() { }

	[CompilerGenerated]
	public ClientBroadcastSyncController get_ClientBroadcastSyncController() { }

	[CompilerGenerated]
	public ArtilleryShellingControllerClient get_ClientShellingController() { }

	[CompilerGenerated]
	public CutscenesClientController get_CutscenesClientController() { }

	[CompilerGenerated]
	public CutscenesServerController get_CutscenesServerController() { }

	public float get_DeltaTime() { }

	[CompilerGenerated]
	public ExfiltrationController get_ExfiltrationController() { }

	public override GrenadeFactory get_GrenadeFactory() { }

	[CompilerGenerated]
	public HalloweenEventController get_HalloweenEventController() { }

	public static int get_InteractiveLootMask() { }

	public static int get_InteractiveLootMaskWPlayer() { }

	[CompilerGenerated]
	public KolotunController get_KolotunController() { }

	[CompilerGenerated]
	public string get_LocationId() { }

	public static int get_LootMaskObstruction() { }

	[CompilerGenerated]
	public PasscodeController get_PasscodeController() { }

	public MovingPlatform[] get_Platforms() { }

	[CompilerGenerated]
	protected Dictionary get_PlayersColliders() { }

	[CompilerGenerated]
	public RaidDialogEntryController get_RaidDialogEntryController() { }

	public BaseRestrictableZone[] get_RestrictableZones() { }

	[CompilerGenerated]
	public RunddansController get_RunddansController() { }

	[CompilerGenerated]
	internal ISeasonsController get_SeasonsController() { }

	[CompilerGenerated]
	public ArtilleryShellingControllerServer get_ServerShellingController() { }

	public IBallisticsCalculator get_SharedBallisticsCalculator() { }

	[CompilerGenerated]
	public SynchronizableObjectLogicProcessor get_SynchronizableObjectLogicProcessor() { }

	[CompilerGenerated]
	public SyncModule get_SyncModule() { }

	public override ulong get_TotalIngoingBytes() { }

	public override ulong get_TotalOutgoingBytes() { }

	[CompilerGenerated]
	public TransitController get_TransitController() { }

	[CompilerGenerated]
	public TriggersEmitter get_TriggersEmitter() { }

	[CompilerGenerated]
	public TriggersModule get_TriggersModule() { }

	public EUpdateQueue get_UpdateQueue() { }

	[CompilerGenerated]
	public IVolumePropagationSystem get_VolumetricPropagationSystem() { }

	private World get_World() { }

	public IObserverToPlayerBridge GetAlivePlayerBridgeByCollider(Collider col) { }

	public IObserverToPlayerBridge GetAlivePlayerBridgeByRaidID(int playerRaidId) { }

	public Player GetAlivePlayerByProfileID(string playerProfileId) { }

	public Player GetAlivePlayerByRaidID(int playerRaidId) { }

	public override IEnumerator GetEnumerator() { }

	public IObserverToPlayerBridge GetEverExistedBridgeByRaidID(int playerRaidId) { }

	public Player GetEverExistedPlayerByID(int playerRaidId) { }

	public Player GetEverExistedPlayerByProfileId(string playerProfileId) { }

	public int GetMaxExistingGroupSize() { }

	public ObservedPlayerView GetObservedPlayerByRaidID(int playerRaidId) { }

	protected override void GetOrAddAudioSourceCulling(GameObject gameObject, TGameWorld gameWorld) { }

	[IteratorStateMachine(typeof(<GetParentList>d__263))]
	private static IEnumerable GetParentList(Transform transform) { }

	[CanBeNull]
	public MovingPlatform GetPlatformAtPosition(Vector3 position) { }

	[CanBeNull]
	public Player GetPlayerByCollider(Collider col) { }

	internal LootData GetQuestLootReady(LootData lootItems) { }

	private void GrenadeDestroyEvent(Throwable grenade) { }

	public override PlayerHitInfo HackShot(DamageInfo damageInfo) { }

	public override void InitAirdrop(string lootTemplateId = null, bool takeNearbyPoint = false, Vector3 position = null) { }

	[AsyncStateMachine(typeof(<InitializeEffects>d__251))]
	private Task InitializeEffects() { }

	[AsyncStateMachine(typeof(<InitLevel>d__250))]
	public override Task InitLevel(ItemFactory itemFactory, ObjectsFactoryConfig config, bool loadBundlesAndCreatePools = true, List resources = null, IProgress progress = null, CancellationToken ct = null) { }

	public static bool InteractionSense(Vector3 origin, Vector3 direction, float radius, float distance) { }

	public override bool IsLocalGame() { }

	public override void LateUpdateWorld(float dt) { }

	internal void ManageBattlePassDocumentLoot(Player player) { }

	[AsyncStateMachine(typeof(<ManageQuestLoot>d__308))]
	internal Task ManageQuestLoot(Player player) { }

	public override void NetworkWorldOnGrenadeHit(Vector3 pos) { }

	protected override void OnDestroy() { }

	public override void OnGameStarted() { }

	public override void OnLootSpawn(Item item, GameObject obj, string src) { }

	public void OnSmokeGrenadesDeserialized(List netGrenadeData) { }

	public void OnTearGasGrenadesDeserialized(List netGrenadeData) { }

	protected override void OtherElseWorldTick(float dt) { }

	public override void PlantTripwire(Item item, int playerRaidId, Vector3 fromPosition, Vector3 toPosition) { }

	protected override void PlayerTick(float dt) { }

	protected override Task PreloadAdditionalData() { }

	public void RegisterBorderZones() { }

	public override void RegisterGameOwner(Player player) { }

	public override void RegisterGrenade(Throwable grenade) { }

	public override void RegisterInteractiveObject(Turnable t) { }

	public void RegisterLoot(T loot) { }

	public override void RegisterPlayer(IPlayer iPlayer) { }

	public override void RegisterPlayerCollider(Player player, Collider playerCollider) { }

	public void RegisterRestrictableZones() { }

	public void RegisterSourceInAudioCulling(AudioSource source, bool restartSource = false) { }

	public void RegisterWindow(WindowBreaker window) { }

	public void RegisterWorldInteractionObject(WorldInteractiveObject worldInteractiveObject) { }

	[CompilerGenerated]
	public void remove_AfterGameStarted(Action value) { }

	[CompilerGenerated]
	public void remove_OnBeforeWorldTick(Action value) { }

	[CompilerGenerated]
	public static void remove_OnDispose(Action value) { }

	[CompilerGenerated]
	public void remove_OnLateUpdate(Action value) { }

	[CompilerGenerated]
	public override void remove_OnLootItemDestroyed(Action value) { }

	[CompilerGenerated]
	public override void remove_OnPersonAdd(Action value) { }

	public override void RemoveBallisticCalculator(Item weapon) { }

	public void RemoveClientBallisticsCalculator() { }

	public void RemoveSourceFromAudioCulling(AudioSource source) { }

	private void SafePlayerOperation(Action operation) { }

	[IteratorStateMachine(typeof(<SelectRandomBattlePassDocumentLootItems>d__310))]
	private IEnumerable SelectRandomBattlePassDocumentLootItems(int count) { }

	[CompilerGenerated]
	public void set_BotsCulling(BotsCulling value) { }

	[CompilerGenerated]
	public void set_BotsCullingClientController(BotsCullingClientController value) { }

	[CompilerGenerated]
	public void set_BtrController(BtrController value) { }

	[CompilerGenerated]
	public void set_BufferZoneController(BufferZoneController value) { }

	[CompilerGenerated]
	private void set_ClientBallisticCalculator(IBallisticsCalculator value) { }

	[CompilerGenerated]
	public void set_ClientBroadcastSyncController(ClientBroadcastSyncController value) { }

	[CompilerGenerated]
	public void set_ClientShellingController(ArtilleryShellingControllerClient value) { }

	[CompilerGenerated]
	public void set_CutscenesClientController(CutscenesClientController value) { }

	[CompilerGenerated]
	public void set_CutscenesServerController(CutscenesServerController value) { }

	[CompilerGenerated]
	public void set_ExfiltrationController(ExfiltrationController value) { }

	[CompilerGenerated]
	public void set_HalloweenEventController(HalloweenEventController value) { }

	[CompilerGenerated]
	public void set_KolotunController(KolotunController value) { }

	[CompilerGenerated]
	public void set_LocationId(string value) { }

	[CompilerGenerated]
	public void set_PasscodeController(PasscodeController value) { }

	public void set_Platforms(MovingPlatform[] value) { }

	[CompilerGenerated]
	public void set_RaidDialogEntryController(RaidDialogEntryController value) { }

	[CompilerGenerated]
	public void set_RunddansController(RunddansController value) { }

	[CompilerGenerated]
	internal void set_SeasonsController(ISeasonsController value) { }

	[CompilerGenerated]
	public void set_ServerShellingController(ArtilleryShellingControllerServer value) { }

	private void set_SharedBallisticsCalculator(IBallisticsCalculator value) { }

	[CompilerGenerated]
	protected void set_SynchronizableObjectLogicProcessor(SynchronizableObjectLogicProcessor value) { }

	[CompilerGenerated]
	public void set_SyncModule(SyncModule value) { }

	[CompilerGenerated]
	public void set_TransitController(TransitController value) { }

	[CompilerGenerated]
	public void set_TriggersEmitter(TriggersEmitter value) { }

	[CompilerGenerated]
	public void set_TriggersModule(TriggersModule value) { }

	[CompilerGenerated]
	public void set_VolumetricPropagationSystem(IVolumePropagationSystem value) { }

	public override LootItem SetupItem(Item item, IPlayer player, Vector3 position, Quaternion rotation) { }

	public override void ShotDelegate(Shot shotResult) { }

	internal void SpawnLoot(LootData lootItems, bool initial) { }

	protected override void SpawnLootCorpse(JsonCorpse lootItem) { }

	protected void SpawnLootCorpse(JsonCorpse corpseJson) { }

	private void SpawnLootItem(JsonLootItem lootItem, bool initial, Player questPlayer = null, MovingPlatform platform = null) { }

	public AmmoPoolObject SpawnShellInTheWorld(ref AmmoPoolObject shell) { }

	protected override void Start() { }

	protected override SynchronizableObjectLogicProcessor SyncObjectProcessorFactory() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public override LootItem ThrowItem(Item item, IPlayer player, Nullable direction) { }

	public LootItem ThrowItem(Item item, IPlayer player, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool syncable, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0) { }

	public Option ToItemAddress(ItemAddressDescriptor descriptor) { }

	public int TotalPlayersCountToCull() { }

	public override void TriggerTripwire(TripwireSynchronizableObject tripwire) { }

	public bool TryGetAlivePlayer(int id, out Player alivePlayer) { }

	public bool TryGetAlivePlayerByRaidID(int raidId, out IPlayer player) { }

	public bool TryGetControlledLampGroup(ulong id, out ControlledLampGroup controlledLampGroup) { }

	public bool TryGetIPlayerByCollider(Collider col, out IPlayer player) { }

	public bool TryGetLampController(string id, out LampController lampController) { }

	public bool TryGetObservedPlayer(int id, out ObservedPlayerView observedPlayer) { }

	public override void UnregisterGrenade(string id) { }

	private void UnregisterGrenade(Throwable grenade) { }

	public override void UnregisterPlayer(IPlayer iPlayer) { }

	public override void UnregisterPlayerCollider(Collider playerCollider) { }

	protected void Update() { }

	private void WorldInteractiveObjectOnDoorStateChanged(WorldInteractiveObject door, EDoorState stateBefore, EDoorState stateAfter) { }

	public IEnumerable WorldInteractiveObjects() { }

	private void WriteGrenadeCriticalPacket(Throwable grenade) { }

}

