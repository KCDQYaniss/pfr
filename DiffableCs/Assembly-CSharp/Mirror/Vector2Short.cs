namespace Mirror;

public struct Vector2Short
{
	public short x; //Field offset: 0x0
	public short y; //Field offset: 0x2

	public Vector2Short(short x, short y) { }

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

