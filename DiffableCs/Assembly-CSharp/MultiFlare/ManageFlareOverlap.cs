namespace MultiFlare;

[BurstCompile]
public struct ManageFlareOverlap : IJob
{
	private readonly int _maxNeighborCount; //Field offset: 0x0
	private readonly float _searchRange; //Field offset: 0x4
	private readonly float _maxScaleMultiplier; //Field offset: 0x8
	private NativeArray _data; //Field offset: 0x10

	public ManageFlareOverlap(NativeArray data, FlareOverlapSettings overlapSettings) { }

	public override void Execute() { }

	private float GetNeighborCount(int index) { }

}

