//Type is in global namespace

[AddComponentMenu("Colorful/Bleach Bypass")]
[ExecuteInEditMode]
public class CC_BleachBypass : CC_Base
{
	private static readonly int _amount; //Field offset: 0x0
	[Range(0, 1)]
	public float amount; //Field offset: 0x38

	private static CC_BleachBypass() { }

	public CC_BleachBypass() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected override void OnRenderImageImpl(RenderTexture source, RenderTexture destination) { }

}

