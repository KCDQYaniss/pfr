namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
internal struct ProcessAndAggregateJob : IJob
{
	[ReadOnly]
	public NativeArray listenerToSourceHits; //Field offset: 0x0
	[ReadOnly]
	public NativeArray sourceToListenerHits; //Field offset: 0x10
	[ReadOnly]
	public NativeArray rayStartPoints; //Field offset: 0x20
	[ReadOnly]
	public float3 ListenerPosition; //Field offset: 0x30
	[ReadOnly]
	public float3 sourcePosition; //Field offset: 0x3C
	[ReadOnly]
	public float absorptionPerUnit; //Field offset: 0x48
	[ReadOnly]
	public float minEnergyThreshold; //Field offset: 0x4C
	[ReadOnly]
	public float minThicknessThreshold; //Field offset: 0x50
	[ReadOnly]
	public float maxThicknessThreshold; //Field offset: 0x54
	[ReadOnly]
	public float maxDistance; //Field offset: 0x58
	[ReadOnly]
	public int totalRayCount; //Field offset: 0x5C
	[WriteOnly]
	public NativeArray aggregatedResultBuffer; //Field offset: 0x60

	public override void Execute() { }

}

