//Type is in global namespace

public static class MiddleGraphGraphBuild
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"i", "j", "distSq"})]
		public static Comparison <>9__2_0; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"i", "j", "distSq"})]
		public static Comparison <>9__3_0; //Field offset: 0x10
		public static Comparison <>9__8_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <ApplyPathOptimization>b__8_0(MiddleGraphPathOptimizationEdge x, MiddleGraphPathOptimizationEdge y) { }

		internal int <BuildFromIncomePoints>b__2_0(ValueTuple a, ValueTuple b) { }

		internal int <EnsureConnected>b__3_0(ValueTuple a, ValueTuple b) { }

	}

	private const string LogPrefix = "[MiddleGraphGraphBuild]"; //Field offset: 0x0

	private static void AddBidirectionalEdge(AIMiddleGraphContainer container, MiddleGraphPoint a, MiddleGraphPoint b) { }

	private static int ApplyMaxConnectionsPerPointPruning(AIMiddleGraphContainer container, List placedSegments) { }

	private static int ApplyPathOptimization(AIMiddleGraphContainer container) { }

	private static Dictionary BuildConnectionGroupToPointIndices(List points) { }

	public static void BuildFromIncomePoints(AIMiddleGraphContainer container, IReadOnlyList incomes) { }

	public static void CollectAndBuild(AIMiddleGraphContainer container) { }

	private static void EnsureConnected(AIMiddleGraphContainer container, List placedSegments) { }

	private static int EnsureIntraConnectionGroupNavMeshBridges(AIMiddleGraphContainer container, List placedSegments) { }

	private static bool HasCompleteNavMeshPathBothWays(Vector3 from, Vector3 to) { }

	private static bool HasDirectEdge(MiddleGraphPoint a, MiddleGraphPoint b) { }

	private static float MinAbsYDifferenceBetweenEdgeEndpoints(Vector3 edge1A, Vector3 edge1B, Vector3 edge2A, Vector3 edge2B) { }

	private static bool NavMeshEdgePassesDirectRatioLimit(Vector3 from, Vector3 to, float maxRatio) { }

	private static bool NearlySamePosition(Vector3 a, Vector3 b) { }

	private static void RemoveBidirectionalEdge(AIMiddleGraphContainer container, MiddleGraphPoint a, MiddleGraphPoint b) { }

	private static int RemoveEdgesExceedingNavMeshDirectRatio(AIMiddleGraphContainer container) { }

	private static void RemoveSegmentFromPlaced(List placedSegments, Vector3 aPos, Vector3 bPos) { }

	private static bool TryAddBridgeEdgeIgnoreIntersection(AIMiddleGraphContainer container, MiddleGraphPoint a, MiddleGraphPoint b, List placedSegments) { }

	private static bool TryAddEdge(AIMiddleGraphContainer container, MiddleGraphPoint a, MiddleGraphPoint b, List placedSegments) { }

	private static bool TryGetAverageNavMeshPathLength(Vector3 a, Vector3 b, out float avgLen) { }

	private static Nullable TryGetShortestPathLengthBetween(AIMiddleGraphContainer container, MiddleGraphPoint from, MiddleGraphPoint to) { }

}

