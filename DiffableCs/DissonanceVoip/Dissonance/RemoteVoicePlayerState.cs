namespace Dissonance;

internal class RemoteVoicePlayerState : VoicePlayerState
{
	private static readonly Log Log; //Field offset: 0x0
	private static readonly ReadOnlyCollection EmptyRoomsList; //Field offset: 0x8
	private readonly IVoicePlaybackInternal _playback; //Field offset: 0x40
	private IDissonancePlayer _player; //Field offset: 0x48
	private ReadOnlyCollection _rooms; //Field offset: 0x50

	public virtual float Amplitude
	{
		 get { } //Length: 113
	}

	public virtual bool IsConnected
	{
		 get { } //Length: 171
	}

	public virtual bool IsLocallyMuted
	{
		 get { } //Length: 110
		 set { } //Length: 317
	}

	public virtual bool IsLocalPlayer
	{
		 get { } //Length: 3
	}

	public virtual bool IsSpeaking
	{
		 get { } //Length: 110
	}

	internal Nullable Jitter
	{
		internal get { } //Length: 143
	}

	public virtual Nullable PacketLoss
	{
		 get { } //Length: 100
	}

	internal virtual IVoicePlaybackInternal PlaybackInternal
	{
		internal get { } //Length: 50
	}

	public virtual ReadOnlyCollection Rooms
	{
		 get { } //Length: 99
	}

	public virtual Nullable SpeakerPriority
	{
		 get { } //Length: 211
	}

	public internal virtual IDissonancePlayer Tracker
	{
		 get { } //Length: 5
		internal set { } //Length: 818
	}

	public virtual float Volume
	{
		 get { } //Length: 103
		 set { } //Length: 228
	}

	private static RemoteVoicePlayerState() { }

	internal RemoteVoicePlayerState(IVoicePlaybackInternal playback) { }

	public virtual float get_Amplitude() { }

	public virtual bool get_IsConnected() { }

	public virtual bool get_IsLocallyMuted() { }

	public virtual bool get_IsLocalPlayer() { }

	public virtual bool get_IsSpeaking() { }

	internal Nullable get_Jitter() { }

	public virtual Nullable get_PacketLoss() { }

	internal virtual IVoicePlaybackInternal get_PlaybackInternal() { }

	public virtual ReadOnlyCollection get_Rooms() { }

	public virtual Nullable get_SpeakerPriority() { }

	public virtual IDissonancePlayer get_Tracker() { }

	public virtual float get_Volume() { }

	public virtual void GetSpeakingChannels(List channels) { }

	internal virtual void InvokeOnEnteredRoom(RoomEvent evtData) { }

	internal virtual void InvokeOnExitedRoom(RoomEvent evtData) { }

	public virtual void set_IsLocallyMuted(bool value) { }

	internal virtual void set_Tracker(IDissonancePlayer value) { }

	public virtual void set_Volume(float value) { }

	internal virtual void Update() { }

}

