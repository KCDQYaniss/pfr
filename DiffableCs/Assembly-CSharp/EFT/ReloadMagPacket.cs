namespace EFT;

public struct ReloadMagPacket
{
	public bool Reload; //Field offset: 0x0
	public string MagId; //Field offset: 0x8
	public byte[] LocationDescription; //Field offset: 0x10

	public void Deserialize(IBitReaderStream reader) { }

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref ReloadMagPacket reloadMagPacket, ReloadMagPacket reloadMagPacket1) { }

	public void Serialize(IBitWriterStream writer) { }

	public static void SerializeDiffUsing(IBitWriterStream writer, ReloadMagPacket reloadMagPacket, ReloadMagPacket reloadMagPacket1) { }

	public virtual string ToString() { }

}

