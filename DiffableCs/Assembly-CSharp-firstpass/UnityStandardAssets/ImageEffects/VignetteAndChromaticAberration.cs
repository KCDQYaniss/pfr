namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	internal enum AberrationMode
	{
		Simple = 0,
		Advanced = 1,
	}

	public AberrationMode mode; //Field offset: 0x30
	public float intensity; //Field offset: 0x34
	public float chromaticAberration; //Field offset: 0x38
	public float axialAberration; //Field offset: 0x3C
	public float blur; //Field offset: 0x40
	public float blurSpread; //Field offset: 0x44
	public float luminanceDependency; //Field offset: 0x48
	public float blurDistance; //Field offset: 0x4C
	public Shader vignetteShader; //Field offset: 0x50
	public Shader separableBlurShader; //Field offset: 0x58
	public Shader chromAberrationShader; //Field offset: 0x60
	private Material m_VignetteMaterial; //Field offset: 0x68
	private Material m_SeparableBlurMaterial; //Field offset: 0x70
	private Material m_ChromAberrationMaterial; //Field offset: 0x78

	public VignetteAndChromaticAberration() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

