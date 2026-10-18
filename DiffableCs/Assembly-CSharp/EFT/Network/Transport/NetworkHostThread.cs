namespace EFT.Network.Transport;

public class NetworkHostThread
{
	private struct ConnectQueueData
	{
		public int Connection; //Field offset: 0x0
		public string Address; //Field offset: 0x8
		public int Port; //Field offset: 0x10

	}

	private struct DisconnectQueueData
	{
		public int Connection; //Field offset: 0x0

	}

	private struct ReceiveQueueData
	{
		public int Connection; //Field offset: 0x0
		public NetworkMessagePooled Message; //Field offset: 0x8

	}

	private struct SendQueueData
	{
		public int Connection; //Field offset: 0x0
		public bool NeedEncrypt; //Field offset: 0x4
		public NetworkChannel Channel; //Field offset: 0x5
		public ArraySegment Buffer; //Field offset: 0x8

	}

	private const int SLEEP_TIMEOUT = 10; //Field offset: 0x0
	private const int PROCESSING_LIMIT = 2000; //Field offset: 0x0
	private const int MESSAGE_TYPE_OVERHEAD = 2; //Field offset: 0x0
	private NetworkHost _networkHost; //Field offset: 0x10
	private Thread _thread; //Field offset: 0x18
	private readonly ConcurrentQueueNonAlloc _connectQueue; //Field offset: 0x20
	private readonly ConcurrentQueueNonAlloc _disconnectQueue; //Field offset: 0x28
	private readonly ConcurrentQueueNonAlloc _receiveQueue; //Field offset: 0x30
	private readonly ConcurrentQueueNonAlloc _sendQueue; //Field offset: 0x38
	private readonly ConcurrentQueueNonAlloc _receiveErrorQueue; //Field offset: 0x40
	private readonly Dictionary _networkCryptographies; //Field offset: 0x48
	private readonly object _lockObject; //Field offset: 0x50
	private readonly HashSet _silencedConnections; //Field offset: 0x58

	public int Index
	{
		 get { } //Length: 26
	}

	public NetworkConnectionLogger Logger
	{
		 get { } //Length: 7
	}

	public NetworkHostThread(NetworkConnectConfiguration configuration, int index, int port) { }

	public int Connect(string address, int port) { }

	public bool Disconnect(int index) { }

	public int get_Index() { }

	public NetworkConnectionLogger get_Logger() { }

	public void GetConnectionInfo(int index, out string address, out int port, out byte error) { }

	public DisconnectionInformation GetDisconnectionInformation(int index) { }

	public int GetLossCount(int index, out byte error) { }

	public int GetLossPercent(int index, out byte error) { }

	public int GetRtt(int index, out byte error) { }

	public NetworkConnectionStatistics GetStatistics(int index) { }

	private void ProcessConnectQueue() { }

	private void ProcessDisconnectQueue() { }

	private void ProcessReceivedMessage(int index, NetworkMessagePooled message) { }

	private void ProcessReceivedMessages() { }

	private void ProcessSendQueue() { }

	public bool Receive(out int index, out NetworkChannel channel, out NetworkSystemMessageType systemMessageType, ref byte[] buffer, out int bufferSize) { }

	public bool ReceiveMessage(out int index, out NetworkMessagePooled message) { }

	public void RemoveNetworkCryptography(int connectionId) { }

	private void Run() { }

	private void RunInternal() { }

	private bool Send(int connection, NetworkChannel channel, ArraySegment buffer, bool takeOwnership, bool needEncrypt) { }

	public bool Send(int connection, NetworkChannel channel, byte[] buffer, int bufferSize, bool needEncrypt) { }

	public bool SendPooled(int connection, NetworkChannel channel, ArraySegment buffer, bool needEncrypt) { }

	private void SendQueuedData(SendQueueData sendQueueData) { }

	public void SetConnectionSilenced(int connectionId, bool silenced) { }

	public void SetNetworkCryptography(int connectionId, BaseNetworkCryptography networkCryptography) { }

	public void Shutdown() { }

	public bool TryDequeueReceiveError(out int connectionIndex) { }

}

