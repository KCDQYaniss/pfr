namespace EFT;

public struct CorpseSyncPacket
{
	private static readonly QuaternionQuantizer _rotationQuantizer; //Field offset: 0x0
	private const int TRANSFORMS_COUNT = 12; //Field offset: 0x0
	public int Id; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x4
	public bool Done; //Field offset: 0x10
	public TransformSync[] TransformSyncs; //Field offset: 0x18
	public bool IsNotValidPosition; //Field offset: 0x20

	private static CorpseSyncPacket() { }

	public void Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

