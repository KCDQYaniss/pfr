//Type is in global namespace

[AddComponentMenu("Colorful/Analog TV")]
[ExecuteInEditMode]
public class CC_AnalogTV : CC_Base
{
	private static readonly int _phase; //Field offset: 0x0
	private static readonly int _noiseIntensity; //Field offset: 0x4
	private static readonly int _scanlinesIntensity; //Field offset: 0x8
	private static readonly int _scanlinesCount; //Field offset: 0xC
	private static readonly int _scanlinesOffset; //Field offset: 0x10
	private static readonly int _distortion; //Field offset: 0x14
	private static readonly int _cubicDistortion; //Field offset: 0x18
	private static readonly int _scale; //Field offset: 0x1C
	public bool autoPhase; //Field offset: 0x38
	public float phase; //Field offset: 0x3C
	public bool grayscale; //Field offset: 0x40
	[Range(0, 1)]
	public float noiseIntensity; //Field offset: 0x44
	[Range(0, 10)]
	public float scanlinesIntensity; //Field offset: 0x48
	[Range(0, 4096)]
	public float scanlinesCount; //Field offset: 0x4C
	public float scanlinesOffset; //Field offset: 0x50
	[Range(-2, 2)]
	public float distortion; //Field offset: 0x54
	[Range(-2, 2)]
	public float cubicDistortion; //Field offset: 0x58
	[Range(0.01, 2)]
	public float scale; //Field offset: 0x5C

	private static CC_AnalogTV() { }

	public CC_AnalogTV() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected override void Update() { }

}

