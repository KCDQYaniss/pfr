namespace EFT.SynchronizableObjects;

[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class TripwireProceduralMesh : MonoBehaviour
{
	private static readonly int _colorId; //Field offset: 0x0
	private const float BASE_WIDTH = 0.0025; //Field offset: 0x0
	private const float MAX_SEGMENT_LENGTH = 0.01; //Field offset: 0x0
	private static readonly int _reflectColorId; //Field offset: 0x4
	private Mesh _mesh; //Field offset: 0x20
	private MeshRenderer _meshRenderer; //Field offset: 0x28
	private MaterialPropertyBlock _propertyBlock; //Field offset: 0x30
	private Vector3 _fromPositionPivot; //Field offset: 0x38
	private Vector3 _toPositionPivot; //Field offset: 0x44
	private Vector3 _direction; //Field offset: 0x50
	private Vector3[] _vertices; //Field offset: 0x60
	private int[] _triangles; //Field offset: 0x68
	private int _currentSegmentCount; //Field offset: 0x70
	private float _previousTotalLength; //Field offset: 0x74
	private float _totalLength; //Field offset: 0x78
	[Range(0.1, 5)]
	public float Width; //Field offset: 0x7C
	[Range(1, 5)]
	public float SegmentLength; //Field offset: 0x80

	private static TripwireProceduralMesh() { }

	public TripwireProceduralMesh() { }

	private void GenerateMesh(bool forceRotate) { }

	public void Initialize(bool isVisualPlacer) { }

	public void SetColor(Color color) { }

	public void SetPosition(Vector3 fromPositionPivot, Vector3 toPositionPivot) { }

	private void SetupTriangles() { }

	private void SetupVertices() { }

	public void UpdateMeshIfNeeded(bool forceRotate = false) { }

}

