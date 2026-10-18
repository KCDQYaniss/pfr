//Type is in global namespace

[AddComponentMenu("Colorful/Technicolor")]
[ExecuteInEditMode]
public class CC_Technicolor : CC_Base
{
	private static readonly int _exposure; //Field offset: 0x0
	private static readonly int _balance; //Field offset: 0x4
	private static readonly int _amount; //Field offset: 0x8
	[Range(0, 8)]
	public float exposure; //Field offset: 0x38
	public Vector3 balance; //Field offset: 0x3C
	[Range(0, 1)]
	public float amount; //Field offset: 0x48

	private static CC_Technicolor() { }

	public CC_Technicolor() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

