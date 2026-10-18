namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BloomOptimized : PostEffectsBase
{
	internal enum BlurType
	{
		Standard = 0,
		Sgx = 1,
	}

	internal enum Resolution
	{
		Low = 0,
		High = 1,
	}

	[Range(0, 1.5)]
	public float threshold; //Field offset: 0x30
	[Range(0, 2.5)]
	public float intensity; //Field offset: 0x34
	[Range(0.25, 5.5)]
	public float blurSize; //Field offset: 0x38
	private Resolution resolution; //Field offset: 0x3C
	[Range(1, 4)]
	public int blurIterations; //Field offset: 0x40
	public BlurType blurType; //Field offset: 0x44
	public Shader fastBloomShader; //Field offset: 0x48
	private Material fastBloomMaterial; //Field offset: 0x50
	private bool isSupport; //Field offset: 0x58

	public BloomOptimized() { }

	private void Awake() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

