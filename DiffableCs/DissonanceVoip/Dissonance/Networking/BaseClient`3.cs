namespace Dissonance.Networking;

public abstract class BaseClient`3 : IClient
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__62_0; //Field offset: 0x0
		public static Func <>9__62_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal byte[] <.ctor>b__62_0() { }

		internal List <.ctor>b__62_1() { }

	}

	protected readonly Log Log; //Field offset: 0x0
	private readonly TrafficCounter _recvClientState; //Field offset: 0x0
	private readonly TrafficCounter _recvHandshakeP2P; //Field offset: 0x0
	private readonly TrafficCounter _recvHandshakeResponse; //Field offset: 0x0
	private readonly TrafficCounter _recvTextData; //Field offset: 0x0
	private readonly TrafficCounter _recvVoiceData; //Field offset: 0x0
	private readonly TrafficCounter _recvRemoveClient; //Field offset: 0x0
	private readonly TextSender _textSender; //Field offset: 0x0
	private readonly TextReceiver _textReceiver; //Field offset: 0x0
	private readonly VoiceSender _voiceSender; //Field offset: 0x0
	private readonly VoiceReceiver _voiceReceiver; //Field offset: 0x0
	private readonly PacketDelaySimulator _lossSimulator; //Field offset: 0x0
	private readonly SendQueue _sendQueue; //Field offset: 0x0
	private readonly ConnectionNegotiator _serverNegotiator; //Field offset: 0x0
	private readonly SlaveClientCollection _peers; //Field offset: 0x0
	private readonly EventQueue _events; //Field offset: 0x0
	private bool _error; //Field offset: 0x0
	private bool _disconnected; //Field offset: 0x0
	private readonly TrafficCounter _recvDeltaState; //Field offset: 0x0
	private readonly TrafficCounter _sentServer; //Field offset: 0x0

	public event Action PlayerEnteredRoom
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action PlayerExitedRoom
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action PlayerJoined
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action PlayerLeft
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action PlayerStartedSpeaking
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action PlayerStoppedSpeaking
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action TextMessageReceived
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action VoicePacketReceived
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public bool IsConnected
	{
		 get { } //Length: 49
	}

	[NotNull]
	internal TrafficCounter RecvClientState
	{
		internal get { } //Length: 8
	}

	[NotNull]
	internal TrafficCounter RecvDeltaState
	{
		internal get { } //Length: 8
	}

	[NotNull]
	internal TrafficCounter RecvHandshakeP2P
	{
		internal get { } //Length: 8
	}

	[NotNull]
	internal TrafficCounter RecvHandshakeResponse
	{
		internal get { } //Length: 8
	}

	[NotNull]
	internal TrafficCounter RecvRemoveClient
	{
		internal get { } //Length: 5
	}

	[NotNull]
	internal TrafficCounter RecvTextData
	{
		internal get { } //Length: 5
	}

	[NotNull]
	internal TrafficCounter RecvVoiceData
	{
		internal get { } //Length: 5
	}

	[NotNull]
	internal TrafficCounter SentServerTraffic
	{
		internal get { } //Length: 8
	}

	protected BaseClient`3(ICommsNetworkState network) { }

	public void add_PlayerEnteredRoom(Action value) { }

	public void add_PlayerExitedRoom(Action value) { }

	public void add_PlayerJoined(Action value) { }

	public void add_PlayerLeft(Action value) { }

	public void add_PlayerStartedSpeaking(Action value) { }

	public void add_PlayerStoppedSpeaking(Action value) { }

	public void add_TextMessageReceived(Action value) { }

	public void add_VoicePacketReceived(Action value) { }

	private bool CheckSessionId(ref PacketReader reader, MessageTypes type) { }

	public abstract void Connect() { }

	protected void Connected() { }

	public override void Disconnect() { }

	private override void Dissonance.Networking.Client.IClient<TPeer>.SendReliable(ArraySegment packet) { }

	private override void Dissonance.Networking.Client.IClient<TPeer>.SendReliableP2P(List destinations, ArraySegment packet) { }

	private override void Dissonance.Networking.Client.IClient<TPeer>.SendUnreliable(ArraySegment packet) { }

	private override void Dissonance.Networking.Client.IClient<TPeer>.SendUnreliableP2P(List destinations, ArraySegment packet) { }

	protected void FatalError(string reason) { }

	public bool get_IsConnected() { }

	internal TrafficCounter get_RecvClientState() { }

	internal TrafficCounter get_RecvDeltaState() { }

	internal TrafficCounter get_RecvHandshakeP2P() { }

	internal TrafficCounter get_RecvHandshakeResponse() { }

	internal TrafficCounter get_RecvRemoveClient() { }

	internal TrafficCounter get_RecvTextData() { }

	internal TrafficCounter get_RecvVoiceData() { }

	internal TrafficCounter get_SentServerTraffic() { }

	public Nullable NetworkReceivedPacket(ArraySegment data) { }

	protected override void OnAddedClient(ClientInfo client) { }

	protected override void OnMetClient(ClientInfo client) { }

	protected override void OnServerAssignedSessionId(uint session, ushort id) { }

	private Nullable ProcessReceivedPacket(ArraySegment data) { }

	protected abstract void ReadMessages() { }

	protected void ReceiveHandshakeP2P(ushort id, TPeer connection) { }

	public void remove_PlayerEnteredRoom(Action value) { }

	public void remove_PlayerExitedRoom(Action value) { }

	public void remove_PlayerJoined(Action value) { }

	public void remove_PlayerLeft(Action value) { }

	public void remove_PlayerStartedSpeaking(Action value) { }

	public void remove_PlayerStoppedSpeaking(Action value) { }

	public void remove_TextMessageReceived(Action value) { }

	public void remove_VoicePacketReceived(Action value) { }

	private bool RunUpdate(DateTime utcNow) { }

	protected abstract void SendReliable(ArraySegment packet) { }

	protected override void SendReliableP2P(List destinations, ArraySegment packet) { }

	public void SendTextData(string data, ChannelType type, string recipient) { }

	protected abstract void SendUnreliable(ArraySegment packet) { }

	protected override void SendUnreliableP2P(List destinations, ArraySegment packet) { }

	public override void SendVoiceData(ArraySegment encodedAudio) { }

	public override ClientStatus Update() { }

	[NotNull]
	protected static byte[] WriteHandshakeP2P(uint sessionId, ushort clientId) { }

}

