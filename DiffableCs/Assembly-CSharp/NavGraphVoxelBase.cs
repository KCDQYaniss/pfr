//Type is in global namespace

public abstract class NavGraphVoxelBase
{
	public const float SIZE = 10; //Field offset: 0x0
	public const float SIZE_Y = 5; //Field offset: 0x0
	public Vector3 Position; //Field offset: 0x10
	public ushort IndexX; //Field offset: 0x1C
	public ushort IndexZ; //Field offset: 0x1E
	public ushort IndexY; //Field offset: 0x20
	public ushort Id; //Field offset: 0x22

	protected NavGraphVoxelBase(Vector3 pos, int indexX, int indexY, int indexZ, int id) { }

}

