//Type is in global namespace

[AddComponentMenu("Colorful/Double Vision")]
[ExecuteInEditMode]
public class CC_DoubleVision : CC_Base
{
	private static readonly int _displace; //Field offset: 0x0
	private static readonly int _amount; //Field offset: 0x4
	public Vector2 displace; //Field offset: 0x38
	[Range(0, 1)]
	public float amount; //Field offset: 0x40

	private static CC_DoubleVision() { }

	public CC_DoubleVision() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

