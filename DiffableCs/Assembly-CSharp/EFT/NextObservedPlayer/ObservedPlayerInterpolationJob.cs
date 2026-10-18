namespace EFT.NextObservedPlayer;

[BurstCompile]
public struct ObservedPlayerInterpolationJob : IJobParallelFor
{
	private const float CURVE_BLEND = 0.2; //Field offset: 0x0
	[ReadOnly]
	public NativeArray ObservedPlayers; //Field offset: 0x0
	[ReadOnly]
	public NativeArray SnapshotRing; //Field offset: 0x10
	[NativeDisableParallelForRestriction]
	public NativeArray SnapshotHead; //Field offset: 0x20
	[NativeDisableParallelForRestriction]
	public NativeArray SnapshotCount; //Field offset: 0x30
	[ReadOnly]
	public NativeArray ProcessMovementMask; //Field offset: 0x40
	[NativeDisableParallelForRestriction]
	public NativeArray LocalTimeline; //Field offset: 0x50
	[ReadOnly]
	public NativeArray LocalTimescale; //Field offset: 0x60
	[ReadOnly]
	public NativeArray BufferTimeMultiplier; //Field offset: 0x70
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray MovementOutput; //Field offset: 0x80
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray WorldTimeOutput; //Field offset: 0x90
	[NativeDisableParallelForRestriction]
	[WriteOnly]
	public NativeArray MovementValid; //Field offset: 0xA0
	public int SnapshotRingCapacity; //Field offset: 0xB0
	public float RemoteDeltaTime; //Field offset: 0xB4
	public float LocalDeltaTime; //Field offset: 0xB8

	public override void Execute(int observedIndex) { }

	private static float LerpAngleDegrees(float from, float to, float t) { }

}

