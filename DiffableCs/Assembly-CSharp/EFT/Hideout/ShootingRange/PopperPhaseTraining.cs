namespace EFT.Hideout.ShootingRange;

public class PopperPhaseTraining : TargetScenario, ITargetScoring
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Start>b__14_0(PopperTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public CancellationToken token; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal Task <ResetTargets>b__0(PopperTarget target) { }

	}

	[CompilerGenerated]
	private struct <Complete>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompleteProcess>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperPhaseTraining <>4__this; //Field offset: 0x20
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
		public PopperPhaseTraining <>4__this; //Field offset: 0x28
		public PopperTarget target; //Field offset: 0x30
		public int segmentTarget; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetTargets>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public PopperTarget[] prevTargets; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartProcess>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperPhaseTraining <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public PopperTarget[] prevTargets; //Field offset: 0x30
		private int[] <prevCols>5__2; //Field offset: 0x38
		private float <timeout>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnfoldTargetPopper>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTarget target; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		public int duration; //Field offset: 0x38
		public PopperPhaseTraining <>4__this; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class Setting
	{
		public bool Enabled; //Field offset: 0x10
		[Space]
		public int Rows; //Field offset: 0x14
		public int Amount; //Field offset: 0x18
		[Min(0.1)]
		public float ShowInterval; //Field offset: 0x1C
		public float HideDelay; //Field offset: 0x20
		[Space]
		public int ShotScore; //Field offset: 0x24
		public int FailScore; //Field offset: 0x28
		[Space]
		public int RowBonus; //Field offset: 0x2C
		public TimeBonusSetting TimeBonus; //Field offset: 0x30

		public Setting() { }

	}

	internal class TimeBonusSetting
	{
		public float Time; //Field offset: 0x10
		public int Score; //Field offset: 0x14
		public int MaxScore; //Field offset: 0x18

		public TimeBonusSetting() { }

	}

	private PopperTargets _popperTargets; //Field offset: 0x30
	private Setting _setting; //Field offset: 0x38
	private float _duration; //Field offset: 0x40
	private int _score; //Field offset: 0x44
	private int _timeBonusScore; //Field offset: 0x48

	public PopperPhaseTraining(PopperTargets popperTargets, Setting setting, float duration) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(CancellationToken token) { }

	[CompilerGenerated]
	private int <StartProcess>b__17_0(PopperTarget target) { }

	private void AddRowBonusScore(PopperTarget target) { }

	private void AddShotScore(int segmentTarget) { }

	private void AddTimeBonusScore(PopperTarget target) { }

	[AsyncStateMachine(typeof(<Complete>d__15))]
	public virtual Task Complete(CancellationToken token) { }

	[AsyncStateMachine(typeof(<CompleteProcess>d__18))]
	private Task CompleteProcess(CancellationToken token) { }

	public void Destroy() { }

	[AsyncStateMachine(typeof(<HandleHitTarget>d__7))]
	private void HandleHitTarget(PopperTarget target, int segmentTarget) { }

	private int[] RandomRange(int amount) { }

	private void RemoveFailScore(PopperTarget target) { }

	public override void ResetScore() { }

	[AsyncStateMachine(typeof(<ResetTargets>d__16))]
	private Task ResetTargets(PopperTarget[] prevTargets, CancellationToken token) { }

	public override int Score() { }

	[AsyncStateMachine(typeof(<Start>d__14))]
	public virtual Task Start(CancellationToken token) { }

	[AsyncStateMachine(typeof(<StartProcess>d__17))]
	private Task StartProcess(PopperTarget[] prevTargets, CancellationToken token) { }

	[AsyncStateMachine(typeof(<UnfoldTargetPopper>d__20))]
	private void UnfoldTargetPopper(PopperTarget target, int duration, CancellationToken token) { }

}

