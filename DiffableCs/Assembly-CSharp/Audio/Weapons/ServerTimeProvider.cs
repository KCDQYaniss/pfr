namespace Audio.Weapons;

public sealed class ServerTimeProvider : IServerTimeProvider
{
	internal sealed class ServerTimeProviderOptions
	{
		public double freshnessThresholdSeconds; //Field offset: 0x10
		public double maxBackwardJumpSeconds; //Field offset: 0x18
		public double coastAfterStaleSeconds; //Field offset: 0x20
		public double reconnectDetectionThresholdSeconds; //Field offset: 0x28

		public ServerTimeProviderOptions() { }

	}

	public const double NO_SERVER_TIME = -1; //Field offset: 0x0
	private readonly Func _snapshotProvider; //Field offset: 0x10
	private readonly ServerTimeProviderOptions _options; //Field offset: 0x18
	private double _lastSnapshotServerTime; //Field offset: 0x20
	private double _lastSnapshotReceiveRealtime; //Field offset: 0x28
	private double _lastReturnedEstimate; //Field offset: 0x30
	private bool _reconnectDetected; //Field offset: 0x38

	public ServerTimeProvider(Func snapshotProvider) { }

	public ServerTimeProvider(Func snapshotProvider, ServerTimeProviderOptions options) { }

	private double EstimateNow(double nowRealtime) { }

	private double GetClampedEstimate(float nowRealtime) { }

	public override double GetCurrentServerTime() { }

	private static bool IsSnapshotValid(double snapshot) { }

	public override void Reset() { }

}

