namespace EFT.Hideout;

public sealed class HideoutCustomizationController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public MongoID itemId; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <InstallCustomization>b__0(HideoutCustomizationItem i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public HideoutCustomizationController <>4__this; //Field offset: 0x10
		public HideoutCustomizationGlobalOffer globalOffer; //Field offset: 0x18
		public Nullable lastSelected; //Field offset: 0x20

		public <>c__DisplayClass36_0() { }

		internal void <InstallCustomization>b__0(IResult res) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Nullable foundItemId; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <GetStartupCustomizationAssetKey>b__0(HideoutCustomizationGlobalOffer offer) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass40_0() { }

		internal bool <GetSpawnPoint>b__0(KeyValuePair p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public EHideoutCustomizationType customizationType; //Field offset: 0x10

		public <>c__DisplayClass41_0() { }

		internal bool <GetSlotOffers>b__0(HideoutCustomizationSlotOffer o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public EHideoutCustomizationType customizationType; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <GetGlobalOffers>b__0(HideoutCustomizationGlobalOffer o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public Nullable itemId; //Field offset: 0x10

		public <>c__DisplayClass50_0() { }

		internal bool <GetInstalledItemsPack>b__0(HideoutCustomizationItem i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public Nullable itemId; //Field offset: 0x10

		public <>c__DisplayClass53_0() { }

		internal bool <FindBundleKey>b__0(HideoutCustomizationItem i) { }

	}

	[CompilerGenerated]
	private struct <Clear>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CollectSelectedBundleKeys>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InstallCustomization>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		public Dictionary customizationPack; //Field offset: 0x28
		public CompoundItem stash; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InstallSelectedCustomization>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		private Nullable <floorItemId>5__2; //Field offset: 0x28
		private Nullable <wallItemId>5__3; //Field offset: 0x48
		private Nullable <ceilingItemId>5__4; //Field offset: 0x68
		private Nullable <markItemId>5__5; //Field offset: 0x88
		private TaskAwaiter <>u__1; //Field offset: 0xA8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAllBundles>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBundles>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable bundleKeys; //Field offset: 0x20
		private Token <bundles>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitCanSelect>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationController <>4__this; //Field offset: 0x20
		public OperationResult quickFindResult; //Field offset: 0x28
		public Item item; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string FLOOR_DEFAULT_ITEM_ID = "6758443ff94a97cbbe096f18"; //Field offset: 0x0
	private const string WALL_DEFAULT_ITEM_ID = "675844bdf94a97cbbe096f1a"; //Field offset: 0x0
	private const string CEILING_DEFAULT_ITEM_ID = "673b3f977038192ee006aa09"; //Field offset: 0x0
	private const string SHOOTING_RANGE_MARK_DEFAULT_ITEM_ID = "67585d416c72998cf60ed85a"; //Field offset: 0x0
	private const string NO_FREE_SPACE_TITLE = "no_free_space_title"; //Field offset: 0x0
	private const string NO_FREE_SPACE_MESSAGE = "no_free_space_message"; //Field offset: 0x0
	private readonly InventoryController _inventoryController; //Field offset: 0x10
	private readonly IEftSession _session; //Field offset: 0x18
	private HideoutAreaStashController _stashController; //Field offset: 0x20
	private CompoundItem _stash; //Field offset: 0x28
	private Token _selectedBundles; //Field offset: 0x30
	private Token _allBundles; //Field offset: 0x38
	private HideoutCustomizationOffersCollection _offersCollection; //Field offset: 0x40
	private HideoutCustomizationItemsInstaller _customizationItemsInstaller; //Field offset: 0x48
	private ConditionsConnectorsManagerHideoutCustomizationOffersClientBackend _offersConditionsConnectorsManager; //Field offset: 0x50
	private HideoutCustomizationOffersBook _offersBook; //Field offset: 0x58
	private Dictionary _selectedGlobalCustomizations; //Field offset: 0x60
	private IEnumerable _allCustomizations; //Field offset: 0x68
	private bool _canSelectSlotItem; //Field offset: 0x70
	[CompilerGenerated]
	private Action ItemSelectionInProcessAction; //Field offset: 0x78
	public IEnumerable AvailableCustomizations; //Field offset: 0x80
	[CompilerGenerated]
	private HideoutCustomizationIcons <Icons>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Action CustomizationChangedAction; //Field offset: 0x90

	public event Action CustomizationChangedAction
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action ItemSelectionInProcessAction
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private HideoutCustomizationIcons Icons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutCustomizationController(HideoutCustomizationOffersCollection offersCollection, CompoundItem hideoutCustomizationStash, InventoryController inventoryController, Profile profile, QuestBook questBook, IEftSession session) { }

	[CompilerGenerated]
	public void add_CustomizationChangedAction(Action value) { }

	[CompilerGenerated]
	public void add_ItemSelectionInProcessAction(Action value) { }

	public bool CanSelect(Item item) { }

	[AsyncStateMachine(typeof(<Clear>d__56))]
	public Task Clear() { }

	private List CollectAllBundleKeys() { }

	[AsyncStateMachine(typeof(<CollectSelectedBundleKeys>d__52))]
	private Task CollectSelectedBundleKeys() { }

	private string FindBundleKey(Nullable itemId, bool onlyAssetName = false) { }

	[CompilerGenerated]
	public HideoutCustomizationIcons get_Icons() { }

	public IEnumerable GetGlobalOffers(EHideoutCustomizationType customizationType) { }

	public Dictionary GetInstalledItemsPack() { }

	public Nullable GetSelectedCustomizationItemId(EHideoutCustomizationType customizationType) { }

	public IEnumerable GetSlotOffers(EHideoutCustomizationType customizationType) { }

	public HideoutCustomizationItemModelSpawnPoint GetSpawnPoint(string id) { }

	private string GetStartupCustomizationAssetKey(EHideoutCustomizationType customizationType, out Nullable itemId) { }

	public Slot[] GetStashSlots() { }

	private static void HandleCanSelectError(Item item, OperationResult quickFindResult) { }

	public void Init(HideoutCustomizationItemsInstaller customizationItemsInstaller) { }

	public void InstallCustomization(HideoutCustomizationOffer offer) { }

	[AsyncStateMachine(typeof(<InstallCustomization>d__33))]
	public Task InstallCustomization(Dictionary customizationPack, CompoundItem stash) { }

	private void InstallCustomization(MongoID itemId, EHideoutCustomizationType customizationType) { }

	private void InstallCustomization(ResourceKey resourceKey, EHideoutCustomizationType customizationType) { }

	[AsyncStateMachine(typeof(<InstallSelectedCustomization>d__32))]
	private Task InstallSelectedCustomization() { }

	private void InventoryOperationHandler(IResult result) { }

	[AsyncStateMachine(typeof(<LoadAllBundles>d__54))]
	public Task LoadAllBundles(Action callback) { }

	[AsyncStateMachine(typeof(<LoadBundles>d__55))]
	private Task LoadBundles(IEnumerable bundleKeys) { }

	private void OnInstallationFailed(IResult result, EHideoutCustomizationType customizationType, Nullable lastSelected) { }

	public void OnSlotItemSelectionChanged(ItemAddress toAddress, Item selectedItem) { }

	[CompilerGenerated]
	public void remove_CustomizationChangedAction(Action value) { }

	[CompilerGenerated]
	public void remove_ItemSelectionInProcessAction(Action value) { }

	[CompilerGenerated]
	private void set_Icons(HideoutCustomizationIcons value) { }

	public void TestOffersConditions() { }

	[AsyncStateMachine(typeof(<WaitCanSelect>d__46))]
	private Task WaitCanSelect(OperationResult quickFindResult, Item item) { }

}

