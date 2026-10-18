namespace EFT.NextObservedPlayer;

public struct ObservedPlayerSnapshotMessagePrepareJob : IJob
{
	private const float TIME_EPSILON = 0.0001; //Field offset: 0x0
	public static int ByteMessageCount; //Field offset: 0x0
	public static readonly ArraySegment[] ByteMessages; //Field offset: 0x8
	public static readonly double[] ByteMessageLocalTimes; //Field offset: 0x10
	private static readonly NetworkReader _networkReader; //Field offset: 0x18
	private static readonly int[] _observedKeyToIndexMap; //Field offset: 0x20
	private static uint _lastPacketSequence; //Field offset: 0x28
	private static byte _packetSequenceInitialized; //Field offset: 0x2C
	public static float WorldTime; //Field offset: 0x30
	public static uint PacketSequence; //Field offset: 0x34
	public int ObservedPlayerCount; //Field offset: 0x0
	[ReadOnly]
	public NativeArray ObservedPlayers; //Field offset: 0x8
	public NativeArray SnapshotRing; //Field offset: 0x18
	public NativeArray SnapshotHead; //Field offset: 0x28
	public NativeArray SnapshotCount; //Field offset: 0x38
	public NativeArray LocalTimeline; //Field offset: 0x48
	public NativeArray LocalTimescale; //Field offset: 0x58
	public NativeArray BufferTimeMultiplier; //Field offset: 0x68
	public NativeArray DeliveryEma; //Field offset: 0x78
	public NativeArray DriftEma; //Field offset: 0x88
	public int SnapshotRingCapacity; //Field offset: 0x98
	public double RemoteDeltaTime; //Field offset: 0xA0
	public double DeliveryEmaAlpha; //Field offset: 0xA8
	public double DriftEmaAlpha; //Field offset: 0xB0
	public double DynamicAdjustmentTolerance; //Field offset: 0xB8
	public double CatchupSpeed; //Field offset: 0xC0
	public double SlowdownSpeed; //Field offset: 0xC8
	public double CatchupNegativeThreshold; //Field offset: 0xD0
	public double CatchupPositiveThreshold; //Field offset: 0xD8
	public double MaxBufferMultiplier; //Field offset: 0xE0
	public double MaxCatchupSpeed; //Field offset: 0xE8
	public double BufferMultiplierSmoothing; //Field offset: 0xF0
	public double TimescaleSmoothing; //Field offset: 0xF8

	private static ObservedPlayerSnapshotMessagePrepareJob() { }

	public override void Execute() { }

	public static void ResetStreamState() { }

}

