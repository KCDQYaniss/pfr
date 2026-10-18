namespace Dissonance.Audio.Playback;

internal class BufferedDecoder : IFrameSource, IRemoteChannelProvider
{
	private readonly EncodedAudioBuffer _buffer; //Field offset: 0x10
	private readonly IVoiceDecoder _decoder; //Field offset: 0x18
	private readonly uint _frameSize; //Field offset: 0x20
	private readonly WaveFormat _waveFormat; //Field offset: 0x28
	private readonly Action _recycleFrame; //Field offset: 0x30
	private AudioFileWriter _diagnosticOutput; //Field offset: 0x38
	private readonly LockedValue _options; //Field offset: 0x40
	private bool _receivedFirstPacket; //Field offset: 0x48
	private int _approxChannelCount; //Field offset: 0x4C
	private readonly ReadonlyLockedValue _channels; //Field offset: 0x50

	public int BufferCount
	{
		 get { } //Length: 26
	}

	public override uint FrameSize
	{
		 get { } //Length: 4
	}

	public PlaybackOptions LatestPlaybackOptions
	{
		 get { } //Length: 313
	}

	public float PacketLoss
	{
		 get { } //Length: 248
	}

	public uint SequenceNumber
	{
		 get { } //Length: 26
	}

	public override WaveFormat WaveFormat
	{
		 get { } //Length: 5
	}

	public BufferedDecoder(IVoiceDecoder decoder, uint frameSize, WaveFormat waveFormat, Action recycleFrame) { }

	private void ExtractChannels(VoicePacket encoded) { }

	public int get_BufferCount() { }

	public override uint get_FrameSize() { }

	public PlaybackOptions get_LatestPlaybackOptions() { }

	public float get_PacketLoss() { }

	public uint get_SequenceNumber() { }

	public override WaveFormat get_WaveFormat() { }

	public override void GetRemoteChannels(List output) { }

	public override void Prepare(SessionContext context) { }

	public void Push(VoicePacket frame) { }

	public override bool Read(ArraySegment frame) { }

	public override void Reset() { }

	public void Stop() { }

}

