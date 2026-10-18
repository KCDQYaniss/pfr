namespace System.Net.WebSockets;

public abstract class WebSocket : IDisposable
{

	public static TimeSpan DefaultKeepAliveInterval
	{
		 get { } //Length: 137
	}

	public abstract WebSocketState State
	{
		 get { } //Length: 0
	}

	protected WebSocket() { }

	public abstract void Abort() { }

	public abstract Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	public abstract Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public static WebSocket CreateClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment internalBuffer) { }

	public abstract void Dispose() { }

	public static TimeSpan get_DefaultKeepAliveInterval() { }

	public abstract WebSocketState get_State() { }

	public abstract Task ReceiveAsync(ArraySegment buffer, CancellationToken cancellationToken) { }

}

