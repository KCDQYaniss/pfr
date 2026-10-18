//Type is in global namespace

[AddComponentMenu("Colorful/Convolution Matrix 3x3")]
[ExecuteInEditMode]
public class CC_Convolution3x3 : CC_Base
{
	private static readonly int _px; //Field offset: 0x0
	private static readonly int _py; //Field offset: 0x4
	private static readonly int _amount; //Field offset: 0x8
	private static readonly int _kernelT; //Field offset: 0xC
	private static readonly int _kernelM; //Field offset: 0x10
	private static readonly int _kernelB; //Field offset: 0x14
	public Vector3 kernelTop; //Field offset: 0x38
	public Vector3 kernelMiddle; //Field offset: 0x44
	public Vector3 kernelBottom; //Field offset: 0x50
	public float divisor; //Field offset: 0x5C
	[Range(0, 1)]
	public float amount; //Field offset: 0x60

	private static CC_Convolution3x3() { }

	public CC_Convolution3x3() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

