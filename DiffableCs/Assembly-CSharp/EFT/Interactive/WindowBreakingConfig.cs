namespace EFT.Interactive;

public class WindowBreakingConfig : ScriptableObject
{
	internal class Crack
	{
		public Polygon[] Polygons; //Field offset: 0x10
		public bool GetFromSelectedMeshes; //Field offset: 0x18
		public float Scale; //Field offset: 0x1C
		public GameObject Glass; //Field offset: 0x20

		public Crack() { }

	}

	internal class MeshPiece
	{
		public int[] Triangles; //Field offset: 0x10
		public Vector3[] Vertices; //Field offset: 0x18
		public Vector3[] Normals; //Field offset: 0x20
		public Vector2[] Uv; //Field offset: 0x28

		public MeshPiece() { }

		public Mesh GetMesh(Vector2 center) { }

	}

	internal class Polygon
	{
		public Vector2[] Points; //Field offset: 0x10
		public float[] Distances; //Field offset: 0x18
		public float[] RandomRanges; //Field offset: 0x20
		public float Mass; //Field offset: 0x28
		public bool Intersects; //Field offset: 0x2C

		public Polygon(Vector2[] points, float mass) { }

		public Polygon CutPolygon(Vector4 box) { }

		public Polygon CutPolygon(Vector4 box, Vector2 xAxis) { }

		public void DebugDraw(Color color) { }

	}

	private static readonly List Buffer0; //Field offset: 0x0
	private const int RandomsCount = 128; //Field offset: 0x0
	private static readonly List Buffer1; //Field offset: 0x8
	private static Vector2[] _randoms; //Field offset: 0x10
	private static int _randomid; //Field offset: 0x18
	public Crack[] Cracks; //Field offset: 0x18

	private static WindowBreakingConfig() { }

	public WindowBreakingConfig() { }

	public static Mesh CombineMeshPieces(MeshPiece[] pieces) { }

	private static int CutLine(ref Vector2 p0, ref Vector2 p1, Vector4 box) { }

	private static int CutLine(ref Vector2 p0, ref Vector2 p1, bool xAxis, bool positive, float value) { }

	private static Vector2[] CutPolygon(Vector2[] points, Vector4 box, out bool noIntersects) { }

	private static void CutPolygon(List newList, List points, bool xAxis, bool positive, float value) { }

	public static void DetectPlane(Vector3 size, out int axisX, out int axisY, out int axisZ) { }

	private static void DetectPlane(Vector3[] points, out int axisX, out int axisY) { }

	public static void DetectPlane(Vector3 size, out int axisX, out int axisY) { }

	public static Mesh GenerateMesh(Vector2[] points, Vector2 center, bool swap, Vector2 uvMult, Vector2 uvAdd, Vector2 zSurfs) { }

	public static Mesh GenerateMesh(Vector2[] points, Vector2 center, float halfWith) { }

	public static MeshPiece GenerateMeshPice(Vector2[] points, bool swap, Vector2 uvMult, Vector2 uvAdd, Vector2 zSurfs, float edgesWidth) { }

	private static int[] GenerateTriangles(Vector2[] points) { }

	public static Polygon GetPolygonFormMesh(Mesh mesh, float scale) { }

	private static Vector2[] GetRandoms(int count) { }

	public static Vector2 GetXAxis(float angle) { }

	private static Vector2 IntersectLine(Vector2 pIn, Vector2 pOut, bool xAxis, float value) { }

	private void OnValidate() { }

	private static float PolygonArea(Vector2[] points) { }

	private static int PolygonInOut(List points, bool xAxis, bool positive, float value) { }

	private static int PolygonInOut(Vector2[] points, Vector4 box) { }

	private static Vector2[] RotatePoints(Vector2[] points, Vector2 xAxis) { }

}

