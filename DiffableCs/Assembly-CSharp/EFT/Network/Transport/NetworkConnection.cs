namespace EFT.Network.Transport;

public class NetworkConnection
{
	private const int CHANNEL_HEADER_SIZE = 1; //Field offset: 0x0
	private const int KCP_RESEND = 3; //Field offset: 0x0
	private const int KCP_PROCESSING_INTERVAL = 30; //Field offset: 0x0
	private const int KCP_NO_DELAY = 1; //Field offset: 0x0
	private const int TYPE_HEADER_SIZE = 1; //Field offset: 0x0
	private const int INDEX_HEADER_SIZE = 2; //Field offset: 0x0
	private ConnectionState _state; //Field offset: 0x10
	private UdpSocket _socket; //Field offset: 0x18
	private IPEndPointNonAlloc _socketAddress; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Address>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <Port>k__BackingField; //Field offset: 0x30
	private Kcp _kcp; //Field offset: 0x38
	[CompilerGenerated]
	private readonly NetworkConnectConfiguration <Configuration>k__BackingField; //Field offset: 0x40
	private readonly Stopwatch _stopwatch; //Field offset: 0x48
	private readonly NetworkStatistics _networkStatistics; //Field offset: 0x50
	public uint LastReceiveTime; //Field offset: 0x58
	private uint _lastPingTime; //Field offset: 0x5C
	private uint _lastLoseTime; //Field offset: 0x60
	private readonly byte[] _reliableMessageBuffer; //Field offset: 0x68
	private readonly byte[] _messageBuffer; //Field offset: 0x70
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly int <Hash>k__BackingField; //Field offset: 0x7C
	private ushort _unreliableIndex; //Field offset: 0x80
	private ushort _prevUnreliableIndex; //Field offset: 0x82
	public Queue SendQueue; //Field offset: 0x88
	public readonly Queue ReceiveQueue; //Field offset: 0x90

	public string Address
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NetworkConnectConfiguration Configuration
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public uint CurrentTime
	{
		 get { } //Length: 29
	}

	public int Hash
	{
		[CompilerGenerated]
		 get { } //Length: 4
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

	public int Port
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public NetworkConnection(int index, UdpSocket socket, IPEndPointNonAlloc socketAddress, NetworkConnectConfiguration configuration) { }

	public void ChangeState(ConnectionState state) { }

	public void Clear() { }

	public void Connect() { }

	public static int CreateHash(EndPoint address) { }

	public void Disconnect(byte reason) { }

	[CompilerGenerated]
	public string get_Address() { }

	[CompilerGenerated]
	public NetworkConnectConfiguration get_Configuration() { }

	public uint get_CurrentTime() { }

	[CompilerGenerated]
	public int get_Hash() { }

	[CompilerGenerated]
	public int get_Index() { }

	public NetworkConnectionLogger get_Logger() { }

	[CompilerGenerated]
	public int get_Port() { }

	public void GetInformation(out string address, out int port, out byte error) { }

	public int GetLossCount() { }

	public int GetLossPercent() { }

	public int GetRtt() { }

	public NetworkConnectionStatistics GetStatistics() { }

	public void HandelReceive(byte[] buffer, int count) { }

	public void HandelReceiveReliableFinite() { }

	private void HandelReceiveReliableInitial(byte[] buffer, int bufferSize) { }

	private void HandelReceiveUnreliable(byte[] buffer, int bufferSize) { }

	public void HandleDeadLink() { }

	public void HandleDisconnectReceiving(byte[] buffer, int count) { }

	public void HandleOverflow() { }

	public void HandlePing() { }

	public void HandlePingReceiving(byte[] buffer, int count) { }

	public void HandlePongReceiving(byte[] buffer, int count) { }

	private void HandleStatistics() { }

	public void KcpUpdate() { }

	public void LateUpdate() { }

	public bool Receive(out NetworkMessagePooled message) { }

	public void ReturnConnect() { }

	public void ReturnDisconnect(byte reason) { }

	public void Send(NetworkMessagePooled message) { }

	public void SendConnect(bool syn, bool asc) { }

	public void SendDisconnect(byte reason) { }

	public void SendFinite(NetworkMessagePooled message) { }

	public void SendPing() { }

	private void SendRaw(byte[] buffer, int count) { }

	private void SendReliableFinite(byte[] buffer, int count) { }

	private void SendReliableInitial(NetworkMessagePooled message) { }

	public void SendUnreliable(NetworkMessagePooled message) { }

	private void SetupKcp() { }

	public void Update() { }

	public void WriteStatistics() { }

}

