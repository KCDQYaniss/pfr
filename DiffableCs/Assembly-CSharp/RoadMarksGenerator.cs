//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RoadMarksGenerator : MonoBehaviour
{
	public RoadSplineGenerator Parent; //Field offset: 0x20
	public int Road; //Field offset: 0x28
	public float Shift; //Field offset: 0x2C
	public float Width; //Field offset: 0x30
	public float MarkLength; //Field offset: 0x34
	public float MarkDist; //Field offset: 0x38
	[Range(0, 1)]
	public float Start; //Field offset: 0x3C
	[Range(0, 1)]
	public float End; //Field offset: 0x40
	public Rect UvRect; //Field offset: 0x44
	public float RoadOffset; //Field offset: 0x54
	public int LodParts; //Field offset: 0x58
	[Range(0, 100)]
	public float CullingRate; //Field offset: 0x5C
	private MeshFilter _meshFilter; //Field offset: 0x60
	private float _actualCullingRate; //Field offset: 0x68
	public string Culled; //Field offset: 0x70
	public LayerMask Mask; //Field offset: 0x78
	private float _oldStart; //Field offset: 0x7C
	private bool _copyColorsInReverseOrder; //Field offset: 0x80

	public RoadMarksGenerator() { }

	private void Awake() { }

	private void FillMesh(Vector3[] marksPos, int[] tris, Vector3[] verts, Vector3[] normals, Vector4[] tangents, Vector2[] uv, Rect uvRect, float width, Color[] colors, Color[] oldColors, bool copyColorsInReverseOrder) { }

	public Vector3 FixOnGround(Vector3 point) { }

	private void Generate() { }

	private void GenerateLods(Vector3[] marksPos, int parts, float cullingRate) { }

	public static void GeneratePoints(Vector3[] positions, float[] lengths, float shift) { }

	private static Vector3[] GetMarksPos(Road road, float shift, float markLength, float markDist, float start, float end) { }

	private Mesh GetMesh(Vector3[] marksPos, Mesh mesh = null) { }

	public static Vector3 Lerp(Vector3 from, Vector3 to, float t) { }

	private void OnValidate() { }

	private Vector3[][] Split(Vector3[] marksPos, int parts) { }

}

