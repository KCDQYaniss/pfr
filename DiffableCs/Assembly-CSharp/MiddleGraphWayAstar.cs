//Type is in global namespace

public class MiddleGraphWayAstar
{
	private const float PENALTY = 100; //Field offset: 0x0
	private static int _nextSearchId; //Field offset: 0x0
	private readonly List _path; //Field offset: 0x10
	private readonly PriorityQueue _queue; //Field offset: 0x18
	private int _searchId; //Field offset: 0x20

	public MiddleGraphWayAstar() { }

	private static void ApplyPenalty(IReadOnlyList pathWays, HashSet penalized) { }

	private static void ApplyPenaltyToEdge(MiddleGraphWay way, HashSet penalized) { }

	public static void DrawWayGizmos(IReadOnlyList way, int restrict = 900) { }

	private static float GetAStarG(MiddleGraphPoint node, int searchGen) { }

	private static int GetNextSearchId() { }

	public bool GetWayPoints(MiddleGraphPoint beginPoint, MiddleGraphPoint endPoint, out MiddleGraphPoint[] wayOut, bool disableLogs = false) { }

	public bool GetWayPointsPenalizingExistingPath(MiddleGraphPoint beginPoint, MiddleGraphPoint endPoint, IReadOnlyList existingPathPoints, out MiddleGraphPoint[] wayOut, bool disableLogs = false) { }

	private static float HeuristicDistance(Vector3 from, Vector3 goal) { }

	private static void RestoreCosts(HashSet penalized) { }

	private MiddleGraphPoint[] RestorePath(MiddleGraphPoint lastNode, MiddleGraphPoint firstNode) { }

	public static bool TryCollectWaysAlongPath(IReadOnlyList pathPoints, out List waysOut) { }

	private static bool TryFindOutgoingWay(MiddleGraphPoint from, MiddleGraphPoint to, out MiddleGraphWay way) { }

}

