namespace EFT.WboitSmoke;

[IsReadOnly]
internal struct ParticleRenderData
{
	public readonly int ParticleCount; //Field offset: 0x0
	public readonly Vector3 Origin; //Field offset: 0x4
	public readonly Bounds Bounds; //Field offset: 0x10

	public ParticleRenderData(int particleCount, Vector3 origin, Bounds bounds) { }

}

