namespace EFT.WboitSmoke;

public struct GpuParticle
{
	public uint Id; //Field offset: 0x0
	public float3 WorldPos; //Field offset: 0x4
	public float SpawnTime; //Field offset: 0x10
	public float WboitDist; //Field offset: 0x14
	public float CullingFactor; //Field offset: 0x18
	public float StencilFactor; //Field offset: 0x1C

}

