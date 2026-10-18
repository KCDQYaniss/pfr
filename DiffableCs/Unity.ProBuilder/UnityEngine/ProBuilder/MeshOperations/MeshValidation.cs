namespace UnityEngine.ProBuilder.MeshOperations;

[Extension]
public static class MeshValidation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10
		public static Func <>9__7_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

		internal IEnumerable <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

		internal IEnumerable <RemoveUnusedVertices>b__7_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public ProBuilderMesh mesh; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <RebuildSelectionIndexes>b__0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Triangle triangle; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal bool <CollectFaceGroups>b__0(Triangle x) { }

	}

	private enum AttributeValidationStrategy
	{
		Resize = 0,
		Nullify = 1,
	}


	[Extension]
	internal static List CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, IList faces) { }

	[Extension]
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	[Extension]
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	private static void EnsureArraySize(ref T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy = 1, T fill = null) { }

	[Extension]
	public static List EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, IEnumerable faces) { }

	private static void EnsureListSize(ref List attribute, int expectedVertexCount, AttributeValidationStrategy strategy = 1, T fill = null) { }

	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, out int removedVertices) { }

	private static void EnsureRealNumbers(IList attribute) { }

	private static void EnsureRealNumbers(IList attribute) { }

	private static void EnsureRealNumbers(IList attribute) { }

	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

	internal static List RebuildEdges(IEnumerable edges, List removed) { }

	internal static List RebuildIndexes(IEnumerable indices, List removed) { }

	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, ref Face[] faces, ref Edge[] edges, ref int[] indices, IEnumerable removed) { }

	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, List removed = null) { }

	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, List removed = null) { }

}

