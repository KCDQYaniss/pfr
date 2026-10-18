namespace FlyingWormConsole3.LiteNetLib.Layers;

public class XorEncryptLayer : PacketLayerBase
{
	private byte[] _byteKey; //Field offset: 0x18

	public XorEncryptLayer() { }

	public XorEncryptLayer(byte[] key) { }

	public XorEncryptLayer(string key) { }

	public virtual void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }

	public virtual void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length) { }

	public void SetKey(string key) { }

	public void SetKey(byte[] key) { }

}

