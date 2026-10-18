//Type is in global namespace

internal class WsWebSender
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__69_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetNotificationPayloadMessages>b__69_0(JToken item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public WsWebSender <>4__this; //Field offset: 0x10
		public DateTime startTime; //Field offset: 0x18

		public <>c__DisplayClass50_0() { }

		internal void <EstablishConnection>b__0() { }

		internal bool <EstablishConnection>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public WsRequest reqToSend; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass64_0() { }

		internal bool <HandleRequestConfirmationWithRetries>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public WsWebSender <>4__this; //Field offset: 0x10
		public WsRequest requestToSend; //Field offset: 0x18

		public <>c__DisplayClass65_0() { }

		internal void <TrySendAndFinishIfError>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public string payload; //Field offset: 0x10
		public WsWebSender <>4__this; //Field offset: 0x18
		public string wsMessageId; //Field offset: 0x20

		public <>c__DisplayClass73_0() { }

		internal void <HandleWireMessageAsync>b__0() { }

		internal void <HandleWireMessageAsync>b__1() { }

		internal WsResponseJson <HandleWireMessageAsync>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_1
	{
		public Action action; //Field offset: 0x10
		public string notificationParams; //Field offset: 0x18

		public <>c__DisplayClass73_1() { }

		internal void <HandleWireMessageAsync>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_2
	{
		public Action handler; //Field offset: 0x10
		public WsPushNotificationMessage pushNotification; //Field offset: 0x18

		public <>c__DisplayClass73_2() { }

		internal void <HandleWireMessageAsync>b__4() { }

	}

	[CompilerGenerated]
	private struct <AwaitReconnectionIfNeededAsync>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Func updateContinueCondition; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseConnection>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		public bool fullClose; //Field offset: 0x28
		private WebSocket <webSocket>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DebugPingManuallyAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EstablishConnection>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		public WsConnectionParams connParams; //Field offset: 0x28
		private <>c__DisplayClass50_0 <>8__1; //Field offset: 0x58
		private bool <isReconnecting>5__2; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleIncomingWireMessageAsync>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MessageEventArgs e; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleRequestConfirmation>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		public WsRequest reqToSend; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleRequestConfirmationWithRetries>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsRequest reqToSend; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private <>c__DisplayClass64_0 <>8__1; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private int <timeoutIndex>5__2; //Field offset: 0x40
		private DateTime <timeOutStart>5__3; //Field offset: 0x48
		private float <curTimeout>5__4; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x54
		private bool <connectionIsInactive>5__5; //Field offset: 0x55
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleRequestSendAndConfirmation>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsRequest reqToSend; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleWireMessageAsync>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string payload; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		public string wsMessageId; //Field offset: 0x30
		public WsWireMessageType messageType; //Field offset: 0x38
		private <>c__DisplayClass73_0 <>8__1; //Field offset: 0x40
		public string method; //Field offset: 0x48
		private WsRequest <request>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <KeepAliveUpdate>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private YieldAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PingSocketUpdateAsync>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PingSocketUpdateIfOutdatedAsync>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		public float outdateIntervalSec; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestsQueueAwaitingResponseUpdate>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestsQueueSendingUpdate>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private WsRequest <reqToSend>5__2; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestsQueueSerializationUpdate>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		private WsRequest <req>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendNotification>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendRequest>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsRequestJson requestJson; //Field offset: 0x20
		public WsWebSender <>4__this; //Field offset: 0x28
		public int timeoutSeconds; //Field offset: 0x30
		private WsRequest <request>5__2; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySendAndFinishIfError>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsWebSender <>4__this; //Field offset: 0x20
		public WsRequest requestToSend; //Field offset: 0x28
		private <>c__DisplayClass65_0 <>8__1; //Field offset: 0x30
		private bool <errorOccured>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float CHECK_CONN_PING_INTERVAL_SEC = 1; //Field offset: 0x0
	private const float KEEP_ALIVE_INTERVAL_SANITY_FALLBACK_VALUE = 1; //Field offset: 0x0
	private const float ESTABLISHING_CONNECTION_TIMEOUT_SEC = 30; //Field offset: 0x0
	private const float CLOSE_HANDSHAKE_TIMEOUT_SEC = 5; //Field offset: 0x0
	private WsConnectionStatus _connStatus; //Field offset: 0x10
	private CloseStatusCode _closeStatusCode; //Field offset: 0x14
	private ushort _lastCloseCode; //Field offset: 0x16
	private string _lastCloseReason; //Field offset: 0x18
	private bool _lastCloseWasClean; //Field offset: 0x20
	private bool _isQuitting; //Field offset: 0x21
	private CancellationTokenSource _internalUpdatesCTS; //Field offset: 0x28
	private bool _lastPingResult; //Field offset: 0x30
	private DateTime _lastPingTime; //Field offset: 0x38
	private float _keepAliveInterval; //Field offset: 0x40
	private float[] _receiveConfirmationTimeouts; //Field offset: 0x48
	private bool _requestConfirmationInProgress; //Field offset: 0x50
	private WebSocket _webSocket; //Field offset: 0x58
	private TaskCompletionSource _closeHandshakeAwaiter; //Field offset: 0x60
	private readonly Dictionary _notificationsToHandle; //Field offset: 0x68
	private readonly Stack _requestsPool; //Field offset: 0x70
	private readonly WsRequestsQueue _requestsToSerialize; //Field offset: 0x78
	private readonly WsRequestsQueue _requestsToSend; //Field offset: 0x80
	private readonly Dictionary _requestsToAwaitResult; //Field offset: 0x88
	private readonly List _timedOutRequestsIdsCache; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnConnectionClosed; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnPushNotificationReceived; //Field offset: 0xA0

	public event Action OnConnectionClosed
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPushNotificationReceived
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public CloseStatusCode CloseStatusCode
	{
		 get { } //Length: 5
	}

	public WsConnectionStatus ConnectionStatus
	{
		 get { } //Length: 164
	}

	public int DebugCurrRunningRequestsCount
	{
		 get { } //Length: 205
	}

	public int DebugCurrSendingReqs
	{
		 get { } //Length: 74
	}

	public int DebugCurrSerializingReqs
	{
		 get { } //Length: 71
	}

	public int DebugCurrWaitingResponseReqs
	{
		 get { } //Length: 71
	}

	public bool DebugIsPingResultOutdated
	{
		 get { } //Length: 172
	}

	public bool DebugLastPingResult
	{
		 get { } //Length: 5
	}

	public bool DebugReqConfirmInProgress
	{
		 get { } //Length: 5
	}

	private bool RetriesEnabled
	{
		private get { } //Length: 22
	}

	public WsWebSender() { }

	[CompilerGenerated]
	private bool <RequestsQueueSendingUpdate>b__60_0() { }

	[CompilerGenerated]
	public void add_OnConnectionClosed(Action value) { }

	[CompilerGenerated]
	public void add_OnPushNotificationReceived(Action value) { }

	public void AddNotificationToHandle(string notificationId, Action action) { }

	[AsyncStateMachine(typeof(<AwaitReconnectionIfNeededAsync>d__75))]
	private Task AwaitReconnectionIfNeededAsync(Func updateContinueCondition, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CloseConnection>d__51))]
	public Task CloseConnection(bool fullClose = true) { }

	[AsyncStateMachine(typeof(<DebugPingManuallyAsync>d__86))]
	public Task DebugPingManuallyAsync() { }

	private void DetachWebSocket(WebSocket webSocket) { }

	[AsyncStateMachine(typeof(<EstablishConnection>d__50))]
	public Task EstablishConnection(WsConnectionParams connParams) { }

	public CloseStatusCode get_CloseStatusCode() { }

	public WsConnectionStatus get_ConnectionStatus() { }

	public int get_DebugCurrRunningRequestsCount() { }

	public int get_DebugCurrSendingReqs() { }

	public int get_DebugCurrSerializingReqs() { }

	public int get_DebugCurrWaitingResponseReqs() { }

	public bool get_DebugIsPingResultOutdated() { }

	public bool get_DebugLastPingResult() { }

	public bool get_DebugReqConfirmInProgress() { }

	private bool get_RetriesEnabled() { }

	private string GetNotificationParams(string payload) { }

	private string[] GetNotificationPayloadMessages(string payload) { }

	[AsyncStateMachine(typeof(<HandleIncomingWireMessageAsync>d__72))]
	private Task HandleIncomingWireMessageAsync(MessageEventArgs e) { }

	[AsyncStateMachine(typeof(<HandleRequestConfirmation>d__63))]
	private Task HandleRequestConfirmation(WsRequest reqToSend, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<HandleRequestConfirmationWithRetries>d__64))]
	private Task HandleRequestConfirmationWithRetries(WsRequest reqToSend, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<HandleRequestSendAndConfirmation>d__62))]
	private Task HandleRequestSendAndConfirmation(WsRequest reqToSend, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<HandleWireMessageAsync>d__73))]
	private Task HandleWireMessageAsync(WsWireMessageType messageType, string wsMessageId, string method, string payload) { }

	private bool IsConnectionActive(WsConnectionStatus connectionStatus) { }

	private bool IsReqConfirmedInSomeWay(WsRequest req) { }

	private bool IsRequestStillAwaited(WsRequest req) { }

	[AsyncStateMachine(typeof(<KeepAliveUpdate>d__58))]
	private Task KeepAliveUpdate(CancellationToken cancellationToken) { }

	private void OnApplicationQuitting() { }

	private void OnClose(object sender, CloseEventArgs e) { }

	private void OnErrorReceived(object sender, ErrorEventArgs e) { }

	private void OnMessageReceived(object sender, MessageEventArgs e) { }

	private void OnOpened(object sender, EventArgs e) { }

	private void OnWSLogReceived(LogData data, string message) { }

	private bool PingSocketUpdate() { }

	[AsyncStateMachine(typeof(<PingSocketUpdateAsync>d__79))]
	private Task PingSocketUpdateAsync() { }

	[AsyncStateMachine(typeof(<PingSocketUpdateIfOutdatedAsync>d__80))]
	private Task PingSocketUpdateIfOutdatedAsync(float outdateIntervalSec) { }

	private WsRequest PopRequest() { }

	private void PushRequest(WsRequest req) { }

	[CompilerGenerated]
	public void remove_OnConnectionClosed(Action value) { }

	[CompilerGenerated]
	public void remove_OnPushNotificationReceived(Action value) { }

	public void RemoveHandlingNotification(string notificationId) { }

	[AsyncStateMachine(typeof(<RequestsQueueAwaitingResponseUpdate>d__61))]
	private Task RequestsQueueAwaitingResponseUpdate(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<RequestsQueueSendingUpdate>d__60))]
	private Task RequestsQueueSendingUpdate(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<RequestsQueueSerializationUpdate>d__59))]
	private Task RequestsQueueSerializationUpdate(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SendNotification>d__57))]
	public Task SendNotification(WsRequestJson requestJson) { }

	[AsyncStateMachine(typeof(<SendRequest>d__54))]
	public Task SendRequest(WsRequestJson requestJson, int timeoutSeconds) { }

	private void SendWireData(byte[] data) { }

	private void TryRemoveFromAwaitResult(WsRequest req) { }

	[AsyncStateMachine(typeof(<TrySendAndFinishIfError>d__65))]
	private Task TrySendAndFinishIfError(WsRequest requestToSend) { }

}

