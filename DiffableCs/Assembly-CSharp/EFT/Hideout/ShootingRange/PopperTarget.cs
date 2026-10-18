namespace EFT.Hideout.ShootingRange;

[RequireComponent(typeof(FoldingPopperTarget))]
public class PopperTarget : MonoBehaviour, IFoldingTarget
{
	[CompilerGenerated]
	private struct <FoldButton>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTarget <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RockingButton>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTarget <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UnfoldButton>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PopperTarget <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private int _row; //Field offset: 0x20
	[SerializeField]
	[Space]
	private PaperTarget _paperTarget; //Field offset: 0x28
	private FoldingPopperTarget _foldingPopperTarget; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0x38
	private CancellationTokenSource _cancellationToken; //Field offset: 0x40

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool Folded
	{
		 get { } //Length: 33
	}

	public bool Ready
	{
		 get { } //Length: 33
	}

	public float ReadyTime
	{
		 get { } //Length: 95
	}

	public int Row
	{
		 get { } //Length: 4
	}

	public bool Unfolded
	{
		 get { } //Length: 33
	}

	public PopperTarget() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	private void Awake() { }

	private void Cancel() { }

	public override Task Fold(bool mute, CancellationToken token) { }

	[AsyncStateMachine(typeof(<FoldButton>d__25))]
	private void FoldButton() { }

	public bool get_Folded() { }

	public bool get_Ready() { }

	public float get_ReadyTime() { }

	public int get_Row() { }

	public bool get_Unfolded() { }

	private void HandleHitTarget(TargetColliderType targetColliderType, int segmentTarget) { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	public override Task Rocking(CancellationToken token) { }

	[AsyncStateMachine(typeof(<RockingButton>d__27))]
	private void RockingButton() { }

	public override Task Unfold(bool mute, CancellationToken token) { }

	[AsyncStateMachine(typeof(<UnfoldButton>d__26))]
	private void UnfoldButton() { }

}

