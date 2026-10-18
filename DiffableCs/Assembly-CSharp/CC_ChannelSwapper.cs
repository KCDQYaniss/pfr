//Type is in global namespace

[AddComponentMenu("Colorful/Channel Swapper")]
[ExecuteInEditMode]
public class CC_ChannelSwapper : CC_Base
{
	private static Vector4[] m_Channels; //Field offset: 0x0
	private static readonly int _red; //Field offset: 0x8
	private static readonly int _green; //Field offset: 0xC
	private static readonly int _blue; //Field offset: 0x10
	public int red; //Field offset: 0x38
	public int green; //Field offset: 0x3C
	public int blue; //Field offset: 0x40

	private static CC_ChannelSwapper() { }

	public CC_ChannelSwapper() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

