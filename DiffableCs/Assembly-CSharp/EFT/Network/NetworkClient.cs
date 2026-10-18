namespace EFT.Network;

public class NetworkClient : AbstractNetwork
{
	private static NetworkClient _defaultInstance; //Field offset: 0x0
	private NetworkConnection _connection; //Field offset: 0x30

	public NetworkConnection Connection
	{
		 get { } //Length: 76
	}

	public static NetworkClient Default
	{
		 get { } //Length: 215
	}

	public NetworkClient() { }

	public void Connect(string address, int port) { }

	public NetworkConnection get_Connection() { }

	public static NetworkClient get_Default() { }

	protected virtual void OnConnect(int connectionIndex) { }

	protected virtual void OnData(int connectionIndex, NetworkChannel channel, byte[] buffer, int bufferOffset, int bufferCount) { }

	protected virtual void OnDisconnect(int connectionIndex) { }

	public void Shutdown() { }

}

