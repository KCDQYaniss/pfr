namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct SelectBestEdgeJob : IJob
{
	private const int COMMANDS_PER_CANDIDATE = 2; //Field offset: 0x0
	private const float MIN_DISTANCE_SQ_THRESHOLD = 0.0001; //Field offset: 0x0
	private const float ENERGY_EXPONENT = 1.5; //Field offset: 0x0
	private const float DOT_OFFSET = 1; //Field offset: 0x0
	private const float DOT_SCALE = 0.5; //Field offset: 0x0
	private const int RESULT_INDEX = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeArray validationRayHits; //Field offset: 0x0
	[ReadOnly]
	public NativeArray validationRayCommands; //Field offset: 0x10
	[ReadOnly]
	public NativeList candidateEdgePoints; //Field offset: 0x20
	[ReadOnly]
	public NativeArray candidateCount; //Field offset: 0x28
	[ReadOnly]
	public float3 sourcePos; //Field offset: 0x38
	[ReadOnly]
	public float3 listenerPos; //Field offset: 0x44
	[ReadOnly]
	public NativeArray checkResult; //Field offset: 0x50
	[ReadOnly]
	public float maxDiffractionPathFactor; //Field offset: 0x60
	[WriteOnly]
	public NativeArray result; //Field offset: 0x68

	private float CalculateEnergyFactor(float3 edgePoint, float3 source, float3 listener) { }

	public override void Execute() { }

}

