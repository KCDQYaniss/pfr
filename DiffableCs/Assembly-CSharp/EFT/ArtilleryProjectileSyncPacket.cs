namespace EFT;

public struct ArtilleryProjectileSyncPacket
{
	public int id; //Field offset: 0x0
	public Vector3 position; //Field offset: 0x4
	public bool explosion; //Field offset: 0x10

	public void Deserialize(IBitReaderStream reader, ArtilleryProjectileSyncPacket previousPacket) { }

	public void Deserialize(IBitReaderStream reader) { }

	private void Deserialize(IBitReaderStream reader, bool hasPreviousPacket, ArtilleryProjectileSyncPacket previousPacket) { }

	public void Serialize(IBitWriterStream writer, ArtilleryProjectileSyncPacket previousPacket) { }

	public void Serialize(IBitWriterStream writer) { }

	public void Serialize(IBitWriterStream writer, bool hasPreviousPacket, ArtilleryProjectileSyncPacket previousPacket) { }

}

