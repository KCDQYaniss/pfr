namespace EFT.Interactive;

[Extension]
public static class LootPointsUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__3_0; //Field offset: 0x10
		public static Func <>9__3_1; //Field offset: 0x18
		public static Func <>9__3_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal LootPointNode <GetItemNodes>b__3_0(NodeReference x) { }

		internal IEnumerable <GetItemNodes>b__3_1(LootPointNode x) { }

		internal bool <GetItemNodes>b__3_2(LootPointNode x) { }

		internal string <GetNodeIds>b__2_0(NodeReference x) { }

	}


	[Extension]
	public static void Collapse(IEnumerable source, bool recursive) { }

	[Extension]
	public static void Expand(IEnumerable source, bool recursive) { }

	[Extension]
	public static IEnumerable GetItemNodes(IEnumerable source) { }

	[Extension]
	public static IEnumerable GetNodeIds(IEnumerable source) { }

}

