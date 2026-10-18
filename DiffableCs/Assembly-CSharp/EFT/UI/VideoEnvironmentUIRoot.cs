namespace EFT.UI;

public sealed class VideoEnvironmentUIRoot : EnvironmentUIRoot
{
	[CompilerGenerated]
	private struct <ResumePlaybackAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VideoEnvironmentUIRoot <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WarmupAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VideoEnvironmentUIRoot <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float PREPARE_TIMEOUT = 5; //Field offset: 0x0
	[SerializeField]
	private GameObject _videoHolderGameObject; //Field offset: 0x68
	private readonly HashSet _loggedErrors; //Field offset: 0x70
	private StreamingVideoPlayer[] _videoPlayers; //Field offset: 0x78
	private Renderer[] _videoRenderers; //Field offset: 0x80
	private Animator[] _synchronizedAnimators; //Field offset: 0x88
	private CancellationTokenSource _playbackCancellation; //Field offset: 0x90

	public VideoEnvironmentUIRoot() { }

	private void CancelPlaybackPreparation() { }

	private void HandleVideoError(VideoPlayer source, string message) { }

	public virtual void Hide(Action callbackOnHide) { }

	public virtual void Init(Camera alignmentCamera, IReadOnlyCollection events, bool isMain, EGameMode gameMode) { }

	private void OnDestroy() { }

	private void PauseVideos() { }

	private void ReleaseVideos() { }

	[AsyncStateMachine(typeof(<ResumePlaybackAsync>d__9))]
	private Task ResumePlaybackAsync(CancellationToken cancellationToken) { }

	private void SetAnimatorsEnabled(bool enabled) { }

	private void SetVideoRenderersEnabled(bool enabled) { }

	public virtual void Show(Action callbackOnShow) { }

	private void SubscribeToErrors(VideoPlayer videoPlayer) { }

	[AsyncStateMachine(typeof(<WarmupAsync>d__8))]
	public virtual Task WarmupAsync(CancellationToken cancellationToken) { }

}

