//Type is in global namespace

[AddComponentMenu("Colorful/Pixelate")]
[ExecuteInEditMode]
public class CC_Pixelate : CC_Base
{
	private static readonly int _scale; //Field offset: 0x0
	private static readonly int _ratio; //Field offset: 0x4
	[Range(1, 1024)]
	public float scale; //Field offset: 0x38
	public bool automaticRatio; //Field offset: 0x3C
	public float ratio; //Field offset: 0x40
	public int mode; //Field offset: 0x44
	protected Camera m_Camera; //Field offset: 0x48

	private static CC_Pixelate() { }

	public CC_Pixelate() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

}

