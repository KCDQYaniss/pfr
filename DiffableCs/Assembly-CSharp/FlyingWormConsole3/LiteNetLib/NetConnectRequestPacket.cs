namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetConnectRequestPacket
{
	public const int HeaderSize = 14; //Field offset: 0x0
	public readonly long ConnectionTime; //Field offset: 0x10
	public readonly byte ConnectionNumber; //Field offset: 0x18
	public readonly byte[] TargetAddress; //Field offset: 0x20
	public readonly NetDataReader Data; //Field offset: 0x28

	private NetConnectRequestPacket(long connectionTime, byte connectionNumber, byte[] targetAddress, NetDataReader data) { }

	public static NetConnectRequestPacket FromData(NetPacket packet) { }

	public static int GetProtocolId(NetPacket packet) { }

	public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectId) { }

}

