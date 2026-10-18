//Type is in global namespace

[AddComponentMenu(null)]
public class HBAO_Core : MonoBehaviour
{
	internal struct AOSettings
	{
		[Range(0, 2)]
		[Space(6)]
		[Tooltip("AO radius: this is the distance outside which occluders are ignored.")]
		public float radius; //Field offset: 0x0
		[Range(64, 512)]
		[Tooltip("Maximum radius in pixels: this prevents the radius to grow too much with close-up object and impact on performances.")]
		public float maxRadiusPixels; //Field offset: 0x4
		[Range(0, 0.5)]
		[Tooltip("For low-tessellated geometry, occlusion variations tend to appear at creases and ridges, which betray the underlying tessellation. To remove these artifacts, we use an angle bias parameter which restricts the hemisphere.")]
		public float bias; //Field offset: 0x8
		[Range(0, 10)]
		[Tooltip("This value allows to scale up the ambient occlusion values.")]
		public float intensity; //Field offset: 0xC
		[Tooltip("Enable/disable MultiBounce approximation.")]
		public bool useMultiBounce; //Field offset: 0x10
		[Range(0, 1)]
		[Tooltip("MultiBounce approximation influence.")]
		public float multiBounceInfluence; //Field offset: 0x14
		[Range(0, 1)]
		[Tooltip("The amount of AO offscreen samples are contributing.")]
		public float offscreenSamplesContribution; //Field offset: 0x18
		[Space(10)]
		[Tooltip("The max distance to display AO.")]
		public float maxDistance; //Field offset: 0x1C
		[Tooltip("The distance before max distance at which AO start to decrease.")]
		public float distanceFalloff; //Field offset: 0x20
		[Space(10)]
		[Tooltip("The type of per pixel normals to use.")]
		public PerPixelNormals perPixelNormals; //Field offset: 0x24
		[Space(10)]
		[Tooltip("This setting allow you to set the base color if the AO, the alpha channel value is unused.")]
		public Color baseColor; //Field offset: 0x28

		[SerializeField]
		public static AOSettings defaultSettings
		{
			 get { } //Length: 78
		}

		public static AOSettings get_defaultSettings() { }

	}

	internal enum Blur
	{
		None = 0,
		Narrow = 1,
		Medium = 2,
		Wide = 3,
		ExtraWide = 4,
	}

	internal struct BlurSettings
	{
		[Space(6)]
		[Tooltip("The type of blur to use.")]
		public Blur amount; //Field offset: 0x0
		[Range(0, 16)]
		[Space(10)]
		[Tooltip("This parameter controls the depth-dependent weight of the bilateral filter, to avoid bleeding across edges. A zero sharpness is a pure Gaussian blur. Increasing the blur sharpness removes bleeding by using lower weights for samples with large depth delta from the current pixel.")]
		public float sharpness; //Field offset: 0x4
		[Tooltip("Is the blur downsampled.")]
		public bool downsample; //Field offset: 0x8

		[SerializeField]
		public static BlurSettings defaultSettings
		{
			 get { } //Length: 23
		}

		public static BlurSettings get_defaultSettings() { }

	}

	internal struct ColorBleedingSettings
	{
		[Space(6)]
		public bool enabled; //Field offset: 0x0
		[Range(0, 4)]
		[Space(10)]
		[Tooltip("This value allows to control the saturation of the color bleeding.")]
		public float saturation; //Field offset: 0x4
		[Range(0, 32)]
		[Tooltip("This value allows to scale the contribution of the color bleeding samples.")]
		public float albedoMultiplier; //Field offset: 0x8
		[Range(0, 1)]
		[Tooltip("Use masking on emissive pixels")]
		public float brightnessMask; //Field offset: 0xC
		[HBAO_MinMaxSlider(0, 8)]
		[Tooltip("Brightness level where masking starts/ends")]
		public Vector2 brightnessMaskRange; //Field offset: 0x10

		[SerializeField]
		public static ColorBleedingSettings defaultSettings
		{
			 get { } //Length: 50
		}

		public static ColorBleedingSettings get_defaultSettings() { }

	}

	internal enum Deinterleaving
	{
		Disabled = 0,
		_2x = 1,
		_4x = 2,
	}

