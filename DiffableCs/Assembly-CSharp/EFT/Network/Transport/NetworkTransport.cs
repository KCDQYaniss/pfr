namespace EFT.Network.Transport;

public class NetworkTransport
{
	private static NetworkTransport _instance; //Field offset: 0x0
	private int _hostIndex; //Field offset: 0x10
	private Dictionary _hosts; //Field offset: 0x18

	public static NetworkTransport instance
	{
		 get { } //Length: 383
	}

	public NetworkTransport() { }

	public int AddHost(NetworkConnectConfiguration configuration, int port) { }

	public int Connect(int hostIndex, string address, int port) { }

	public void Disconnect(int hostIndex, int connectionIndex) { }

	public static NetworkTransport get_instance() { }

	public void GetConnectionInfo(int hostIndex, int connectionIndex, out string address, out int port) { }

	public DisconnectionInformation GetDisconnectionReason(int hostIndex, int connectionIndex) { }

	public int GetLossCount(int hostIndex, int connectionIndex) { }

	public int GetLossPercent(int hostIndex, int connectionIndex) { }

	public int GetRtt(int hostIndex, int connectionIndex) { }

	public NetworkConnectionStatistics GetStatistics(int hostIndex, int connectionIndex) { }

	public bool Receive(int hostIndex, out int connectionIndex, out NetworkChannel channel, out NetworkSystemMessageType messageType, ref byte[] buffer, out int bufferCount) { }

	public bool ReceiveMessage(int hostIndex, out int connectionIndex, out NetworkMessagePooled message) { }

	public void RemoveHost(int hostIndex) { }

	public void RemoveNetworkCryptography(NetworkConnection connection) { }

	public void Send(int hostIndex, int connectionIndex, NetworkChannel channel, byte[] buffer, int bufferCount, bool needEncrypt) { }

	public void SendPooled(int hostIndex, int connectionIndex, NetworkChannel channel, ArraySegment buffer, bool needEncrypt) { }

	public void SetConnectionSilenced(NetworkConnection connection, bool silenced) { }

	public void SetNetworkCryptography(NetworkConnection connection, BaseNetworkCryptography networkCryptography) { }

	public void Shutdown() { }

	public bool TryDequeueReceiveError(int hostIndex, out int connectionIndex) { }

}

