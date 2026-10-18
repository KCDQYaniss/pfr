//Type is in global namespace

[AddComponentMenu("Colorful/Posterize")]
[ExecuteInEditMode]
public class CC_Posterize : CC_Base
{
	private static readonly int _levels; //Field offset: 0x0
	[Range(2, 255)]
	public int levels; //Field offset: 0x38

	private static CC_Posterize() { }

	public CC_Posterize() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

