//Type is in global namespace

[AddComponentMenu("Colorful/Threshold")]
[ExecuteInEditMode]
public class CC_Threshold : CC_Base
{
	private static readonly int _threshold; //Field offset: 0x0
	private static readonly int _range; //Field offset: 0x4
	[Range(1, 255)]
	public float threshold; //Field offset: 0x38
	[Range(0, 128)]
	public float noiseRange; //Field offset: 0x3C
	public bool useNoise; //Field offset: 0x40

	private static CC_Threshold() { }

	public CC_Threshold() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

