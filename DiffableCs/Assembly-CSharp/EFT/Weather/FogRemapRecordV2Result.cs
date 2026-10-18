namespace EFT.Weather;

public struct FogRemapRecordV2Result
{
	public float Hour; //Field offset: 0x0
	public float OriginalFogValue; //Field offset: 0x4
	public float NewFogValue; //Field offset: 0x8
	public float MBOITFogHeighFalloffFactor; //Field offset: 0xC
	public Color ColorMultiplier; //Field offset: 0x10
	public float DensityMultiplier; //Field offset: 0x20
	public float DensityPower; //Field offset: 0x24
	public float DensityBias; //Field offset: 0x28
	public float GreyscaleLerpFactor; //Field offset: 0x2C
	public float SlicesDistribution; //Field offset: 0x30
	public float FogSoftParticleScale; //Field offset: 0x34

}

