namespace Dissonance.Networking;

public abstract class BaseServer`3 : IServer
{
	protected readonly Log Log; //Field offset: 0x0
	private bool _disconnected; //Field offset: 0x0
	private bool _error; //Field offset: 0x0
	[CompilerGenerated]
	private TrafficCounter <RecvHandshakeRequest>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TrafficCounter <RecvClientState>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TrafficCounter <RecvPacketRelay>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TrafficCounter <RecvDeltaChannelState>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TrafficCounter <SentTraffic>k__BackingField; //Field offset: 0x0
	private readonly ServerRelay _relay; //Field offset: 0x0
	private readonly BroadcastingClientCollection _clients; //Field offset: 0x0
	private readonly uint _sessionId; //Field offset: 0x0
	private readonly ServerAdmin serverAdmin; //Field offset: 0x0

	internal TrafficCounter RecvClientState
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal TrafficCounter RecvDeltaChannelState
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal TrafficCounter RecvHandshakeRequest
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal TrafficCounter RecvPacketRelay
	{
		[CompilerGenerated]
		internal get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal TrafficCounter SentTraffic
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[NotNull]
	public IServerAdmin ServerAdmin
	{
		 get { } //Length: 5
	}

	public override uint SessionId
	{
		 get { } //Length: 4
	}

	protected BaseServer`3() { }

	protected override void AddClient(ClientInfo client) { }

	private bool CheckSessionId(ref PacketReader reader, TPeer source) { }

	protected void ClientDisconnected(TPeer connection) { }

	public override void Connect() { }

	public override void Disconnect() { }

	private override void Dissonance.Networking.Server.IServer<TPeer>.AddClient(ClientInfo client) { }

	private override void Dissonance.Networking.Server.IServer<TPeer>.SendReliable(List connections, ArraySegment packet) { }

	private override void Dissonance.Networking.Server.IServer<TPeer>.SendReliable(TPeer connection, ArraySegment packet) { }

	private override void Dissonance.Networking.Server.IServer<TPeer>.SendUnreliable(List connections, ArraySegment packet) { }

	protected void FatalError(string reason) { }

	[CompilerGenerated]
	internal TrafficCounter get_RecvClientState() { }

	[CompilerGenerated]
	internal TrafficCounter get_RecvDeltaChannelState() { }

	[CompilerGenerated]
	internal TrafficCounter get_RecvHandshakeRequest() { }

	[CompilerGenerated]
	internal TrafficCounter get_RecvPacketRelay() { }

	[CompilerGenerated]
	internal TrafficCounter get_SentTraffic() { }

	public IServerAdmin get_ServerAdmin() { }

	public override uint get_SessionId() { }

	public void NetworkReceivedPacket(TPeer source, ArraySegment data) { }

	protected abstract void ReadMessages() { }

	private bool RunUpdate() { }

	protected abstract void SendReliable(TPeer connection, ArraySegment packet) { }

	public override void SendReliable(List connections, ArraySegment packet) { }

	public override void SendUnreliable(List connections, ArraySegment packet) { }

	protected abstract void SendUnreliable(TPeer connection, ArraySegment packet) { }

	[CompilerGenerated]
	private void set_RecvClientState(TrafficCounter value) { }

	[CompilerGenerated]
	private void set_RecvDeltaChannelState(TrafficCounter value) { }

	[CompilerGenerated]
	private void set_RecvHandshakeRequest(TrafficCounter value) { }

	[CompilerGenerated]
	private void set_RecvPacketRelay(TrafficCounter value) { }

	[CompilerGenerated]
	private void set_SentTraffic(TrafficCounter value) { }

	public override ServerState Update() { }

}

