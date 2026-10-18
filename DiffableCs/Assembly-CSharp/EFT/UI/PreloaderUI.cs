namespace EFT.UI;

public sealed class PreloaderUI : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public PreloaderUI <>4__this; //Field offset: 0x10
		public float step; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20

		public <>c__DisplayClass81_0() { }

		internal void <FadeBlackScreen>b__0() { }

		internal void <FadeBlackScreen>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public ErrorScreen errorScreen; //Field offset: 0x10
		public PreloaderUI <>4__this; //Field offset: 0x18
		public ErrorWindowContext context; //Field offset: 0x20

		public <>c__DisplayClass90_0() { }

		internal void <ShowCriticalErrorScreen>g__Continue|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public ErrorScreenData nextErrorData; //Field offset: 0x10
		public ErrorWindowContext context; //Field offset: 0x18

		public <>c__DisplayClass93_0() { }

		internal void <OpenNextErrorScreen>g__CloseHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <CanShowLossTimerCoroutine>d__95 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PreloaderUI <>4__this; //Field offset: 0x20
		private float <normalizedTime>5__2; //Field offset: 0x28

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
		public <CanShowLossTimerCoroutine>d__95(int <>1__state) { }

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
	private sealed class <Co_ShowBlackImage>d__99 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float to; //Field offset: 0x20
		public float step; //Field offset: 0x24
		public PreloaderUI <>4__this; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private float <alpha>5__2; //Field offset: 0x38

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
		public <Co_ShowBlackImage>d__99(int <>1__state) { }

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
	private struct <MakeScreenshot>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderUI <>4__this; //Field offset: 0x20
		private string <capturePath>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenNextErrorScreen>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PreloaderUI <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string TRAINING_SESSION_ID = "TRAINING"; //Field offset: 0x0
	public const string LOCAL_GAME_SESSION_ID = "LOCAL"; //Field offset: 0x0
	public const string TUTORIAL_SESSION_ID = "TUTORIAL"; //Field offset: 0x0
	private const float SHOW_RTT_DURATION = 2; //Field offset: 0x0
	private const float SHOW_LOSS_DURATION = 2; //Field offset: 0x0
	private const float SHOW_LOSS_THRESHOLD_TIMER = 30; //Field offset: 0x0
	private const string EXTENSION = ".png"; //Field offset: 0x0
	private static readonly string ScreenshotsFolderPath; //Field offset: 0x0
	[SerializeField]
	private LocalizedText _alphaVersionLabel; //Field offset: 0x20
	[SerializeField]
	private RectTransform _childrenContainer; //Field offset: 0x28
	[SerializeField]
	private Image _overlapBlackImage; //Field offset: 0x30
	[SerializeField]
	private RaidStartIntro _raidStartIntro; //Field offset: 0x38
	[SerializeField]
	private TMP_FPSCounter _fpsCounter; //Field offset: 0x40
	[SerializeField]
	private HideoutLoadingScreen _hideoutLoadingScreen; //Field offset: 0x48
	[SerializeField]
	private PveGameModeLoadingScreen _pveLoadingScreen; //Field offset: 0x50
	[SerializeField]
	private NarrateLoadingScreen _narrateLoadingScreen; //Field offset: 0x58
	[SerializeField]
	private GameObject _rttObject; //Field offset: 0x60
	[SerializeField]
	private TextMeshProUGUI _rttLabel; //Field offset: 0x68
	[SerializeField]
	private GameObject _lossObject; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _lossLabel; //Field offset: 0x78
	[SerializeField]
	private GameObject _loader; //Field offset: 0x80
	[SerializeField]
	private ItemUiContext _UIContext; //Field offset: 0x88
	[SerializeField]
	private GameObject _bottomPanelBackground; //Field offset: 0x90
	[SerializeField]
	private ErrorScreen ErrorScreen; //Field offset: 0x98
	[SerializeField]
	private ErrorScreen _criticalErrorScreenTemplate; //Field offset: 0xA0
	[SerializeField]
	private EmptyInputNode _criticalErrorScreenContainer; //Field offset: 0xA8
	[SerializeField]
	private BattleUIMalfunctionGlow _malfunctionGlow; //Field offset: 0xB0
	[SerializeField]
	public TMP_Text WetLog; //Field offset: 0xB8
	public Dictionary Binds; //Field offset: 0xC0
	public ClientWatermark ClientWatermark; //Field offset: 0xC8
	public ConsoleScreen Console; //Field offset: 0xD0
	public UnknownErrorScreen UnknownErrorScreen; //Field offset: 0xD8
	public NotifierView NotifierView; //Field offset: 0xE0
	public MenuTaskBar MenuTaskBar; //Field offset: 0xE8
	private Coroutine _showBlackImageCoroutine; //Field offset: 0xF0
	private Nullable _menuTaskBarVisibilityBeforeHide; //Field offset: 0xF8
	private double _currentRtt; //Field offset: 0x100
	private double _currentLoss; //Field offset: 0x108
	private float _rttTimer; //Field offset: 0x110
	private float _lossTimer; //Field offset: 0x114
	private string _alphaVersionText; //Field offset: 0x118
	private string _sessionIdText; //Field offset: 0x120
	private string _commitsNotMatchText; //Field offset: 0x128
	private string _sessionModeText; //Field offset: 0x130
	private bool _streamMode; //Field offset: 0x138
	private double showRttThreshold; //Field offset: 0x140
	private int showLossThreshold; //Field offset: 0x148
	private bool _canShowLoss; //Field offset: 0x14C
	private Coroutine _canShowLossesCoroutine; //Field offset: 0x150
	private List _errorsQueue; //Field offset: 0x158
	private string _capturePath; //Field offset: 0x160
	private int _captureIteration; //Field offset: 0x168

	public bool CanShowErrorScreen
	{
		 get { } //Length: 98
	}

	public InputNode ErrorScreenInputNode
	{
		 get { } //Length: 8
	}

	public TMP_FPSCounter FPSCounter
	{
		 get { } //Length: 5
	}

	public HideoutLoadingScreen HideoutLoadingScreen
	{
		 get { } //Length: 5
	}

	public BattleUIMalfunctionGlow MalfunctionGlow
	{
		 get { } //Length: 8
	}

	public NarrateLoadingScreen NarrateLoadingScreen
	{
		 get { } //Length: 5
	}

	public bool RaidInfoVisibility
	{
		 set { } //Length: 152
	}

	public string Size
	{
		 get { } //Length: 27
	}

	private static PreloaderUI() { }

	public PreloaderUI() { }

	private void ApplyMenuTaskBarVisibility(bool visible) { }

	public virtual void Awake() { }

	[IteratorStateMachine(typeof(<CanShowLossTimerCoroutine>d__95))]
	private IEnumerator CanShowLossTimerCoroutine() { }

	public void ClearErrorQueue() { }

	public void CloseErrorScreen() { }

	public void ClosePveLoadingScreen() { }

	[IteratorStateMachine(typeof(<Co_ShowBlackImage>d__99))]
	private IEnumerator Co_ShowBlackImage(float to, float step, Action callback = null) { }

	public void FadeBlackScreen(float pause, float step) { }

	public string GenerateScreenshotPath() { }

	public bool get_CanShowErrorScreen() { }

	public InputNode get_ErrorScreenInputNode() { }

	public TMP_FPSCounter get_FPSCounter() { }

	public HideoutLoadingScreen get_HideoutLoadingScreen() { }

	public BattleUIMalfunctionGlow get_MalfunctionGlow() { }

	public NarrateLoadingScreen get_NarrateLoadingScreen() { }

	public string get_Size() { }

	public string GetUniqueCapturePath(string path) { }

	public void HideMenuTaskBarTemporarily() { }

	public void InitConsole(Profile profile) { }

	[AsyncStateMachine(typeof(<MakeScreenshot>d__86))]
	public Task MakeScreenshot() { }

	private void OnApplicationFocus(bool hasFocus) { }

	public virtual void OnDestroy() { }

	private void OnDisable() { }

	[AsyncStateMachine(typeof(<OpenNextErrorScreen>d__93))]
	private Task OpenNextErrorScreen() { }

	private void RefreshCornerLabel() { }

	public void ResetTimersForShowRttAndLoss() { }

	public void RestoreMenuTaskBar() { }

	public void set_RaidInfoVisibility(bool value) { }

	public void SetBlackBlackScreen(bool on, float alpha, bool raycast) { }

	public void SetBlackImageAlpha(float alpha) { }

	public void SetCanvasAsParent(GameObject object) { }

	public void SetCommitsNotMatchText(string commitsNotMatchText) { }

	public void SetGameModeText(string sessionMode) { }

	public void SetLoaderStatus(bool status) { }

	public void SetMenuTaskBarVisibility(bool visible) { }

	public void SetNetworkViewSettings(NetworkStateViewSettings clientSettingsNetworkStateView) { }

	public void SetSessionId(string id) { }

	public void SetStreamMode(bool status) { }

	public void SetWatermarkStatus(Profile profile, bool watermarkEnabled) { }

	private void ShowClientWatermark(Profile profile) { }

	public ErrorWindowContext ShowCriticalErrorScreen(string header, string message, EButtonType buttonType, float waitingTime) { }

	public void ShowErrorScreen(string header, Exception exception, Action acceptCallback = null) { }

	public void ShowErrorScreen(string header, string message, Action acceptCallback = null) { }

	public void ShowPveLoadingScreen() { }

	public void ShowRaidStartInfo(long raidNumber, DateTime registrationDate, GameDateTime locationTime, EPlayerSide side, string playerName, string location) { }

	public void StartBlackScreenShow(float to, float step, Action callback, bool raycast = false) { }

	public void StopClientWatermark() { }

	private void TryToShowLoss() { }

	private void TryToShowRtt() { }

	private void Update() { }

	public void UpdateSessionIDAfterLocalMatch() { }

}

