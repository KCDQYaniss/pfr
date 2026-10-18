//Type is in global namespace

[AddComponentMenu("Colorful/Negative")]
[ExecuteInEditMode]
public class CC_Negative : CC_Base
{
	private static readonly int _amount; //Field offset: 0x0
	[Range(0, 1)]
	public float amount; //Field offset: 0x38

	private static CC_Negative() { }

	public CC_Negative() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

