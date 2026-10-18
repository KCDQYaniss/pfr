namespace UnityDiagnostics;

public class FrameMeasurer : IDisposable
{
	internal class FrameMeasurerLogger : AbstractLogger
	{
		internal class Config
		{
			public float AvgStatisticsLogInterval; //Field offset: 0x10
			public float NetworkQualityLogInterval; //Field offset: 0x14
			public float BadFrame; //Field offset: 0x18
			public float BadFixedUpdate; //Field offset: 0x1C
			public float BadFrameWithoutFixedUpdates; //Field offset: 0x20

			public Config() { }

		}

		private BadValueLogTracker _badFrameTracker; //Field offset: 0x48
		private BadValueLogTracker _badFixedUpdateTracker; //Field offset: 0x50
		private BadValueLogTracker _badFrameWithoutFixedUpdatesTracker; //Field offset: 0x58
		private Config _config; //Field offset: 0x60
		private float _lastAvgStatisticsLogTime; //Field offset: 0x68
		private float _lastNetworkQualityLogTime; //Field offset: 0x6C

		public FrameMeasurerLogger(Config config) { }

		public virtual void Dispose() { }

		public void TrackFixedUpdate(FrameMeasurer frameMeasurer) { }

		public void TrackUpdate(FrameMeasurer frameMeasurer) { }

		public void TryToLogAvgNetworkQuality(NetworkQuality networkQuality) { }

		public void TryToLogAvgStatistics(FrameMeasurer frameMeasurer) { }

	}

	public static readonly string FIXED_UPDATE; //Field offset: 0x0
	public static readonly string SINGLE_FIXED_UPDATE; //Field offset: 0x8
	public static readonly string UPDATE; //Field offset: 0x10
	public static readonly string GAME_UPDATE; //Field offset: 0x18
	public static readonly string RENDER; //Field offset: 0x20
	public static readonly string FRAME; //Field offset: 0x28
	public static readonly string NET_OUTGOINIG; //Field offset: 0x30
	public static readonly string PACKETS_OUTGOINIG; //Field offset: 0x38
	public static readonly string PACKETS_INGOINIG; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnFrameLengthReceived; //Field offset: 0x10
	private double _currentFixedUpdatesBetweenUpdate; //Field offset: 0x18
	private float _lastUpdateMetricsTime; //Field offset: 0x20
	private float _updateMetricsInterval; //Field offset: 0x24
	private float _lastUpdateTimeStamp; //Field offset: 0x28
	private IMetricsHandler _metrics; //Field offset: 0x30
	private FrameMeasurerLogger _logger; //Field offset: 0x38
	[CompilerGenerated]
	private int <PlayerRTT>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <ServerFixedUpdateTime>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <ServerTime>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private TimeMeasurer <FixedUpdatesBetweenUpdateMeasurer>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private TimeMeasurer <SingleFixedUpdatesMeasurer>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private TimeMeasurer <UpdateMeasurer>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private TimeMeasurer <GameUpdateMeasurer>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private TimeMeasurer <RenderMeasurer>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private TimeMeasurer <GameFrameMeasurer>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private ValueDiffStatisticsMeasurer <NetOutgoingMeasurer>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private ValueDiffStatisticsMeasurer <PacketsOutgoingMeasurer>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private ValueDiffStatisticsMeasurer <PacketsIngoingMeasurer>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private IncrementalMeasurer <UpdateCountMeasurer>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private IncrementalMeasurer <FixedUpdateCountMeasurer>k__BackingField; //Field offset: 0xA0
	public readonly NetworkQuality NetworkQuality; //Field offset: 0xA8

	public event Action OnFrameLengthReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public double CurrentFrameWithoutFixedUpdates
	{
		 get { } //Length: 143
	}

	public private IncrementalMeasurer FixedUpdateCountMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private TimeMeasurer FixedUpdatesBetweenUpdateMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private TimeMeasurer GameFrameMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private TimeMeasurer GameUpdateMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ValueDiffStatisticsMeasurer NetOutgoingMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ValueDiffStatisticsMeasurer PacketsIngoingMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ValueDiffStatisticsMeasurer PacketsOutgoingMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int PlayerRTT
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private TimeMeasurer RenderMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int ServerFixedUpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int ServerTime
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private TimeMeasurer SingleFixedUpdatesMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private IncrementalMeasurer UpdateCountMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private TimeMeasurer UpdateMeasurer
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static FrameMeasurer() { }

