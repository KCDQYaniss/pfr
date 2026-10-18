namespace EFT;

public struct InteractWithBtrPacket
{
	public bool HasInteraction; //Field offset: 0x0
	public EInteractionType InteractionType; //Field offset: 0x4
	public byte SideId; //Field offset: 0x8
	public byte SlotId; //Field offset: 0x9
	public bool Fast; //Field offset: 0xA

	public void Deserialize(IBitReaderStream reader) { }

	public void Deserialize(NetworkReader reader) { }

	public bool Equals(InteractWithBtrPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

