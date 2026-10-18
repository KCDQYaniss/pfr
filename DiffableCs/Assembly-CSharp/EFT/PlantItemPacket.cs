namespace EFT;

public struct PlantItemPacket
{
	public bool Successful; //Field offset: 0x0
	public string ItemId; //Field offset: 0x8
	public string ZoneId; //Field offset: 0x10

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(PlantItemPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

