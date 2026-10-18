namespace Vuplex.WebView;

public class StandaloneWebView : BaseWebView, IWebView, IWithAudioStream, IWithAuth, IWithCursorType, IWithDeepLinking, IWithDownloads, IWithFileSelection, IWithIme, IWithKeyDownAndUp, IWithMovablePointer, IWithMutableAudio, IWithNativeJavaScriptDialogs, IWithPdfCreation, IWithPixelDensity, IWithPointerDownAndUp, IWithPopups, IWithSettableUserAgent, IWithTouch
{
	[CompilerGenerated]
	private struct <_initStandalone>d__138 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StandaloneWebView <>4__this; //Field offset: 0x20
		public int width; //Field offset: 0x28
		public int height; //Field offset: 0x2C
		public string popupId; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <_renderPluginOncePerFrame>d__144 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public StandaloneWebView <>4__this; //Field offset: 0x20

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
		public <_renderPluginOncePerFrame>d__144(int <>1__state) { }

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
	private sealed class <>c__DisplayClass135_0
	{
		private struct <<HandlePopup>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass135_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public StandaloneWebView popupWebView; //Field offset: 0x10
		public StandaloneWebView <>4__this; //Field offset: 0x18
		public string popupBrowserId; //Field offset: 0x20
		public string url; //Field offset: 0x28

		public <>c__DisplayClass135_0() { }

		[AsyncStateMachine(typeof(<<HandlePopup>b__0>d))]
		internal void <HandlePopup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass163_0
	{
		public string gameObjectName; //Field offset: 0x10
		public string methodName; //Field offset: 0x18
		public string message; //Field offset: 0x20

		public <>c__DisplayClass163_0() { }

		internal void <_unitySendMessage>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public string resultCallbackId; //Field offset: 0x10
		public StandaloneWebView <>4__this; //Field offset: 0x18
		public StandalonePdfOptions pdfOptions; //Field offset: 0x20

		public <>c__DisplayClass48_0() { }

		internal void <CreatePdf>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>___handleTerminationFinished; //Field offset: 0x0
		public static Action <1>___handleBrowserProcessFailed; //Field offset: 0x8
		public static Action <2>___logInfo; //Field offset: 0x10
		public static Action <3>___logWarning; //Field offset: 0x18
		public static Action <4>___logError; //Field offset: 0x20
		public static Action <5>___unitySendMessage; //Field offset: 0x28
		public static Action <6>___handleAudioPacket; //Field offset: 0x30
		public static Action <7>___handleGetCookiesResult; //Field offset: 0x38
		public static Action <8>___handleModifyCookiesResult; //Field offset: 0x40

	}

	[CompilerGenerated]
	private struct <GetCookie>d__226 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x28
		public string cookieName; //Field offset: 0x30
		public Action callback; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCookie>d__227 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		public string cookieName; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCookies>d__228 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCookie>d__231 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Cookie cookie; //Field offset: 0x28
		public Action callback; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string WEBVIEW_DATA_SUBDIRECTORY_NAME = "Vuplex.WebView"; //Field offset: 0x0
	[CompilerGenerated]
	private static EventHandler BrowserProcessFailed; //Field offset: 0x0
	private static bool _acceleratedPaintEnabled; //Field offset: 0x8
	private static float[][] _audioBuffers; //Field offset: 0x10
	private static Dictionary _pendingGetCookiesResultCallbacks; //Field offset: 0x18
	private static Dictionary _pendingModifyCookiesResultCallbacks; //Field offset: 0x20
	private static TaskCompletionSource _terminationTaskSource; //Field offset: 0x28
	private static Dictionary _webViews; //Field offset: 0x30
	[CompilerGenerated]
	private Action AudioStreamPacketReceived; //Field offset: 0x128
	[CompilerGenerated]
	private EventHandler DownloadProgressChanged; //Field offset: 0x130
	[CompilerGenerated]
	private EventHandler ImeInputFieldPositionChanged; //Field offset: 0x138
	[CompilerGenerated]
	private EventHandler PopupRequested; //Field offset: 0x140
	[CompilerGenerated]
	private bool <AudioStreamEnabled>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private float <PixelDensity>k__BackingField; //Field offset: 0x14C
	[CompilerGenerated]
	private readonly WebPluginType <PluginType>k__BackingField; //Field offset: 0x150
	private EventHandler _authRequestedHandler; //Field offset: 0x158
	private EventHandler _clientCertificateRequestedHandler; //Field offset: 0x160
	[CompilerGenerated]
	private EventHandler _cursorTypeChanged; //Field offset: 0x168
	private EventHandler _fileSelectionHandler; //Field offset: 0x170
	private string _gameObjectName; //Field offset: 0x178
	private Dictionary _pendingCreatePdfTaskSources; //Field offset: 0x180
	private readonly WaitForEndOfFrame _waitForEndOfFrame; //Field offset: 0x188

