//Type is in global namespace

[AddComponentMenu("Image Effects/Screen")]
[ExecuteInEditMode]
public class ScreenEffect : ImageEffectBase
{
	private static readonly int _rampTex; //Field offset: 0x0
	private static readonly int _desat; //Field offset: 0x4
	private static readonly int _rampOffset; //Field offset: 0x8
	public float desaturateAmount; //Field offset: 0x38
	public Texture textureRamp; //Field offset: 0x40
	public float rampOffsetR; //Field offset: 0x48
	public float rampOffsetG; //Field offset: 0x4C
	public float rampOffsetB; //Field offset: 0x50

	private static ScreenEffect() { }

	public ScreenEffect() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

