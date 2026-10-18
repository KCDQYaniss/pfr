namespace EFT.UI;

[UsedImplicitly]
public sealed class SubtitlesView : UIElement
{
	[CompilerGenerated]
	private struct <AddCCLine>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SubtitlesView <>4__this; //Field offset: 0x20
		public ActiveCCLine line; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowSubtitles>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SubtitlesView <>4__this; //Field offset: 0x20
		public IEnumerable ccData; //Field offset: 0x28
		public Func passedTime; //Field offset: 0x30
		private Subtitles <currentSubs>5__2; //Field offset: 0x38
		private TaskCompletionSource <taskSource>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TMP_Text _textField; //Field offset: 0x70
	private readonly CompositeDisposable _currentSubsDisposable; //Field offset: 0x78
	private readonly HashSet _activeLines; //Field offset: 0x80

	public SubtitlesView() { }

	[CompilerGenerated]
	private void <ShowSubtitles>b__3_0() { }

	[AsyncStateMachine(typeof(<AddCCLine>d__5))]
	private Task AddCCLine(ActiveCCLine line) { }

	private void CompileText() { }

	private void ShowCCLine(ActiveCCLine line) { }

	[AsyncStateMachine(typeof(<ShowSubtitles>d__3))]
	public Task ShowSubtitles(IEnumerable ccData, Func passedTime = null) { }

}

