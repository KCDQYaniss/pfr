//Type is in global namespace

[AddComponentMenu("Colorful/Vibrance")]
[ExecuteInEditMode]
public class CC_Vibrance : CC_Base
{
	private static readonly int _amount; //Field offset: 0x0
	private static readonly int _channels; //Field offset: 0x4
	[Range(-100, 100)]
	public float amount; //Field offset: 0x38
	[Range(-5, 5)]
	public float redChannel; //Field offset: 0x3C
	[Range(-5, 5)]
	public float greenChannel; //Field offset: 0x40
	[Range(-5, 5)]
	public float blueChannel; //Field offset: 0x44
	public bool advanced; //Field offset: 0x48

	private static CC_Vibrance() { }

	public CC_Vibrance() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

