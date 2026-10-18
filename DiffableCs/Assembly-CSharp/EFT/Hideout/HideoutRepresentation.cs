namespace EFT.Hideout;

public sealed class HideoutRepresentation : IUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__106_0; //Field offset: 0x8
		public static Func <>9__122_2; //Field offset: 0x10
		public static Func <>9__122_1; //Field offset: 0x18
		public static Func <>9__139_0; //Field offset: 0x20
		public static Func <>9__164_0; //Field offset: 0x28
		public static Func <>9__169_0; //Field offset: 0x30
		public static Func <>9__172_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <ActivateWeapon>b__172_0(AreaData v) { }

		internal TraderInfo <CalculateTraderRequirements>b__164_0(Trader trader) { }

		internal bool <Init>b__106_0(AreaInfo x) { }

		internal ItemToHandover <ResolveReferenceAction>b__139_0(HideoutItemReference reference) { }

		internal IEnumerable <SelectItems>b__169_0(CommodityToPurchase x) { }

		internal Requirement[] <UpdateAllAreaRequirementsList>b__122_1(Improvement v) { }

		internal bool <UpdateAllAreaRequirementsList>b__122_2(QteHandleData qteData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__148`1
	{
		public static readonly <>c__148 <>9; //Field offset: 0x0
		public static Func <>9__148_2; //Field offset: 0x0
		public static Func <>9__148_3; //Field offset: 0x0

		private static <>c__148`1() { }

		public <>c__148`1() { }

		internal MongoID <GetAvailableItemsByFilter>b__148_2(Item item) { }

		internal bool <GetAvailableItemsByFilter>b__148_3(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass116_0
	{
		public AreaTemplate areaTemplate; //Field offset: 0x10

		public <>c__DisplayClass116_0() { }

		internal bool <SetHideoutData>b__0(AreaInfo areaInfo) { }

		internal bool <SetHideoutData>b__1(AreaData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public AreaInfo areaInfo; //Field offset: 0x10

		public <>c__DisplayClass117_0() { }

		internal bool <StoreOurAreaInfo>b__0(AreaInfo a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public InventoryController inventoryController; //Field offset: 0x10
		public HideoutRepresentation <>4__this; //Field offset: 0x18
		public Profile profile; //Field offset: 0x20
		public EnergyController energyController; //Field offset: 0x28

		public <>c__DisplayClass118_0() { }

		internal void <SetupControllers>b__0() { }

		internal void <SetupControllers>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass119_0
	{
		public HideoutRepresentation <>4__this; //Field offset: 0x10
		public AreaData areaData; //Field offset: 0x18
		public IConsumerAreaBehaviour consumerArea; //Field offset: 0x20

		public <>c__DisplayClass119_0() { }

		internal void <InitProfileData>b__0() { }

		internal bool <InitProfileData>b__1(AreaInfo info) { }

		internal void <InitProfileData>b__2(bool silent) { }

		internal void <InitProfileData>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass119_1
	{
		public BaseItemSlotsAreaBehaviour itemSlotsArea; //Field offset: 0x10
		public <>c__DisplayClass119_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass119_1() { }

		internal void <InitProfileData>b__4(Item _, int _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public AreaData areaData; //Field offset: 0x10

		public <>c__DisplayClass121_0() { }

		internal bool <UpdateLinkedAreas>b__0(AreaData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public AreaData areaData; //Field offset: 0x10

		public <>c__DisplayClass122_0() { }

		internal bool <UpdateAllAreaRequirementsList>b__0(Requirement requirement) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public AreaTemplate areaTemplate; //Field offset: 0x10
		public HideoutRepresentation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass130_0() { }

		internal bool <PrepareAreaData>b__0(AreaTemplate v) { }

		internal bool <PrepareAreaData>b__1(QteData qteData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_1
	{
		public AreaData data; //Field offset: 0x10
		public <>c__DisplayClass130_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass130_1() { }

		internal void <PrepareAreaData>b__2(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass131_0
	{
		public int level; //Field offset: 0x10

		public <>c__DisplayClass131_0() { }

		internal bool <UpdateAreaStages>b__0(QteData qteData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass134_0
	{
		public EAreaType type; //Field offset: 0x10

		public <>c__DisplayClass134_0() { }

		internal bool <AreaSchemesByType>b__0(ProductionScheme scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass140_0
	{
		public ItemToHandover itemReference; //Field offset: 0x10

		public <>c__DisplayClass140_0() { }

		internal bool <RemoveSpentItems>b__0(Item playerItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass147_0
	{
		public int type; //Field offset: 0x10
		public EAreaType areaType; //Field offset: 0x14

		public <>c__DisplayClass147_0() { }

		internal bool <CompleteUpgradeZone>b__0(AreaInfo a) { }

		internal bool <CompleteUpgradeZone>b__1(AreaData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass148_0`1
	{
		public IEnumerable templateIdFilter; //Field offset: 0x0
		public HideoutRepresentation <>4__this; //Field offset: 0x0

		public <>c__DisplayClass148_0`1() { }

		internal bool <GetAvailableItemsByFilter>b__0(Item item) { }

		internal bool <GetAvailableItemsByFilter>b__1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass153_0
	{
		public HideoutRepresentation <>4__this; //Field offset: 0x10
		public Item templateItem; //Field offset: 0x18
		public Callback onComplete; //Field offset: 0x20

		public <>c__DisplayClass153_0() { }

		internal void <TakeItemsFromAreaSlot>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass159_0
	{
		public HideoutRepresentation <>4__this; //Field offset: 0x10
		public string stashId; //Field offset: 0x18
		public List producedItems; //Field offset: 0x20
		public AreaBehaviour behaviour; //Field offset: 0x28

		public <>c__DisplayClass159_0() { }

		internal void <GetProducedItems>g__GetProducedItemHandler|0(AddItemEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass178_0
	{
		public EAreaType areaType; //Field offset: 0x10

		public <>c__DisplayClass178_0() { }

		internal bool <ShowAreaItemsTransferScreen>b__0(AreaData data) { }

		internal bool <ShowAreaItemsTransferScreen>b__1(AreaData data) { }

		internal bool <ShowAreaItemsTransferScreen>b__2(AreaData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass179_0
	{
		public HideoutInventoryScreenController inventoryScreenController; //Field offset: 0x10
		public HideoutRepresentation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass179_0() { }

		internal void <ShowInventoryScreen>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass181_0
	{
		public EAreaType type; //Field offset: 0x10

		public <>c__DisplayClass181_0() { }

		internal bool <InitHideoutArea>b__0(AreaData data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass185_0
	{
		public HideoutPlayerOwner hideoutPlayerOwner; //Field offset: 0x10
		public HideoutRepresentation <>4__this; //Field offset: 0x18

		public <>c__DisplayClass185_0() { }

		internal void <StartHideoutAreaDialogue>g__DialogueActionFinishedHandler|0(DialogAction action) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass186_0
	{
		public EAreaType areaType; //Field offset: 0x10

		public <>c__DisplayClass186_0() { }

		internal bool <OnResourceConsumptionChanged>b__0(AreaInfo x) { }

	}

	[CompilerGenerated]
	private struct <CalculateItemRequirements>d__167 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool decide; //Field offset: 0x28
		public HideoutRepresentation <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CancelProduction>d__155 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public BaseHideoutScheme scheme; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompleteUpgradeZone>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EAreaType areaType; //Field offset: 0x20
		public HideoutRepresentation <>4__this; //Field offset: 0x28
		private <>c__DisplayClass147_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAreasQte>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBackendTemplates>d__107 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHideoutCustomizationOffers>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHideoutSettings>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetProducedItems>d__159 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public ItemsProducerBase producer; //Field offset: 0x28
		public string schemeId; //Field offset: 0x30
		private <>c__DisplayClass159_0 <>8__1; //Field offset: 0x38
		public bool showItemsListWindow; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetProductionRecipes>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession session; //Field offset: 0x20
		private HideoutDataLoader <dataLoader>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RestartProduction>d__154 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public BaseHideoutScheme scheme; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectItems>d__169 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public ItemRequirement[] requirements; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetHideoutData>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public HideoutData hideoutData; //Field offset: 0x28
		public bool updateVisual; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartCultistsProduction>d__158 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartImprovement>d__168 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Improvement improvement; //Field offset: 0x20
		public HideoutRepresentation <>4__this; //Field offset: 0x28
		public EAreaType areaType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartScavCaseProduction>d__157 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public ItemRequirement[] requirements; //Field offset: 0x28
		public string schemeId; //Field offset: 0x30
		private IEnumerable <operationResults>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartSingleProduction>d__156 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseHideoutScheme scheme; //Field offset: 0x20
		public HideoutRepresentation <>4__this; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private ItemRequirement[] <requiredItems>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpgradeZone>d__146 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutRepresentation <>4__this; //Field offset: 0x20
		public RelatedRequirements requirements; //Field offset: 0x28
		public EAreaType areaType; //Field offset: 0x30
		private IEnumerable <operationResults>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public sealed class HideoutLogger : AbstractLogger
	{
		private static HideoutLogger _instance; //Field offset: 0x0

		public static HideoutLogger Instance
		{
			 get { } //Length: 311
		}

		private HideoutLogger() { }

		public static HideoutLogger get_Instance() { }

	}

	public const string NO_FREE_SPACE_TITLE = "no_free_space_title"; //Field offset: 0x0
	public const string NO_FREE_SPACE_MESSAGE = "no_free_space_message"; //Field offset: 0x0
	private const float DECIDE_DELAY = 0.5; //Field offset: 0x0
	private static readonly SpawnedInSessionItemComparer _comparer; //Field offset: 0x0
	private static readonly List _itemsBuffer; //Field offset: 0x8
	[CompilerGenerated]
	private Action OnItemsChanged; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnItemChanged; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnAreaUpdated; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnProducedItemsReceived; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnInited; //Field offset: 0x30
	private AreaTemplate[] _areaTemplates; //Field offset: 0x38
	private InventoryController _inventoryController; //Field offset: 0x40
	private IEftSession _session; //Field offset: 0x48
	private HideoutSkillManager _skillManager; //Field offset: 0x50
	private BonusController _maxBonuses; //Field offset: 0x58
	private QuestControllerClient _questController; //Field offset: 0x60
	private AchievementsController _achievementsController; //Field offset: 0x68
	private PrestigeController _prestigeController; //Field offset: 0x70
	private BaseTraderDialogController _dialogController; //Field offset: 0x78
	private readonly List _updatables; //Field offset: 0x80
	private readonly List _stashItems; //Field offset: 0x88
	private readonly List _tempItemsCollection; //Field offset: 0x90
	private readonly List _takeBackSlotItemsInQueue; //Field offset: 0x98
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0xA0
	private List _allRequirements; //Field offset: 0xA8
	private Dictionary _areaDataIndex; //Field offset: 0xB0
	private List _areaDatas; //Field offset: 0xB8
	private bool _isRunning; //Field offset: 0xC0
	private bool _hasBeenInit; //Field offset: 0xC1
	private AreaInfo _generatorAreaInfo; //Field offset: 0xC8
	private AreaData _generatorData; //Field offset: 0xD0
	private bool _calculationInProgress; //Field offset: 0xD8
	private QteData[] _areasQteList; //Field offset: 0xE0
	private Seed _seed; //Field offset: 0xE8
	private RandomXORShift _randomXorShift; //Field offset: 0xF8
	[CompilerGenerated]
	private EnergyController <EnergyController>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private bool <IsClientBusy>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private ProductionSchemesCollection <ProductionSchemesCollection>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private ProductionController <ProductionController>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private ImprovementController <ImprovementController>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private HideoutSettings <Settings>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private AreaInfo[] <Areas>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private AreaTemplate[] <BackendTemplatesData>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private HideoutCustomizationController <CustomizationController>k__BackingField; //Field offset: 0x140
	private OfflineHealthController _healthController; //Field offset: 0x148
	private EEventType[] _events; //Field offset: 0x150
	private HashSet _favoriteProductionSchemes; //Field offset: 0x158
	private HideoutCustomizationOffersCollection _customizationOffers; //Field offset: 0x160
	private readonly HashSet _processedItems; //Field offset: 0x168
	private HideoutDialogEntryPoint[] _dialogEntryPoints; //Field offset: 0x170
	[CompilerGenerated]
	private Action OnDialogStart; //Field offset: 0x178

	public event Action OnAreaUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnDialogStart
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnInited
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnItemChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnItemsChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnProducedItemsReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public IEnumerable AllStashItems
	{
		 get { } //Length: 8
	}

	public List AreaDatas
	{
		 get { } //Length: 207
	}

	private AreaInfo[] Areas
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private AreaTemplate[] BackendTemplatesData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HideoutCustomizationController CustomizationController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutDialogEntryPoint[] DialogEntryPoints
	{
		 get { } //Length: 8
		 set { } //Length: 437
	}

	public private EnergyController EnergyController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private EEventType[] Events
	{
		 get { } //Length: 8
		private set { } //Length: 95
	}

	public IEnumerable FavoriteProductionSchemes
	{
		 get { } //Length: 8
	}

	public private ImprovementController ImprovementController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool IsClientBusy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsEnergyGenerationOn
	{
		 get { } //Length: 18
	}

	public private ProductionController ProductionController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ProductionSchemesCollection ProductionSchemesCollection
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HideoutSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static HideoutRepresentation() { }

	public HideoutRepresentation() { }

	[CompilerGenerated]
	private void <GetItemReferences>g__FillBufferWithSuitableItems|138_0(List itemsBuffer, ItemRequirement requirement) { }

	[CompilerGenerated]
	private void <WorkoutOperation>b__175_0(IResult result) { }

	public void ActivateWeapon(HideoutPlayerOwner owner) { }

	[CompilerGenerated]
	public void add_OnAreaUpdated(Action value) { }

	[CompilerGenerated]
	public void add_OnDialogStart(Action value) { }

	[CompilerGenerated]
	public void add_OnInited(Action value) { }

	[CompilerGenerated]
	public void add_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnItemsChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnProducedItemsReceived(Action value) { }

	private void AddFavoriteScheme(BaseHideoutScheme scheme) { }

	private void AddItemEventHandler(AddItemEventArgs args) { }

	public void AddItemToProcessingList(Item item) { }

	public void ApplyChanges() { }

	private List AreaSchemesByType(EAreaType type) { }

	private void AreaSelectedHandler(EAreaType type, bool selected) { }

	private void CalculateAreaRequirements() { }

	private void CalculateBodyPartBuffRequirements(OfflineHealthController healthController) { }

	private void CalculateHealthRequirements(OfflineHealthController healthController) { }

	[AsyncStateMachine(typeof(<CalculateItemRequirements>d__167))]
	private void CalculateItemRequirements(bool decide) { }

	private void CalculateQuestRequirements(bool decide) { }

	private void CalculateSkillRequirements(bool decide) { }

	private void CalculateTraderRequirements(bool decide) { }

	[AsyncStateMachine(typeof(<CancelProduction>d__155))]
	public Task CancelProduction(BaseHideoutScheme scheme) { }

	public void ClearProcessingList() { }

	[AsyncStateMachine(typeof(<CompleteUpgradeZone>d__147))]
	public Task CompleteUpgradeZone(EAreaType areaType) { }

	private void DecideStatuses() { }

	private void DeInit() { }

	private void DialogStartHandler(DialogStartData dialogData) { }

	private void EnergyGenerationChanged(bool isPowerOn) { }

	public IEnumerable get_AllStashItems() { }

	public List get_AreaDatas() { }

	[CompilerGenerated]
	private AreaInfo[] get_Areas() { }

	[CompilerGenerated]
	public AreaTemplate[] get_BackendTemplatesData() { }

	[CompilerGenerated]
	public HideoutCustomizationController get_CustomizationController() { }

	public HideoutDialogEntryPoint[] get_DialogEntryPoints() { }

	[CompilerGenerated]
	public EnergyController get_EnergyController() { }

	public EEventType[] get_Events() { }

	public IEnumerable get_FavoriteProductionSchemes() { }

	[CompilerGenerated]
	public ImprovementController get_ImprovementController() { }

	[CompilerGenerated]
	public bool get_IsClientBusy() { }

	public bool get_IsEnergyGenerationOn() { }

	[CompilerGenerated]
	public ProductionController get_ProductionController() { }

	[CompilerGenerated]
	public ProductionSchemesCollection get_ProductionSchemesCollection() { }

	[CompilerGenerated]
	public HideoutSettings get_Settings() { }

	[AsyncStateMachine(typeof(<GetAreasQte>d__108))]
	private Task GetAreasQte() { }

	public IEnumerable GetAvailableItemsByFilter(IEnumerable templateIdFilter = null, Func predicate = null, bool onlyExamined = false) { }

	[AsyncStateMachine(typeof(<GetBackendTemplates>d__107))]
	private Task GetBackendTemplates() { }

	[AsyncStateMachine(typeof(<GetHideoutCustomizationOffers>d__110))]
	private Task GetHideoutCustomizationOffers() { }

	[AsyncStateMachine(typeof(<GetHideoutSettings>d__109))]
	private Task GetHideoutSettings() { }

	private List GetItemReferences(ItemRequirement[] requirements) { }

	public double GetMaxBonus(EBonusType bonusType, double input) { }

	[AsyncStateMachine(typeof(<GetProducedItems>d__159))]
	public Task GetProducedItems(ItemsProducerBase producer, string schemeId, bool showItemsListWindow) { }

	[AsyncStateMachine(typeof(<GetProductionRecipes>d__111))]
	private Task GetProductionRecipes() { }

	public int GetShootingRangeScore() { }

	[AsyncStateMachine(typeof(<Init>d__105))]
	public Task Init(IEftSession session) { }

	public void Init(IEftSession session, AreaTemplate[] areaTemplates, QteData[] qteData, HideoutSettings settings, ProductionSchemesCollection schemes, HideoutCustomizationOffersCollection customization, HideoutAreasInfo areaInfo) { }

	public AreaData InitHideoutArea(EAreaType type, HideoutArea area) { }

	private void InitProfileData(AreaData areaData) { }

	public bool InQteRandomChance(float chance) { }

	private void OnResourceConsumptionChanged(EAreaType areaType, Item[] items) { }

	private void PrepareAreaData() { }

	private void PrepareConsumptionData(Stage stage, int level, EAreaType type) { }

	private void PrepareProductionData(AreaData data, AreaInfo areaInfo, EAreaType type, Profile profile) { }

	public void PutItemInAreaSlot(EAreaType areaType, int slotIndex, Item item, int count = 1, Callback callback = null) { }

	public void PutManyInAreaSlots(EAreaType areaType, Dictionary slotItems, Callback onComplete) { }

	public int QteRandomNext(int min, int max) { }

	private void RecalculateAllRequirements() { }

	private void RecalculatePlayerItems() { }

	private void RefreshItemEvent(RefreshItemEventArgs args) { }

	private void RehashPlayerItems() { }

	[CompilerGenerated]
	public void remove_OnAreaUpdated(Action value) { }

	[CompilerGenerated]
	public void remove_OnDialogStart(Action value) { }

	[CompilerGenerated]
	public void remove_OnInited(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemsChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnProducedItemsReceived(Action value) { }

	private void RemoveFavoriteScheme(BaseHideoutScheme scheme) { }

	private void RemoveItemEventHandler(RemoveItemEventArgs args) { }

	[CanBeNull]
	private IEnumerable RemoveSpentItems(IEnumerable items) { }

	[CanBeNull]
	private IEnumerable ResolveReferenceAction(IEnumerable references) { }

	[AsyncStateMachine(typeof(<RestartProduction>d__154))]
	public Task RestartProduction(BaseHideoutScheme scheme) { }

	[AsyncStateMachine(typeof(<SelectItems>d__169))]
	private Task SelectItems(ItemRequirement[] requirements) { }

	[CompilerGenerated]
	private void set_Areas(AreaInfo[] value) { }

	[CompilerGenerated]
	private void set_BackendTemplatesData(AreaTemplate[] value) { }

	[CompilerGenerated]
	private void set_CustomizationController(HideoutCustomizationController value) { }

	public void set_DialogEntryPoints(HideoutDialogEntryPoint[] value) { }

	[CompilerGenerated]
	private void set_EnergyController(EnergyController value) { }

	private void set_Events(EEventType[] value) { }

	[CompilerGenerated]
	private void set_ImprovementController(ImprovementController value) { }

	[CompilerGenerated]
	public void set_IsClientBusy(bool value) { }

	[CompilerGenerated]
	private void set_ProductionController(ProductionController value) { }

	[CompilerGenerated]
	private void set_ProductionSchemesCollection(ProductionSchemesCollection value) { }

	[CompilerGenerated]
	private void set_Settings(HideoutSettings value) { }

	[AsyncStateMachine(typeof(<SetHideoutData>d__116))]
	public Task SetHideoutData(HideoutData hideoutData, bool updateVisual) { }

	public void SetShootingRangeScore(int value) { }

	public void SetupControllers(InventoryController inventoryController, OfflineHealthController healthController, QuestControllerClientBackend questController, AchievementsController achievementsController, PrestigeController prestigeController, BaseTraderDialogController dialogController) { }

	public void ShowAreaItemsTransferScreen(EAreaType areaType, Action exitAction = null) { }

	public void ShowInventoryScreen(Action exitAction = null) { }

	private void SkillLevelChangedHandler(BaseSkill skill) { }

	public void StartContinuousProduction(string schemeId) { }

	[AsyncStateMachine(typeof(<StartCultistsProduction>d__158))]
	public Task StartCultistsProduction() { }

	public EventDialogScreenController StartGameScreen(MongoID dialogId) { }

	public void StartHideoutAreaDialogue(HideoutPlayerOwner hideoutPlayerOwner, ITraderAnimationController animController, string traderId) { }

	[AsyncStateMachine(typeof(<StartImprovement>d__168))]
	public Task StartImprovement(Improvement improvement, EAreaType areaType) { }

	[AsyncStateMachine(typeof(<StartScavCaseProduction>d__157))]
	public Task StartScavCaseProduction(string schemeId, ItemRequirement[] requirements) { }

	[AsyncStateMachine(typeof(<StartSingleProduction>d__156))]
	public Task StartSingleProduction(BaseHideoutScheme scheme, Action callback) { }

	private void StoreOurAreaInfo(AreaInfo areaInfo, AreaData areaData) { }

	public bool TakeItemsFromAreaSlot(EAreaType areaType, int slotIndex, MongoID itemTemplate, Callback onComplete = null) { }

	private void TraderChangedHandler(TraderInfo traderInfo) { }

	private void TryDecideStatuses(bool isGuestArea) { }

	public override void Update(float deltaTime) { }

	private void UpdateAllAreaRequirementsList(AreaData areaData) { }

	private void UpdateAreaSchemes(AreaData data, List areaSchemes, Profile profile) { }

	private void UpdateAreaStages(Dictionary stages, AreaTemplate areaTemplate, IEnumerable areaQteDatas) { }

	private void UpdateIconStatuses() { }

	public void UpdateImprovements(Dictionary improvements) { }

	private void UpdateLinkedAreas(AreaData areaData) { }

	private void UpdateMaxBonuses() { }

	public void UpdateProduction(Dictionary productionDataChanges) { }

	public void UpdateSchemes() { }

	[AsyncStateMachine(typeof(<UpgradeZone>d__146))]
	public Task UpgradeZone(EAreaType areaType, RelatedRequirements requirements) { }

	public void WorkoutOperation(IEnumerable qtesResult, string qteId, string accountId) { }

}

