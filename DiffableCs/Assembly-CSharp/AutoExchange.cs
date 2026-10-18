//Type is in global namespace

public class AutoExchange
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8
		public static Func <>9__14_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <ExchangeCurrency>b__14_0(KeyValuePair x) { }

		internal bool <ExchangeCurrency>b__14_1(Item item) { }

	}

	[CompilerGenerated]
	private struct <ApproveAutoExchange>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AutoExchangeData exchangeData; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExchangeCurrency>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int amountToBuy; //Field offset: 0x20
		public AutoExchange <>4__this; //Field offset: 0x28
		public ECurrencyType targetCurrency; //Field offset: 0x30
		private Assortment <assortment>5__2; //Field offset: 0x38
		private Item <previousItem>5__3; //Field offset: 0x40
		private int <previousQuantity>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAssortments>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AutoExchange <>4__this; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct AutoExchangeData : IEquatable
	{
		public ECurrencyType CurrencyToAutoExchange; //Field offset: 0x0
		public int ExistingAmount; //Field offset: 0x4
		public int AmountToAutoExchange; //Field offset: 0x8
		public int PriceToAutoExchange; //Field offset: 0xC
		public Trader ExchangeTrader; //Field offset: 0x10

		public override bool Equals(AutoExchangeData other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	private readonly InventoryController _stashController; //Field offset: 0x10
	private readonly Trader _peacekeeper; //Field offset: 0x18
	private readonly Trader _skier; //Field offset: 0x20
	private readonly List _traders; //Field offset: 0x28
	private readonly List _refreshAssortTraders; //Field offset: 0x30
	private TaskCompletionSource _refreshCompletionSource; //Field offset: 0x38

	public Task RefreshAssortmentTask
	{
		 get { } //Length: 67
	}

	public AutoExchange(InventoryController stashController, IEnumerable traders) { }

	[AsyncStateMachine(typeof(<ApproveAutoExchange>d__12))]
	public Task ApproveAutoExchange(AutoExchangeData exchangeData) { }

	private bool CanAutoExchange(ECurrencyType targetCurrency, int amountToExchange, out int priceAmount, out Trader exchangeTrader) { }

	public bool CanPurchaseAssortmentWithAutoExchange(Assortment purchaseAssortment, out AutoExchangeData autoExchangeData) { }

	public bool CanPurchaseWithAutoExchange(Dictionary requirements, out AutoExchangeData autoExchangeData) { }

	[AsyncStateMachine(typeof(<ExchangeCurrency>d__14))]
	public Task ExchangeCurrency(ECurrencyType targetCurrency, int amountToBuy) { }

	public Task get_RefreshAssortmentTask() { }

	private int GetPlayerCurrencyAmount(ECurrencyType currencyType) { }

	private Task RefreshAssortment(Trader trader) { }

	[AsyncStateMachine(typeof(<RefreshAssortments>d__10))]
	public Task RefreshAssortments() { }

	private bool TryGetExchangeBarterVariant(ECurrencyType fromCurrency, ECurrencyType toCurrency, out BarterVariant barterVariant, out Assortment assortment, out Item targetCurrencyItem, out Trader outTrader) { }

}

