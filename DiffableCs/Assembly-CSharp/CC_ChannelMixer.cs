//Type is in global namespace

[AddComponentMenu("Colorful/Channel Mixer")]
[ExecuteInEditMode]
public class CC_ChannelMixer : CC_Base
{
	private static readonly int _red; //Field offset: 0x0
	private static readonly int _green; //Field offset: 0x4
	private static readonly int _blue; //Field offset: 0x8
	private static readonly int _constant; //Field offset: 0xC
	[Range(-200, 200)]
	public float redR; //Field offset: 0x38
	[Range(-200, 200)]
	public float redG; //Field offset: 0x3C
	[Range(-200, 200)]
	public float redB; //Field offset: 0x40
	[Range(-200, 200)]
	public float greenR; //Field offset: 0x44
	[Range(-200, 200)]
	public float greenG; //Field offset: 0x48
	[Range(-200, 200)]
	public float greenB; //Field offset: 0x4C
	[Range(-200, 200)]
	public float blueR; //Field offset: 0x50
	[Range(-200, 200)]
	public float blueG; //Field offset: 0x54
	[Range(-200, 200)]
	public float blueB; //Field offset: 0x58
	[Range(-200, 200)]
	public float constantR; //Field offset: 0x5C
	[Range(-200, 200)]
	public float constantG; //Field offset: 0x60
	[Range(-200, 200)]
	public float constantB; //Field offset: 0x64
	public int currentChannel; //Field offset: 0x68

	private static CC_ChannelMixer() { }

	public CC_ChannelMixer() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

