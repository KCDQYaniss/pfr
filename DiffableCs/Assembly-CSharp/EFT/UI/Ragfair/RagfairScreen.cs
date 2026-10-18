namespace EFT.UI.Ragfair;

public sealed class RagfairScreen : UIScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__75_0; //Field offset: 0x8
		public static Action <>9__79_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OfferPurchaseHandler>b__75_0(KeyValuePair x) { }

		internal void <OfferRemovedHandler>b__79_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public IEftSession session; //Field offset: 0x10
		public CaptchaHandler captchaHandler; //Field offset: 0x18
		public Profile profile; //Field offset: 0x20
		public RagfairScreen <>4__this; //Field offset: 0x28

		public <>c__DisplayClass55_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public RagfairScreen <>4__this; //Field offset: 0x10
		public Offer offer; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass74_0() { }

		internal void <OfferRenewHandler>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public RagfairScreen <>4__this; //Field offset: 0x10
		public Offer offer; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass79_0() { }

		internal void <OfferRemovedHandler>b__0() { }

	}

	[CompilerGenerated]
	private struct <AddOffer>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagfairScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformPurchase>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagfairScreen <>4__this; //Field offset: 0x20
		public CommoditiesToPurchase newPurchases; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForAddOfferEnable>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagfairScreen <>4__this; //Field offset: 0x20
		public DateTime availableTime; //Field offset: 0x28
		private CancellationToken <token>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class RagfairScreenDataLoadManager : IGetOffersDataLoadManager
	{
		[CompilerGenerated]
		private struct <GetOffers>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public RagfairScreenDataLoadManager <>4__this; //Field offset: 0x20
			public RagFair ragfair; //Field offset: 0x28
			public bool updateCategories; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <LoadAutoExchange>d__9 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public RagfairScreenDataLoadManager <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly AutoExchange _autoExchange; //Field offset: 0x10
		private bool _autoExchangeLoaded; //Field offset: 0x18
		private bool _autoExchangeLoading; //Field offset: 0x19
		[CompilerGenerated]
		private string <HandbookId>k__BackingField; //Field offset: 0x20

		public private override string HandbookId
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public RagfairScreenDataLoadManager(AutoExchange autoExchange) { }

		[CompilerGenerated]
		public override string get_HandbookId() { }

		[AsyncStateMachine(typeof(<GetOffers>d__8))]
		public override Task GetOffers(RagFair ragfair, bool updateCategories) { }

		[AsyncStateMachine(typeof(<LoadAutoExchange>d__9))]
		private Task LoadAutoExchange() { }

		[CompilerGenerated]
		private void set_HandbookId(string value) { }

	}

	private const string RAGFAIR_REACHED_MAXIMUM_AMOUNT_OF_OFFERS = "ragfair/Reached maximum amount of offers"; //Field offset: 0x0
	private const string RAGFAIR_ARE_YOU_SURE_YOU_WANT_TO_REMOVE_YOUR_OFFER = "ragfair/Are you sure you want to remove your offer?"; //Field offset: 0x0
	private const string RAGFAIR_CURRENT_PLAYER_LEVEL = "Ragfair/CurrentPlayerLevel{0}"; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _addOfferButton; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _playerLevelLabel; //Field offset: 0x98
	[SerializeField]
	private GameObject _offerButtonLockIcon; //Field offset: 0xA0
	[SerializeField]
	private Button _filterButton; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _requirementsWindowContainer; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _myRagfairRating; //Field offset: 0xB8
	[SerializeField]
	private GameObject _positiveReputation; //Field offset: 0xC0
	[SerializeField]
	private GameObject _negativeReputation; //Field offset: 0xC8
	[SerializeField]
	private GameObject _myOffersCount; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _myOffersCurrentCount; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _myOffersMaxCount; //Field offset: 0xE0
	[SerializeField]
	private OfferViewList _offersListTemplate; //Field offset: 0xE8
	[SerializeField]
	private RectTransform _offersListContainer; //Field offset: 0xF0
	[SerializeField]
	private DisplayMoneyPanel _moneyCountPanel; //Field offset: 0xF8
	[SerializeField]
	private UIAnimatedToggleSpawner _allOffersToggle; //Field offset: 0x100
	[SerializeField]
	private UIAnimatedToggleSpawner _wishListToggle; //Field offset: 0x108
	[SerializeField]
	private UIAnimatedToggleSpawner _myOffersToggle; //Field offset: 0x110
	private ItemUiContext _itemUiContext; //Field offset: 0x118
	private RenewOfferWindow _renewOfferWindow; //Field offset: 0x120
	private HandoverRagfairMoneyWindow _handoverMoneyWindow; //Field offset: 0x128
	private RagfairFilterWindow _filterWindow; //Field offset: 0x130
	private OfferViewList _allOffersList; //Field offset: 0x138
	private OfferViewList _wishList; //Field offset: 0x140
	private OfferViewList _myOffersList; //Field offset: 0x148
	private HandoverExchangeableItemsWindow _handoverItemsWindow; //Field offset: 0x150
	private Profile _profile; //Field offset: 0x158
	private InventoryController _inventoryController; //Field offset: 0x160
	private CompoundItem[] _lootItems; //Field offset: 0x168
	private Dictionary _traders; //Field offset: 0x170
	private InsuranceCompany _insuranceCompany; //Field offset: 0x178
	private SocialNetwork _social; //Field offset: 0x180
	private RagFair _ragfair; //Field offset: 0x188
	private Handbook _handbook; //Field offset: 0x190
	private RagfairSearch _ragfairSearch; //Field offset: 0x198
	private OfferViewList _selectedTab; //Field offset: 0x1A0
	private int _maxCount; //Field offset: 0x1A8
	private bool _returnToBuilds; //Field offset: 0x1AC
	private bool _ragfairAvailability; //Field offset: 0x1AD
	private DialogWindowContext _addOfferContext; //Field offset: 0x1B0
	private DialogWindowContext _purchaseWindowContext; //Field offset: 0x1B8
	private WindowContext _filterWindowContext; //Field offset: 0x1C0
	private CancellationTokenSource _tmpDisableAddOfferTokenSource; //Field offset: 0x1C8
	private bool _isAddOfferButtonTemporaryDisabled; //Field offset: 0x1D0
	private AutoExchange _autoExchange; //Field offset: 0x1D8
	private RagfairScreenDataLoadManager _dataLoadManager; //Field offset: 0x1E0

	private bool BuildFilterActive
	{
		private get { } //Length: 54
	}

	public RagfairScreen() { }

	[CompilerGenerated]
	private void <Awake>b__51_0() { }

	[CompilerGenerated]
	private void <Awake>g__ClearIdFilter|51_1() { }

	[CompilerGenerated]
	private void <OfferPurchaseHandler>g__PerformPurchaseSync|75_1(CommoditiesToPurchase commodities) { }

	[CompilerGenerated]
	private void <Start>b__52_0(bool arg) { }

	[CompilerGenerated]
	private void <Start>b__52_1(bool arg) { }

	[CompilerGenerated]
	private void <Start>b__52_2(bool arg) { }

	[AsyncStateMachine(typeof(<AddOffer>d__59))]
	private Task AddOffer() { }

	private void AddToWishlistHandler(MongoID templateId, EWishlistGroup groupType) { }

	private void Awake() { }

	private void CancellableFilterAddedHandler(CancellableFilter filter) { }

	private void CancellableFilterRemovedHandler(CancellableFilter filter) { }

	public virtual void Close() { }

	private void FilterWindowClosed() { }

	private void FindById(string id) { }

	private bool get_BuildFilterActive() { }

	private bool IsAddOfferBlockedByPerk() { }

	private void OfferClosedHandler(Offer offer) { }

	private void OfferPurchaseHandler(bool displayInputField, Dictionary offers) { }

	private void OfferRemovedHandler(Offer offer, Action callback) { }

	private void OfferRenewHandler(Offer offer, Action callback) { }

	private void OnFilterRuleChangedHandler(ESetFilterSource source, bool clear, bool updateCategories) { }

	private void OnFindByIdHandler(Offer offer, object id, bool reset) { }

	private void OnPerksChanged() { }

	[AsyncStateMachine(typeof(<PerformPurchase>d__76))]
	private Task PerformPurchase(CommoditiesToPurchase newPurchases) { }

	private void PerformPurchaseCallback(CommoditiesToPurchase newPurchases) { }

	private void RagFairAvailabilityHandler(ERagFairStatus status) { }

	private void RemoveFromWishlistHandler(MongoID templateId, EWishlistGroup groupType) { }

	private void SelectAllOffersTab() { }

	private void SelectTab(OfferViewList tabToOpen, OffersWithNodes offers, EViewListType type, Nullable newRule = null) { }

	private void SetPurchaseWindowProcessing(bool isProcessing) { }

	public void Show(Profile profile, InventoryController inventoryController, CompoundItem[] lootItems, IHealthController healthController, IEftSession session, RagfairSearch search) { }

	private void Start() { }

	private void ToggleFilterWindow() { }

	private void ToggleOnSilently(UIAnimatedToggleSpawner toggle) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateAddOfferButton() { }

	private void UpdateAddOfferVisibility() { }

	private void UpdateAvailability(ERagFairStatus status) { }

	private void UpdateMoneyCount() { }

	private void UpdateMyOffersCount(EViewListType type) { }

	private void UpdateRagfairRating(float rating, bool isRatingGrowing) { }

	[AsyncStateMachine(typeof(<WaitForAddOfferEnable>d__56))]
	private Task WaitForAddOfferEnable(DateTime availableTime) { }

}

