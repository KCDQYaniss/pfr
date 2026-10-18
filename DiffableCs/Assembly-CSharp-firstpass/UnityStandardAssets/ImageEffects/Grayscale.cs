namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
[ExecuteInEditMode]
public class Grayscale : ImageEffectBase
{
	private static readonly int _rampTex; //Field offset: 0x0
	private static readonly int _rampOffset; //Field offset: 0x4
	public Texture textureRamp; //Field offset: 0x30
	public float rampOffset; //Field offset: 0x38

	private static Grayscale() { }

	public Grayscale() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

