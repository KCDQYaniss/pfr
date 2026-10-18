namespace EFT.WboitSmoke;

internal sealed class GpuParticleBatchBuilder
{
	private const int JOB_BATCH_SIZE = 64; //Field offset: 0x0
	private readonly Vector3 _origin; //Field offset: 0x10
	private readonly float _voxelSize; //Field offset: 0x1C

	public GpuParticleBatchBuilder(Vector3 origin, float voxelSize) { }

	public IndirectParticleBatch Build(IReadOnlyList source, int fromIndex, int count, float spawnTime, float visualBoundsPadding) { }

	private static void CopyVoxels(IReadOnlyList source, int fromIndex, int count, NativeArray voxels) { }

	private static Bounds ToBounds(ParticleBoundsData boundsData) { }

	private static Vector3 ToVector3(float3 value) { }

}

