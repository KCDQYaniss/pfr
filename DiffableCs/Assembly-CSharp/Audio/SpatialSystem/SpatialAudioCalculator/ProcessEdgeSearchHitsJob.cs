namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct ProcessEdgeSearchHitsJob : IJob
{
	private const int SIDE_COUNT = 2; //Field offset: 0x0
	private const float TOO_CLOSE_DISTANCE_SQ_THRESHOLD = 0.001; //Field offset: 0x0
	private const int RESULT_INDEX = 0; //Field offset: 0x0
	[ReadOnly]
	public NativeArray edgeSearchRayHits; //Field offset: 0x0
	[ReadOnly]
	public NativeArray edgeSearchRayCommands; //Field offset: 0x10
	[ReadOnly]
	public NativeArray checkResult; //Field offset: 0x20
	[ReadOnly]
	public int edgeSearchRayCount; //Field offset: 0x30
	public NativeList candidateEdgePoints; //Field offset: 0x38
	public NativeArray candidateCount; //Field offset: 0x40

	public override void Execute() { }

}

