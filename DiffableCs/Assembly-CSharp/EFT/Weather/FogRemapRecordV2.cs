namespace EFT.Weather;

public struct FogRemapRecordV2
{
	public float Hour; //Field offset: 0x0
	public float OriginalFogValue; //Field offset: 0x4
	public AnimationCurve NewFogValue; //Field offset: 0x8
	public Gradient ColorMultiplier; //Field offset: 0x10
	public AnimationCurve DensityMultiplier; //Field offset: 0x18
	public AnimationCurve DensityPower; //Field offset: 0x20
	public AnimationCurve DensityBias; //Field offset: 0x28
	public AnimationCurve GreyscaleLerpFactor; //Field offset: 0x30
	public AnimationCurve SlicesDistribution; //Field offset: 0x38
	public AnimationCurve FogSoftParticleScale; //Field offset: 0x40
	public AnimationCurve DensityMultiplierFromTime; //Field offset: 0x48
	public AnimationCurve DensityPowerFromTime; //Field offset: 0x50
	public AnimationCurve DensityBiasFromTime; //Field offset: 0x58
	public AnimationCurve MBOITFogHeighFalloffFactor; //Field offset: 0x60

}

