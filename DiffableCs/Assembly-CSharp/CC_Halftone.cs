//Type is in global namespace

[AddComponentMenu("Colorful/Halftone")]
[ExecuteInEditMode]
public class CC_Halftone : CC_Base
{
	private static readonly int _density; //Field offset: 0x0
	private static readonly int _aspectRatio; //Field offset: 0x4
	[Range(0, 512)]
	public float density; //Field offset: 0x38
	public int mode; //Field offset: 0x3C
	public bool antialiasing; //Field offset: 0x40
	public bool showOriginal; //Field offset: 0x41
	protected Camera m_Camera; //Field offset: 0x48

	private static CC_Halftone() { }

	public CC_Halftone() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

}

