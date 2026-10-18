namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BloomAndFlares : PostEffectsBase
{
	private static readonly int _offsets; //Field offset: 0x0
	private static readonly int _threshold; //Field offset: 0x4
	private static readonly int _tintColor; //Field offset: 0x8
	private static readonly int _stretchWidth; //Field offset: 0xC
	private static readonly int _intensity; //Field offset: 0x10
	private static readonly int _colorBuffer; //Field offset: 0x14
	private static readonly int _colorA; //Field offset: 0x18
	private static readonly int _colorB; //Field offset: 0x1C
	private static readonly int _colorC; //Field offset: 0x20
	private static readonly int _colorD; //Field offset: 0x24
	private static readonly int _threshold1; //Field offset: 0x28
	private static readonly int _useSrcAlphaAsMask; //Field offset: 0x2C
	private static readonly int _vignetteIntensity; //Field offset: 0x30
	public TweakMode34 tweakMode; //Field offset: 0x30
	public BloomScreenBlendMode screenBlendMode; //Field offset: 0x34
	public HDRBloomMode hdr; //Field offset: 0x38
	private bool doHdr; //Field offset: 0x3C
	public float sepBlurSpread; //Field offset: 0x40
	public float useSrcAlphaAsMask; //Field offset: 0x44
	public float bloomIntensity; //Field offset: 0x48
	public float bloomThreshold; //Field offset: 0x4C
	public int bloomBlurIterations; //Field offset: 0x50
	public bool lensflares; //Field offset: 0x54
	public int hollywoodFlareBlurIterations; //Field offset: 0x58
	public LensflareStyle34 lensflareMode; //Field offset: 0x5C
	public float hollyStretchWidth; //Field offset: 0x60
	public float lensflareIntensity; //Field offset: 0x64
	public float lensflareThreshold; //Field offset: 0x68
	public Color flareColorA; //Field offset: 0x6C
	public Color flareColorB; //Field offset: 0x7C
	public Color flareColorC; //Field offset: 0x8C
	public Color flareColorD; //Field offset: 0x9C
	public Texture2D lensFlareVignetteMask; //Field offset: 0xB0
	public Shader lensFlareShader; //Field offset: 0xB8
	private Material lensFlareMaterial; //Field offset: 0xC0
	public Shader vignetteShader; //Field offset: 0xC8
	private Material vignetteMaterial; //Field offset: 0xD0
	public Shader separableBlurShader; //Field offset: 0xD8
	private Material separableBlurMaterial; //Field offset: 0xE0
	public Shader addBrightStuffOneOneShader; //Field offset: 0xE8
	private Material addBrightStuffBlendOneOneMaterial; //Field offset: 0xF0
	public Shader screenBlendShader; //Field offset: 0xF8
	private Material screenBlend; //Field offset: 0x100
	public Shader hollywoodFlaresShader; //Field offset: 0x108
	private Material hollywoodFlaresMaterial; //Field offset: 0x110
	public Shader brightPassFilterShader; //Field offset: 0x118
	private Material brightPassFilterMaterial; //Field offset: 0x120

	private static BloomAndFlares() { }

	public BloomAndFlares() { }

	private void AddTo(float intensity_, RenderTexture from, RenderTexture to) { }

	private void BlendFlares(RenderTexture from, RenderTexture to) { }

	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to) { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Vignette(float amount, RenderTexture from, RenderTexture to) { }

}

