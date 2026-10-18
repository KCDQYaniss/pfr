namespace GPUInstancer;

[Extension]
public static class GPUInstancerUtility
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__73_0; //Field offset: 0x8
		public static Func <>9__74_0; //Field offset: 0x10
		public static Func <>9__82_1; //Field offset: 0x18
		public static Func <>9__82_0; //Field offset: 0x20
		public static Func <>9__97_0; //Field offset: 0x28
		public static Func <>9__97_1; //Field offset: 0x30
		public static Func <>9__98_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <AddBillboardToRuntimeData>b__97_0(Renderer r) { }

		internal bool <AddBillboardToRuntimeData>b__97_1(Renderer r) { }

		internal bool <AddDetailInstanceRuntimeDataToList>b__73_0(MeshRenderer r) { }

		internal bool <DetermineTreePrototypeType>b__82_0(MeshRenderer mr) { }

		internal bool <DetermineTreePrototypeType>b__82_1(Material m) { }

		internal bool <GetBillboardMaterial>b__98_0(MeshRenderer r) { }

		internal bool <UpdateDetailInstanceRuntimeDataList>b__74_0(MeshRenderer r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass107_0
	{
		public GPUInstancerSpatialPartitioningData spData; //Field offset: 0x10

		public <>c__DisplayClass107_0() { }

		internal bool <CalculateSpatialPartitioningValuesFromTerrain>b__0(int d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass77_0
	{
		public GameObject go; //Field offset: 0x10

		public <>c__DisplayClass77_0() { }

		internal bool <SetPrefabInstancePrototypes>b__0(GPUInstancerPrototype p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public int n; //Field offset: 0x10

		public <>c__DisplayClass93_0() { }

		internal bool <GetDivisors>b__0(int a) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GCD; //Field offset: 0x0

	}

	private static readonly int _healthyDryNoiseTexture; //Field offset: 0x0
	private static readonly int _noiseSpread; //Field offset: 0x4
	private static readonly int _windWaveNormalTexture; //Field offset: 0x8
	private static readonly int _windVector; //Field offset: 0xC
	private static readonly int _heightMap; //Field offset: 0x10
	private static readonly int _heightResolution; //Field offset: 0x14
	private static readonly int _terrainWorldPos; //Field offset: 0x18
	private static readonly int _terrainSize; //Field offset: 0x1C
	private static readonly int _terrainNormalMap; //Field offset: 0x20
	private static readonly int _gradientNormalHeight; //Field offset: 0x24
	private static readonly int _normalMap; //Field offset: 0x28
	private static readonly int _alphaMapArray; //Field offset: 0x2C
	private static readonly int _alphaChannelMask; //Field offset: 0x30
	private static readonly int _densityMapArray; //Field offset: 0x34
	private static readonly int _densityMapIndex; //Field offset: 0x38
	private static readonly int _densityChanelMask; //Field offset: 0x3C
	private static readonly int _densityMinMax; //Field offset: 0x40
	private static readonly int _cutoffFade; //Field offset: 0x44
	private static readonly int _ambientOcclusion; //Field offset: 0x48
	private static readonly int _gradientPower; //Field offset: 0x4C
	private static readonly int _windWaveTintColor; //Field offset: 0x50
	private static readonly int _windIdleSway; //Field offset: 0x54
	private static readonly int _windWavesOn; //Field offset: 0x58
	private static readonly int _windWaveSize; //Field offset: 0x5C
	private static readonly int _windWaveTint; //Field offset: 0x60
	private static readonly int _windWaveSway; //Field offset: 0x64
	private static readonly int _isBillboard; //Field offset: 0x68
	private static readonly int _mainTex; //Field offset: 0x6C
	private static readonly int _healthyColor; //Field offset: 0x70
	private static readonly int _dryColor; //Field offset: 0x74
	private static readonly int _mainTexture; //Field offset: 0x78
	private static readonly int _gpuiBillboardBrightness; //Field offset: 0x7C
	private static readonly int _gpuiBillboardCutoffOverride; //Field offset: 0x80
	private static readonly int _isLinearSpace; //Field offset: 0x84
	private static readonly int _useSpdHueVariation; //Field offset: 0x88
	private static readonly int _spdHueVariation; //Field offset: 0x8C
	private static readonly int _hueVariation; //Field offset: 0x90
	private static readonly int _hueVariationColor; //Field offset: 0x94
	private static readonly int _translucencyColor; //Field offset: 0x98
	private static readonly int _translucencyViewDependency; //Field offset: 0x9C
	private static readonly int _shadowStrength; //Field offset: 0xA0
	private static readonly int _albedoAtlas; //Field offset: 0xA4
	private static readonly int _normalAtlas; //Field offset: 0xA8
	private static readonly int _frameCount; //Field offset: 0xAC
	private static readonly int _cutOff; //Field offset: 0xB0
	private static readonly int _bufferSize; //Field offset: 0xB4
	private static readonly int _maxTextureSize; //Field offset: 0xB8
	public static Texture2D dummyHiZTex; //Field offset: 0xC0
	public static GPUIMatrixHandlingType matrixHandlingType; //Field offset: 0xC8
	private static Dictionary _eventDictionary; //Field offset: 0xD0

	private static GPUInstancerUtility() { }

	public static void AddBillboardToRuntimeData(GPUInstancerRuntimeData runtimeData) { }

	public static void AddDetailInstancePrototypeFromTerrainPrototype(GPUInstancerDetailManager detailManager, List detailInstancePrototypes, DetailPrototype terrainDetailPrototype, int detailIndex, int quadCount, GPUInstancerTerrainSettings terrainSettings, GameObject replacementPrefab = null, Terrain terrain = null) { }

	public static void AddDetailInstanceRuntimeDataToList(Terrain terrain, List runtimeDataList, List detailPrototypes, GPUInstancerTerrainSettings terrainSettings, int detailLayer) { }

	public static void AddObjectToAsset(Object baseAsset, Object objectToAdd) { }

	public static void AddTreeInstancePrototypeFromTerrainPrototype(GameObject gameObject, List treeInstancePrototypes, TreePrototype terrainTreePrototype, int treeIndex, GPUInstancerTerrainSettings terrainSettings) { }

	public static void AddTreeInstanceRuntimeDataToList(List runtimeDataList, List treePrototypes, GPUInstancerTerrainSettings terrainSettings) { }

	public static void AssignBillboardBinding(GPUInstancerPrototype prototype) { }

	public static void CalculateSpatialPartitioningValuesFromTerrain(GPUInstancerSpatialPartitioningData spData, Terrain terrain, float maxDetailDistance, float preferedCellSize = 0) { }

	public static void ClearInstanceData(List runtimeDataList) { }

	public static Vector3 ComputeTerrainNormal(float leftBottomH, float leftTopH, float rightBottomH, float scale) { }

	[Extension]
	public static void CopyComputeBuffer(ComputeBuffer computeBuffer, int computeBufferStartIndex, int count, ComputeBuffer managedBuffer) { }

	public static void CopyTextureWithComputeShader(Texture source, Texture destination, int offsetX, int sourceMip = 0, int destinationMip = 0, bool reverseZ = true) { }

	public static Mesh CreateCrossQuadsMeshForDetailGrass(float width, float height, string name, int quality) { }

	public static Shader CreateInstancedShader(Shader originalShader, bool useOriginal = false) { }

	public static GPUIPlatform DeterminePlatform() { }

	public static void DetermineTreePrototypeType(GPUInstancerPrototype prototype) { }

	public static Texture2D DilateBillboardTexture(Texture2D billboardTexture, int frameCount, bool isNormal) { }

	public static void DispatchBufferToTexture(List runtimeDataList, ComputeShader bufferToTextureComputeShader, int bufferToTextureComputeKernelID) { }

	public static void DispatchCSInstancedCameraCalculation(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, T runtimeData, GPUInstancerTerrainSettings terrainSettings, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool isInitial) { }

	public static void DispatchCSInstancedVisibilityCalculation(ComputeShader visibilityComputeShader, int instanceVisibilityComputeKernelId, T runtimeData, bool isShadow, int lodShift, int lodAppendIndex) { }

	public static void DrawPrePass(CommandBuffer motionVectorsCb, List runtimeDataList, Bounds instancingBounds, GPUInstancerCameraData cameraData, bool generateMotionVectors, int layerMask = -1) { }

	public static int GCD(int a, int b) { }

	public static int GCD(int[] numbers) { }

	public static Bounds GenerateBoundsFromTerrainPositionAndSize(Vector3 position, Vector3 size) { }

	public static void GenerateInstancedShadersForGameObject(GPUInstancerPrototype prototype) { }

	public static GPUInstancerPrefabPrototype GeneratePrefabPrototype(GameObject go, bool forceNew) { }

	public static void GeneratePrototypeBillboard(GPUInstancerPrototype prototype, bool forceRegenerate = false) { }

	public static Mesh GenerateQuadMesh(float width, float height, Nullable uvRect = null, bool centerPivotAtBottom = false, float pivotOffsetX = 0, float pivotOffsetY = 0) { }

	public static string GetAssetGUID(Object assetObject) { }

	public static Material GetBillboardMaterial(GPUInstancerPrototype prototype) { }

	public static string GetBillboardShaderName(GPUInstancerPrototype prototype) { }

	public static List GetDetailMapsFromTerrain(Terrain terrain, List detailPrototypeList) { }

	public static float GetDistanceRelativeHeight(GPUInstancerDetailPrototype detailPrototype) { }

	public static IEnumerable GetDivisors(int n) { }

	public static void GPUIDrawMeshInstancedIndirect(List runtimeDataList, Bounds instancingBounds, GPUInstancerCameraData cameraData, int layerMask = -1) { }

	public static void ImportFoliageLWRPShader() { }

	public static void ImportFoliageLWRPShaderPopup() { }

	public static void ImportSpeedTree8Shader() { }

	public static void ImportSpeedTree8ShaderPopup() { }

	public static void InitializeGPUBuffer(T runtimeData) { }

	public static void InitializeGPUBuffers(List runtimeDataList) { }

	public static void InitializeWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array) { }

	public static bool IsBillboardGeneratedByDefault(GPUInstancerPrototype prototype) { }

	public static bool IsInLayer(int layerMask, int layer) { }

	public static bool IsShaderInstanced(Shader shader) { }

	public static Matrix4x4 Matrix4x4FromString(string matrixStr) { }

	[Extension]
	public static float[] Matrix4x4ToFloatArray(Matrix4x4 matrix4x4) { }

	[Extension]
	public static void Matrix4x4ToFloatArray(Matrix4x4 matrix4x4, float[] floatArray) { }

	public static string Matrix4x4ToString(Matrix4x4 matrix4x4) { }

	[Extension]
	public static ComputeBuffer MergeComputeBuffers(ComputeBuffer computeBuffer, ComputeBuffer bufferToMerge, bool releaseMergedBuffers) { }

	[Extension]
	public static T[] MirrorAndFlatten(T[,] array2D, int xBase, int yBase, int width, int height) { }

	[Extension]
	public static T[] MirrorAndFlatten(T[,] array2D) { }

	public static void OnFoliageLWRPShaderImportCompleted(string foliageShaderPackageName) { }

	[Extension]
	public static float Range(Random prng, float min, float max) { }

	public static void ReduceTextureWithComputeShader(Texture source, Texture destination, int offsetX) { }

	public static void ReleaseInstanceBuffers(List runtimeDataList) { }

	public static void ReleaseInstanceBuffers(T runtimeData) { }

	public static void ReleaseSPBuffers(GPUInstancerSpatialPartitioningData spData) { }

	public static void ReleaseSPCell(GPUInstancerCell spCell) { }

	public static void RemoveAssetsOfType(Object baseAsset, Type type) { }

	public static void RemoveInstancesInsideBounds(ComputeBuffer instanceDataBuffer, Vector3 center, Vector3 extents, float offset) { }

	public static void RemoveInstancesInsideBoxCollider(ComputeBuffer instanceDataBuffer, BoxCollider boxCollider, float offset) { }

	public static void RemoveInstancesInsideCapsuleCollider(ComputeBuffer instanceDataBuffer, CapsuleCollider capsuleCollider, float offset) { }

	public static void RemoveInstancesInsideSphereCollider(ComputeBuffer instanceDataBuffer, SphereCollider sphereCollider, float offset) { }

	public static void RemoveUnusedAssets(Object baseAsset, List prototypeList, Type prototypeType) { }

	public static float SampleTerrainHeight(float px, float py, float leftBottomH, float leftTopH, float rightBottomH, float rightTopH) { }

	public static void SetAppendBuffers(T runtimeData) { }

	private static void SetAppendBuffersDefault(T runtimeData) { }

	private static void SetAppendBuffersGLES3(T runtimeData) { }

	private static void SetAppendBuffersVulkan(T runtimeData) { }

	[Extension]
	public static void SetDataPartial(ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex, int count, ComputeBuffer managedBuffer = null, Matrix4x4[] managedData = null) { }

	[Extension]
	public static void SetDataSingle(ComputeBuffer computeBuffer, Matrix4x4[] data, int managedBufferStartIndex, int computeBufferStartIndex) { }

	public static void SetDetailInstancePrototypes(GPUInstancerDetailManager detailManager, List detailInstancePrototypes, DetailPrototype[] detailPrototypes, int quadCount, GPUInstancerTerrainSettings terrainSettings, bool forceNew, Terrain terrain) { }

	public static void SetGlobalPositionOffset(GPUInstancerManager manager, Vector3 offsetPosition) { }

	[Extension]
	public static void SetMatrix4x4ToTransform(Transform transform, Matrix4x4 matrix) { }

	public static void SetPlatformDependentVariables() { }

	public static void SetPrefabInstancePrototypes(GameObject gameObject, List prototypeList, List prefabList, bool forceNew) { }

	public static void SetPrototypeListFromAssets(Object baseAsset, List prototypeList, Type prototypeType) { }

	public static void SetTreeInstancePrototypes(GameObject gameObject, List treeIntancePrototypes, TreePrototype[] treePrototypes, GPUInstancerTerrainSettings terrainSettings, bool forceNew) { }

	public static void ShowBillboardQuad(GPUInstancerPrototype prototype, Vector3 quadPos) { }

	public static void StartListening(GPUInstancerEventType eventType, UnityAction listener) { }

	public static void StopListening(GPUInstancerEventType eventType, UnityAction listener) { }

	public static void TriggerEvent(GPUInstancerEventType eventType) { }

	public static void UpdateDetailInstanceRuntimeDataList(Terrain terrain, List runtimeDataList, GPUInstancerTerrainSettings terrainSettings, bool updateMeshes = false, int detailLayer = 0) { }

	public static void UpdateGPUBuffer(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, T runtimeData, GPUInstancerTerrainSettings terrainSetting, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) { }

	public static void UpdateGPUBuffers(ComputeShader cameraComputeShader, int[] cameraComputeKernelIDs, ComputeShader visibilityComputeShader, int[] instanceVisibilityComputeKernelIDs, List runtimeDataList, GPUInstancerTerrainSettings terrainSetting, GPUInstancerCameraData cameraData, bool isManagerFrustumCulling, bool isManagerOcclusionCulling, bool showRenderedAmount, bool isInitial) { }

	public static void UpdatePlatformDependentFiles() { }

	public static void UpdateTerrainNormalMapDetailInstance(Terrain terrain, List runtimeDataList) { }

	public static void UpdateVisibilityBufferWithMatrix4x4Array(GPUInstancerPrefabManager prefabManager, GPUInstancerPrefabPrototype prototype, Matrix4x4[] matrix4x4Array, int arrayStartIndex = 0, int bufferStartIndex = 0, int count = 0) { }

	public static void VersionControlCheckout(string path) { }

	public static void VersionControlCheckout(Object assetObject) { }

}

