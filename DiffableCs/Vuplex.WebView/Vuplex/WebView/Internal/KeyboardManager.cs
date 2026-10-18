namespace Vuplex.WebView.Internal;

internal class KeyboardManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public object sender; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <WebView_FocusChanged>b__0(BaseWebViewPrefab p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public object sender; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <WebView_ImeInputFieldPositionChanged>b__0(BaseWebViewPrefab p) { }

	}

	private static bool _destroyed; //Field offset: 0x0
	private static KeyboardManager _instance; //Field offset: 0x8
	private BaseWebViewPrefab _focusedWebViewPrefab; //Field offset: 0x20
	private BaseWebViewPrefab _hoveredWebViewPrefab; //Field offset: 0x28
	private HashSet _keyboards; //Field offset: 0x30
	private NativeKeyboardListener _nativeKeyboardListener; //Field offset: 0x38
	private bool _pointerIsHoveringOverKeyboard; //Field offset: 0x40
	private HashSet _webViewPrefabs; //Field offset: 0x48

	public static KeyboardManager Instance
	{
		 get { } //Length: 657
	}

	private void _addWebViewPrefab(BaseWebViewPrefab webViewPrefab) { }

	private void _removeWebViewPrefab(BaseWebViewPrefab webViewPrefab) { }

	private void _setFocusedWebViewPrefab(BaseWebViewPrefab webViewPrefab) { }

	public KeyboardManager() { }

	public void AddKeyboard(BaseKeyboard keyboard) { }

	private void Awake() { }

	public static KeyboardManager get_Instance() { }

	private void NativeKeyboardListener_ImeCompositionCancelled(object sender, EventArgs eventArgs) { }

	private void NativeKeyboardListener_ImeCompositionChanged(object sender, EventArgs eventArgs) { }

	private void NativeKeyboardListener_ImeCompositionFinished(object sender, EventArgs eventArgs) { }

	private void NativeKeyboardListener_KeyDownReceived(object sender, KeyboardEventArgs eventArgs) { }

	private void NativeKeyboardListener_KeyUpReceived(object sender, KeyboardEventArgs eventArgs) { }

	private void OnDestroy() { }

	private void OnScreenKeyboard_KeyPressed(object sender, EventArgs eventArgs) { }

	private void OnScreenKeyboard_PointerEntered(object sender, EventArgs eventArgs) { }

	private void OnScreenKeyboard_PointerExited(object sender, EventArgs eventArgs) { }

	public void RemoveKeyboard(BaseKeyboard keyboard) { }

	public void SetKeyboardEnabled(BaseWebViewPrefab webViewPrefab, bool enabled) { }

	private void Update() { }

	private void WebView_FocusChanged(object sender, EventArgs eventArgs) { }

	private void WebView_ImeInputFieldPositionChanged(object sender, EventArgs eventArgs) { }

	private void WebViewPrefab_Clicked(object sender, ClickedEventArgs eventArgs) { }

	private void WebViewPrefab_PointerEntered(object sender, EventArgs eventArgs) { }

	private void WebViewPrefab_PointerExited(object sender, EventArgs eventArgs) { }

}

