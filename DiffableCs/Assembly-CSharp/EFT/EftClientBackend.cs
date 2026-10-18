namespace EFT;

internal sealed class EftClientBackend : ClientBackend, IClientBackEnd, IBackEnd, ILocalizationLoader
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal void <Logout>b__0() { }

	}

	[CompilerGenerated]
	private struct <Logout>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackend <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private EftClientBackend(HTTPTransportManager httpTransport, WsTransportManager wsTransport, Version version, string backendUrl, string deviceId, bool developMode, EGameMode gameMode, BackendCache cache) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	internal static EftClientBackend Create(Version version, string backendUrl, string cacheDir, EGameMode gameMode, string deviceId = null, bool developMode = false, string phpSessionId = null, RequestFailHandler failHandler = null) { }

	protected virtual IEftSession CreateSession(LoginDataResponse loginDataResponse) { }

	[AsyncStateMachine(typeof(<Logout>d__3))]
	public virtual Task Logout() { }

}

