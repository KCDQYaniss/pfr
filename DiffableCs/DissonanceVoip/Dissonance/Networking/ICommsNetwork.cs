namespace Dissonance.Networking;

[Obfuscation(Exclude = True, ApplyToMembers = True)]
public interface ICommsNetwork
{

	public event Action ModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerEnteredRoom
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerExitedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerJoined
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerLeft
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerStartedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action PlayerStoppedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action TextPacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action VoicePacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public NetworkMode Mode
	{
		 get { } //Length: 0
	}

	public ConnectionStatus Status
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ModeChanged(Action value) { }

	[CompilerGenerated]
	public void add_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void add_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void add_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public void add_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public void add_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_TextPacketReceived(Action value) { }

	[CompilerGenerated]
	public void add_VoicePacketReceived(Action value) { }

	public NetworkMode get_Mode() { }

	public ConnectionStatus get_Status() { }

	public void Initialize(string playerName, Rooms rooms, PlayerChannels playerChannels, RoomChannels roomChannels, CodecSettings codecSettings) { }

	[CompilerGenerated]
	public void remove_ModeChanged(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_TextPacketReceived(Action value) { }

	[CompilerGenerated]
	public void remove_VoicePacketReceived(Action value) { }

	public void SendText(string data, ChannelType recipientType, string recipientId) { }

	public void SendVoice(ArraySegment data) { }

}

