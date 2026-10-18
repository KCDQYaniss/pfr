namespace FlyingWormConsole3.LiteNetLib;

internal sealed class NetPacketPool
{
	private NetPacket _head; //Field offset: 0x10
	private int _count; //Field offset: 0x18
	private readonly object _lock; //Field offset: 0x20

	public NetPacketPool() { }

	public NetPacket GetPacket(int size) { }

	public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length) { }

	public NetPacket GetWithProperty(PacketProperty property, int size) { }

	public NetPacket GetWithProperty(PacketProperty property) { }

	public void Recycle(NetPacket packet) { }

}

