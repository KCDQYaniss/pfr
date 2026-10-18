namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class ContrastEnhance : PostEffectsBase
{
	public float intensity; //Field offset: 0x30
	public float threshold; //Field offset: 0x34
	private Material separableBlurMaterial; //Field offset: 0x38
	private Material contrastCompositeMaterial; //Field offset: 0x40
	public float blurSpread; //Field offset: 0x48
	public Shader separableBlurShader; //Field offset: 0x50
	public Shader contrastCompositeShader; //Field offset: 0x58

	public ContrastEnhance() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

