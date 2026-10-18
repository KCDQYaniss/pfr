namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetSocket
{
	public const int ReceivePollingTime = 500000; //Field offset: 0x0
	private const int SioUdpConnreset = -1744830452; //Field offset: 0x0
	private static readonly IPAddress MulticastAddressV6; //Field offset: 0x0
	internal static readonly bool IPv6Support; //Field offset: 0x8
	private Socket _udpSocketv4; //Field offset: 0x10
	private Socket _udpSocketv6; //Field offset: 0x18
	private Thread _threadv4; //Field offset: 0x20
	private Thread _threadv6; //Field offset: 0x28
	private IPEndPoint _bufferEndPointv4; //Field offset: 0x30
	private IPEndPoint _bufferEndPointv6; //Field offset: 0x38
	private readonly NetManager _listener; //Field offset: 0x40
	[CompilerGenerated]
	private int <LocalPort>k__BackingField; //Field offset: 0x48
	public bool IsRunning; //Field offset: 0x4C

	public private int LocalPort
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public short Ttl
	{
		 get { } //Length: 421
		 set { } //Length: 73
	}

	private static NetSocket() { }

	public NetSocket(NetManager listener) { }

	public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode) { }

	private bool BindSocket(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode) { }

	public void Close(bool suspend) { }

	[CompilerGenerated]
	public int get_LocalPort() { }

	public short get_Ttl() { }

	private bool IsActive() { }

	public void ManualReceive() { }

	private bool ManualReceive(Socket socket, EndPoint bufferEndPoint) { }

	private bool ProcessError(SocketException ex, EndPoint bufferEndPoint) { }

	private void ReceiveLogic(object state) { }

	public bool SendBroadcast(byte[] data, int offset, int size, int port) { }

	public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode) { }

	[CompilerGenerated]
	private void set_LocalPort(int value) { }

	public void set_Ttl(short value) { }

}

