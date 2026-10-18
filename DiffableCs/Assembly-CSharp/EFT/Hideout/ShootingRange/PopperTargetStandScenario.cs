namespace EFT.Hideout.ShootingRange;

public class PopperTargetStandScenario : TargetScenario
{
	[CompilerGenerated]
	private struct <Complete>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTargetStandScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleHitTarget>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTargetStandScenario <>4__this; //Field offset: 0x28
		public int segmentTarget; //Field offset: 0x30
		public PopperTarget target; //Field offset: 0x38
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTargetStandScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class Setting
	{
		public float ResetDelay; //Field offset: 0x10

		public Setting() { }

	}

	private PopperTargets _targets; //Field offset: 0x30
	private Setting _setting; //Field offset: 0x38
	private CancellationToken _cancellationToken; //Field offset: 0x40

	public PopperTargetStandScenario(PopperTargets targets, Setting setting) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Complete>d__6))]
	public virtual Task Complete(CancellationToken token) { }

	public void Destroy() { }

	[AsyncStateMachine(typeof(<HandleHitTarget>d__7))]
	private void HandleHitTarget(PopperTarget target, int segmentTarget) { }

	[AsyncStateMachine(typeof(<Start>d__5))]
	public virtual Task Start(CancellationToken token) { }

}

