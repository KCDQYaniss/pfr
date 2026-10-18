namespace EFT;

public struct LeftHandPacket
{
	public bool HasCriticalData; //Field offset: 0x0
	public string ItemId; //Field offset: 0x8
	public bool Remove; //Field offset: 0x10
	public float RemoveSpeed; //Field offset: 0x14

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(LeftHandPacket other) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

