namespace kcp2k;

public class KcpServerNonAlloc : KcpServer
{
	private IPEndPointNonAlloc reusableClientEP; //Field offset: 0x78

	public KcpServerNonAlloc(Action OnConnected, Action OnData, Action OnDisconnected, Action OnError, bool DualMode, bool NoDelay, uint Interval, int FastResend = 0, bool CongestionWindow = true, uint SendWindowSize = 32, uint ReceiveWindowSize = 128, int Timeout = 10000, uint MaxRetransmits = 20, bool MaximizeSendReceiveBuffersToOSLimit = false) { }

	protected virtual KcpServerConnection CreateConnection() { }

	protected virtual int ReceiveFrom(byte[] buffer, out int connectionHash) { }

}

