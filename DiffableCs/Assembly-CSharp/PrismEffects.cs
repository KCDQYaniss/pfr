//Type is in global namespace

[AddComponentMenu("PRISM/Prism Effects")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PrismEffects : MonoBehaviour
{
	private static readonly int _bloomIntensity; //Field offset: 0x0
	private static readonly int _bloomThreshold; //Field offset: 0x4
	private static readonly int _dirtIntensity; //Field offset: 0x8
	private static readonly int _fogIntensity; //Field offset: 0xC
	private static readonly int _vignetteStart; //Field offset: 0x10
	private static readonly int _vignetteEnd; //Field offset: 0x14
	private static readonly int _vignetteIntensity; //Field offset: 0x18
	private static readonly int _vignetteColor; //Field offset: 0x1C
	private static readonly int _nvColor; //Field offset: 0x20
	private static readonly int _targetWhiteColor; //Field offset: 0x24
	private static readonly int _baseLightingContribution; //Field offset: 0x28
	private static readonly int _lightSensitivityMultiplier; //Field offset: 0x2C
	private static readonly int _grainIntensity; //Field offset: 0x30
	private static readonly int _grainTex; //Field offset: 0x34
	private static readonly int _randomInts; //Field offset: 0x38
	private static readonly int _chromaticIntensity; //Field offset: 0x3C
	private static readonly int _chromaticParams; //Field offset: 0x40
	private static readonly int _toneParams; //Field offset: 0x44
	private static readonly int _secondaryToneParams; //Field offset: 0x48
	private static readonly int _shadowToneParams; //Field offset: 0x4C
	private static readonly int _gamma; //Field offset: 0x50
	private static readonly int _sharpenAmount; //Field offset: 0x54
	private static readonly int _dirtTex; //Field offset: 0x58
	private static readonly int _exposureLowerLimit; //Field offset: 0x5C
	private static readonly int _exposureUpperLimit; //Field offset: 0x60
	private static readonly int _exposureMiddleGrey; //Field offset: 0x64
	private static readonly int _exposureSpeed; //Field offset: 0x68
	private static readonly int _useNoise; //Field offset: 0x6C
	private static readonly int _useNightVision; //Field offset: 0x70
	private static readonly int _sunWeight; //Field offset: 0x74
	private static readonly int _aoIntensity; //Field offset: 0x78
	private static readonly int _aoLuminanceWeighting; //Field offset: 0x7C
	private static readonly int _aoSampleCount; //Field offset: 0x80
	private static readonly int _aoSpiralTurns; //Field offset: 0x84
	private static readonly int _sunColor; //Field offset: 0x88
	private static readonly int _sunThreshold; //Field offset: 0x8C
	private static readonly int _sunPosition; //Field offset: 0x90
	private static readonly int _fogHeight; //Field offset: 0x94
	private static readonly int _fogDistance; //Field offset: 0x98
	private static readonly int _fogStart; //Field offset: 0x9C
	private static readonly int _fogColor; //Field offset: 0xA0
	private static readonly int _fogEndColor; //Field offset: 0xA4
	private static readonly int _fogBlurSkybox; //Field offset: 0xA8
	private static readonly int _inverseView; //Field offset: 0xAC
	private static readonly int _aoRadius; //Field offset: 0xB0
	private static readonly int _aoBias; //Field offset: 0xB4
	private static readonly int _aoTargetScale; //Field offset: 0xB8
	private static readonly int _aoCutoff; //Field offset: 0xBC
	private static readonly int _aoCutoffRange; //Field offset: 0xC0
	private static readonly int _aoCameraModelView; //Field offset: 0xC4
	private static readonly int _aoProjInfo; //Field offset: 0xC8
	private static readonly int _lutScale; //Field offset: 0xCC
	private static readonly int _lutOffset; //Field offset: 0xD0
	private static readonly int _lutTex; //Field offset: 0xD4
	private static readonly int _lutAmount; //Field offset: 0xD8
	private static readonly int _secondLutScale; //Field offset: 0xDC
	private static readonly int _secondLutOffset; //Field offset: 0xE0
	private static readonly int _secondLutTex; //Field offset: 0xE4
	private static readonly int _secondLutAmount; //Field offset: 0xE8
	private static readonly int _dofFocusPoint; //Field offset: 0xEC
	private static readonly int _dofFocusDistance; //Field offset: 0xF0
	private static readonly int _dofRadius; //Field offset: 0xF4
	private static readonly int _dofFactor; //Field offset: 0xF8
	private static readonly int _dofUseNearBlur; //Field offset: 0xFC
	private static readonly int _dofNearFocusDistance; //Field offset: 0x100
	private static readonly int _dofBlurSkybox; //Field offset: 0x104
	private static readonly int _brightnessTexture; //Field offset: 0x108
	private static readonly int _blurVector; //Field offset: 0x10C
	private static readonly int _lastCameraDepthTexture1; //Field offset: 0x110
	private static readonly int _doF1; //Field offset: 0x114
	private static readonly int _dofUseLerp; //Field offset: 0x118
	private static readonly int _currentIteration; //Field offset: 0x11C
	private static readonly int _blurredScreenTex; //Field offset: 0x120
	private static readonly int _bloom1; //Field offset: 0x124
	private static readonly int _bloomAcc; //Field offset: 0x128
	private static readonly int _bloom2; //Field offset: 0x12C
	private static readonly int _bloom3; //Field offset: 0x130
	private static readonly int _bloom4; //Field offset: 0x134
	private static readonly int _aoBlurVector; //Field offset: 0x138
	private static readonly int _aoTex; //Field offset: 0x13C
	private static readonly int _raysTexture; //Field offset: 0x140
	public PrismPreset currentPrismPreset; //Field offset: 0x20
	private bool shouldSkipNextFrame; //Field offset: 0x28
	public bool isParentPrism; //Field offset: 0x29
	public bool isChildPrism; //Field offset: 0x2A
	private RenderTexture depthTex; //Field offset: 0x30
	public Material m_Material; //Field offset: 0x38
	public Shader m_Shader; //Field offset: 0x40
	public Material m_Material2; //Field offset: 0x48
	public Shader m_Shader2; //Field offset: 0x50
	public PrismEffects m_MasterEffectExposure; //Field offset: 0x58
	private List m_DependentEffectsExposure; //Field offset: 0x60
	public Material m_AOMaterial; //Field offset: 0x68
	public Shader m_AOShader; //Field offset: 0x70
	public Material m_Material3; //Field offset: 0x78
	public Shader m_Shader3; //Field offset: 0x80
	private Camera m_Camera; //Field offset: 0x88
	private SSAA m_SSAA; //Field offset: 0x90
	public bool doBigPass; //Field offset: 0x98
	public bool useSeparableBlur; //Field offset: 0x99
	public Texture2D lensDirtTexture; //Field offset: 0xA0
	public bool useLensDirt; //Field offset: 0xA8
	[Space(10)]
	public bool useBloom; //Field offset: 0xA9
	public bool bloomUseScreenBlend; //Field offset: 0xAA
	public BloomType bloomType; //Field offset: 0xAC
	public bool debugBloomTex; //Field offset: 0xB0
	[Range(1, 12)]
	public int bloomDownsample; //Field offset: 0xB4
	[Range(0, 12)]
	public int bloomBlurPasses; //Field offset: 0xB8
	public float bloomIntensity; //Field offset: 0xBC
	[Range(-2, 2)]
	public float bloomThreshold; //Field offset: 0xC0
	public float dirtIntensity; //Field offset: 0xC4
	public bool useBloomStability; //Field offset: 0xC8
	private RenderTexture accumulationBuffer; //Field offset: 0xD0
	public bool useUIBlur; //Field offset: 0xD8
	public int uiBlurGrabTextureFromPassNumber; //Field offset: 0xDC
	private RenderTexture uiBlurTexture; //Field offset: 0xE0
	[Space(10)]
	public bool useVignette; //Field offset: 0xE8
	public float vignetteStart; //Field offset: 0xEC
	public float vignetteEnd; //Field offset: 0xF0
	public float vignetteStrength; //Field offset: 0xF4
	public Color vignetteColor; //Field offset: 0xF8
	[Space(10)]
	public bool useNightVision; //Field offset: 0x108
	[SerializeField]
	[Tooltip("The main color of the NV effect")]
	public Color m_NVColor; //Field offset: 0x10C
	[SerializeField]
	[Tooltip("The color that the NV effect will 'bleach' towards (white = default)")]
	public Color m_TargetBleachColor; //Field offset: 0x11C
	[Range(0, 0.1)]
	[Tooltip("How much base lighting does the NV effect pick up")]
	public float m_baseLightingContribution; //Field offset: 0x12C
	[Range(0, 128)]
	[Tooltip("The higher this value, the more bright areas will get 'bleached out'")]
	public float m_LightSensitivityMultiplier; //Field offset: 0x130
	[Space(10)]
	public bool useNoise; //Field offset: 0x134
	public Texture2D noiseTexture; //Field offset: 0x138
	public float noiseScale; //Field offset: 0x140
	public float noiseIntensity; //Field offset: 0x144
	public NoiseType noiseType; //Field offset: 0x148
	[Space(10)]
	public bool useChromaticAberration; //Field offset: 0x14C
	public AberrationType aberrationType; //Field offset: 0x150
	[Range(0, 1)]
	public float chromaticDistanceOne; //Field offset: 0x154
	[Range(0, 1)]
	public float chromaticDistanceTwo; //Field offset: 0x158
	public float chromaticIntensity; //Field offset: 0x15C
	public float chromaticBlurWidth; //Field offset: 0x160
	public bool useChromaticBlur; //Field offset: 0x164
	[Space(10)]
	public bool useTonemap; //Field offset: 0x165
	public TonemapType tonemapType; //Field offset: 0x168
	public Vector3 toneValues; //Field offset: 0x16C
	public Vector3 secondaryToneValues; //Field offset: 0x178
	public Vector4 shadowToneValues; //Field offset: 0x184
	public bool useExposure; //Field offset: 0x194
	public bool debugViewExposure; //Field offset: 0x195
	private RenderTexture currentAdaptationTexture; //Field offset: 0x198
	public float exposureMiddleGrey; //Field offset: 0x1A0
	public float exposureLowerLimit; //Field offset: 0x1A4
	public float exposureUpperLimit; //Field offset: 0x1A8
	public float exposureSpeed; //Field offset: 0x1AC
	public int histWidth; //Field offset: 0x1B0
	public int histHeight; //Field offset: 0x1B4
	private bool firstRun; //Field offset: 0x1B8
	public bool useGammaCorrection; //Field offset: 0x1B9
	public float gammaValue; //Field offset: 0x1BC
	[Space(10)]
	public bool useDof; //Field offset: 0x1C0
	public bool dofForceEnableMedian; //Field offset: 0x1C1
	public bool useNearDofBlur; //Field offset: 0x1C2
	public bool useFullScreenBlur; //Field offset: 0x1C3
	public float dofNearFocusDistance; //Field offset: 0x1C4
	public float dofFocusPoint; //Field offset: 0x1C8
	public float dofFocusDistance; //Field offset: 0x1CC
	public float dofRadius; //Field offset: 0x1D0
	public float dofBokehFactor; //Field offset: 0x1D4
	public DoFSamples dofSampleAmount; //Field offset: 0x1D8
	public bool dofBlurSkybox; //Field offset: 0x1DC
	public bool debugDofPass; //Field offset: 0x1DD
	public Transform dofFocusTransform; //Field offset: 0x1E0
	[Space(10)]
	public bool useLut; //Field offset: 0x1E8
	public Texture2D twoDLookupTex; //Field offset: 0x1F0
	public Texture3D threeDLookupTex; //Field offset: 0x1F8
	public string basedOnTempTex; //Field offset: 0x200
	public float lutLerpAmount; //Field offset: 0x208
	public bool useSecondLut; //Field offset: 0x20C
	public Texture2D secondaryTwoDLookupTex; //Field offset: 0x210
	public Texture3D secondaryThreeDLookupTex; //Field offset: 0x218
	public string secondaryBasedOnTempTex; //Field offset: 0x220
	public float secondaryLutLerpAmount; //Field offset: 0x228
	[Space(10)]
	public bool useSharpen; //Field offset: 0x22C
	public float sharpenAmount; //Field offset: 0x230
	public bool useFog; //Field offset: 0x234
	public bool fogAffectSkybox; //Field offset: 0x235
	public float fogIntensity; //Field offset: 0x238
	public float fogStartPoint; //Field offset: 0x23C
	public float fogDistance; //Field offset: 0x240
	public Color fogColor; //Field offset: 0x244
	public Color fogEndColor; //Field offset: 0x254
	public float fogHeight; //Field offset: 0x264
	public bool useAmbientObscurance; //Field offset: 0x268
	public SampleCount aoSampleCount; //Field offset: 0x26C
	public bool useAODistanceCutoff; //Field offset: 0x270
	public float aoDistanceCutoffLength; //Field offset: 0x274
	public float aoDistanceCutoffStart; //Field offset: 0x278
	public float aoIntensity; //Field offset: 0x27C
	public float aoMinIntensity; //Field offset: 0x280
	public float aoRadius; //Field offset: 0x284
	public bool aoDownsample; //Field offset: 0x288
	public AOBlurType aoBlurType; //Field offset: 0x28C
	[Range(0, 3)]
	public int aoBlurIterations; //Field offset: 0x290
	public float aoBias; //Field offset: 0x294
	public float aoBlurFilterDistance; //Field offset: 0x298
	public float aoLightingContribution; //Field offset: 0x29C
	public bool aoShowDebug; //Field offset: 0x2A0
	public bool useRays; //Field offset: 0x2A1
	public Transform rayTransform; //Field offset: 0x2A8
	public float rayWeight; //Field offset: 0x2B0
	public Color rayColor; //Field offset: 0x2B4
	public Color rayThreshold; //Field offset: 0x2C4
	public bool raysShowDebug; //Field offset: 0x2D4
	[Space(10)]
	public bool advancedVignette; //Field offset: 0x2D5
	public bool advancedAO; //Field offset: 0x2D6
	private bool _supportsRenderTextureFormatR8; //Field offset: 0x2D7
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x2D8

	public RenderTexture AdaptationTexture
	{
		 get { } //Length: 8
	}

	public int aoSampleCountValue
	{
		 get { } //Length: 63
		 set { } //Length: 7
	}

	private RenderTextureFormat aoTextureFormat
	{
		private get { } //Length: 15
	}

	public bool forceSecondChromaticPass
	{
		 get { } //Length: 38
	}

	public bool IsGBufferAvailable
	{
		 get { } //Length: 99
	}

	public bool useMedianDoF
	{
		 get { } //Length: 38
	}

	public bool UsingTerrain
	{
		 get { } //Length: 273
	}

	private static PrismEffects() { }

	public PrismEffects() { }

	public void AddDependantEffectExposure(PrismEffects pe) { }

	private void Awake() { }

	private RenderTexture BlurTex(RenderTexture tex, int iterations = 1) { }

	public void Convert(Texture2D temp2DTex, bool secondaryLut = false) { }

	private Material CreateMaterial(Shader shader) { }

	private bool CreateMaterials() { }

	[ContextMenu("DontRenderDepthTexture")]
	private void DontRenderDepthTexture() { }

	public void DontRenderPrismThisFrame() { }

	public RenderTexture get_AdaptationTexture() { }

	public int get_aoSampleCountValue() { }

	private RenderTextureFormat get_aoTextureFormat() { }

	public bool get_forceSecondChromaticPass() { }

	public bool get_IsGBufferAvailable() { }

	public bool get_useMedianDoF() { }

	public bool get_UsingTerrain() { }

	public Camera GetPrismCamera() { }

	private void HandleExposure(RenderTexture source, RenderTextureFormat rtFormat) { }

	private void HandleGodrays(RenderTexture quarterResMain) { }

	public void LerpToPreset(PrismPreset preset, float t) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture source, RenderTexture destination) { }

	public void Reset() { }

	public void ResetDofTransform() { }

	public void ResetToneParamsACES() { }

	public void ResetToneParamsFilmic() { }

	public void ResetToneParamsRomB() { }

	public void set_aoSampleCountValue(int value) { }

	private void SetAOShaderValues(Material aoMaterial) { }

	private void SetBloomStablityValues() { }

	public void SetChromaticIntensity(float value) { }

	public void SetDofPoint(Vector3 point) { }

	public void SetDofTransform(Transform target) { }

	private void SetDofValues(Material targetMat) { }

	private void SetFogShaderValues(Material fogMaterial) { }

	public void SetGamma(float value) { }

	private void SetGodraysShaderValues(Material raysMaterial) { }

	public void SetIdentityLut(bool secondary = false) { }

	public void SetNoiseIntensity(float value) { }

	private void SetPrimaryLutShaderValues() { }

	public void SetPrimaryLutStrength(float value) { }

	public void SetPrismPreset(PrismPreset preset) { }

	private void SetSecondaryLutShaderValues() { }

	public void SetSecondaryLutStrength(float value) { }

	public void SetVignetteStrength(float value) { }

	public void UpdateShaderValues() { }

	public bool ValidDimensions(Texture2D tex2d) { }

}

