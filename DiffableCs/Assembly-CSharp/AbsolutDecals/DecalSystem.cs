namespace AbsolutDecals;

[ExecuteInEditMode]
public class DecalSystem : MonoBehaviourSingleton
{
	internal enum BakeResult
	{
		Unsuccess = 0,
		BakedToSkinnedMesh = 1,
		BakedToMesh = 2,
	}

	internal class SingleDecal
	{
		public Material DecalMaterial; //Field offset: 0x10
		public int TileSheetRows; //Field offset: 0x18
		public int TileSheetColumns; //Field offset: 0x1C
		public bool UseRandomScale; //Field offset: 0x20
		public Vector3 MaxScale; //Field offset: 0x24
		public Vector3 MinScale; //Field offset: 0x30
		public bool CanRotate; //Field offset: 0x3C
		public MaterialType TypeOfMaterial; //Field offset: 0x40
		private bool _isPrecalculated; //Field offset: 0x44
		private Vector2[][] uvSet; //Field offset: 0x48

		public SingleDecal() { }

		private void CalculateUv() { }

		public Vector3 GetScale() { }

		public Vector2[] GetUv() { }

	}

	private const int _maxUniqueDecalQueueCapasity = 20; //Field offset: 0x0
	private const string IgnoreProjectorTag = "DecalIgnore"; //Field offset: 0x0
	private static List _skinnedMeshRenderers; //Field offset: 0x0
	private static List _skinnedMeshBoneWeights; //Field offset: 0x8
	private static List _skinnedMeshTransforms; //Field offset: 0x10
	private static TemporaryMesh _terrainMesh; //Field offset: 0x18
	private static GameObject _decalsParent; //Field offset: 0x20
	private static Dictionary _bakedMeshes; //Field offset: 0x28
	private static Dictionary _bakedReusableMeshes; //Field offset: 0x30
	private static Dictionary _reusableMeshesProjectors; //Field offset: 0x38
	private static Dictionary _projectors; //Field offset: 0x40
	private static Dictionary _uniqueMeshes; //Field offset: 0x48
	private static Queue _uniqueMeshObjects; //Field offset: 0x50
	private static Dictionary _skinnedDecals; //Field offset: 0x58
	private static int _currentIndex; //Field offset: 0x60
	public static Action CallProjectors; //Field offset: 0x68
	public SingleDecal DefaultMaterial; //Field offset: 0x20
	public SingleDecal BloodOnWallsMaterial; //Field offset: 0x28
	public SingleDecal[] Decals; //Field offset: 0x30
	private List _renderers; //Field offset: 0x38
	private List _meshes; //Field offset: 0x40
	private List _tmpMeshes; //Field offset: 0x48
	private List _transforms; //Field offset: 0x50
	[SerializeField]
	private List _staticRenderers; //Field offset: 0x58
	[SerializeField]
	private List _staticMeshes; //Field offset: 0x60
	[SerializeField]
	private List _staticTmpMeshes; //Field offset: 0x68
	[SerializeField]
	private List _staticTransforms; //Field offset: 0x70
	public int count; //Field offset: 0x78
	[SerializeField]
	private float _offset; //Field offset: 0x7C
	[SerializeField]
	private string[] _ignoreProjectorTags; //Field offset: 0x80
	[SerializeField]
	private LayerMask _ingoreDecalsLayers; //Field offset: 0x88
	[SerializeField]
	private int _maxDecalsOnSkinMesh; //Field offset: 0x8C
	[SerializeField]
	private int MaxMeshVerticies; //Field offset: 0x90
	[SerializeField]
	private bool _includeTerrain; //Field offset: 0x94
	public Action OnAssetsReadyToSave; //Field offset: 0x98
	[CompilerGenerated]
	private GameObject <ProjectorsParent>k__BackingField; //Field offset: 0xA0
	private List _skinnedMeshes; //Field offset: 0xA8

	public private GameObject ProjectorsParent
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static DecalSystem() { }

	protected DecalSystem() { }

	private bool AddMeshToList(Renderer currentRenderer, bool forStatic) { }

	private void AddToExistingMesh(ProjectorHelper projectorHelper, MeshFilter filter, Mesh mesh, TemporaryMesh tmpMesh) { }

	public virtual void Awake() { }

	public void BakeAndSaveAll() { }

	public BakeResult BakeDecal(DecalProjector projector, bool bakeToReusableMesh) { }

	private BakeResult BakeToInfinityListOfMeshes(Material projectorMaterial, ProjectorHelper projectorHelper, DecalProjector projector) { }

	private BakeResult BakeToReusableMesh(Material projectorMaterial, ProjectorHelper projectorHelper, DecalProjector projector) { }

	public BakeResult BakeToSkinnedMesh(TemporaryMesh meshToBake, DecalProjector projector) { }

	public bool BakeUniqueDecal(DecalProjector projector) { }

	private void CallDestroy() { }

	private void ClearAllLists() { }

	private void ClearDynamicLists() { }

	private void ClearSkinnedLists() { }

	public void ClearStaticLists() { }

	private bool CreateNewMesh(DecalProjector projector, string namePrefix, Material projectorMaterial, ProjectorHelper projectorHelper, out MeshFilter resultFilter, TemporaryMesh tmpMeshPrecalc = null) { }

	private SkinnedMeshRenderer CreateSkinnedDecal(SkinnedMeshRenderer doll) { }

	public void FindProjectors() { }

	[CompilerGenerated]
	public GameObject get_ProjectorsParent() { }

	public SingleDecal GetDecal(MaterialType typeOfMaterial) { }

	public TemporaryMesh GetDecalMesh(DecalProjector projector, bool inProjectorSpace) { }

	public Transform GetRelativeTransform(SkinnedMeshRenderer doll, out bool success) { }

	private void OnDestroy(bool destroyProjectors) { }

	public virtual void OnDestroy() { }

	public void RegisterProjector(DecalProjector projector) { }

	public void RegisterRenderer(GameObject go) { }

	[CompilerGenerated]
	private void set_ProjectorsParent(GameObject value) { }

	public void Start() { }

	public void UnbakeDecal(DecalProjector projector) { }

	public void UnregisterProjector(DecalProjector decalProjector, bool destroyMesh = false) { }

	public void UpdateNonStaticSceneData() { }

	private static void UpdateProjectorsAfterRemoval(ProjectorHelper projector, Dictionary projectorHelpers) { }

	public void UpdateSceneData(bool updateStatic) { }

	public void UpdateSkinnedMeshSceneData() { }

	public void UpdateStaticSceneData() { }

}

