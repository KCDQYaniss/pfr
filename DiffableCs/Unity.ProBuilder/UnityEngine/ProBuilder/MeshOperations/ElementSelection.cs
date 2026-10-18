namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class ElementSelection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10
		public static Func <>9__5_2; //Field offset: 0x18
		public static Func <>9__7_0; //Field offset: 0x20
		public static Func <>9__7_1; //Field offset: 0x28
		public static Func <>9__10_0; //Field offset: 0x30
		public static Func <>9__11_0; //Field offset: 0x38
		public static Func <>9__12_0; //Field offset: 0x40
		public static Func <>9__13_0; //Field offset: 0x48
		public static Func <>9__14_0; //Field offset: 0x50
		public static Func <>9__15_0; //Field offset: 0x58
		public static Func <>9__15_1; //Field offset: 0x60
		public static Func <>9__26_0; //Field offset: 0x68
		public static Comparison <>9__27_0; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal Edge <FindHoles>b__26_0(WingedEdge x) { }

		internal int <FindHoles>b__27_0(SimpleTuple x, SimpleTuple y) { }

		internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

		internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

		internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

		internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

		internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

		internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

		internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

		internal IEnumerable <GetPerimeterEdges>b__5_0(Face x) { }

		internal bool <GetPerimeterEdges>b__5_1(KeyValuePair x) { }

		internal Edge <GetPerimeterEdges>b__5_2(KeyValuePair x) { }

		internal bool <GetPerimeterFaces>b__7_0(KeyValuePair x) { }

		internal Face <GetPerimeterFaces>b__7_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public Face face; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <GetFaceLoop>b__0(WingedEdge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public HashSet common; //Field offset: 0x10
		public Func <>9__1; //Field offset: 0x18
		public Func <>9__2; //Field offset: 0x20

		public <>c__DisplayClass27_0() { }

		internal bool <FindHoles>b__1(WingedEdge w) { }

		internal bool <FindHoles>b__2(WingedEdge w) { }

	}

	private const int k_MaxHoleIterations = 2048; //Field offset: 0x0
	private static readonly Vector3 Vector3_Zero; //Field offset: 0x0

	private static ElementSelection() { }

	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	internal static List FindHoles(List wings, HashSet common) { }

	internal static List FindHoles(ProBuilderMesh mesh, IEnumerable indexes) { }

	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, HashSet selection) { }

	internal static void Flood(WingedEdge wing, HashSet selection) { }

	public static HashSet FloodSelection(ProBuilderMesh mesh, IList faces, float maxAngleDiff) { }

	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	internal static bool GetEdgeLoop(ProBuilderMesh mesh, IEnumerable edges, out Edge[] loop) { }

	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, HashSet used) { }

	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, HashSet used) { }

	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, IEnumerable edges, out Edge[] loop) { }

	internal static IEnumerable GetEdgeRing(ProBuilderMesh pb, IEnumerable edges) { }

	internal static IEnumerable GetEdgeRingIterative(ProBuilderMesh pb, IEnumerable edges) { }

	private static HashSet GetFaceLoop(List wings, Face face, bool ring) { }

	public static HashSet GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring = false) { }

	public static HashSet GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	internal static List GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	internal static List GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, List neighborFaces) { }

	[Extension]
	public static IEnumerable GetPerimeterEdges(ProBuilderMesh mesh, IEnumerable faces) { }

	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, IList edges) { }

	internal static IEnumerable GetPerimeterFaces(ProBuilderMesh mesh, IEnumerable faces) { }

	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	internal static List GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles = false) { }

	public static HashSet GrowSelection(ProBuilderMesh mesh, IEnumerable faces, float maxAngleDiff = -1) { }

	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

}

