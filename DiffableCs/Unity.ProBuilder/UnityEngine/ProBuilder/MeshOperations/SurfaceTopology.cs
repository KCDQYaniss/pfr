namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class SurfaceTopology
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__3_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

		internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	}


	private static List BreakFaceIntoTris(Face face, List vertices, Dictionary lookup) { }

	[Extension]
	public static ActionResult ConformNormals(ProBuilderMesh mesh, IEnumerable faces) { }

	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	[Extension]
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	private static void GetWindingFlags(WingedEdge edge, bool flag, Dictionary flags) { }

	[Extension]
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	private static WindingOrder GetWindingOrder(IList vertices, IList indexes) { }

	public static WindingOrder GetWindingOrder(IList points) { }

	internal static void MatchNormal(Face source, Face target, Dictionary lookup) { }

	[Extension]
	public static Face[] ToTriangles(ProBuilderMesh mesh, IList faces) { }

}

