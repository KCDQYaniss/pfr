namespace UI.Subtitles;

public sealed class SubtitlesAuthorityController : UIElement
{
	[CompilerGenerated]
	private struct <StartSubtitlesAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ESubtitlesSource source; //Field offset: 0x20
		public SubtitlesAuthorityController <>4__this; //Field offset: 0x28
		public IEnumerable subtitlesData; //Field offset: 0x30
		public Func passedTime; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private CanvasGroup _subtitlesRoot; //Field offset: 0x70
	[SerializeField]
	private SubtitlesView _subtitlesView; //Field offset: 0x78
	private bool _isVisible; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnAuthorityOverruled; //Field offset: 0x88
	[CompilerGenerated]
	private ESubtitlesSource <CurrentAuthority>k__BackingField; //Field offset: 0x90

	public event Action OnAuthorityOverruled
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private ESubtitlesSource CurrentAuthority
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public SubtitlesAuthorityController() { }

	[CompilerGenerated]
	public void add_OnAuthorityOverruled(Action value) { }

	[CompilerGenerated]
	public ESubtitlesSource get_CurrentAuthority() { }

	public void Init() { }

	private bool IsVisibleOnScreen(EEftScreenType screenType) { }

	[CompilerGenerated]
	public void remove_OnAuthorityOverruled(Action value) { }

	private void ScreenChangeHandler(EEftScreenType screen) { }

	[CompilerGenerated]
	private void set_CurrentAuthority(ESubtitlesSource value) { }

	private void SetVisible(bool visible) { }

	public void StartSubtitles(ESubtitlesSource source, IEnumerable subtitlesData, Func passedTime = null) { }

	[AsyncStateMachine(typeof(<StartSubtitlesAsync>d__12))]
	public Task StartSubtitlesAsync(ESubtitlesSource source, IEnumerable subtitlesData, Func passedTime = null) { }

	public void StopSubtitles(ESubtitlesSource source) { }

	private void ValidateVisibility(EEftScreenType currentScreen) { }

}

