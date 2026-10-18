namespace EFT;

public struct InteractionPacket
{
	public bool HasCriticalData; //Field offset: 0x0
	public bool ResetGesture; //Field offset: 0x1
	public EInteraction Interaction; //Field offset: 0x2

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InteractionPacket other) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

