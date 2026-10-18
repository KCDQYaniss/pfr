//Type is in global namespace

[AddComponentMenu("Colorful/White Balance")]
[ExecuteInEditMode]
public class CC_WhiteBalance : CC_Base
{
	private static readonly int _white; //Field offset: 0x0
	public Color white; //Field offset: 0x38
	public int mode; //Field offset: 0x48

	private static CC_WhiteBalance() { }

	public CC_WhiteBalance() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected override void Reset() { }

}

