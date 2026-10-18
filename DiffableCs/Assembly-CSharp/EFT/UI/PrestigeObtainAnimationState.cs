namespace EFT.UI;

public sealed class PrestigeObtainAnimationState : EftScreenState
{
	[CompilerGenerated]
	private struct <ShowState>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrestigeObtainAnimationState <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private PrestigeAnimationPlayer _animationPlayer; //Field offset: 0x90
	private string _currentAnimation; //Field offset: 0x98
	private int _prestigeLevelToSet; //Field offset: 0xA0
	private EGameMode _gameMode; //Field offset: 0xA4

	public PrestigeAnimationPlayer AnimationPlayer
	{
		 get { } //Length: 8
	}

	public PrestigeObtainAnimationState() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	private void <ShowState>b__7_0() { }

	public PrestigeAnimationPlayer get_AnimationPlayer() { }

	public void Init(int prestigeLevelToSet, EGameMode gameMode = 0) { }

	[AsyncStateMachine(typeof(<ShowState>d__7))]
	public virtual Task ShowState() { }

}

