namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class VertexEditing
{

	private static Edge AlignEdgeWithDirection(EdgeLookup edge, int commonIndex) { }

	internal static FaceRebuildData ExplodeVertex(IList vertices, IList edgeAndCommonIndex, float distance, out Dictionary appendedVertices) { }

	[Extension]
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst = false) { }

	[Extension]
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	[Extension]
	public static void SplitVertices(ProBuilderMesh mesh, IEnumerable vertices) { }

	[Extension]
	public static int[] WeldVertices(ProBuilderMesh mesh, IEnumerable indexes, float neighborRadius) { }

}

