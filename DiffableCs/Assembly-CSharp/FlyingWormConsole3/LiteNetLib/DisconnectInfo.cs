namespace FlyingWormConsole3.LiteNetLib;

public struct DisconnectInfo
{
	public DisconnectReason Reason; //Field offset: 0x0
	public SocketError SocketErrorCode; //Field offset: 0x4
	public NetPacketReader AdditionalData; //Field offset: 0x8

}

