//Type is in global namespace

[AddComponentMenu("Colorful/RGB Split")]
[ExecuteInEditMode]
public class CC_RGBSplit : CC_Base
{
	private static readonly int _rgbShiftAmount; //Field offset: 0x0
	private static readonly int _rgbShiftAngleCos; //Field offset: 0x4
	private static readonly int _rgbShiftAngleSin; //Field offset: 0x8
	public float amount; //Field offset: 0x38
	public float angle; //Field offset: 0x3C

	private static CC_RGBSplit() { }

	public CC_RGBSplit() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

