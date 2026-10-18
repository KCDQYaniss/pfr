//Type is in global namespace

[AddComponentMenu("Colorful/Hue Focus")]
[ExecuteInEditMode]
public class CC_HueFocus : CC_Base
{
	private static readonly int _range; //Field offset: 0x0
	private static readonly int _params; //Field offset: 0x4
	[Range(0, 360)]
	public float hue; //Field offset: 0x38
	[Range(1, 180)]
	public float range; //Field offset: 0x3C
	[Range(0, 1)]
	public float boost; //Field offset: 0x40
	[Range(0, 1)]
	public float amount; //Field offset: 0x44

	private static CC_HueFocus() { }

	public CC_HueFocus() { }

	[ImageEffectTransformsToLDR]
	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

