namespace EFT.WboitSmoke;

[BurstCompile]
internal struct BuildIndirectParticleBoundsJob : IJob
{
	[ReadOnly]
	public NativeArray Voxels; //Field offset: 0x0
	[WriteOnly]
	public NativeArray Bounds; //Field offset: 0x10
	public float VoxelSize; //Field offset: 0x20
	public float Padding; //Field offset: 0x24

	public override void Execute() { }

}

