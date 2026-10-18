namespace Dissonance.Networking.Server.Admin;

internal class ServerAdmin`3 : IServerAdmin
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly TServer _server; //Field offset: 0x0
	private readonly Dictionary _knownRoomNames; //Field offset: 0x0
	[CompilerGenerated]
	private Action ClientJoined; //Field offset: 0x0
	[CompilerGenerated]
	private Action ClientLeft; //Field offset: 0x0
	[CompilerGenerated]
	private Action VoicePacketSpoofed; //Field offset: 0x0
	private readonly List _clients; //Field offset: 0x0
	private readonly ReadOnlyCollection _readonlyClients; //Field offset: 0x0
	private readonly List _channelsTmp; //Field offset: 0x0
	[CompilerGenerated]
	private bool <EnableChannelMonitoring>k__BackingField; //Field offset: 0x0

	public override event Action ClientJoined
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action ClientLeft
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action VoicePacketSpoofed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override ReadOnlyCollection Clients
	{
		 get { } //Length: 5
	}

	public override bool EnableChannelMonitoring
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static ServerAdmin`3() { }

	public ServerAdmin`3(TServer server) { }

	[CompilerGenerated]
	public override void add_ClientJoined(Action value) { }

	[CompilerGenerated]
	public override void add_ClientLeft(Action value) { }

	[CompilerGenerated]
	public override void add_VoicePacketSpoofed(Action value) { }

	[CanBeNull]
	private ServerClientState FindPlayer(ushort id) { }

	[CanBeNull]
	private ServerClientState FindPlayer(TPeer peer) { }

	[CanBeNull]
	private ServerClientState FindPlayer(ClientInfo peer) { }

	public override ReadOnlyCollection get_Clients() { }

	[CompilerGenerated]
	public override bool get_EnableChannelMonitoring() { }

	public void InvokeOnClientEnteredRoom(ClientInfo peer, string name) { }

	public void InvokeOnClientExitedRoom(ClientInfo peer, string name) { }

	public void InvokeOnClientJoined(ClientInfo peer) { }

	public void InvokeOnClientLeft(ClientInfo peer) { }

	public void InvokeOnRelayingPacket(ArraySegment payload, TPeer source) { }

	private void InvokeOnVoicePacketSpoof(IServerClientState spoofer, IServerClientState spoofee) { }

	[CompilerGenerated]
	public override void remove_ClientJoined(Action value) { }

	[CompilerGenerated]
	public override void remove_ClientLeft(Action value) { }

	[CompilerGenerated]
	public override void remove_VoicePacketSpoofed(Action value) { }

	[CompilerGenerated]
	public override void set_EnableChannelMonitoring(bool value) { }

}

