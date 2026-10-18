namespace Dissonance.Audio.Playback;

public struct SpeechSession
{
	private static readonly Log Log; //Field offset: 0x0
	private const float MinimumDelayFactor = 1.5; //Field offset: 0x0
	private const float MaximumDelay = 0.75; //Field offset: 0x0
	private static readonly float[] DesyncFixBuffer; //Field offset: 0x8
	private static readonly int FixedDelayToleranceTicks; //Field offset: 0x10
	private static readonly float InitialBufferDelay; //Field offset: 0x14
	private readonly float _minimumDelay; //Field offset: 0x0
	private readonly IRemoteChannelProvider _channels; //Field offset: 0x8
	private readonly IDecoderPipeline _pipeline; //Field offset: 0x10
	private readonly SessionContext _context; //Field offset: 0x18
	private readonly DateTime _creationTime; //Field offset: 0x28
	private readonly IJitterEstimator _jitter; //Field offset: 0x30

	public int BufferCount
	{
		 get { } //Length: 75
	}

	internal IRemoteChannelProvider Channels
	{
		internal get { } //Length: 5
	}

	public SessionContext Context
	{
		 get { } //Length: 11
	}

	public TimeSpan Delay
	{
		 get { } //Length: 367
	}

	[NotNull]
	public WaveFormat OutputWaveFormat
	{
		 get { } //Length: 78
	}

	internal float PacketLoss
	{
		internal get { } //Length: 78
	}

	public PlaybackOptions PlaybackOptions
	{
		 get { } //Length: 215
	}

	public SyncState SyncState
	{
		 get { } //Length: 215
	}

	public DateTime TargetActivationTime
	{
		 get { } //Length: 146
	}

	private static SpeechSession() { }

	private SpeechSession(SessionContext context, IJitterEstimator jitter, IDecoderPipeline pipeline, IRemoteChannelProvider channels, DateTime now) { }

	internal static SpeechSession Create(SessionContext context, IJitterEstimator jitter, IDecoderPipeline pipeline, IRemoteChannelProvider channels, DateTime now) { }

	public int get_BufferCount() { }

	internal IRemoteChannelProvider get_Channels() { }

	public SessionContext get_Context() { }

	public TimeSpan get_Delay() { }

	public WaveFormat get_OutputWaveFormat() { }

	internal float get_PacketLoss() { }

	public PlaybackOptions get_PlaybackOptions() { }

	public SyncState get_SyncState() { }

	public DateTime get_TargetActivationTime() { }

	public void Prepare(DateTime timeOfFirstDequeueAttempt) { }

	public bool Read(ArraySegment samples) { }

}

