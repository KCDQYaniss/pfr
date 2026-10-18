namespace EFT.Hideout.ShootingRange;

public class TargetScenario
{
	[CompilerGenerated]
	private struct <Complete>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetScenario <>4__this; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetScenario <>4__this; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Action _handleStart; //Field offset: 0x10
	private Action _handleComplete; //Field offset: 0x18
	private Action _handleCancel; //Field offset: 0x20
	private bool _enabled; //Field offset: 0x28

	public bool Disabled
	{
		 get { } //Length: 8
	}

	public bool Enabled
	{
		 get { } //Length: 5
	}

	public TargetScenario() { }

	public override void Cancel() { }

	[AsyncStateMachine(typeof(<Complete>d__9))]
	public override Task Complete(CancellationToken token) { }

	public bool get_Disabled() { }

	public bool get_Enabled() { }

	public void OnCancel(Action callback) { }

	public void OnComplete(Action callback) { }

	public void OnStart(Action callback) { }

	[AsyncStateMachine(typeof(<Start>d__8))]
	public override Task Start(CancellationToken token) { }

}

