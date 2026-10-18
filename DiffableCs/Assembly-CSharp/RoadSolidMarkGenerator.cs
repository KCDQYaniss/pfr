//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RoadSolidMarkGenerator : MonoBehaviour
{
	public RoadSplineGenerator Parent; //Field offset: 0x20
	public int Road; //Field offset: 0x28
	public float Shift; //Field offset: 0x2C
	public float Width; //Field offset: 0x30
	[Range(0, 1)]
	public float Start; //Field offset: 0x34
	[Range(0, 1)]
	public float End; //Field offset: 0x38
	public Rect UvRect; //Field offset: 0x3C
	public float RoadOffset; //Field offset: 0x4C
	public int LodParts; //Field offset: 0x50
	[Range(0, 100)]
	public float CullingRate; //Field offset: 0x54
	private MeshFilter _meshFilter; //Field offset: 0x58
	private float _actualCullingRate; //Field offset: 0x60
	public string Culled; //Field offset: 0x68
	public LayerMask Mask; //Field offset: 0x70
	private float _oldStart; //Field offset: 0x74
	private bool _copyColorsInReverseOrder; //Field offset: 0x78

	public RoadSolidMarkGenerator() { }

	private void Awake() { }

	private static void FillMesh(Vector3[] points, Vector3[] forwards, int[] tris, Vector3[] verts, Vector3[] normals, Vector4[] tangents, Vector2[] uv, Rect uvRect, float width, ref float uvY, Color[] colors, Color[] oldColors, bool copyColorsInReverseOrder) { }

	public Vector3 FixOnGround(Vector3 point) { }

	private void Generate() { }

	private void GenerateLods(Vector3[] points, int parts, float cullingRate) { }

	public static Vector3[] GeneratePoints(Vector3[] positions, float start, float end, float shift) { }

	public static Vector3[] GetForwards(Vector3[] points) { }

	private Mesh GetMesh(Vector3[] points, Vector3[] forwards, ref float uvY, Mesh mesh = null) { }

	public static Vector3 Lerp(Vector3 from, Vector3 to, float t) { }

	private void OnValidate() { }

	private static void SplitPoints(Vector3[] points, Vector3[] forwards, int parts, out Vector3[][] lodsPoints, out Vector3[][] lodsForwards) { }

}

