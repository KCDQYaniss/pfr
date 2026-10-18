namespace Dissonance.Audio.Playback;

public class VoicePlayback : MonoBehaviour, IVoicePlaybackInternal, IRemoteChannelProvider, IVoicePlayback, IVolumeProvider
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static PCMReaderCallback <>9__58_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnEnable>b__58_0(float[] buf) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private Transform _transformCache; //Field offset: 0x20
	private readonly SpeechSessionStream _sessions; //Field offset: 0x28
	private PlaybackOptions _cachedPlaybackOptions; //Field offset: 0x30
	[CompilerGenerated]
	private AudioSource <AudioSource>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <Dissonance.Audio.Playback.IVoicePlaybackInternal.AllowPositionalPlayback>k__BackingField; //Field offset: 0x48
	private SamplePlaybackComponent _player; //Field offset: 0x50
	private CodecSettings _codecSettings; //Field offset: 0x58
	private FrameFormat _frameFormat; //Field offset: 0x68
	private Nullable _savedSpatialBlend; //Field offset: 0x80
	private bool _spatialBlendFixed; //Field offset: 0x88
	[CompilerGenerated]
	private bool <Dissonance.Audio.Playback.IVoicePlaybackInternal.IsMuted>k__BackingField; //Field offset: 0x89
	[CompilerGenerated]
	private float <Dissonance.Audio.Playback.IVoicePlaybackInternal.PlaybackVolume>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private bool <IsApplyingAudioSpatialization>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private IPriorityManager <PriorityManager>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private IVolumeProvider <VolumeProvider>k__BackingField; //Field offset: 0xA0

	public override float Amplitude
	{
		 get { } //Length: 243
	}

	public private override AudioSource AudioSource
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public internal CodecSettings CodecSettings
	{
		 get { } //Length: 19
		internal set { } //Length: 372
	}

	private override float Dissonance.Audio.Playback.IVoicePlayback.Jitter
	{
		private get { } //Length: 75
	}

	private override Nullable Dissonance.Audio.Playback.IVoicePlayback.PacketLoss
	{
		private get { } //Length: 284
	}

	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.AllowPositionalPlayback
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.IsApplyingAudioSpatialization
	{
		private get { } //Length: 8
	}

	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.IsMuted
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override float Dissonance.Audio.Playback.IVoicePlaybackInternal.PlaybackVolume
	{
		[CompilerGenerated]
		private get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	private override float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
	{
		private get { } //Length: 487
	}

	public override bool IsActive
	{
		 get { } //Length: 78
	}

	private bool IsApplyingAudioSpatialization
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool IsSpeaking
	{
		 get { } //Length: 265
	}

	public internal override string PlayerName
	{
		 get { } //Length: 27
		internal set { } //Length: 373
	}

	public override ChannelPriority Priority
	{
		 get { } //Length: 259
	}

	internal IPriorityManager PriorityManager
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	private Transform Transform
	{
		private get { } //Length: 342
	}

	[CanBeNull]
	internal IVolumeProvider VolumeProvider
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	private static VoicePlayback() { }

	public VoicePlayback() { }

	public void Awake() { }

	private override void Dissonance.Audio.Playback.IRemoteChannelProvider.GetRemoteChannels(List output) { }

	private override float Dissonance.Audio.Playback.IVoicePlayback.get_Jitter() { }

	private override Nullable Dissonance.Audio.Playback.IVoicePlayback.get_PacketLoss() { }

	[CompilerGenerated]
	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.get_AllowPositionalPlayback() { }

	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.get_IsApplyingAudioSpatialization() { }

	[CompilerGenerated]
	private override bool Dissonance.Audio.Playback.IVoicePlaybackInternal.get_IsMuted() { }

	[CompilerGenerated]
	private override float Dissonance.Audio.Playback.IVoicePlaybackInternal.get_PlaybackVolume() { }

	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.ReceiveAudioPacket(VoicePacket packet) { }

	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.Reset() { }

	[CompilerGenerated]
	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.set_AllowPositionalPlayback(bool value) { }

	[CompilerGenerated]
	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.set_IsMuted(bool value) { }

	[CompilerGenerated]
	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.set_PlaybackVolume(float value) { }

	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.SetTransform(Vector3 pos, Quaternion rot) { }

	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.StartPlayback() { }

	private override void Dissonance.Audio.Playback.IVoicePlaybackInternal.StopPlayback() { }

	private override float Dissonance.Audio.Playback.IVolumeProvider.get_TargetVolume() { }

	public override void ForceReset() { }

	public override float get_Amplitude() { }

	[CompilerGenerated]
	public override AudioSource get_AudioSource() { }

	public CodecSettings get_CodecSettings() { }

	public override bool get_IsActive() { }

	[CompilerGenerated]
	private bool get_IsApplyingAudioSpatialization() { }

	public override bool get_IsSpeaking() { }

	public override string get_PlayerName() { }

	public override ChannelPriority get_Priority() { }

	[CompilerGenerated]
	internal IPriorityManager get_PriorityManager() { }

	private Transform get_Transform() { }

	[CompilerGenerated]
	internal IVolumeProvider get_VolumeProvider() { }

	public void OnDisable() { }

	public void OnEnable() { }

	[CompilerGenerated]
	private void set_AudioSource(AudioSource value) { }

	internal void set_CodecSettings(CodecSettings value) { }

	[CompilerGenerated]
	private void set_IsApplyingAudioSpatialization(bool value) { }

	internal void set_PlayerName(string value) { }

	[CompilerGenerated]
	internal void set_PriorityManager(IPriorityManager value) { }

	[CompilerGenerated]
	internal void set_VolumeProvider(IVolumeProvider value) { }

	public void Update() { }

	private void UpdatePositionalPlayback() { }

}

