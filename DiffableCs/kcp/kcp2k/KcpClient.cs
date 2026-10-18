namespace kcp2k;

public class KcpClient
{
	public Action OnConnected; //Field offset: 0x10
	public Action OnData; //Field offset: 0x18
	public Action OnDisconnected; //Field offset: 0x20
	public Action OnError; //Field offset: 0x28
	public KcpClientConnection connection; //Field offset: 0x30
	public bool connected; //Field offset: 0x38

	public KcpClient(Action OnConnected, Action OnData, Action OnDisconnected, Action OnError) { }

	[CompilerGenerated]
	private void <Connect>b__8_0() { }

	[CompilerGenerated]
	private void <Connect>b__8_1(ArraySegment message, KcpChannel channel) { }

	[CompilerGenerated]
	private void <Connect>b__8_2() { }

	[CompilerGenerated]
	private void <Connect>b__8_3(ErrorCode error, string reason) { }

	public void Connect(string address, ushort port, bool noDelay, uint interval, int fastResend = 0, bool congestionWindow = true, uint sendWindowSize = 32, uint receiveWindowSize = 128, int timeout = 10000, uint maxRetransmits = 20, bool maximizeSendReceiveBuffersToOSLimit = false) { }

	protected override KcpClientConnection CreateConnection() { }

	public void Disconnect() { }

	public void Send(ArraySegment segment, KcpChannel channel) { }

	public void Tick() { }

	public void TickIncoming() { }

	public void TickOutgoing() { }

}

