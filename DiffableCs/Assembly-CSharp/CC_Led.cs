//Type is in global namespace

[AddComponentMenu("Colorful/LED")]
[ExecuteInEditMode]
public class CC_Led : CC_Base
{
	private static readonly int _scale; //Field offset: 0x0
	private static readonly int _ratio; //Field offset: 0x4
	private static readonly int _brightness; //Field offset: 0x8
	[Range(1, 255)]
	public float scale; //Field offset: 0x38
	[Range(0, 10)]
	public float brightness; //Field offset: 0x3C
	public bool automaticRatio; //Field offset: 0x40
	public float ratio; //Field offset: 0x44
	public int mode; //Field offset: 0x48
	protected Camera m_Camera; //Field offset: 0x50

	private static CC_Led() { }

	public CC_Led() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

}

