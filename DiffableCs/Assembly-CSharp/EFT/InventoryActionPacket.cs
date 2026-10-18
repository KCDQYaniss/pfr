namespace EFT;

public struct InventoryActionPacket
{
	internal enum ETag
	{
		Command = 1,
		Status = 2,
	}

	public ETag Tag; //Field offset: 0x0
	public InventoryCommandPacket CommandPacket; //Field offset: 0x8
	public InventoryOperationStatus StatusPacket; //Field offset: 0x18

	public void Deserialize(IBitReaderStream reader) { }

	public void Serialize(IBitWriterStream writer) { }

}

