namespace UnityEngine.ProBuilder.MeshOperations;

public static class MergeElements
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <Merge>b__1_0(Face x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public HashSet remove; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <MergePairs>b__0(Face x) { }

	}


	internal static void CollapseCoincidentVertices(ProBuilderMesh mesh, IEnumerable faces) { }

	public static Face Merge(ProBuilderMesh target, IEnumerable faces) { }

	public static List MergePairs(ProBuilderMesh target, IEnumerable pairs, bool collapseCoincidentVertices = true) { }

}

