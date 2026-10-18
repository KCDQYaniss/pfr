namespace EFT;

public struct InteractWithTransitPacket
{
	public bool hasInteraction; //Field offset: 0x0
	public int pointId; //Field offset: 0x4
	public string keyId; //Field offset: 0x8
	public EDateTime time; //Field offset: 0x10

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InteractWithTransitPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

