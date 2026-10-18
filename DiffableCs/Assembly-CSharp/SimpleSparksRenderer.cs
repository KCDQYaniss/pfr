//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class SimpleSparksRenderer : MonoBehaviour
{
	private static readonly int _mainTime; //Field offset: 0x0
	private static readonly int _lastMainTime; //Field offset: 0x4
	public int Segments; //Field offset: 0x20
	public int Count; //Field offset: 0x24
	private Vector3[] _vertices; //Field offset: 0x28
	private Vector3[] _normals; //Field offset: 0x30
	private Vector4[] _tangents; //Field offset: 0x38
	private Color32[] _colors; //Field offset: 0x40
	private Mesh _mesh; //Field offset: 0x48
	private Bounds _bounds; //Field offset: 0x50
	private bool _needToUpdate; //Field offset: 0x68
	private int _lastPos; //Field offset: 0x6C
	private float _lastFrameTime; //Field offset: 0x70
	private Renderer _renderer; //Field offset: 0x78
	private MaterialPropertyBlock _materialPropertyBlock; //Field offset: 0x80

	private static SimpleSparksRenderer() { }

	public SimpleSparksRenderer() { }

	public void Awake() { }

	public void EmitSeg(Vector3 position, Vector3 velocity, float time, float gravity, float drag, float lifeTime, byte emission = 255, byte size = 255, byte turbulence = 255, byte frequency = 255) { }

	public static void ExpandBoundsFast(ref Bounds bounds, Vector3 position, float size) { }

	public void Fill(int pos, Vector2[] uv0, Vector2[] uv1, int[] triangles) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void Update() { }

}

