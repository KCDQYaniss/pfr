namespace kcp2k;

public class KcpClientConnection : KcpConnection
{
	private readonly byte[] rawReceiveBuffer; //Field offset: 0x80

	public KcpClientConnection() { }

	private void ConfigureSocketBufferSizes(bool maximizeSendReceiveBuffersToOSLimit) { }

	public void Connect(string host, ushort port, bool noDelay, uint interval = 100, int fastResend = 0, bool congestionWindow = true, uint sendWindowSize = 32, uint receiveWindowSize = 128, int timeout = 10000, uint maxRetransmits = 20, bool maximizeSendReceiveBuffersToOSLimit = false) { }

	protected override void CreateRemoteEndPoint(IPAddress[] addresses, ushort port) { }

	protected override void CreateRemoteEndPoint(string addresses, ushort port) { }

	protected virtual void Dispose() { }

	public void RawReceive() { }

	protected virtual void RawSend(byte[] data, int length) { }

	protected override int ReceiveFrom(byte[] buffer) { }

	public static bool ResolveHostname(string hostname, out IPAddress[] addresses) { }

}

