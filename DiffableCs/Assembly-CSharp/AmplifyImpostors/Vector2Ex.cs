namespace AmplifyImpostors;

[Extension]
public static class Vector2Ex
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ConvexHull>b__3_0(Vector2 a, Vector2 b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Vector2[] P; //Field offset: 0x10
		public int smallestIndex; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal bool <ReduceLeastSignificantVertice>b__0(Vector2 x) { }

	}


	public static Vector2[] ConvexHull(Vector2[] P) { }

	[Extension]
	public static float Cross(Vector2 O, Vector2 A, Vector2 B) { }

	private static Vector2 GetIntersectionPointCoordinates(Vector2 A1, Vector2 A2, Vector2 B1, Vector2 B2) { }

	private static float OutsideBounds(Vector2 P) { }

	private static Vector2[] ReduceLeastSignificantVertice(Vector2[] P) { }

	public static Vector2[] ReduceVertices(Vector2[] P, int maxVertices) { }

	public static Vector2[] ScaleAlongNormals(Vector2[] P, float scaleAmount) { }

	[Extension]
	public static float TriangleArea(Vector2 O, Vector2 A, Vector2 B) { }

	[Extension]
	public static float TriangleArea(Vector3 O, Vector3 A, Vector3 B) { }

}

