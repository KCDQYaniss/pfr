namespace EFT.Hideout.ShootingRange;

public class ShootTrainingScenario : TargetScenario
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <Score>b__20_0(ITargetScoring v) { }

	}

	[CompilerGenerated]
	private struct <Complete>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootTrainingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompleteProcess>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootTrainingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetProcess>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootTrainingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootTrainingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPhases>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TargetScenario[] targetScenarios; //Field offset: 0x20
		public TargetControl targetControl; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TargetScenario[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartProcess>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShootTrainingScenario <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class PhaseSetting
	{
		public float Duration; //Field offset: 0x10
		public Setting PopperTargets; //Field offset: 0x18
		public Setting RailTargets; //Field offset: 0x20

		public PhaseSetting() { }

	}

	internal class Setting
	{
		public float Delay; //Field offset: 0x10
		public PhaseSetting[] Phases; //Field offset: 0x18

		public Setting() { }

	}

	private RailTargets _railTargets; //Field offset: 0x30
	private PopperTargets _popperTargets; //Field offset: 0x38
	private Setting _setting; //Field offset: 0x40
	private PopperPhaseTraining[] _popperPhasesTraining; //Field offset: 0x48
	private RailPhaseTraining[] _railPhasesTraining; //Field offset: 0x50
	private RailSpeedPhaseTraining[] _railSpeedPhasesTraining; //Field offset: 0x58
	private TargetControl _popperPhasesControl; //Field offset: 0x60
	private TargetControl _railPhasesControl; //Field offset: 0x68
	private TargetControl _railSpeedPhasesControl; //Field offset: 0x70

	public ShootTrainingScenario(RailTargets railTargets, PopperTargets popperTargets, Setting setting) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(CancellationToken token) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(CancellationToken token) { }

	public virtual void Cancel() { }

	private void CancelPhases(TargetScenario[] targetScenarios) { }

	[AsyncStateMachine(typeof(<Complete>d__12))]
	public virtual Task Complete(CancellationToken token) { }

	[AsyncStateMachine(typeof(<CompleteProcess>d__15))]
	private Task CompleteProcess(CancellationToken token) { }

	public void Destroy() { }

	[AsyncStateMachine(typeof(<ResetProcess>d__16))]
	private Task ResetProcess(CancellationToken token) { }

	private void ResetScore() { }

	private void ResetScore(ITargetScoring[] list) { }

	public int Score() { }

	private int Score(ITargetScoring[] list) { }

	[AsyncStateMachine(typeof(<Start>d__11))]
	public virtual Task Start(CancellationToken token) { }

	[AsyncStateMachine(typeof(<StartPhases>d__17))]
	private Task StartPhases(TargetControl targetControl, TargetScenario[] targetScenarios, CancellationToken token) { }

	[AsyncStateMachine(typeof(<StartProcess>d__14))]
	private Task StartProcess(CancellationToken token) { }

}

