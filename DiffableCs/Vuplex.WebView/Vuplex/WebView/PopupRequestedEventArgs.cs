namespace Vuplex.WebView;

public class PopupRequestedEventArgs : EventArgs
{
	public readonly string Url; //Field offset: 0x10
	public readonly IWebView WebView; //Field offset: 0x18

	public PopupRequestedEventArgs(string url, IWebView webView) { }

}

