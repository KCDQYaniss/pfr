namespace EFT.Weather;

[IsReadOnly]
public struct SHDataInput
{
	public readonly float Time; //Field offset: 0x0
	public readonly Color ForwardHarmonicMultiplier; //Field offset: 0x4
	public readonly float ForwardHarmonicIntensity; //Field offset: 0x14
	public readonly Color BackwardHarmonicMultiplier; //Field offset: 0x18
	public readonly float TopHarmonicIntensity; //Field offset: 0x28
	public readonly float HorizonHarmonicIntensity; //Field offset: 0x2C
	public readonly float AmbientContrast; //Field offset: 0x30
	public readonly float AmbientSaturation; //Field offset: 0x34
	public readonly float AmbientBrightness; //Field offset: 0x38
	public readonly float BounceHarmonicIntensity; //Field offset: 0x3C
	public readonly Color AddAmbient; //Field offset: 0x40
	public readonly Color CloudinessLightColor; //Field offset: 0x50
	public readonly Color AddTopAmbient; //Field offset: 0x60

	public SHDataInput(float time, Color forwardHarmonicMultiplier, float forwardHarmonicIntensity, Color backwardHarmonicMultiplier, float topHarmonicIntensity, float horizonHarmonicIntensity, float ambientContrast, float ambientSaturation, float ambientBrightness, float bounceHarmonicIntensity, Color addAmbient, Color cloudinessLightColor, Color addTopAmbient) { }

}

