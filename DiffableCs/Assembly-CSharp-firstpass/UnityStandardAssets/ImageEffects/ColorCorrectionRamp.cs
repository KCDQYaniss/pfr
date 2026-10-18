namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
[ExecuteInEditMode]
public class ColorCorrectionRamp : ImageEffectBase
{
	public Texture textureRamp; //Field offset: 0x30

	public ColorCorrectionRamp() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

