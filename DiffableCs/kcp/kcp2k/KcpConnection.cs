namespace kcp2k;

public abstract class KcpConnection
{
	internal const int QueueDisconnectThreshold = 10000; //Field offset: 0x0
	public const int PING_INTERVAL = 1000; //Field offset: 0x0
	public const int UnreliableMaxMessageSize = 1199; //Field offset: 0x0
	private const int CHANNEL_HEADER_SIZE = 1; //Field offset: 0x0
	public const int DEFAULT_TIMEOUT = 10000; //Field offset: 0x0
	protected Socket socket; //Field offset: 0x10
	protected EndPoint remoteEndPoint; //Field offset: 0x18
	internal Kcp kcp; //Field offset: 0x20
	private KcpState state; //Field offset: 0x28
	public Action OnAuthenticated; //Field offset: 0x30
	public Action OnData; //Field offset: 0x38
	public Action OnDisconnected; //Field offset: 0x40
	public Action OnError; //Field offset: 0x48
	public int timeout; //Field offset: 0x50
	private uint lastReceiveTime; //Field offset: 0x54
	private readonly Stopwatch refTime; //Field offset: 0x58
	private byte[] kcpMessageBuffer; //Field offset: 0x60
	private byte[] kcpSendBuffer; //Field offset: 0x68
	private byte[] rawSendBuffer; //Field offset: 0x70
	private uint lastPingTime; //Field offset: 0x78

	public uint MaxReceiveRate
	{
		 get { } //Length: 48
	}

	public uint MaxSendRate
	{
		 get { } //Length: 48
	}

	public int ReceiveBufferCount
	{
		 get { } //Length: 77
	}

	public int ReceiveQueueCount
	{
		 get { } //Length: 77
	}

	public int SendBufferCount
	{
		 get { } //Length: 77
	}

	public int SendQueueCount
	{
		 get { } //Length: 77
	}

	protected KcpConnection() { }

	public void Disconnect() { }

	protected override void Dispose() { }

	public uint get_MaxReceiveRate() { }

	public uint get_MaxSendRate() { }

	public int get_ReceiveBufferCount() { }

	public int get_ReceiveQueueCount() { }

	public int get_SendBufferCount() { }

	public int get_SendQueueCount() { }

	public EndPoint GetRemoteEndPoint() { }

	private void HandleChoked() { }

	private void HandleDeadLink() { }

	private void HandlePing(uint time) { }

	private void HandleTimeout(uint time) { }

	public void RawInput(byte[] buffer, int msgLength) { }

	protected abstract void RawSend(byte[] data, int length) { }

	private void RawSendReliable(byte[] data, int length) { }

	private bool ReceiveNextReliable(out KcpHeader header, out ArraySegment message) { }

	public static int ReliableMaxMessageSize(uint rcv_wnd) { }

	private static int ReliableMaxMessageSize_Unconstrained(uint rcv_wnd) { }

	public void SendData(ArraySegment data, KcpChannel channel) { }

	private void SendDisconnect() { }

	public void SendHandshake() { }

	private void SendPing() { }

	private void SendReliable(KcpHeader header, ArraySegment content) { }

	private void SendUnreliable(ArraySegment message) { }

	protected void SetupKcp(bool noDelay, uint interval = 100, int fastResend = 0, bool congestionWindow = true, uint sendWindowSize = 32, uint receiveWindowSize = 128, int timeout = 10000, uint maxRetransmits = 20) { }

	public void TickIncoming() { }

	private void TickIncoming_Authenticated(uint time) { }

	private void TickIncoming_Connected(uint time) { }

	public void TickOutgoing() { }

}

