namespace EFT;

public struct ViewPacket
{
	public float WeaponOverlap; //Field offset: 0x0

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref ViewPacket current) { }

	public static void SerializeDiffUsing(IBitWriterStream writer, ref ViewPacket current) { }

}

