namespace EFT.UI.Browser;

public sealed class BrowserWindow : UIScreen, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public bool started; //Field offset: 0x10
		public bool loadSucceeded; //Field offset: 0x11
		public bool loadFailed; //Field offset: 0x12
		public TaskCompletionSource loadTcs; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <InitializeAndNavigateAsync>b__0(object s, ProgressChangedEventArgs e) { }

		internal void <InitializeAndNavigateAsync>b__1(object s, LoadFailedEventArgs e) { }

	}

	[CompilerGenerated]
	private struct <InitializeAndNavigateAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string rawUrl; //Field offset: 0x20
		public BrowserWindow <>4__this; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		private <>c__DisplayClass32_0 <>8__1; //Field offset: 0x38
		private string <url>5__2; //Field offset: 0x40
		private EventHandler <progressHandler>5__3; //Field offset: 0x48
		private EventHandler <loadFailedHandler>5__4; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshNavigationButtonsAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BrowserWindow <>4__this; //Field offset: 0x20
		private bool <canGoBack>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string HomeUrl = "about:blank"; //Field offset: 0x0
	[SerializeField]
	private BrowserUI _ui; //Field offset: 0x90
	[SerializeField]
	private WebViewWrapper _webView; //Field offset: 0x98
	[SerializeField]
	private BrowserSoundHandler _soundHandler; //Field offset: 0xA0
	private IBrowserLogic _logic; //Field offset: 0xA8
	private readonly BrowserEventDispatcher _logicDispatcher; //Field offset: 0xB0
	private readonly BrowserEventDispatcher _soundDispatcher; //Field offset: 0xB8
	private CancellationTokenSource _cts; //Field offset: 0xC0
	[CompilerGenerated]
	private string <InitialUrl>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <NavigationEnabled>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private IEftSession <Session>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private EBrowserType <BrowserType>k__BackingField; //Field offset: 0xE0
	private Action _unsubscribeNotificationReceived; //Field offset: 0xE8

	public private EBrowserType BrowserType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private string InitialUrl
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool NavigationEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private IEftSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BrowserWindow() { }

	[CompilerGenerated]
	private void <EnsureNotificationSubscription>b__44_0() { }

	[CompilerGenerated]
	private void <Show>b__26_0() { }

	[CompilerGenerated]
	private void <Show>b__26_1() { }

	[CompilerGenerated]
	private void <Show>b__26_2() { }

	private void Awake() { }

	public virtual void Close() { }

	private static IBrowserLogic CreateLogic(EBrowserType type) { }

	private void EnsureNotificationSubscription() { }

	private void FocusWebView() { }

	[CompilerGenerated]
	public EBrowserType get_BrowserType() { }

	[CompilerGenerated]
	public string get_InitialUrl() { }

	[CompilerGenerated]
	public bool get_NavigationEnabled() { }

	[CompilerGenerated]
	public IEftSession get_Session() { }

	private void HandleLogicEvent(EBrowserEventType type, JObject obj) { }

	[AsyncStateMachine(typeof(<InitializeAndNavigateAsync>d__32))]
	private Task InitializeAndNavigateAsync(string rawUrl, CancellationToken ct) { }

	public void NavigateToUrl(string rawUrl) { }

	private void NotificationReceivedHandler(Notification notification) { }

	private void OnAddressSubmitted(string address) { }

	private void OnLoadFailed(object sender, LoadFailedEventArgs e) { }

	private void OnMessageReceived(object sender, EventArgs e) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void OnSoundEventReceived(EBrowserSoundEventType type, JObject obj) { }

	private void OnTerminated(object sender, TerminatedEventArgs e) { }

	private void OnUrlChanged(object sender, UrlChangedEventArgs e) { }

	public void PostMessage(string data) { }

	private void PostSoundPreviewFinished(string soundId) { }

	[AsyncStateMachine(typeof(<RefreshNavigationButtonsAsync>d__37))]
	private Task RefreshNavigationButtonsAsync() { }

	[CompilerGenerated]
	private void set_BrowserType(EBrowserType value) { }

	[CompilerGenerated]
	private void set_InitialUrl(string value) { }

	[CompilerGenerated]
	private void set_NavigationEnabled(bool value) { }

	[CompilerGenerated]
	private void set_Session(IEftSession value) { }

	public void SetPlaceholderVisible(bool visible, bool soft = false) { }

	public void Show(string initialUrl = null, bool navigationEnabled = false, IEftSession session = null, EBrowserType browserType = 0) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UnsubscribeNotifications() { }

	private void UpdateNavigationUI() { }

}

