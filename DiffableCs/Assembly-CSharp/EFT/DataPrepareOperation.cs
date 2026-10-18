namespace EFT;

internal static class DataPrepareOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal void <CompleteSelectedProfile>b__0(Result _) { }

	}

	[CompilerGenerated]
	private struct <CompleteSelectedProfile>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession backendSession; //Field offset: 0x20
		private <>c__DisplayClass2_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession backendSession; //Field offset: 0x20
		private Task <loadingWeather>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectProfile>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEftSession backendSession; //Field offset: 0x20
		private Token <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<CompleteSelectedProfile>d__2))]
	public static Task CompleteSelectedProfile(IEftSession backendSession) { }

	public static void PrepareSelectedProfileLocally(IEftSession backendSession) { }

	[AsyncStateMachine(typeof(<Run>d__0))]
	public static Task Run(IEftSession backendSession) { }

	[AsyncStateMachine(typeof(<SelectProfile>d__3))]
	public static Task SelectProfile(IEftSession backendSession) { }

}

