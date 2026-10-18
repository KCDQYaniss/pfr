namespace EFT;

public struct InteractWithEventObjectPacket
{
	public bool hasInteraction; //Field offset: 0x0
	public int objectId; //Field offset: 0x4
	public EInteraction interaction; //Field offset: 0x8

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InteractWithEventObjectPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

