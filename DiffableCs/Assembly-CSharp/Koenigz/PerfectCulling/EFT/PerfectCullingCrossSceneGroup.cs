namespace Koenigz.PerfectCulling.EFT;

[RequireComponent(typeof(GuidComponent))]
public sealed class PerfectCullingCrossSceneGroup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetGroupRenderers>b__27_0(Renderer rend) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__VolumeCompare; //Field offset: 0x0

	}

	public static readonly List AllCrossGroups; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	public PerfectCullingBakeGroup[] bakeGroups; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	public GameObject[] sharedOccluders; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	public GameObject[] sharedOccludeeOccluders; //Field offset: 0x30
	[SerializeField]
	public SharedOccluder sharedOccluder; //Field offset: 0x38
	[SerializeField]
	public bool debugDrawVisibilityLines; //Field offset: 0x40
	[SerializeField]
	public bool lightsOnly; //Field offset: 0x41
	[SerializeField]
	public bool disableOnRuntime; //Field offset: 0x42
	[SerializeField]
	public BakeBatch[] bakeBatches; //Field offset: 0x48
	[SerializeField]
	public bool useGroundSuperSampling; //Field offset: 0x50
	[SerializeField]
	public bool disableGroupOnPointSample; //Field offset: 0x51
	[SerializeField]
	public bool allowGroupCulling; //Field offset: 0x52
	[SerializeField]
	public Transform groupRoot; //Field offset: 0x58
	[SerializeField]
	private Bounds _groupBoundingBox; //Field offset: 0x60
	[SerializeField]
	public bool AllowAdaptiveGridMapping; //Field offset: 0x78
	private FastArray _queueActivate; //Field offset: 0x80
	private FastArray _queueDeactivate; //Field offset: 0x88
	private ValueTuple _switchStats; //Field offset: 0x90
	private int _updateCounter; //Field offset: 0x98
	public int counterMainThread; //Field offset: 0x9C
	public int counterWorkThread; //Field offset: 0xA0
	public object lockUpdateVisibilityQueues; //Field offset: 0xA8
	public List _runtimeSharedVolumes; //Field offset: 0xB0
	public string runtimeGroupName; //Field offset: 0xB8
	private List _hiddenIndices; //Field offset: 0xC0

	public Bounds GroupBoundingBox
	{
		 get { } //Length: 21
	}

	public Transform GroupRoot
	{
		 get { } //Length: 280
	}

	internal bool IsCullingReady
	{
		internal get { } //Length: 81
	}

	public ValueTuple SwitchStats
	{
		 get { } //Length: 8
	}

	private static PerfectCullingCrossSceneGroup() { }

	public PerfectCullingCrossSceneGroup() { }

	public void AddHiddenIndex(Vector2Int v) { }

	private void Awake() { }

	internal void CreateAutoTestProxies() { }

	public void CreateRuntimeProxies() { }

	public void DeleteRuntimeProxies() { }

	private void DrawBounds() { }

	private void DrawVisibilityLines() { }

	internal void EditorUpdateVisibilitySetMT(CullingGroupData data) { }

	public Bounds get_GroupBoundingBox() { }

	public Transform get_GroupRoot() { }

	internal bool get_IsCullingReady() { }

	public ValueTuple get_SwitchStats() { }

	public int GetBakeHash() { }

	public int GetBakeHashDefault() { }

	public float GetDistanceToNearestRendererSquared(Vector3 point) { }

	public static HashSet GetGroupRenderers(Transform groupRoot, bool applyTypeFiltering = true, bool includeInactiveRenderers = true) { }

	public LODGroup[] GetLODGroups() { }

	public HashSet GetSharedOccluderRenderers() { }

	internal void InitializeGroup() { }

	internal void InitializeRuntime() { }

	private bool IsHiddenByBakedLOD(ushort index) { }

	private void OnDestroy() { }

	private void OnDrawGizmos() { }

	public void OnPostLevelLoaded() { }

	internal void PrepareGroups() { }

	private void RecomputeSwitchQueuesMT() { }

	public static void RefreshBakeGroups(PerfectCullingCrossSceneGroup group) { }

	public static void RefreshSharedOccluders(PerfectCullingCrossSceneGroup group) { }

	public void RemoveHiddenIndex(Vector2Int v) { }

	public static bool RendererFilter(Renderer renderer) { }

	internal void RuntimeUpdateVisibilitySetPackedMT(FastArray visibilityIndices) { }

	internal void ShutdownGroup() { }

	private void Start() { }

	private void Update() { }

	private void UpdateGroupBounds() { }

	private void UpdateSwitchQueues() { }

	public void UpdateSwitchQueuesMT() { }

	private void UpdateVisibilityCountersMT(ushort[] indices, int newCounter) { }

	public bool UpdateVisibleSetsMT(PerfectCullingCamera cam) { }

	private static int VolumeCompare(RuntimeCrossGroupVolume a, RuntimeCrossGroupVolume b) { }

}

