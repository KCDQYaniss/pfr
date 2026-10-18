namespace EFT.NextObservedPlayer;

public static class ObservedPlayerMessageJobs
{
	internal struct InterpolationOptions
	{
		public double DynamicAdjustmentTolerance; //Field offset: 0x0
		public int DeliveryTimeEmaDuration; //Field offset: 0x8
		public double CatchupNegativeThreshold; //Field offset: 0x10
		public double CatchupPositiveThreshold; //Field offset: 0x18
		public double CatchupSpeed; //Field offset: 0x20
		public double SlowdownSpeed; //Field offset: 0x28
		public double MaxBufferMultiplier; //Field offset: 0x30
		public double MaxCatchupSpeed; //Field offset: 0x38
		public double BufferMultiplierSmoothing; //Field offset: 0x40
		public double TimescaleSmoothing; //Field offset: 0x48

	}

	public const int OBSERVED_PLAYER_SIZE = 255; //Field offset: 0x0
	public const int SNAPSHOT_MESSAGE_SIZE = 64; //Field offset: 0x0
	public const int COMMANDS_MESSAGE_SIZE = 4096; //Field offset: 0x0
	public static readonly InterpolationOptions MediumLatencyToleranceInterpolationOptions; //Field offset: 0x0
	public static readonly InterpolationOptions DefaultInterpolationOptions; //Field offset: 0x50
	private static NativeArray _jobHandles; //Field offset: 0xA0
	private static bool _initialized; //Field offset: 0xB0
	private static NativeArray _snapshotRing; //Field offset: 0xB8
	private static NativeArray _snapshotHead; //Field offset: 0xC8
	private static NativeArray _snapshotCount; //Field offset: 0xD8
	private static NativeArray _localTimeline; //Field offset: 0xE8
	private static NativeArray _localTimescale; //Field offset: 0xF8
	private static NativeArray _bufferTimeMultiplier; //Field offset: 0x108
	private static NativeArray _deliveryEma; //Field offset: 0x118
	private static NativeArray _driftEma; //Field offset: 0x128
	private static NativeArray _movementOutput; //Field offset: 0x138
	private static NativeArray _worldTimeOutput; //Field offset: 0x148
	private static NativeArray _movementValid; //Field offset: 0x158
	private static NativeArray _processMovementMask; //Field offset: 0x168
	private static NativeArray _observedPlayersNative; //Field offset: 0x178
	private static int _remoteFramerate; //Field offset: 0x188
	private static float _remoteDeltaTime; //Field offset: 0x18C
	private static double _deliveryEmaAlpha; //Field offset: 0x190
	private static double _driftEmaAlpha; //Field offset: 0x198
	private static double _dynamicAdjustmentTolerance; //Field offset: 0x1A0
	private static double _catchupSpeed; //Field offset: 0x1A8
	private static double _slowdownSpeed; //Field offset: 0x1B0
	private static double _catchupNegativeThreshold; //Field offset: 0x1B8
	private static double _catchupPositiveThreshold; //Field offset: 0x1C0
	private static double _maxBufferMultiplier; //Field offset: 0x1C8
	private static double _maxCatchupSpeed; //Field offset: 0x1D0
	private static double _bufferMultiplierSmoothing; //Field offset: 0x1D8
	private static double _timescaleSmoothing; //Field offset: 0x1E0
	private static InterpolationOptions _interpolationOptions; //Field offset: 0x1E8
	private static int _observedPlayerCount; //Field offset: 0x238
	private static readonly int[] _observedPlayers; //Field offset: 0x240

	public static NativeArray MovementOutput
	{
		 get { } //Length: 99
	}

	public static NativeArray MovementValid
	{
		 get { } //Length: 99
	}

	public static NativeArray WorldTimeOutput
	{
		 get { } //Length: 99
	}

	private static ObservedPlayerMessageJobs() { }

	public static void Dispose() { }

	private static void EnsureInitialized() { }

	public static NativeArray get_MovementOutput() { }

	public static NativeArray get_MovementValid() { }

	public static NativeArray get_WorldTimeOutput() { }

	private static void RecalculateInterpolationParameters() { }

	public static void ResetPlayer(int playerId) { }

	public static JobHandle Run(ObservedPlayerControllers observedPlayerControllers, int snapshotMessageCount, int commandsMessageCount, float localDeltaTime) { }

	public static void SetInterpolationOptions(InterpolationOptions options) { }

	public static void SetRemoteFramerate(int framerate) { }

}

