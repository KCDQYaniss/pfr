namespace EFT.UI;

public static class BrowserUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <BuildQueryString>b__17_0(KeyValuePair parameter) { }

	}

	[CompilerGenerated]
	private struct <OpenExpansionsPageAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string bodyUrl; //Field offset: 0x20
		private CancellationTokenSource <openCts>5__2; //Field offset: 0x28
		private CancellationToken <openCancellationToken>5__3; //Field offset: 0x30
		private bool <browserOpened>5__4; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static bool _isExpansionsOpeningOrOpen; //Field offset: 0x0
	private static CancellationTokenSource _openCts; //Field offset: 0x8

	private static ItemUiContext Instance
	{
		private get { } //Length: 148
	}

	private static void AbandonPendingOpenCts() { }

	private static string BuildQueryString(IReadOnlyDictionary query) { }

	public static string BuildUrl(string baseUrl, IReadOnlyDictionary query = null) { }

	private static void CancelPendingExpansionsOpen() { }

	private static bool CanContinueOpening(CancellationToken openCancellationToken) { }

	private static void CloseExpansionsBrowser() { }

	private static string CombineUrlWithQuery(Uri baseUri, string queryString) { }

	private static ItemUiContext get_Instance() { }

	public static string GetGamePurchaseMethod() { }

	[AsyncStateMachine(typeof(<OpenExpansionsPageAsync>d__15))]
	public static Task OpenExpansionsPageAsync(string bodyUrl = "") { }

	public static void OpenInGameBrowser(string url) { }

	public static bool OpenUrl(string url) { }

	public static Task ReloadExpansionsPageAsync(string bodyUrl) { }

	public static void RequestCloseShop() { }

	public static void ResetExpansionsOpenState() { }

	public static void TryCloseIfOpen() { }

	public static bool TryNormalizeUrl(string rawUrl, out string url, out string error) { }

}

