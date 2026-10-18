namespace Dissonance.Audio.Playback;

internal class SynchronizerSampleSource : ISampleSource, IRateProvider
{
	private static readonly Log Log; //Field offset: 0x0
	private static readonly float[] DesyncFixBuffer; //Field offset: 0x8
	private readonly ISampleSource _upstream; //Field offset: 0x10
	private readonly TimeSpan _resetDesyncTime; //Field offset: 0x18
	private readonly Stopwatch _timer; //Field offset: 0x20
	private bool _enabled; //Field offset: 0x28
	private TimeSpan _aheadWarningLastSent; //Field offset: 0x30
	private long _totalSamplesRead; //Field offset: 0x38
	private DesyncCalculator _desync; //Field offset: 0x40
	[CompilerGenerated]
	private float <PlaybackRate>k__BackingField; //Field offset: 0x44

	public TimeSpan Desync
	{
		 get { } //Length: 159
	}

	public TimeSpan IdealPlaybackPosition
	{
		 get { } //Length: 29
	}

	public TimeSpan PlaybackPosition
	{
		 get { } //Length: 258
	}

	public private override float PlaybackRate
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SyncState State
	{
		 get { } //Length: 281
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 75
	}

	private static SynchronizerSampleSource() { }

	public SynchronizerSampleSource(ISampleSource upstream, TimeSpan resetDesyncTime) { }

	public void Enable() { }

	public TimeSpan get_Desync() { }

	public TimeSpan get_IdealPlaybackPosition() { }

	public TimeSpan get_PlaybackPosition() { }

	[CompilerGenerated]
	public override float get_PlaybackRate() { }

	public SyncState get_State() { }

	public override WaveFormat get_WaveFormat() { }

	public override void Prepare(SessionContext context) { }

	public override bool Read(ArraySegment samples) { }

	public override void Reset() { }

	[CompilerGenerated]
	private void set_PlaybackRate(float value) { }

	private bool Skip(int desyncMilliseconds, out int deltaSamples, out int deltaDesyncMilliseconds) { }

}

