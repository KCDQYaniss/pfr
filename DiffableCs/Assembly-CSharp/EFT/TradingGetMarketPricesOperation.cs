namespace EFT;

public sealed class TradingGetMarketPricesOperation : TradingAbstractOperation
{
	[CompilerGenerated]
	private struct <ExecuteOnce>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TradingGetMarketPricesOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public TradingGetMarketPricesOperation(ITradingSession trading, string traderId) { }

	[AsyncStateMachine(typeof(<ExecuteOnce>d__1))]
	protected virtual Task ExecuteOnce() { }

}

