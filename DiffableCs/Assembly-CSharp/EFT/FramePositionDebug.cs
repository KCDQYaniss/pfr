namespace EFT;

public struct FramePositionDebug
{
	public bool HasData; //Field offset: 0x0
	public int Id; //Field offset: 0x4
	public KeyValuePair[] fp; //Field offset: 0x8

	public static FramePositionDebug Deserialize(IBitReaderStream reader) { }

	public static void Serialize(FramePositionDebug info, IBitWriterStream writer) { }

	public virtual string ToString() { }

}

