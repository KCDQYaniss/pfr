namespace EFT.Network.Transport;

[Extension]
public static class IPEndPointNonAllocExtensions
{

	[Extension]
	public static int ReceiveFromNonAlloc(UdpSocket socket, byte[] buffer, int offset, int size, SocketFlags socketFlags, IPEndPointNonAlloc remoteEndPoint) { }

	[Extension]
	public static int ReceiveFromNonAlloc(UdpSocket socket, byte[] buffer, IPEndPointNonAlloc remoteEndPoint) { }

	[Extension]
	public static int SendToNonAlloc(UdpSocket socket, byte[] buffer, int offset, int size, SocketFlags socketFlags, IPEndPointNonAlloc remoteEndPoint) { }

}

