namespace Systems.Effects;

public class TreePlaneLod : MonoBehaviour
{
	private static LinkedList _list; //Field offset: 0x0
	private static TreePlaneLod[] _array; //Field offset: 0x8
	private static Vector3[] _vertices; //Field offset: 0x10
	private static Vector3[] _normals; //Field offset: 0x18
	private static Vector4[] _tangents; //Field offset: 0x20
	private static Vector2[] _uv; //Field offset: 0x28
	private static Vector2[] _screenShift; //Field offset: 0x30
	private static int[] _triangles; //Field offset: 0x38
	private static Mesh _mesh; //Field offset: 0x40
	private static Vector3 _bMin; //Field offset: 0x48
	private static Vector3 _bMax; //Field offset: 0x54
	private static bool _initialized; //Field offset: 0x60
	public float Height; //Field offset: 0x20
	public float Width; //Field offset: 0x24
	public Material Mat; //Field offset: 0x28
	private int _id; //Field offset: 0x30

	private static TreePlaneLod() { }

	public TreePlaneLod() { }

	private void Awake() { }

	private static void CalcBounds(Vector3 position) { }

	private void OnBecameInvisible() { }

	private void OnBecameVisible() { }

	private void Start() { }

	private static void UpdateMesh() { }

}