	private event EventHandler _cursorTypeChanged
	{
		[CompilerGenerated]
		private add { } //Length: 278
		[CompilerGenerated]
		private remove { } //Length: 278
	}

	public override event Action AudioStreamPacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event EventHandler AuthRequested
	{
		 add { } //Length: 313
		 remove { } //Length: 245
	}

	public static event EventHandler BrowserProcessFailed
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	public event EventHandler ClientCertificateRequested
	{
		 add { } //Length: 313
		 remove { } //Length: 245
	}

	public override event EventHandler CursorTypeChanged
	{
		 add { } //Length: 350
		 remove { } //Length: 516
	}

	public override event EventHandler DownloadProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event EventHandler FileSelectionRequested
	{
		 add { } //Length: 313
		 remove { } //Length: 245
	}

	public override event EventHandler ImeInputFieldPositionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event EventHandler PopupRequested
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private static bool _isWindows
	{
		private get { } //Length: 223
	}

	public private override bool AudioStreamEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public static string CachePath
	{
		 get { } //Length: 440
		 set { } //Length: 348
	}

	public private override float PixelDensity
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override WebPluginType PluginType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	private static Task _deleteCookies(string url = null, string cookieName = null) { }

	protected virtual GraphicsDeviceType[] _getSupportedGraphicsApis() { }

	protected virtual TextureFormat _getTextureFormat() { }

	[MonoPInvokeCallback(typeof(System.Action`3<System.String, System.IntPtr, System.Int32>))]
	private static void _handleAudioPacket(string gameObjectName, IntPtr audioFramesPtr, int framesCount) { }

	[MonoPInvokeCallback(typeof(System.Action`1<System.String>))]
	private static void _handleBrowserProcessFailed(string errorMessage) { }

	[MonoPInvokeCallback(typeof(System.Action`2<System.String, System.String>))]
	private static void _handleGetCookiesResult(string resultCallbackId, string serializedCookies) { }

	[MonoPInvokeCallback(typeof(System.Action`2<System.String, System.Boolean>))]
	private static void _handleModifyCookiesResult(string resultCallbackId, bool success) { }

