namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
internal struct AggregateResultsJob : IJob
{
	private const float ZERO_ENERGY = 0; //Field offset: 0x0
	private const float FULL_ENERGY = 1; //Field offset: 0x0
	[ReadOnly]
	public NativeArray rayResults; //Field offset: 0x0
	[WriteOnly]
	public NativeArray aggregatedResultBuffer; //Field offset: 0x10

	public override void Execute() { }

}

