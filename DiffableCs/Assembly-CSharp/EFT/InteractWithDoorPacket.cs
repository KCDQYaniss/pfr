namespace EFT;

public struct InteractWithDoorPacket
{
	public bool HasInteraction; //Field offset: 0x0
	public EInteractionType EInteractionType; //Field offset: 0x4
	public EInteractionStage Execute; //Field offset: 0x8
	public string Id; //Field offset: 0x10
	public string ItemId; //Field offset: 0x18

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(InteractWithDoorPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

