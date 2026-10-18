namespace Dissonance.Audio.Playback;

internal class DecoderPipeline : IDecoderPipeline, IVolumeProvider, IRemoteChannelProvider, IRateProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__33_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal List <.ctor>b__33_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public uint inputFrameSize; //Field offset: 0x10
		public IVoiceDecoder decoder; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal byte[] <.ctor>b__0() { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly Action _completionHandler; //Field offset: 0x10
	private readonly TransferBuffer _inputBuffer; //Field offset: 0x18
	private readonly ConcurrentPool _bytePool; //Field offset: 0x20
	private readonly ConcurrentPool _channelListPool; //Field offset: 0x28
	private readonly BufferedDecoder _source; //Field offset: 0x30
	private readonly SynchronizerSampleSource _synchronizer; //Field offset: 0x38
	private readonly ISampleSource _output; //Field offset: 0x40
	private bool _prepared; //Field offset: 0x48
	private bool _complete; //Field offset: 0x49
	private bool _sourceClosed; //Field offset: 0x4A
	private readonly TimeSpan _frameDuration; //Field offset: 0x50
	private Nullable _firstFrameArrival; //Field offset: 0x58
	private uint _firstFrameSeq; //Field offset: 0x68
	private readonly string _id; //Field offset: 0x70
	[CompilerGenerated]
	private IVolumeProvider <VolumeProvider>k__BackingField; //Field offset: 0x78

	public override int BufferCount
	{
		 get { } //Length: 93
	}

	public override TimeSpan BufferTime
	{
		 get { } //Length: 178
	}

	private override float Dissonance.Audio.Playback.IRateProvider.PlaybackRate
	{
		private get { } //Length: 28
	}

	private override float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
	{
		private get { } //Length: 139
	}

	public string ID
	{
		 get { } //Length: 5
	}

	public override TimeSpan InputFrameTime
	{
		 get { } //Length: 5
	}

	public override WaveFormat OutputFormat
	{
		 get { } //Length: 75
	}

	public override float PacketLoss
	{
		 get { } //Length: 261
	}

	public override PlaybackOptions PlaybackOptions
	{
		 get { } //Length: 59
	}

	public override SyncState SyncState
	{
		 get { } //Length: 328
	}

	public IVolumeProvider VolumeProvider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static DecoderPipeline() { }

	public DecoderPipeline(IVoiceDecoder decoder, uint inputFrameSize, Action completionHandler, string id, bool softClip = true) { }

	private override float Dissonance.Audio.Playback.IRateProvider.get_PlaybackRate() { }

	private override float Dissonance.Audio.Playback.IVolumeProvider.get_TargetVolume() { }

	public override void EnableDynamicSync() { }

	public void FlushTransferBuffer() { }

	public override int get_BufferCount() { }

	public override TimeSpan get_BufferTime() { }

	public string get_ID() { }

	public override TimeSpan get_InputFrameTime() { }

	public override WaveFormat get_OutputFormat() { }

	public override float get_PacketLoss() { }

	public override PlaybackOptions get_PlaybackOptions() { }

	public override SyncState get_SyncState() { }

	[CompilerGenerated]
	public IVolumeProvider get_VolumeProvider() { }

	public override void GetRemoteChannels(List output) { }

	public override void Prepare(SessionContext context) { }

	public float Push(VoicePacket packet, DateTime now) { }

	public override bool Read(ArraySegment samples) { }

	private void RecycleFrame(VoicePacket packet) { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_VolumeProvider(IVolumeProvider value) { }

	public void Stop() { }

}

