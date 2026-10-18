namespace FlyingWormConsole3.LiteNetLib;

public static class NetConstants
{
	public const int DefaultWindowSize = 64; //Field offset: 0x0
	public const int SocketBufferSize = 1048576; //Field offset: 0x0
	public const int SocketTTL = 255; //Field offset: 0x0
	public const int HeaderSize = 1; //Field offset: 0x0
	public const int ChanneledHeaderSize = 4; //Field offset: 0x0
	public const int FragmentHeaderSize = 6; //Field offset: 0x0
	public const int FragmentedHeaderTotalSize = 10; //Field offset: 0x0
	public const ushort MaxSequence = 32768; //Field offset: 0x0
	public const ushort HalfMaxSequence = 16384; //Field offset: 0x0
	internal const int ProtocolId = 11; //Field offset: 0x0
	internal const int MaxUdpHeaderSize = 68; //Field offset: 0x0
	internal static readonly int[] PossibleMtu; //Field offset: 0x0
	public const byte MaxConnectionNumber = 4; //Field offset: 0x0
	public const int PacketPoolSize = 1000; //Field offset: 0x0
	internal static readonly int MaxPacketSize; //Field offset: 0x8

	private static NetConstants() { }

}

