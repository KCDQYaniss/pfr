//Type is in global namespace

public class AIMiddleGraphContainer : MonoBehaviour
{
	public float PathOptimizationMaxPathVsDirectRatio; //Field offset: 0x20
	public bool UsePathOptimizationMaxPathVsDirectRatio; //Field offset: 0x24
	public float MaxNavMeshPathVsDirectRatio; //Field offset: 0x28
	public bool UseMaxNavMeshPathVsDirectRatio; //Field offset: 0x2C
	public bool RequireNavMeshPath; //Field offset: 0x2D
	public bool CheckEdgeSegmentIntersectionXZ; //Field offset: 0x2E
	public bool UseMaxConnectionsPerPoint; //Field offset: 0x2F
	[Min(1)]
	public int MaxConnectionsPerPoint; //Field offset: 0x30
	public float EdgeIntersectionYGapIgnorePlanarThreshold; //Field offset: 0x34
	[SerializeField]
	private bool _drawGraphInScene; //Field offset: 0x38
	[SerializeField]
	private bool _drawNodes; //Field offset: 0x39
	[SerializeField]
	private bool _drawEdges; //Field offset: 0x3A
	[Min(0.1)]
	[SerializeField]
	private float _drawGraphRange; //Field offset: 0x3C
	[SerializeField]
	private bool _useSceneCameraForCulling; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private List _savedPositions; //Field offset: 0x48
	[HideInInspector]
	[SerializeField]
	private List _savedEdges; //Field offset: 0x50
	[HideInInspector]
	[SerializeField]
	private List _savedCorePointIds; //Field offset: 0x58
	private readonly List _points; //Field offset: 0x60
	private readonly List _ways; //Field offset: 0x68
	private bool _runtimeGraphDirty; //Field offset: 0x70

	public bool DrawEdges
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DrawGraphInScene
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float DrawGraphRange
	{
		 get { } //Length: 6
		 set { } //Length: 20
	}

	public bool DrawNodes
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	internal List MiddleGraphPoints
	{
		internal get { } //Length: 5
	}

	internal List MiddleGraphWays
	{
		internal get { } //Length: 5
	}

	public IReadOnlyList Points
	{
		 get { } //Length: 5
	}

	public IReadOnlyList SavedCorePointIds
	{
		 get { } //Length: 5
	}

	public IReadOnlyList SavedEdges
	{
		 get { } //Length: 5
	}

	public IReadOnlyList SavedPositions
	{
		 get { } //Length: 5
	}

	public bool UseSceneCameraForCulling
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public IReadOnlyList Ways
	{
		 get { } //Length: 5
	}

	public AIMiddleGraphContainer() { }

	private void AddBidirectionalEdge(MiddleGraphPoint a, MiddleGraphPoint b) { }

	private void BindCorePointsResolvedFromIds() { }

	public void BuildFromIncomePoints(IReadOnlyList incomes) { }

	public void Clear() { }

	private static Vector3 ClosestPointOnSegment(Vector3 p, Vector3 a, Vector3 b) { }

	public void CollectPointForGraph() { }

	private static bool EdgeWithinRange(Vector3 a, Vector3 b, Vector3 origin, float rangeSq) { }

	public void EnsureRuntimeGraphLoaded() { }

	public bool get_DrawEdges() { }

	public bool get_DrawGraphInScene() { }

	public float get_DrawGraphRange() { }

	public bool get_DrawNodes() { }

	internal List get_MiddleGraphPoints() { }

	internal List get_MiddleGraphWays() { }

	public IReadOnlyList get_Points() { }

	public IReadOnlyList get_SavedCorePointIds() { }

	public IReadOnlyList get_SavedEdges() { }

	public IReadOnlyList get_SavedPositions() { }

	public bool get_UseSceneCameraForCulling() { }

	public IReadOnlyList get_Ways() { }

	private Vector3 GetGizmoCullOrigin() { }

	private static bool HasDirectEdge(MiddleGraphPoint a, MiddleGraphPoint b) { }

	internal void MarkRuntimeGraphClean() { }

	private void OnDrawGizmos() { }

	private void OnValidate() { }

	public void PersistGraphToSerialized() { }

	private void RebuildRuntimeFromSerialized() { }

	public void set_DrawEdges(bool value) { }

	public void set_DrawGraphInScene(bool value) { }

	public void set_DrawGraphRange(float value) { }

	public void set_DrawNodes(bool value) { }

	public void set_UseSceneCameraForCulling(bool value) { }

}

