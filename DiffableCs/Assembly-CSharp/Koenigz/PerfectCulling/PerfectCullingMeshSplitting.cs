namespace Koenigz.PerfectCulling;

public class PerfectCullingMeshSplitting
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__3_0; //Field offset: 0x8
		public static Comparison <>9__3_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Split>b__3_0(TriangleData a, TriangleData b) { }

		internal int <Split>b__3_1(TriangleData a, TriangleData b) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public SplitMeshData splitMeshData; //Field offset: 0x0
		public List meshes; //Field offset: 0x8
		public Dictionary spV; //Field offset: 0x10
		public int cIndex; //Field offset: 0x18

	}

	private class SplitMeshData
	{
		public List indices; //Field offset: 0x10
		public List verts; //Field offset: 0x18
		public List colors; //Field offset: 0x20
		public List tris; //Field offset: 0x28

		public SplitMeshData() { }

		public Hash128 ComputeHash() { }

		public Mesh CreateMesh() { }

	}

	private class TriangleData
	{
		public Vector3 posA; //Field offset: 0x10
		public Vector3 posB; //Field offset: 0x1C
		public Vector3 posC; //Field offset: 0x28
		public Color colA; //Field offset: 0x34
		public Vector3 center; //Field offset: 0x44

		public TriangleData() { }

	}

	private class TupleComparer : IEqualityComparer
	{

		public TupleComparer() { }

		public override bool Equals(ValueTuple x, ValueTuple y) { }

		public override int GetHashCode(ValueTuple obj) { }

	}

	private const int SplitSize = 8000; //Field offset: 0x0
	private static TupleComparer tupleComparer; //Field offset: 0x0

	private static PerfectCullingMeshSplitting() { }

	public PerfectCullingMeshSplitting() { }

	[CompilerGenerated]
	internal static void <SplitTriangles>g__AddVerts|6_1(Vector3 pos, Color col, ref <>c__DisplayClass6_0 unnamed_param_2) { }

	[CompilerGenerated]
	internal static void <SplitTriangles>g__SplitMesh|6_0(ref <>c__DisplayClass6_0 unnamed_param_0) { }

	private static SplitMeshData GenerateFromMesh(Mesh mesh, Matrix4x4 transformMat) { }

	public static List Split(Mesh mesh, Matrix4x4 transformMatrix) { }

	private static List SplitTriangles(List triangles, int splitCount) { }

}

