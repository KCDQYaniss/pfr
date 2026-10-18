//Type is in global namespace

[AddComponentMenu("Colorful/Grayscale")]
[ExecuteInEditMode]
public class CC_Grayscale : CC_Base
{
	private static readonly int _data; //Field offset: 0x0
	[Range(0, 1)]
	public float redLuminance; //Field offset: 0x38
	[Range(0, 1)]
	public float greenLuminance; //Field offset: 0x3C
	[Range(0, 1)]
	public float blueLuminance; //Field offset: 0x40
	[Range(0, 1)]
	public float amount; //Field offset: 0x44

	private static CC_Grayscale() { }

	public CC_Grayscale() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

