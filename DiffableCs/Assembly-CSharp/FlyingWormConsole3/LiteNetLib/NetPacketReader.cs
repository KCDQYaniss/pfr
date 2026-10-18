namespace FlyingWormConsole3.LiteNetLib;

public sealed class NetPacketReader : NetDataReader
{
	private NetPacket _packet; //Field offset: 0x28
	private readonly NetManager _manager; //Field offset: 0x30
	private readonly NetEvent _evt; //Field offset: 0x38

	internal NetPacketReader(NetManager manager, NetEvent evt) { }

	public void Recycle() { }

	internal void RecycleInternal() { }

	internal void SetSource(NetPacket packet, int headerSize) { }

}

