namespace Mirror;

public struct Vector3Byte
{
	public byte x; //Field offset: 0x0
	public byte y; //Field offset: 0x1
	public byte z; //Field offset: 0x2

	public Vector3Byte(byte x, byte y, byte z) { }

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

