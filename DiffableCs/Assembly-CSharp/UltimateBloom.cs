//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class UltimateBloom : MonoBehaviour
{
	internal enum AnamorphicDirection
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum BlendMode
	{
		ADD = 0,
		SCREEN = 1,
	}

	internal enum BloomIntensityManagement
	{
		FilmicCurve = 0,
		Threshold = 1,
	}

	internal enum BloomQualityPreset
	{
		Optimized = 0,
		Standard = 1,
		HighVisuals = 2,
		Custom = 3,
	}

	internal enum BloomSamplingQuality
	{
		VerySmallKernel = 0,
		SmallKernel = 1,
		MediumKernel = 2,
		LargeKernel = 3,
		LargerKernel = 4,
		VeryLargeKernel = 5,
	}

	internal enum BloomScreenBlendMode
	{
		Screen = 0,
		Add = 1,
	}

	private sealed class BlurFunction : MulticastDelegate
	{

		public BlurFunction(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, RenderTexture additiveTexture, BlurSampleCount sampleCount, Color tint, float intensity, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, RenderTexture additiveTexture, BlurSampleCount sampleCount, Color tint, float intensity) { }

	}

	internal enum BlurSampleCount
	{
		Nine = 0,
		Seventeen = 1,
		Thirteen = 2,
		TwentyThree = 3,
		TwentySeven = 4,
		ThrirtyOne = 5,
		NineCurve = 6,
		FourSimple = 7,
	}

	internal enum BokehFlareQuality
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3,
	}

	internal enum FlareBlurQuality
	{
		Fast = 0,
		Normal = 1,
		High = 2,
	}

	internal enum FlarePresets
	{
		ChoosePreset = 0,
		GhostFast = 1,
		Ghost1 = 2,
		Ghost2 = 3,
		Ghost3 = 4,
		Bokeh1 = 5,
		Bokeh2 = 6,
		Bokeh3 = 7,
	}

	internal enum FlareRendering
	{
		Sharp = 0,
		Blurred = 1,
		MoreBlurred = 2,
	}

	private enum FlareStripeType
	{
		Anamorphic = 0,
		Star = 1,
		DiagonalUpright = 2,
		DiagonalUpleft = 3,
	}

	internal enum FlareType
	{
		Single = 0,
		Double = 1,
	}

	internal enum HDRBloomMode
	{
		Auto = 0,
		On = 1,
		Off = 2,
	}

	internal enum SamplingMode
	{
		Fixed = 0,
		HeightRelative = 1,
	}

	internal enum SimpleSampleCount
	{
		Four = 0,
		Nine = 1,
		FourCurve = 2,
		ThirteenTemporal = 3,
		ThirteenTemporalCurve = 4,
	}

	private static readonly int _maskTex; //Field offset: 0x0
	private static readonly int _intensity; //Field offset: 0x4
	private static readonly int _flareIntensity; //Field offset: 0x8
	private static readonly int _colorBuffer; //Field offset: 0xC
	private static readonly int _flareTexture; //Field offset: 0x10
	private static readonly int _additiveTexture; //Field offset: 0x14
	private static readonly int _brightTexture; //Field offset: 0x18
	private static readonly int _dirtIntensity; //Field offset: 0x1C
	private static readonly int _dirtLightIntensity; //Field offset: 0x20
	private static readonly int _screenMaxIntensity; //Field offset: 0x24
	private static readonly int _flareScales; //Field offset: 0x28
	private static readonly int _flareScalesNear; //Field offset: 0x2C
	private static readonly int _flareTint0; //Field offset: 0x30
	private static readonly int _flareTint1; //Field offset: 0x34
	private static readonly int _flareTint2; //Field offset: 0x38
	private static readonly int _flareTint3; //Field offset: 0x3C
	private static readonly int _flareTint4; //Field offset: 0x40
	private static readonly int _flareTint5; //Field offset: 0x44
	private static readonly int _flareTint6; //Field offset: 0x48
	private static readonly int _flareTint7; //Field offset: 0x4C
	private static readonly int _curveExposure; //Field offset: 0x50
	private static readonly int _k; //Field offset: 0x54
	private static readonly int _crossover; //Field offset: 0x58
	private static readonly int _toe; //Field offset: 0x5C
	private static readonly int _shoulder; //Field offset: 0x60
	private static readonly int _maxValue; //Field offset: 0x64
	private static readonly int _threshhold; //Field offset: 0x68
	private static readonly int _offsetInfos; //Field offset: 0x6C
	private static readonly int _tint; //Field offset: 0x70
	private static readonly int _intensity0; //Field offset: 0x74
	private static readonly int _intensity1; //Field offset: 0x78
	public float m_SamplingMinHeight; //Field offset: 0x20
	public float[] m_ResSamplingPixelCount; //Field offset: 0x28
	public SamplingMode m_SamplingMode; //Field offset: 0x30
	public BlendMode m_BlendMode; //Field offset: 0x34
	public float m_ScreenMaxIntensity; //Field offset: 0x38
	public BloomQualityPreset m_QualityPreset; //Field offset: 0x3C
	public HDRBloomMode m_HDR; //Field offset: 0x40
	public BloomScreenBlendMode m_ScreenBlendMode; //Field offset: 0x44
	public float m_BloomIntensity; //Field offset: 0x48
	public float m_BloomThreshhold; //Field offset: 0x4C
	public Color m_BloomThreshholdColor; //Field offset: 0x50
	public int m_DownscaleCount; //Field offset: 0x60
	public BloomIntensityManagement m_IntensityManagement; //Field offset: 0x64
	public float[] m_BloomIntensities; //Field offset: 0x68
	public Color[] m_BloomColors; //Field offset: 0x70
	public bool[] m_BloomUsages; //Field offset: 0x78
	[SerializeField]
	public DeluxeFilmicCurve m_BloomCurve; //Field offset: 0x80
	private int m_LastDownscaleCount; //Field offset: 0x88
	public bool useTriangleBlit; //Field offset: 0x8C
	private CommandBuffer _cmdBuf; //Field offset: 0x90
	private List _tempTextures; //Field offset: 0x98
	private List _samplingProps; //Field offset: 0xA0
	private int _currentSamplingProp; //Field offset: 0xA8
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xB0
	public bool m_UseLensFlare; //Field offset: 0xB8
	public float m_FlareTreshold; //Field offset: 0xBC
	public float m_FlareIntensity; //Field offset: 0xC0
	public Color m_FlareTint0; //Field offset: 0xC4
	public Color m_FlareTint1; //Field offset: 0xD4
	public Color m_FlareTint2; //Field offset: 0xE4
	public Color m_FlareTint3; //Field offset: 0xF4
	public Color m_FlareTint4; //Field offset: 0x104
	public Color m_FlareTint5; //Field offset: 0x114
	public Color m_FlareTint6; //Field offset: 0x124
	public Color m_FlareTint7; //Field offset: 0x134
	public float m_FlareGlobalScale; //Field offset: 0x144
	public Vector4 m_FlareScales; //Field offset: 0x148
	public Vector4 m_FlareScalesNear; //Field offset: 0x158
	public Texture2D m_FlareMask; //Field offset: 0x168
	public FlareRendering m_FlareRendering; //Field offset: 0x170
	public FlareType m_FlareType; //Field offset: 0x174
	public Texture2D m_FlareShape; //Field offset: 0x178
	public FlareBlurQuality m_FlareBlurQuality; //Field offset: 0x180
	private BokehRenderer m_FlareSpriteRenderer; //Field offset: 0x188
	private Mesh[] m_BokehMeshes; //Field offset: 0x190
	public bool m_UseBokehFlare; //Field offset: 0x198
	public float m_BokehScale; //Field offset: 0x19C
	public BokehFlareQuality m_BokehFlareQuality; //Field offset: 0x1A0
	public bool m_UseAnamorphicFlare; //Field offset: 0x1A4
	public float m_AnamorphicFlareTreshold; //Field offset: 0x1A8
	public float m_AnamorphicFlareIntensity; //Field offset: 0x1AC
	public int m_AnamorphicDownscaleCount; //Field offset: 0x1B0
	public int m_AnamorphicBlurPass; //Field offset: 0x1B4
	private int m_LastAnamorphicDownscaleCount; //Field offset: 0x1B8
	private RenderTexture[] m_AnamorphicUpscales; //Field offset: 0x1C0
	public float[] m_AnamorphicBloomIntensities; //Field offset: 0x1C8
	public Color[] m_AnamorphicBloomColors; //Field offset: 0x1D0
	public bool[] m_AnamorphicBloomUsages; //Field offset: 0x1D8
	public bool m_AnamorphicSmallVerticalBlur; //Field offset: 0x1E0
	public AnamorphicDirection m_AnamorphicDirection; //Field offset: 0x1E4
	public float m_AnamorphicScale; //Field offset: 0x1E8
	public bool m_UseStarFlare; //Field offset: 0x1EC
	public float m_StarFlareTreshol; //Field offset: 0x1F0
	public float m_StarFlareIntensity; //Field offset: 0x1F4
	public float m_StarScale; //Field offset: 0x1F8
	public int m_StarDownscaleCount; //Field offset: 0x1FC
	public int m_StarBlurPass; //Field offset: 0x200
	private int m_LastStarDownscaleCount; //Field offset: 0x204
	private RenderTexture[] m_StarUpscales; //Field offset: 0x208
	public float[] m_StarBloomIntensities; //Field offset: 0x210
	public Color[] m_StarBloomColors; //Field offset: 0x218
	public bool[] m_StarBloomUsages; //Field offset: 0x220
	public bool m_UseLensDust; //Field offset: 0x228
	public float m_DustIntensity; //Field offset: 0x22C
	public Texture2D m_DustTexture; //Field offset: 0x230
	public float m_DirtLightIntensity; //Field offset: 0x238
	public BloomSamplingQuality m_DownsamplingQuality; //Field offset: 0x23C
	public BloomSamplingQuality m_UpsamplingQuality; //Field offset: 0x240
	public bool m_TemporalStableDownsampling; //Field offset: 0x244
	public bool m_InvertImage; //Field offset: 0x245
	private Material m_FlareMaterial; //Field offset: 0x248
	private Shader m_FlareShader; //Field offset: 0x250
	private Material m_SamplingMaterial; //Field offset: 0x258
	private Shader m_SamplingShader; //Field offset: 0x260
	private Material m_CombineMaterial; //Field offset: 0x268
	private Shader m_CombineShader; //Field offset: 0x270
	private Material m_BrightpassMaterial; //Field offset: 0x278
	private Material m_BrightpassWithMaskMaterial; //Field offset: 0x280
	private Shader m_BrightpassShader; //Field offset: 0x288
	private Shader m_BrightpassWithMaskShader; //Field offset: 0x290
	private Material m_FlareMaskMaterial; //Field offset: 0x298
	private Shader m_FlareMaskShader; //Field offset: 0x2A0
	private Material m_MixerMaterial; //Field offset: 0x2A8
	private Shader m_MixerShader; //Field offset: 0x2B0
	private Material m_FlareBokehMaterial; //Field offset: 0x2B8
	private Shader m_FlareBokehShader; //Field offset: 0x2C0
	public bool m_DirectDownSample; //Field offset: 0x2C8
	public bool m_DirectUpsample; //Field offset: 0x2C9
	public bool m_UiShowBloomScales; //Field offset: 0x2CA
	public bool m_UiShowAnamorphicBloomScales; //Field offset: 0x2CB
	public bool m_UiShowStarBloomScales; //Field offset: 0x2CC
	public bool m_UiShowHeightSampling; //Field offset: 0x2CD
	public bool m_UiShowBloomSettings; //Field offset: 0x2CE
	public bool m_UiShowSampling; //Field offset: 0x2CF
	public bool m_UiShowIntensity; //Field offset: 0x2D0
	public bool m_UiShowOptimizations; //Field offset: 0x2D1
	public bool m_UiShowLensDirt; //Field offset: 0x2D2
	public bool m_UiShowLensFlare; //Field offset: 0x2D3
	public bool m_UiShowAnamorphic; //Field offset: 0x2D4
	public bool m_UiShowStar; //Field offset: 0x2D5
	private NightVision _nightVision; //Field offset: 0x2D8
	private RenderTexture[] m_DownSamples; //Field offset: 0x2E0
	private RenderTexture[] m_UpSamples; //Field offset: 0x2E8
	private RenderTextureFormat m_Format; //Field offset: 0x2F0
	private bool[] m_BufferUsage; //Field offset: 0x2F8
	private RenderTexture m_LastBloomUpsample; //Field offset: 0x300

	private bool IsNightVisionOn
	{
		private get { } //Length: 242
	}

	private static UltimateBloom() { }

	public UltimateBloom() { }

	private void Awake() { }

	private void BlitIntensity(RenderTexture source, RenderTexture destination, float intensity) { }

	private void BrightPass(RenderTexture source, RenderTexture destination, Vector4 treshold, MaterialPropertyBlock props) { }

	private void BrightPassWithMask(RenderTexture source, RenderTexture destination, Vector4 treshold, Texture mask, MaterialPropertyBlock props) { }

	private void CachedDownsample(RenderTexture source, RenderTexture[] destinations, DeluxeFilmicCurve intensityCurve, bool hdr) { }

	private void CachedUpsample(RenderTexture[] sources, RenderTexture[] destinations, int originalWidth, int originalHeight, BlurSampleCount upsamplingCount) { }

	private void CombineAdditive(RenderTexture source, RenderTexture destination, float intensitySource, float intensityDestination) { }

	private void ComputeBufferOptimization() { }

	public void ComputeResolutionRelativeData() { }

	private Material CreateMaterial(Shader shader) { }

	public void CreateMaterials() { }

	private void DestroyMaterial(Material mat) { }

	private void DoBlit(Texture source, RenderTexture destination) { }

	public void ForceShadersReload() { }

	private void GaussianBlur1(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, RenderTexture additiveTexture, BlurSampleCount sampleCount, Color tint, float intensity) { }

	private void GaussianBlur2(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, RenderTexture additiveTexture, BlurSampleCount sampleCount, Color tint, float intensity) { }

	private void GaussianBlurSeparate(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, RenderTexture additiveTexture, BlurSampleCount sampleCount, Color tint, float intensity, MaterialPropertyBlock props) { }

	private bool get_IsNightVisionOn() { }

	private int GetGhostBokehLayer() { }

	private int GetNeededDownsamples() { }

	private MaterialPropertyBlock GetSamplingProp() { }

	private BlurSampleCount GetUpsamplingSize() { }

	private void LoadShader(ref Material material, ref Shader shader, string shaderPath) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture source, RenderTexture destination) { }

	private void RenderFlares(RenderTexture brightTexture, RenderTexture source, ref Texture flareRT) { }

	private void RenderSimple(RenderTexture source, RenderTexture destination, float horizontalBlur, float verticalBlur, SimpleSampleCount sampleCount, MaterialPropertyBlock matBlock) { }

	private RenderTexture RenderStar(RenderTexture[] sources, BlurSampleCount upsamplingCount, int sourceWidth, int sourceHeight) { }

	private RenderTexture RenderStripe(RenderTexture[] sources, BlurSampleCount upsamplingCount, int sourceWidth, int sourceHeight, FlareStripeType type) { }

	private void RenderTextureAdditive(RenderTexture source, RenderTexture destination, float intensity, MaterialPropertyBlock prop) { }

	private void ResetSamplingPropsPool() { }

	public void SetFilmicCurveParameters(float middle, float dark, float bright, float highlights) { }

	private void Start() { }

}

