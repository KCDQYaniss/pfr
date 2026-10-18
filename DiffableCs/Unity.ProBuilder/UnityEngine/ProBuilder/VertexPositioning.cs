namespace UnityEngine.ProBuilder;

[Extension]
public static class VertexPositioning
{
	private static List s_CoincidentVertices; //Field offset: 0x0

	private static VertexPositioning() { }

	[Extension]
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	[Extension]
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	[Extension]
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable indexes, Vector3 offset) { }

	[Extension]
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable edges, Vector3 offset) { }

	[Extension]
	public static void TranslateVertices(ProBuilderMesh mesh, IEnumerable faces, Vector3 offset) { }

	private static void TranslateVerticesInternal(ProBuilderMesh mesh, IEnumerable indices, Vector3 offset) { }

	[Extension]
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	[Extension]
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	[Extension]
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

}

