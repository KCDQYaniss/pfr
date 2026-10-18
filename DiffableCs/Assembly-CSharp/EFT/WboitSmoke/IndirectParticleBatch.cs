namespace EFT.WboitSmoke;

internal struct IndirectParticleBatch : IDisposable
{
	public readonly NativeArray Voxels; //Field offset: 0x0
	public readonly NativeArray Particles; //Field offset: 0x10
	public readonly Bounds LocalBounds; //Field offset: 0x20
	public readonly int Count; //Field offset: 0x38

	public IndirectParticleBatch(NativeArray voxels, NativeArray particles, Bounds localBounds, int count) { }

	public override void Dispose() { }

}

