namespace EFT.UI.Browser;

public class WebViewWrapper : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CanGoBack>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebViewWrapper <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CanGoForward>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebViewWrapper <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnsureInitializedAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebViewWrapper <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeInternalAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WebViewWrapper <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int REFERENCE_RESOLUTION_WIDTH = 1920; //Field offset: 0x0
	private const int REFERENCE_RESOLUTION_HEIGHT = 1080; //Field offset: 0x0
	private const float MAX_PIXEL_DENSITY = 2; //Field offset: 0x0
	[SerializeField]
	private CanvasWebViewPrefab _vuplexWebViewPrefab; //Field offset: 0x20
	private bool _initRequested; //Field offset: 0x28
	private bool _eventsSubscribed; //Field offset: 0x29
	private bool _resolutionHandlerSubscribed; //Field offset: 0x2A
	private Task _initializationTask; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler UrlChanged; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler LoadProgressChanged; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler MessageReceived; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler LoadFailed; //Field offset: 0x50
	[CompilerGenerated]
	private EventHandler Terminated; //Field offset: 0x58
	[CompilerGenerated]
	private Action NavigationStateChanged; //Field offset: 0x60

	public event EventHandler LoadFailed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler LoadProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler MessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action NavigationStateChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler Terminated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler UrlChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsInitialized
	{
		 get { } //Length: 44
	}

	public IWebView WebView
	{
		 get { } //Length: 19
	}

	public WebViewWrapper() { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_0(object s, UrlChangedEventArgs e) { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_1(object s, ProgressChangedEventArgs e) { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_2(object s, EventArgs e) { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_3(object s, LoadFailedEventArgs e) { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_4(object s, TerminatedEventArgs e) { }

	[CompilerGenerated]
	private void <SubscribeEvents>b__44_5(object s, ClickedEventArgs e) { }

	[CompilerGenerated]
	public void add_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void add_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_MessageReceived(EventHandler value) { }

	[CompilerGenerated]
	public void add_NavigationStateChanged(Action value) { }

	[CompilerGenerated]
	public void add_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public void add_UrlChanged(EventHandler value) { }

	private void ApplyPixelDensity() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<CanGoBack>d__36))]
	public Task CanGoBack() { }

	[AsyncStateMachine(typeof(<CanGoForward>d__37))]
	public Task CanGoForward() { }

	private float ComputePixelDensity() { }

	[AsyncStateMachine(typeof(<EnsureInitializedAsync>d__33))]
	public Task EnsureInitializedAsync() { }

	public bool get_IsInitialized() { }

	public IWebView get_WebView() { }

	public void GoBack() { }

	public void GoForward() { }

	[AsyncStateMachine(typeof(<InitializeInternalAsync>d__34))]
	private Task InitializeInternalAsync() { }

	public void LoadUrl(string url) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnResolutionChangedHandler() { }

	public void PostMessage(string data) { }

	public void Reload() { }

	[CompilerGenerated]
	public void remove_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void remove_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_MessageReceived(EventHandler value) { }

	[CompilerGenerated]
	public void remove_NavigationStateChanged(Action value) { }

	[CompilerGenerated]
	public void remove_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public void remove_UrlChanged(EventHandler value) { }

	public void SetFocused(bool focused) { }

	public void SetVisible(bool visible) { }

	private void SubscribeEvents() { }

	private void SubscribeResolutionHandler() { }

	private void UnsubscribeEvents() { }

	private void UnsubscribeResolutionHandler() { }

}

