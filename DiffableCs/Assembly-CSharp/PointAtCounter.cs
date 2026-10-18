//Type is in global namespace

public class PointAtCounter
{
	private static int _idInc; //Field offset: 0x0
	public CoverLevel CoverLevel; //Field offset: 0x10
	public Vector3 FirePosition; //Field offset: 0x14
	public Vector3 PointHit; //Field offset: 0x20
	public Vector3 Pos; //Field offset: 0x2C
	public Nullable AltPos; //Field offset: 0x38
	public Vector3 WallDirection; //Field offset: 0x48
	public int Id; //Field offset: 0x54
	public bool AlwaysGood; //Field offset: 0x58
	public PointWithNeighborType NeighborType; //Field offset: 0x5C
	public float MagnitudeForSort; //Field offset: 0x60
	public NavPoint Point; //Field offset: 0x68
	public int CorePoint; //Field offset: 0x70

	public PointAtCounter(NavPoint point, Vector3 pos, Vector3 wallDirection, int corePoint) { }

}

