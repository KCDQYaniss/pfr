namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Bloom : PostEffectsBase
{
	internal enum BloomQuality
	{
		Cheap = 0,
		High = 1,
	}

	internal enum BloomScreenBlendMode
	{
		Screen = 0,
		Add = 1,
	}

	internal enum HDRBloomMode
	{
		Auto = 0,
		On = 1,
		Off = 2,
	}

	internal enum LensFlareStyle
	{
		Ghosting = 0,
		Anamorphic = 1,
		Combined = 2,
	}

	internal enum TweakMode
	{
		Basic = 0,
		Complex = 1,
	}

	public TweakMode tweakMode; //Field offset: 0x30
	public BloomScreenBlendMode screenBlendMode; //Field offset: 0x34
	public HDRBloomMode hdr; //Field offset: 0x38
	private bool doHdr; //Field offset: 0x3C
	public float sepBlurSpread; //Field offset: 0x40
	public BloomQuality quality; //Field offset: 0x44
	public float bloomIntensity; //Field offset: 0x48
	public float bloomThreshold; //Field offset: 0x4C
	public Color bloomThresholdColor; //Field offset: 0x50
	public int bloomBlurIterations; //Field offset: 0x60
	public int hollywoodFlareBlurIterations; //Field offset: 0x64
	public float flareRotation; //Field offset: 0x68
	public LensFlareStyle lensflareMode; //Field offset: 0x6C
	public float hollyStretchWidth; //Field offset: 0x70
	public float lensflareIntensity; //Field offset: 0x74
	public float lensflareThreshold; //Field offset: 0x78
	public float lensFlareSaturation; //Field offset: 0x7C
	public Color flareColorA; //Field offset: 0x80
	public Color flareColorB; //Field offset: 0x90
	public Color flareColorC; //Field offset: 0xA0
	public Color flareColorD; //Field offset: 0xB0
	public Texture2D lensFlareVignetteMask; //Field offset: 0xC0
	public Shader lensFlareShader; //Field offset: 0xC8
	private Material lensFlareMaterial; //Field offset: 0xD0
	public Shader screenBlendShader; //Field offset: 0xD8
	private Material screenBlend; //Field offset: 0xE0
	public Shader blurAndFlaresShader; //Field offset: 0xE8
	private Material blurAndFlaresMaterial; //Field offset: 0xF0
	public Shader brightPassFilterShader; //Field offset: 0xF8
	private Material brightPassFilterMaterial; //Field offset: 0x100

	public Bloom() { }

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) { }

	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) { }

	public virtual bool CheckResources() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageImpl(RenderTexture source, RenderTexture destination) { }

	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

}

