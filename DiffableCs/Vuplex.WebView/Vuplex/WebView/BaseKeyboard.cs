namespace Vuplex.WebView;

public abstract class BaseKeyboard : MonoBehaviour
{
	[CompilerGenerated]
	private struct <_init>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseKeyboard <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal void <WaitUntilInitialized>b__0(object sender, EventArgs e) { }

	}

	protected static readonly WebViewOptions _webViewOptions; //Field offset: 0x0
	[CompilerGenerated]
	private EventHandler KeyPressed; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler Initialized; //Field offset: 0x28
	[Label("Custom Keyboard URL (optional)")]
	[Tooltip("If you want to load a customized version of the Keyboard UI, you can do so by setting this field. For example, you could load a customized Keyboard UI from StreamingAssets by using a URL like \"streaming-assets://keyboard/index.html\".")]
	public string CustomKeyboardUrl; //Field offset: 0x30
	private bool _isInitialized; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	protected BaseWebViewPrefab _webViewPrefab; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler InputReceived; //Field offset: 0x48

	public event EventHandler Initialized
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	[Obsolete("Keyboard.InputReceived was removed in v4.3 because WebViewPrefab and CanvasWebViewPrefab now automatically handle keyboard input by default. Please remove your code that references Keyboard.InputReceived, and keyboard support will still work. For more info, including details about how you can still access keyboard input programmatically, please see this article: https://support.vuplex.com/articles/keyboard", True)]
	public event EventHandler InputReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event EventHandler KeyPressed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	internal BaseWebViewPrefab BaseWebViewPrefab
	{
		internal get { } //Length: 5
	}

	private string _getKeyboardLanguage() { }

	[AsyncStateMachine(typeof(<_init>d__13))]
	protected void _init() { }

	private void _sendKeyboardLanguageMessage() { }

	protected static void _setLayerRecursively(GameObject gameObject, int layer) { }

	private static BaseKeyboard() { }

	protected BaseKeyboard() { }

	[CompilerGenerated]
	public void add_Initialized(EventHandler value) { }

	[CompilerGenerated]
	public void add_InputReceived(EventHandler value) { }

	[CompilerGenerated]
	public void add_KeyPressed(EventHandler value) { }

	internal BaseWebViewPrefab get_BaseWebViewPrefab() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	[CompilerGenerated]
	public void remove_Initialized(EventHandler value) { }

	[CompilerGenerated]
	public void remove_InputReceived(EventHandler value) { }

	[CompilerGenerated]
	public void remove_KeyPressed(EventHandler value) { }

	public Task WaitUntilInitialized() { }

	private void WebView_MessageEmitted(object sender, EventArgs e) { }

}

