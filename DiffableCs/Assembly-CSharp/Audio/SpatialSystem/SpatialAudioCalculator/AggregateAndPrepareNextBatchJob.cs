namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct AggregateAndPrepareNextBatchJob : IJob
{
	private const float DISTANCE_TOLERANCE = 0.01; //Field offset: 0x0
	private const int INVALID_COMMAND_INDEX = -1; //Field offset: 0x0
	[ReadOnly]
	public NativeArray findShortestResult; //Field offset: 0x0
	[ReadOnly]
	public NativeArray previousStepSphereHits; //Field offset: 0x10
	[ReadOnly]
	public int directSpherecastCommandIndex; //Field offset: 0x20
	[ReadOnly]
	public float3 sourcePosition; //Field offset: 0x24
	[ReadOnly]
	public float3 listenerPosition; //Field offset: 0x30
	[ReadOnly]
	public float MaxDistance; //Field offset: 0x3C
	[ReadOnly]
	public NativeArray rayStates; //Field offset: 0x40
	[ReadOnly]
	public int maxCommandBufferSize; //Field offset: 0x50
	[ReadOnly]
	public float minReflectionEnergyThreshold; //Field offset: 0x54
	[ReadOnly]
	public ShortestPathResultData initialBestOverallResult; //Field offset: 0x58
	[ReadOnly]
	public ShortestPathResultData initialBestReflectedResult; //Field offset: 0xE8
	[ReadOnly]
	public NativeArray scheduledSpherecastCommands; //Field offset: 0x178
	[WriteOnly]
	public NativeArray outputSpherecastCommands; //Field offset: 0x188
	[WriteOnly]
	public NativeArray outputCommandIndicesMap; //Field offset: 0x198
	[WriteOnly]
	public NativeArray outputBatchProcessing; //Field offset: 0x1A8

	public override void Execute() { }

}

