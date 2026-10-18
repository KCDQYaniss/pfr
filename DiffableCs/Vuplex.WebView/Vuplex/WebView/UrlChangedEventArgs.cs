namespace Vuplex.WebView;

public class UrlChangedEventArgs : EventArgs
{
	public string Url; //Field offset: 0x10
	[Obsolete("UrlChangedEventArgs.Title has been removed. Please use IWebView.Title or IWebView.TitleChanged instead: https://developer.vuplex.com/webview/IWebView#Title", True)]
	public string Title; //Field offset: 0x18
	[Obsolete("UrlChangedEventArgs.Type has been removed.", True)]
	public string Type; //Field offset: 0x20

	public UrlChangedEventArgs(string url) { }

	public virtual string ToString() { }

}

