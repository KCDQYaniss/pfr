//Type is in global namespace

[AddComponentMenu("Colorful/Lookup Filter (Color Grading)")]
[ExecuteInEditMode]
public class CC_LookupFilter : CC_Base
{
	private static readonly int _lookupTex; //Field offset: 0x0
	private static readonly int _amount; //Field offset: 0x4
	public Texture lookupTexture; //Field offset: 0x38
	[Range(0, 1)]
	public float amount; //Field offset: 0x40

	private static CC_LookupFilter() { }

	public CC_LookupFilter() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

