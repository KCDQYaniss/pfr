//Type is in global namespace

[ExecuteInEditMode]
[ScriptOrder(19000)]
public class AmbientLight : OnRenderObjectConnector
{
	private sealed class CamSettings : IDisposable
	{
		public CommandBuffer CbStencil; //Field offset: 0x10
		public CommandBuffer CbAmbient; //Field offset: 0x18
		public RenderTexture Texture; //Field offset: 0x20
		public bool HDR; //Field offset: 0x28

		public CamSettings() { }

		public override void Dispose() { }

		private void Dispose(bool disposing) { }

		protected virtual void Finalize() { }

	}

	internal class CullingSettings
	{
		public float Distance; //Field offset: 0x10
		public float FadeLength; //Field offset: 0x14
		private float _maxSqrtDistance; //Field offset: 0x18
		private float _minSqrtDistance; //Field offset: 0x1C
		private float _invSqrtDistRange; //Field offset: 0x20

		public CullingSettings() { }

		public bool PassCulling(float sqrtDistance, out float fadeValue) { }

		public void Update() { }

	}

	private static readonly HashSet AnalyticSources; //Field offset: 0x0
	private static readonly SortedSet AnalyticSourcesSorted; //Field offset: 0x8
	private static readonly HashSet DynamicAnalyticSources; //Field offset: 0x10
	private static readonly SortedSet DynamicAnalyticSourcesSorted; //Field offset: 0x18
	private static readonly HashSet StencilShadowsObjects; //Field offset: 0x20
	private static readonly SortedSet StencilShadowsObjectsSorted; //Field offset: 0x28
	public static bool UseSortedSources; //Field offset: 0x30
	private static Mesh _quadMesh; //Field offset: 0x38
	private static Mesh _qubeMesh; //Field offset: 0x40
	private static readonly Matrix4x4 MatrixIdentity; //Field offset: 0x48
	private static int[] _idSha; //Field offset: 0x88
	private static int[] _idShb; //Field offset: 0x90
	private static int _idShc; //Field offset: 0x98
	private static readonly int _cullID; //Field offset: 0x9C
	private static readonly int _zTestID; //Field offset: 0xA0
	private static readonly int _srcBlendID; //Field offset: 0xA4
	private static readonly int _dstBlendID; //Field offset: 0xA8
	private static readonly int _cullingFade; //Field offset: 0xAC
	private static readonly int _ambientBlur; //Field offset: 0xB0
	private static readonly int _eftAmbientID; //Field offset: 0xB4
	private static readonly int _reflectionIntensityID; //Field offset: 0xB8
	private static readonly int _reflectionBottomShade; //Field offset: 0xBC
	private static readonly int _myGlobalReflectionProbeID; //Field offset: 0xC0
	private static readonly string _stencilShadowsMarkerName; //Field offset: 0xC8
	private static readonly string _stencilAnalyticSourcesMarkerName; //Field offset: 0xD0
	private static readonly string _stencilDynamicAnalyticSourcesMarkerName; //Field offset: 0xD8
	private static List _runtimeStaticSources; //Field offset: 0xE0
	private Dictionary _cameras; //Field offset: 0x20
	private Dictionary _swap; //Field offset: 0x28
	[Help("Use method SetSH to set spherical harmonics")]
	public Shader DepthWriteShader; //Field offset: 0x30
	public Shader ClearStencilShader; //Field offset: 0x38
	public Shader WriteStencilShader; //Field offset: 0x40
	public Shader ScreenAmbientShader; //Field offset: 0x48
	[FormerlySerializedAs("AnalSourceShader")]
	public Shader AnalyticSourceShader; //Field offset: 0x50
	[Space]
	public float AmbientBlur; //Field offset: 0x58
	[Header("Reflections")]
	public float ReflectionIntensity; //Field offset: 0x5C
	public float ReflectionIntensitySSR; //Field offset: 0x60
	public float RenderDelay; //Field offset: 0x64
	public int QubemapResolution; //Field offset: 0x68
	public LayerMask CullingMask; //Field offset: 0x6C
	[Range(0, 1)]
	public float ReflectionBottomShade; //Field offset: 0x70
	public AnimationCurve _reflectionWettingFunc; //Field offset: 0x78
	private Material _depthWriteMaterial; //Field offset: 0x80
	private Material _clearStencilMaterial; //Field offset: 0x88
	private Material _writeStencilMaterial; //Field offset: 0x90
	private Material _screenAmbientMaterial; //Field offset: 0x98
	private Material _analyticSourceMaterial; //Field offset: 0xA0
	private MaterialPropertyBlock _screenAmbientBlock; //Field offset: 0xA8
	private bool _isInitialized; //Field offset: 0xB0
	private readonly List _removeList; //Field offset: 0xB8
	private RenderTexture _cubeRT; //Field offset: 0xC0
	private int _faceNum; //Field offset: 0xC8
	private Camera _cubemapCamera; //Field offset: 0xD0
	private float _nextRenderTime; //Field offset: 0xD8

