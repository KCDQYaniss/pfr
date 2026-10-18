namespace EFT;

internal abstract class ClientBackend`1 : Backend
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public TaskCompletionSource loginTaskSource; //Field offset: 0x0

		public <>c__DisplayClass16_0() { }

		internal void <Login>b__0(Result result) { }

	}

	[CompilerGenerated]
	private struct <CreateClientSession>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Destroy>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAvailableLanguages>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetExpansionsSettings>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGameMode>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Nullable sessionMode; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLocalization>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		public string locale; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Login>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		public string login; //Field offset: 0x0
		public string password; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Logout>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegenerateToken>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskCompletionSource <source>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateVersion>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ClientBackend <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class ExtensionsSettingsResponse
	{
		internal sealed class GlobalsConfig
		{
			[JsonProperty("ExtensionsSettings")]
			public ExtensionsSettings ExtensionsSettings; //Field offset: 0x0

			public GlobalsConfig() { }

		}

		[JsonProperty("config")]
		public GlobalsConfig Config; //Field offset: 0x0

		public ExtensionsSettingsResponse() { }

	}

	[CompilerGenerated]
	private BackendStatus <Status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private T <Session>k__BackingField; //Field offset: 0x0
	protected GameModeDescriptor gameModeDescriptor; //Field offset: 0x0
	protected string _backendUrl; //Field offset: 0x0
	protected readonly Version _version; //Field offset: 0x0
	protected readonly string _deviceId; //Field offset: 0x0
	protected readonly bool _developMode; //Field offset: 0x0

	public GameModeDescriptor GameModeDescriptor
	{
		 get { } //Length: 5
	}

	public override T Session
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override BackendStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected ClientBackend`1(HTTPTransportManager httpTransport, WsTransportManager wsTransport, Version version, string backendUrl, string deviceId, bool developMode, EGameMode gameMode, BackendCache cache) { }

	[AsyncStateMachine(typeof(<CreateClientSession>d__23))]
	public override Task CreateClientSession() { }

	protected abstract T CreateSession(LoginDataResponse loginDataResponse) { }

	[AsyncStateMachine(typeof(<Destroy>d__25))]
	public override Task Destroy() { }

	public override void EnableDiagnostics(bool webDiagnosticsEnabled) { }

	public GameModeDescriptor get_GameModeDescriptor() { }

	[CompilerGenerated]
	public override T get_Session() { }

	[CompilerGenerated]
	public override BackendStatus get_Status() { }

	[AsyncStateMachine(typeof(<GetAvailableLanguages>d__35))]
	public override Task GetAvailableLanguages() { }

	public override Task GetCharacters() { }

	[AsyncStateMachine(typeof(<GetExpansionsSettings>d__20))]
	public override Task GetExpansionsSettings() { }

	[AsyncStateMachine(typeof(<GetGameMode>d__17))]
	public override Task GetGameMode(Nullable sessionMode) { }

	[AsyncStateMachine(typeof(<GetLocalization>d__32))]
	public override Task GetLocalization(string locale) { }

	public override Task GetMainMenuLocalization(string locale) { }

	public override Task GetSeasonalPerks() { }

	public override Task GetTemplates(ItemTemplates returnInCaseOfCache) { }

	public override Task LoadLocale(string locale = null) { }

	public override Task LoadMainMenuLocale(string locale = null) { }

	[AsyncStateMachine(typeof(<Login>d__16))]
	public override Task Login(string login, string password) { }

	[AsyncStateMachine(typeof(<Logout>d__24))]
	public override Task Logout() { }

	[AsyncStateMachine(typeof(<RegenerateToken>d__29))]
	public override Task RegenerateToken() { }

	public override void RegisterDevice(string email, string activateCode, Callback callback) { }

	[CompilerGenerated]
	protected void set_Session(T value) { }

	[CompilerGenerated]
	private void set_Status(BackendStatus value) { }

	[AsyncStateMachine(typeof(<ValidateVersion>d__30))]
	public override Task ValidateVersion() { }

}

