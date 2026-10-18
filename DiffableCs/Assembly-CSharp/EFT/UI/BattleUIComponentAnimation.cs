namespace EFT.UI;

public sealed class BattleUIComponentAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Hide>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattleUIComponentAnimation <>4__this; //Field offset: 0x20
		public float delaySeconds; //Field offset: 0x28
		private CancellationTokenSource <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattleUIComponentAnimation <>4__this; //Field offset: 0x20
		public float delaySeconds; //Field offset: 0x28
		public bool autoHide; //Field offset: 0x2C
		private CancellationTokenSource <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const float VISIBILITY_DURATION = 3; //Field offset: 0x0
	private const float ANIMATION_DURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x20
	private CancellationTokenSource _animationCancellation; //Field offset: 0x28

	public BattleUIComponentAnimation() { }

	public void Close() { }

	[AsyncStateMachine(typeof(<Hide>d__5))]
	public Task Hide(float delaySeconds = 0) { }

	[AsyncStateMachine(typeof(<Show>d__4))]
	public Task Show(bool autoHide, float delaySeconds = 0) { }

	public CancellationTokenSource StopAnimation() { }

}