	private FrameMeasurer() { }

	[CompilerGenerated]
	public void add_OnFrameLengthReceived(Action value) { }

	public static FrameMeasurer Create() { }

	private void CreateMeasurers() { }

	public override void Dispose() { }

	public double get_CurrentFrameWithoutFixedUpdates() { }

	[CompilerGenerated]
	public IncrementalMeasurer get_FixedUpdateCountMeasurer() { }

	[CompilerGenerated]
	public TimeMeasurer get_FixedUpdatesBetweenUpdateMeasurer() { }

	[CompilerGenerated]
	public TimeMeasurer get_GameFrameMeasurer() { }

	[CompilerGenerated]
	public TimeMeasurer get_GameUpdateMeasurer() { }

	[CompilerGenerated]
	public ValueDiffStatisticsMeasurer get_NetOutgoingMeasurer() { }

	[CompilerGenerated]
	public ValueDiffStatisticsMeasurer get_PacketsIngoingMeasurer() { }

	[CompilerGenerated]
	public ValueDiffStatisticsMeasurer get_PacketsOutgoingMeasurer() { }

	[CompilerGenerated]
	public int get_PlayerRTT() { }

	[CompilerGenerated]
	public TimeMeasurer get_RenderMeasurer() { }

	[CompilerGenerated]
	public int get_ServerFixedUpdateTime() { }

	[CompilerGenerated]
	public int get_ServerTime() { }

	[CompilerGenerated]
	public TimeMeasurer get_SingleFixedUpdatesMeasurer() { }

	[CompilerGenerated]
	public IncrementalMeasurer get_UpdateCountMeasurer() { }

	[CompilerGenerated]
	public TimeMeasurer get_UpdateMeasurer() { }

	public double GetCurrentFrameTime() { }

	public double GetRealCurrentFrameTimeRightNow() { }

	private void OnEndOfFixedUpdate() { }

	private void OnEndOfFrame() { }

	private void OnEndOfUpdate() { }

	private void OnStartOfFixedUpdate() { }

	private void OnStartOfFrame() { }

	private void OnStartOfPostLateUpdate() { }

	private void OnStartOfUpdate() { }

	[CompilerGenerated]
	public void remove_OnFrameLengthReceived(Action value) { }

	[CompilerGenerated]
	private void set_FixedUpdateCountMeasurer(IncrementalMeasurer value) { }

	[CompilerGenerated]
	private void set_FixedUpdatesBetweenUpdateMeasurer(TimeMeasurer value) { }

	[CompilerGenerated]
	private void set_GameFrameMeasurer(TimeMeasurer value) { }

	[CompilerGenerated]
	private void set_GameUpdateMeasurer(TimeMeasurer value) { }

	[CompilerGenerated]
	private void set_NetOutgoingMeasurer(ValueDiffStatisticsMeasurer value) { }

	[CompilerGenerated]
	private void set_PacketsIngoingMeasurer(ValueDiffStatisticsMeasurer value) { }

	[CompilerGenerated]
	private void set_PacketsOutgoingMeasurer(ValueDiffStatisticsMeasurer value) { }

	[CompilerGenerated]
	public void set_PlayerRTT(int value) { }

	[CompilerGenerated]
	private void set_RenderMeasurer(TimeMeasurer value) { }

	[CompilerGenerated]
	public void set_ServerFixedUpdateTime(int value) { }

	[CompilerGenerated]
	public void set_ServerTime(int value) { }

	[CompilerGenerated]
	private void set_SingleFixedUpdatesMeasurer(TimeMeasurer value) { }

	[CompilerGenerated]
	private void set_UpdateCountMeasurer(IncrementalMeasurer value) { }

	[CompilerGenerated]
	private void set_UpdateMeasurer(TimeMeasurer value) { }

	public void SetMetricsHandler(IMetricsHandler metrics) { }

	private void TryToUpdateMetrics() { }

}

