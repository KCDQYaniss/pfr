namespace UnityEngine.ProBuilder;

public static class Projection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__6_0; //Field offset: 0x8
		public static Func <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Sort>b__6_0(SimpleTuple a, SimpleTuple b) { }

		internal Vector2 <Sort>b__6_1(SimpleTuple x) { }

	}


	public static Plane FindBestPlane(IList points, IList indexes = null) { }

	internal static Plane FindBestPlane(ProBuilderMesh mesh, int textureGroup) { }

	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	public static Vector2[] PlanarProject(IList positions, IList indexes = null) { }

	public static Vector2[] PlanarProject(IList positions, IList indexes, Vector3 direction) { }

	internal static void PlanarProject(IList positions, IList indexes, Vector3 direction, List results) { }

	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection = null) { }

	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	internal static IList Sort(IList verts, SortMethod method = 1) { }

	internal static Vector2[] SphericalProject(IList vertices, IList indexes = null) { }

	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

}

