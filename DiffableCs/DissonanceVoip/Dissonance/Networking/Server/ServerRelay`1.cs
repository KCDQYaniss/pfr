namespace Dissonance.Networking.Server;

internal class ServerRelay`1
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly IServer _server; //Field offset: 0x0
	private readonly BaseClientCollection _peers; //Field offset: 0x0
	private readonly List _tmpPeerBuffer; //Field offset: 0x0
	private readonly List _tmpIdBuffer; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnRelayingPacket; //Field offset: 0x0

	public event Action OnRelayingPacket
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private static ServerRelay`1() { }

	public ServerRelay`1(IServer server, BaseClientCollection peers) { }

	[CompilerGenerated]
	public void add_OnRelayingPacket(Action value) { }

	public void ProcessPacketRelay(ref PacketReader reader, bool reliable, TPeer source) { }

	[CompilerGenerated]
	public void remove_OnRelayingPacket(Action value) { }

}

