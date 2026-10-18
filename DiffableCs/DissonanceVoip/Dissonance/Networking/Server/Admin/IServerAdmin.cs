namespace Dissonance.Networking.Server.Admin;

public interface IServerAdmin
{

	public event Action ClientJoined
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action ClientLeft
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action VoicePacketSpoofed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ReadOnlyCollection Clients
	{
		 get { } //Length: 0
	}

	public bool EnableChannelMonitoring
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_ClientJoined(Action value) { }

	[CompilerGenerated]
	public void add_ClientLeft(Action value) { }

	[CompilerGenerated]
	public void add_VoicePacketSpoofed(Action value) { }

	public ReadOnlyCollection get_Clients() { }

	public bool get_EnableChannelMonitoring() { }

	[CompilerGenerated]
	public void remove_ClientJoined(Action value) { }

	[CompilerGenerated]
	public void remove_ClientLeft(Action value) { }

	[CompilerGenerated]
	public void remove_VoicePacketSpoofed(Action value) { }

	public void set_EnableChannelMonitoring(bool value) { }

}

