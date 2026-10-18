namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct ProcessReflectionHitsJob : IJobParallelFor
{
	private const float MIN_HIT_DISTANCE_THRESHOLD = 0.0001; //Field offset: 0x0
	private const float MIN_DIRECTION_SQRMAGNITUDE = 0.0001; //Field offset: 0x0
	private const float MIN_DOT_PRODUCT_THRESHOLD = 0.001; //Field offset: 0x0
	private const float MIN_CONTINUATION_ENERGY_FACTOR = 0.1; //Field offset: 0x0
	private const int INVALID_COMMAND_INDEX = -1; //Field offset: 0x0
	[ReadOnly]
	public float minEnergyAtMaxDistance; //Field offset: 0x0
	[ReadOnly]
	public float minValidReflectionEnergy; //Field offset: 0x4
	[ReadOnly]
	public NativeArray previousStepSphereHits; //Field offset: 0x8
	public NativeArray rayStates; //Field offset: 0x18
	[ReadOnly]
	public float3 listenerPosition; //Field offset: 0x28
	[ReadOnly]
	public int maxReflections; //Field offset: 0x34
	[ReadOnly]
	public float rayOffset; //Field offset: 0x38
	[ReadOnly]
	public QueryParameters queryParams; //Field offset: 0x3C
	[ReadOnly]
	public int maxCommandsInBuffer; //Field offset: 0x4C
	[ReadOnly]
	public float reflectionEnergyLossFactor; //Field offset: 0x50
	[ReadOnly]
	public float spherecastRadius; //Field offset: 0x54
	[ReadOnly]
	public float listenerCheckSpherecastRadius; //Field offset: 0x58
	[NativeDisableParallelForRestriction]
	public NativeArray nextSpherecastCommands; //Field offset: 0x60
	[WriteOnly]
	public NativeArray minPathLengths; //Field offset: 0x70
	[WriteOnly]
	public NativeArray pathEnergies; //Field offset: 0x80
	[WriteOnly]
	public NativeArray pathEndStatuses; //Field offset: 0x90
	[NativeDisableParallelForRestriction]
	public ParallelWriter pathPointInfosWriter; //Field offset: 0xA0
	[ReadOnly]
	public NativeArray commandIndices; //Field offset: 0xA8

	public override void Execute(int index) { }

}

