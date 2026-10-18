namespace Vuplex.WebView;

public interface IWebView
{

	public event EventHandler CloseRequested
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler ConsoleMessageLogged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler FocusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler FocusedInputFieldChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler LoadFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler LoadProgressChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler MessageEmitted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Obsolete("IWebView.PageLoadFailed is now deprecated. Please use IWebView.LoadFailed instead: https://developer.vuplex.com/webview/IWebView#LoadFailed")]
	public event EventHandler PageLoadFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler Terminated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler TitleChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler UrlChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Obsolete("IWebView.VideoRectChanged has been removed. Please use IWithFallbackVideo.VideoRectChanged instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoRectChanged", True)]
	public event EventHandler VideoRectChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool IsDisposed
	{
		 get { } //Length: 0
	}

	public bool IsInitialized
	{
		 get { } //Length: 0
	}

	public List PageLoadScripts
	{
		 get { } //Length: 0
	}

	public WebPluginType PluginType
	{
		 get { } //Length: 0
	}

	[Obsolete("IWebView.Resolution has been removed in v4. Please use WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", True)]
	public float Resolution
	{
		 get { } //Length: 0
	}

	public Vector2Int Size
	{
		 get { } //Length: 0
	}

	[Obsolete("IWebView.SizeInPixels is now deprecated. Please use IWebView.Size instead: https://developer.vuplex.com/webview/IWebView#Size")]
	public Vector2 SizeInPixels
	{
		 get { } //Length: 0
	}

	public Texture2D Texture
	{
		 get { } //Length: 0
	}

	public string Title
	{
		 get { } //Length: 0
	}

	public string Url
	{
		 get { } //Length: 0
	}

	[Obsolete("IWebView.VideoTexture has been removed. Please use IWithFallbackVideo.VideoTexture instead: https://developer.vuplex.com/webview/IWithFallbackVideo#VideoTexture", True)]
	public Texture2D VideoTexture
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_CloseRequested(EventHandler value) { }

	[CompilerGenerated]
	public void add_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public void add_FocusChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void add_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_MessageEmitted(EventHandler value) { }

	[CompilerGenerated]
	public void add_PageLoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void add_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public void add_TitleChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_UrlChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_VideoRectChanged(EventHandler value) { }

	[Obsolete("IWebView.Blur() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", True)]
	public void Blur() { }

	[Obsolete("The callback-based CanGoBack(Action) version of this method has been removed. Please switch to the Task-based CanGoBack() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoBack().ContinueWith(result => {...})", True)]
	public void CanGoBack(Action callback) { }

	public Task CanGoBack() { }

	[Obsolete("The callback-based CanGoForward(Action) version of this method has been removed. Please switch to the Task-based CanGoForward() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CanGoForward().ContinueWith(result => {...})", True)]
	public void CanGoForward(Action callback) { }

	public Task CanGoForward() { }

	[Obsolete("The callback-based CaptureScreenshot(Action) version of this method has been removed. Please switch to the Task-based CaptureScreenshot() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: CaptureScreenshot().ContinueWith(result => {...})", True)]
	public void CaptureScreenshot(Action callback) { }

	public Task CaptureScreenshot() { }

	public void Click(Vector2 normalizedPoint, bool preventStealingFocus = false) { }

	public void Click(int xInPixels, int yInPixels, bool preventStealingFocus = false) { }

	public void Copy() { }

	public Material CreateMaterial() { }

	public void Cut() { }

	[Obsolete("DisableViewUpdates() has been removed. Please use SetRenderingEnabled(false) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public void DisableViewUpdates() { }

	public void Dispose() { }

	[Obsolete("EnableViewUpdates() has been removed. Please use SetRenderingEnabled(true) instead: https://developer.vuplex.com/webview/IWebView#SetRenderingEnabled", True)]
	public void EnableViewUpdates() { }

	public void ExecuteJavaScript(string javaScript, Action callback) { }

	public Task ExecuteJavaScript(string javaScript) { }

	[Obsolete("IWebView.Focus() has been removed. Please use SetFocused(false) instead: https://developer.vuplex.com/webview/IWebView#SetFocused", True)]
	public void Focus() { }

	public bool get_IsDisposed() { }

	public bool get_IsInitialized() { }

	public List get_PageLoadScripts() { }

	public WebPluginType get_PluginType() { }

	public float get_Resolution() { }

	public Vector2Int get_Size() { }

	public Vector2 get_SizeInPixels() { }

	public Texture2D get_Texture() { }

	public string get_Title() { }

	public string get_Url() { }

	public Texture2D get_VideoTexture() { }

	public Task GetRawTextureData() { }

	[Obsolete("The callback-based GetRawTextureData(Action) version of this method has been removed. Please switch to the Task-based GetRawTextureData() version instead. If you prefer using a callback instead of awaiting the Task, you can still use a callback like this: GetRawTextureData().ContinueWith(result => {...})", True)]
	public void GetRawTextureData(Action callback) { }

	public void GoBack() { }

	public void GoForward() { }

	[Obsolete("IWebView.HandleKeyboardInput() has been renamed to IWebView.SendKey(). Please switch to SendKey().")]
	public void HandleKeyboardInput(string key) { }

	[Obsolete("IWebView.Init(Texture2D, float, float, Texture2D) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public void Init(Texture2D texture, float width, float height, Texture2D videoTexture) { }

	[Obsolete("IWebView.Init(Texture2D, float, float) has been removed in v4. Please switch to IWebView.Init(int, int) and await the Task it returns. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#init", True)]
	public void Init(Texture2D texture, float width, float height) { }

	public Task Init(int width, int height) { }

	public void LoadHtml(string html) { }

	public void LoadUrl(string url, Dictionary additionalHttpHeaders) { }

	public void LoadUrl(string url) { }

	public Vector2Int NormalizedToPoint(Vector2 normalizedPoint) { }

	public void Paste() { }

	public Vector2 PointToNormalized(int xInPixels, int yInPixels) { }

	public void PostMessage(string data) { }

	public void Reload() { }

	[CompilerGenerated]
	public void remove_CloseRequested(EventHandler value) { }

	[CompilerGenerated]
	public void remove_ConsoleMessageLogged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_FocusChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_FocusedInputFieldChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_LoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void remove_LoadProgressChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_MessageEmitted(EventHandler value) { }

	[CompilerGenerated]
	public void remove_PageLoadFailed(EventHandler value) { }

	[CompilerGenerated]
	public void remove_Terminated(EventHandler value) { }

	[CompilerGenerated]
	public void remove_TitleChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_UrlChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_VideoRectChanged(EventHandler value) { }

	public void Resize(int width, int height) { }

	public void Scroll(Vector2 normalizedScrollDelta, Vector2 normalizedPoint) { }

	public void Scroll(Vector2 normalizedScrollDelta) { }

	public void Scroll(int scrollDeltaXInPixels, int scrollDeltaYInPixels) { }

	public void SelectAll() { }

	public void SendKey(string key) { }

	public void SetDefaultBackgroundEnabled(bool enabled) { }

	public void SetFocused(bool focused) { }

	public void SetRenderingEnabled(bool enabled) { }

	[Obsolete("IWebView.SetResolution() has been removed in v4. Please set the WebViewPrefab.Resolution or CanvasWebViewPrefab.Resolution property instead. For more details, please see this article: https://support.vuplex.com/articles/v4-changes#resolution", True)]
	public void SetResolution(float pixelsPerUnityUnit) { }

	public void StopLoad() { }

	public Task WaitForNextPageLoadToFinish() { }

	public void ZoomIn() { }

	public void ZoomOut() { }

}

