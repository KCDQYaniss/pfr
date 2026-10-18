//Type is in global namespace

[AddComponentMenu("Colorful/Blend")]
[ExecuteInEditMode]
public class CC_Blend : CC_Base
{
	private static readonly int _overlayTex; //Field offset: 0x0
	private static readonly int _amount; //Field offset: 0x4
	public Texture texture; //Field offset: 0x38
	[Range(0, 1)]
	public float amount; //Field offset: 0x40
	public int mode; //Field offset: 0x44

	private static CC_Blend() { }

	public CC_Blend() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

