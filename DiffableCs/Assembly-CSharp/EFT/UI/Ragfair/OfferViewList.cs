namespace EFT.UI.Ragfair;

public sealed class OfferViewList : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LightScrollerDataTypeGetter <>9__51_1; //Field offset: 0x8
		public static Func <>9__76_0; //Field offset: 0x10
		public static Func <>9__76_1; //Field offset: 0x18
		public static Func <>9__76_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal Enum <ManageOffers>b__51_1(Data offerData) { }

		internal int <UpdateListType>b__76_0(KeyValuePair x) { }

		internal string <UpdateListType>b__76_1(KeyValuePair x) { }

		internal bool <UpdateListType>b__76_2(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public OffersWithNodes offers; //Field offset: 0x10
		public OfferViewList <>4__this; //Field offset: 0x18
		public HandbookNodes originalNodes; //Field offset: 0x20

		public <>c__DisplayClass51_0() { }

		internal void <ManageOffers>b__2() { }

		internal void <ManageOffers>b__3() { }

		internal void <ManageOffers>b__4(NodeBaseView view, string id) { }

		internal void <ManageOffers>b__5(NodeBaseView view, string id) { }

		internal void <ManageOffers>b__6() { }

		internal void <ManageOffers>g__OnOffersChanged|0() { }

	}

	[CompilerGenerated]
	private struct <GetOffers>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OfferViewList <>4__this; //Field offset: 0x28
		public bool clear; //Field offset: 0x30
		public bool updateCategories; //Field offset: 0x31
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetOffers>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OfferViewList <>4__this; //Field offset: 0x20
		public bool updateCategories; //Field offset: 0x28
		public Action afterGetOffers; //Field offset: 0x30
		private RagFair <ragfair>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int REFRESH_COOLDOWN = 3; //Field offset: 0x0
	private const string NO_OFFERS_FOUND = "ragfair/No offers has been found in {0} category. Select another category."; //Field offset: 0x0
	[SerializeField]
	private FiltersPanel _filtersPanel; //Field offset: 0x70
	[SerializeField]
	private RagfairCategoriesPanel _browseCategoriesPanel; //Field offset: 0x78
	[SerializeField]
	private CancellableFiltersPanel _cancellableFiltersPanel; //Field offset: 0x80
	[SerializeField]
	private GameObject _loader; //Field offset: 0x88
	[SerializeField]
	private LightScroller _scroller; //Field offset: 0x90
	[SerializeField]
	private UIElement _cellViewPrefab; //Field offset: 0x98
	[SerializeField]
	private UIElement _updateDataPrefab; //Field offset: 0xA0
	[SerializeField]
	private RagfairAvailabilityWarning _availabilityWarningPrefab; //Field offset: 0xA8
	[SerializeField]
	private GameObject _notFoundObject; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _notFoundLabel; //Field offset: 0xB8
	[SerializeField]
	private MassPurchasePanel _massPurchasePanel; //Field offset: 0xC0
	[SerializeField]
	private Button _refreshButton; //Field offset: 0xC8
	private RagFair _ragfair; //Field offset: 0xD0
	private EViewListType _viewListType; //Field offset: 0xD8
	private HandbookNodes _categories; //Field offset: 0xE0
	private IGetOffersDataLoadManager _getOfferLoader; //Field offset: 0xE8
	private readonly Dictionary _pagesCount; //Field offset: 0xF0
	private ConvertedBindableList _offersData; //Field offset: 0xF8
	private OffersUpdatePanel _updatePanel; //Field offset: 0x100
	private NodeBaseView _selectedItemPanel; //Field offset: 0x108
	private Action _onClose; //Field offset: 0x110
	private Action _onFindById; //Field offset: 0x118
	private Handbook _handbook; //Field offset: 0x120
	private string _profileId; //Field offset: 0x128
	private Dictionary _traders; //Field offset: 0x130
	private ItemUiContext _itemUiContext; //Field offset: 0x138
	private InventoryController _inventoryController; //Field offset: 0x140
	private InsuranceCompany _insuranceCompany; //Field offset: 0x148
	private SocialNetwork _social; //Field offset: 0x150
	private CaptchaHandler _captchaHandler; //Field offset: 0x158
	private Action _onRenew; //Field offset: 0x160
	private Action _onPurchase; //Field offset: 0x168
	private Action _onRemove; //Field offset: 0x170
	private float _timer; //Field offset: 0x178
	private bool _canRefresh; //Field offset: 0x17C
	private RagfairSearch _currentSearch; //Field offset: 0x180
	private readonly CompositeDisposable _disposableContainer; //Field offset: 0x188
	private readonly UpdateData _updateData; //Field offset: 0x190
	private readonly AvailabilityWarning _availabilityWarning; //Field offset: 0x198
	private string _selectedNodeId; //Field offset: 0x1A0

	private int CurrentPage
	{
		private get { } //Length: 43
	}

	private int CurrentPageCount
	{
		private get { } //Length: 184
	}

	private bool WeaponBuildsMode
	{
		private get { } //Length: 99
	}

	public OfferViewList() { }

	[CompilerGenerated]
	private void <UpdatePagesCount>b__74_0() { }

	[CompilerGenerated]
	private void <UpdatePagesCount>b__74_1(int arg) { }

	private void Awake() { }

	private void CancellableFilterAddedHandler(CancellableFilter filter) { }

	private void CancellableFilterRemovedHandler(CancellableFilter filter) { }

	public void ClearIdFilter() { }

	public virtual void Close() { }

	private void DeselectSelectedItemPanel() { }

	private int get_CurrentPage() { }

	private int get_CurrentPageCount() { }

	private bool get_WeaponBuildsMode() { }

	[AsyncStateMachine(typeof(<GetOffers>d__66))]
	private void GetOffers(ESetFilterSource source, bool clear, bool updateCategories) { }

	[AsyncStateMachine(typeof(<GetOffers>d__67))]
	private Task GetOffers(bool updateCategories, Action afterGetOffers = null) { }

	private UIElement GetOfferView(Data offerData) { }

	private void HandbookNodeIdChangedHandler(string id, bool dropPage) { }

	private void HandleNodeSelection(OffersData offersData) { }

	public bool HandleScrollCommand(ECommand command) { }

	private void ItemAddedToWishListHandler(HandbookNode node) { }

	private void ManageOffers(OffersWithNodes offers) { }

	private bool OfferDataFromOffer(Offer offer, out Data convertedItem) { }

	private void OnFiltered() { }

	private void OnFindByIdHandler(Offer offer, object id, bool reset) { }

	private void OnGettingOffersProcessingHandler(bool active) { }

	private void OnYourOfferSoldHandler(Offer offer, int count, string handbookId) { }

	private void RefreshButtonPressedHandler() { }

	private void RefreshOffersPerPage(int offersPerPage) { }

	private void RemoveOffer(Offer offer) { }

	private void RemovePageCounter() { }

	private void ResetCategorySelection(string failedCategoryId) { }

	private void SetSelectedItemPanel(NodeBaseView view) { }

	public void Show(EViewListType type, Handbook handbook, string profileId, OffersWithNodes offers, Dictionary traders, ItemUiContext itemUiContext, RagFair ragfair, InventoryController inventoryController, InsuranceCompany insuranceCompany, SocialNetwork social, Action onRenew, Action onPurchase, Action onRemove, Action onClose, Action onFindById, IGetOffersDataLoadManager getOfferLoader, RagfairSearch currentSearch = null) { }

	private void ShowOffer(Data offerData, UIElement dataView) { }

	private void Update() { }

	private void UpdateListType() { }

	public void UpdateOffersForced() { }

	private void UpdatePagesCount(OffersUpdatePanel view) { }

}

