namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct ValidateCandidatesJob : IJobParallelFor
{
	private const int COMMANDS_PER_CANDIDATE = 2; //Field offset: 0x0
	private const int SECONDARY_COMMAND_OFFSET = 1; //Field offset: 0x0
	private const int RESULT_INDEX = 0; //Field offset: 0x0
	private const float MIN_RAY_LENGTH = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeList candidateEdgePoints; //Field offset: 0x0
	[ReadOnly]
	public float3 sourcePos; //Field offset: 0x8
	[ReadOnly]
	public float3 listenerPos; //Field offset: 0x14
	[ReadOnly]
	public QueryParameters queryParams; //Field offset: 0x20
	[ReadOnly]
	public float edgeValidationRayOffset; //Field offset: 0x30
	[ReadOnly]
	public NativeArray candidateCount; //Field offset: 0x38
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray validationRayCommands; //Field offset: 0x48

	public override void Execute(int index) { }

}

