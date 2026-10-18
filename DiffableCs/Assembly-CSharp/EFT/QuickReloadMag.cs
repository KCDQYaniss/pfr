namespace EFT;

public struct QuickReloadMag
{
	public bool Reload; //Field offset: 0x0
	public MongoID MagId; //Field offset: 0x8

	private void Deserialize(IBitReaderStream reader) { }

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref QuickReloadMag quickReloadMagPacket, QuickReloadMag quickReloadMag) { }

	private void Serialize(IBitWriterStream writer) { }

	public static void SerializeDiffUsing(IBitWriterStream writer, QuickReloadMag quickReloadMagPacket, QuickReloadMag quickReloadMag) { }

	public virtual string ToString() { }

}

