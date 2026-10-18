namespace EFT.Network;

public class NetworkServer : AbstractNetwork
{
	private static NetworkServer _defaultInstance; //Field offset: 0x0
	private Dictionary _connections; //Field offset: 0x30

	public static NetworkServer Default
	{
		 get { } //Length: 397
	}

	public NetworkServer() { }

	public static NetworkServer get_Default() { }

	public bool Listen(int port) { }

	protected virtual void OnConnect(int connectionIndex) { }

	protected virtual void OnData(int connectionIndex, NetworkChannel channel, byte[] buffer, int bufferOffset, int bufferCount) { }

	protected virtual void OnDisconnect(int connectionIndex) { }

	protected virtual void OnPacketProcessingError(int connectionIndex) { }

	public void Shutdown() { }

}

