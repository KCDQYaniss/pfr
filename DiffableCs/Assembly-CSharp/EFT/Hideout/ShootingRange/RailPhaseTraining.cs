namespace EFT.Hideout.ShootingRange;

public class RailPhaseTraining : TargetScenario, ITargetScoring
{
	[CompilerGenerated]
	private struct <Complete>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompleteProcess>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailPhaseTraining <>4__this; //Field offset: 0x20
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
		public RailPhaseTraining <>4__this; //Field offset: 0x28
		public RailTarget target; //Field offset: 0x30
		public int ring; //Field offset: 0x38
		public TargetColliderType targetColliderType; //Field offset: 0x3C
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartProcess>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RailPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private float <timeout>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnfoldTargetRail>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTarget target; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		public int duration; //Field offset: 0x38
		public RailPhaseTraining <>4__this; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class RowBonusSetting
	{
		public int Score; //Field offset: 0x10
		public int MaxScore; //Field offset: 0x14

		public RowBonusSetting() { }

	}

	internal class Setting
	{
		public bool Enabled; //Field offset: 0x10
		[Space]
		public int Rows; //Field offset: 0x14
		[Min(0.1)]
		public float ShowInterval; //Field offset: 0x18
		public float HideDelay; //Field offset: 0x1C
		[Space]
		public MovementSpeed[] Speeds; //Field offset: 0x20
		public float MinSpeedDuration; //Field offset: 0x28
		public float MaxSpeedDuration; //Field offset: 0x2C
		[Space]
		public int HeadShotScore; //Field offset: 0x30
		public int FailScore; //Field offset: 0x34
		[Space]
		public RowBonusSetting RowBonus; //Field offset: 0x38

		public Setting() { }

	}

	private RailTargets _railTargets; //Field offset: 0x30
	private Setting _setting; //Field offset: 0x38
	private float _duration; //Field offset: 0x40
	private int _score; //Field offset: 0x44
	private int _rowBonusScore; //Field offset: 0x48

	public RailPhaseTraining(RailTargets railTargets, Setting setting, float duration) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(CancellationToken token) { }

	private void AddRowBonusScore(RailTarget target) { }

	private void AddShotScore(TargetColliderType targetColliderType, int shotRing) { }

	[AsyncStateMachine(typeof(<Complete>d__14))]
	public virtual Task Complete(CancellationToken token) { }

	[AsyncStateMachine(typeof(<CompleteProcess>d__16))]
	private Task CompleteProcess(CancellationToken token) { }

	public void Destroy() { }

	[AsyncStateMachine(typeof(<HandleHitTarget>d__7))]
	private void HandleHitTarget(RailTarget target, TargetColliderType targetColliderType, int ring) { }

	private void RemoveFailScore(RailTarget target) { }

	public override void ResetScore() { }

	public override int Score() { }

	[AsyncStateMachine(typeof(<Start>d__13))]
	public virtual Task Start(CancellationToken token) { }

	[AsyncStateMachine(typeof(<StartProcess>d__15))]
	private Task StartProcess(CancellationToken token) { }

	[AsyncStateMachine(typeof(<UnfoldTargetRail>d__17))]
	private void UnfoldTargetRail(RailTarget target, int duration, CancellationToken token) { }

}

