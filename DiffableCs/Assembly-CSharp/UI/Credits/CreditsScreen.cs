namespace UI.Credits;

public sealed class CreditsScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <AutoScrollCoroutine>d__50 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreditsScreen <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AutoScrollCoroutine>d__50(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <DoFadeOutComplete>d__51 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CreditsScreen <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <DoFadeOutComplete>d__51(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class CreditsScreenController : EftScreenController
	{
		public readonly Action CompleteCallback; //Field offset: 0x58
		[CompilerGenerated]
		private bool <IsCreditsCompleted>k__BackingField; //Field offset: 0x60
		[CompilerGenerated]
		private readonly float <AddDelayAfterComplete>k__BackingField; //Field offset: 0x64

		public float AddDelayAfterComplete
		{
			[CompilerGenerated]
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher CameraBlur
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher IgnorePlayerInput
		{
			 get { } //Length: 6
		}

		public private bool IsCreditsCompleted
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironment
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher ShowEnvironmentCamera
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		public CreditsScreenController(float addDelayAfterComplete = 0, Action completeCallback = null) { }

		[CompilerGenerated]
		private void <.ctor>b__24_0() { }

		[CompilerGenerated]
		public float get_AddDelayAfterComplete() { }

		protected virtual EStateSwitcher get_CameraBlur() { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		protected virtual EStateSwitcher get_IgnorePlayerInput() { }

		[CompilerGenerated]
		public bool get_IsCreditsCompleted() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		protected virtual EStateSwitcher get_ShowEnvironment() { }

		protected virtual EStateSwitcher get_ShowEnvironmentCamera() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		[CompilerGenerated]
		private void set_IsCreditsCompleted(bool value) { }

	}

	private const float BASE_AFTER_FADE_DELAY = 1; //Field offset: 0x0
	[SerializeField]
	private ScrollRect _scrollRect; //Field offset: 0xA0
	[SerializeField]
	private Image _skipProgressFill; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _skipCanvas; //Field offset: 0xB0
	[SerializeField]
	private CanvasGroup _skipButtonCanvas; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _fadeCanvas; //Field offset: 0xC0
	[SerializeField]
	private RectTransform _contentContainer; //Field offset: 0xC8
	[SerializeField]
	private GameObject _creditsSectionHolder; //Field offset: 0xD0
	[SerializeField]
	private CreditsEntryView _h1Prefab; //Field offset: 0xD8
	[SerializeField]
	private CreditsEntryView _h2Prefab; //Field offset: 0xE0
	[SerializeField]
	private CreditsEntryView _h3Prefab; //Field offset: 0xE8
	[SerializeField]
	private CreditsEntryView _personRolePrefab; //Field offset: 0xF0
	[SerializeField]
	private CreditsEntryView _personNamePrefab; //Field offset: 0xF8
	[SerializeField]
	private TextAsset _creditsCSV; //Field offset: 0x100
	[SerializeField]
	private float _baseScrollSpeed; //Field offset: 0x108
	[SerializeField]
	private float _speedModifierUp; //Field offset: 0x10C
	[SerializeField]
	private float _speedModifierDown; //Field offset: 0x110
	[SerializeField]
	private float _timeToSkip; //Field offset: 0x114
	[SerializeField]
	private float _skipShowTime; //Field offset: 0x118
	[SerializeField]
	private float _backwardTimeMul; //Field offset: 0x11C
	[SerializeField]
	private float _startCreditsDelay; //Field offset: 0x120
	[SerializeField]
	private float _minViewTime; //Field offset: 0x124
	[SerializeField]
	private float _fadeOutDelay; //Field offset: 0x128
	[SerializeField]
	private float _fadeOutDuration; //Field offset: 0x12C
	[SerializeField]
	private float _fadeInDuration; //Field offset: 0x130
	[SerializeField]
	private float _startDelay; //Field offset: 0x134
	[SerializeField]
	private float _skipButtonShowDuration; //Field offset: 0x138
	[SerializeField]
	private AudioClipConfig _backgroundMusicConfig; //Field offset: 0x140
	[SerializeField]
	private int _backgroundMusicMinVolumeIndex; //Field offset: 0x148
	private float _currentSkipTime; //Field offset: 0x14C
	private float _currentScrollSpeed; //Field offset: 0x150
	private float _calculatedScrollSpeed; //Field offset: 0x154
	private float _startTime; //Field offset: 0x158
	private bool _skipActive; //Field offset: 0x15C
	private bool _canSkip; //Field offset: 0x15D
	private bool _fadeOutStarted; //Field offset: 0x15E
	private Tween _skipShowTween; //Field offset: 0x160
	private Tween _skipHideTween; //Field offset: 0x168
	private Action _completeCallback; //Field offset: 0x170
	private Coroutine _autoScrollCoroutine; //Field offset: 0x178
	private Coroutine _fadeOutCoroutine; //Field offset: 0x180
	private bool _isContentGenerated; //Field offset: 0x188
	private readonly List _creditsObjects; //Field offset: 0x190

	public CreditsScreen() { }

	[IteratorStateMachine(typeof(<AutoScrollCoroutine>d__50))]
	private IEnumerator AutoScrollCoroutine() { }

	public virtual void Close() { }

	private void CreateCreditsEntry(CreditsEntry entry, Transform currentSectionHolder) { }

	private CreditsEntryView CreateViewInstance(CreditsEntryView prefab, Transform currentSectionHolder) { }

	[IteratorStateMachine(typeof(<DoFadeOutComplete>d__51))]
	private IEnumerator DoFadeOutComplete() { }

	private void GenerateCreditsContent() { }

	private void PlayMusic() { }

	private void SetDefaultSkipState() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public virtual void Show(CreditsScreenController controller) { }

	private void Show(Action completeCallback) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

}

