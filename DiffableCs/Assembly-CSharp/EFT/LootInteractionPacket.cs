namespace EFT;

public struct LootInteractionPacket
{
	public bool Interact; //Field offset: 0x0
	public string LootId; //Field offset: 0x8
	public uint CallbackId; //Field offset: 0x10

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(LootInteractionPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

