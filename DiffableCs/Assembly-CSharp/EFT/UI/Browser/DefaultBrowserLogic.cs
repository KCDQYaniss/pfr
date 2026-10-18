namespace EFT.UI.Browser;

public class DefaultBrowserLogic : IBrowserLogic
{

	public override bool CanBeClosedManually
	{
		 get { } //Length: 3
	}

	public override bool DeferNavigation
	{
		 get { } //Length: 3
	}

	public DefaultBrowserLogic() { }

	public override bool get_CanBeClosedManually() { }

	public override bool get_DeferNavigation() { }

	public override void HandleMessage(JObject obj, EBrowserEventType type) { }

	public override void Initialize(BrowserWindow window) { }

	public override void OnClose() { }

	public override void OnPageLoadFinished(bool succeeded) { }

	public override void OnShow() { }

	public override void OnWebViewReady(WebViewWrapper webView) { }

}

