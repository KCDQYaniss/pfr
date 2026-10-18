namespace Audio.AmbientSubsystem;

[BurstCompile]
internal struct OptimalScoreCalculationJob : IJobParallelFor
{
	[ReadOnly]
	public int currentIndoorRoomID; //Field offset: 0x0
	[ReadOnly]
	public float listenerHeightWeight; //Field offset: 0x4
	[ReadOnly]
	public float depthCalculationMult; //Field offset: 0x8
	[ReadOnly]
	public float connectedRoomPenalty; //Field offset: 0xC
	[ReadOnly]
	public float neighborRoomPenalty; //Field offset: 0x10
	[ReadOnly]
	public Vector3 listenerPosition; //Field offset: 0x14
	[ReadOnly]
	public NativeArray portalsData; //Field offset: 0x20
	[ReadOnly]
	public NativeArray distancesToListener; //Field offset: 0x30
	[WriteOnly]
	public NativeArray calculatedPortalData; //Field offset: 0x40
	[ReadOnly]
	public NativeArray indoorRoomsIDs; //Field offset: 0x50
	[ReadOnly]
	public NativeArray neighborRoomIDs; //Field offset: 0x60
	[ReadOnly]
	public bool ignoreDistanceRatio; //Field offset: 0x70

	public override void Execute(int index) { }

	private static bool IsPortalInRange(float distanceToPortal, float depth, float depthMult) { }

	private static bool IsPortalStateValid(byte state) { }

}

