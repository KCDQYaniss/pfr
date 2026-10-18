namespace System.Net.WebSockets;

public sealed class ClientWebSocket : WebSocket
{
	[CompilerGenerated]
	private struct <ConnectAsyncCore>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientWebSocket <>4__this; //Field offset: 0x20
		public Uri uri; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public sealed class DefaultWebProxy : IWebProxy
	{
		[CompilerGenerated]
		private static readonly DefaultWebProxy <Instance>k__BackingField; //Field offset: 0x0

		public override ICredentials Credentials
		{
			 get { } //Length: 62
		}

		public static DefaultWebProxy Instance
		{
			[CompilerGenerated]
			 get { } //Length: 83
		}

		private static DefaultWebProxy() { }

		public DefaultWebProxy() { }

		public override ICredentials get_Credentials() { }

		[CompilerGenerated]
		public static DefaultWebProxy get_Instance() { }

		public override Uri GetProxy(Uri destination) { }

		public override bool IsBypassed(Uri host) { }

	}

	private enum InternalState
	{
		Created = 0,
		Connecting = 1,
		Connected = 2,
		Disposed = 3,
	}

	private readonly ClientWebSocketOptions _options; //Field offset: 0x10
	private WebSocketHandle _innerWebSocket; //Field offset: 0x18
	private int _state; //Field offset: 0x20

	public ClientWebSocketOptions Options
	{
		 get { } //Length: 5
	}

	public virtual WebSocketState State
	{
		 get { } //Length: 189
	}

	public ClientWebSocket() { }

	public virtual void Abort() { }

	public virtual Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public virtual Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ConnectAsyncCore>d__16))]
	private Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken) { }

	public virtual void Dispose() { }

	public ClientWebSocketOptions get_Options() { }

	public virtual WebSocketState get_State() { }

	public virtual Task ReceiveAsync(ArraySegment buffer, CancellationToken cancellationToken) { }

	private void ThrowIfNotConnected() { }

}

