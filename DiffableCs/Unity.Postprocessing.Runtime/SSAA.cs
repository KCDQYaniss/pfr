//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SSAA : MonoBehaviour
{
	private const int OPTIC_HISTORY_BUFFER_SIZE = 256; //Field offset: 0x0
	public const int COLLIMATOR_MATERIAL_DRAW_PASS = 0; //Field offset: 0x0
	private static readonly int _depthBuffer; //Field offset: 0x0
	public const int OPTIC_MASK_MATERIAL_COPY_DEPHT_MOTION_PASS = 1; //Field offset: 0x0
	private static readonly int _mvBuffer; //Field offset: 0x4
	private static readonly int _verticesRead; //Field offset: 0x8
	private static readonly int _verticesWrite; //Field offset: 0xC
	private SSAAImpl _impl; //Field offset: 0x20
	private SSAAPropagator _prop; //Field offset: 0x28
	private SSAAPropagatorOpaque _propOpaq; //Field offset: 0x30
	private PostProcessLayer _postProc; //Field offset: 0x38
	private float _currentSSRatio; //Field offset: 0x40
	private float _nextSSRatio; //Field offset: 0x44
	public bool DLSSOutputFlipY; //Field offset: 0x48
	public bool UseJitter; //Field offset: 0x49
	private Renderer _opticLensRenderer; //Field offset: 0x50
	private Renderer _collimatorRenderer; //Field offset: 0x58
	private int _objectId; //Field offset: 0x60
	public Shader ScopeMaskShader; //Field offset: 0x68
	public Shader CollimatorShader; //Field offset: 0x70
	public int UnityTAAJitterSamplesRepeatCount; //Field offset: 0x78
	public int BasePhaseSamplesCount; //Field offset: 0x7C
	public float DLSSJitterXScale; //Field offset: 0x80
	public float DLSSJitterYScale; //Field offset: 0x84
	public float MVScaleX; //Field offset: 0x88
	public float MVScaleY; //Field offset: 0x8C
	public USE_PROJ UseProjectionMatrix; //Field offset: 0x90
	private Material _opticMaskMaterial; //Field offset: 0x98
	private Material _collimatorMaterial; //Field offset: 0xA0
	private ComputeBuffer[] _opticLensVerticesHistory; //Field offset: 0xA8
	private ComputeBuffer _opticLensDUVDXY; //Field offset: 0xB0
	private int _opticLensHistoryIdxWrite; //Field offset: 0xB8
	private int _opticLensHistoryIdxRead; //Field offset: 0xBC
	private bool _inventoryBlurIsEnabled; //Field offset: 0xC0
	private bool _isInitialized; //Field offset: 0xC1
	public bool FlippedV; //Field offset: 0xC2

	public Mesh FullScreenMesh
	{
		 get { } //Length: 233
	}

	public Mesh FullScreenYFlippedMesh
	{
		 get { } //Length: 233
	}

	private static SSAA() { }

	public SSAA() { }

	private void Awake() { }

	public void DisableCollimatorRenderer(int objectId) { }

	public Mesh get_FullScreenMesh() { }

	public Mesh get_FullScreenYFlippedMesh() { }

	public DepthTextureMode GetCameraFlags() { }

	public Renderer GetCollimatorRenderer() { }

	public float GetCurrentSSRatio() { }

	public Mesh GetFullScreenMesh() { }

	public Mesh GetFullScreenYFlippedMesh() { }

	public int GetInputHeight() { }

	public int GetInputWidth() { }

	public int GetOutputHeight() { }

	public int GetOutputWidth() { }

	public RenderTexture GetRT() { }

	public RenderTargetIdentifier GetRTIdentifier() { }

	private void Init() { }

	public bool IsUsingDLSS() { }

	public bool IsUsingFSR2() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnPreCull() { }

	public Vector3 RemapToHiRes(Vector3 loRes) { }

	public void RenderImage(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	public void RenderImage(RenderTexture source, RenderTexture destination, bool flipV, CommandBuffer externalCommandBuffer) { }

	public void SetAfterTransparentRT(RenderTexture source) { }

	public void SetCollimatorRenderer(Renderer collimatorRenderer, int objectId) { }

	public void SetInventoryBlurEnabled(bool enabled) { }

	public void SetLensMaterialTextures(Texture depthBuffer, Texture mvBuffer) { }

	public void SetLensRenderer(Renderer opticLensRenderer, Renderer[] sightNonLensRenderers, Renderer[] otherWeaponRenderer) { }

	public void SetThermalVisionOn(bool on, Material mat) { }

	public void Switch(float superSamplingRatio) { }

	private void Update() { }

	public bool UsesDLSSUpscaler() { }

	public bool UsesFSR2Upscaler() { }

	public bool UsesFSR3Upscaler() { }

	public bool UsesFSRUpscaler() { }

}

