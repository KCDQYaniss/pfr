namespace EFT.Weather;

public struct SphericalHarmonicsSettings
{
	public AnimationCurve TopHarmonicIntensity; //Field offset: 0x0
	public AnimationCurve HorizonHarmonicIntensity; //Field offset: 0x8
	public AnimationCurve BounceHarmonicIntensity; //Field offset: 0x10
	public AnimationCurve ForwardHarmonicIntensity; //Field offset: 0x18
	[Space(16)]
	public Gradient ForwardHarmonicMultiplier; //Field offset: 0x20
	public Gradient BackwardHarmonicMultiplier; //Field offset: 0x28
	[Space(16)]
	public Gradient AddTopAmbient; //Field offset: 0x30
	public Gradient AddAmbient; //Field offset: 0x38
	[Space(16)]
	public AnimationCurve AmbientBrightness; //Field offset: 0x40
	public AnimationCurve AmbientSaturation; //Field offset: 0x48
	public AnimationCurve AmbientContrast; //Field offset: 0x50
	public Color CloudinessLightColor; //Field offset: 0x58

	public SHDataInput Evaluate(float t) { }

	public int GetBakingHashCode() { }

}

