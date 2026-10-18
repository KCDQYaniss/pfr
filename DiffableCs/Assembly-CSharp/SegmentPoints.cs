//Type is in global namespace

public class SegmentPoints
{
	public Vector3 a; //Field offset: 0x10
	public Vector3 b; //Field offset: 0x1C

	public SegmentPoints(Vector3 a, Vector3 b) { }

	public void DebugDrawSegment(Color color, bool onSameY = true) { }

	public Vector3 Middle() { }

}

