namespace EFT.UI;

public sealed class TraderDealScreen : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public Profile profile; //Field offset: 0x10
		public TraderDealScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass52_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private struct <InitAutoExchange>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task tradingRequestsAwaiter; //Field offset: 0x20
		public AutoExchange autoExchange; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDealButtonClickAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderDealScreen <>4__this; //Field offset: 0x20
		private AutoExchangeData <autoExchangeData>5__2; //Field offset: 0x28
		private Item <selectedItem>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAssortment>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderDealScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class TraderLoyaltyTabController : SimpleTabController
	{
		private readonly TraderDealScreen _screen; //Field offset: 0x10

		public TraderLoyaltyTabController(TraderDealScreen screen) { }

		public virtual void Show() { }

	}

	private sealed class TraderModeTabController : SimpleTabController
	{
		private readonly ETradeMode _tradeMode; //Field offset: 0x10
		private readonly TraderDealScreen _screen; //Field offset: 0x18

		public TraderModeTabController(ETradeMode tradeMode, TraderDealScreen traderDealScreen) { }

		public virtual void Show() { }

	}

	public const int DEFAULT_GRID_WIDTH = 10; //Field offset: 0x0
	public const int DEFAULT_GRID_HEIGHT = 25; //Field offset: 0x0
	private const int WHOLE_ASSORTMENT_LEVEL = 0; //Field offset: 0x0
	[SerializeField]
	private Tab _buyTab; //Field offset: 0x80
	[SerializeField]
	private Tab _sellTab; //Field offset: 0x88
	[SerializeField]
	private FilterTab[] _levelTabs; //Field offset: 0x90
	[SerializeField]
	private FilterTab _allItemsTab; //Field offset: 0x98
	[SerializeField]
	private FilterTab _eliteLevelTab; //Field offset: 0xA0
	[SerializeField]
	private TradingGridView _traderGridView; //Field offset: 0xA8
	[SerializeField]
	private TradingGridView _stashGridView; //Field offset: 0xB0
	[SerializeField]
	private SimpleStashPanel _stashPanel; //Field offset: 0xB8
	[SerializeField]
	private BarterSchemePanel _barterSchemePanel; //Field offset: 0xC0
	[SerializeField]
	private TradingTable _tradingTable; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _dealButton; //Field offset: 0xD0
	[SerializeField]
	private GameObject _traderGridLoader; //Field offset: 0xD8
	[SerializeField]
	private GameObject _userGridLoader; //Field offset: 0xE0
	[SerializeField]
	private GameObject _transactionLoader; //Field offset: 0xE8
	[SerializeField]
	private TMP_Text[] _equivalentSumValue; //Field offset: 0xF0
	[SerializeField]
	private ScrollRect _traderScroll; //Field offset: 0xF8
	[SerializeField]
	private ScrollRect _stashScroll; //Field offset: 0x100
	[SerializeField]
	private DefaultUIButton _updateAssort; //Field offset: 0x108
	[SerializeField]
	private Rotator _rotate; //Field offset: 0x110
	private Trader _lastTrader; //Field offset: 0x118
	private Trader _trader; //Field offset: 0x120
	private ETradeMode _tradeMode; //Field offset: 0x128
	private AutoExchange _autoExchange; //Field offset: 0x130
	private InventoryController _stashController; //Field offset: 0x138
	private Stash _stash; //Field offset: 0x140
	private ItemUiContext _itemUiContext; //Field offset: 0x148
	private QuestController _questController; //Field offset: 0x150
	private TraderTabGroup _loyaltyTabs; //Field offset: 0x158
	private TabGroup _tradingTabs; //Field offset: 0x160
	private ReferenceGrid _traderGrid; //Field offset: 0x168
	private bool _traderGridPrepared; //Field offset: 0x170
	private int _traderContentHashSum; //Field offset: 0x174
	private int _stashGridViewHashSum; //Field offset: 0x178
	private TradingItemContext _traderContext; //Field offset: 0x180
	private TradingItemContext _stashContext; //Field offset: 0x188
	private bool _restrictExternalTradingScreens; //Field offset: 0x190
	private readonly HashSet _renderedTraderIds; //Field offset: 0x198
	[CompilerGenerated]
	private Action OnTradingModeChanged; //Field offset: 0x1A0

	public event Action OnTradingModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private bool ShowAllTabSelected
	{
		private get { } //Length: 33
	}

	private ETradeMode TradeMode
	{
		private get { } //Length: 7
		private set { } //Length: 42
	}

	public TraderDealScreen() { }

	[CompilerGenerated]
	private void <SubscribeToAssortment>b__65_0() { }

	[CompilerGenerated]
	public void add_OnTradingModeChanged(Action value) { }

	private void AssortmentUpdatedHandler() { }

	private void Awake() { }

	public virtual void Close() { }

	public static string FormatPrice(int amount) { }

	public void FullClose() { }

	private bool get_ShowAllTabSelected() { }

	private ETradeMode get_TradeMode() { }

	private void HideAssortmentPanels() { }

	[AsyncStateMachine(typeof(<InitAutoExchange>d__54))]
	private static Task InitAutoExchange(AutoExchange autoExchange, Task tradingRequestsAwaiter) { }

	private bool IsValidDeal(out bool withAutoExchange, out AutoExchangeData exchangeData) { }

	private static int ItemsCollectionHashSum(IEnumerable items, bool ignoreStackCount) { }

	private void ManageLoyaltyFilterTabs(TraderInfo traderInfo) { }

	private void OnDealButtonClick() { }

	[AsyncStateMachine(typeof(<OnDealButtonClickAsync>d__56))]
	private Task OnDealButtonClickAsync() { }

	private void OnPriceChanged() { }

	private IReadOnlyCollection PrepareTraderGrid() { }

	[CompilerGenerated]
	public void remove_OnTradingModeChanged(Action value) { }

	private static void ResetScroll(ScrollRect scroll) { }

	private void ResetTraderGridScroll() { }

	public void SelectTab(ETradeMode mode) { }

	private void set_TradeMode(ETradeMode value) { }

	private void SetFilterTabsInteractable() { }

	private void SetGridLoadingStatus(bool active) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private bool ShouldUpdateStashGrid() { }

	private bool ShouldUpdateTraderGrid(out IReadOnlyCollection prepared) { }

	public void Show(Trader trader, Profile profile, InventoryController stashController, ETradeMode mode, ItemUiContext itemUiContext, QuestController questController, IEnumerable traders, Task tradingRequestsAwaiter, bool restrictActionsDuringDialog = false) { }

	private void ShowAssortmentPanels() { }

	private void ShowLoyaltyLevel(bool raiseEvents) { }

	private void SubscribeToAssortment() { }

	private void TraderModeChanged(ETradeMode tradeMode) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryGetPurchasePrice(out ECurrencyType currency, out int amount) { }

	private void TryShowWishlistPurchaseNotification(Item item) { }

	private void Update() { }

	[AsyncStateMachine(typeof(<UpdateAssortment>d__59))]
	private Task UpdateAssortment() { }

	private void UpdateAssortmentHandler() { }

	private void UpdateDealButton() { }

	private void UpdateGridViews(bool force, bool raiseEvents) { }

	private void UpdateTradeModeContexts() { }

}

