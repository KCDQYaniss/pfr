namespace Dissonance;

public abstract class VoicePlayerState
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly string _name; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnStartedSpeaking; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnStoppedSpeaking; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnEnteredRoom; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnExitedRoom; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnLeftSession; //Field offset: 0x38

	public event Action OnEnteredRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnExitedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnLeftSession
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStartedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnStoppedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public abstract float Amplitude
	{
		 get { } //Length: 0
	}

	public abstract bool IsConnected
	{
		 get { } //Length: 0
	}

	public abstract bool IsLocallyMuted
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool IsLocalPlayer
	{
		 get { } //Length: 0
	}

	public abstract bool IsSpeaking
	{
		 get { } //Length: 0
	}

	[NotNull]
	public string Name
	{
		 get { } //Length: 5
	}

	[CanBeNull]
	public abstract Nullable PacketLoss
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public IVoicePlayback Playback
	{
		 get { } //Length: 20
	}

	[CanBeNull]
	internal abstract IVoicePlaybackInternal PlaybackInternal
	{
		internal get { } //Length: 0
	}

	[NotNull]
	public abstract ReadOnlyCollection Rooms
	{
		 get { } //Length: 0
	}

	public abstract Nullable SpeakerPriority
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public internal abstract IDissonancePlayer Tracker
	{
		 get { } //Length: 0
		internal set { } //Length: 0
	}

	public abstract float Volume
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	private static VoicePlayerState() { }

	internal VoicePlayerState(string name) { }

	[CompilerGenerated]
	public void add_OnEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void add_OnExitedRoom(Action value) { }

	[CompilerGenerated]
	public void add_OnLeftSession(Action value) { }

	[CompilerGenerated]
	public void add_OnStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_OnStoppedSpeaking(Action value) { }

	public abstract float get_Amplitude() { }

	public abstract bool get_IsConnected() { }

	public abstract bool get_IsLocallyMuted() { }

	public abstract bool get_IsLocalPlayer() { }

	public abstract bool get_IsSpeaking() { }

	public string get_Name() { }

	public abstract Nullable get_PacketLoss() { }

	public IVoicePlayback get_Playback() { }

	internal abstract IVoicePlaybackInternal get_PlaybackInternal() { }

	public abstract ReadOnlyCollection get_Rooms() { }

	public abstract Nullable get_SpeakerPriority() { }

	public abstract IDissonancePlayer get_Tracker() { }

	public abstract float get_Volume() { }

	public abstract void GetSpeakingChannels(List output) { }

	internal override void InvokeOnEnteredRoom(RoomEvent evtData) { }

	internal override void InvokeOnExitedRoom(RoomEvent evtData) { }

	internal void InvokeOnLeftSession() { }

	internal void InvokeOnStartedSpeaking() { }

	internal void InvokeOnStoppedSpeaking() { }

	[CompilerGenerated]
	public void remove_OnEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void remove_OnExitedRoom(Action value) { }

	[CompilerGenerated]
	public void remove_OnLeftSession(Action value) { }

	[CompilerGenerated]
	public void remove_OnStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_OnStoppedSpeaking(Action value) { }

	public abstract void set_IsLocallyMuted(bool value) { }

	internal abstract void set_Tracker(IDissonancePlayer value) { }

	public abstract void set_Volume(float value) { }

	internal abstract void Update() { }

}

