namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Displacement/Twirl")]
[ExecuteInEditMode]
public class Twirl : ImageEffectBase
{
	public Vector2 radius; //Field offset: 0x30
	public float angle; //Field offset: 0x38
	public Vector2 center; //Field offset: 0x3C

	public Twirl() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

