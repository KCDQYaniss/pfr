//Type is in global namespace

public class PointWithSegment
{
	public NavPoint Point; //Field offset: 0x10
	public AIPointsCounterSegment Segment; //Field offset: 0x18

	public PointWithSegment(NavPoint key, AIPointsCounterSegment aIPointsCounterSegment) { }

	public bool CreatedPoint(PointAtCounter np1) { }

	public Vector3 GetDirection() { }

	public float GetSDist() { }

}

