namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshSurface", 30)]
[DefaultExecutionOrder(-102)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshSurface.html")]
public class NavMeshSurface : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__85_0; //Field offset: 0x8
		public static Predicate <>9__86_0; //Field offset: 0x10
		public static Predicate <>9__86_1; //Field offset: 0x18
		public static Predicate <>9__86_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <AppendModifierVolumes>b__85_0(NavMeshModifierVolume x) { }

		internal bool <CollectSources>b__86_0(NavMeshModifier x) { }

		internal bool <CollectSources>b__86_1(NavMeshBuildSource x) { }

		internal bool <CollectSources>b__86_2(NavMeshBuildSource x) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static OnNavMeshPreUpdate <0>__UpdateActive; //Field offset: 0x0

	}

	public static Func ModifyColliders; //Field offset: 0x0
	private static readonly List s_NavMeshSurfaces; //Field offset: 0x8
	[SerializeField]
	private int m_AgentTypeID; //Field offset: 0x20
	[SerializeField]
	private CollectObjects m_CollectObjects; //Field offset: 0x24
	[SerializeField]
	private Vector3 m_Size; //Field offset: 0x28
	[SerializeField]
	private Vector3 m_Center; //Field offset: 0x34
	[SerializeField]
	private LayerMask m_LayerMask; //Field offset: 0x40
	[SerializeField]
	private NavMeshCollectGeometry m_UseGeometry; //Field offset: 0x44
	[SerializeField]
	private int m_DefaultArea; //Field offset: 0x48
	[SerializeField]
	private bool m_GenerateLinks; //Field offset: 0x4C
	[SerializeField]
	private bool m_IgnoreNavMeshAgent; //Field offset: 0x4D
	[SerializeField]
	private bool m_IgnoreNavMeshObstacle; //Field offset: 0x4E
	[SerializeField]
	private bool m_OverrideTileSize; //Field offset: 0x4F
	[SerializeField]
	private int m_TileSize; //Field offset: 0x50
	[SerializeField]
	private bool m_OverrideVoxelSize; //Field offset: 0x54
	[SerializeField]
	private float m_VoxelSize; //Field offset: 0x58
	[SerializeField]
	private float m_MinRegionArea; //Field offset: 0x5C
	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	private NavMeshData m_NavMeshData; //Field offset: 0x60
	[SerializeField]
	private bool m_BuildHeightMesh; //Field offset: 0x68
	private NavMeshDataInstance m_NavMeshDataInstance; //Field offset: 0x6C
	private Vector3 m_LastPosition; //Field offset: 0x70
	private Quaternion m_LastRotation; //Field offset: 0x7C

	public static List activeSurfaces
	{
		 get { } //Length: 84
	}

	public int agentTypeID
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool buildHeightMesh
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Vector3 center
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public CollectObjects collectObjects
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int defaultArea
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool ignoreNavMeshAgent
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool ignoreNavMeshObstacle
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public LayerMask layerMask
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float minRegionArea
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public NavMeshData navMeshData
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	internal NavMeshDataInstance navMeshDataInstance
	{
		internal get { } //Length: 4
	}

	public bool overrideTileSize
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool overrideVoxelSize
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Vector3 size
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public int tileSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public NavMeshCollectGeometry useGeometry
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float voxelSize
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	private static NavMeshSurface() { }

	public NavMeshSurface() { }

	private static Vector3 Abs(Vector3 v) { }

	public void AddData() { }

	private void AppendModifierVolumes(ref List sources) { }

	public void BuildNavMesh() { }

	private Bounds CalculateWorldBounds(List sources) { }

	private List CollectSources() { }

	public static List get_activeSurfaces() { }

	public int get_agentTypeID() { }

	public bool get_buildHeightMesh() { }

	public Vector3 get_center() { }

	public CollectObjects get_collectObjects() { }

	public int get_defaultArea() { }

	public bool get_ignoreNavMeshAgent() { }

	public bool get_ignoreNavMeshObstacle() { }

	public LayerMask get_layerMask() { }

	public float get_minRegionArea() { }

	public NavMeshData get_navMeshData() { }

	internal NavMeshDataInstance get_navMeshDataInstance() { }

	public bool get_overrideTileSize() { }

	public bool get_overrideVoxelSize() { }

	public Vector3 get_size() { }

	public int get_tileSize() { }

	public NavMeshCollectGeometry get_useGeometry() { }

	public float get_voxelSize() { }

	public NavMeshBuildSettings GetBuildSettings() { }

	private Bounds GetInflatedBounds() { }

	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	private bool HasTransformChanged() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private static void Register(NavMeshSurface surface) { }

	public void RemoveData() { }

	public void set_agentTypeID(int value) { }

	public void set_buildHeightMesh(bool value) { }

	public void set_center(Vector3 value) { }

	public void set_collectObjects(CollectObjects value) { }

	public void set_defaultArea(int value) { }

	public void set_ignoreNavMeshAgent(bool value) { }

	public void set_ignoreNavMeshObstacle(bool value) { }

	public void set_layerMask(LayerMask value) { }

	public void set_minRegionArea(float value) { }

	public void set_navMeshData(NavMeshData value) { }

	public void set_overrideTileSize(bool value) { }

	public void set_overrideVoxelSize(bool value) { }

	public void set_size(Vector3 value) { }

	public void set_tileSize(int value) { }

	public void set_useGeometry(NavMeshCollectGeometry value) { }

	public void set_voxelSize(float value) { }

	private static void Unregister(NavMeshSurface surface) { }

	private static void UpdateActive() { }

	private void UpdateDataIfTransformChanged() { }

	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

}

