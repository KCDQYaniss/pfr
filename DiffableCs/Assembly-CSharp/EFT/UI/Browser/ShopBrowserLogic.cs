namespace EFT.UI.Browser;

public sealed class ShopBrowserLogic : IBrowserLogic
{
	[CompilerGenerated]
	private struct <HidePlaceholderWithDelay>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShopBrowserLogic <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendSignTransactionRequestToBackend>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShopBrowserLogic <>4__this; //Field offset: 0x20
		public string transactionId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForShopReadyWithTimeout>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShopBrowserLogic <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float MIN_SHOW_DURATION = 3.5; //Field offset: 0x0
	private const float SHOP_READY_TIMEOUT_SECONDS = 15; //Field offset: 0x0
	private BrowserWindow _window; //Field offset: 0x10
	private float _showTime; //Field offset: 0x18
	private bool _hideEventReceived; //Field offset: 0x1C
	private bool _shopContentReady; //Field offset: 0x1D
	private bool _allowManualClose; //Field offset: 0x1E
	private CancellationTokenSource _cts; //Field offset: 0x20
	private readonly ShopWebViewExternalLinkHandler _externalLinkHandler; //Field offset: 0x28

	public override bool CanBeClosedManually
	{
		 get { } //Length: 5
	}

	public override bool DeferNavigation
	{
		 get { } //Length: 3
	}

	public ShopBrowserLogic() { }

	private void EnableManualClose() { }

	public override bool get_CanBeClosedManually() { }

	public override bool get_DeferNavigation() { }

	private void HandleCloseShop() { }

	public override void HandleMessage(JObject obj, EBrowserEventType type) { }

	private void HandleNeedTransactionSign(JObject obj) { }

	private void HandlePurchaseByWidget(JObject obj) { }

	private static void HandleShopNotification(JObject obj) { }

	private void HandleShopReloadAuth(JObject obj) { }

	[AsyncStateMachine(typeof(<HidePlaceholderWithDelay>d__22))]
	private Task HidePlaceholderWithDelay() { }

	public override void Initialize(BrowserWindow window) { }

	public override void OnClose() { }

	public override void OnPageLoadFinished(bool succeeded) { }

	public override void OnShow() { }

	public override void OnWebViewReady(WebViewWrapper webView) { }

	private void PostPurchaseCommandToWeb(EBrowserEventType browserEventType, string targetId) { }

	[AsyncStateMachine(typeof(<SendSignTransactionRequestToBackend>d__25))]
	private Task SendSignTransactionRequestToBackend(string transactionId) { }

	private static void TryPurchaseViaSteamOverlay(JObject obj) { }

	[AsyncStateMachine(typeof(<WaitForShopReadyWithTimeout>d__20))]
	private Task WaitForShopReadyWithTimeout() { }

}

