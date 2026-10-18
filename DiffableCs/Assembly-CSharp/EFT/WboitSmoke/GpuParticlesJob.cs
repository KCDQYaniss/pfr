namespace EFT.WboitSmoke;

[BurstCompile]
internal struct GpuParticlesJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray Voxels; //Field offset: 0x0
	[WriteOnly]
	public NativeArray Particles; //Field offset: 0x10
	public float3 Origin; //Field offset: 0x20
	public float VoxelSize; //Field offset: 0x2C
	public float SpawnTime; //Field offset: 0x30

	public override void Execute(int index) { }

	private static uint HashWorldPosition(float3 pos) { }

}

