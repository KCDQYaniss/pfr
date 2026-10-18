//Type is in global namespace

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class TracerSystem : MonoBehaviour
{
	private class Particle
	{
		public int Pos4; //Field offset: 0x10
		public Vector3[] Vertices; //Field offset: 0x18
		public Vector2 Uv2Val; //Field offset: 0x20
		public Color32 Color; //Field offset: 0x28

		public Particle() { }

		public void Calc(Vector3 start, Vector3 end, float size, float time, Color32 color) { }

		public void Update(Vector3[] vertices, Vector2[] uv2, Color32[] colors) { }

	}

	public int Count; //Field offset: 0x20
	public float Size; //Field offset: 0x24
	private int _count2; //Field offset: 0x28
	private LinkedList _changedParticles; //Field offset: 0x30
	private Particle[] _particles; //Field offset: 0x38
	private int _currentParticleId; //Field offset: 0x40
	private Vector3[] _vertices; //Field offset: 0x48
	private Vector3[] _normals; //Field offset: 0x50
	private Vector4[] _tangents; //Field offset: 0x58
	private Vector2[] _uv; //Field offset: 0x60
	private Vector2[] _uv2Vals; //Field offset: 0x68
	private Color32[] _colors; //Field offset: 0x70
	private int[] _triangles; //Field offset: 0x78
	private Mesh _mesh; //Field offset: 0x80
	private Vector3 _bMin; //Field offset: 0x88
	private Vector3 _bMax; //Field offset: 0x94

	public TracerSystem() { }

	public void Add(Vector3 start, Vector3 end, Color32 color) { }

	public void Add(Vector3 start, Vector3 end, Color32 color, float size, float time = 1) { }

	private void Awake() { }

	private void CalcBounds(Vector3 position) { }

	private void LateUpdate() { }

}

