namespace Vuplex.WebView.Internal;

public interface INativeWebViewPlugin
{

	public void CanGoBack(IntPtr webViewPtr) { }

	public void CanGoForward(IntPtr webViewPtr) { }

	public void Click(IntPtr webViewPtr, int xInPixels, int yInPixels, bool preventStealingFocus) { }

	public void Copy(IntPtr webViewPtr) { }

	public void Cut(IntPtr webViewPtr) { }

	public void Destroy(IntPtr webViewPtr) { }

	public void DestroyTexture(IntPtr texturePtr, string graphicsApi) { }

	public void ExecuteJavaScript(IntPtr webViewPtr, string javaScript, string resultCallbackID) { }

	public void GoBack(IntPtr webViewPtr) { }

	public void GoForward(IntPtr webViewPtr) { }

	public void LoadHtml(IntPtr webViewPtr, string html) { }

	public void LoadUrl(IntPtr webViewPtr, string url) { }

	public void LoadUrlWithHeaders(IntPtr webViewPtr, string url, string newlineDelimitedHttpHeaders) { }

	public void Paste(IntPtr webViewPtr) { }

	public void Reload(IntPtr webViewPtr) { }

	public void Resize(IntPtr webViewPtr, int width, int height) { }

	public void Scroll(IntPtr webViewPtr, int deltaX, int deltaY) { }

	public void ScrollAtPoint(IntPtr webViewPtr, int deltaX, int deltaY, int pointerX, int pointerY) { }

	public void SelectAll(IntPtr webViewPtr) { }

	public void SendKey(IntPtr webViewPtr, string input) { }

	public void SetConsoleMessageEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	public void SetDefaultBackgroundEnabled(IntPtr webViewPtr, bool enabled) { }

	public void SetFocused(IntPtr webViewPtr, bool focused) { }

	public void SetFocusedInputFieldEventsEnabled(IntPtr webViewPtr, bool enabled) { }

	public void SetRenderingEnabled(IntPtr webViewPtr, bool enabled) { }

	public void StopLoad(IntPtr webViewPtr) { }

	public void ZoomIn(IntPtr webViewPtr) { }

	public void ZoomOut(IntPtr webViewPtr) { }

}

