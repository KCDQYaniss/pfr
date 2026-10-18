namespace EFT.UI.Browser;

internal sealed class ShopWebViewExternalLinkHandler
{
	[CompilerGenerated]
	private struct <RevertNavigationAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShopWebViewExternalLinkHandler <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string XSOLLA_PAYMENT_MARKER = "secure.xsolla.com"; //Field offset: 0x0
	private WebViewWrapper _webView; //Field offset: 0x10
	private IWithPopups _webViewWithPopups; //Field offset: 0x18
	private string _shopHost; //Field offset: 0x20
	private bool _revertingNavigation; //Field offset: 0x28

	public ShopWebViewExternalLinkHandler() { }

	public void Attach(WebViewWrapper webView, string shopUrl) { }

	public void Detach() { }

	private static bool IsAppDeepLink(string url) { }

	private static bool IsAppScheme(string scheme) { }

	private static bool IsXsollaPaymentSuccessUrl(string url) { }

	private void OnPopupRequested(object sender, PopupRequestedEventArgs e) { }

	private void OnUrlChanged(object sender, UrlChangedEventArgs e) { }

	private static void OpenExternally(string url) { }

	[AsyncStateMachine(typeof(<RevertNavigationAsync>d__10))]
	private Task RevertNavigationAsync() { }

	private bool ShouldStayInWebView(string url) { }

	private string TryGetHost(string url) { }

}

