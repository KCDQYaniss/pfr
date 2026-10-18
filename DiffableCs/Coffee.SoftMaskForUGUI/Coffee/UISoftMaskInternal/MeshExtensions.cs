namespace Coffee.UISoftMaskInternal;

[Extension]
internal static class MeshExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Mesh <.cctor>b__8_0() { }

		internal bool <.cctor>b__8_1(Mesh mesh) { }

		internal void <.cctor>b__8_2(Mesh mesh) { }

	}

	internal static readonly InternalObjectPool s_MeshPool; //Field offset: 0x0

	private static MeshExtensions() { }

	[Extension]
	public static void CopyTo(Mesh self, Mesh dst) { }

	[Extension]
	public static void CopyTo(VertexHelper self, Mesh dst) { }

	[Extension]
	public static void CopyTo(Mesh self, VertexHelper dst) { }

	[Extension]
	public static void CopyTo(Mesh self, VertexHelper dst, int vertexCount, int indexCount) { }

	[Extension]
	private static T GetOrDefault(List self, int index) { }

	public static Mesh Rent() { }

	public static void Return(ref Mesh mesh) { }

}