	internal enum DisplayMode
	{
		Normal = 0,
		AOOnly = 1,
		ColorBleedingOnly = 2,
		SplitWithoutAOAndWithAO = 3,
		SplitWithAOAndAOOnly = 4,
		SplitWithoutAOAndAOOnly = 5,
	}

	internal struct GeneralSettings
	{
		[Space(6)]
		[Tooltip("The stage the AO is integrated into the rendering pipeline.")]
		public IntegrationStage integrationStage; //Field offset: 0x0
		[Space(10)]
		[Tooltip("The quality of the AO.")]
		public Quality quality; //Field offset: 0x4
		[Tooltip("The deinterleaving factor.")]
		public Deinterleaving deinterleaving; //Field offset: 0x8
		[Tooltip("The resolution at which the AO is calculated.")]
		public Resolution resolution; //Field offset: 0xC
		[Space(10)]
		[Tooltip("The type of noise to use.")]
		public NoiseType noiseType; //Field offset: 0x10
		[Space(10)]
		[Tooltip("The way the AO is displayed on screen.")]
		public DisplayMode displayMode; //Field offset: 0x14

		[SerializeField]
		public static GeneralSettings defaultSettings
		{
			 get { } //Length: 31
		}

		public static GeneralSettings get_defaultSettings() { }

	}

	internal enum IntegrationStage
	{
		BeforeImageEffectsOpaque = 0,
		AfterLighting = 1,
		BeforeReflections = 2,
	}

	private static class MersenneTwister
	{
		public static float[] Numbers; //Field offset: 0x0

		private static MersenneTwister() { }

	}

	internal enum NoiseType
	{
		Random = 0,
		Dither = 1,
	}

	internal static class Pass
	{
		public const int AO_LowestQuality = 0; //Field offset: 0x0
		public const int Composite = 25; //Field offset: 0x0
		public const int Composite_MultiBounce = 26; //Field offset: 0x0
		public const int Debug_AO_Only = 27; //Field offset: 0x0
		public const int Debug_AO_Only_MultiBounce = 28; //Field offset: 0x0
		public const int Debug_ColorBleeding_Only = 29; //Field offset: 0x0
		public const int Debug_Split_WithoutAO_WithAO = 30; //Field offset: 0x0
		public const int Debug_Split_WithoutAO_WithAO_MultiBounce = 31; //Field offset: 0x0
		public const int Debug_Split_WithAO_AOOnly = 32; //Field offset: 0x0
		public const int Debug_Split_WithAO_AOOnly_MultiBounce = 33; //Field offset: 0x0
		public const int Blur_Y_ExtraWide = 24; //Field offset: 0x0
		public const int Debug_Split_WithoutAO_AOOnly = 34; //Field offset: 0x0
		public const int Combine_Deffered = 36; //Field offset: 0x0
		public const int Combine_Deffered_Multiplicative = 37; //Field offset: 0x0
		public const int Combine_Integrated = 38; //Field offset: 0x0
		public const int Combine_Integrated_MultiBounce = 39; //Field offset: 0x0
		public const int Combine_Integrated_Multiplicative = 40; //Field offset: 0x0
		public const int Combine_Integrated_Multiplicative_MultiBounce = 41; //Field offset: 0x0
		public const int Combine_ColorBleeding = 42; //Field offset: 0x0
		public const int Debug_Split_Additive = 43; //Field offset: 0x0
		public const int Debug_Split_Additive_MultiBounce = 44; //Field offset: 0x0
		public const int Debug_Split_WithoutAO_AOOnly_MultiBounce = 35; //Field offset: 0x0
		public const int Debug_Split_Multiplicative = 45; //Field offset: 0x0
		public const int Blur_Y_Wide = 23; //Field offset: 0x0
		public const int Blur_Y_Narrow = 21; //Field offset: 0x0
		public const int AO_LowQuality = 1; //Field offset: 0x0
		public const int AO_MediumQuality = 2; //Field offset: 0x0
		public const int AO_HighQuality = 3; //Field offset: 0x0
		public const int AO_HighestQuality = 4; //Field offset: 0x0
		public const int AO_Deinterleaved_LowestQuality = 5; //Field offset: 0x0
		public const int AO_Deinterleaved_LowQuality = 6; //Field offset: 0x0
		public const int AO_Deinterleaved_MediumQuality = 7; //Field offset: 0x0
		public const int AO_Deinterleaved_HighQuality = 8; //Field offset: 0x0
		public const int AO_Deinterleaved_HighestQuality = 9; //Field offset: 0x0
		public const int Blur_Y_Medium = 22; //Field offset: 0x0
		public const int Depth_Deinterleaving_2x2 = 10; //Field offset: 0x0
		public const int Normals_Deinterleaving_2x2 = 12; //Field offset: 0x0
		public const int Normals_Deinterleaving_4x4 = 13; //Field offset: 0x0
		public const int Atlas = 14; //Field offset: 0x0
		public const int Reinterleaving_2x2 = 15; //Field offset: 0x0
		public const int Reinterleaving_4x4 = 16; //Field offset: 0x0
		public const int Blur_X_Narrow = 17; //Field offset: 0x0
		public const int Blur_X_Medium = 18; //Field offset: 0x0
		public const int Blur_X_Wide = 19; //Field offset: 0x0
		public const int Blur_X_ExtraWide = 20; //Field offset: 0x0
		public const int Depth_Deinterleaving_4x4 = 11; //Field offset: 0x0
		public const int Debug_Split_Multiplicative_MultiBounce = 46; //Field offset: 0x0

	}

