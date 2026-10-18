//Type is in global namespace

public class AITriangleData : MonoBehaviour
{
	public List Points; //Field offset: 0x20
	public List Triangles; //Field offset: 0x28
	public List Edge; //Field offset: 0x30
	public TriangleCounters Counters; //Field offset: 0x38
	public bool Restored; //Field offset: 0x40
	public Dictionary ToCut; //Field offset: 0x48
	public bool HaveExternalEdges; //Field offset: 0x50
	public bool DrawPoints; //Field offset: 0x51
	public bool DrawPointsWithEdges; //Field offset: 0x52
	public bool DrawEdges; //Field offset: 0x53
	public bool DrawTriags; //Field offset: 0x54
	public bool DrawCounters; //Field offset: 0x55
	public bool DrawWithIndex; //Field offset: 0x56
	public int DistDraw; //Field offset: 0x58
	public int CountExternalEdges; //Field offset: 0x5C
	[SerializeField]
	private int _idIndex; //Field offset: 0x60
	public int wrongAddsToCutList; //Field offset: 0x64
	public int goodAddsToCutList; //Field offset: 0x68
	private Dictionary _dcPoints; //Field offset: 0x70
	private Dictionary _dcTriangles; //Field offset: 0x78
	private Dictionary _dcEdge; //Field offset: 0x80
	private readonly Vector3 distDrawPoints; //Field offset: 0x88
	private readonly Vector3 distDrawEdges; //Field offset: 0x94
	private readonly Vector3 distDrawTriags; //Field offset: 0xA0
	private readonly Vector3 distDrawCounters; //Field offset: 0xAC
	public float SizeToCutOff; //Field offset: 0xB8
	public List ObjectsToDelete; //Field offset: 0xC0

	public int LastUsedId
	{
		 get { } //Length: 4
	}

	public AITriangleData() { }

	public bool AddCut(PointAtCounter point, NavEdge edge) { }

	public void AddEdgeExternal(NavEdge nEdge) { }

	public void AddTriag(NavTriangle trianlge) { }

	public int CalcZeroDistEdges() { }

	public void Clear() { }

	public static AITriangleData CreateOrFind(bool withClear) { }

	public void DeleteTriangle(NavTriangle triagToDel) { }

	public string EdgeDebug() { }

	public int get_LastUsedId() { }

	public NavEdge GetEdge(int index) { }

	public int GetId() { }

	public NavPoint GetPoint(int id) { }

	public NavPoint GetPointNew(Vector3 pos) { }

	public void OnDrawGizmosSelected() { }

	public void RemoveEdge(NavEdge navEgde) { }

	public void SetDictionaries(Dictionary dcPoints, Dictionary dcEdge, Dictionary dcTriangles) { }

	public void TryAddPoint(NavPoint p) { }

}

