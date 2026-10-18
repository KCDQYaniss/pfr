//Type is in global namespace

[AddComponentMenu("Colorful/Hue, Saturation, Value")]
[ExecuteInEditMode]
public class CC_HueSaturationValue : CC_Base
{
	private static readonly int _master; //Field offset: 0x0
	private static readonly int _reds; //Field offset: 0x4
	private static readonly int _yellows; //Field offset: 0x8
	private static readonly int _greens; //Field offset: 0xC
	private static readonly int _cyans; //Field offset: 0x10
	private static readonly int _blues; //Field offset: 0x14
	private static readonly int _magentas; //Field offset: 0x18
	[Range(-180, 180)]
	public float masterHue; //Field offset: 0x38
	[Range(-100, 100)]
	public float masterSaturation; //Field offset: 0x3C
	[Range(-100, 100)]
	public float masterValue; //Field offset: 0x40
	[Range(-180, 180)]
	public float redsHue; //Field offset: 0x44
	[Range(-100, 100)]
	public float redsSaturation; //Field offset: 0x48
	[Range(-100, 100)]
	public float redsValue; //Field offset: 0x4C
	[Range(-180, 180)]
	public float yellowsHue; //Field offset: 0x50
	[Range(-100, 100)]
	public float yellowsSaturation; //Field offset: 0x54
	[Range(-100, 100)]
	public float yellowsValue; //Field offset: 0x58
	[Range(-180, 180)]
	public float greensHue; //Field offset: 0x5C
	[Range(-100, 100)]
	public float greensSaturation; //Field offset: 0x60
	[Range(-100, 100)]
	public float greensValue; //Field offset: 0x64
	[Range(-180, 180)]
	public float cyansHue; //Field offset: 0x68
	[Range(-100, 100)]
	public float cyansSaturation; //Field offset: 0x6C
	[Range(-100, 100)]
	public float cyansValue; //Field offset: 0x70
	[Range(-180, 180)]
	public float bluesHue; //Field offset: 0x74
	[Range(-100, 100)]
	public float bluesSaturation; //Field offset: 0x78
	[Range(-100, 100)]
	public float bluesValue; //Field offset: 0x7C
	[Range(-180, 180)]
	public float magentasHue; //Field offset: 0x80
	[Range(-100, 100)]
	public float magentasSaturation; //Field offset: 0x84
	[Range(-100, 100)]
	public float magentasValue; //Field offset: 0x88
	public bool advanced; //Field offset: 0x8C
	public int currentChannel; //Field offset: 0x90

	public float hue
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float saturation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float value
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	private static CC_HueSaturationValue() { }

	public CC_HueSaturationValue() { }

	public float get_hue() { }

	public float get_saturation() { }

	public float get_value() { }

	[ImageEffectTransformsToLDR]
	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_hue(float value) { }

	public void set_saturation(float value) { }

	public void set_value(float value) { }

}

