namespace EFT.Hideout.ShootingRange;

public class RailTargets : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8
		public static Func <>9__34_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FoldTasks>b__31_0(RailTarget target) { }

		internal bool <UnfoldTasks>b__34_0(RailTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public RailTargets <>4__this; //Field offset: 0x10
		public CancellationToken token; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal Task <FoldTasks>b__1(RailTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public RailTargets <>4__this; //Field offset: 0x10
		public CancellationToken token; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal Task <UnfoldTasks>b__1(RailTarget target) { }

	}

	[CompilerGenerated]
	private struct <FoldButton>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InspectButton>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetButton>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResetShootingButton>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShootingButton>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnfoldButton>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RailTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private RailTarget[] _targets; //Field offset: 0x20
	[SerializeField]
	[Space]
	private AudioSource _foldAudio; //Field offset: 0x28
	[SerializeField]
	private AudioSource _unfoldAudio; //Field offset: 0x30
	private CancellationTokenSource _cancellationToken; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0x40

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public RailTarget[] Targets
	{
		 get { } //Length: 5
	}

	public RailTargets() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	private void Cancel() { }

	public Task Fold(IFoldingTarget target, bool mute, CancellationToken token) { }

	public Task Fold(CancellationToken token) { }

	[AsyncStateMachine(typeof(<FoldButton>d__36))]
	private void FoldButton() { }

	private Task[] FoldTasks(CancellationToken token) { }

	public RailTarget[] get_Targets() { }

	private void HandleHitTarget(RailTarget target, TargetColliderType targetColliderType, int segmentTarget) { }

	public Task Inspect(CancellationToken token) { }

	public Task Inspect(RailTarget[] targets, CancellationToken token) { }

	[AsyncStateMachine(typeof(<InspectButton>d__40))]
	private void InspectButton() { }

	private Task[] InspectTasks(RailTarget[] targets, CancellationToken token) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	[AsyncStateMachine(typeof(<ResetButton>d__41))]
	private void ResetButton() { }

	public Task ResetInspect(CancellationToken token) { }

	public Task ResetInspect(RailTarget[] targets, CancellationToken token) { }

	private Task[] ResetInspectTasks(RailTarget[] targets, CancellationToken token) { }

	public Task ResetShooting(RailTarget[] targets, CancellationToken token) { }

	public Task ResetShooting(CancellationToken token) { }

	[AsyncStateMachine(typeof(<ResetShootingButton>d__39))]
	private void ResetShootingButton() { }

	private Task[] ResetShootingTasks(RailTarget[] targets, CancellationToken token) { }

	public Task RestoreInspect(RailTarget[] targets, CancellationToken token) { }

	public Task RestoreInspect(CancellationToken token) { }

	private Task[] RestoreInspectTasks(RailTarget[] targets, CancellationToken token) { }

	public void SetSpeed(RailTarget[] targets, int value) { }

	public void SetSpeed(int value) { }

	public Task Shooting(CancellationToken token) { }

	public Task Shooting(RailTarget[] targets, CancellationToken token) { }

	[AsyncStateMachine(typeof(<ShootingButton>d__38))]
	private void ShootingButton() { }

	private Task[] ShootingTasks(RailTarget[] targets, CancellationToken token) { }

	public Task Unfold(CancellationToken token) { }

	public Task Unfold(IFoldingTarget target, bool mute, CancellationToken token) { }

	[AsyncStateMachine(typeof(<UnfoldButton>d__37))]
	private void UnfoldButton() { }

	private Task[] UnfoldTasks(CancellationToken token) { }

}

