namespace EFT.UI.Browser;

public interface IBrowserLogic
{

	public bool CanBeClosedManually
	{
		 get { } //Length: 0
	}

	public bool DeferNavigation
	{
		 get { } //Length: 0
	}

	public bool get_CanBeClosedManually() { }

	public bool get_DeferNavigation() { }

	public void HandleMessage(JObject obj, EBrowserEventType type) { }

	public void Initialize(BrowserWindow window) { }

	public void OnClose() { }

	public void OnPageLoadFinished(bool succeeded) { }

	public void OnShow() { }

	public void OnWebViewReady(WebViewWrapper webView) { }

}

