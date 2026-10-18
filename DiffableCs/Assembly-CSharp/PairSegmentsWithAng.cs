//Type is in global namespace

public class PairSegmentsWithAng
{
	public AIPointsCounterSegment S1; //Field offset: 0x10
	public AIPointsCounterSegment S2; //Field offset: 0x18
	public NavPoint Center; //Field offset: 0x20
	public float Ang; //Field offset: 0x28

	public PairSegmentsWithAng(AIPointsCounterSegment s1, AIPointsCounterSegment s2) { }

	private float CalcAng(AIPointsCounterSegment s1, AIPointsCounterSegment s2) { }

	public void DebugDraw(float up) { }

}

