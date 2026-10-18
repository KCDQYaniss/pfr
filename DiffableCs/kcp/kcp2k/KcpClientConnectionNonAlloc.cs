namespace kcp2k;

public class KcpClientConnectionNonAlloc : KcpClientConnection
{
	private IPEndPointNonAlloc reusableEP; //Field offset: 0x88

	public KcpClientConnectionNonAlloc() { }

	protected virtual void CreateRemoteEndPoint(IPAddress[] addresses, ushort port) { }

	protected virtual int ReceiveFrom(byte[] buffer) { }

}

