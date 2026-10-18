namespace EFT.Trading;

public sealed class FenceTrader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8
		public static Func <>9__12_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__11_0(Trader trader) { }

		internal TradingItemReference <SellItems>b__12_0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <SellItems>b__1(IResult result) { }

	}

	[CompilerGenerated]
	private struct <Init>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FenceTrader <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action OnReadyStatusChanged; //Field offset: 0x10
	private readonly ITradingSession _tradingSession; //Field offset: 0x18
	private Trader _fence; //Field offset: 0x20
	private Assortment _fenceAssortment; //Field offset: 0x28
	private bool _ready; //Field offset: 0x30

	public event Action OnReadyStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private bool Ready
	{
		 get { } //Length: 5
		private set { } //Length: 33
	}

	public FenceTrader(ITradingSession session) { }

	[CompilerGenerated]
	public void add_OnReadyStatusChanged(Action value) { }

	public bool get_Ready() { }

	[AsyncStateMachine(typeof(<Init>d__11))]
	private Task Init() { }

	[CompilerGenerated]
	public void remove_OnReadyStatusChanged(Action value) { }

	public Task SellItems(IEnumerable items, int price) { }

	private void set_Ready(bool value) { }

}

