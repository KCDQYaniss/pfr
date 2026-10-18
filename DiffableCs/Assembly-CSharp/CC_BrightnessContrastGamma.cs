//Type is in global namespace

[AddComponentMenu("Colorful/Brightness, Contrast, Gamma")]
[ExecuteInEditMode]
public class CC_BrightnessContrastGamma : CC_Base
{
	private static readonly int _bcg; //Field offset: 0x0
	private static readonly int _coeffs; //Field offset: 0x4
	[Range(-100, 100)]
	public float brightness; //Field offset: 0x38
	[Range(-100, 100)]
	public float contrast; //Field offset: 0x3C
	[Range(0, 1)]
	public float redCoeff; //Field offset: 0x40
	[Range(0, 1)]
	public float greenCoeff; //Field offset: 0x44
	[Range(0, 1)]
	public float blueCoeff; //Field offset: 0x48
	[Range(0.1, 9.9)]
	public float gamma; //Field offset: 0x4C

	private static CC_BrightnessContrastGamma() { }

	public CC_BrightnessContrastGamma() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected override void OnRenderImageImpl(RenderTexture source, RenderTexture destination) { }

}

