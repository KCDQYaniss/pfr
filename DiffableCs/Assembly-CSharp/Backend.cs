//Type is in global namespace

internal class Backend
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0`1
	{
		public BackendRequestParams backRequest; //Field offset: 0x0
		public Backend <>4__this; //Field offset: 0x0

		public <>c__DisplayClass30_0`1() { }

		internal void <Send>b__0() { }

	}

	[CompilerGenerated]
	private struct <KeepAliveCoroutine>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Backend <>4__this; //Field offset: 0x28
		public bool useStaticInterval; //Field offset: 0x30
		public float delay; //Field offset: 0x34
		public string url; //Field offset: 0x38
		public object params; //Field offset: 0x40
		public bool inBackground; //Field offset: 0x48
		public CancellationToken cts; //Field offset: 0x50
		private DateTime <staticIntervalReference>5__2; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Send>d__30`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BackendRequestParams backRequest; //Field offset: 0x0
		public Backend <>4__this; //Field offset: 0x0
		private <>c__DisplayClass30_0 <>8__1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Send>d__31`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Backend <>4__this; //Field offset: 0x0
		public SendRequest request; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Send>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Backend <>4__this; //Field offset: 0x20
		public SendRequest request; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Send>d__33`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Backend <>4__this; //Field offset: 0x0
		public SendRequest request; //Field offset: 0x0
		public Callback onFinished; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendHeadersOnly>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SendRequest request; //Field offset: 0x20
		public Backend <>4__this; //Field offset: 0x70
		private TaskAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendLegacy>d__38`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public SendRequest request; //Field offset: 0x0
		public Backend <>4__this; //Field offset: 0x0
		private T <res>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendVoid>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Backend <>4__this; //Field offset: 0x20
		public SendRequest request; //Field offset: 0x28
		public Callback onFinished; //Field offset: 0x78
		private TaskAwaiter <>u__1; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StopBackend>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Backend <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BackendLogger : AbstractLogger
	{

		public BackendLogger() { }

	}

	private enum EBackEndCoreState
	{
		Free = 0,
		Stopping = 1,
		Stopped = 2,
	}

	protected readonly BackendLogger Logger; //Field offset: 0x10
	[CanBeNull]
	protected readonly BackendCache _cache; //Field offset: 0x18
	protected HTTPTransportManager _httpTransport; //Field offset: 0x20
	protected WsTransportManager _wsTransport; //Field offset: 0x28
	protected string[] _region; //Field offset: 0x30
	protected string[] _virtualRegion; //Field offset: 0x38
	private EBackEndCoreState _state; //Field offset: 0x40
	private int _skipped; //Field offset: 0x44
	private HashSet _wsPathsSet; //Field offset: 0x48
	protected bool _useLobbyConnection; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; //Field offset: 0x51

	protected string AppVersion
	{
		 get { } //Length: 148
	}

	public override IBackendCache Cache
	{
		 get { } //Length: 5
	}

	public override bool Destroyed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected DateTime LastSucceedResponse
	{
		 get { } //Length: 29
	}

	[CanBeNull]
	protected string PhpSessionId
	{
		 get { } //Length: 148
	}

	protected Backend(HTTPTransportManager httpTransport, WsTransportManager wsTransport, BackendCache cache = null) { }

	[CompilerGenerated]
	private void <KeepAliveCoroutine>b__27_0(IResult result) { }

	public void AddNotification(string notificationType, Action action) { }

	protected void ConfigureWssMethodsSet(IEnumerable wssMethods) { }

	protected string get_AppVersion() { }

	public override IBackendCache get_Cache() { }

	[CompilerGenerated]
	public override bool get_Destroyed() { }

	protected DateTime get_LastSucceedResponse() { }

	protected string get_PhpSessionId() { }

	public static string GetMd5Hash(string input) { }

	private ETransportProtocolType GetTransportProtocolForBackendMethod(string methodPath) { }

	[AsyncStateMachine(typeof(<KeepAliveCoroutine>d__27))]
	protected void KeepAliveCoroutine(string url, float delay, CancellationToken cts, bool useStaticInterval = false, bool inBackground = true, object params = null) { }

	protected override void OnKeepAliveFailed(string error, int errorCode) { }

	public void RemoveNotificationHandling(string notificationType) { }

	[AsyncStateMachine(typeof(<Send>d__30`1))]
	protected Task Send(BackendRequestParams backRequest) { }

	[AsyncStateMachine(typeof(<Send>d__33`1))]
	protected Task Send(SendRequest request, Callback onFinished) { }

	[AsyncStateMachine(typeof(<Send>d__31`1))]
	protected Task Send(SendRequest request) { }

	[AsyncStateMachine(typeof(<Send>d__32))]
	protected Task Send(SendRequest request) { }

	[AsyncStateMachine(typeof(<SendHeadersOnly>d__35))]
	protected Task SendHeadersOnly(SendRequest request) { }

	[AsyncStateMachine(typeof(<SendLegacy>d__38`1))]
	private Task SendLegacy(SendRequest request) { }

	[AsyncStateMachine(typeof(<SendVoid>d__34))]
	protected Task SendVoid(SendRequest request, Callback onFinished) { }

	[CompilerGenerated]
	protected void set_Destroyed(bool value) { }

	protected void SetWebDiagnosticsEnabled(bool webDiagnosticsEnabled) { }

	[AsyncStateMachine(typeof(<StopBackend>d__36))]
	protected Task StopBackend() { }

}

