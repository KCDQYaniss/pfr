namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	[Flags]
	internal enum BokehDestination
	{
		Background = 1,
		Foreground = 2,
		BackgroundAndForeground = 3,
	}

	internal enum Dof34QualitySetting
	{
		OnlyBackground = 1,
		BackgroundAndForeground = 2,
	}

	internal enum DofBlurriness
	{
		Low = 1,
		High = 2,
		VeryHigh = 4,
	}

	internal enum DofResolution
	{
		High = 2,
		Medium = 3,
		Low = 4,
	}

	private static int SMOOTH_DOWNSAMPLE_PASS; //Field offset: 0x0
	private static float BOKEH_EXTRA_BLUR; //Field offset: 0x4
	public Dof34QualitySetting quality; //Field offset: 0x30
	public DofResolution resolution; //Field offset: 0x34
	public bool simpleTweakMode; //Field offset: 0x38
	public float focalPoint; //Field offset: 0x3C
	public float smoothness; //Field offset: 0x40
	public float focalZDistance; //Field offset: 0x44
	public float focalZStartCurve; //Field offset: 0x48
	public float focalZEndCurve; //Field offset: 0x4C
	private float focalStartCurve; //Field offset: 0x50
	private float focalEndCurve; //Field offset: 0x54
	private float focalDistance01; //Field offset: 0x58
	public Transform objectFocus; //Field offset: 0x60
	public float focalSize; //Field offset: 0x68
	public DofBlurriness bluriness; //Field offset: 0x6C
	public float maxBlurSpread; //Field offset: 0x70
	public float foregroundBlurExtrude; //Field offset: 0x74
	public Shader dofBlurShader; //Field offset: 0x78
	private Material dofBlurMaterial; //Field offset: 0x80
	public Shader dofShader; //Field offset: 0x88
	private Material dofMaterial; //Field offset: 0x90
	public bool visualize; //Field offset: 0x98
	public BokehDestination bokehDestination; //Field offset: 0x9C
	private float widthOverHeight; //Field offset: 0xA0
	private float oneOverBaseSize; //Field offset: 0xA4
	public bool bokeh; //Field offset: 0xA8
	public bool bokehSupport; //Field offset: 0xA9
	public Shader bokehShader; //Field offset: 0xB0
	public Texture2D bokehTexture; //Field offset: 0xB8
	public float bokehScale; //Field offset: 0xC0
	public float bokehIntensity; //Field offset: 0xC4
	public float bokehThresholdContrast; //Field offset: 0xC8
	public float bokehThresholdLuminance; //Field offset: 0xCC
	public int bokehDownsample; //Field offset: 0xD0
	private Material bokehMaterial; //Field offset: 0xD8
	private Camera _camera; //Field offset: 0xE0
	private RenderTexture foregroundTexture; //Field offset: 0xE8
	private RenderTexture mediumRezWorkTexture; //Field offset: 0xF0
	private RenderTexture finalDefocus; //Field offset: 0xF8
	private RenderTexture lowRezWorkTexture; //Field offset: 0x100
	private RenderTexture bokehSource; //Field offset: 0x108
	private RenderTexture bokehSource2; //Field offset: 0x110

	private static DepthOfFieldDeprecated() { }

	public DepthOfFieldDeprecated() { }

	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) { }

	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) { }

	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) { }

	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) { }

	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) { }

	public virtual bool CheckResources() { }

	private void CreateMaterials() { }

	private void Downsample(RenderTexture from, RenderTexture to) { }

	private float FocalDistance01(float worldDist) { }

	private int GetDividerBasedOnQuality() { }

	private int GetLowResolutionDividerBasedOnQuality(int baseDivider) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void ReleaseTextures() { }

}

