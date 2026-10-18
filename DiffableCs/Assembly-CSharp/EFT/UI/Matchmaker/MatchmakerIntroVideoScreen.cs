namespace EFT.UI.Matchmaker;

public sealed class MatchmakerIntroVideoScreen : EftScreen
{
	[CompilerGenerated]
	private struct <LoadAssets>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerIntroVideoScreen <>4__this; //Field offset: 0x20
		private CancellationTokenSource <cancelTimeout>5__2; //Field offset: 0x28
		private Task[] <loadTasks>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAudio>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerIntroVideoScreen <>4__this; //Field offset: 0x20
		private CancellationToken <token>5__2; //Field offset: 0x28
		private AudioClip <audioClip>5__3; //Field offset: 0x30
		private UnityWebRequest <audioLoadRequest>5__4; //Field offset: 0x38
		private UnityWebRequestAsyncOperation <loadOperation>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadingTimeout>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancelTimeout; //Field offset: 0x20
		public CancellationTokenSource source; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadVideo>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MatchmakerIntroVideoScreen <>4__this; //Field offset: 0x20
		private CancellationToken <token>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class MatchmakerIntroVideoScreenController : EftScreenController
	{
		public readonly Action CompleteCallback; //Field offset: 0x58
		[CompilerGenerated]
		private bool <IsVideoCompleted>k__BackingField; //Field offset: 0x60

		public private bool IsVideoCompleted
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public MatchmakerIntroVideoScreenController() { }

		[CompilerGenerated]
		private void <.ctor>b__11_0() { }

		[CompilerGenerated]
		public bool get_IsVideoCompleted() { }

		public virtual bool get_KeyScreen() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		private void set_IsVideoCompleted(bool value) { }

	}

	private const string VIDEO_ASSET_PATH = "Intro/IntroVideo.mp4"; //Field offset: 0x0
	private const string AUDIO_ASSET_PATH = "Intro/IntroSound-"; //Field offset: 0x0
	private const string SUBTITLES_KEY = "68d6c08ac4b4997eeb79db5c"; //Field offset: 0x0
	private const string LOADING_TIMEOUT_ERROR = "Screen closed or loading timeout"; //Field offset: 0x0
	[SerializeField]
	private VideoPlayer _videoPlayer; //Field offset: 0xA0
	[SerializeField]
	private AudioSource _audioSource; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _videoCanvas; //Field offset: 0xB0
	[SerializeField]
	private Image _skipProgressFill; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _skipCanvas; //Field offset: 0xC0
	[SerializeField]
	private CanvasGroup _subtitlesToggleCanvas; //Field offset: 0xC8
	[SerializeField]
	private CanvasGroup _subtitlesCanvas; //Field offset: 0xD0
	[SerializeField]
	private SubtitlesView _subtitlesView; //Field offset: 0xD8
	[SerializeField]
	private TMP_Text _subtitlesToggleLabel; //Field offset: 0xE0
	[SerializeField]
	private float _timeToSkip; //Field offset: 0xE8
	[SerializeField]
	private float _skipShowTime; //Field offset: 0xEC
	[SerializeField]
	private float _backwardTimeMul; //Field offset: 0xF0
	[SerializeField]
	private float _subtitlesToggleStartTime; //Field offset: 0xF4
	[SerializeField]
	private float _subtitlesToggleReopenTime; //Field offset: 0xF8
	[SerializeField]
	private float _subtitlesToggleFadeTime; //Field offset: 0xFC
	private float _currentSkipTime; //Field offset: 0x100
	private bool _skipActive; //Field offset: 0x104
	private bool _isSubtitlesVisible; //Field offset: 0x105
	private Tween _skipShowTween; //Field offset: 0x108
	private Tween _skipHideTween; //Field offset: 0x110
	private Tween _hideSubtitlesToggleTween; //Field offset: 0x118
	private DateTime _subtitleToggleReopenEnableTime; //Field offset: 0x120
	private bool _isCancelled; //Field offset: 0x128
	private Action _completeCallback; //Field offset: 0x130
	private CancellationTokenSource _loadingAssetsCancellation; //Field offset: 0x138

	private string AudioAssetPath
	{
		private get { } //Length: 211
	}

	public MatchmakerIntroVideoScreen() { }

	private void BuildSubtitlesToggleTween(float lifeTime) { }

	public virtual void Close() { }

	private string get_AudioAssetPath() { }

	private bool IsSubtitlesVisibleByDefault() { }

	[AsyncStateMachine(typeof(<LoadAssets>d__34))]
	private Task LoadAssets() { }

	[AsyncStateMachine(typeof(<LoadAudio>d__35))]
	private Task LoadAudio() { }

	[AsyncStateMachine(typeof(<LoadingTimeout>d__37))]
	private Task LoadingTimeout(CancellationTokenSource source, CancellationToken cancelTimeout) { }

	[AsyncStateMachine(typeof(<LoadVideo>d__36))]
	private Task LoadVideo() { }

	private void OnVideoError(VideoPlayer source, string message) { }

	private void SetDefaultSkipState() { }

	private void SetSubtitlesVisible(bool visible) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private void Show(Action completeCallback) { }

	public virtual void Show(MatchmakerIntroVideoScreenController controller) { }

	private void ToggleSubtitlesVisible() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UnsubscribeFromVideoEvents() { }

	private void Update() { }

	private void ValidateSubtitlesToggleLabel() { }

	private void VideoCompletedHandler(VideoPlayer source) { }

}

