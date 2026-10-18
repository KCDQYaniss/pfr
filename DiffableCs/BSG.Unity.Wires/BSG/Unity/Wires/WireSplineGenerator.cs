namespace BSG.Unity.Wires;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class WireSplineGenerator : MonoBehaviour
{
	internal struct Point
	{
		public Vector3 Position; //Field offset: 0x0
		public Vector3 Upward; //Field offset: 0xC
		public Vector3 Right; //Field offset: 0x18

	}

	internal class Shape
	{
		public Vector2[] Vertices; //Field offset: 0x10
		public float[] Uv; //Field offset: 0x18
		public int[] TrisA; //Field offset: 0x20
		public int[] TrisB; //Field offset: 0x28

		public Shape() { }

	}

	internal class Wire
	{
		public Vector3[] Positins; //Field offset: 0x10
		public Vector3[] Normals; //Field offset: 0x18
		public int Parts; //Field offset: 0x20
		private Vector3[] _optimized; //Field offset: 0x28

		public Wire() { }

		public void Generate(Shape shape, ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector2[] uv0, float error) { }

		public static void Generate(Shape shape, Point[] points, ref int vIndex, ref int tIndex, int[] triangles, Vector3[] positions, Vector2[] uv0) { }

		public void GeneratePoints(float error) { }

		public Point[] GeneratePoints(Vector3[] positions) { }

		public int GetTrianglesCount(Shape shape) { }

		public int GetVerticesCount(Shape shape) { }

	}

	public Wire[] Wires; //Field offset: 0x20
	public int ShapeDetails; //Field offset: 0x28
	public float ShapeSize; //Field offset: 0x2C
	public float Error; //Field offset: 0x30
	private MeshFilter _meshFilter; //Field offset: 0x38
	public Mesh Mesh; //Field offset: 0x40

	public WireSplineGenerator() { }

	private static Vector3 Bezier(float t, Vector3 p0, Vector3 n0, Vector3 n1, Vector3 p1) { }

	private static Shape CreateShape(int details, float size) { }

	public void Generate() { }

	public static Vector3 GetCurve(float t, Vector3 p0, Vector3 n0, Vector3 n1, Vector3 p1) { }

	private static Vector3[] GetPoints(Wire wire) { }

	public static Vector3[] GetPoints(Vector3 p0, Vector3 p1, Vector3 n0, Vector3 n1, int parts) { }

	private static Vector3 Hermite(float t, Vector3 p0, Vector3 m0, Vector3 m1, Vector3 p1) { }

	private static Vector3[] Optimize(Vector3[] points, float error) { }

	private static void Optimize(LinkedList points, float error) { }

}

