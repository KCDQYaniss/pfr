namespace EFT.Trading;

public sealed class Assortment
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__64_1; //Field offset: 0x8
		public static Func <>9__64_0; //Field offset: 0x10
		public static Func <>9__72_0; //Field offset: 0x18
		public static Func <>9__73_0; //Field offset: 0x20
		public static Func <>9__76_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal double <GetBarterPrice>b__64_0(BarterVariant y) { }

		internal double <GetBarterPrice>b__64_1(BarterTemplate j) { }

		internal TradingItemReference <GetTradingItemReferences>b__76_0(Item x) { }

		internal IEnumerable <Purchase>b__73_0(Requisite x) { }

		internal bool <SetValidity>b__72_0(Requisite requisite) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Assortment <>4__this; //Field offset: 0x10
		public FlatItem[] allItems; //Field offset: 0x18

		public <>c__DisplayClass54_0() { }

		internal Dictionary <UpdateAssortment>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_1
	{
		public string newItemId; //Field offset: 0x10

		public <>c__DisplayClass54_1() { }

		internal bool <UpdateAssortment>b__1(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Item subItem; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal bool <IsBeingSold>b__1(Item sellableItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public Assortment <>4__this; //Field offset: 0x10
		public TradingItemReference[] itemReferences; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal void <Sell>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private struct <Purchase>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Assortment <>4__this; //Field offset: 0x20
		private Item <selectedItem>5__2; //Field offset: 0x28
		private IResult <purchaseResult>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SellAsSavage>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Assortment <>4__this; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		public string petId; //Field offset: 0x30
		private TradingItemReference[] <itemReferences>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateAssortment>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Assortment <>4__this; //Field offset: 0x20
		public bool ignoreTimeout; //Field offset: 0x28
		private <>c__DisplayClass54_0 <>8__1; //Field offset: 0x30
		private Result <result>5__2; //Field offset: 0x38
		private List <topLevelItems>5__3; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string ERROR_HEADER = "Error"; //Field offset: 0x0
	private static readonly int[] _silentErrors; //Field offset: 0x0
	private readonly ITradingSession _trading; //Field offset: 0x10
	private readonly Grid _stashGrid; //Field offset: 0x18
	private readonly ItemFactory _itemFactory; //Field offset: 0x20
	private readonly Trader _trader; //Field offset: 0x28
	private readonly string _traderId; //Field offset: 0x30
	private readonly Dictionary _clones; //Field offset: 0x38
	private Dictionary _schemes; //Field offset: 0x40
	public readonly BindableEvent SelectedItemChanged; //Field offset: 0x48
	public readonly BindableEvent ValidityChanged; //Field offset: 0x50
	public readonly BindableEvent QuantityChanged; //Field offset: 0x58
	public readonly BindableEvent PreparedSumChanged; //Field offset: 0x60
	public readonly BindableEvent AssortmentUpdated; //Field offset: 0x68
	public readonly BindableEvent TransactionChanged; //Field offset: 0x70
	public readonly BindableEvent PreparedItemsChanged; //Field offset: 0x78
	[CompilerGenerated]
	private Action RequisiteChanged; //Field offset: 0x80
	[CompilerGenerated]
	private Action ItemPrepared; //Field offset: 0x88
	public readonly ItemController TraderController; //Field offset: 0x90
	public readonly Stash SellingStash; //Field offset: 0x98
	public readonly Grid SellingTableGrid; //Field offset: 0xA0
	public readonly List CurrentRequisites; //Field offset: 0xA8
	private int _currentQuantity; //Field offset: 0xB0
	[CompilerGenerated]
	private Item <SelectedItem>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private Dictionary <LoyalLevelItems>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private ItemPrice <PreparedSum>k__BackingField; //Field offset: 0xC8
	private bool _transactionInProgress; //Field offset: 0xF0
	private float _buyRestrictionMul; //Field offset: 0xF4
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; //Field offset: 0xF8

	public event Action ItemPrepared
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action RequisiteChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public int CurrentQuantity
	{
		 get { } //Length: 7
		 set { } //Length: 494
	}

	private CompoundItem[] GetTraderCollections
	{
		private get { } //Length: 306
	}

	public private bool IsValid
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Dictionary LoyalLevelItems
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ItemPrice PreparedSum
	{
		[CompilerGenerated]
		 get { } //Length: 38
		[CompilerGenerated]
		private set { } //Length: 114
	}

	public private Item SelectedItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int SelectedItemBuyRestrictionMax
	{
		 get { } //Length: 46
	}

	public private bool TransactionInProgress
	{
		 get { } //Length: 8
		private set { } //Length: 40
	}

	private static Assortment() { }

	public Assortment(Trader trader, ITradingSession trading, ItemController traderController, TraderAssortment traderAssortment, string traderId, string traderNickname) { }

	[CompilerGenerated]
	private OperationResult <ClearSellItems>b__69_0(KeyValuePair item) { }

	[CompilerGenerated]
	private bool <IsBeingSold>b__56_0(Item subItem) { }

	[CompilerGenerated]
	private Requisite <SelectScheme>b__67_0(BarterTemplate x) { }

	[CompilerGenerated]
	public void add_ItemPrepared(Action value) { }

	[CompilerGenerated]
	public void add_RequisiteChanged(Action value) { }

	public bool CanPrepareItemToSell(Item item) { }

	public void ClearPreparedItems() { }

	private void ClearRequisitesList() { }

	public void ClearSellItems() { }

	public int get_CurrentQuantity() { }

	private CompoundItem[] get_GetTraderCollections() { }

	[CompilerGenerated]
	public bool get_IsValid() { }

	[CompilerGenerated]
	public Dictionary get_LoyalLevelItems() { }

	[CompilerGenerated]
	public ItemPrice get_PreparedSum() { }

	[CompilerGenerated]
	public Item get_SelectedItem() { }

	public int get_SelectedItemBuyRestrictionMax() { }

	public bool get_TransactionInProgress() { }

	public Nullable GetBarterPrice(Item[] items) { }

	[CanBeNull]
	public BarterScheme GetSchemeForClone(Item item) { }

	[CanBeNull]
	public BarterScheme GetSchemeForItem(Item item) { }

	private TradingItemReference[] GetTradingItemReferences() { }

	public bool IsBeingSold(Item item) { }

	private void OnRequisiteChanged(Requisite requisite) { }

	public void PrepareToSell(Item item, LocationInGrid location) { }

	[AsyncStateMachine(typeof(<Purchase>d__73))]
	public Task Purchase() { }

	public bool QuickFindTradingAppropriatePlace(Item item, Callback callback = null) { }

	[CanBeNull]
	private GridItemAddress QuickFindTradingLocation(Item item) { }

	[CompilerGenerated]
	public void remove_ItemPrepared(Action value) { }

	[CompilerGenerated]
	public void remove_RequisiteChanged(Action value) { }

	public void SelectItem(Item item) { }

	private void SelectScheme(Item selectedItem, int schemeIndex) { }

	public void Sell() { }

	[AsyncStateMachine(typeof(<SellAsSavage>d__75))]
	public Task SellAsSavage(string playerId, string petId) { }

	public void set_CurrentQuantity(int value) { }

	[CompilerGenerated]
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	private void set_LoyalLevelItems(Dictionary value) { }

	[CompilerGenerated]
	private void set_PreparedSum(ItemPrice value) { }

	[CompilerGenerated]
	private void set_SelectedItem(Item value) { }

	private void set_TransactionInProgress(bool value) { }

	public void SetValidity() { }

	public void UnprepareSellItem(Item item) { }

	[AsyncStateMachine(typeof(<UpdateAssortment>d__54))]
	public Task UpdateAssortment(bool ignoreTimeout) { }

	private void UpdateQuestsBackendCounters(TradingItemReference[] itemReferences) { }

}

