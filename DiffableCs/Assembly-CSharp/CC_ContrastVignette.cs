//Type is in global namespace

[AddComponentMenu("Colorful/Contrast Vignette")]
[ExecuteInEditMode]
public class CC_ContrastVignette : CC_Base
{
	private static readonly int _data; //Field offset: 0x0
	private static readonly int _coeffs; //Field offset: 0x4
	private static readonly int _center; //Field offset: 0x8
	public Vector2 center; //Field offset: 0x38
	[Range(-100, 100)]
	public float sharpness; //Field offset: 0x40
	[Range(0, 100)]
	public float darkness; //Field offset: 0x44
	[Range(0, 200)]
	public float contrast; //Field offset: 0x48
	[Range(0, 1)]
	public float redCoeff; //Field offset: 0x4C
	[Range(0, 1)]
	public float greenCoeff; //Field offset: 0x50
	[Range(0, 1)]
	public float blueCoeff; //Field offset: 0x54
	[Range(0, 200)]
	public float edge; //Field offset: 0x58

	private static CC_ContrastVignette() { }

	public CC_ContrastVignette() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

