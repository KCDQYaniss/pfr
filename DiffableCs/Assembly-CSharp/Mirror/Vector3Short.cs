namespace Mirror;

public struct Vector3Short
{
	public short x; //Field offset: 0x0
	public short y; //Field offset: 0x2
	public short z; //Field offset: 0x4

	public Vector3Short(short x, short y, short z) { }

	public void Deserialize(NetworkReader reader) { }

	public void Serialize(NetworkWriter writer) { }

}

