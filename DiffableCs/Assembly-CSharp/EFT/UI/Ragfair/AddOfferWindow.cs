namespace EFT.UI.Ragfair;

public sealed class AddOfferWindow : Window, IAddHandler, IItemRelatedView, IRemoveHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__72_0; //Field offset: 0x8
		public static Func <>9__73_0; //Field offset: 0x10
		public static Func <>9__73_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <EnsureTaxCorrect>b__72_0() { }

		internal string <SetPrices>b__73_0(string x) { }

		internal bool <SetPrices>b__73_1(RequirementView x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public RequirementView requirementView; //Field offset: 0x10
		public AddOfferWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass64_0() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public Dictionary offerItemDict; //Field offset: 0x10
		public AddOfferWindow <>4__this; //Field offset: 0x18

		public <>c__DisplayClass69_0() { }

		internal void <AddOffer>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public ItemTemplate template; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal bool <CheckRestrictions>b__0(RagfairItemRestrictions x) { }

	}

	private enum EAddOfferWarning
	{
		TooLittle = 0,
		TooMuch = 1,
		Pack = 2,
		None = 3,
	}

	private const int TIMER_VISUAL_OFFSET = 1; //Field offset: 0x0
	private const int REFRESH_COOLDOWN = 3; //Field offset: 0x0
	private const float TOO_LOW_PRICE_WARNING = 2; //Field offset: 0x0
	private const float TOO_HIGH_PRICE_WARNING = 4; //Field offset: 0x0
	private const string NO_SELECTED_ITEMS = "Ragfair/No selected item"; //Field offset: 0x0
	private const string NO_AVAILABLE_ITEMS = "No available item"; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _autoButton; //Field offset: 0xB8
	[SerializeField]
	private ItemInfoWindowLabels _labels; //Field offset: 0xC0
	[SerializeField]
	private Button _refreshButton; //Field offset: 0xC8
	[SerializeField]
	private TweenAnimatedButton _TweenAnimatedRefreshButton; //Field offset: 0xD0
	[SerializeField]
	private CameraImage _cameraImage; //Field offset: 0xD8
	[SerializeField]
	private DefaultUIButton _addOfferButton; //Field offset: 0xE0
	[SerializeField]
	private TextMeshProUGUI _selectedCountLabel; //Field offset: 0xE8
	[SerializeField]
	private TextMeshProUGUI _categoryLabel; //Field offset: 0xF0
	[SerializeField]
	private TextMeshProUGUI _myOffersCount; //Field offset: 0xF8
	[SerializeField]
	private TextMeshProUGUI _durationLabel; //Field offset: 0x100
	[SerializeField]
	private GridView _gridView; //Field offset: 0x108
	[SerializeField]
	private ItemMarketPricesPanel _pricesPanel; //Field offset: 0x110
	[SerializeField]
	private TextMeshProUGUI _estimatedRequirementsPrice; //Field offset: 0x118
	[SerializeField]
	private TextMeshProUGUI _taxPrice; //Field offset: 0x120
	[SerializeField]
	private TextMeshProUGUI _perItemLabel; //Field offset: 0x128
	[SerializeField]
	private UpdatableToggle _autoSelectSimilar; //Field offset: 0x130
	[SerializeField]
	private UpdatableToggle _sellInOnePieceToggle; //Field offset: 0x138
	[SerializeField]
	private CanvasGroup _sellInOnePieceGroup; //Field offset: 0x140
	[SerializeField]
	private GameObject _loader; //Field offset: 0x148
	[SerializeField]
	private GameObject _selectedItemPanel; //Field offset: 0x150
	[SerializeField]
	private GameObject _noOfferPanel; //Field offset: 0x158
	[SerializeField]
	private TextMeshProUGUI _noItemsText; //Field offset: 0x160
	[SerializeField]
	private RequirementView[] _requirementViews; //Field offset: 0x168
	[SerializeField]
	private DisplayMoneyPanel _moneyPanel; //Field offset: 0x170
	[SerializeField]
	private RagfairReputationPanel _reputationPanel; //Field offset: 0x178
	[SerializeField]
	private GridSortPanel _sortPanel; //Field offset: 0x180
	[SerializeField]
	private TextMeshProUGUI _updatePricesTimerText; //Field offset: 0x188
	private readonly List _dynamicRequirementViews; //Field offset: 0x190
	private RequirementView _rubRequirementView; //Field offset: 0x198
	private readonly List _passedWarnings; //Field offset: 0x1A0
	private InventoryController _inventoryController; //Field offset: 0x1A8
	private ItemUiContext _itemUiContext; //Field offset: 0x1B0
	private Handbook _handbook; //Field offset: 0x1B8
	private RagFair _ragfair; //Field offset: 0x1C0
	private Item _selectedItem; //Field offset: 0x1C8
	private bool _sellInOnePiece; //Field offset: 0x1D0
	private bool _canRefresh; //Field offset: 0x1D1
	private float _timer; //Field offset: 0x1D4
	private double _requirementsCost; //Field offset: 0x1D8
	private List _cachedSlots; //Field offset: 0x1E0
	private WeaponPreviewPool _weaponPreviewPool; //Field offset: 0x1E8
	private WeaponPreview _weaponPreview; //Field offset: 0x1F0
	private NewOfferItemContext _itemContext; //Field offset: 0x1F8
	private RagfairNewOfferContext _offerContext; //Field offset: 0x200

	private double DependentRequirementsCost
	{
		private get { } //Length: 75
	}

	private TimeSpan Duration
	{
		private get { } //Length: 269
	}

	private int OfferItemCount
	{
		private get { } //Length: 32
	}

	protected virtual RectTransform RectTransform
	{
		 get { } //Length: 68
	}

	private BarterTemplate[] Requirements
	{
		private get { } //Length: 613
	}

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public AddOfferWindow() { }

	[CompilerGenerated]
	private void <AddOffer>b__69_0() { }

	[CompilerGenerated]
	private void <AddOffer>b__69_1() { }

	[CompilerGenerated]
	private void <AddOffer>b__69_2() { }

	[CompilerGenerated]
	private void <Awake>b__63_0(bool arg) { }

	[CompilerGenerated]
	private void <SetupWeapon>b__84_0() { }

	[CompilerGenerated]
	private void <SetupWeapon>b__84_1() { }

	[CompilerGenerated]
	private void <SetupWeapon>b__84_2(IResult arg) { }

	[CompilerGenerated]
	private void <Show>b__64_0() { }

	private void AddOffer() { }

	private void AutoSelectSimilarChanged(bool value) { }

	protected virtual void Awake() { }

	private EAddOfferWarning CalculateCurrentWarning() { }

	private IResult CheckRestrictions() { }

	private IResult CheckTemplateRestrictions(MongoID templateId, RagfairItemRestrictions restriction) { }

	public virtual void Close() { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs args) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs args) { }

	private static void EnsureTaxCorrect(InventoryController inventoryController, int taxPrice, int rubAmountBefore) { }

	private double get_DependentRequirementsCost() { }

	private TimeSpan get_Duration() { }

	private int get_OfferItemCount() { }

	protected virtual RectTransform get_RectTransform() { }

	private BarterTemplate[] get_Requirements() { }

	protected virtual bool get_ShowOnTop() { }

	private void ItemChangedHandler(Item item) { }

	private void ItemSelectionChanged(Item item, bool selected) { }

	private void OnNodePriceUpdatedHandler(Dictionary dictionary) { }

	private void PricesPanelOnOnPriceClick(float priceFloat) { }

	private void RefreshButtonPressed() { }

	private void SelectFirstAvailableItem() { }

	private void SetNoAvailableItemsBanner(bool hasItemForRagfairSale) { }

	private void SetPrices() { }

	private void SetSellInOnePiece(bool value) { }

	private void SetupWeapon(Item item) { }

	public DialogWindowContext Show(InventoryController inventoryController, CompoundItem[] lootItems, RagFair ragfair, Handbook handbook, ItemUiContext itemUiContext, WeaponPreviewPool weaponPreviewPool, Item itemToSelect = null) { }

	private void Update() { }

	private void UpdateMoneyCount() { }

	public void UpdateRagfairRating(float rating, bool isRatingGrowing) { }

}

