namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Displacement/Fisheye")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Fisheye : PostEffectsBase
{
	public float strengthX; //Field offset: 0x30
	public float strengthY; //Field offset: 0x34
	public Shader fishEyeShader; //Field offset: 0x38
	private Material fisheyeMaterial; //Field offset: 0x40

	public Fisheye() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

