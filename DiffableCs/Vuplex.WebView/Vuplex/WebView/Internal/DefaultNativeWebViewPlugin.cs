namespace Vuplex.WebView.Internal;

public class DefaultNativeWebViewPlugin : INativeWebViewPlugin
{
	public const string DllName = "VuplexWebViewWindows"; //Field offset: 0x0

	public DefaultNativeWebViewPlugin() { }

	public override void CanGoBack(IntPtr webViewPtr) { }

	public override void CanGoForward(IntPtr webViewPtr) { }

	public override void Click(IntPtr webViewPtr, int xInPixels, int yInPixels, bool preventStealingFocus) { }

	public override void Copy(IntPtr webViewPtr) { }

	public override void Cut(IntPtr webViewPtr) { }

	public override void Destroy(IntPtr webViewPtr) { }

	public override void DestroyTexture(IntPtr texturePtr, string graphicsApi) { }

	public override void ExecuteJavaScript(IntPtr webViewPtr, string javaScript, string resultCallbackID) { }

	public override void GoBack(IntPtr webViewPtr) { }

	public override void GoForward(IntPtr webViewPtr) { }

	public override void LoadHtml(IntPtr webViewPtr, string html) { }

	public override void LoadUrl(IntPtr webViewPtr, string url) { }

	public override void LoadUrlWithHeaders(IntPtr webViewPtr, string url, string newlineDelimitedHttpHeaders) { }

	public override void Paste(IntPtr webViewPtr) { }

	public override void Reload(IntPtr webViewPtr) { }

	public override void Resize(IntPtr webViewPtr, int width, int height) { }

	public override void Scroll(IntPtr webViewPtr, int deltaX, int deltaY) { }

	public override void ScrollAtPoint(IntPtr webViewPtr, int deltaX, int deltaY, int pointerX, int pointerY) { }

	public override void SelectAll(IntPtr webViewPtr) { }

	public override void SendKey(IntPtr webViewPtr, string key) { }

	public override void SetConsoleMessageEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	public override void SetDefaultBackgroundEnabled(IntPtr webViewPtr, bool enabled) { }

	public override void SetFocused(IntPtr webViewPtr, bool focused) { }

	public override void SetFocusedInputFieldEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	public override void SetRenderingEnabled(IntPtr webViewPtr, bool enabled) { }

	public override void StopLoad(IntPtr webViewPtr) { }

	private static void WebView_canGoBack(IntPtr webViewPtr) { }

	private static void WebView_canGoForward(IntPtr webViewPtr) { }

	private static void WebView_click(IntPtr webViewPtr, int x, int y, bool preventStealingFocus) { }

	private static void WebView_copy(IntPtr webViewPtr) { }

	private static void WebView_cut(IntPtr webViewPtr) { }

	private static void WebView_destroy(IntPtr webViewPtr) { }

	private static void WebView_destroyTexture(IntPtr texturePtr, string graphicsApi) { }

	private static void WebView_executeJavaScript(IntPtr webViewPtr, string javaScript, string resultCallbackID) { }

	private static void WebView_goBack(IntPtr webViewPtr) { }

	private static void WebView_goForward(IntPtr webViewPtr) { }

	private static void WebView_loadHtml(IntPtr webViewPtr, string html) { }

	private static void WebView_loadUrl(IntPtr webViewPtr, string url) { }

	private static void WebView_loadUrlWithHeaders(IntPtr webViewPtr, string url, string newlineDelimitedHttpHeaders) { }

	private static void WebView_paste(IntPtr webViewPtr) { }

	private static void WebView_reload(IntPtr webViewPtr) { }

	private static void WebView_resize(IntPtr webViewPtr, int width, int height) { }

	private static void WebView_scroll(IntPtr webViewPtr, int deltaX, int deltaY) { }

	private static void WebView_scrollAtPoint(IntPtr webViewPtr, int deltaX, int deltaY, int pointerX, int pointerY) { }

	private static void WebView_selectAll(IntPtr webViewPtr) { }

	private static void WebView_sendKey(IntPtr webViewPtr, string key) { }

	private static void WebView_setConsoleMessageEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setDefaultBackgroundEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setFocused(IntPtr webViewPtr, bool focused) { }

	private static void WebView_setFocusedInputFieldEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_setRenderingEnabled(IntPtr webViewPtr, bool enabled) { }

	private static void WebView_stopLoad(IntPtr webViewPtr) { }

	private static void WebView_zoomIn(IntPtr webViewPtr) { }

	private static void WebView_zoomOut(IntPtr webViewPtr) { }

	public override void ZoomIn(IntPtr webViewPtr) { }

	public override void ZoomOut(IntPtr webViewPtr) { }

}

