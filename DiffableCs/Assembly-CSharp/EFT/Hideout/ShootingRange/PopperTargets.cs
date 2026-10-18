namespace EFT.Hideout.ShootingRange;

public class PopperTargets : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__21_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <FoldTasks>b__18_0(PopperTarget target) { }

		internal bool <UnfoldTasks>b__21_0(PopperTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public PopperTargets <>4__this; //Field offset: 0x10
		public CancellationToken token; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal Task <FoldTasks>b__1(PopperTarget target) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public PopperTargets <>4__this; //Field offset: 0x10
		public CancellationToken token; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal Task <UnfoldTasks>b__1(PopperTarget target) { }

	}

	[CompilerGenerated]
	private struct <FoldButton>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnfoldButton>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTargets <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private int _rows; //Field offset: 0x20
	[SerializeField]
	private int _cols; //Field offset: 0x24
	[SerializeField]
	[Space]
	private PopperTarget[] _targets; //Field offset: 0x28
	[SerializeField]
	[Space]
	private AudioSource _foldAudio; //Field offset: 0x30
	[SerializeField]
	private AudioSource _unfoldAudio; //Field offset: 0x38
	private CancellationTokenSource _cancellationToken; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0x48

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int Cols
	{
		 get { } //Length: 4
	}

	public PopperTarget[] Targets
	{
		 get { } //Length: 5
	}

	public PopperTargets() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	private void Cancel() { }

	public Task Fold(CancellationToken token) { }

	public Task Fold(IFoldingTarget target, bool mute, CancellationToken token) { }

	[AsyncStateMachine(typeof(<FoldButton>d__23))]
	private void FoldButton() { }

	private Task[] FoldTasks(CancellationToken token) { }

	public int get_Cols() { }

	public PopperTarget[] get_Targets() { }

	private void HandleHitTarget(PopperTarget target, int segmentTarget) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	public Task Unfold(CancellationToken token) { }

	public Task Unfold(IFoldingTarget target, bool mute, CancellationToken token) { }

	[AsyncStateMachine(typeof(<UnfoldButton>d__24))]
	private void UnfoldButton() { }

	private Task[] UnfoldTasks(CancellationToken token) { }

}

