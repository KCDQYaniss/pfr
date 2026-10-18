namespace Audio.SpatialSystem.SpatialAudioCalculator;

[BurstCompile]
public struct FindShortestPathJob : IJob
{
	private const float INITIAL_SHORTEST_PATH_LENGTH = 3.4028235E+38; //Field offset: 0x0
	private const int INVALID_RAY_INDEX = -1; //Field offset: 0x0
	private const byte STATUS_LISTENER_CLEAR = 1; //Field offset: 0x0
	[ReadOnly]
	public NativeArray rayMinPathLengths; //Field offset: 0x0
	[ReadOnly]
	public NativeArray rayEnergies; //Field offset: 0x10
	[ReadOnly]
	public NativeList rayPathPointInfos; //Field offset: 0x20
	[ReadOnly]
	public NativeArray rayEndStatuses; //Field offset: 0x28
	[WriteOnly]
	public NativeArray outputResult; //Field offset: 0x38

	public override void Execute() { }

}

