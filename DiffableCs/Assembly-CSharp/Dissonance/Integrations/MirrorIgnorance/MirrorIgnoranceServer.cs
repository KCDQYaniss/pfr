namespace Dissonance.Integrations.MirrorIgnorance;

public class MirrorIgnoranceServer : BaseServer
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__NullMessageReceivedHandler; //Field offset: 0x0

	}

	[NotNull]
	private readonly MirrorIgnoranceCommsNetwork _network; //Field offset: 0x68
	private readonly NetworkWriter _sendWriter; //Field offset: 0x70
	private readonly byte[] _receiveBuffer; //Field offset: 0x78
	private readonly List _addedConnections; //Field offset: 0x80

	public MirrorIgnoranceServer(MirrorIgnoranceCommsNetwork network) { }

	protected virtual void AddClient(ClientInfo client) { }

	public virtual void Connect() { }

	public virtual void Disconnect() { }

	private void OnMessageReceivedHandler(NetworkMessage netmsg) { }

	protected virtual void ReadMessages() { }

	private bool Send(ArraySegment packet, MirrorConn connection, NetworkChannel channel) { }

	protected virtual void SendReliable(MirrorConn connection, ArraySegment packet) { }

	protected virtual void SendUnreliable(MirrorConn connection, ArraySegment packet) { }

	public virtual ServerState Update() { }

}

