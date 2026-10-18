namespace EFT.Network.Transport;

public class NetworkHost
{
	private Dictionary _connectionsByIndex; //Field offset: 0x10
	private Dictionary _connectionsByHash; //Field offset: 0x18
	private Dictionary _disconnectionInformationByIndex; //Field offset: 0x20
	private int _connectionsIndex; //Field offset: 0x28
	private UdpSocket _socket; //Field offset: 0x30
	private IPEndPointNonAlloc _address; //Field offset: 0x38
	private IPEndPoint _copyAddress; //Field offset: 0x40
	private NetworkConnectConfiguration _configuration; //Field offset: 0x48
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x50
	private readonly byte[] _buffer; //Field offset: 0x58
	private int _bufferCount; //Field offset: 0x60
	private Stopwatch _timeoutSw; //Field offset: 0x68
	private List _connectionsToRemove; //Field offset: 0x70

	private bool ConnectionLimitExceeded
	{
		private get { } //Length: 83
	}

	public int Index
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public NetworkConnectionLogger Logger
	{
		 get { } //Length: 7
	}

	public int NextConnectionIndex
	{
		 get { } //Length: 10
	}

	public NetworkHost(NetworkConnectConfiguration configuration, int index, int port) { }

	private NetworkConnection AddConnection(int index, IPEndPointNonAlloc address) { }

	private void CompleteRemovalConnection() { }

	public int Connect(int index, string address, int port, out byte error) { }

	public bool Disconnect(int index, out byte error) { }

	public int EarlyUpdate(float maxSpendTime) { }

	private bool get_ConnectionLimitExceeded() { }

	[CompilerGenerated]
	public int get_Index() { }

	public NetworkConnectionLogger get_Logger() { }

	public int get_NextConnectionIndex() { }

	public void GetConnectionInfo(int index, out string address, out int port, out byte error) { }

	public DisconnectionInformation GetDisconnectionInformation(int index) { }

	public int GetLossCount(int index, out byte error) { }

	public int GetLossPercent(int index, out byte error) { }

	public int GetRtt(int index, out byte error) { }

	public NetworkConnectionStatistics GetStatistics(int index) { }

	private void HandleDisconnected(NetworkConnection connection, ArraySegment buffer) { }

	public void LateUpdate() { }

	public bool Receive(out int index, out NetworkMessagePooled message, out byte error) { }

	private void RemoveConnection(NetworkConnection connection) { }

	public bool Send(int index, NetworkMessagePooled message, out byte error) { }

	public void Shutdown() { }

	private bool TryGetConnection(Dictionary dictionary, int key, out NetworkConnection connection, out byte error) { }

	private bool TryGetConnectionByAddress(EndPoint address, out NetworkConnection connection, out byte error) { }

	private bool TryGetConnectionByIndex(int key, out NetworkConnection connection, out byte error) { }

}

