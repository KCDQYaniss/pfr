//Type is in global namespace

[ExecuteAlways]
public class WindowsManager : MonoBehaviour
{
	private class BreakerIdInstanceIdPair : MyKeyValuePair
	{

		public BreakerIdInstanceIdPair() { }

		public static Dictionary DictFromList(List list) { }

		public static List ListFromDictionary(Dictionary dict) { }

	}

	private class BreakerTextureOffsetsPair : MyKeyValuePair
	{

		public BreakerTextureOffsetsPair() { }

		public static Dictionary DictFromList(List list) { }

		public static List ListFromDictionary(Dictionary dict) { }

	}

	private class InteractableIdInstancesIdsPair : MyKeyValuePair
	{

		public InteractableIdInstancesIdsPair() { }

		public static Dictionary DictFromList(List list) { }

		public static List ListFromDictionary(Dictionary dict) { }

	}

	private class MyKeyValuePair`2
	{
		public KeyType key; //Field offset: 0x0
		public ValueType value; //Field offset: 0x0

		public MyKeyValuePair`2() { }

	}

	private struct PiecesQueueElement
	{
		public string breakerId; //Field offset: 0x0
		public string pieceId; //Field offset: 0x8
		public MeshRenderer renderer; //Field offset: 0x10
		public Mesh mesh; //Field offset: 0x18
		public Material material; //Field offset: 0x20

	}

	private static WindowsManager _instance; //Field offset: 0x0
	private static bool IsDynamicRenderersArrayDirty; //Field offset: 0x8
	private static Dictionary DynamicRenderersOffsets; //Field offset: 0x10
	private static ParticleSystemRenderer[] DynamicRenderersArray; //Field offset: 0x18
	private static HashSet DynamicParticleSystems; //Field offset: 0x20
	private static int _lastEmptyRendererIdx; //Field offset: 0x28
	public static bool EnableIsManageFunction; //Field offset: 0x2C
	public static bool UseUnityMathCullingForParticles; //Field offset: 0x2D
	public static bool EnableParticlesCulling; //Field offset: 0x2E
	private static int PROPERTY_MBOITForeground; //Field offset: 0x30
	private static int PROPERTY_CameraParameters; //Field offset: 0x34
	private static int PROPERTY_WindowsVerticesIDs; //Field offset: 0x38
	private static int PROPERTY_WindowsVerticesInstances; //Field offset: 0x3C
	private static int PROPERTY_WindowsVerticesLocalOffsets; //Field offset: 0x40
	private static int PROPERTY_WindowsInstancesMeshesIndices; //Field offset: 0x44
	private static int PROPERTY_WindowsInstancesMeshesOffsets; //Field offset: 0x48
	private static int PROPERTY_WindowsMeshesVerticesCount; //Field offset: 0x4C
	private static int PROPERTY_WindowsVertices; //Field offset: 0x50
	private static int PROPERTY_WindowsBounds; //Field offset: 0x54
	private static int PROPERTY_WindowsLocalToWorld; //Field offset: 0x58
	private static int PROPERTY_WindowsTriangles; //Field offset: 0x5C
	private static int PROPERTY_WindowsTexturesOffsets; //Field offset: 0x60
	private static int PROPERTY_InstanceIdToStartVertexId; //Field offset: 0x64
	private static int PROPERTY_MaterialsProperties; //Field offset: 0x68
	private static int PROPERTY_LightsParameters; //Field offset: 0x6C
	private static int PROPERTY_GlobalReflectionStrength; //Field offset: 0x70
	private static int PROPERTY_CustomFogStrength; //Field offset: 0x74
	private static int PROPERTY_ScatterStrength; //Field offset: 0x78
	private static int PROPERTY_WindowsSpecTex; //Field offset: 0x7C
	private static int PROPERTY_WindowsCubeTex; //Field offset: 0x80
	private static int PROPERTY_moments; //Field offset: 0x84
	private static int PROPERTY_zeroth_moment; //Field offset: 0x88
	private static int PROPERTY_zeroth_moment_foreground; //Field offset: 0x8C
	private static int PROPERTY_MainTex; //Field offset: 0x90
	private static int PROPERTY_DepthTex; //Field offset: 0x94
	private static int PROPERTY_WindowsInstancesCount; //Field offset: 0x98
	private static int PROPERTY_FrustumPlanes; //Field offset: 0x9C
	private static int PROPERTY_FrustumPlanesPNFactors; //Field offset: 0xA0
	private static int PROPERTY_InstancesBounds; //Field offset: 0xA4
	private static int PROPERTY_VerticesCountForeground; //Field offset: 0xA8
	private static int PROPERTY_VerticesIDsForeground; //Field offset: 0xAC
	private static int PROPERTY_VerticesCountBackground; //Field offset: 0xB0
	private static int PROPERTY_VerticesIDsBackground; //Field offset: 0xB4
	private static int PROPERTY_WindowsInstancesCountForeground; //Field offset: 0xB8
	private static int PROPERTY_OcclusionGroupsCountForeground; //Field offset: 0xBC
	private static int PROPERTY_WindowsInstancesCountBackground; //Field offset: 0xC0
	private static int PROPERTY_OcclusionGroupsCountBackground; //Field offset: 0xC4
	private static int PROPERTY_VerticesCount; //Field offset: 0xC8
	private static int PROPERTY_VerticesIDs; //Field offset: 0xCC
	private static int PROPERTY_InstancesId; //Field offset: 0xD0
	private static int PROPERTY_ProjViewMatrix; //Field offset: 0xD4
	private static int PROPERTY_WindowsInstancesEnabled; //Field offset: 0xD8
	private static int PROPERTY_occlusionAccuracy; //Field offset: 0xDC
	private static int PROPERTY_occlusionOffset; //Field offset: 0xE0
	private static int PROPERTY_hiZMap; //Field offset: 0xE4
	private static int PROPERTY_hiZTxtrSize; //Field offset: 0xE8
	private static int PROPERTY_momentsLowRes; //Field offset: 0xEC
	private static int PROPERTY_zeroth_momentLowRes; //Field offset: 0xF0
	private static int PROPERTY_transmittance_sum_rcp; //Field offset: 0xF4
	private static int PROPERTY_UnpackedVertexOffsetInstanceId; //Field offset: 0xF8
	private static int PROPERTY_FrustumCornersWS; //Field offset: 0xFC
	public static int PiecesInstancesRingSize; //Field offset: 0x100
	public static int PiecesVerticesRingSize; //Field offset: 0x104
	public static int PiecesIndicesRingSize; //Field offset: 0x108
	private static float4[] FrustumPlanesBuf; //Field offset: 0x110
	private static Vector3 v0v7; //Field offset: 0x118
	private static Vector3 v1v6; //Field offset: 0x124
	private static Vector3 v4v3; //Field offset: 0x130
	private static Vector3 v5v2; //Field offset: 0x13C
	private static Vector3[] _dirs; //Field offset: 0x148
	private static IntVec2[] _dirsPointsIDs; //Field offset: 0x150
	private static Vector3[] _pointsLerpFactors; //Field offset: 0x158
	private static float[] CameraParametersBuffer; //Field offset: 0x160
	private static readonly float[] CameraLogarithmicDepthSliceData; //Field offset: 0x168
	private static readonly int _CameraLogarithmicDepthSliceData; //Field offset: 0x170
	private static HashSet suitableShaders; //Field offset: 0x178
	private Dictionary _commandBuffers; //Field offset: 0x20
	private Dictionary _cameras; //Field offset: 0x28
	public Material WindowsMaterial; //Field offset: 0x30
	public Material CopyCubemapMaterial; //Field offset: 0x38
	public Material MBOITBlitOpaque; //Field offset: 0x40
	public Material QuarterMomentsUpscaler; //Field offset: 0x48
	public ComputeShader FrustumCullShader; //Field offset: 0x50
	public ComputeShader OcclusionCullShader; //Field offset: 0x58
	public ComputeShader ParticlesIndirectArgsCleaner; //Field offset: 0x60
	public ComputeShader ParticlesTexturesCopyShader; //Field offset: 0x68
	public ComputeShader ParticlesRenderDataCopyShader; //Field offset: 0x70
	public ComputeShader MBOITFogBlurShader; //Field offset: 0x78
	public int OcclusionAccuracy; //Field offset: 0x80
	public float OcclusionOffset; //Field offset: 0x84
	public bool IsActive; //Field offset: 0x88
	public bool ScatterBlur; //Field offset: 0x89
	public int FogBlurSamplesCount; //Field offset: 0x8C
	public float FogBlurRadiusScale; //Field offset: 0x90
	public float BackgroundSplitDistance; //Field offset: 0x94
	private Renderer[] RenderersForOITMoments; //Field offset: 0x98
	private HashSet ProcessedDynamicParticleSystems; //Field offset: 0xA0
	private bool _renderParticles; //Field offset: 0xA8
	private Dictionary _meshesOffsets; //Field offset: 0xB0
	private List _requiredTexturesList; //Field offset: 0xB8
	private List _requiredCubemapsList; //Field offset: 0xC0
	[SerializeField]
	private List _lightsProperties; //Field offset: 0xC8
	[SerializeField]
	private List _materialsParameters; //Field offset: 0xD0
	private Vector4[] _gpuPlanesBuffer; //Field offset: 0xD8
	private Vector3 _v3buf; //Field offset: 0xE0
	private Dictionary _pieces; //Field offset: 0xF0
	private Queue _piecesQueue; //Field offset: 0xF8
	private PieceOffsets _lastPieceOffset; //Field offset: 0x100
	private PieceOffsets _firstPieceOffset; //Field offset: 0x108
	private PieceOffsets _updateableZoneStartOffset; //Field offset: 0x110
	[SerializeField]
	private InstancesBuffers _instancesGeometry; //Field offset: 0x118
	[SerializeField]
	private GeometryBuffers _geometryData; //Field offset: 0x120
	[SerializeField]
	private SceneDataContainer _sceneData; //Field offset: 0x128
	private GeometryComputeBuffers _renderData; //Field offset: 0x130
	private MBOITParticlesManager _particlesManager; //Field offset: 0x138
	private bool _isInitialPopulateParticlesSystemsIsEcecuted; //Field offset: 0x140
	private Light _skyLight; //Field offset: 0x148
	[SerializeField]
	private Texture2DArray _texture2DArray; //Field offset: 0x150
	[SerializeField]
	private CubemapArray _cubemapArray; //Field offset: 0x158
	private List _instancesEnable; //Field offset: 0x160
	private Dictionary _breakerIdInstanceId; //Field offset: 0x168
	[SerializeField]
	private List _breakerIdInstanceIdList; //Field offset: 0x170
	private Dictionary _interactableIdInstanceId; //Field offset: 0x178
	[SerializeField]
	private List _interactableIdInstanceIdList; //Field offset: 0x180
	[SerializeField]
	private List _breakersTexturesOffsetsList; //Field offset: 0x188
	private Dictionary _breakersTexturesOffsets; //Field offset: 0x190
	private Plane[] _cameraPlanesBuffer; //Field offset: 0x198
	private Plane[] _cameraBackgroundPlanesBuffer; //Field offset: 0x1A0
	private Dictionary _earlyPiecesQueue; //Field offset: 0x1A8
	private List _earlyWindowsQueue; //Field offset: 0x1B0
	private List _materialsParametersBufList; //Field offset: 0x1B8
	private List _meshesOffsetsBufList; //Field offset: 0x1C0
	private List _meshesVerticesCountBufList; //Field offset: 0x1C8
	private List _allVerticesBufList; //Field offset: 0x1D0
	private List _allTrianglesBufList; //Field offset: 0x1D8
	private WindowVertex _windowVertexBuf; //Field offset: 0x1E0
	private List _instanceIdToStartVertexIdBufList; //Field offset: 0x200
	private List _verticesInstancesBufList; //Field offset: 0x208
	private List _verticesLocalOffsetsBufList; //Field offset: 0x210
	private PieceOffsets _requiredSizes; //Field offset: 0x218
	private List _allTransformsBufList; //Field offset: 0x220
	private List _allBoundsBufList; //Field offset: 0x228
	private List _meshIndexBufList; //Field offset: 0x230
	private List _texturesOffsetsBufList; //Field offset: 0x238
	private List _enableBufList; //Field offset: 0x240
	private Dictionary _earlyInteractablesTransforms; //Field offset: 0x248
	private List breakerBuf; //Field offset: 0x250

	public static WindowsManager Instance
	{
		 get { } //Length: 83
	}

	public MBOITParticlesManager ParticlesManager
	{
		 get { } //Length: 8
	}

	private static WindowsManager() { }

	public WindowsManager() { }

	public static void AddParticleSystem(ParticleSystem ps) { }

	public static void AddParticleSystemsList(List psList) { }

	public bool AddPiece(string breakerId, string pieceId, MeshRenderer renderer, Mesh mesh, Material material) { }

	private void Awake() { }

	private void BlitMBOITFog(CommandBuffer cmdBuf, RenderTexture quarterOIT) { }

	public void BreakWindow(string breakerId) { }

	private static void CalculateFrustumPNFactors(Camera camera, ref Vector3[] result) { }

	public void CheckInteractablesIDs() { }

	private void CleanupDisabledPieces() { }

	private void ClearCommandBuffers() { }

	private void ClearData() { }

	private void ClearRenderBuffers(bool releaseTextures = true) { }

	public void ClearRenderData(bool releaseTextures) { }

	public void CollectAndDisableMeshRenderers(bool collect) { }

	public void CollectAndEnableMeshRenderers(bool collect) { }

	private void CollectMeshRenderersInCullingSystem() { }

	private void ComputeFrustumCorners(CameraRenderData crd, Camera camera) { }

	private ComputeBuffer CreateComputeBufferWithData(T[] data, int tailReserveCount, string name = "", ComputeBufferType bufferType = 0) { }

	private ComputeBuffer CreateComputeBufferWithData(List data, int tailReserveCount, string name = "", ComputeBufferType bufferType = 0) { }

	private static CubemapArray CreateCubemapArray(List textures, string name, int firstMipLevel, Material copyMaterial) { }

	private RenderTexture CreateRenderTexture(RenderTexture initialRenderTexture, int width, int height, string name, GraphicsFormat format, bool UAV = false, int depth = 0) { }

	private RenderTexture CreateRenderTexture(RenderTexture initialRenderTexture, int width, int height, string name, RenderTextureFormat format, bool UAV = false, int depth = 0) { }

	private void CreateRenderTextures(ref CameraRenderData crd, Camera camera, int w, int h, GraphicsFormat momentsFormat, GraphicsFormat momentsRcpFormat) { }

	private static Texture2DArray CreateTexture2DArray(List textures, string name, int firstMipLevel) { }

	private void DestroyRenderTexture(RenderTexture renderTexture) { }

	public void DisableMeshRenderers() { }

	public void Discard() { }

	private bool DoesFitInBetween(PieceOffsets left, PieceOffsets right, PieceOffsets desiredSize) { }

	private bool DoesFitInBufferHead(PieceOffsets bufferHead, PieceOffsets first, PieceOffsets desiredSize) { }

	private bool DoesFitInBufferTail(PieceOffsets last, PieceOffsets desiredSize) { }

	private void DoProcessingForEarlyInteractables() { }

	private void DoProcessingForParticles(ref CameraRenderData crd, Camera cam) { }

	private void DoProcessingForPieces(ref CameraRenderData crd, Camera camera) { }

	public void EnableMBOITParticles(bool enable) { }

	private void EnableMeshRenderers(bool enable) { }

	public void EnableMeshRenderers() { }

	private void EnableParticlesKeyword(CommandBuffer cmdBuf, string keyword) { }

	private void FillCameraParameters(ref float[] cameraParameters, Camera cam) { }

	private void FillLightProperties(ref List props) { }

	public List FindSuitableParticlesSources() { }

	public static WindowsManager get_Instance() { }

	public MBOITParticlesManager get_ParticlesManager() { }

	private PieceOffsets GetPieceOffsets(string pieceId, int pieceIdHash, PieceOffsets desiredSizes) { }

	private MBOITParticlesManager InitializeParticlesManager() { }

	public static bool InstanceIsActive() { }

	public static bool IsManagedByWindowsManager(Renderer renderer) { }

	private static bool IsMaterialValid(Material material) { }

	public static bool IsParticleSystemRendererSuitableForMBOIT(ParticleSystemRenderer psr) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void PopulateRenderersForOITMomentsLists() { }

	private void PreCull(Camera camera) { }

	public void ProcessAll() { }

	private void RegenRenderData() { }

	public static void RemoveParticleSystem(ParticleSystem ps) { }

	public static void RemoveParticleSystemsList(List psList) { }

	public void RemovePiece(string pieceId) { }

	private static void ReservePSRenderersArraySpace(int count) { }

	public void RunAwakeForSelected() { }

	private void Start() { }

	public bool TryGetCameraParameters(Camera cam, out ComputeBuffer parameters) { }

	private void UpdateCommandBuffer(ref CameraRenderData crd, Camera camera) { }

	private void UpdateEarlyPiecesQueue() { }

	private void UpdateInteractableTransform(List offsets, Matrix4x4 transform) { }

	public void UpdateInteractableTransform(string id, Transform transform) { }

	private void UpdateLightProperties(ref List props) { }

	public void UpdatePieceTransform(string pieceId, Transform transform) { }

	private static bool ValidateMeshRenderer(MeshRenderer renderer) { }

	private List ValidateMeshRenderers(MeshRenderer[] meshRenderers) { }

}

