//Type is in global namespace

[AddComponentMenu("Colorful/Levels")]
[ExecuteInEditMode]
public class CC_Levels : CC_Base
{
	private static readonly int _inputMin; //Field offset: 0x0
	private static readonly int _inputMax; //Field offset: 0x4
	private static readonly int _inputGamma; //Field offset: 0x8
	private static readonly int _outputMin; //Field offset: 0xC
	private static readonly int _outputMax; //Field offset: 0x10
	public bool isRGB; //Field offset: 0x38
	public float inputMinL; //Field offset: 0x3C
	public float inputMaxL; //Field offset: 0x40
	public float inputGammaL; //Field offset: 0x44
	public float inputMinR; //Field offset: 0x48
	public float inputMaxR; //Field offset: 0x4C
	public float inputGammaR; //Field offset: 0x50
	public float inputMinG; //Field offset: 0x54
	public float inputMaxG; //Field offset: 0x58
	public float inputGammaG; //Field offset: 0x5C
	public float inputMinB; //Field offset: 0x60
	public float inputMaxB; //Field offset: 0x64
	public float inputGammaB; //Field offset: 0x68
	public float outputMinL; //Field offset: 0x6C
	public float outputMaxL; //Field offset: 0x70
	public float outputMinR; //Field offset: 0x74
	public float outputMaxR; //Field offset: 0x78
	public float outputMinG; //Field offset: 0x7C
	public float outputMaxG; //Field offset: 0x80
	public float outputMinB; //Field offset: 0x84
	public float outputMaxB; //Field offset: 0x88
	public int currentChannel; //Field offset: 0x8C
	public bool logarithmic; //Field offset: 0x90

	public int mode
	{
		 get { } //Length: 9
		 set { } //Length: 27
	}

	private static CC_Levels() { }

	public CC_Levels() { }

	public int get_mode() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void set_mode(int value) { }

}

