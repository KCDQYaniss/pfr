//Type is in global namespace

public class GlitchUtilities
{
	public Shader Shader; //Field offset: 0x10
	public Texture2D DisplacementMap; //Field offset: 0x18
	[Header("Digital Mistake")]
	[Range(0, 1)]
	public float DigitalMistakeIntensity; //Field offset: 0x20
	[Range(0, 1)]
	public float DigitalMistakeFrequency; //Field offset: 0x24
	[Header("Vertical Flip")]
	[Range(0, 1)]
	public float VerticalFlipIntensity; //Field offset: 0x28
	[Range(0, 1)]
	public float VerticalFlipFrequency; //Field offset: 0x2C
	[Header("Color Switch")]
	[Range(0, 1)]
	public float ColorSwitchIntensity; //Field offset: 0x30
	[Range(0, 1)]
	public float ColorSwitchFrequency; //Field offset: 0x34
	[Header("Vertical Jump")]
	[Range(0, 1)]
	public float VerticalJumpCoef; //Field offset: 0x38
	[Range(0, 1)]
	public float VerticalJumpFrequency; //Field offset: 0x3C
	public float VerticalJumpTimeScale; //Field offset: 0x40
	[Header("Scan Line Jitter")]
	[Range(0, 1)]
	public float ScanLineJitterCoef; //Field offset: 0x44
	[Range(0, 1)]
	public float ScanLineJitterFrequency; //Field offset: 0x48
	[Header("Horizontal Shake")]
	[Range(0, 1)]
	public float HorizontalShake; //Field offset: 0x4C
	[Range(0, 1)]
	public float HorizontalShakeFrequency; //Field offset: 0x50
	[Header("Color Drift")]
	[Range(0, 1)]
	public float ColorDriftCoef; //Field offset: 0x54
	[Range(0, 1)]
	public float ColorDriftFrequency; //Field offset: 0x58
	public float MaxColorDrift; //Field offset: 0x5C

	public GlitchUtilities() { }

}

