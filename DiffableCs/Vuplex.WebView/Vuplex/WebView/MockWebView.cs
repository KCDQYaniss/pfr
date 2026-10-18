namespace Vuplex.WebView;

internal class MockWebView : MonoBehaviour, IWebView
{
	[CompilerGenerated]
	private EventHandler CloseRequested; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler ConsoleMessageLogged; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler FocusChanged; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler FocusedInputFieldChanged; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler LoadFailed; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler LoadProgressChanged; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler MessageEmitted; //Field offset: 0x50
	[CompilerGenerated]
	private EventHandler Terminated; //Field offset: 0x58
	[CompilerGenerated]
	private EventHandler TitleChanged; //Field offset: 0x60
	[CompilerGenerated]
	private EventHandler UrlChanged; //Field offset: 0x68
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x71
	[CompilerGenerated]
	private readonly List <PageLoadScripts>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly WebPluginType <PluginType>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Vector2Int <Size>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private Texture2D <Texture>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private string <Url>k__BackingField; //Field offset: 0xA0
	private Rect _moreDetailsClickRect; //Field offset: 0xA8
	private TaskCompletionSource _pageLoadFinishedTaskSource; //Field offset: 0xB8
	[CompilerGenerated]
	private EventHandler PageLoadFailed; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly float <Resolution>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private EventHandler VideoRectChanged; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly Texture2D <VideoTexture>k__BackingField; //Field offset: 0xD8

	public override event EventHandler CloseRequested
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event EventHandler ConsoleMessageLogged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
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
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
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
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
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

	public private override bool IsDisposed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override List PageLoadScripts
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override WebPluginType PluginType
	{
		[CompilerGenerated]
		 get { } //Length: 7
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
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
	public override Vector2 SizeInPixels
	{
		 get { } //Length: 34
	}

	public private override Texture2D Texture
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
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

	private void _assertValidNormalizedPoint(Vector2 normalizedPoint) { }

	private void _handlePageLoad(string url) { }

	private static void _log(string message) { }

	private string _truncateIfNeeded(string str) { }

	public MockWebView() { }

	[CompilerGenerated]
	public override void add_CloseRequested(EventHandler value) { }

	[CompilerGenerated]
	public override void add_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_FocusChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void add_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void add_MessageEmitted(EventHandler value) { }

	[CompilerGenerated]
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

	[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", True)]
	public override void CanGoBack(Action callback) { }

	public override Task CanGoBack() { }

	public override Task CanGoForward() { }

	[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", True)]
	public override void CanGoForward(Action callback) { }

	[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", True)]
	public override void CaptureScreenshot(Action callback) { }

	public override Task CaptureScreenshot() { }

	public override void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false) { }

	public override void Click(Vector2 point, bool preventStealingFocus = false) { }

	public override void Copy() { }

	public override Material CreateMaterial() { }

	public override void Cut() { }

	public static Task DeleteCookies(string url, string cookieName = null) { }

	[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public override void DisableViewUpdates() { }

	public override void Dispose() { }

	[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public override void EnableViewUpdates() { }

	public override Task ExecuteJavaScript(string javaScript) { }

	public override void ExecuteJavaScript(string javaScript, Action callback) { }

	[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", True)]
	public override void Focus() { }

	[CompilerGenerated]
	public override bool get_IsDisposed() { }

	[CompilerGenerated]
	public override bool get_IsInitialized() { }

	[CompilerGenerated]
	public override List get_PageLoadScripts() { }

	[CompilerGenerated]
	public override WebPluginType get_PluginType() { }

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

	public static Task GetCookies(string url, string cookieName = null) { }

	public override Task GetRawTextureData() { }

	[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", True)]
	public override void GetRawTextureData(Action callback) { }

	public override void GoBack() { }

	public override void GoForward() { }

	[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
	public override void HandleKeyboardInput(string key) { }

	[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public override void Init(Texture2D texture, float width, float height, Texture2D videoTexture) { }

	[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public override void Init(Texture2D texture, float width, float height) { }

	public override Task Init(int width, int height) { }

	public static MockWebView Instantiate() { }

	public override void LoadHtml(string html) { }

	public override void LoadUrl(string url) { }

	public override void LoadUrl(string url, Dictionary additionalHttpHeaders) { }

	public override Vector2Int NormalizedToPoint(Vector2 normalizedPoint) { }

	public override void Paste() { }

	public override Vector2 PointToNormalized(int xInPixels, int yInPixels) { }

	public override void PostMessage(string data) { }

	public override void Reload() { }

	[CompilerGenerated]
	public override void remove_CloseRequested(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_FocusChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_MessageEmitted(EventHandler value) { }

	[CompilerGenerated]
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

	public override void Scroll(int scrollDeltaX, int scrollDeltaY) { }

	public override void Scroll(Vector2 delta, Vector2 point) { }

	public override void Scroll(Vector2 delta) { }

	public override void SelectAll() { }

	public override void SendKey(string input) { }

	[CompilerGenerated]
	private void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	[CompilerGenerated]
	private void set_Size(Vector2Int value) { }

	[CompilerGenerated]
	private void set_Texture(Texture2D value) { }

	[CompilerGenerated]
	private void set_Title(string value) { }

	[CompilerGenerated]
	private void set_Url(string value) { }

	public static Task SetCookie(Cookie cookie) { }

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

