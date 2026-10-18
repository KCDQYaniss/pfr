namespace Vuplex.WebView;

[HelpURL("https://developer.vuplex.com/webview/CanvasWebViewPrefab")]
public class CanvasWebViewPrefab : BaseWebViewPrefab
{
	[CompilerGenerated]
	private struct <_initCanvasPrefab>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CanvasWebViewPrefab <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Header("Platform-specific")]
	[HideInInspector]
	[Label("Native 2D Mode (Android, iOS, macOS WebKit, WebGL, & UWP only)")]
	[Tooltip("Native 2D Mode positions a native 2D webview in front of the Unity game view instead of rendering web content as a texture in the Unity scene. Native 2D Mode provides better performance on iOS and UWP, because the default mode of rendering web content to a texture is slower. \n\nImportant notes:\n• Native 2D Mode is only supported for Android (non-Gecko), iOS, macOS WebKit, WebGL, and UWP. For the other 3D WebView packages, the default render mode is used instead.\n• Native 2D Mode requires that the canvas's render mode be set to \"Screen Space - Overlay\".")]
	public bool Native2DModeEnabled; //Field offset: 0xF8
	[Label("Native On-Screen Keyboard (Android, iOS, & visionOS only)")]
	[Tooltip("Determines whether the operating system's native on-screen keyboard is automatically shown when a text input in the webview is focused. The native on-screen keyboard is only supported for the following packages:\n• 3D WebView for Android (non-Gecko)\n• 3D WebView for iOS\n• 3D WebView for visionOS")]
	public bool NativeOnScreenKeyboardEnabled; //Field offset: 0xF9
	[FormerlySerializedAs("InitialResolution")]
	[HideInInspector]
	[Label("Resolution (px / Unity unit)")]
	[Tooltip("You can change this to make web content appear larger or smaller. Note that this property is ignored when running in Native 2D Mode.")]
	public float Resolution; //Field offset: 0xFC
	[HideInInspector]
	[Tooltip("Determines the scroll sensitivity. Note that This property is ignored when running in Native 2D Mode.")]
	public float ScrollingSensitivity; //Field offset: 0x100
	private RectTransform _cachedRectTransform; //Field offset: 0x108
	private CachingGetter _canvasGetter; //Field offset: 0x110
	private bool _native2DModeEnabledAtInitialization; //Field offset: 0x118

	public virtual event EventHandler Clicked
	{
		 add { } //Length: 406
		 remove { } //Length: 262
	}

	public virtual event EventHandler Scrolled
	{
		 add { } //Length: 406
		 remove { } //Length: 262
	}

	private Canvas _canvas
	{
		private get { } //Length: 337
	}

	private bool _native2DModeActive
	{
		private get { } //Length: 100
	}

	private RectTransform _rectTransform
	{
		private get { } //Length: 323
	}

	[Obsolete("CanvasWebViewPrefab.InitialResolution is now deprecated. Please use CanvasWebViewPrefab.Resolution instead.")]
	public float InitialResolution
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public virtual bool Visible
	{
		 get { } //Length: 95
		 set { } //Length: 291
	}

	private bool _canNative2DModeBeEnabled(bool logWarnings = false) { }

	private IWithNative2DMode _getNative2DWebViewIfActive() { }

	protected virtual bool _getNativeOnScreenKeyboardEnabled() { }

	private Rect _getRectForInitialization(bool preferNative2DMode) { }

	protected virtual float _getResolution() { }

	private Rect _getScreenSpaceRect() { }

	private float _getScreenSpaceScaleFactor() { }

	protected virtual float _getScrollingSensitivity() { }

	protected virtual ViewportMaterialView _getView() { }

	[AsyncStateMachine(typeof(<_initCanvasPrefab>d__36))]
	private void _initCanvasPrefab() { }

	private void _logErrorIfNative2DModeEnabledChanged() { }

	private bool _logErrorIfSizeIsInvalid(Vector2 size) { }

	private void _logEventCameraWarningIfNeeded() { }

	private void _logNative2DModeWarning(string message) { }

	private void _logNative2DRecommendationIfNeeded(object sender, EventArgs eventArgs) { }

	private bool _resizeNative2DWebViewIfNeeded() { }

	private bool _sizeIsInvalid(Vector2 size) { }

	public CanvasWebViewPrefab() { }

	public virtual void add_Clicked(EventHandler value) { }

	public virtual void add_Scrolled(EventHandler value) { }

	public virtual Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels) { }

	private Canvas get__canvas() { }

	private bool get__native2DModeActive() { }

	private RectTransform get__rectTransform() { }

	public float get_InitialResolution() { }

	public virtual bool get_Visible() { }

	[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called. Please use CanvasWebViewPrefab.SetWebViewForInitialization(IWebView) instead.", True)]
	public void Init(IWebView webView) { }

	[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init(WebViewOptions options) { }

	[Obsolete("CanvasWebViewPrefab.Init() has been removed. The CanvasWebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init() { }

	public static CanvasWebViewPrefab Instantiate() { }

	public static CanvasWebViewPrefab Instantiate(IWebView webView) { }

	public static CanvasWebViewPrefab Instantiate(WebViewOptions options) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void remove_Clicked(EventHandler value) { }

	public virtual void remove_Scrolled(EventHandler value) { }

	public void set_InitialResolution(float value) { }

	public virtual void set_Visible(bool value) { }

	private void Start() { }

	protected virtual void Update() { }

}

