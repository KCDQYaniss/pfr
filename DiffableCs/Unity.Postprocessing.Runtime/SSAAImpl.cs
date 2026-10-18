//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SSAAImpl : MonoBehaviour
{
	private enum SSState
	{
		NOSCALE = 0,
		UPSCALE = 1,
		DOWNSCALE = 2,
	}

	private const string FORWARD_OPAQUE_DUMMY_SHADER = "Hidden/SSAAImpl_DummyShader"; //Field offset: 0x0
	private GameObject _dummy; //Field offset: 0x20
	private Camera _currentCamera; //Field offset: 0x28
	private RenderTexture _currentRT; //Field offset: 0x30
	private CommandBuffer _cmdBufAfterForwardAlpha; //Field offset: 0x38
	private CommandBuffer _cmdBufAfterForwardOpaque; //Field offset: 0x40
	private float _currentSSRatio; //Field offset: 0x48
	private float _nextSSRation; //Field offset: 0x4C
	public bool FlippedV; //Field offset: 0x50
	private Material RenderTextureMaterialBicubic; //Field offset: 0x58
	private Material RenderTextureMaterialBicubic2; //Field offset: 0x60
	[CompilerGenerated]
	private Mesh <FullScreenMesh>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Mesh <FullScreenYFlippedMesh>k__BackingField; //Field offset: 0x70
	public Renderer OpticLensRenderer; //Field offset: 0x78
	public Renderer CollimatorRenderer; //Field offset: 0x80
	public Material LensMaterial; //Field offset: 0x88
	public Material CollimatorMaterial; //Field offset: 0x90
	public int CopyLensDepthMotionPass; //Field offset: 0x98
	public int DrawCollimatorPass; //Field offset: 0x9C
	public ComputeBuffer LensVerticesReadBuffer; //Field offset: 0xA0
	public ComputeBuffer LensVerticesWriteBuffer; //Field offset: 0xA8
	public ComputeBuffer LensDUVDXYBuffer; //Field offset: 0xB0
	public DEPTH_COPY_MODE DepthCopyMode; //Field offset: 0xB8
	[CompilerGenerated]
	private Action RenderTexturesAreChanged; //Field offset: 0xC0
	private int _prevWidth; //Field offset: 0xC8
	private int _prevHeight; //Field offset: 0xCC
	private CommandBuffer _applyResultCmdBuf; //Field offset: 0xD0
	private CommandBuffer _applyResultCmdBuf2; //Field offset: 0xD8
	private SSState CurrentState; //Field offset: 0xE0
	private DLSSWrapper _dlssWrapper; //Field offset: 0xE8
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xF0
	public bool SwapDLSSUpDown; //Field offset: 0xF8
	public bool EnableDLSS; //Field offset: 0xF9
	private bool _failedToInitializeDLSS; //Field offset: 0xFA
	public float DLSSSharpness; //Field offset: 0xFC
	public bool DLSSDebug; //Field offset: 0x100
	public bool DLSSDebugDisable; //Field offset: 0x101
	public bool DLSSCopy; //Field offset: 0x102
	public int DLSSQualityNext; //Field offset: 0x104
	public Vector2 DLSSMVScale; //Field offset: 0x108
	private int _DLSSCurrentQuality; //Field offset: 0x110
	public Vector2 DLSSJitter; //Field offset: 0x114
	public float DLSSJitterXScale; //Field offset: 0x11C
	public float DLSSJitterYScale; //Field offset: 0x120
	public bool InventoryBlurIsEnabled; //Field offset: 0x124
	public bool EnableFSR; //Field offset: 0x125
	private FSRWrapper _fsrWrapper; //Field offset: 0x128
	private bool _failedToInitializeFSR; //Field offset: 0x130
	private bool _enableFSR2; //Field offset: 0x131
	private FSR2Wrapper _fsr2Wrapper; //Field offset: 0x138
	private bool _failedToInitializeFSR2; //Field offset: 0x140
	private bool _enableFSR3; //Field offset: 0x141
	private FSR3Wrapper _fsr3Wrapper; //Field offset: 0x148
	private bool _failedToInitializeFSR3; //Field offset: 0x150

	public event Action RenderTexturesAreChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public bool EnableFSR2
	{
		 get { } //Length: 8
		 set { } //Length: 71
	}

	public bool EnableFSR3
	{
		 get { } //Length: 8
		 set { } //Length: 71
	}

	public private Mesh FullScreenMesh
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Mesh FullScreenYFlippedMesh
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SSAAImpl() { }

	[CompilerGenerated]
	public void add_RenderTexturesAreChanged(Action value) { }

	private void ApplySwitch() { }

	private void Awake() { }

	private bool CheckCamera() { }

	public float ComputeOptimalResamplingFactor(int outputWidth, int outputHeight, int quality) { }

	private static GameObject CreateForwardRenderDummy(Transform parent) { }

	public bool get_EnableFSR2() { }

	public bool get_EnableFSR3() { }

	[CompilerGenerated]
	public Mesh get_FullScreenMesh() { }

	[CompilerGenerated]
	public Mesh get_FullScreenYFlippedMesh() { }

	public DepthTextureMode GetCameraFlags() { }

	public PresetController GetDLSSPresetController() { }

	public int GetInputHeight() { }

	public int GetInputWidth() { }

	public int GetOutputHeight() { }

	public int GetOutputWidth() { }

	public RenderTexture GetRT() { }

	public RenderTargetIdentifier GetRTIdentifier() { }

	public bool IsUsingDLSS() { }

	public bool IsUsingFSR2() { }

	private bool NeedToApplySwitch() { }

	private void OnDestroy() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	[CompilerGenerated]
	public void remove_RenderTexturesAreChanged(Action value) { }

	public void RenderImage(RenderTexture source, RenderTexture destination, bool flipV, CommandBuffer externalCommandBuffer) { }

	public void RenderImage(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	public void set_EnableFSR2(bool value) { }

	public void set_EnableFSR3(bool value) { }

	[CompilerGenerated]
	private void set_FullScreenMesh(Mesh value) { }

	[CompilerGenerated]
	private void set_FullScreenYFlippedMesh(Mesh value) { }

	public void SetAfterTransparentRT(RenderTexture source) { }

	private static void SetupMesh(Mesh mesh, bool flipV = false) { }

	public void Switch(float superSamplingRatio) { }

	private bool TryRenderDLSS(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	private bool TryRenderFSR(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	private bool TryRenderFSR2(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	private bool TryRenderFSR3(RenderTexture source, RenderTexture destination, CommandBuffer externalCommandBuffer) { }

	public bool UsesDLSSUpscaler() { }

	public bool UsesFSR2Upscaler() { }

	public bool UsesFSR3Upscaler() { }

	public bool UsesFSRUpscaler() { }

}

