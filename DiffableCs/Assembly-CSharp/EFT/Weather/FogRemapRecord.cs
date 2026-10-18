namespace EFT.Weather;

public struct FogRemapRecord
{
	public float Hour; //Field offset: 0x0
	public float OriginalFogValue; //Field offset: 0x4
	public float NewFogValue; //Field offset: 0x8
	public Color ColorMultiplier; //Field offset: 0xC
	public float DensityMultiplier; //Field offset: 0x1C
	public float DensityPower; //Field offset: 0x20
	public float DensityBias; //Field offset: 0x24
	public float GreyscaleLerpFactor; //Field offset: 0x28
	public float SlicesDistribution; //Field offset: 0x2C
	public float FogSoftParticleScale; //Field offset: 0x30

}

