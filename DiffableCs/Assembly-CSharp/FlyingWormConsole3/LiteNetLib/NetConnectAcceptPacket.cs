namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetConnectAcceptPacket
{
	public const int Size = 11; //Field offset: 0x0
	public readonly long ConnectionId; //Field offset: 0x10
	public readonly byte ConnectionNumber; //Field offset: 0x18
	public readonly bool IsReusedPeer; //Field offset: 0x19

	private NetConnectAcceptPacket(long connectionId, byte connectionNumber, bool isReusedPeer) { }

	public static NetConnectAcceptPacket FromData(NetPacket packet) { }

	public static NetPacket Make(long connectId, byte connectNum, bool reusedPeer) { }

}

