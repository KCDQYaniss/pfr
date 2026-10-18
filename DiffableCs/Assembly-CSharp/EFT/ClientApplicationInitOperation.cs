namespace EFT;

public sealed class ClientApplicationInitOperation : Operation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public List excludedBundlesMask; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <ExecuteInternal>b__0(string x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__CursorVisibilityChangedHandler; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <ExecuteInternal>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x28
		public IBundleLock bundleLock; //Field offset: 0x30
		public Func bundlesCheck; //Field offset: 0x38
		public ClientApplicationInitOperation <>4__this; //Field offset: 0x40
		public bool resetSettings; //Field offset: 0x48
		public EUpdateQueue playerUpdateQueue; //Field offset: 0x4C
		private IOperation <operation>5__2; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60
		private OperationAwaiter <>u__3; //Field offset: 0x68
		private TaskAwaiter <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadUserSettings>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20
		private TaskAwaiter <>u__2; //Field offset: 0x28
		private TaskAwaiter <>u__3; //Field offset: 0x30
		private YieldAwaiter <>u__4; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WarmupBundleShaders>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public ClientApplicationInitOperation() { }

	private static void CursorVisibilityChangedHandler(bool isCursorVisible) { }

	public static ClientApplicationInitOperation Execute(bool resetSettings, EUpdateQueue playerUpdateQueue, IBundleLock bundleLock, Func bundlesCheck = null) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__1))]
	private void ExecuteInternal(bool resetSettings, EUpdateQueue playerUpdateQueue, IBundleLock bundleLock, Func bundlesCheck = null) { }

	[AsyncStateMachine(typeof(<LoadUserSettings>d__5))]
	private static Task LoadUserSettings() { }

	private static void UpdateCursorTexture(bool isCursorVisible) { }

	[AsyncStateMachine(typeof(<WarmupBundleShaders>d__4))]
	private Task WarmupBundleShaders() { }

}

