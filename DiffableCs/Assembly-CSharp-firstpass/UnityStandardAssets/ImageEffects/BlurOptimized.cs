namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BlurOptimized : PostEffectsBase
{
	internal enum BlurType
	{
		StandardGauss = 0,
		SgxGauss = 1,
	}

	private static readonly int _parameter; //Field offset: 0x0
	[Range(0, 2)]
	public int downsample; //Field offset: 0x30
	[Range(0, 10)]
	public float blurSize; //Field offset: 0x34
	[Range(1, 4)]
	public int blurIterations; //Field offset: 0x38
	public BlurType blurType; //Field offset: 0x3C
	public Shader blurShader; //Field offset: 0x40
	private Material blurMaterial; //Field offset: 0x48

	private static BlurOptimized() { }

	public BlurOptimized() { }

	public virtual bool CheckResources() { }

	public Material GetBlurMaterial() { }

	public void Modify(ref RenderTexture source, ref RenderTexture myTex) { }

	public void OnDisable() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

