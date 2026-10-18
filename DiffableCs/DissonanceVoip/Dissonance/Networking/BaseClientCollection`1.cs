namespace Dissonance.Networking;

internal class BaseClientCollection`1 : IClientCollection
{
	protected readonly Log Log; //Field offset: 0x0
	protected readonly ClientIdCollection PlayerIds; //Field offset: 0x0
	protected readonly RoomClientsCollection ClientsInRooms; //Field offset: 0x0
	private readonly Dictionary _clientsByPlayerId; //Field offset: 0x0
	private readonly Dictionary _clientsByName; //Field offset: 0x0
	private readonly List _tmpRoomList; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnClientJoined; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnClientLeft; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnClientEnteredRoomEvent; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnClientExitedRoomEvent; //Field offset: 0x0

	public event Action OnClientEnteredRoomEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnClientExitedRoomEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnClientJoined
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnClientLeft
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	protected BaseClientCollection`1() { }

	[CompilerGenerated]
	public void add_OnClientEnteredRoomEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnClientExitedRoomEvent(Action value) { }

	[CompilerGenerated]
	public void add_OnClientJoined(Action value) { }

	[CompilerGenerated]
	public void add_OnClientLeft(Action value) { }

	protected void ClearRooms() { }

	protected void GetClients(List output) { }

	[NotNull]
	protected ClientInfo GetOrCreateClientInfo(ushort id, string name, CodecSettings codecSettings, TPeer connection) { }

	protected void JoinRoom(string room, ClientInfo client) { }

	private void LeaveRoom(string room, ClientInfo client) { }

	protected override void OnAddedClient(ClientInfo client) { }

	protected override void OnClientEnteredRoom(ClientInfo client, string room) { }

	protected override void OnClientExitedRoom(ClientInfo client, string room) { }

	protected override void OnRemovedClient(ClientInfo client) { }

	public override void ProcessClientState(TPeer source, ref PacketReader reader) { }

	public override void ProcessDeltaChannelState(ref PacketReader reader) { }

	[CompilerGenerated]
	public void remove_OnClientEnteredRoomEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnClientExitedRoomEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OnClientJoined(Action value) { }

	[CompilerGenerated]
	public void remove_OnClientLeft(Action value) { }

	protected void RemoveClient(ClientInfo client) { }

	public override void Stop() { }

	[ContractAnnotation("=> true, info:notnull; => false, info:null")]
	protected bool TryFindClientByConnection(TPeer connection, out ClientInfo info) { }

	[ContractAnnotation("=> true, info:notnull; => false, info:null")]
	public override bool TryGetClientInfoById(ushort player, out ClientInfo info) { }

	[ContractAnnotation("=> true, info:notnull; => false, info:null")]
	public override bool TryGetClientInfoByName(string name, out ClientInfo info) { }

	public override bool TryGetClientsInRoom(string room, out List clients) { }

	public override bool TryGetClientsInRoom(ushort roomId, out List clients) { }

}

