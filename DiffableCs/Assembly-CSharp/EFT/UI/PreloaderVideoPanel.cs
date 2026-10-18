namespace EFT.UI;

public sealed class PreloaderVideoPanel : PreloaderPanelBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal void <SoftShow>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public TaskCompletionSource tcs; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal void <SoftHide>b__0() { }

	}

	[CompilerGenerated]
	private struct <SoftHide>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderVideoPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SoftShow>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderVideoPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float FADE_DURATION = 0.5; //Field offset: 0x0
	[SerializeField]
	private StreamingVideoPlayer _streamingVideoPlayer; //Field offset: 0x70
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x78
	[SerializeField]
	private RawImage _sourceImage; //Field offset: 0x80
	[SerializeField]
	private AudioClipConfig _audioConfig; //Field offset: 0x88
	[SerializeField]
	private bool _playOnEnable; //Field offset: 0x90
	[SerializeField]
	private bool _loop; //Field offset: 0x91
	[SerializeField]
	private bool _useMovement; //Field offset: 0x92
	[SerializeField]
	private Vector2 _movementOffset; //Field offset: 0x94
	private Vector2 _startPosition; //Field offset: 0x9C
	private Sequence _softSequence; //Field offset: 0xA8

	private VideoPlayer VideoPlayer
	{
		private get { } //Length: 233
	}

	public PreloaderVideoPanel() { }

	private void Awake() { }

	public virtual void Close() { }

	private VideoPlayer get_VideoPlayer() { }

	public virtual void Hide(bool soft) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void Pause() { }

	public void Play() { }

	public virtual void Show(bool soft) { }

	[AsyncStateMachine(typeof(<SoftHide>d__17))]
	private Task SoftHide() { }

	[AsyncStateMachine(typeof(<SoftShow>d__15))]
	private Task SoftShow() { }

	public void Stop() { }

}