	private RenderTexture CubeRT
	{
		private get { } //Length: 828
	}

	public bool IsInitialized
	{
		 get { } //Length: 8
	}

	private bool IsSSREnable
	{
		private get { } //Length: 191
	}

	private static AmbientLight() { }

	public AmbientLight() { }

	public static void AddAnalyticSource(AnalyticSource source) { }

	public static void AddDynamicAnalyticSource(DynamicAnalyticSource source) { }

	public static void AddStencilShadow(StencilShadow shadow) { }

	private void ControlReflectionIntensity() { }

	private static RenderTexture CreateIndoorTexture(int width, int height, string name = "") { }

	private static Mesh CreateQuad() { }

	private void DisposeCameras() { }

	private void DrawAnalyticSource(AnalyticSource source, CommandBuffer cmdBuf, Vector3 camPos, Plane[] frustrumPlanes) { }

	private void DrawAnalyticSourceOptimized(AnalyticSource source, CommandBuffer cmdBuf, Vector3 camPos, Plane[] frustrumPlanes) { }

	private void DrawAnalyticSources(CommandBuffer cmdBuf, Vector3 camPos, Plane[] frustrumPlanes) { }

	private void DrawStencil(CamSettings camSettings, Camera currentCamera) { }

	private bool DrawStencilShadow(CommandBuffer cmdBuf, StencilShadow ss, Vector3 camPos, bool disableColorPass = false) { }

	private void DrawStencilShadow(CommandBuffer cmdBuf, Vector3 camPos, Plane[] frustrumPlanes) { }

	private RenderTexture get_CubeRT() { }

	public bool get_IsInitialized() { }

	private bool get_IsSSREnable() { }

	public Color GetColor(SphericalHarmonicsL2 sh, Vector3 normal) { }

	public Color GetColorTop(SphericalHarmonicsL2 sh) { }

	private static Mesh GetCubeMesh() { }

	public static Mesh GetQuadMesh() { }

	private void InitAmbientBuffer(CamSettings camSettings, Camera currentCamera) { }

	private void Initialize() { }

	private void InitStencilBuffer(CommandBuffer commandBuffer, RenderTexture renderTexture, string shaderTextureName) { }

	private bool IsCorrectLayer(int cullingMask) { }

	private static bool IsInLoadingScreen() { }

	public void LateUpdate() { }

	public virtual void ManualOnRenderObject(Camera currentCamera) { }

	protected virtual void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public static void RemoveAnalyticSource(AnalyticSource source) { }

	public static void RemoveDynamicAnalyticSource(DynamicAnalyticSource source) { }

	public static void RemoveStencilShadow(StencilShadow shadow) { }

	private void RenderCameras() { }

	private void RenderToCubemap() { }

	public void RuntimeDrawStaticSourcesOptimized(CommandBuffer cmdBuf, Vector3 camPos, Plane[] frustrumPlanes) { }

	public static void RuntimeForceAnalyticSourceVisibility(bool flag) { }

	public static void RuntimeOptimizeClear() { }

	public static void RuntimeOptimizePrepare() { }

	public void SetReflectionIntensity(float value) { }

	public void SetSH(SphericalHarmonicsL2 sh) { }

	protected virtual void Start() { }

	public void Update() { }

}

