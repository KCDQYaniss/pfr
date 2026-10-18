namespace kcp2k;

public class KcpClientNonAlloc : KcpClient
{

	public KcpClientNonAlloc(Action OnConnected, Action OnData, Action OnDisconnected, Action OnError) { }

	protected virtual KcpClientConnection CreateConnection() { }

}

