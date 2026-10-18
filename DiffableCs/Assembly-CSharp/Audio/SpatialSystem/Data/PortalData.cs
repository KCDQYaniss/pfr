namespace Audio.SpatialSystem.Data;

public struct PortalData
{
	public int id; //Field offset: 0x0
	public Vector3 position; //Field offset: 0x4
	public Vector3 normal; //Field offset: 0x10
	public float cost; //Field offset: 0x1C
	public float depth; //Field offset: 0x20
	public byte state; //Field offset: 0x24
	public short startIndex; //Field offset: 0x26
	public short indoorRoomsCount; //Field offset: 0x28

	public PortalData(int id, Vector3 position, Vector3 normal, float cost, byte state, float depth, short startIndex, short indoorRoomsCount) { }

	public static PortalData Default() { }

}

