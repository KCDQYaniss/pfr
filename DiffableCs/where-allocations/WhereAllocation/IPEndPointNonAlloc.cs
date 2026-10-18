namespace WhereAllocation;

public class IPEndPointNonAlloc : IPEndPoint
{
	public SocketAddress temp; //Field offset: 0x20

	public IPEndPointNonAlloc(long address, int port) { }

	public IPEndPointNonAlloc(IPAddress address, int port) { }

	public virtual EndPoint Create(SocketAddress socketAddress) { }

	public IPEndPoint DeepCopyIPEndPoint() { }

	public virtual int GetHashCode() { }

	public virtual SocketAddress Serialize() { }

}

