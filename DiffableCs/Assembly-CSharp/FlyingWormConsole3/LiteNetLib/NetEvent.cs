namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetEvent
{
	internal enum EType
	{
		Connect = 0,
		Disconnect = 1,
		Receive = 2,
		ReceiveUnconnected = 3,
		Error = 4,
		ConnectionLatencyUpdated = 5,
		Broadcast = 6,
		ConnectionRequest = 7,
		MessageDelivered = 8,
	}

	public NetEvent Next; //Field offset: 0x10
	public EType Type; //Field offset: 0x18
	public NetPeer Peer; //Field offset: 0x20
	public IPEndPoint RemoteEndPoint; //Field offset: 0x28
	public object UserData; //Field offset: 0x30
	public int Latency; //Field offset: 0x38
	public SocketError ErrorCode; //Field offset: 0x3C
	public DisconnectReason DisconnectReason; //Field offset: 0x40
	public ConnectionRequest ConnectionRequest; //Field offset: 0x48
	public DeliveryMethod DeliveryMethod; //Field offset: 0x50
	public readonly NetPacketReader DataReader; //Field offset: 0x58

	public NetEvent(NetManager manager) { }

}

