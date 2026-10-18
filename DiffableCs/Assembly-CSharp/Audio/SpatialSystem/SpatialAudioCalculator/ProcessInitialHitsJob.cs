namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct ProcessInitialHitsJob : IJob
{
	private const int HIT_INDEX_SOURCE_TO_LISTENER = 0; //Field offset: 0x0
	private const int HIT_INDEX_LISTENER_TO_SOURCE = 1; //Field offset: 0x0
	private const int RESULT_INDEX = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeArray hits; //Field offset: 0x0
	[ReadOnly]
	public float3 sourceToListenerDirection; //Field offset: 0x10
	[ReadOnly]
	public float3 listenerToSourceDirection; //Field offset: 0x1C
	[ReadOnly]
	public float directDistance; //Field offset: 0x28
	[WriteOnly]
	public NativeArray checkResult; //Field offset: 0x30

	public override void Execute() { }

}

