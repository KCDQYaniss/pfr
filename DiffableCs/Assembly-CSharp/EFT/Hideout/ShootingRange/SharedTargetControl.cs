namespace EFT.Hideout.ShootingRange;

public class SharedTargetControl : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Complete>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SharedTargetControl <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SharedTargetControl <>4__this; //Field offset: 0x20
		public TargetScenario targetScenario; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private TargetControl _targetControl; //Field offset: 0x20

	public SharedTargetControl() { }

	public void Cancel() { }

	[AsyncStateMachine(typeof(<Complete>d__2))]
	public Task Complete() { }

	[AsyncStateMachine(typeof(<Run>d__1))]
	public Task Run(TargetScenario targetScenario) { }

}