	internal enum PerPixelNormals
	{
		GBuffer = 0,
		Camera = 1,
		Reconstruct = 2,
	}

	internal enum Preset
	{
		FastestPerformance = 0,
		FastPerformance = 1,
		Normal = 2,
		HighQuality = 3,
		HighestQuality = 4,
		ColoredHighestQuality = 5,
		Custom = 6,
	}

	internal struct Presets
	{
		public Preset preset; //Field offset: 0x0

		[SerializeField]
		public static Presets defaultPresets
		{
			 get { } //Length: 6
		}

		public static Presets get_defaultPresets() { }

	}

	internal enum Quality
	{
		Lowest = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Highest = 4,
	}

	internal class RenderTarget
	{
		public bool orthographic; //Field offset: 0x10
		public RenderingPath renderingPath; //Field offset: 0x14
		public bool hdr; //Field offset: 0x18
		public int width; //Field offset: 0x1C
		public int height; //Field offset: 0x20
		public int fullWidth; //Field offset: 0x24
		public int fullHeight; //Field offset: 0x28
		public int layerWidth; //Field offset: 0x2C
		public int layerHeight; //Field offset: 0x30
		public int downsamplingFactor; //Field offset: 0x34
		public int deinterleavingFactor; //Field offset: 0x38
		public int blurDownsamplingFactor; //Field offset: 0x3C

		public RenderTarget() { }

	}

	internal enum Resolution
	{
		Full = 0,
		Half = 1,
		Quarter = 2,
	}

	[AttributeUsage(AttributeTargets::Field (256))]
	internal class SettingsGroup : Attribute
	{

		public SettingsGroup() { }

	}

	internal static class ShaderProperties
	{
		public static int mainTex; //Field offset: 0x0
		public static int hbaoTex; //Field offset: 0x4
		public static int noiseTex; //Field offset: 0x8
		public static int rt0Tex; //Field offset: 0xC
		public static int rt3Tex; //Field offset: 0x10
		public static int depthTex; //Field offset: 0x14
		public static int normalsTex; //Field offset: 0x18
		public static int[] mrtDepthTex; //Field offset: 0x20
		public static int[] mrtNrmTex; //Field offset: 0x28
		public static int[] mrtHBAOTex; //Field offset: 0x30
		public static int[] deinterleavingOffset; //Field offset: 0x38
		public static int layerOffset; //Field offset: 0x40
		public static int jitter; //Field offset: 0x44
		public static int uvToView; //Field offset: 0x48
		public static int worldToCameraMatrix; //Field offset: 0x4C
		public static int fullResTexelSize; //Field offset: 0x50
		public static int layerResTexelSize; //Field offset: 0x54
		public static int targetScale; //Field offset: 0x58
		public static int noiseTexSize; //Field offset: 0x5C
		public static int radius; //Field offset: 0x60
		public static int maxRadiusPixels; //Field offset: 0x64
		public static int negInvRadius2; //Field offset: 0x68
		public static int angleBias; //Field offset: 0x6C
		public static int aoMultiplier; //Field offset: 0x70
		public static int intensity; //Field offset: 0x74
		public static int multiBounceInfluence; //Field offset: 0x78
		public static int offscreenSamplesContrib; //Field offset: 0x7C
		public static int maxDistance; //Field offset: 0x80
		public static int distanceFalloff; //Field offset: 0x84
		public static int baseColor; //Field offset: 0x88
		public static int colorBleedSaturation; //Field offset: 0x8C
		public static int albedoMultiplier; //Field offset: 0x90
		public static int colorBleedBrightnessMask; //Field offset: 0x94
		public static int colorBleedBrightnessMaskRange; //Field offset: 0x98
		public static int blurSharpness; //Field offset: 0x9C

