//Type is in global namespace

[AddComponentMenu("Colorful/Radial Blur")]
[ExecuteInEditMode]
public class CC_RadialBlur : CC_Base
{
	private static readonly int _amount; //Field offset: 0x0
	private static readonly int _center; //Field offset: 0x4
	private static readonly int _samples; //Field offset: 0x8
	[Range(0, 1)]
	public float amount; //Field offset: 0x38
	[Range(2, 24)]
	public int samples; //Field offset: 0x3C
	public Vector2 center; //Field offset: 0x40
	public int quality; //Field offset: 0x48

	private static CC_RadialBlur() { }

	public CC_RadialBlur() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

