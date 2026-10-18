namespace Koenigz.PerfectCulling.EFT;

public sealed class PerfectCullingCrossSceneSampler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__78_0; //Field offset: 0x8
		public static Func <>9__78_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Camera <LocateGameCameras>b__78_0() { }

		internal Camera <LocateGameCameras>b__78_1() { }

	}

	[CompilerGenerated]
	private struct <InitializeAutoCulling>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken token; //Field offset: 0x20
		public IProgress progress; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class CameraState
	{
		public bool IsActive; //Field offset: 0x10
		public Vector3 Position; //Field offset: 0x14
		public float FieldOfView; //Field offset: 0x20
		public Func CameraGetter; //Field offset: 0x28

		public CameraState(Func cam) { }

		public void Update() { }

	}

	private sealed class GridTaskParameters
	{
		public PerfectCullingAdaptiveGrid grid; //Field offset: 0x10

		public GridTaskParameters() { }

	}

	private struct OverlapCellJob : IJob
	{
		public Vector3 ObservePosition; //Field offset: 0x0

		public override void Execute() { }

	}

	private struct RecomputeVisibilityJob : IJob
	{
		public Vector3 ObservePosition; //Field offset: 0x0

		private void DecompressCallback(TemporaryCullingCellData e) { }

		public override void Execute() { }

		private static CullingCellData GetNearestOriented(CullingCellData[] buffer, int numElementsInBuffer, Vector3 point, out int bestCell) { }

	}

	private struct SnapFillJob : IJobParallelFor
	{
		public LayerMask Mask; //Field offset: 0x0
		public Vector3 CamPos; //Field offset: 0x4
		[WriteOnly]
		public NativeArray SnapRaycastCommands; //Field offset: 0x10
		[WriteOnly]
		public NativeArray SnapRaycastResults; //Field offset: 0x20

		public override void Execute(int index) { }

	}

	private struct SnapUpdateJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray SnapRaycastResults; //Field offset: 0x0

		public override void Execute(int index) { }

	}

	private sealed class WorkItem
	{
		public HashSet VolumeIds; //Field offset: 0x10
		public HashSet GroupIds; //Field offset: 0x18
		public ManualResetEventSlim WorkThreadWaitHandle; //Field offset: 0x20
		public object LockUpdate; //Field offset: 0x28
		public long WorkTime; //Field offset: 0x30

		public WorkItem() { }

		public void Clear() { }

	}

	private static class WorkJob
	{
		internal struct PrepareVolumesJob : IJobParallelFor
		{

			public override void Execute(int index) { }

		}

		internal struct UpdateVisibilityJob : IJobParallelFor
		{

			public override void Execute(int index) { }

		}

		public static WorkThreadParams JobParams; //Field offset: 0x0
		public static CancellationTokenSource TerminateToken; //Field offset: 0x8
		public static readonly HashSet[] VolumeIds; //Field offset: 0x10
		public static readonly HashSet[] GroupIds; //Field offset: 0x18
		private static readonly List[] _sortedIndices; //Field offset: 0x20
		private static readonly List[] _removeCells; //Field offset: 0x28

		private static WorkJob() { }

	}

	private sealed class WorkThreadParams
	{
		public PerfectCullingCamera camera; //Field offset: 0x10
		public int threadId; //Field offset: 0x18
		public int numThreads; //Field offset: 0x1C

		public WorkThreadParams() { }

	}

	[CompilerGenerated]
	private static PerfectCullingCrossSceneSampler <Instance>k__BackingField; //Field offset: 0x0
	public const int MAX_OVERLAP_BUFFER_SIZE = 512; //Field offset: 0x0
	private const int GRID_QUERY_AWAIT_TIME = 100; //Field offset: 0x0
	private const int GRID_QUERY_DELAY_TIME = 1; //Field offset: 0x0
	private const string LOW_POLY_COLLIDER_LAYER = "LowPolyCollider"; //Field offset: 0x0
	private static CancellationTokenSource _terminateTokenSource; //Field offset: 0x8
	private static CancellationToken _terminateToken; //Field offset: 0x10
	public static bool disableWorkThread; //Field offset: 0x18
	public static bool disableReuse; //Field offset: 0x19
	public static bool disableSampling; //Field offset: 0x1A
	private static AnalyticSource[] _analSources; //Field offset: 0x20
	private static readonly WorkItem[] _workItems; //Field offset: 0x28
	private static CullingGridVisibilitySampler _cullingGridVisibilitySampler; //Field offset: 0x30
	private static CullingGridContentSwitcher _cullingGridContentSwitcher; //Field offset: 0x38
	private static int _cullingCellId; //Field offset: 0x40
	internal static float GRID_QUERY_RADIUS; //Field offset: 0x44
	private static CullingCellData _activeCell; //Field offset: 0x48
	private static float _lodBias; //Field offset: 0x50
	private static object kSetCullingCellLock; //Field offset: 0x58
	private static readonly List AllGameCameras; //Field offset: 0x60
	private static int _recomputeVisibilityJobTimeMs; //Field offset: 0x68
	private static Vector3[] kClosestSnapPoints; //Field offset: 0x70
	private static bool[] _snapTestInsideFlag; //Field offset: 0x78
	private static NativeArray _snapRaycastCommands; //Field offset: 0x80
	private static NativeArray _snapRaycastResults; //Field offset: 0x90
	private static int _numOverlapCells; //Field offset: 0xA0
	private static bool[] kTempOverlapSnapAllowed; //Field offset: 0xA8
	private static CullingCellData[] kTempOverlapBuffer; //Field offset: 0xB0
	private static LayerMask _snapLayerMask; //Field offset: 0xB8
	[SerializeField]
	[Tooltip("Current culling camera.")]
	private PerfectCullingCamera _cullingCamera; //Field offset: 0x20
	[SerializeField]
	[Tooltip("Number of work threads for presampling data. Typically 2 threads is enough. More threads may lead to poor performance.")]
	private int _numWorkThreads; //Field offset: 0x28
	[SerializeField]
	private PerfectCullingCrossSceneVolume[] _forceInitializeVolumes; //Field offset: 0x30
	private Thread[] _workThreads; //Field offset: 0x38
	private float _BPSTimer; //Field offset: 0x40
	private float _bytesRead; //Field offset: 0x44
	private int _numReadOperations; //Field offset: 0x48
	private float _maxRate; //Field offset: 0x4C
	private bool _updateVisibility; //Field offset: 0x50
	private Nullable _lastWorkerJob; //Field offset: 0x58
	[CompilerGenerated]
	private bool <ShowStats>k__BackingField; //Field offset: 0x70
	private Task _adaptiveGridUpdateTask; //Field offset: 0x78
	private Bounds _cullingCellBounds; //Field offset: 0x80
	private JobHandle _recomputeVisibilityJobHandle; //Field offset: 0x98

	public PerfectCullingCamera CullingCamera
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	internal static int CullingCellId
	{
		internal get { } //Length: 83
	}

	public static bool Exists
	{
		 get { } //Length: 305
	}

	public private static PerfectCullingCrossSceneSampler Instance
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		private set { } //Length: 167
	}

	public static bool IsAutocullingExists
	{
		 get { } //Length: 291
	}

	public bool IsUpdatingVisibility
	{
		 get { } //Length: 10
	}

	public bool ShowStats
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static PerfectCullingCrossSceneSampler() { }

	public PerfectCullingCrossSceneSampler() { }

	public void AwaitWorkJobFinish() { }

	public void CompleteJobs() { }

	public static void DeinitializeAutoCulling() { }

	private void DrawStatsUI() { }

	private static void EditorActiveSceneChanged(Scene prev, Scene newScene) { }

	private static void EditorUpdate() { }

	private void FetchVisibilityJobResults() { }

	public bool FinishJob(JobHandle handle) { }

	public PerfectCullingCamera get_CullingCamera() { }

	internal static int get_CullingCellId() { }

	public static bool get_Exists() { }

	[CompilerGenerated]
	public static PerfectCullingCrossSceneSampler get_Instance() { }

	public static bool get_IsAutocullingExists() { }

	public bool get_IsUpdatingVisibility() { }

	[CompilerGenerated]
	public bool get_ShowStats() { }

	public static int GetRuntimeMemoryUsageMb() { }

	internal void Initialize() { }

	[AsyncStateMachine(typeof(<InitializeAutoCulling>d__36))]
	public static Task InitializeAutoCulling(CancellationToken token, IProgress progress = null) { }

	private static void InitializeBuffers() { }

	private static bool IsScreenDistanceSwitcherVisibleByCamera(ScreenDistanceSwitcher sw, List cameras) { }

	private void LateUpdate() { }

	private static void LocateGameCameras() { }

	private void OnDestroy() { }

	private static void PrepareVolumes(CancellationToken terminateToken, Vector3 worldPos, HashSet volumeIds, List removeCells, List sortedIndices) { }

	private void ScheduleCullingJob() { }

	public Nullable ScheduleJob(FastArray inputRuntimeVolumeIds, FastArray inputGroupIds) { }

	public void ScheduleUpdate(FastArray inputRuntimeVolumeIds, FastArray inputGroupIds) { }

	public void set_CullingCamera(PerfectCullingCamera value) { }

	[CompilerGenerated]
	private static void set_Instance(PerfectCullingCrossSceneSampler value) { }

	[CompilerGenerated]
	public void set_ShowStats(bool value) { }

	internal static CullingCellData SetCullingCellLocked(CullingCellData newCell) { }

	public void Shutdown() { }

	private void Start() { }

	private void Update() { }

	public static void UpdateBakedLODVisibility(PerfectCullingCrossSceneGroup group, ScreenDistanceSwitcher lod) { }

	private void UpdateGameCameraStates() { }

	private static void UpdateScreenDistanceSwitchMT() { }

	private void UpdateStreamingInfo() { }

	private static bool UpdateVisibility(CancellationToken terminateToken, PerfectCullingCamera camera, HashSet groupIds) { }

	private static bool WorkExecute(CancellationToken terminateToken, PerfectCullingCamera camera, Vector3 worldPos, HashSet volumeIds, HashSet groupIds, List removeCells, List sortedIndices) { }

	private static void WorkThread(object p) { }

}

