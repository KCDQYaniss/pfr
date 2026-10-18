//Type is in global namespace

public class NavGraphWayAstar
{
	private static int _nextSearchId; //Field offset: 0x0
	private readonly List _path; //Field offset: 0x10
	private NavGraphEditorPoint[] _arrayPath; //Field offset: 0x18
	private float _distWay; //Field offset: 0x20
	private readonly PriorityQueue _queue; //Field offset: 0x28
	private int _searchId; //Field offset: 0x30
	private NavGraphEditorPoint _beginPoint; //Field offset: 0x38
	private NavGraphEditorPoint _endPoint; //Field offset: 0x40

	public NavGraphWayAstar() { }

	public float CalcDist() { }

	public static void DrawWayGizmos(IPositionPoint[] way, int restrict = 900) { }

	private static int GetNextSearchId() { }

	private float GetWayLength(NavGraphEditorPoint currentNode) { }

	public bool GetWayPoints(NavGraphEditorPoint beginPoint, NavGraphEditorPoint endPoint, out NavGraphEditorPoint[] wayOut, bool disableLogs = false) { }

	private float HeuristicFunction(NavGraphEditorPointWay node, Vector3 targetPosition) { }

	private float HeuristicFunction2(NavGraphEditorPointWay node, Vector3 targetPosition) { }

	private bool IsVisited(NavGraphEditorPoint currentNode, int searchId) { }

	private void MarkAsVisited(NavGraphEditorPoint currentNode, int searchId) { }

	public void OnDrawGizmosSelected() { }

	private NavGraphEditorPoint[] RestorePath(NavGraphEditorPoint lastNode, NavGraphEditorPoint firstNode) { }

	private void SetWayLength(NavGraphEditorPoint neighbour, float length) { }

}

