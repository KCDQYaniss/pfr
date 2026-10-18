//Type is in global namespace

[AddComponentMenu("Colorful/Fast Vignette")]
[ExecuteInEditMode]
public class CC_FastVignette : CC_Base
{
	private static readonly int _data; //Field offset: 0x0
	public Vector2 center; //Field offset: 0x38
	[Range(-100, 100)]
	public float sharpness; //Field offset: 0x40
	[Range(0, 100)]
	public float darkness; //Field offset: 0x44
	public bool desaturate; //Field offset: 0x48

	private static CC_FastVignette() { }

	public CC_FastVignette() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

