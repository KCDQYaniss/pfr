namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct FindAndAggregateNextBatchJob : IJob
{
	[ReadOnly]
	public NativeArray rayMinPathLengths; //Field offset: 0x0
	[ReadOnly]
	public NativeArray rayEnergies; //Field offset: 0x10
	[ReadOnly]
	public NativeList rayPathPointInfos; //Field offset: 0x20
	[ReadOnly]
	public NativeArray rayEndStatuses; //Field offset: 0x28
	[ReadOnly]
	public ShortestPathResultData initialBestOverallResult; //Field offset: 0x38
	[ReadOnly]
	public ShortestPathResultData initialBestReflectedResult; //Field offset: 0xC8
	[ReadOnly]
	public NativeArray previousStepSphereHits; //Field offset: 0x158
	[ReadOnly]
	public int directSpherecastCommandIndex; //Field offset: 0x168
	[ReadOnly]
	public float3 sourcePosition; //Field offset: 0x16C
	[ReadOnly]
	public float3 listenerPosition; //Field offset: 0x178
	[ReadOnly]
	public float minReflectionEnergyThreshold; //Field offset: 0x184
	[ReadOnly]
	public NativeArray scheduledSpherecastCommands; //Field offset: 0x188
	[ReadOnly]
	public NativeArray rayStates; //Field offset: 0x198
	[ReadOnly]
	public int maxCommandBufferSize; //Field offset: 0x1A8
	[WriteOnly]
	public NativeArray outputSpherecastCommands; //Field offset: 0x1B0
	[WriteOnly]
	public NativeArray outputCommandIndicesMap; //Field offset: 0x1C0
	[WriteOnly]
	public NativeArray outputBatchProcessing; //Field offset: 0x1D0

	public override void Execute() { }

}

