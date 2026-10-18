namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Other/Screen Overlay")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ScreenOverlay : PostEffectsBase
{
	internal enum OverlayBlendMode
	{
		Additive = 0,
		ScreenBlend = 1,
		Multiply = 2,
		Overlay = 3,
		AlphaBlend = 4,
	}

	private static readonly int _uvTransform; //Field offset: 0x0
	private static readonly int _intensity; //Field offset: 0x4
	private static readonly int _overlay; //Field offset: 0x8
	public OverlayBlendMode blendMode; //Field offset: 0x30
	public float intensity; //Field offset: 0x34
	public Texture2D texture; //Field offset: 0x38
	public Shader overlayShader; //Field offset: 0x40
	private Material overlayMaterial; //Field offset: 0x48

	private static ScreenOverlay() { }

	public ScreenOverlay() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

