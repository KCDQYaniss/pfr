//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
public class MeshProjector : MonoBehaviour
{
	private const float RaycastDistance = 50; //Field offset: 0x0
	public static Action OnMeshUpdated; //Field offset: 0x0
	private LayerMask _projectionLayers; //Field offset: 0x20
	[Range(0, 1)]
	[SerializeField]
	private float _offset; //Field offset: 0x24
	[SerializeField]
	private float _raycastOffset; //Field offset: 0x28
	[HideInInspector]
	public bool UpdateByTimer; //Field offset: 0x2C
	[HideInInspector]
	public float UpdateTime; //Field offset: 0x30
	private Transform _transform; //Field offset: 0x38
	private MeshFilter _meshFilter; //Field offset: 0x40
	private float _timer; //Field offset: 0x48

	public MeshProjector() { }

}

