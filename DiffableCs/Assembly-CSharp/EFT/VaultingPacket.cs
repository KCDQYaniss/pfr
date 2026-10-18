namespace EFT;

public struct VaultingPacket
{
	public bool HasCriticalData; //Field offset: 0x0
	public EVaultingStrategy VaultingStrategy; //Field offset: 0x4
	public Vector3 VaultingPoint; //Field offset: 0x8
	public float VaultingSpeed; //Field offset: 0x14
	public float VaultingHeight; //Field offset: 0x18
	public float VaultingLength; //Field offset: 0x1C
	public float BehindObstacleHeight; //Field offset: 0x20
	public float AbsoluteForwardVelocity; //Field offset: 0x24

	public void Deserialize(IBitReaderStream reader) { }

	public bool Equals(VaultingPacket other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void Serialize(IBitWriterStream writer) { }

}

