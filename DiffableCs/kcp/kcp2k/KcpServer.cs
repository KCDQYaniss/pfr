namespace kcp2k;

public class KcpServer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public int connectionId; //Field offset: 0x10
		public KcpServer <>4__this; //Field offset: 0x18
		public Action <>9__1; //Field offset: 0x20
		public Action <>9__2; //Field offset: 0x28
		public Action <>9__3; //Field offset: 0x30

		public <>c__DisplayClass28_0() { }

		internal void <TickIncoming>b__1(ArraySegment message, KcpChannel channel) { }

		internal void <TickIncoming>b__2() { }

		internal void <TickIncoming>b__3(ErrorCode error, string reason) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_1
	{
		public KcpServerConnection connection; //Field offset: 0x10
		public <>c__DisplayClass28_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass28_1() { }

		internal void <TickIncoming>b__0() { }

	}

	public Action OnConnected; //Field offset: 0x10
	public Action OnData; //Field offset: 0x18
	public Action OnDisconnected; //Field offset: 0x20
	public Action OnError; //Field offset: 0x28
	public bool DualMode; //Field offset: 0x30
	public bool MaximizeSendReceiveBuffersToOSLimit; //Field offset: 0x31
	public bool NoDelay; //Field offset: 0x32
	public uint Interval; //Field offset: 0x34
	public int FastResend; //Field offset: 0x38
	public bool CongestionWindow; //Field offset: 0x3C
	public uint SendWindowSize; //Field offset: 0x40
	public uint ReceiveWindowSize; //Field offset: 0x44
	public int Timeout; //Field offset: 0x48
	public uint MaxRetransmits; //Field offset: 0x4C
	protected Socket socket; //Field offset: 0x50
	private EndPoint newClientEP; //Field offset: 0x58
	private readonly byte[] rawReceiveBuffer; //Field offset: 0x60
	public Dictionary connections; //Field offset: 0x68
	private HashSet connectionsToRemove; //Field offset: 0x70

	public KcpServer(Action OnConnected, Action OnData, Action OnDisconnected, Action OnError, bool DualMode, bool NoDelay, uint Interval, int FastResend = 0, bool CongestionWindow = true, uint SendWindowSize = 32, uint ReceiveWindowSize = 128, int Timeout = 10000, uint MaxRetransmits = 20, bool MaximizeSendReceiveBuffersToOSLimit = false) { }

	private void ConfigureSocketBufferSizes() { }

	protected override KcpServerConnection CreateConnection() { }

	public void Disconnect(int connectionId) { }

	public IPEndPoint GetClientEndPoint(int connectionId) { }

	public bool IsActive() { }

	protected override int ReceiveFrom(byte[] buffer, out int connectionHash) { }

	public void Send(int connectionId, ArraySegment segment, KcpChannel channel) { }

	public void Start(ushort port) { }

	public void Stop() { }

	public void Tick() { }

	public void TickIncoming() { }

	public void TickOutgoing() { }

}

