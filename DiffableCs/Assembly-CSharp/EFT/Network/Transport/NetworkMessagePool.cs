namespace EFT.Network.Transport;

public static class NetworkMessagePool
{
	private static readonly ConcurrentPool _pool; //Field offset: 0x0
	private static readonly ArrayPool _bytePool; //Field offset: 0x8

	private static NetworkMessagePool() { }

	public static NetworkMessagePooled Create() { }

	public static NetworkMessagePooled Get(NetworkChannel channel, NetworkSystemMessageType type, ArraySegment buffer) { }

	public static NetworkMessagePooled Get(NetworkChannel channel, NetworkSystemMessageType type, byte[] buffer) { }

	public static NetworkMessagePooled Get(NetworkChannel channel, NetworkSystemMessageType type, byte[] buffer, int offset, int count) { }

	public static NetworkMessagePooled GetPooledNoCopy(NetworkChannel channel, NetworkSystemMessageType type, ArraySegment buffer) { }

	public static void Return(NetworkMessagePooled messageSegment) { }

}

