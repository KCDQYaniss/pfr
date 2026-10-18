namespace Dissonance.Audio.Playback;

internal interface IDecoderPipeline
{

	public int BufferCount
	{
		 get { } //Length: 0
	}

	public TimeSpan BufferTime
	{
		 get { } //Length: 0
	}

	public TimeSpan InputFrameTime
	{
		 get { } //Length: 0
	}

	[NotNull]
	public WaveFormat OutputFormat
	{
		 get { } //Length: 0
	}

	public float PacketLoss
	{
		 get { } //Length: 0
	}

	public PlaybackOptions PlaybackOptions
	{
		 get { } //Length: 0
	}

	public SyncState SyncState
	{
		 get { } //Length: 0
	}

	public void EnableDynamicSync() { }

	public int get_BufferCount() { }

	public TimeSpan get_BufferTime() { }

	public TimeSpan get_InputFrameTime() { }

	public WaveFormat get_OutputFormat() { }

	public float get_PacketLoss() { }

	public PlaybackOptions get_PlaybackOptions() { }

	public SyncState get_SyncState() { }

	public void Prepare(SessionContext context) { }

	public bool Read(ArraySegment samples) { }

}

