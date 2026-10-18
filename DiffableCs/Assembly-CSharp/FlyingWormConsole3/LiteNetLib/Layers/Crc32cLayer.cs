namespace FlyingWormConsole3.LiteNetLib.Layers;

public sealed class Crc32cLayer : PacketLayerBase
{

	public Crc32cLayer() { }

	public virtual void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }

	public virtual void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }

}

