namespace Dissonance.Networking.Server.Admin;

internal class ServerClientState`3 : IServerClientState
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly TServer _server; //Field offset: 0x0
	private readonly ClientInfo _peer; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnStartedListeningToRoom; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnStoppedListeningToRoom; //Field offset: 0x0
	private readonly List _rooms; //Field offset: 0x0
	private readonly ReadOnlyCollection _roomsReadonly; //Field offset: 0x0
	private readonly List _channels; //Field offset: 0x0
	private readonly ReadOnlyCollection _channelsReadonly; //Field offset: 0x0
	[CompilerGenerated]
	private DateTime <LastChannelUpdateUtc>k__BackingField; //Field offset: 0x0

	public override event Action OnStartedListeningToRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnStoppedListeningToRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override ReadOnlyCollection Channels
	{
		 get { } //Length: 5
	}

	public override bool IsConnected
	{
		 get { } //Length: 27
	}

	public private override DateTime LastChannelUpdateUtc
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override string Name
	{
		 get { } //Length: 27
	}

	public ClientInfo Peer
	{
		 get { } //Length: 5
	}

	public override ReadOnlyCollection Rooms
	{
		 get { } //Length: 5
	}

	private static ServerClientState`3() { }

	public ServerClientState`3(TServer server, ClientInfo peer) { }

	[CompilerGenerated]
	public override void add_OnStartedListeningToRoom(Action value) { }

	[CompilerGenerated]
	public override void add_OnStoppedListeningToRoom(Action value) { }

	public override ReadOnlyCollection get_Channels() { }

	public override bool get_IsConnected() { }

	[CompilerGenerated]
	public override DateTime get_LastChannelUpdateUtc() { }

	public override string get_Name() { }

	public ClientInfo get_Peer() { }

	public override ReadOnlyCollection get_Rooms() { }

	public void InvokeOnEnteredRoom(string name) { }

	public void InvokeOnExitedRoom(string name) { }

	[CompilerGenerated]
	public override void remove_OnStartedListeningToRoom(Action value) { }

	[CompilerGenerated]
	public override void remove_OnStoppedListeningToRoom(Action value) { }

	public override void RemoveFromRoom(string roomName) { }

	public override void Reset() { }

	[CompilerGenerated]
	private void set_LastChannelUpdateUtc(DateTime value) { }

	public void UpdateChannels(List channels) { }

}

