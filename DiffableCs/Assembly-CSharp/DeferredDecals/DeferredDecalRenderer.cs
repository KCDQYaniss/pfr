namespace DeferredDecals;

public class DeferredDecalRenderer : MonoBehaviour
{
	private class CameraData
	{
		public CommandBuffer StaticDecalsBuffer; //Field offset: 0x10
		public CommandBuffer DynamicDecalsBuffer; //Field offset: 0x18
		public CullingGroup CullGroup; //Field offset: 0x20
		public bool IsStaticBufferDirty; //Field offset: 0x28
		public bool IsDynamicBufferDirty; //Field offset: 0x29

		public CameraData() { }

	}

	internal class ManagedMesh : IDisposable
	{
		private static int[] _triangles; //Field offset: 0x0
		private const int BoundsSize = 10000; //Field offset: 0x0
		private static int _nDecals; //Field offset: 0x8
		public readonly int VertexCount; //Field offset: 0x10
		public readonly Mesh Mesh; //Field offset: 0x18
		public readonly Vector3[] Vertices; //Field offset: 0x20
		public readonly Vector3[] Normals; //Field offset: 0x28
		public readonly Vector4[] Tangents; //Field offset: 0x30
		public readonly List Uvs0; //Field offset: 0x38
		public readonly List Uvs1; //Field offset: 0x40
		public readonly List Uvs2; //Field offset: 0x48

		public ManagedMesh(int nDecals) { }

		public override void Dispose() { }

		public void PasteProjectorIntoMiddle(int startvIndex, Vector3[] newDecalVerts, Vector4[] newDecalTangents, Vector3[] newDecalNormals, Vector4[] decalUv0Right, Vector4[] decalUv1Up, Vector4[] decalUv2Fwd) { }

		public void UpdateInnerMesh() { }

	}

	internal class SingleDecal
	{
		public bool RandomizeRotation; //Field offset: 0x10
		[MinMaxVec2(0, 2, -1)]
		public Vector2 DecalSize; //Field offset: 0x14
		[Range(1, 10)]
		public int TileSheetRows; //Field offset: 0x1C
		[Range(1, 10)]
		public int TileSheetColumns; //Field offset: 0x20
		public MaterialType[] DecalMaterialType; //Field offset: 0x28
		public Material DecalMaterial; //Field offset: 0x30
		public Material DynamicDecalMaterial; //Field offset: 0x38
		[HideInInspector]
		public float TileUSize; //Field offset: 0x40
		[HideInInspector]
		public float TileVSize; //Field offset: 0x44
		[HideInInspector]
		public bool IsTiled; //Field offset: 0x48

		public SingleDecal() { }

		public void Init() { }

	}

	private const float MaxStaticDecalSize = 0.4; //Field offset: 0x0
	[Range(0.001, 3)]
	[SerializeField]
	private float _decalProjectorHeight; //Field offset: 0x20
	[Range(0.001, 3)]
	[SerializeField]
	private float _decalProjectorHeightForGrenade; //Field offset: 0x24
	[Range(1, 1024)]
	[SerializeField]
	private int _maxDecals; //Field offset: 0x28
	[Range(1, 1024)]
	[SerializeField]
	private int _maxDynamicDecals; //Field offset: 0x2C
	[Range(1, 1000)]
	[SerializeField]
	private int _cullDistance; //Field offset: 0x30
	[SerializeField]
	private SingleDecal[] _decals; //Field offset: 0x38
	[SerializeField]
	private SingleDecal _environmentBlood; //Field offset: 0x40
	[SerializeField]
	private SingleDecal _bleedingDecal; //Field offset: 0x48
	[SerializeField]
	private SingleDecal _grenadeDecal; //Field offset: 0x50
	[SerializeField]
	private SingleDecal _genericDecal; //Field offset: 0x58
	[SerializeField]
	private Mesh _cube; //Field offset: 0x60
	private readonly Queue _managedMeshes; //Field offset: 0x68
	private readonly Dictionary _meshesDict; //Field offset: 0x70
	private readonly Dictionary _decalsDict; //Field offset: 0x78
	private int _currentDecalIndex; //Field offset: 0x80
	private int _maxVertsInMesh; //Field offset: 0x84
	private int _normalsId; //Field offset: 0x88
	private Dictionary _cameras; //Field offset: 0x90
	private BoundingSphere[] _dynamicDecalsBoundingSpheres; //Field offset: 0x98
	private int _currentDynamicDecalIndex; //Field offset: 0xA0
	private List _dynamicDecals; //Field offset: 0xA8
	private Vector4[] _decalUv0Right; //Field offset: 0xB0
	private Vector4[] _decalUv1Up; //Field offset: 0xB8
	private Vector4[] _decalUv2Fwd; //Field offset: 0xC0
	private Vector3[] _newDecalVerts; //Field offset: 0xC8
	private Vector3[] _newDecalNormals; //Field offset: 0xD0
	private Vector4[] _newDecalTangents; //Field offset: 0xD8
	private Transform _dynamicDecalsParent; //Field offset: 0xE0
	private CommandBuffer _staticBuf; //Field offset: 0xE8
	private CommandBuffer _dynamicBuf; //Field offset: 0xF0
	private bool _updateBuffersInNewCamera; //Field offset: 0xF8

	public DeferredDecalRenderer() { }

	private void AddCubeToMesh(Vector3 position, Vector3 normal, ManagedMesh mesh, SingleDecal decal, float projectorHeight) { }

	private void Awake() { }

	private bool CanBeRendered(Camera currentCamera) { }

	public void Clear() { }

	private void ClearCamData() { }

	private void CreateDecalMesh(SingleDecal decal) { }

	private void CreateDynamicDecals() { }

	private void CreateManagedMeshes(int size) { }

	private void DestroyDynamicDecals() { }

	public void DrawDecal(RaycastHit hit, BallisticCollider hitCollider) { }

	public void DrawDecal(Vector3 position, Vector3 normal, BallisticCollider hitCollider, bool isGrenade) { }

	private void DrawDynamicDecals(Camera currentCamera, CommandBuffer buffer) { }

	private void DrawStaticDecals(Camera currentCamera, CommandBuffer buffer) { }

	public void EmitBleeding(Vector3 position, Vector3 normal) { }

	public void EmitBloodOnEnvironment(Vector3 position, Vector3 normal) { }

	private void GetDynamicDecal(Vector3 position, Vector3 normal, BallisticCollider hitCollider, SingleDecal currentDecal, Material currentMaterial, float projectorHeight) { }

	private ManagedMesh GetManagedMesh() { }

	private SingleDecal GetSingleDecal(BallisticCollider hitCollider, bool isGrenade) { }

	private void MakeDynamicBufferDirty() { }

	private void OnDestroy() { }

	public void OnDisable() { }

	public void OnPreCameraRender(Camera currentCamera) { }

	public void OnPreCullCameraRender(Camera currentCamera) { }

	public void SetMaxDynamicDecals(int maxDecals) { }

	public void SetMaxStaticDecals(int maxDecals) { }

	private void Update() { }

	private void UpdateBuffer(CommandBuffer buffer, Camera currentCamera, Action drawFunc) { }

}

