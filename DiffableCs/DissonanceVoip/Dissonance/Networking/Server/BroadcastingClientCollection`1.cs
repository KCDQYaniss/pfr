namespace Dissonance.Networking.Server;

internal class BroadcastingClientCollection`1 : BaseClientCollection
{
	private readonly IServer _server; //Field offset: 0x0
	private readonly byte[] _tmpSendBuffer; //Field offset: 0x0
	private readonly List _tmpConnectionBuffer; //Field offset: 0x0
	private readonly List _tmpClientBuffer; //Field offset: 0x0
	private readonly List _tmpClientBufferHandshake; //Field offset: 0x0
	private readonly Dictionary _tmpClientByRoomsBufferHandshake; //Field offset: 0x0

	public BroadcastingClientCollection`1(IServer server) { }

	private void Broadcast(ArraySegment packet) { }

	protected virtual void OnAddedClient(ClientInfo client) { }

	protected virtual void OnRemovedClient(ClientInfo client) { }

	public virtual void ProcessClientState(TPeer source, ref PacketReader reader) { }

	public virtual void ProcessDeltaChannelState(ref PacketReader reader) { }

	public void ProcessHandshakeRequest(TPeer source, ref PacketReader reader) { }

	public void RemoveClient(TPeer connection) { }

	private void SendFakeClientState(TPeer destination, ClientInfo clientInfo) { }

}

