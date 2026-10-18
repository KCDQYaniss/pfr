//Type is in global namespace

[AddComponentMenu("Colorful/Photo Filter")]
[ExecuteInEditMode]
public class CC_PhotoFilter : CC_Base
{
	private static readonly int _rgb; //Field offset: 0x0
	private static readonly int _density; //Field offset: 0x4
	public Color color; //Field offset: 0x38
	[Range(0, 1)]
	public float density; //Field offset: 0x48

	private static CC_PhotoFilter() { }

	public CC_PhotoFilter() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

