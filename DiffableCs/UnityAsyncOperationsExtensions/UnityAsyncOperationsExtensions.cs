//Type is in global namespace

[Extension]
public static class UnityAsyncOperationsExtensions
{
	[CompilerGenerated]
	private struct <Await>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AsyncOperation operation; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Await>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AsyncOperation operation; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<Await>d__0))]
	[Extension]
	public static Task Await(AsyncOperation operation) { }

	[AsyncStateMachine(typeof(<Await>d__1))]
	[Extension]
	public static Task Await(AsyncOperation operation, CancellationToken token) { }

}

