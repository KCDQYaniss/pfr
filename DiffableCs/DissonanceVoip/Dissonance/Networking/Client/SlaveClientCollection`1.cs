namespace Dissonance.Networking.Client;

internal class SlaveClientCollection`1 : BaseClientCollection
{
	private readonly ISendQueue _sender; //Field offset: 0x0
	private readonly ISession _session; //Field offset: 0x0
	private readonly EventQueue _events; //Field offset: 0x0
	private readonly Rooms _localRooms; //Field offset: 0x0
	private readonly string _playerName; //Field offset: 0x0
	private readonly CodecSettings _codecSettings; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnClientIntroducedP2P; //Field offset: 0x0
	private readonly List _pendingIntroductions; //Field offset: 0x0

	public event Action OnClientIntroducedP2P
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public SlaveClientCollection`1(ISendQueue sender, ISession session, EventQueue events, Rooms localRooms, string playerName, CodecSettings codecSettings) { }

	[CompilerGenerated]
	public void add_OnClientIntroducedP2P(Action value) { }

	public void IntroduceP2P(ushort id, TPeer connection) { }

	protected virtual void OnAddedClient(ClientInfo client) { }

	protected virtual void OnClientEnteredRoom(ClientInfo client, string room) { }

	protected virtual void OnClientExitedRoom(ClientInfo client, string room) { }

	protected virtual void OnRemovedClient(ClientInfo client) { }

	public void ProcessRemoveClient(ref PacketReader reader) { }

	public void ReceiveHandshakeResponseBody(ref PacketReader reader) { }

	[CompilerGenerated]
	public void remove_OnClientIntroducedP2P(Action value) { }

	private void SendClientState() { }

	private void SendJoinRoom(string room) { }

	private void SendLeaveRoom(string room) { }

	public virtual void Stop() { }

	private bool TryIntroduceP2P(ushort id, TPeer connection) { }

}

