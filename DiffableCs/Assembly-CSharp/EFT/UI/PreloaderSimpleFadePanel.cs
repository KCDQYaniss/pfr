namespace EFT.UI;

public class PreloaderSimpleFadePanel : PreloaderPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal void <SoftShow>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <SoftHide>b__0() { }

	}

	[CompilerGenerated]
	private struct <SoftHide>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderSimpleFadePanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SoftShow>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderSimpleFadePanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected const float FADE_DURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	protected CanvasGroup _canvasGroup; //Field offset: 0x70
	protected Sequence _softSequence; //Field offset: 0x78

	public PreloaderSimpleFadePanel() { }

	public virtual void Close() { }

	public virtual void Hide(bool soft) { }

	public virtual void Show(bool soft) { }

	[AsyncStateMachine(typeof(<SoftHide>d__6))]
	protected Task SoftHide() { }

	[AsyncStateMachine(typeof(<SoftShow>d__5))]
	protected Task SoftShow() { }

}

