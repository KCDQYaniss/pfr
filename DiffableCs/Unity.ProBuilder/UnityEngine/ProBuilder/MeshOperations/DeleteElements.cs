namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class DeleteElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <DeleteFaces>b__3_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public List sorted; //Field offset: 0x10
		public int[] offset; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal bool <DeleteVertices>b__0(KeyValuePair x) { }

		internal KeyValuePair <DeleteVertices>b__1(KeyValuePair y) { }

		internal bool <DeleteVertices>b__2(KeyValuePair x) { }

		internal KeyValuePair <DeleteVertices>b__3(KeyValuePair y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public ProBuilderMesh mesh; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal int <DeleteFaces>b__0(Face x) { }

	}


	[Extension]
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static int[] DeleteFaces(ProBuilderMesh mesh, IEnumerable faces) { }

	[Extension]
	public static int[] DeleteFaces(ProBuilderMesh mesh, IList faceIndexes) { }

	[Extension]
	public static void DeleteVertices(ProBuilderMesh mesh, IEnumerable distinctIndexes) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Extension]
	[Obsolete("Use MeshValidation.RemoveDegenerateTriangles")]
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Extension]
	[Obsolete("Use MeshValidation.RemoveUnusedVertices")]
	public static int[] RemoveUnusedVertices(ProBuilderMesh mesh) { }

}

