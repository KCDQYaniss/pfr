//Type is in global namespace

[ExecuteInEditMode]
[ScriptOrder(20010)]
public class StaticDeferredDecalRenderer : MonoBehaviour
{
	private class CameraDecalsCommandBuffers
	{
		public CommandBuffer BeginCB; //Field offset: 0x10
		public CommandBuffer EndCB; //Field offset: 0x18
		public HashSet DrawCBs; //Field offset: 0x20

		public CameraDecalsCommandBuffers() { }

	}

	internal class DecalsData
	{
		public string Hash; //Field offset: 0x10
		public Material ParentMaterial; //Field offset: 0x18
		public Material OwnMaterial; //Field offset: 0x20
		public int DecalQueue; //Field offset: 0x28
		public List Decals; //Field offset: 0x30
		public Bounds Bounds; //Field offset: 0x38

		public DecalsData(string hash, Material decalMaterial, int decalQueue, List decals, Bounds initialBounds) { }

	}

	private const int MaxDecalsCount = 60000; //Field offset: 0x0
	[CompilerGenerated]
	private static StaticDeferredDecalRenderer <Instance>k__BackingField; //Field offset: 0x0
	private static readonly int _bumpMapTextureID; //Field offset: 0x8
	private static readonly int _decalID; //Field offset: 0xC
	private static readonly int[] _trigs; //Field offset: 0x10
	private static readonly Vector3[] _verts; //Field offset: 0x18
	private static readonly int _normalsId; //Field offset: 0x20
	public int DecalsGridSize; //Field offset: 0x20
	private BoundingFrustum CameraFrustum; //Field offset: 0x28
	public bool UseQuadTreeRenderInEditor; //Field offset: 0x30
	public bool UseQuadTreeRenderInPlayMode; //Field offset: 0x31
	public bool UseTexturesQuadTreeInEditor; //Field offset: 0x32
	public bool UseTexturesQuadTreeInPlayMode; //Field offset: 0x33
	public bool QuadTreeRecordPerFrame; //Field offset: 0x34
	public bool UseTreeAsync; //Field offset: 0x35
	private bool _oldUseRenderGrid; //Field offset: 0x36
	private bool _oldUseTexturesGrid; //Field offset: 0x37
	public int TreeCmdBufMaxDepth; //Field offset: 0x38
	public int TreeTexturesMaxDepth; //Field offset: 0x3C
	public int TreeThreadSleepTime; //Field offset: 0x40
	private float CameraMaxHScale; //Field offset: 0x44
	private float CameraMaxVScale; //Field offset: 0x48
	private int _oldDecalsGridSize; //Field offset: 0x4C
	private int _allDecalsCount; //Field offset: 0x50
	private bool _decalBuffersDirty; //Field offset: 0x54
	private readonly DictionaryListHydra _decals; //Field offset: 0x58
	private readonly SortedList _instances; //Field offset: 0x60
	private readonly Dictionary _cameras; //Field offset: 0x68
	private Mesh _decalMesh; //Field offset: 0x70
	private StaticDeferredDecalQuadTree _quadTree; //Field offset: 0x78
	private Dictionary _texturesQuadTrees; //Field offset: 0x80
	private List _texturesQuadTreesList; //Field offset: 0x88
	public int UpdateTexturesPerFrame; //Field offset: 0x90
	private int _lastUpdatedTexture; //Field offset: 0x94
	private readonly RenderTargetIdentifier[] _mrt; //Field offset: 0x98
	private Vector4[] frustumPlanesVectors; //Field offset: 0xA0
	private Plane[] frustumPlanes; //Field offset: 0xA8
	private Vector3[] corners; //Field offset: 0xB0

	public private static StaticDeferredDecalRenderer Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	private static StaticDeferredDecalRenderer() { }

	public StaticDeferredDecalRenderer() { }

	private void AddCommandBufferOnCamera(Camera camera) { }

	private void AddDecal(StaticDeferredDecal decal, bool updateInstances) { }

	private void AddEarlyDecals() { }

	private void Awake() { }

	private void CameraRender(Camera currentCamera) { }

	private void ClearCamerasData() { }

	private void ClearDecals() { }

	private void ClearTree() { }

	private void ComputeDecalMinMaxPoints(StaticDeferredDecal decal, ref Vector3 minPoint, ref Vector3 maxPoint) { }

	private string ComputeHash(StaticDeferredDecal decal) { }

	private void ConstructQuadTree() { }

	private void CreateMesh() { }

	private void DestroyMesh() { }

	private bool FrustumTest(StaticDeferredDecalDrawInstance drawInstance) { }

	[CompilerGenerated]
	public static StaticDeferredDecalRenderer get_Instance() { }

	public StaticDeferredDecalDrawInstance[] GetDecalDrawInstancesArray() { }

	private Mesh GetMesh() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDrawGizmosSelected() { }

	private void QuadTreeNodePreDraw(CommandBuffer cmdBuf) { }

	public void Refresh() { }

	private void RefreshDecals() { }

	private void RegisterDecal(StaticDeferredDecal decal, bool updateInstances) { }

	public void ReInitialize() { }

	private void RemoveCommandBuffersForCamera(Camera cam) { }

	private void RemoveDecal(StaticDeferredDecal decal, bool updateInstances) { }

	[CompilerGenerated]
	private static void set_Instance(StaticDeferredDecalRenderer value) { }

	private void SubscribeOnCameraEvents() { }

	private void SubscribeOnDecalEvents() { }

	private void UnregisterDecal(StaticDeferredDecal decal, bool updateInstances) { }

	private void UnsubscribeFromCameraEvents() { }

	private void UnsubscribeFromDecalEvents() { }

	private void UpdateBuffer(Camera currentCamera) { }

	public void UpdateInstancesBuffers() { }

}

