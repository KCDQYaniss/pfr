//Type is in global namespace

[AddComponentMenu("Colorful/Frost")]
[ExecuteInEditMode]
public class CC_Frost : CC_Base
{
	private static readonly int _scale; //Field offset: 0x0
	private static readonly int _sharpness; //Field offset: 0x4
	private static readonly int _darkness; //Field offset: 0x8
	[Range(0, 16)]
	public float scale; //Field offset: 0x38
	[Range(-100, 100)]
	public float sharpness; //Field offset: 0x3C
	[Range(0, 100)]
	public float darkness; //Field offset: 0x40
	public bool enableVignette; //Field offset: 0x44

	private static CC_Frost() { }

	public CC_Frost() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

