namespace GPUInstancer;

public abstract class GPUInstancerManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__90_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GeneratePrototypes>b__90_0(GPUInstancerPrototype p) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnResolutionChangeStatic; //Field offset: 0x0

	}

	internal class GPUIThreadData
	{
		public Thread thread; //Field offset: 0x10
		public object parameter; //Field offset: 0x18

		public GPUIThreadData() { }

	}

	public static List activeManagerList; //Field offset: 0x0
	public static bool showRenderedAmount; //Field offset: 0x8
	protected static ComputeShader _cameraComputeShader; //Field offset: 0x10
	protected static int[] _cameraComputeKernelIDs; //Field offset: 0x18
	protected static ComputeShader _visibilityComputeShader; //Field offset: 0x20
	protected static int[] _instanceVisibilityComputeKernelIDs; //Field offset: 0x28
	protected static ComputeShader _bufferToTextureComputeShader; //Field offset: 0x30
	protected static int _bufferToTextureComputeKernelID; //Field offset: 0x38
	public static int lastTreePositionUpdate; //Field offset: 0x3C
	public static GameObject treeProxyParent; //Field offset: 0x40
	public static Dictionary treeProxyList; //Field offset: 0x48
	public static int lastDrawCallFrame; //Field offset: 0x50
	public static float lastDrawCallTime; //Field offset: 0x54
	public static float timeSinceLastDrawCall; //Field offset: 0x58
	protected static Vector4 _windVector; //Field offset: 0x5C
	protected static CommandBuffer motionVectorsCb; //Field offset: 0x70
	protected static CommandBuffer motionVectorsAfterCb; //Field offset: 0x78
	protected static RenderTexture motionVectorsRt; //Field offset: 0x80
	protected static RenderTexture motionVectorsRtDepth; //Field offset: 0x88
	protected static CommandBuffer motionVectorsCbOptic; //Field offset: 0x90
	protected static CommandBuffer motionVectorsAfterCbOptic; //Field offset: 0x98
	protected static RenderTexture motionVectorsRtOptic; //Field offset: 0xA0
	protected static RenderTexture motionVectorsRtDepthOptic; //Field offset: 0xA8
	protected static RenderTargetIdentifier[] mrt; //Field offset: 0xB0
	protected static RenderTargetIdentifier[] mrtOptic; //Field offset: 0xB8
	protected static bool isMotionVectorDataClear; //Field offset: 0xC0
	protected static bool isMotionVectorDataClearOptic; //Field offset: 0xC1
	protected static bool isMotionVectorsInit; //Field offset: 0xC2
	private static readonly int _wind; //Field offset: 0xC4
	private static readonly int _blendGrassMv; //Field offset: 0xC8
	public bool IsOptic; //Field offset: 0x20
	public List prototypeList; //Field offset: 0x28
	public GPUInstancerCameraData cameraData; //Field offset: 0x30
	public bool useFloatingOriginHandler; //Field offset: 0x38
	public Transform floatingOriginTransform; //Field offset: 0x40
	public GPUInstancerFloatingOriginHandler floatingOriginHandler; //Field offset: 0x48
	public GPUInstancerTerrainSettings terrainSettings; //Field offset: 0x50
	public List runtimeDataList; //Field offset: 0x58
	public Bounds instancingBounds; //Field offset: 0x60
	public bool isFrustumCulling; //Field offset: 0x78
	public bool isOcclusionCulling; //Field offset: 0x79
	public float minCullingDistance; //Field offset: 0x7C
	protected GPUInstancerSpatialPartitioningData spData; //Field offset: 0x80
	public int maxThreads; //Field offset: 0x88
	public readonly List activeThreads; //Field offset: 0x90
	public readonly Queue threadStartQueue; //Field offset: 0x98
	public readonly Queue threadQueue; //Field offset: 0xA0
	protected bool isInitial; //Field offset: 0xA8
	public bool isInitialized; //Field offset: 0xA9
	public Dictionary runtimeDataDictionary; //Field offset: 0xB0
	public LayerMask layerMask; //Field offset: 0xB8
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0xC0
	public Exception threadException; //Field offset: 0xC8

	protected static bool bGenerateMotionVectors
	{
		 get { } //Length: 758
	}

	protected Camera Camera
	{
		 get { } //Length: 15
	}

	protected SSAA CameraSSAA
	{
		 get { } //Length: 15
	}

	protected override bool isCulled
	{
		 get { } //Length: 3
	}

	public bool IsMotionVectorDataClear
	{
		 get { } //Length: 143
		 set { } //Length: 158
	}

	protected static bool isTaaEnabled
	{
		 get { } //Length: 213
	}

	public CommandBuffer MotionVectorsAfterCommandBuffer
	{
		 get { } //Length: 140
	}

	public CommandBuffer MotionVectorsCommandBuffer
	{
		 get { } //Length: 140
	}

	public RenderTexture MotionVectorsDepth
	{
		 get { } //Length: 143
	}

	public RenderTexture MotionVectorsTexture
	{
		 get { } //Length: 143
	}

	public RenderTargetIdentifier[] MRT
	{
		 get { } //Length: 143
	}

	protected static int OpticResolution
	{
		 get { } //Length: 92
	}

	private static GPUInstancerManager() { }

	protected GPUInstancerManager() { }

	public static void AddTreeProxy(GPUInstancerPrototype treePrototype, GPUInstancerRuntimeData runtimeData) { }

	public override void Awake() { }

	public void ClearCompletedThreads() { }

	public override void ClearInstancingData() { }

	protected void ClearMotionVectorData() { }

	protected void CreateMotionVectorsData() { }

	public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true) { }

	public void DisposeMotionVectorsData() { }

	public override void GeneratePrototypes(bool forceNew = false) { }

	protected static bool get_bGenerateMotionVectors() { }

	protected Camera get_Camera() { }

	protected SSAA get_CameraSSAA() { }

	protected override bool get_isCulled() { }

	public bool get_IsMotionVectorDataClear() { }

	protected static bool get_isTaaEnabled() { }

	public CommandBuffer get_MotionVectorsAfterCommandBuffer() { }

	public CommandBuffer get_MotionVectorsCommandBuffer() { }

	public RenderTexture get_MotionVectorsDepth() { }

	public RenderTexture get_MotionVectorsTexture() { }

	public RenderTargetIdentifier[] get_MRT() { }

	protected static int get_OpticResolution() { }

	public GPUInstancerRuntimeData GetRuntimeData(GPUInstancerPrototype prototype, bool logError = false) { }

	public ComputeBuffer GetTransformDataBuffer(GPUInstancerPrototype prototype) { }

	public static Vector4 GetWindVector() { }

	public void InitializeCameraData() { }

	public override void InitializeRuntimeDataAndBuffers(bool forceNew = true) { }

	public override void InitializeSpatialPartitioning() { }

	public static void InstantiateTreeProxyObject(GameObject treePrefab, GameObject proxyObjectParent, Material[] proxyMaterials, Mesh proxyMesh, bool setBounds) { }

	public void LateUpdate() { }

	public void LogThreadException() { }

	public override void OnDestroy() { }

	public override void OnDisable() { }

	public override void OnEnable() { }

	private static void OnResolutionChangeMain(EftResolution resolution) { }

	private static void OnResolutionChangeOptic() { }

	protected static void OnResolutionChangeStatic(EftDisplaySettings displaySettings) { }

	public override void RemoveInstancesInsideBounds(Bounds bounds, float offset, List prototypeFilter = null) { }

	public override void RemoveInstancesInsideCollider(Collider collider, float offset, List prototypeFilter = null) { }

	public override void Reset() { }

	public void set_IsMotionVectorDataClear(bool value) { }

	public void SetCamera(Camera camera) { }

	public override void SetGlobalPositionOffset(Vector3 offsetPosition) { }

	public void SetLODBias(float newLODBias, List prototypeFilter) { }

	public void SetupOcclusionCulling() { }

	public override void Update() { }

	public void UpdateBuffers() { }

	public static void UpdateSceneWind() { }

	public override void UpdateSpatialPartitioningCells(GPUInstancerCameraData renderingCameraData) { }

	public void UpdateTreeMPB() { }

}

