namespace EFT;

public sealed class TradingGetAssortmentOperation : TradingAbstractOperation
{
	[CompilerGenerated]
	private struct <ExecuteOnce>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TradingGetAssortmentOperation <>4__this; //Field offset: 0x20
		private TaskCompletionSource <source>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public TradingGetAssortmentOperation(ITradingSession trading, string traderId) { }

	[AsyncStateMachine(typeof(<ExecuteOnce>d__1))]
	protected virtual Task ExecuteOnce() { }

}

