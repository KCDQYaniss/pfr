namespace EFT;

public struct InventoryCommandPacket
{
	private const int MAX_CALLBACK_ID = 2047; //Field offset: 0x0
	public byte[] CommandBytes; //Field offset: 0x0
	public uint CallbackId; //Field offset: 0x8
	public int InventoryHashSum; //Field offset: 0xC

	public void Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

