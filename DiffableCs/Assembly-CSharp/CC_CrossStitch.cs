//Type is in global namespace

[AddComponentMenu("Colorful/Cross Stitch")]
[ExecuteInEditMode]
public class CC_CrossStitch : CC_Base
{
	private static readonly int _stitchSize; //Field offset: 0x0
	private static readonly int _brightness; //Field offset: 0x4
	private static readonly int _scale; //Field offset: 0x8
	private static readonly int _ratio; //Field offset: 0xC
	[Range(1, 128)]
	public int size; //Field offset: 0x38
	public float brightness; //Field offset: 0x3C
	public bool invert; //Field offset: 0x40
	public bool pixelize; //Field offset: 0x41
	protected Camera m_Camera; //Field offset: 0x48
	protected SSAA m_SSAA; //Field offset: 0x50

	private static CC_CrossStitch() { }

	public CC_CrossStitch() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

}

