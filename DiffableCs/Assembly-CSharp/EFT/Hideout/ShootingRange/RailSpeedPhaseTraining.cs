namespace EFT.Hideout.ShootingRange;

public class RailSpeedPhaseTraining : TargetScenario
{
	[CompilerGenerated]
	private struct <Complete>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailSpeedPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompleteProcess>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailSpeedPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailSpeedPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartProcess>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailSpeedPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private float <timeout>5__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private RailTargets _railTargets; //Field offset: 0x30
	private Setting _setting; //Field offset: 0x38
	private float _duration; //Field offset: 0x40

	public RailSpeedPhaseTraining(RailTargets railTargets, Setting setting, float duration) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Complete>d__5))]
	public virtual Task Complete(CancellationToken token) { }

	[AsyncStateMachine(typeof(<CompleteProcess>d__7))]
	private Task CompleteProcess(CancellationToken token) { }

	[AsyncStateMachine(typeof(<Start>d__4))]
	public virtual Task Start(CancellationToken token) { }

	[AsyncStateMachine(typeof(<StartProcess>d__6))]
	private Task StartProcess(CancellationToken token) { }

}

