//Type is in global namespace

[AddComponentMenu("Colorful/Channel Clamper")]
[ExecuteInEditMode]
public class CC_ChannelClamper : CC_Base
{
	private static readonly int _redClamp; //Field offset: 0x0
	private static readonly int _greenClamp; //Field offset: 0x4
	private static readonly int _blueClamp; //Field offset: 0x8
	public Vector2 red; //Field offset: 0x38
	public Vector2 green; //Field offset: 0x40
	public Vector2 blue; //Field offset: 0x48

	private static CC_ChannelClamper() { }

	public CC_ChannelClamper() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

