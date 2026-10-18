//Type is in global namespace

public class AISegmentGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <GetTotalDist>b__13_0(AIPointsCounterSegment x) { }

	}

	private AIPointsCounter Parent; //Field offset: 0x10
	public int Id; //Field offset: 0x18
	public float collectedAng; //Field offset: 0x1C
	public List Segments; //Field offset: 0x20
	private Dictionary _pointsSegments; //Field offset: 0x28

	public int Count
	{
		 get { } //Length: 65
	}

	public AISegmentGroup(int id, AIPointsCounter parent) { }

	private void AddSegment(AIPointsCounterSegment segment) { }

	public void DebugDraw(float up) { }

	public int get_Count() { }

	public List GetBorderPoints() { }

	public PointWithSegment GetNextPoint(PointWithSegment prev) { }

	public float GetTotalDist() { }

	public bool TryAdd(PairSegmentsWithAng pair) { }

	public bool TryAdd(AIPointsCounterSegment s1, float ang) { }

}

