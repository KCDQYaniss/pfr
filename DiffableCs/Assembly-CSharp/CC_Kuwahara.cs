//Type is in global namespace

[AddComponentMenu("Colorful/Kuwahara")]
[ExecuteInEditMode]
public class CC_Kuwahara : CC_Base
{
	private static readonly int _texelSize; //Field offset: 0x0
	[Range(1, 4)]
	public int radius; //Field offset: 0x38
	protected Camera m_Camera; //Field offset: 0x40

	private static CC_Kuwahara() { }

	public CC_Kuwahara() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

}