	[MonoPInvokeCallback(typeof(Action))]
	private static void _handleTerminationFinished() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSplashScreen (3))]
	private static void _initializePlugin() { }

	[AsyncStateMachine(typeof(<_initStandalone>d__138))]
	private Task _initStandalone(int width, int height, string popupId) { }

	[MonoPInvokeCallback(typeof(System.Action`1<System.String>))]
	private static void _logError(string message) { }

	[MonoPInvokeCallback(typeof(System.Action`1<System.String>))]
	private static void _logInfo(string message) { }

	[MonoPInvokeCallback(typeof(System.Action`1<System.String>))]
	private static void _logWarning(string message) { }

	private void _pointerDown(Vector2 normalizedPoint, MouseButton mouseButton, int clickCount, bool preventStealingFocus) { }

	private void _pointerUp(Vector2 normalizedPoint, MouseButton mouseButton, int clickCount) { }

	[IteratorStateMachine(typeof(<_renderPluginOncePerFrame>d__144))]
	private IEnumerator _renderPluginOncePerFrame() { }

	protected virtual void _resize() { }

	private static void _throwAlreadyInitializedException(string memberName, bool isProperty = false) { }

	[MonoPInvokeCallback(typeof(System.Action`3<System.String, System.String, System.String>))]
	private static void _unitySendMessage(string gameObjectName, string methodName, string message) { }

	private static StandaloneWebView() { }

	public StandaloneWebView() { }

	[CompilerGenerated]
	private void <HandleAuthRequested>b__126_0(string username, string password) { }

	[CompilerGenerated]
	private void <HandleAuthRequested>b__126_1() { }

	[CompilerGenerated]
	private void <HandleClientCertificateRequested>b__128_0(int requestID, int certificateID) { }

	[CompilerGenerated]
	private void <HandleFileSelectionRequested>b__131_0(string[] filePaths) { }

	[CompilerGenerated]
	private void <HandleFileSelectionRequested>b__131_1() { }

	[CompilerGenerated]
	private void add__cursorTypeChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_AudioStreamPacketReceived(Action value) { }

	public override void add_AuthRequested(EventHandler value) { }

	[CompilerGenerated]
	public static void add_BrowserProcessFailed(EventHandler value) { }

	public void add_ClientCertificateRequested(EventHandler value) { }

	public override void add_CursorTypeChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_DownloadProgressChanged(EventHandler value) { }

	public override void add_FileSelectionRequested(EventHandler value) { }

	[CompilerGenerated]
	public override void add_ImeInputFieldPositionChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_PopupRequested(EventHandler value) { }

	public override void CancelImeComposition() { }

	public virtual Task CanGoBack() { }

	public virtual Task CanGoForward() { }

	public virtual Task CaptureScreenshot() { }

	public static void ClearAllData() { }

	public virtual void Copy() { }

	public Task CreatePdf(StandalonePdfOptions pdfOptions) { }

	public override Task CreatePdf() { }

	public virtual void Cut() { }

	public static Task DeleteAllCookies() { }

	public static Task DeleteCookies(string url, string cookieName = null) { }

	[Obsolete("StandaloneWebView.DispatchTouchEvent() has been renamed to SendTouchEvent(). Please switch to using IWithTouch.SendTouchEvent(): https://developer.vuplex.com/webview/IWithTouch")]
	public void DispatchTouchEvent(TouchEvent touchEvent) { }

	public virtual void Dispose() { }

	public static void EnableRemoteDebugging(int portNumber) { }

	public virtual void ExecuteJavaScript(string javaScript, Action callback) { }

	public override void FinishImeComposition(string text) { }

	private static bool get__isWindows() { }

	[CompilerGenerated]
	public override bool get_AudioStreamEnabled() { }

	public static string get_CachePath() { }

	[CompilerGenerated]
	public override float get_PixelDensity() { }

	[CompilerGenerated]
	public override WebPluginType get_PluginType() { }

	[AsyncStateMachine(typeof(<GetCookie>d__227))]
	[Obsolete("StandaloneWebView.GetCookie() is now deprecated. Please switch to Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
	public static Task GetCookie(string url, string cookieName) { }

	[AsyncStateMachine(typeof(<GetCookie>d__226))]
	[Obsolete("StandaloneWebView.GetCookie() is now deprecated. Please switch to using Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
	public static void GetCookie(string url, string cookieName, Action callback) { }

	[AsyncStateMachine(typeof(<GetCookies>d__228))]
	[Obsolete("StandaloneWebView.GetCookies(url, callback) is now deprecated. Please switch to Web.CookieManager.GetCookies(): https://developer.vuplex.com/webview/CookieManager#GetCookies")]
	public static void GetCookies(string url, Action callback) { }

	public static Task GetCookies(string url, string cookieName = null) { }

	public virtual Task GetRawTextureData() { }

	public static void GloballySetUserAgent(bool mobile) { }

	public static void GloballySetUserAgent(string userAgent) { }

	public virtual void GoBack() { }

	public virtual void GoForward() { }

	private void HandleAuthRequested(string host) { }

	private void HandleClientCertificateRequested(string serializedMessage) { }

	private void HandleCursorTypeChanged(string type) { }

	private void HandleDownloadProgressChanged(string serializedMessage) { }

	private void HandleFileSelectionRequested(string serializedMessage) { }

	private void HandleImeInputFieldPositionChanged(string message) { }

	private void HandlePdfCreated(string message) { }

	private void HandlePopup(string message) { }

	public override Task Init(int width, int height) { }

	public static StandaloneWebView Instantiate() { }

	public override void KeyDown(string key, KeyModifier modifiers) { }

	public override void KeyUp(string key, KeyModifier modifiers) { }

	public virtual void LoadHtml(string html) { }

	public virtual void LoadUrl(string url) { }

	public virtual void LoadUrl(string url, Dictionary additionalHttpHeaders) { }

	public override void MovePointer(Vector2 normalizedPoint, bool pointerLeave = false) { }

	private void OnEnable() { }

	public virtual void Paste() { }

	public override void PointerDown(Vector2 point) { }

	public override void PointerDown(Vector2 point, PointerOptions options) { }

	public override void PointerUp(Vector2 point, PointerOptions options) { }

	public override void PointerUp(Vector2 point) { }

	public void ReloadIgnoreCache() { }

	[CompilerGenerated]
	private void remove__cursorTypeChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_AudioStreamPacketReceived(Action value) { }

	public override void remove_AuthRequested(EventHandler value) { }

	[CompilerGenerated]
	public static void remove_BrowserProcessFailed(EventHandler value) { }

	public void remove_ClientCertificateRequested(EventHandler value) { }

	public override void remove_CursorTypeChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_DownloadProgressChanged(EventHandler value) { }

	public override void remove_FileSelectionRequested(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_ImeInputFieldPositionChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_PopupRequested(EventHandler value) { }

	public void SendDevToolsMessage(string messageJson) { }

	public override void SendTouchEvent(TouchEvent touchEvent) { }

	[CompilerGenerated]
	private void set_AudioStreamEnabled(bool value) { }

	public static void set_CachePath(string value) { }

	[CompilerGenerated]
	private void set_PixelDensity(float value) { }

	public static void SetAcceleratedPaintEnabled(bool enabled) { }

	[Obsolete("StandaloneWebView.SetAudioAndVideoCaptureEnabled() is now deprecated. Please switch to Web.SetCameraAndMicrophoneEnabled(): https://developer.vuplex.com/webview/Web#SetCameraAndMicrophoneEnabled")]
	public static void SetAudioAndVideoCaptureEnabled(bool enabled) { }

	public override void SetAudioMuted(bool muted) { }

	public override void SetAudioStreamEnabled(bool enabled) { }

	public static void SetAutoplayEnabled(bool enabled) { }

	[Obsolete("StandaloneWebView.SetCachePath() is now deprecated. Please switch to setting the StandaloneWebView.CachePath property instead: https://developer.vuplex.com/webview/StandaloneWebView#CachePath")]
	public static void SetCachePath(string absoluteFilePath) { }

	public static void SetCameraAndMicrophoneEnabled(bool enabled) { }

	public static void SetChromiumLogLevel(ChromiumLogLevel level) { }

	public static void SetChromiumLogPath(string absoluteFilePath) { }

	public static void SetCommandLineArguments(string args) { }

	[AsyncStateMachine(typeof(<SetCookie>d__231))]
	[Obsolete("StandaloneWebView.SetCookie(cookie, callback) is now deprecated. Please switch to Web.CookieManager.SetCookie(): https://developer.vuplex.com/webview/CookieManager#SetCookie")]
	public static void SetCookie(Cookie cookie, Action callback) { }

	public static Task SetCookie(Cookie cookie) { }

	public override void SetDeepLinkingEnabled(bool enabled) { }

	public override void SetDownloadsEnabled(bool enabled) { }

	public static void SetIgnoreCertificateErrors(bool ignore) { }

	public override void SetImeComposition(string text) { }

	public void SetNativeFileDialogEnabled(bool enabled) { }

	public override void SetNativeJavaScriptDialogsEnabled(bool enabled) { }

	[Obsolete("StandaloneWebView.SetNativeScriptDialogEnabled() is now deprecated. Please switch to IWithNativeJavaScriptDialogs.SetNativeJavaScriptDialogsEnabled(): https://developer.vuplex.com/webview/IWithNativeJavaScriptDialogs")]
	public void SetNativeScriptDialogEnabled(bool enabled) { }

	public override void SetPixelDensity(float pixelDensity) { }

	public override void SetPopupMode(PopupMode popupMode) { }

	public static void SetScreenSharingEnabled(bool enabled) { }

	public static void SetStorageEnabled(bool enabled) { }

	public static void SetTargetFrameRate(uint targetFrameRate) { }

	public override void SetUserAgent(bool mobile) { }

	public override void SetUserAgent(string userAgent) { }

	public void SetZoomLevel(float zoomLevel) { }

	public static Task TerminateBrowserProcess() { }

	[Obsolete("StandaloneWebView.TerminatePlugin() has been replaced with StandaloneWebView.TerminateBrowserProcess(). Please switch to TerminateBrowserProcess().")]
	public static void TerminatePlugin() { }

	private static bool WebView_browserProcessIsRunning() { }

	private static void WebView_cancelAuth(IntPtr webViewPtr) { }

	private static void WebView_cancelFileSelection(IntPtr webViewPtr) { }

	private static void WebView_cancelImeComposition(IntPtr webViewPtr) { }

	private static void WebView_continueAuth(IntPtr webViewPtr, string username, string password) { }

	private static void WebView_continueFileSelection(IntPtr webViewPtr, string serializedFilePaths) { }

	private static void WebView_copy(IntPtr webViewPtr) { }

	private static void WebView_createPdf(IntPtr webViewPtr, string resultCallbackId, string filePath, string options) { }

	private static void WebView_cut(IntPtr webViewPtr) { }

	private static void WebView_deleteCookies(string url, string cookieName, string resultCallbackId) { }

	private static int WebView_depositPointer(IntPtr pointer) { }

	private static bool WebView_enableRemoteDebugging(int portNumber) { }

	private static void WebView_finishImeComposition(IntPtr webViewPtr, string text) { }

	private static void WebView_getCachePath(byte[] buffer, int bufferSize) { }

	private static void WebView_getCookies(string url, string cookieName, string resultCallbackId) { }

	private static IntPtr WebView_getRenderFunction() { }

	private static void WebView_globallySetUserAgent(string userAgent) { }

	private static void WebView_globallySetUserAgentToMobile(bool mobile) { }

	private static void WebView_initializePlugin(string defaultCachePath, IntPtr terminationFinishedCallback, IntPtr browserProcessFailedCallback, IntPtr logInfoFunction, IntPtr logWarningFunction, IntPtr logErrorFunction, IntPtr unitySendMessageFunction, IntPtr audioPacketCallback, IntPtr getCookiesCallback, IntPtr modifyCookiesCallback) { }

	private static void WebView_keyDown(IntPtr webViewPtr, string key, int modifiers) { }

	private static void WebView_keyUp(IntPtr webViewPtr, string key, int modifiers) { }

	private static void WebView_movePointer(IntPtr webViewPtr, int x, int y, bool pointerLeave) { }

	private static IntPtr WebView_new(string gameObjectName, int width, int height, float pixelDensity, string popupBrowserId) { }

	private static void WebView_paste(IntPtr webViewPtr) { }

	private static void WebView_pointerDown(IntPtr webViewPtr, int x, int y, int mouseButton, int clickCount, bool preventStealingFocus) { }

	private static void WebView_pointerUp(IntPtr webViewPtr, int x, int y, int mouseButton, int clickCount) { }

	private static void WebView_reloadIgnoreCache(IntPtr webViewPtr) { }

	private static void WebView_removePointer(IntPtr pointer) { }

	private static void WebView_resizeWithPixelDensity(IntPtr webViewPtr, int width, int height, float pixelDensity) { }

	private static void WebView_selectAll(IntPtr webViewPtr) { }

	private static void WebView_selectClientCertificate(IntPtr webViewPtr, int requestID, int certificateID) { }

	private static void WebView_sendDevToolsMessage(IntPtr webViewPtr, string messageJson) { }

	private static void WebView_sendTouchEvent(IntPtr webViewPtr, int touchID, int type, float pointX, float pointY, float radiusX, float radiusY, float rotationAngle, float pressure) { }

	private static bool WebView_setAcceleratedPaintEnabled(bool enabled) { }

	private static void WebView_setAudioMuted(IntPtr webViewPtr, bool muted) { }

	private static void WebView_setAudioStreamEnabled(IntPtr webViewPtr, bool enabled, int sampleRate) { }

	private static void WebView_setAuthEnabled(IntPtr webViewPtr, bool enabled) { }

	private static bool WebView_setAutoplayEnabled(bool enabled) { }

	private static bool WebView_setCachePath(string cachePath) { }

	private static void WebView_setCameraAndMicrophoneEnabled(bool enabled) { }

	private static bool WebView_setChromiumLogLevel(int level) { }

	private static bool WebView_setChromiumLogPath(string logPath) { }

	private static void WebView_setClientCertificateSelectionEnabled(IntPtr webViewPtr, bool enabled) { }

	private static bool WebView_setCommandLineArguments(string args) { }

	private static void WebView_setCookie(string serializedCookie, string resultCallbackId) { }

	private static void WebView_setCursorTypeEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setDeepLinkingEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setDownloadsEnabled(IntPtr webViewPtr, string downloadsDirectoryPath) { }

	private static void WebView_setFileSelectionEnabled(IntPtr webViewPtr, bool enabled) { }

	private static bool WebView_setIgnoreCertificateErrors(bool ignore) { }

	private static void WebView_setImeComposition(IntPtr webViewPtr, string text) { }

	private static void WebView_setNativeFileDialogEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setNativeJavaScriptDialogsEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setPopupMode(IntPtr webViewPtr, int popupMode) { }

	private static bool WebView_setScreenSharingEnabled(bool enabled) { }

	private static bool WebView_setStorageEnabled(bool enabled) { }

	private static bool WebView_setTargetFrameRate(uint targetFrameRate) { }

	private static void WebView_setUserAgent(IntPtr webViewPtr, string userAgent) { }

	private static void WebView_setUserAgentToMobile(IntPtr webViewPtr, bool mobile) { }

	private static void WebView_setZoomLevel(IntPtr webViewPtr, float zoomLevel) { }

	private static bool WebView_terminateBrowserProcess() { }

	public virtual void ZoomIn() { }

	public virtual void ZoomOut() { }

}

