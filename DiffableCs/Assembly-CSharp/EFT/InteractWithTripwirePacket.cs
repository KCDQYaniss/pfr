namespace EFT;

public struct InteractWithTripwirePacket
{
	public bool HasInteraction; //Field offset: 0x0
	public int Id; //Field offset: 0x4

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InteractWithTripwirePacket other) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

