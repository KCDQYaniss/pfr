//Type is in global namespace

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class DecalSystem : MonoBehaviour
{
	private class Decal
	{
		public int Pos4; //Field offset: 0x10
		public Vector3[] Vertices; //Field offset: 0x18
		public Vector3 Normal; //Field offset: 0x20
		public Vector4 Tangent; //Field offset: 0x2C
		public Vector2[] Uv; //Field offset: 0x40

		public Decal() { }

		public void Calc(Vector3 position, Vector3 normal, float radius) { }

		public void FastCalcWithoutRotation(Vector3 position, Vector3 normal, float radius) { }

		public void Update(Vector3[] vertices, Vector3[] normals, Vector4[] tangents) { }

		public void Update(Vector3[] vertices, Vector3[] normals, Vector4[] tangents, Vector2[] uv) { }

	}

	public int Count; //Field offset: 0x20
	public float SizeMin; //Field offset: 0x24
	public float SizeRandomRange; //Field offset: 0x28
	private bool _sizeRandom; //Field offset: 0x2C
	public int TileSheetRows; //Field offset: 0x30
	public int TileSheetColumns; //Field offset: 0x34
	private Vector2[][] _tiles; //Field offset: 0x38
	private int _tilesCount; //Field offset: 0x40
	private bool _updateUv; //Field offset: 0x44
	private LinkedList _changedDecals; //Field offset: 0x48
	private int _currentDecalId; //Field offset: 0x50
	private Decal[] _decals; //Field offset: 0x58
	private Vector3[] _vertices; //Field offset: 0x60
	private Vector3[] _normals; //Field offset: 0x68
	private Vector4[] _tangents; //Field offset: 0x70
	private Vector2[] _uv; //Field offset: 0x78
	private Vector2[] _uv2Vals; //Field offset: 0x80
	private int[] _triangles; //Field offset: 0x88
	private Mesh _mesh; //Field offset: 0x90
	private Vector3 _bMin; //Field offset: 0x98
	private Vector3 _bMax; //Field offset: 0xA4

	public DecalSystem() { }

	public void Add(Vector3 position, Vector3 normal) { }

	public void Add(Vector3 position, Vector3 normal, int tile) { }

	private void Awake() { }

	private void CalcBounds(Vector3 position) { }

	public void Clear() { }

	private void LateUpdate() { }

}

