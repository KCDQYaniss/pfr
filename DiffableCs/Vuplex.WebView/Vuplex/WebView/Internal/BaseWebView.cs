namespace Vuplex.WebView.Internal;

public abstract class BaseWebView : MonoBehaviour
{
	[CompilerGenerated]
	private struct <_initBase>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseWebView <>4__this; //Field offset: 0x20
		public int width; //Field offset: 0x28
		public int height; //Field offset: 0x2C
		public bool createTexture; //Field offset: 0x30
		public bool asyncInit; //Field offset: 0x31
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static LowMemoryCallback <>9__150_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <_staticInit>b__150_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass143_0
	{
		public string url; //Field offset: 0x10

		public <>c__DisplayClass143_0() { }

		internal bool <HandleUrlChanged>b__0(string scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass146_0
	{
		public OrderedDictionary info; //Field offset: 0x10

		public <>c__DisplayClass146_0() { }

		internal string <_logSystemInfoIfNeeded>b__0(string key) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_0
	{
		public EventHandler value; //Field offset: 0x10

		public <>c__DisplayClass166_0() { }

		internal void <add_PageLoadFailed>b__0(object sender, LoadFailedEventArgs eventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Dictionary additionalHttpHeaders; //Field offset: 0x10

		public <>c__DisplayClass71_0() { }

		internal string <LoadUrl>b__0(string key) { }

	}

	internal enum InitState
	{
		Uninitialized = 0,
		InProgress = 1,
		Initialized = 2,
	}

	private static readonly string[] STANDARD_URI_SCHEMES; //Field offset: 0x0
	protected const string _dllName = "VuplexWebViewWindows"; //Field offset: 0x0
	private static readonly Regex _streamingAssetsUrlRegex; //Field offset: 0x8
	[CompilerGenerated]
	private EventHandler CloseRequested; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler FocusChanged; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler LoadFailed; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler LoadProgressChanged; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler MessageEmitted; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler Terminated; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler TitleChanged; //Field offset: 0x50
	[CompilerGenerated]
	private EventHandler UrlChanged; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly List <PageLoadScripts>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Vector2Int <Size>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Texture2D <Texture>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private string <Url>k__BackingField; //Field offset: 0x88
	private EventHandler _consoleMessageLogged; //Field offset: 0x90
	protected IntPtr _currentNativeTexture; //Field offset: 0x98
	private EventHandler _focusedInputFieldChanged; //Field offset: 0xA0
	protected InitState _initState; //Field offset: 0xA8
	private TaskCompletionSource _initTaskSource; //Field offset: 0xB0
	private Material _materialForBlitting; //Field offset: 0xB8
	protected bool _native2DModeEnabled; //Field offset: 0xC0
	protected Vector2Int _native2DPosition; //Field offset: 0xC4
	protected IntPtr _nativeWebViewPtr; //Field offset: 0xD0
	protected INativeWebViewPlugin _nativePlugin; //Field offset: 0xD8
	private TaskCompletionSource _pageLoadFinishedTaskSource; //Field offset: 0xE0
	private List _pendingCanGoBackCallbacks; //Field offset: 0xE8
	private List _pendingCanGoForwardCallbacks; //Field offset: 0xF0
	protected Dictionary _pendingJavaScriptResultCallbacks; //Field offset: 0xF8
	protected bool _renderingEnabled; //Field offset: 0x100
	protected bool _visible; //Field offset: 0x101
	private Dictionary _legacyPageLoadFailedHandlerMap; //Field offset: 0x108
	[CompilerGenerated]
	private readonly float <Resolution>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private EventHandler VideoRectChanged; //Field offset: 0x118
	[CompilerGenerated]
	private readonly Texture2D <VideoTexture>k__BackingField; //Field offset: 0x120

	public override event EventHandler CloseRequested
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event EventHandler ConsoleMessageLogged
	{
		 add { } //Length: 374
		 remove { } //Length: 337
	}

	public override event EventHandler FocusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler FocusedInputFieldChanged
	{
		 add { } //Length: 374
		 remove { } //Length: 337
	}

	public override event EventHandler LoadFailed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler LoadProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler MessageEmitted
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	[Obsolete("IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed")]
	public override event EventHandler PageLoadFailed
	{
		 add { } //Length: 578
		 remove { } //Length: 741
	}

	public override event EventHandler Terminated
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler TitleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler UrlChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	[Obsolete("IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged", True)]
	public override event EventHandler VideoRectChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected override int _abnormallyLargeThreshold
	{
		 get { } //Length: 6
	}

	protected Rect _rect
	{
		 get { } //Length: 70
		 set { } //Length: 59
	}

	public override bool IsDisposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool IsInitialized
	{
		 get { } //Length: 11
	}

	public override List PageLoadScripts
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Obsolete("IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", True)]
	public override float Resolution
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public private override Vector2Int Size
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
	public override Vector2 SizeInPixels
	{
		 get { } //Length: 31
	}

	public override Texture2D Texture
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override string Title
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override string Url
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Obsolete("IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture", True)]
	public override Texture2D VideoTexture
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected void _assertNative2DModeEnabled() { }

	protected void _assertPointIsWithinBounds(int xInPixels, int yInPixels) { }

	protected void _assertSingletonEventHandlerUnset(object handler, string eventName) { }

	private void _assertSupportedGraphicsApi() { }

	private void _assertValidSize(int width, int height) { }

	protected void _assertValidState() { }

	protected override Material _createMaterial() { }

	protected override Task _createTexture(int width, int height) { }

	private Texture2D _getReadableTexture() { }

	private static string _getRenderPipelineName() { }

	protected override GraphicsDeviceType[] _getSupportedGraphicsApis() { }

	protected override TextureFormat _getTextureFormat() { }

	private void _handleJavaScriptResult(string resultCallbackID, string result) { }

	[AsyncStateMachine(typeof(<_initBase>d__144))]
	protected Task _initBase(int width, int height, bool createTexture = true, bool asyncInit = false) { }

	protected Task _initInNative2DModeBase(Rect rect, bool asyncInit = false) { }

	private static void _logSystemInfoIfNeeded() { }

	protected Vector2Int _normalizedToPointAssertValid(Vector2 normalizedPoint) { }

	protected ConsoleMessageLevel _parseConsoleMessageLevel(string levelString) { }

	protected override void _resize() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void _staticInit() { }

	protected string _transformUrlIfNeeded(string originalUrl) { }

	private void _warnIfAbnormallyLarge(int width, int height) { }

	private static BaseWebView() { }

	protected BaseWebView() { }

	[CompilerGenerated]
	public override void add_CloseRequested(EventHandler value) { }

	public override void add_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_FocusChanged(EventHandler value) { }

	public override void add_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void add_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_MessageEmitted(EventHandler value) { }

	public override void add_PageLoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void add_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public override void add_TitleChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_UrlChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_VideoRectChanged(EventHandler value) { }

	[Obsolete("IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", True)]
	public override void Blur() { }

	public override Task CanGoBack() { }

	[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", True)]
	public override void CanGoBack(Action callback) { }

	[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", True)]
	public override void CanGoForward(Action callback) { }

	public override Task CanGoForward() { }

	[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", True)]
	public override void CaptureScreenshot(Action callback) { }

	public override Task CaptureScreenshot() { }

	public override void Click(Vector2 normalizedPoint, bool preventStealingFocus = false) { }

	public override void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false) { }

	public override void Copy() { }

	public override Material CreateMaterial() { }

	public override void Cut() { }

	[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public override void DisableViewUpdates() { }

	public override void Dispose() { }

	[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public override void EnableViewUpdates() { }

	public override Task ExecuteJavaScript(string javaScript) { }

	public override void ExecuteJavaScript(string javaScript, Action callback) { }

	[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", True)]
	public override void Focus() { }

	protected override int get__abnormallyLargeThreshold() { }

	protected Rect get__rect() { }

	[CompilerGenerated]
	public override bool get_IsDisposed() { }

	public override bool get_IsInitialized() { }

	[CompilerGenerated]
	public override List get_PageLoadScripts() { }

	[CompilerGenerated]
	public override float get_Resolution() { }

	[CompilerGenerated]
	public override Vector2Int get_Size() { }

	public override Vector2 get_SizeInPixels() { }

	[CompilerGenerated]
	public override Texture2D get_Texture() { }

	[CompilerGenerated]
	public override string get_Title() { }

	[CompilerGenerated]
	public override string get_Url() { }

	[CompilerGenerated]
	public override Texture2D get_VideoTexture() { }

	[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", True)]
	public override void GetRawTextureData(Action callback) { }

	public override Task GetRawTextureData() { }

	public override void GoBack() { }

	public override void GoForward() { }

	private void HandleCanGoBackResult(string message) { }

	private void HandleCanGoForwardResult(string message) { }

	private void HandleCloseRequested(string message) { }

	private void HandleFocusedInputFieldChanged(string typeString) { }

	protected void HandleInitFinished(string _) { }

	private void HandleJavaScriptResult(string message) { }

	[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
	public override void HandleKeyboardInput(string key) { }

	private void HandleLoadFailed(string message) { }

	private void HandleLoadFinished(string _) { }

	private void HandleLoadProgressUpdate(string progressString) { }

	private void HandleLoadStarted(string _) { }

	protected override void HandleMessageEmitted(string serializedMessage) { }

	private void HandleTerminated(string typeString) { }

	protected override void HandleTextureChanged(string message) { }

	private void HandleTitleChanged(string title) { }

	private void HandleUrlChanged(string url) { }

	[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public override void Init(Texture2D texture, float width, float height, Texture2D videoTexture) { }

	[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public override void Init(Texture2D texture, float width, float height) { }

	public override void LoadHtml(string html) { }

	public override void LoadUrl(string url, Dictionary additionalHttpHeaders) { }

	public override void LoadUrl(string url) { }

	public override Vector2Int NormalizedToPoint(Vector2 normalizedPoint) { }

	protected override void OnLoadProgressChanged(ProgressChangedEventArgs eventArgs) { }

	public override void Paste() { }

	public override Vector2 PointToNormalized(int xInPixels, int yInPixels) { }

	public override void PostMessage(string message) { }

	public override void Reload() { }

	[CompilerGenerated]
	public override void remove_CloseRequested(EventHandler value) { }

	public override void remove_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_FocusChanged(EventHandler value) { }

	public override void remove_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_MessageEmitted(EventHandler value) { }

	public override void remove_PageLoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_TitleChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_UrlChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_VideoRectChanged(EventHandler value) { }

	public override void Resize(int width, int height) { }

	public override void Scroll(int scrollDeltaXInPixels, int scrollDeltaYInPixels) { }

	public override void Scroll(Vector2 normalizedScrollDelta, Vector2 normalizedPoint) { }

	public override void Scroll(Vector2 normalizedScrollDelta) { }

	public override void SelectAll() { }

	public override void SendKey(string key) { }

	protected void set__rect(Rect value) { }

	[CompilerGenerated]
	protected void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	private void set_Size(Vector2Int value) { }

	[CompilerGenerated]
	protected void set_Texture(Texture2D value) { }

	[CompilerGenerated]
	private void set_Title(string value) { }

	[CompilerGenerated]
	private void set_Url(string value) { }

	public override void SetDefaultBackgroundEnabled(bool enabled) { }

	public override void SetFocused(bool focused) { }

	public override void SetRenderingEnabled(bool enabled) { }

	[Obsolete("IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", True)]
	public override void SetResolution(float pixelsPerUnityUnit) { }

	public override void StopLoad() { }

	public override Task WaitForNextPageLoadToFinish() { }

	public override void ZoomIn() { }

	public override void ZoomOut() { }

}

