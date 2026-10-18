namespace EFT.Hideout.ShootingRange;

public class RailTargetShootingScenario : TargetScenario
{
	[CompilerGenerated]
	private struct <Start>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargetShootingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private RailTargets _targets; //Field offset: 0x30

	public RailTargetShootingScenario(RailTargets targets) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Start>d__2))]
	public virtual Task Start(CancellationToken token) { }

}

