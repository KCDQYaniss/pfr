namespace Mirror;

public struct Vector2Byte
{
	public byte x; //Field offset: 0x0
	public byte y; //Field offset: 0x1

	public Vector2Byte(byte x, byte y) { }

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

