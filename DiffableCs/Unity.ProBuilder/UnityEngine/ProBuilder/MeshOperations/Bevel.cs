namespace UnityEngine.ProBuilder.MeshOperations;

public static class Bevel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__0_0; //Field offset: 0x8
		public static Func <>9__0_6; //Field offset: 0x10
		public static Func <>9__0_1; //Field offset: 0x18
		public static Func <>9__0_2; //Field offset: 0x20
		public static Func <>9__0_3; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal Face <BevelEdges>b__0_0(FaceRebuildData x) { }

		internal Face <BevelEdges>b__0_1(FaceRebuildData x) { }

		internal Face <BevelEdges>b__0_2(FaceRebuildData x) { }

		internal Face <BevelEdges>b__0_3(FaceRebuildData x) { }

		internal int <BevelEdges>b__0_6(SimpleTuple x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Dictionary ignore; //Field offset: 0x10
		public SharedVertex[] sharedIndexes; //Field offset: 0x18
		public Func <>9__7; //Field offset: 0x20
		public Func <>9__8; //Field offset: 0x28

		public <>c__DisplayClass0_0() { }

		internal int <BevelEdges>b__7(int x) { }

		internal int <BevelEdges>b__8(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_1
	{
		public EdgeLookup lup; //Field offset: 0x10

		public <>c__DisplayClass0_1() { }

		internal bool <BevelEdges>b__4(WingedEdge x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_2
	{
		public int c; //Field offset: 0x10
		public <>c__DisplayClass0_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass0_2() { }

		internal bool <BevelEdges>b__5(WingedEdge x) { }

	}

	private static readonly int[] k_BridgeIndexesTri; //Field offset: 0x0

	private static Bevel() { }

	public static List BevelEdges(ProBuilderMesh mesh, IList edges, float amount) { }

	private static List GetBridgeFaces(IList vertices, WingedEdge left, WingedEdge right, Dictionary holes) { }

	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	private static void SlideEdge(IList vertices, WingedEdge we, float amount) { }

}

