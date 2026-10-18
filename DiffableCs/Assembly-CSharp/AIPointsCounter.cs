//Type is in global namespace

public class AIPointsCounter
{
	public const float POSSIBLE_TOTAL_ANG = 35; //Field offset: 0x0
	private const float MIN_SEGMENT_LENGHT_TO_ADD_INSIDE = 0.4; //Field offset: 0x0
	private const float MIN_SEGMENT_LENGHT_TO_ADD_OUTSIDE = 1.4; //Field offset: 0x0
	private const int SEGMENTS_TO_ADD_ANYWAY = 1; //Field offset: 0x0
	[SerializeField]
	private List _edges; //Field offset: 0x10
	public bool IsAlwaysGood; //Field offset: 0x18
	private AITriangleData _triangle; //Field offset: 0x20
	public int CorePointId; //Field offset: 0x28

	public int EdgeCount
	{
		 get { } //Length: 65
	}

	public AIPointsCounter(AITriangleData triangle) { }

	public void Add(NavEdge edge) { }

	public List CalculateSegments(List allTriggers) { }

	private Dictionary ConnectToGroups(List pairs) { }

	public void DebugDrawCounter(float duration = 10) { }

	public int get_EdgeCount() { }

	public Vector3 GetCenterPoint() { }

	private bool IsInside(List allTriggers, Vector3 center) { }

	public NavPoint RandomPointFirst() { }

	public void SetCorePoint(AICorePoint holderTestObject) { }

	private int SortByAng(PairSegmentsWithAng x, PairSegmentsWithAng y) { }

	private int SortSegments(AIPointsCounterSegment x, AIPointsCounterSegment y) { }

}

