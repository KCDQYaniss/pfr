namespace AbsolutDecals;

public class TemporaryMesh
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__27_0; //Field offset: 0x8
		public static Comparison <>9__27_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <MakeMesh>b__27_0(DecalMeshVertexData x, DecalMeshVertexData y) { }

		internal int <MakeMesh>b__27_1(DecalMeshVertexData x, DecalMeshVertexData y) { }

	}

	private static readonly Vector2 UvOffset; //Field offset: 0x0
	public Vector3[] _vertices; //Field offset: 0x10
	public int[] Triangles; //Field offset: 0x18
	public Vector3[] Normals; //Field offset: 0x20
	public Vector2[] UV; //Field offset: 0x28
	public bool IsSkinned; //Field offset: 0x30
	public Matrix4x4[] BindPoses; //Field offset: 0x38
	public BoneWeight[] BoneWeights; //Field offset: 0x40
	public Transform[] Bones; //Field offset: 0x48
	public Transform DecalTransform; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsFromStatic>k__BackingField; //Field offset: 0x58
	public Vector3[] WorldVertices; //Field offset: 0x60
	public Vector3[] WorldNormals; //Field offset: 0x68
	[CompilerGenerated]
	private int <VertexCount>k__BackingField; //Field offset: 0x70

	public private bool IsFromStatic
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int VertexCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3[] Vertices
	{
		 get { } //Length: 5
		private set { } //Length: 82
	}

	private static TemporaryMesh() { }

	public TemporaryMesh(Vector3[] vertices, int[] triangles, Vector3[] normals, Vector2[] uv, Vector3[] worldVertices = null, Vector3[] worldNormals = null) { }

	public TemporaryMesh(Mesh mesh, bool isFromStatic = false, Transform objectTransform = null) { }

	[CompilerGenerated]
	public bool get_IsFromStatic() { }

	[CompilerGenerated]
	public int get_VertexCount() { }

	public Vector3[] get_Vertices() { }

	public static Vector2 GetUv(Vector3 projectorLocalVertices, ProjectionDirections direction, Vector2[] decalUv) { }

	public static TemporaryMesh MakeMesh(List verticesList, List projectorVertsList, Vector3 normal, ProjectionDirections projectionDirection, Vector3 projectionDirectionVector, Vector2[] decalUv, float offset, bool isInProjectorSpace, List boneWeights = null, Transform relativeTransform = null) { }

	public static TemporaryMesh op_Addition(TemporaryMesh lhs, TemporaryMesh rhs) { }

	public static Mesh op_Addition(Mesh lhs, TemporaryMesh rhs) { }

	[CompilerGenerated]
	private void set_IsFromStatic(bool value) { }

	[CompilerGenerated]
	private void set_VertexCount(int value) { }

	private void set_Vertices(Vector3[] value) { }

	public static TemporaryMesh TerrainToMesh(TerrainData terrain, Transform terrainTransform, int terrainResolutionPow = 3) { }

	public Mesh ToMesh() { }

}

