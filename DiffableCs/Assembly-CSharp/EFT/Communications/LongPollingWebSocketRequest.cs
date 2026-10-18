namespace EFT.Communications;

internal sealed class LongPollingWebSocketRequest : LongPollingRequestAbstract
{
	[CompilerGenerated]
	private struct <Execute>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LongPollingWebSocketRequest <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private ClientWebSocket <webSocket>5__2; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Receive>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LongPollingWebSocketRequest <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public WebSocket webSocket; //Field offset: 0x30
		private byte[] <buffer>5__2; //Field offset: 0x38
		private MemoryStream <stream>5__3; //Field offset: 0x40
		private WebSocketReceiveResult <result>5__4; //Field offset: 0x48
		private int <received>5__5; //Field offset: 0x50
		private byte[] <bytes>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LongPollingWebSocketRequest <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private CancellationTokenSource _tokenSource; //Field offset: 0x38
	private bool _isQuitting; //Field offset: 0x40

	public virtual ENotificationTransportType TransportType
	{
		 get { } //Length: 6
	}

	protected virtual string TypeName
	{
		 get { } //Length: 49
	}

	internal LongPollingWebSocketRequest(string uri = null, IReadOnlyDictionary uriParams = null, IReadOnlyDictionary requestHeaders = null) { }

	protected virtual void Connect() { }

	protected virtual void Disconnect() { }

	[AsyncStateMachine(typeof(<Execute>d__11))]
	private Task Execute(CancellationToken token) { }

	public virtual ENotificationTransportType get_TransportType() { }

	protected virtual string get_TypeName() { }

	private void OnApplicationQuitting() { }

	[AsyncStateMachine(typeof(<Receive>d__12))]
	private Task Receive(WebSocket webSocket, CancellationToken token) { }

	[AsyncStateMachine(typeof(<Run>d__10))]
	private Task Run(CancellationToken token) { }

}

