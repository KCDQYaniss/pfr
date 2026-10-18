namespace WhereAllocation;

[Extension]
public static class Extensions
{

	[Extension]
	public static int ReceiveFrom_NonAlloc(Socket socket, byte[] buffer, int offset, int size, SocketFlags socketFlags, IPEndPointNonAlloc remoteEndPoint) { }

	[Extension]
	public static int ReceiveFrom_NonAlloc(Socket socket, byte[] buffer, IPEndPointNonAlloc remoteEndPoint) { }

	[Extension]
	public static int SendTo_NonAlloc(Socket socket, byte[] buffer, int offset, int size, SocketFlags socketFlags, IPEndPointNonAlloc remoteEndPoint) { }

}

