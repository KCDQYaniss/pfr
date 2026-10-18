namespace EFT.Hideout.ShootingRange;

public class TargetControl
{
	[CompilerGenerated]
	private struct <Complete>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public TargetScenario targetScenario; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Complete>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public TargetScenario targetScenario; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Complete>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Complete>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public TargetScenario targetScenario; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetControl <>4__this; //Field offset: 0x20
		public TargetScenario targetScenario; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private TargetScenario _currentTargetScenario; //Field offset: 0x10
	private CancellationTokenSource _currentCancellation; //Field offset: 0x18

	public TargetControl() { }

	public void Cancel() { }

	private void CancelCurrentScenario() { }

	[AsyncStateMachine(typeof(<Complete>d__12))]
	public Task Complete(TargetScenario targetScenario) { }

	[AsyncStateMachine(typeof(<Complete>d__13))]
	public Task Complete(TargetScenario targetScenario, CancellationToken token) { }

	[AsyncStateMachine(typeof(<Complete>d__14))]
	private Task Complete(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Complete>d__15))]
	public Task Complete() { }

	private Task CompleteCurrentScenario(CancellationToken token) { }

	private CancellationTokenSource CreateCancellation() { }

	private CancellationTokenSource CreateCancellation(CancellationToken token) { }

	private void SetCurrentScenario(TargetScenario targetScenario) { }

	[AsyncStateMachine(typeof(<Start>d__9))]
	public Task Start(TargetScenario targetScenario) { }

	[AsyncStateMachine(typeof(<Start>d__10))]
	public Task Start(TargetScenario targetScenario, CancellationToken token) { }

	[AsyncStateMachine(typeof(<Start>d__11))]
	private Task Start(CancellationToken token) { }

	private Task StartCurrentScenario(CancellationToken token) { }

	private void UnsetCurrentScenario() { }

}

