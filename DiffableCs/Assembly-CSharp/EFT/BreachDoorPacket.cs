namespace EFT;

public struct BreachDoorPacket
{
	public bool Breach; //Field offset: 0x0
	public string Id; //Field offset: 0x8

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(BreachDoorPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

