namespace Vuplex.WebView;

public abstract class BaseWebViewPrefab : MonoBehaviour
{
	[CompilerGenerated]
	private struct <_initBase>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseWebViewPrefab <>4__this; //Field offset: 0x20
		public Rect rect; //Field offset: 0x28
		public bool preferNative2DMode; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_initWebView>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseWebViewPrefab <>4__this; //Field offset: 0x20
		public bool preferNative2DMode; //Field offset: 0x28
		public Rect rect; //Field offset: 0x2C
		private IWebView <webView>5__2; //Field offset: 0x40
		private IWithNative2DMode <native2DWebView>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal void <WaitUntilInitialized>b__0(object sender, EventArgs e) { }

	}

	private static bool _loggedHoverWarning; //Field offset: 0x0
	private static bool _remoteDebuggingEnabled; //Field offset: 0x1
	[CompilerGenerated]
	private EventHandler Clicked; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler Initialized; //Field offset: 0x28
	[CompilerGenerated]
	private EventHandler PointerEntered; //Field offset: 0x30
	[CompilerGenerated]
	private EventHandler PointerExited; //Field offset: 0x38
	[CompilerGenerated]
	private EventHandler Scrolled; //Field offset: 0x40
	[Label("Output Audio as AudioSource (Windows & macOS only)")]
	[Tooltip("(Windows and macOS only) Sets whether the webview's audio is played through Unity as an AudioSource. This is disabled by default, in which case audio is output directly to the system instead of being routed through Unity because that is more efficient. When enabled, the webview's audio is routed through Unity and played through an AudioSource attached to the prefab, which is accessible to scripts via the WebViewPrefab.AudioSource property.")]
	public bool AudioSourceEnabled; //Field offset: 0x48
	public bool ClickingEnabled; //Field offset: 0x49
	[Label("Cursor Icons Enabled (Windows & macOS only)")]
	[Tooltip("(Windows and macOS only) Sets whether the mouse cursor icon is automatically updated based on interaction with the web page. For example, hovering over a link causes the mouse cursor icon to turn into a pointer hand.")]
	public bool CursorIconsEnabled; //Field offset: 0x4A
	[Tooltip("Determines how the prefab handles drag interactions. Note that This property is ignored when running in Native 2D Mode.")]
	public DragMode DragMode; //Field offset: 0x4C
	[Label("Drag Threshold (px)")]
	[Tooltip("Determines the threshold (in web pixels) for triggering a drag.")]
	public float DragThreshold; //Field offset: 0x50
	public bool HoveringEnabled; //Field offset: 0x54
	[HideInInspector]
	[Label("Initial URL (optional)")]
	[Tooltip("You can set this to the URL that you want to load, or you can leave it blank if you'd rather add a script to load content programmatically with IWebView.LoadUrl() or LoadHtml().")]
	public string InitialUrl; //Field offset: 0x58
	[Tooltip("Determines whether the webview automatically receives keyboard input from the native keyboard and the Keyboard prefab. Note that this property is ignored when running in Native 2D Mode.")]
	public bool KeyboardEnabled; //Field offset: 0x60
	[Tooltip("Determines whether JavaScript console messages are printed to the Unity logs.")]
	public bool LogConsoleMessages; //Field offset: 0x61
	[Label("Pixel Density (Windows, macOS, iOS, & visionOS only)")]
	[Tooltip("(Windows, macOS, iOS, and visionOS only) Sets the webview's pixel density. Note that this property is ignored when running in Native 2D Mode.")]
	public float PixelDensity; //Field offset: 0x64
	[Header("Debugging")]
	[Tooltip("Determines whether remote debugging is enabled.")]
	public bool RemoteDebuggingEnabled; //Field offset: 0x68
	public bool ScrollingEnabled; //Field offset: 0x69
	private float _appliedResolution; //Field offset: 0x6C
	[HideInInspector]
	[SerializeField]
	private ViewportMaterialView _cachedView; //Field offset: 0x70
	private IWebView _cachedWebView; //Field offset: 0x78
	private bool _consoleMessageLoggedHandlerAttached; //Field offset: 0x80
	private bool _dragThresholdReached; //Field offset: 0x81
	private bool _dragToScrollClickIsPending; //Field offset: 0x82
	private bool _hasOverriddenCursorIcon; //Field offset: 0x83
	private bool _keyboardHasBeenEnabled; //Field offset: 0x84
	private bool _loggedDragWarning; //Field offset: 0x85
	protected WebViewOptions _options; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	private MonoBehaviour _pointerInputDetectorMonoBehaviour; //Field offset: 0x98
	private bool _pointerIsDown; //Field offset: 0xA0
	private Vector2 _pointerDownNormalizedPoint; //Field offset: 0xA4
	private Vector2 _previousNormalizedDragPoint; //Field offset: 0xAC
	private Vector2 _previousMovePointerPoint; //Field offset: 0xB4
	protected Vector2 _sizeInUnityUnits; //Field offset: 0xBC
	private Material _viewMaterial; //Field offset: 0xC8
	private bool _visible; //Field offset: 0xD0
	private WebAudioSource _webAudioSource; //Field offset: 0xD8
	protected IWebView _webViewForInitialization; //Field offset: 0xE0
	[HideInInspector]
	[SerializeField]
	private GameObject _webViewGameObject; //Field offset: 0xE8
	[CompilerGenerated]
	private float <DragToScrollThreshold>k__BackingField; //Field offset: 0xF0

	public override event EventHandler Clicked
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler Initialized
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler PointerEntered
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler PointerExited
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event EventHandler Scrolled
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private int _heightInPixels
	{
		private get { } //Length: 18
	}

	private IPointerInputDetector _pointerInputDetector
	{
		private get { } //Length: 66
		private set { } //Length: 441
	}

	protected ViewportMaterialView _view
	{
		 get { } //Length: 304
	}

	private int _widthInPixels
	{
		private get { } //Length: 18
	}

	public AudioSource AudioSource
	{
		 get { } //Length: 239
	}

	[Obsolete("The WebViewPrefab.DragToScrollThreshold property has been removed. Please use DragThreshold instead: https://developer.vuplex.com/webview/WebViewPrefab#DragThreshold", True)]
	public float DragToScrollThreshold
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public Material Material
	{
		 get { } //Length: 48
		 set { } //Length: 57
	}

	public override bool Visible
	{
		 get { } //Length: 8
		 set { } //Length: 190
	}

	public private IWebView WebView
	{
		 get { } //Length: 354
		private set { } //Length: 616
	}

	private void _attachOrDetachPointerInputDetector(IPointerInputDetector detector, bool attach) { }

	private void _attachWebViewEventHandlers(IWebView webView) { }

	private void _disableHoveringIfNeeded(bool preferNative2DMode) { }

	private void _enableConsoleMessagesIfNeeded(IWebView webView) { }

	private void _enableNativeOnScreenKeyboardIfNeeded(IWebView webView) { }

	private void _enableOrDisableAudioSourceIfNeeded(IWithAudioStream webViewWithAudioStream) { }

	private void _enableOrDisableKeyboardIfNeeded() { }

	private void _enableRemoteDebuggingIfNeeded() { }

	protected abstract bool _getNativeOnScreenKeyboardEnabled() { }

	protected abstract float _getResolution() { }

	protected abstract float _getScrollingSensitivity() { }

	private IWithTouch _getTouchIfSupported() { }

	protected abstract ViewportMaterialView _getView() { }

	private void _handleTrialExpired() { }

	[AsyncStateMachine(typeof(<_initBase>d__91))]
	protected Task _initBase(Rect rect, bool preferNative2DMode = false) { }

	private void _initPointerInputDetector(IWebView webView) { }

	private void _initViews(IWebView webView) { }

	[AsyncStateMachine(typeof(<_initWebView>d__93))]
	private Task _initWebView(Rect rect, bool preferNative2DMode) { }

	private void _movePointerIfNeeded(Vector2 point, bool pointerLeave = false) { }

	private bool _native2DModeEnabled(IWebView webView) { }

	protected void _resizeWebViewIfNeeded() { }

	private void _scrollIfNeeded(Vector2 scrollDelta, Vector2 point) { }

	private void _throwExceptionIfInitialized() { }

	private void _updatePixelDensityIfNeeded(IWebView webView) { }

	private void _updateResolutionIfNeeded() { }

	protected BaseWebViewPrefab() { }

	[CompilerGenerated]
	private void <_initWebView>b__93_0(object sender, EventArgs eventArgs) { }

	[CompilerGenerated]
	public override void add_Clicked(EventHandler value) { }

	[CompilerGenerated]
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	public void add_PointerEntered(EventHandler value) { }

	[CompilerGenerated]
	public void add_PointerExited(EventHandler value) { }

	[CompilerGenerated]
	public override void add_Scrolled(EventHandler value) { }

	public abstract Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels) { }

	public void Destroy() { }

	private int get__heightInPixels() { }

	private IPointerInputDetector get__pointerInputDetector() { }

	protected ViewportMaterialView get__view() { }

	private int get__widthInPixels() { }

	public AudioSource get_AudioSource() { }

	[CompilerGenerated]
	public float get_DragToScrollThreshold() { }

	public Material get_Material() { }

	public override bool get_Visible() { }

	public IWebView get_WebView() { }

	private void InputDetector_BeganDrag(object sender, EventArgs eventArgs) { }

	private void InputDetector_Dragged(object sender, EventArgs eventArgs) { }

	protected override void InputDetector_PointerDown(object sender, PointerEventArgs eventArgs) { }

	private void InputDetector_PointerEntered(object sender, EventArgs eventArgs) { }

	private void InputDetector_PointerExited(object sender, EventArgs eventArgs) { }

	private void InputDetector_PointerMoved(object sender, EventArgs eventArgs) { }

	protected override void InputDetector_PointerUp(object sender, PointerEventArgs eventArgs) { }

	private void InputDetector_Scrolled(object sender, ScrolledEventArgs eventArgs) { }

	protected override void OnDestroy() { }

	[CompilerGenerated]
	public override void remove_Clicked(EventHandler value) { }

	[CompilerGenerated]
	public void remove_Initialized(EventHandler value) { }

	[CompilerGenerated]
	public void remove_PointerEntered(EventHandler value) { }

	[CompilerGenerated]
	public void remove_PointerExited(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_Scrolled(EventHandler value) { }

	private void set__pointerInputDetector(IPointerInputDetector value) { }

	[CompilerGenerated]
	public void set_DragToScrollThreshold(float value) { }

	public void set_Material(Material value) { }

	public override void set_Visible(bool value) { }

	private void set_WebView(IWebView value) { }

	[Obsolete("WebViewPrefab.SetCutoutRect() has been replaced with WebViewPrefab.SetRenderBlackAsTransparent(). Please call SetRenderBlackAsTransparent(true) on the WebViewPrefab instance instead.", True)]
	public void SetCutoutRect(Rect rect) { }

	public void SetOptionsForInitialization(WebViewOptions options) { }

	public void SetPointerInputDetector(IPointerInputDetector pointerInputDetector) { }

	public void SetRenderBlackAsTransparent(bool enabled) { }

	public void SetWebViewForInitialization(IWebView webView) { }

	protected override void Update() { }

	public Task WaitUntilInitialized() { }

	private void WebView_ConsoleMessageLogged(object sender, ConsoleMessageEventArgs eventArgs) { }

	private void WebView_FallbackVideoRectChanged(object sender, EventArgs eventArgs) { }

	private void WebView_TextureChanged(object sender, EventArgs eventArgs) { }

}

