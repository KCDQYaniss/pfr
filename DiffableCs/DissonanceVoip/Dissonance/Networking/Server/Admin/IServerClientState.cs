namespace Dissonance.Networking.Server.Admin;

public interface IServerClientState
{

	public event Action OnStartedListeningToRoom
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnStoppedListeningToRoom
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ReadOnlyCollection Channels
	{
		 get { } //Length: 0
	}

	public bool IsConnected
	{
		 get { } //Length: 0
	}

	public DateTime LastChannelUpdateUtc
	{
		 get { } //Length: 0
	}

	[NotNull]
	public string Name
	{
		 get { } //Length: 0
	}

	public ReadOnlyCollection Rooms
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnStartedListeningToRoom(Action value) { }

	[CompilerGenerated]
	public void add_OnStoppedListeningToRoom(Action value) { }

	public ReadOnlyCollection get_Channels() { }

	public bool get_IsConnected() { }

	public DateTime get_LastChannelUpdateUtc() { }

	public string get_Name() { }

	public ReadOnlyCollection get_Rooms() { }

	[CompilerGenerated]
	public void remove_OnStartedListeningToRoom(Action value) { }

	[CompilerGenerated]
	public void remove_OnStoppedListeningToRoom(Action value) { }

	public void RemoveFromRoom(string roomName) { }

	public void Reset() { }

}

