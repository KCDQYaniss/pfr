namespace kcp2k;

public class KcpServerConnectionNonAlloc : KcpServerConnection
{
	private IPEndPointNonAlloc reusableSendEndPoint; //Field offset: 0x80

	public KcpServerConnectionNonAlloc(Socket socket, EndPoint remoteEndpoint, IPEndPointNonAlloc reusableSendEndPoint, bool noDelay, uint interval = 100, int fastResend = 0, bool congestionWindow = true, uint sendWindowSize = 32, uint receiveWindowSize = 128, int timeout = 10000, uint maxRetransmits = 20) { }

	protected virtual void RawSend(byte[] data, int length) { }

}

