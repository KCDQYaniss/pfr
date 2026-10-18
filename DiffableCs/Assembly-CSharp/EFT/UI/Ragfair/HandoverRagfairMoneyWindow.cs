namespace EFT.UI.Ragfair;

public sealed class HandoverRagfairMoneyWindow : BaseMessageWindow
{
	[CompilerGenerated]
	private struct <<ValidateAcceptButton>g__WaitForAutoExchange|31_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HandoverRagfairMoneyWindow <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_2; //Field offset: 0x8
		public static Func <>9__29_3; //Field offset: 0x10
		public static Func <>9__30_0; //Field offset: 0x18
		public static Func <>9__30_1; //Field offset: 0x20
		public static Func <>9__30_2; //Field offset: 0x28
		public static Func <>9__30_4; //Field offset: 0x30
		public static Func <>9__30_3; //Field offset: 0x38
		public static Func <>9__32_1; //Field offset: 0x40
		public static Func <>9__32_2; //Field offset: 0x48
		public static Func <>9__32_4; //Field offset: 0x50
		public static Func <>9__34_1; //Field offset: 0x58
		public static Func <>9__34_2; //Field offset: 0x60
		public static Func <>9__35_1; //Field offset: 0x68
		public static Func <>9__35_0; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal int <Awake>b__29_2(KeyValuePair x) { }

		internal IExchangeable <Awake>b__29_3(KeyValuePair offer) { }

		internal int <RecalculateReferences>b__32_1(ItemReference x) { }

		internal int <RecalculateReferences>b__32_2(ItemReference y) { }

		internal int <RecalculateReferences>b__32_4(ItemReference y) { }

		internal bool <Show>b__30_0(KeyValuePair x) { }

		internal DateTime <Show>b__30_1(KeyValuePair x) { }

		internal int <Show>b__30_2(KeyValuePair x) { }

		internal bool <Show>b__30_3(KeyValuePair x) { }

		internal IExchangeable <Show>b__30_4(KeyValuePair offer) { }

		internal bool <UpdateItemsData>b__34_1(Money item) { }

		internal int <UpdateItemsData>b__34_2(Money x) { }

		internal int <UpdateWindowDescription>b__35_0(CommodityToPurchase x) { }

		internal bool <UpdateWindowDescription>b__35_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public int newCount; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal int <Awake>b__4(KeyValuePair _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public int selectedCount; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal int <Show>b__5(KeyValuePair _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public ECurrencyType moneyType; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <RecalculateReferences>b__0(ItemReference x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_1
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass32_1() { }

		internal bool <RecalculateReferences>b__3(ItemReference x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public CurrencyData currencyData; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <UpdateItemsData>b__0(Money item) { }

	}

	[CompilerGenerated]
	private struct <ResultAction>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HandoverRagfairMoneyWindow <>4__this; //Field offset: 0x20
		private bool <moneyCheck>5__2; //Field offset: 0x28
		private AutoExchangeData <exchangeData>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string NOT_ENOUGH_MONEY_MESSAGE = "ragfair/You don't have enough money for the transaction"; //Field offset: 0x0
	private const string PURCHASE_CONFIRMATION_ONE_ITEM = "ragfair/Are you sure you want to buy {0} ({1}) for {2}?"; //Field offset: 0x0
	private const string PURCHASE_CONFIRMATION_MULTIPLE_ITEMS = "Are you sure you want to buy selected items for {0}?"; //Field offset: 0x0
	private const string ITEM_PURCHASE = "ragfair/Item purchase"; //Field offset: 0x0
	[SerializeField]
	private GameObject _countPanel; //Field offset: 0xF0
	[SerializeField]
	private TMP_InputField _inputField; //Field offset: 0xF8
	[SerializeField]
	private CustomTextMeshProUGUI _maxCountLabel; //Field offset: 0x100
	[SerializeField]
	private Button _allItemsButton; //Field offset: 0x108
	[SerializeField]
	private GameObject _loadingSpinner; //Field offset: 0x110
	public Dictionary Goods; //Field offset: 0x118
	private CommoditiesToPurchase _items; //Field offset: 0x120
	private Item[] _playerItems; //Field offset: 0x128
	private Action _accept; //Field offset: 0x130
	private DateTime _endTime; //Field offset: 0x138
	private EMemberCategory _type; //Field offset: 0x140
	private IEnumerator _timerWorker; //Field offset: 0x148
	private bool _canShowCloseButton; //Field offset: 0x150
	private AutoExchange _autoExchange; //Field offset: 0x158
	private Inventory _inventory; //Field offset: 0x160
	private Dictionary _neededAmount; //Field offset: 0x168
	private Dictionary _existingAmount; //Field offset: 0x170
	private bool _purchaseProcessing; //Field offset: 0x178
	private bool _acceptWasAvailable; //Field offset: 0x179
	private DialogWindowContext _dialogContext; //Field offset: 0x180
	private TaskCompletionSource _exchangeLoadingEnableTaskCompletionSource; //Field offset: 0x188

	protected virtual bool CloseOnAccept
	{
		 get { } //Length: 3
	}

	private TimeSpan TimeLeft
	{
		private get { } //Length: 146
	}

	public HandoverRagfairMoneyWindow() { }

	[CompilerGenerated]
	private void <Awake>b__29_0(string arg) { }

	[CompilerGenerated]
	private void <Awake>b__29_1() { }

	[AsyncStateMachine(typeof(<<ValidateAcceptButton>g__WaitForAutoExchange|31_0>d))]
	[CompilerGenerated]
	private Task <ValidateAcceptButton>g__WaitForAutoExchange|31_0() { }

	private void AcceptHandler() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void CloseHandler() { }

	protected virtual bool get_CloseOnAccept() { }

	private TimeSpan get_TimeLeft() { }

	private static string GetSpriteAlias(ECurrencyType moneyType) { }

	private void RecalculateReferences(Item[] playerItems, out Dictionary neededAmount) { }

	private void RefreshWindowState() { }

	[AsyncStateMachine(typeof(<ResultAction>d__37))]
	private Task ResultAction() { }

	public void SetPurchaseProcessing(bool isProcessing) { }

	public DialogWindowContext Show(Inventory inventory, bool displayInputField, Dictionary goods, Action acceptAction, bool canShowCloseButton, AutoExchange autoExchange) { }

	private void Tick() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateItemsData(Item[] playerItems) { }

	private void UpdateWindowDescription() { }

	private void ValidateAcceptButton() { }

}

