//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class Tracers : MonoBehaviour
{
	private static readonly int _mainTime; //Field offset: 0x0
	private readonly HashSet _usedShots; //Field offset: 0x20
	public float MaxDistance; //Field offset: 0x28
	public float Probobility; //Field offset: 0x2C
	public int Count; //Field offset: 0x30
	private Vector3[] _vertices; //Field offset: 0x38
	private Vector4[] _tangents; //Field offset: 0x40
	private Mesh _mesh; //Field offset: 0x48
	private Bounds _bounds; //Field offset: 0x50
	private Material _material; //Field offset: 0x68
	private bool _needToUpdate; //Field offset: 0x70
	private int _lastPos; //Field offset: 0x74
	private float _lastFrameTime; //Field offset: 0x78

	private static Tracers() { }

	public Tracers() { }

	private static void Abs(ref Vector3 vec) { }

	public void Awake() { }

	private void CreateTracer(Shot shot) { }

	public void EmitSeg(Vector3 start, Vector3 direction, float time) { }

	private static void ExpandBoundsFast(ref Bounds bounds, Vector3 p0, Vector3 p1) { }

	public void Fill(int pos, Vector2[] uv0, Vector2[] uv1, int[] triangles) { }

	private void LateUpdate() { }

	private void OnValidate() { }

	private void Start() { }

	private void Update() { }

	private void WorkCycle() { }

}

