namespace Audio.Weapons;

public abstract class BaseAudioScheduler : IAudioScheduleService
{
	internal sealed class AudioScheduleOptions
	{
		public double baseMinOffsetSec; //Field offset: 0x10
		public double estimateWeight; //Field offset: 0x18
		public double nowWeight; //Field offset: 0x20

		public AudioScheduleOptions() { }

	}

	internal struct SchedulingContext
	{
		public double dspNow; //Field offset: 0x0
		public double alignedDspNow; //Field offset: 0x8
		public double alignmentOffsetDsp; //Field offset: 0x10
		public double adjustedAligned; //Field offset: 0x18
		public double minFutureAligned; //Field offset: 0x20
		public double minFutureDsp; //Field offset: 0x28
		public double previousIdeal; //Field offset: 0x30

	}

	internal sealed class SyncState
	{
		public double lastServerWorldTime; //Field offset: 0x10
		public double lastAlignedDsp; //Field offset: 0x18
		public bool hasValue; //Field offset: 0x20

		public SyncState() { }

	}

	protected const double MAX_VALID_TIME_DELTA = 10; //Field offset: 0x0
	protected const double MAX_VALID_SCHEDULED_DIFF = 60; //Field offset: 0x0
	protected const double MIN_VALID_BEAT_DURATION = 0.001; //Field offset: 0x0
	protected readonly SyncState _sync; //Field offset: 0x10
	protected readonly AudioScheduleOptions _options; //Field offset: 0x18
	protected IServerTimeProvider _serverTimeProvider; //Field offset: 0x20
	[CompilerGenerated]
	private readonly double <BufferLatency>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly double <DspBlockSec>k__BackingField; //Field offset: 0x30

	public override double BufferLatency
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public double DspBlockSec
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public double MinScheduleOffsetSec
	{
		 get { } //Length: 158
	}

	protected BaseAudioScheduler(AudioScheduleOptions options = null) { }

	private static IServerTimeProvider CreateDefaultServerTimeProvider() { }

	[CompilerGenerated]
	public override double get_BufferLatency() { }

	[CompilerGenerated]
	public double get_DspBlockSec() { }

	public double get_MinScheduleOffsetSec() { }

	public abstract double GetScheduledTime(double timeToHear, double previousIdeal, double beatDuration) { }

	protected static bool IsValidBeatDuration(double beatDuration) { }

	protected static bool IsValidTime(double time) { }

	protected SchedulingContext PrepareSchedulingContext(double timeToHear, double previousIdeal, double beatDuration) { }

	public override void RegisterServerTimeProvider(IServerTimeProvider provider) { }

	public override void Reset() { }

	protected double SanitizeScheduledTime(double scheduledDsp, double dspNow) { }

	public override bool TryGetAlignedDspNow(out double alignedDspNow) { }

	protected bool TryGetAlignedDspTime(out double alignedDspNow, out double alignmentOffsetDsp) { }

	public override void UnregisterServerTimeProvider() { }

}

