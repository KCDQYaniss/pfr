namespace UnityEngine.ProBuilder.MeshOperations;

public static class CombineMeshes
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

	}


	private static void AccumulateMeshesInfo(IEnumerable meshes, int offset, ref List vertices, ref List faces, ref List autoUvFaces, ref List sharedVertices, ref List sharedTextures, ref List materialMap, Transform targetTransform = null) { }

	[Obsolete("Combine(IEnumerable<ProBuilderMesh> meshes) is deprecated. Plase use Combine(IEnumerable<ProBuilderMesh> meshes, ProBuilderMesh meshTarget).")]
	public static List Combine(IEnumerable meshes) { }

	public static List Combine(IEnumerable meshes, ProBuilderMesh meshTarget) { }

	private static List CombineToNewMeshes(IEnumerable meshes) { }

	private static ProBuilderMesh CreateMeshFromSplit(List vertices, List faces, Dictionary sharedVertexLookup, Dictionary sharedTextureLookup, Dictionary remap, Material[] materials) { }

	internal static List SplitByMaxVertexCount(IList vertices, IList faces, IList sharedVertices, IList sharedTextures, uint maxVertexCount = 65535) { }

}

