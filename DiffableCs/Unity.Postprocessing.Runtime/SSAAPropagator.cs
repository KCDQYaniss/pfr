//Type is in global namespace

[ExecuteInEditMode]
public class SSAAPropagator : MonoBehaviour
{
	private static readonly string KWRD_NON_JITTERED; //Field offset: 0x0
	private static readonly string KWRD_TAA; //Field offset: 0x8
	private static readonly string KWRD_NIGHTVISION_NOISE; //Field offset: 0x10
	private static readonly int ID_NONJITTEREDPROJ; //Field offset: 0x18
	private SSAA m_ssaa; //Field offset: 0x20
	private CommandBuffer _cmdBuf; //Field offset: 0x28
	private Camera _camera; //Field offset: 0x30
	private Material _nightVisionMaterial; //Field offset: 0x38
	private Material _thermalVisionMaterial; //Field offset: 0x40
	private RenderTexture _resampledDepthTarget; //Field offset: 0x48
	private RenderTexture[] _resampledColorTargetHDR; //Field offset: 0x50
	private RenderTexture[] _resampledColorTargetLDR; //Field offset: 0x58
	private RenderTexture _inputTexture; //Field offset: 0x60
	private Renderer _opticLensRenderer; //Field offset: 0x68
	private Renderer[] _sightNonLensRenderers; //Field offset: 0x70
	private Renderer[] _otherWeaponRenderers; //Field offset: 0x78
	private Material[] _sightNonLensRenderersMaterials; //Field offset: 0x80
	private Material[] _otherWeaponRenderersMaterials; //Field offset: 0x88
	private Material _opticLensMaterial; //Field offset: 0x90
	private Renderer _collimatorRenderer; //Field offset: 0x98
	private Material _collimatorMaterial; //Field offset: 0xA0
	private PostProcessVolume _postProcessVolume; //Field offset: 0xA8
	private PostProcessLayer _postProcessLayer; //Field offset: 0xB0
	private bool _thermalVisionIsOn; //Field offset: 0xB8
	private bool _isInitialized; //Field offset: 0xB9
	private int _currentDestinationHDR; //Field offset: 0xBC
	private int _currentDestinationLDR; //Field offset: 0xC0
	private bool _HDRSourceDestination; //Field offset: 0xC4
	public Material CopyDLSSResources; //Field offset: 0xC8
	public Material DLSSDebugOutput; //Field offset: 0xD0
	public ComputeShader EASUShader; //Field offset: 0xD8
	public ComputeShader RCASShader; //Field offset: 0xE0
	public ComputeShader AutogenReactiveShader; //Field offset: 0xE8
	public ComputeShader TCRAutogenShader; //Field offset: 0xF0
	public ComputeShader ComputeLuminancePyramidShader; //Field offset: 0xF8
	public ComputeShader ReconstructPreviousDepthShader; //Field offset: 0x100
	public ComputeShader DepthClipShader; //Field offset: 0x108
	public ComputeShader LockShader; //Field offset: 0x110
	public ComputeShader AccumulateShader; //Field offset: 0x118
	public ComputeShader RCAS2Shader; //Field offset: 0x120
	public ComputeShader FSR3AutogenReactiveShader; //Field offset: 0x128
	public ComputeShader FSR3TCRAutogenShader; //Field offset: 0x130
	public ComputeShader FSR3ComputeLuminancePyramidShader; //Field offset: 0x138
	public ComputeShader FSR3ReconstructPreviousDepthShader; //Field offset: 0x140
	public ComputeShader FSR3DepthClipShader; //Field offset: 0x148
	public ComputeShader FSR3LockShader; //Field offset: 0x150
	public ComputeShader FSR3AccumulateShader; //Field offset: 0x158
	public ComputeShader FSR3RCAS2Shader; //Field offset: 0x160

	private static SSAAPropagator() { }

	public SSAAPropagator() { }

	private void Awake() { }

	private void ClearResources() { }

	public void FillCommandBuffer(CommandBuffer externalCommandBuffer, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public bool GetSourceDestination(out RenderTexture source, out RenderTexture destination) { }

	private bool GetSourceDestinationHDR(out RenderTexture source, out RenderTexture destination) { }

	public bool GetSourceDestinationHDRToLDR(out RenderTexture source, out RenderTexture destination) { }

	private bool GetSourceDestinationLDR(out RenderTexture source, out RenderTexture destination) { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void ReleaseSourceDestination(RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public void ReleaseSourceDestinationHDRToLDR(RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public void SetLensCollimator(Renderer collimatorRenderer) { }

	public void SetLensRenderer(Renderer opticLensRenderer, Renderer[] sightNonLensRenderers, Renderer[] otherWeaponRenderers) { }

	public void SetNightVisionMaterial(Material mat) { }

	public void SetThermalVisionOn(bool on, Material mat) { }

}

