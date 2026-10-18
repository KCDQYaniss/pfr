namespace EFT;

public abstract class AbstractSessionOperation`1
{
	[CompilerGenerated]
	private struct <Execute>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractSessionOperation <>4__this; //Field offset: 0x0
		private Result <result>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected readonly ITradingSession Trading; //Field offset: 0x0

	protected AbstractSessionOperation`1(ITradingSession session) { }

	[AsyncStateMachine(typeof(<Execute>d__3))]
	public Task Execute() { }

	protected abstract Task ExecuteOnce() { }

}

