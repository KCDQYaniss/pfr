namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class CreaseShading : PostEffectsBase
{
	public float intensity; //Field offset: 0x30
	public int softness; //Field offset: 0x34
	public float spread; //Field offset: 0x38
	public Shader blurShader; //Field offset: 0x40
	private Material blurMaterial; //Field offset: 0x48
	public Shader depthFetchShader; //Field offset: 0x50
	private Material depthFetchMaterial; //Field offset: 0x58
	public Shader creaseApplyShader; //Field offset: 0x60
	private Material creaseApplyMaterial; //Field offset: 0x68

	public CreaseShading() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

