namespace EFT;

public struct InventoryInteractionPacket
{
	public bool HasCriticalData; //Field offset: 0x0
	public bool Inventory; //Field offset: 0x1
	public bool IsOperation; //Field offset: 0x2

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InventoryInteractionPacket other) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

