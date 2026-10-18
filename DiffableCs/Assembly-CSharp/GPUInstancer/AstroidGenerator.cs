namespace GPUInstancer;

public class AstroidGenerator : MonoBehaviour
{
	[Range(0, 200000)]
	public int count; //Field offset: 0x20
	public List asteroidObjects; //Field offset: 0x28
	public GPUInstancerPrefabManager prefabManager; //Field offset: 0x30
	public Transform centerTransform; //Field offset: 0x38
	private List asteroidInstances; //Field offset: 0x40
	private int instantiatedCount; //Field offset: 0x48
	private Vector3 center; //Field offset: 0x4C
	private Vector3 allocatedPos; //Field offset: 0x58
	private Quaternion allocatedRot; //Field offset: 0x64
	private Vector3 allocatedLocalEulerRot; //Field offset: 0x74
	private Vector3 allocatedLocalScale; //Field offset: 0x80
	private GPUInstancerPrefab allocatedGO; //Field offset: 0x90
	private GameObject goParent; //Field offset: 0x98
	private float allocatedLocalScaleFactor; //Field offset: 0xA0
	private int columnSize; //Field offset: 0xA4
	private int columnSpace; //Field offset: 0xA8

	public AstroidGenerator() { }

	private void Awake() { }

	private GPUInstancerPrefab InstantiateInCircle(Vector3 center, int column) { }

	private void SetRandomPosInCircle(Vector3 center, int column, float radius) { }

	private void Start() { }

}

