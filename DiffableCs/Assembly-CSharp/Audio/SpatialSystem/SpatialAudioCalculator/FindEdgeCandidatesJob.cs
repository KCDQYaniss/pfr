namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct FindEdgeCandidatesJob : IJobParallelFor
{
	private const int SIDE_COUNT = 2; //Field offset: 0x0
	private const float VERTICAL_DOT_THRESHOLD = 0.99; //Field offset: 0x0
	private const float MIN_DIRECTION_LENGTH_SQ = 0.001; //Field offset: 0x0
	private const float TWO_PI = 6.2831855; //Field offset: 0x0
	private const int RESULT_INDEX = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeArray checkResult; //Field offset: 0x0
	[ReadOnly]
	public QueryParameters queryParams; //Field offset: 0x10
	[ReadOnly]
	public int edgeSearchRayCount; //Field offset: 0x20
	[ReadOnly]
	public float edgeSearchRayLength; //Field offset: 0x24
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray edgeSearchRayCommands; //Field offset: 0x28

	public override void Execute(int index) { }

	private void GetPerpendicularDirections(float3 forward, out float3 right, out float3 up) { }

}

