namespace EFT;

public struct FireModePacket
{
	public bool ChangeFireMode; //Field offset: 0x0
	public EFireMode FireMode; //Field offset: 0x1

	public static void DeserializeDiffUsing(IBitReaderStream reader, ref FireModePacket fireModePacket) { }

	public static void SerializeDiffUsing(IBitWriterStream writer, FireModePacket fireModePacket) { }

	public virtual string ToString() { }

}

