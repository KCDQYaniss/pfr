namespace Dissonance;

internal class LocalVoicePlayerState : VoicePlayerState
{
	private static readonly Log Log; //Field offset: 0x0
	[NotNull]
	private readonly IAmplitudeProvider _micAmplitude; //Field offset: 0x40
	[NotNull]
	private readonly Rooms _rooms; //Field offset: 0x48
	[NotNull]
	private readonly RoomChannels _roomChannels; //Field offset: 0x50
	[NotNull]
	private readonly PlayerChannels _playerChannels; //Field offset: 0x58
	[NotNull]
	private readonly ILossEstimator _loss; //Field offset: 0x60
	[NotNull]
	private readonly ICommsNetwork _network; //Field offset: 0x68
	[CompilerGenerated]
	private IDissonancePlayer <Tracker>k__BackingField; //Field offset: 0x70

	public virtual float Amplitude
	{
		 get { } //Length: 75
	}

	public virtual bool IsConnected
	{
		 get { } //Length: 82
	}

	public virtual bool IsLocallyMuted
	{
		 get { } //Length: 3
		 set { } //Length: 242
	}

	public virtual bool IsLocalPlayer
	{
		 get { } //Length: 3
	}

	public virtual bool IsSpeaking
	{
		 get { } //Length: 135
	}

	public virtual Nullable PacketLoss
	{
		 get { } //Length: 118
	}

	internal virtual IVoicePlaybackInternal PlaybackInternal
	{
		internal get { } //Length: 3
	}

	public virtual ReadOnlyCollection Rooms
	{
		 get { } //Length: 27
	}

	public virtual Nullable SpeakerPriority
	{
		 get { } //Length: 3
	}

	public internal virtual IDissonancePlayer Tracker
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public virtual float Volume
	{
		 get { } //Length: 9
		 set { } //Length: 229
	}

	private static LocalVoicePlayerState() { }

	public LocalVoicePlayerState(string name, IAmplitudeProvider micAmplitude, Rooms rooms, RoomChannels roomChannels, PlayerChannels playerChannels, ILossEstimator loss, ICommsNetwork network) { }

	private static RemoteChannel CreateRemoteChannel(T item, ChannelType type) { }

	public virtual float get_Amplitude() { }

	public virtual bool get_IsConnected() { }

	public virtual bool get_IsLocallyMuted() { }

	public virtual bool get_IsLocalPlayer() { }

	public virtual bool get_IsSpeaking() { }

	public virtual Nullable get_PacketLoss() { }

	internal virtual IVoicePlaybackInternal get_PlaybackInternal() { }

	public virtual ReadOnlyCollection get_Rooms() { }

	public virtual Nullable get_SpeakerPriority() { }

	[CompilerGenerated]
	public virtual IDissonancePlayer get_Tracker() { }

	public virtual float get_Volume() { }

	public virtual void GetSpeakingChannels(List channels) { }

	private void OnChannelClosed(string channel, ChannelProperties properties) { }

	private void OnChannelOpened(string channel, ChannelProperties properties) { }

	private void OnLocallyEnteredRoom(string room) { }

	private void OnLocallyExitedRoom(string room) { }

	public virtual void set_IsLocallyMuted(bool value) { }

	[CompilerGenerated]
	internal virtual void set_Tracker(IDissonancePlayer value) { }

	public virtual void set_Volume(float value) { }

	internal virtual void Update() { }

}

