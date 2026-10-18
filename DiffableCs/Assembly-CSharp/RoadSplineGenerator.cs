//Type is in global namespace

[Obsolete("This component is obsolete. Use BSG.Tools.Roads.RoadsGenerator instead or try 'Create New Roads As Sibling' in context menu")]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class RoadSplineGenerator : MonoBehaviour
{
	internal struct Point
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Right; //Field offset: 0xC
		public float NextDist; //Field offset: 0x18

	}

	internal class Road
	{
		public RoadSplineGenerator Parent; //Field offset: 0x10
		public Vector3[] Positins; //Field offset: 0x18
		public Vector3[] Normals; //Field offset: 0x20
		public int Parts; //Field offset: 0x28
		public Vector3[] Optimized; //Field offset: 0x30
		public float[] OptimizedVals; //Field offset: 0x38
		public float Width; //Field offset: 0x40
		public int WidthParts; //Field offset: 0x44
		public float[] WidthVals; //Field offset: 0x48
		public bool UseWidthVals; //Field offset: 0x50
		public float TexDensity; //Field offset: 0x54
		public float TexXDensity; //Field offset: 0x58
		public Vector4 Borders; //Field offset: 0x5C
		public int LodsCount; //Field offset: 0x6C
		[SerializeField]
		private bool _hold; //Field offset: 0x70
		public int LastVertId; //Field offset: 0x74
		public bool UseCurve; //Field offset: 0x78
		public AnimationCurve WidthCurve; //Field offset: 0x80
		private int _verticesDelta; //Field offset: 0x88

		public bool Hold
		{
			 get { } //Length: 5
			 set { } //Length: 631
		}

		public Road() { }

		public void Generate(ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector4[] tangents, Vector2[] uv0, Color32[] colors, Color32[] oldColors, float error, bool lodGeneration) { }

		private void Generate(Point[] points, float[] vals, ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector4[] tangents, Vector2[] uv0, Color32[] colors) { }

		public void GeneratePoints(float error) { }

		public bool get_Hold() { }

		public int GetTrianglesCount() { }

		public float[] GetVals() { }

		public int GetVerticesCount() { }

		public void ResetVerticesDelta() { }

		public void set_Hold(bool value) { }

	}

	[CompilerGenerated]
	private Action OnGenerate; //Field offset: 0x20
	public Road[] Roads; //Field offset: 0x28
	public float Error; //Field offset: 0x30
	public int MaxOptimization; //Field offset: 0x34
	public float TerrainOffset; //Field offset: 0x38
	public LayerMask Mask; //Field offset: 0x3C
	public bool SplitForLods; //Field offset: 0x40
	public float CullingRate; //Field offset: 0x44
	public bool LockGeneration; //Field offset: 0x48
	private MeshFilter _meshFilter; //Field offset: 0x50
	public Mesh Mesh; //Field offset: 0x58

	public event Action OnGenerate
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public RoadSplineGenerator() { }

	[CompilerGenerated]
	public void add_OnGenerate(Action value) { }

	private bool CheckZFighting(MeshRenderer lodMeshRenderer, Material lodMeshMaterial) { }

	public static Vector3 CrossUp(Vector3 lhs) { }

	public static void DropChilds(Transform transform) { }

	private void DropCurrentChilds() { }

	public Vector3 FixOnGround(Vector3 point) { }

	public void Generate() { }

	public void GenerateLods(int roadI, Color32[] oldColors) { }

	public static Point[] GeneratePoints(Vector3[] positions, bool calcDistances = true) { }

	private Color32[] GetColors(int roadI) { }

	private void GetColors(int roadI, Color32[] colors, ref int i) { }

	public Color32[] GetColors() { }

	public static Vector3 GetCurve(float t, Vector3 p0, Vector3 n0, Vector3 n1, Vector3 p1) { }

	public Mesh GetMesh() { }

	public static Vector3[] GetPoints(Vector3 p0, Vector3 p1, Vector3 n0, Vector3 n1, int parts) { }

	public Vector3[] GetPoints(Road road) { }

	public Vector3[] GetPointsHeld(Road road) { }

	public float[] GetVals(Road road) { }

	private static Vector3 Hermite(float t, Vector3 p0, Vector3 m0, Vector3 m1, Vector3 p1) { }

	private static void Optimize(LinkedList points, float error) { }

	private static void Optimize(ref Vector3[] points, ref float[] vals, float error, int maxOptimization) { }

	private static void Optimize(Vector3[] points, LinkedList indices, float error) { }

	private static Vector3[] Optimize(Vector3[] points, float error, int maxOptimization) { }

	[CompilerGenerated]
	public void remove_OnGenerate(Action value) { }

	public void SetCullingRate() { }

	private static void Split(Vector2[] uv, int widthVerts, int count, out int[] starts, out int[] lengths) { }

}

