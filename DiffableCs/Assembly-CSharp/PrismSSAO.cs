//Type is in global namespace

[AddComponentMenu("PRISM/Prism Effects SSAO")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PrismSSAO : MonoBehaviour
{
	private static readonly int _fogIntensity; //Field offset: 0x0
	private static readonly int _vignetteIntensity; //Field offset: 0x4
	private static readonly int _chromaticIntensity; //Field offset: 0x8
	private static readonly int _gamma; //Field offset: 0xC
	private static readonly int _dirtIntensity; //Field offset: 0x10
	private static readonly int _lutAmount; //Field offset: 0x14
	private static readonly int _secondLutAmount; //Field offset: 0x18
	private static readonly int _useNoise; //Field offset: 0x1C
	private static readonly int _useNightVision; //Field offset: 0x20
	private static readonly int _sunWeight; //Field offset: 0x24
	private static readonly int _aoIntensity; //Field offset: 0x28
	private static readonly int _aoLuminanceWeighting; //Field offset: 0x2C
	private static readonly int _aoSpiralTurns; //Field offset: 0x30
	private static readonly int _aoRadius; //Field offset: 0x34
	private static readonly int _aoBias; //Field offset: 0x38
	private static readonly int _aoTargetScale; //Field offset: 0x3C
	private static readonly int _aoCutoff; //Field offset: 0x40
	private static readonly int _aoCutoffRange; //Field offset: 0x44
	private static readonly int _aoCameraModelView; //Field offset: 0x48
	private static readonly int _aoProjInfo; //Field offset: 0x4C
	private static readonly int _aoBlurVector; //Field offset: 0x50
	private static readonly int _aoTex; //Field offset: 0x54
	private static readonly int _aoSampleCount; //Field offset: 0x58
	public PrismPreset currentPrismPreset; //Field offset: 0x20
	private bool shouldSkipNextFrame; //Field offset: 0x28
	public bool isParentPrism; //Field offset: 0x29
	public bool isChildPrism; //Field offset: 0x2A
	private RenderTexture depthTex; //Field offset: 0x30
	public Material m_Material; //Field offset: 0x38
	public Shader m_Shader; //Field offset: 0x40
	public Material m_Material2; //Field offset: 0x48
	public Shader m_Shader2; //Field offset: 0x50
	public Material m_AOMaterial; //Field offset: 0x58
	public Shader m_AOShader; //Field offset: 0x60
	public Material m_Material3; //Field offset: 0x68
	public Shader m_Shader3; //Field offset: 0x70
	private Camera m_Camera; //Field offset: 0x78
	private SSAA m_SSAA; //Field offset: 0x80
	public Texture2D lensDirtTexture; //Field offset: 0x88
	public bool useLensDirt; //Field offset: 0x90
	public bool useAmbientObscurance; //Field offset: 0x91
	public SampleCount aoSampleCount; //Field offset: 0x94
	public bool useAODistanceCutoff; //Field offset: 0x98
	public float aoDistanceCutoffLength; //Field offset: 0x9C
	public float aoDistanceCutoffStart; //Field offset: 0xA0
	public float aoIntensity; //Field offset: 0xA4
	public float aoMinIntensity; //Field offset: 0xA8
	public float aoRadius; //Field offset: 0xAC
	public bool aoDownsample; //Field offset: 0xB0
	public AOBlurType aoBlurType; //Field offset: 0xB4
	[Range(0, 3)]
	public int aoBlurIterations; //Field offset: 0xB8
	public float aoBias; //Field offset: 0xBC
	public float aoBlurFilterDistance; //Field offset: 0xC0
	public float aoLightingContribution; //Field offset: 0xC4
	public bool aoShowDebug; //Field offset: 0xC8
	[Space(10)]
	public bool advancedVignette; //Field offset: 0xC9
	public bool advancedAO; //Field offset: 0xCA

	public int aoSampleCountValue
	{
		 get { } //Length: 63
		 set { } //Length: 7
	}

	private RenderTextureFormat aoTextureFormat
	{
		private get { } //Length: 28
	}

	public bool IsGBufferAvailable
	{
		 get { } //Length: 96
	}

	public bool UsingTerrain
	{
		 get { } //Length: 273
	}

	private static PrismSSAO() { }

	public PrismSSAO() { }

	private Material CreateMaterial(Shader shader) { }

	private bool CreateMaterials() { }

	[ContextMenu("DontRenderDepthTexture")]
	private void DontRenderDepthTexture() { }

	public int get_aoSampleCountValue() { }

	private RenderTextureFormat get_aoTextureFormat() { }

	public bool get_IsGBufferAvailable() { }

	public bool get_UsingTerrain() { }

	public Camera GetPrismCamera() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void Reset() { }

	public void set_aoSampleCountValue(int value) { }

	private void SetAOShaderValues(Material aoMaterial) { }

	public void SetPrismPreset(PrismPreset preset) { }

	public void UpdateShaderValues() { }

}

