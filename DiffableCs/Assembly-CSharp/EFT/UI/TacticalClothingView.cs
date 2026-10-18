namespace EFT.UI;

public sealed class TacticalClothingView : ServiceView
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__44_2; //Field offset: 0x8
		public static Action <>9__48_0; //Field offset: 0x10
		public static Func <>9__55_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <SetupPlayerSideToggles>b__44_2(TacticalClothingSideToggle x) { }

		internal void <SetupVisitStoreButton>b__48_0() { }

		internal string <ShowOffers>b__55_0(FullOffer _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public EPlayerSide side; //Field offset: 0x10
		public bool allowAllSides; //Field offset: 0x14
		public EMemberCategory memberCategory; //Field offset: 0x18
		public TacticalClothingView <>4__this; //Field offset: 0x20

		public <>c__DisplayClass44_0() { }

		internal void <SetupPlayerSideToggles>g__SetupToggle|0(TacticalClothingSideToggle toggle) { }

		internal void <SetupPlayerSideToggles>g__ToggleValueChangeHandler|1(TacticalClothingSideToggle sender) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public ExtensionsSettings extensionsSettings; //Field offset: 0x10
		public TacticalClothingView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <SetupVisitStoreButton>g__VisitStoreHandler|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public TacticalClothingView <>4__this; //Field offset: 0x10
		public TaskCompletionSource showPreviewSource; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass54_0() { }

		internal void <ShowPreview>b__0() { }

		internal void <ShowPreview>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public int requestIndex; //Field offset: 0x10
		public TacticalClothingView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass57_0() { }

		internal void <LoadBundles>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_1
	{
		public string currentBodyPath; //Field offset: 0x10
		public string currentFeetPath; //Field offset: 0x18
		public <>c__DisplayClass57_0 CS$<>8__locals1; //Field offset: 0x20

		public <>c__DisplayClass57_1() { }

		internal void <LoadBundles>b__1(FullOffer offer, ClothingItem bodyPartView) { }

		internal void <LoadBundles>b__2(FullOffer offer, ClothingItem bodyPartView) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public TacticalClothingView <>4__this; //Field offset: 0x10
		public EBodyModelPart bodyPart; //Field offset: 0x18

		public <>c__DisplayClass58_0() { }

		internal void <InitClothBundle>b__0(ClothingItem item) { }

		internal void <InitClothBundle>b__1(ClothingItem item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public ClothingItem clothing; //Field offset: 0x10
		public TacticalClothingView <>4__this; //Field offset: 0x18
		public List reqItems; //Field offset: 0x20

		public <>c__DisplayClass62_0() { }

		internal void <BuyOffer>b__0(IResult response) { }

		internal void <BuyOffer>g__PreUpdateStashItems|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_1
	{
		public ItemRequirements itemRequirement; //Field offset: 0x10

		public <>c__DisplayClass62_1() { }

		internal bool <BuyOffer>b__2(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_2
	{
		public ItemToHandover item; //Field offset: 0x10

		public <>c__DisplayClass62_2() { }

		internal bool <BuyOffer>b__3(Item stashItem) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__ShowApparelTooltip; //Field offset: 0x0
		public static Action <1>__CloseTooltip; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <EquipItem>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TacticalClothingView <>4__this; //Field offset: 0x20
		public EBodyModelPart bodyPart; //Field offset: 0x28
		public ClothingItem clothing; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetOffers>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TacticalClothingView <>4__this; //Field offset: 0x20
		public Trader trader; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnEquip>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClothingItem clothing; //Field offset: 0x20
		public TacticalClothingView <>4__this; //Field offset: 0x28
		public EBodyModelPart bodyPart; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTestFit>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TacticalClothingView <>4__this; //Field offset: 0x28
		public EBodyModelPart bodyPart; //Field offset: 0x30
		public ClothingItem item; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowOffers>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TacticalClothingView <>4__this; //Field offset: 0x20
		public Trader trader; //Field offset: 0x28
		private int <requestIndex>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string SIDE_TOGGLES_STATE_KEY = "Customization/SideToggles"; //Field offset: 0x0
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0x70
	[SerializeField]
	private RectTransform _upperBodyList; //Field offset: 0x78
	[SerializeField]
	private RectTransform _lowerBodyList; //Field offset: 0x80
	[SerializeField]
	private ClothingItem _clothingItemTemplate; //Field offset: 0x88
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0x90
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI _sideTitle; //Field offset: 0xA0
	[SerializeField]
	private HoverTrigger _previewHoverArea; //Field offset: 0xA8
	[SerializeField]
	private ServicesListView _servicesListView; //Field offset: 0xB0
	[SerializeField]
	private DefaultUiButtonNewStyle _visitStoreButton; //Field offset: 0xB8
	[SerializeField]
	private DropDownBox _filterOffersDropdown; //Field offset: 0xC0
	[SerializeField]
	private List _sideToggles; //Field offset: 0xC8
	private readonly Dictionary _currentPreview; //Field offset: 0xD0
	private readonly Dictionary _currentEquipped; //Field offset: 0xD8
	private readonly Dictionary _bodyParts; //Field offset: 0xE0
	private Trader _trader; //Field offset: 0xE8
	private Profile _profile; //Field offset: 0xF0
	private InventoryController _inventoryController; //Field offset: 0xF8
	private QuestBook _quests; //Field offset: 0x100
	private AchievementsBook _achievements; //Field offset: 0x108
	private Stash _userStashGrid; //Field offset: 0x110
	private readonly List _stashItems; //Field offset: 0x118
	private List _views; //Field offset: 0x120
	private Token _bundles; //Field offset: 0x128
	private CustomizationSolver _solver; //Field offset: 0x130
	private CustomizationSuite _currentUpperBodySuite; //Field offset: 0x138
	private CustomizationSuite _currentLowerBodySuite; //Field offset: 0x140
	private ItemUiContext _context; //Field offset: 0x148
	private bool _isOverPlayerModel; //Field offset: 0x150
	private int _currentEnterIndex; //Field offset: 0x154
	private bool _fullyEquipped; //Field offset: 0x158
	private Profile _emptyProfile; //Field offset: 0x160
	private Profile _fullProfile; //Field offset: 0x168
	private Task _showPreviewTask; //Field offset: 0x170
	private DialogWindowContext _clothingWindowContext; //Field offset: 0x178
	private HashSet _sideFilter; //Field offset: 0x180

	private Profile CurrentProfile
	{
		private get { } //Length: 25
	}

	private Task ShowPreviewTask
	{
		private get { } //Length: 90
	}

	public TacticalClothingView() { }

	[CompilerGenerated]
	internal static void <IsToggleActiveOnShow>g__IntToSides|46_0(int value, out bool bear, out bool usec) { }

	[CompilerGenerated]
	private void <SetupDropdownFilter>b__43_0(int _) { }

	[CompilerGenerated]
	private void <Show>b__41_0(PointerEventData _) { }

	[CompilerGenerated]
	private void <Show>b__41_1(PointerEventData _) { }

	private void AvailableCustomizationsChangedHandler() { }

	private void BuyOffer(ClothingItem clothing) { }

	public virtual bool CheckAvailable(Trader trader) { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<EquipItem>d__66))]
	private Task EquipItem(EBodyModelPart bodyPart, ClothingItem clothing) { }

	private Profile get_CurrentProfile() { }

	private Task get_ShowPreviewTask() { }

	[AsyncStateMachine(typeof(<GetOffers>d__56))]
	private Task GetOffers(Trader trader) { }

	private bool GetPreviewState(ClothingItem clothingItem) { }

	private EClothingItemState GetState(ClothingItem clothingItem) { }

	private void InitClothBundle(FullOffer offer, ClothingItem bodyPartView, EBodyModelPart bodyPart, string bundlePath) { }

	private bool IsToggleActiveOnShow(EPlayerSide toggleSide, EPlayerSide playerSide, bool allowAllSides) { }

	private void ItemAddedHandler(AddItemEventArgs obj) { }

	private void ItemRefreshedHandler(RefreshItemEventArgs obj) { }

	private void ItemRemovedHandler(RemoveItemEventArgs obj) { }

	private void LoadBundles(IEnumerable clothing, int requestIndex) { }

	private void OnDrag(PointerEventData pointerData) { }

	[AsyncStateMachine(typeof(<OnEquip>d__61))]
	private Task OnEquip(EBodyModelPart bodyPart, ClothingItem clothing) { }

	[AsyncStateMachine(typeof(<OnTestFit>d__68))]
	private void OnTestFit(EBodyModelPart bodyPart, ClothingItem item) { }

	private void PlayEquipSound() { }

	private bool RequirementsSatisfied(FullOffer offer) { }

	private void SaveTogglesState() { }

	private void SendEquippedItems() { }

	private void SetupDropdownFilter() { }

	private void SetupPlayerSideToggles() { }

	private void SetupVisitStoreButton() { }

	public virtual void Show(Trader trader, Profile profile, InventoryController inventoryController, OfflineHealthController healthController, QuestBook quests, AchievementsBook achievements, ItemUiContext context, IEftSession session) { }

	[AsyncStateMachine(typeof(<ShowOffers>d__55))]
	private Task ShowOffers(Trader trader) { }

	private void ShowPreview() { }

	private bool TryDeselectOldView(IReadOnlyDictionary views, EBodyModelPart bodyPart, ClothingItem newClothingItem) { }

	private void Update() { }

	private void UpdateCustomization(EBodyModelPart bodyPart, string customizationId) { }

	private void UpdatePreview() { }

	private void UpdateStashItems() { }

	private void UpdateView(ClothingItem view) { }

	private void UpdateViews() { }

	private void ValidateFilter() { }

}

