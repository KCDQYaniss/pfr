namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Displacement/Vortex")]
[ExecuteInEditMode]
public class Vortex : ImageEffectBase
{
	public Vector2 radius; //Field offset: 0x30
	public float angle; //Field offset: 0x38
	public Vector2 center; //Field offset: 0x3C

	public Vortex() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