		private static ShaderProperties() { }

	}

	protected const int NUM_MRTS = 4; //Field offset: 0x0
	public Texture2D noiseTex; //Field offset: 0x20
	public Mesh quadMesh; //Field offset: 0x28
	public Shader hbaoShader; //Field offset: 0x30
	[SerializeField]
	[SettingsGroup]
	private Presets m_Presets; //Field offset: 0x38
	[SerializeField]
	[SettingsGroup]
	private GeneralSettings m_GeneralSettings; //Field offset: 0x3C
	[SerializeField]
	[SettingsGroup]
	private AOSettings m_AOSettings; //Field offset: 0x54
	[SerializeField]
	[SettingsGroup]
	private ColorBleedingSettings m_ColorBleedingSettings; //Field offset: 0x8C
	[SerializeField]
	[SettingsGroup]
	private BlurSettings m_BlurSettings; //Field offset: 0xA4
	protected Material _hbaoMaterial; //Field offset: 0xB0
	protected Camera _hbaoCamera; //Field offset: 0xB8
	protected RenderTarget _renderTarget; //Field offset: 0xC0
	protected Vector4[] _jitter; //Field offset: 0xC8
	private Quality _quality; //Field offset: 0xD0
	private NoiseType _noiseType; //Field offset: 0xD4
	private string[] _hbaoShaderKeywords; //Field offset: 0xD8
	private int[] _numSampleDirections; //Field offset: 0xE0
	private int supportedRenderTargetCount; //Field offset: 0xE8

	public AOSettings aoSettings
	{
		 get { } //Length: 40
		 set { } //Length: 37
	}

	public BlurSettings blurSettings
	{
		 get { } //Length: 25
		 set { } //Length: 22
	}

	public ColorBleedingSettings colorBleedingSettings
	{
		 get { } //Length: 27
		 set { } //Length: 24
	}

	public GeneralSettings generalSettings
	{
		 get { } //Length: 21
		 set { } //Length: 18
	}

	public Presets presets
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public HBAO_Core() { }

	public void ApplyPreset(Preset preset) { }

	protected override void CheckParameters() { }

	private void CreateMaterial() { }

	private void CreateRandomTexture(int size) { }

	public AOSettings get_aoSettings() { }

	public BlurSettings get_blurSettings() { }

	public ColorBleedingSettings get_colorBleedingSettings() { }

	public GeneralSettings get_generalSettings() { }

	public Presets get_presets() { }

	protected int GetAoDeinterleavedPass() { }

	protected int GetAoPass() { }

	protected int GetBlurXPass() { }

	protected int GetBlurYPass() { }

	protected int GetDeinterleavingFactor() { }

	protected int GetFinalPass() { }

	protected bool IsDeferredShading() { }

	protected bool IsDeferredShadingOrLighting() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public void set_aoSettings(AOSettings value) { }

	public void set_blurSettings(BlurSettings value) { }

	public void set_colorBleedingSettings(ColorBleedingSettings value) { }

	public void set_generalSettings(GeneralSettings value) { }

	public void set_presets(Presets value) { }

	protected override void Start() { }

	protected void UpdateShaderKeywords() { }

	protected override void UpdateShaderProperties() { }

}

