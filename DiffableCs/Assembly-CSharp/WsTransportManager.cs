//Type is in global namespace

internal class WsTransportManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		private struct <<ReconnectLoop>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass20_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TaskCompletionSource tcs; //Field offset: 0x10
		public WsTransportManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		[AsyncStateMachine(typeof(<<ReconnectLoop>b__0>d))]
		internal void <ReconnectLoop>b__0() { }

	}

	[CompilerGenerated]
	private struct <CloseConnection>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsTransportManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EstablishConnectionToUrl>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsTransportManager <>4__this; //Field offset: 0x20
		public WsConnectionParams connParams; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReconnectLoop>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WsTransportManager <>4__this; //Field offset: 0x20
		public CancellationToken ct; //Field offset: 0x28
		private float <delaySec>5__2; //Field offset: 0x30
		private DateTime <startWaitTime>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendRequest>d__21`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BackendRequestParams reqParams; //Field offset: 0x0
		public WsTransportManager <>4__this; //Field offset: 0x0
		private int <maxRetries>5__2; //Field offset: 0x0
		private int <attempt>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendRequestOnce>d__22`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BackendRequestParams reqParams; //Field offset: 0x0
		public WsTransportManager <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float RECONNECT_BASE_DELAY_SEC = 0.1; //Field offset: 0x0
	private const int RECONNECT_MAX_EXPONENT = 6; //Field offset: 0x0
	private WsWebSender _sender; //Field offset: 0x10
	private WsConnectionParams _lastParams; //Field offset: 0x18
	private CancellationTokenSource _reconnectCTS; //Field offset: 0x48
	private int _reconnectAttempt; //Field offset: 0x50
	private float _reconnectDelayTimer; //Field offset: 0x54
	private readonly Random _random; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnPushNotificationReceived; //Field offset: 0x60

	public event Action OnPushNotificationReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public float DebugCurrReconnectIntervalTimer
	{
		 get { } //Length: 6
	}

	public WsWebSender Sender
	{
		 get { } //Length: 5
	}

	public WsTransportManager() { }

	[CompilerGenerated]
	public void add_OnPushNotificationReceived(Action value) { }

	public void AddNotificationToHandle(string notificationId, Action action) { }

	[AsyncStateMachine(typeof(<CloseConnection>d__18))]
	public Task CloseConnection() { }

	[AsyncStateMachine(typeof(<EstablishConnectionToUrl>d__17))]
	public Task EstablishConnectionToUrl(WsConnectionParams connParams) { }

	public float get_DebugCurrReconnectIntervalTimer() { }

	public WsWebSender get_Sender() { }

	private void HandleConnectionClosed(CloseStatusCode code) { }

	private void HandlePushNotificationReceived(WsPushNotificationMessage message) { }

	[AsyncStateMachine(typeof(<ReconnectLoop>d__20))]
	private Task ReconnectLoop(CancellationToken ct) { }

	[CompilerGenerated]
	public void remove_OnPushNotificationReceived(Action value) { }

	public void RemoveHandlingNotification(string notificationId) { }

	public void SendNotification(BackendRequestParams reqParams) { }

	[AsyncStateMachine(typeof(<SendRequest>d__21`1))]
	public Task SendRequest(BackendRequestParams reqParams) { }

	[AsyncStateMachine(typeof(<SendRequestOnce>d__22`1))]
	private Task SendRequestOnce(BackendRequestParams reqParams) { }

}

