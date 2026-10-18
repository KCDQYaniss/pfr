namespace Vuplex.WebView;

[HelpURL("https://developer.vuplex.com/webview/WebViewPrefab")]
public class WebViewPrefab : BaseWebViewPrefab
{
	[CompilerGenerated]
	private struct <_initWebViewPrefab>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public WebViewPrefab <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Obsolete("The static WebViewPrefab.ScrollSensitivity property has been removed. Please use the ScrollingSensitivity instance property instead: https://developer.vuplex.com/webview/WebViewPrefab#ScrollingSensitivity", True)]
	public static float ScrollSensitivity; //Field offset: 0x0
	[Header("Platform-specific")]
	[Label("Native On-Screen Keyboard (Android, iOS, & visionOS only)")]
	[Tooltip("Determines whether the operating system's native on-screen keyboard is automatically shown when a text input in the webview is focused. The native on-screen keyboard is only supported for the following packages:\n• 3D WebView for Android (non-Gecko)\n• 3D WebView for iOS\n• 3D WebView for visionOS")]
	public bool NativeOnScreenKeyboardEnabled; //Field offset: 0xF8
	[FormerlySerializedAs("InitialResolution")]
	[HideInInspector]
	[Label("Resolution (px / Unity unit)")]
	[Tooltip("You can change this to make web content appear larger or smaller.")]
	public float Resolution; //Field offset: 0xFC
	[HideInInspector]
	public float ScrollingSensitivity; //Field offset: 0x100
	private Vector2 _sizeForInitialization; //Field offset: 0x104
	[HideInInspector]
	[SerializeField]
	protected Transform _viewResizer; //Field offset: 0x110

	public Collider Collider
	{
		 get { } //Length: 82
	}

	[Obsolete("WebViewPrefab.InitialResolution is now deprecated. Please use WebViewPrefab.Resolution instead.")]
	public float InitialResolution
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	protected virtual bool _getNativeOnScreenKeyboardEnabled() { }

	protected virtual float _getResolution() { }

	protected virtual float _getScrollingSensitivity() { }

	protected virtual ViewportMaterialView _getView() { }

	[AsyncStateMachine(typeof(<_initWebViewPrefab>d__18))]
	private void _initWebViewPrefab() { }

	private void _resetLocalScale() { }

	private void _setViewSize(float width, float height) { }

	public WebViewPrefab() { }

	public virtual Vector2 BrowserToScreenPoint(int xInPixels, int yInPixels) { }

	[Obsolete("WebViewPrefab.ConvertToScreenPoint() has been renamed to WebViewPrefab.WorldToNormalized(). Please switch to WorldToNormalized().")]
	public Vector2 ConvertToScreenPoint(Vector3 worldPoint) { }

	public Collider get_Collider() { }

	public float get_InitialResolution() { }

	[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init() { }

	[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init(float width, float height) { }

	[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called.", True)]
	public void Init(float width, float height, WebViewOptions options) { }

	[Obsolete("WebViewPrefab.Init() has been removed. The WebViewPrefab script now initializes itself automatically, so Init() no longer needs to be called. Please use WebViewPrefab.SetWebViewForInitialization(IWebView) instead.", True)]
	public void Init(IWebView webView) { }

	public static WebViewPrefab Instantiate(IWebView webView) { }

	public static WebViewPrefab Instantiate(float width, float height, WebViewOptions options) { }

	public static WebViewPrefab Instantiate(float width, float height) { }

	public void Resize(float width, float height) { }

	public void set_InitialResolution(float value) { }

	private void Start() { }

	public Vector2 WorldToNormalized(Vector3 worldPoint) { }

}

