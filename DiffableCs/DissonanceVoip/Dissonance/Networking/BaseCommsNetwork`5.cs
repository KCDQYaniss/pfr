namespace Dissonance.Networking;

public abstract class BaseCommsNetwork`5 : MonoBehaviour, ICommsNetwork, ICommsNetworkState
{
	private class Idle : IState
	{
		private readonly BaseCommsNetwork _net; //Field offset: 0x0

		public override ConnectionStatus Status
		{
			 get { } //Length: 3
		}

		public Idle(BaseCommsNetwork net) { }

		public override void Enter() { }

		public override void Exit() { }

		public override ConnectionStatus get_Status() { }

		public override void Update() { }

	}

	private interface IState
	{

		public ConnectionStatus Status
		{
			 get { } //Length: 0
		}

		public void Enter() { }

		public void Exit() { }

		public ConnectionStatus get_Status() { }

		public void Update() { }

	}

	private class Session : IState
	{
		[CanBeNull]
		private readonly TClientParam _clientParameter; //Field offset: 0x0
		[CanBeNull]
		private readonly TServerParam _serverParameter; //Field offset: 0x0
		private readonly NetworkMode _mode; //Field offset: 0x0
		private readonly BaseCommsNetwork _net; //Field offset: 0x0
		private float _reconnectionAttemptInterval; //Field offset: 0x0
		private DateTime _lastReconnectionAttempt; //Field offset: 0x0

		public override ConnectionStatus Status
		{
			 get { } //Length: 167
		}

		public Session(BaseCommsNetwork net, NetworkMode mode, TServerParam serverParameter, TClientParam clientParameter) { }

		public override void Enter() { }

		public override void Exit() { }

		public override ConnectionStatus get_Status() { }

		private bool ShouldAttemptReconnect() { }

		private void StartClient() { }

		private void StartServer() { }

		public override void Update() { }

	}

	private readonly Queue _nextStates; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerEnteredRoom; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerStoppedSpeaking; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerStartedSpeaking; //Field offset: 0x0
	[CompilerGenerated]
	private Action TextPacketReceived; //Field offset: 0x0
	[CompilerGenerated]
	private Action VoicePacketReceived; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerLeft; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerJoined; //Field offset: 0x0
	[CompilerGenerated]
	private Action ModeChanged; //Field offset: 0x0
	[CompilerGenerated]
	private Action PlayerExitedRoom; //Field offset: 0x0
	[CompilerGenerated]
	private CodecSettings <CodecSettings>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private PlayerChannels <PlayerChannels>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Rooms <Rooms>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private string <PlayerName>k__BackingField; //Field offset: 0x0
	protected readonly Log Log; //Field offset: 0x0
	[CompilerGenerated]
	private TClient <Client>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TServer <Server>k__BackingField; //Field offset: 0x0
	private NetworkMode _mode; //Field offset: 0x0
	private IState _state; //Field offset: 0x0
	[CompilerGenerated]
	private RoomChannels <RoomChannels>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x0

	public override event Action ModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerEnteredRoom
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerExitedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerJoined
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerLeft
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerStartedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action PlayerStoppedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action TextPacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action VoicePacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected private TClient Client
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override CodecSettings CodecSettings
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override NetworkMode Mode
	{
		 get { } //Length: 4
		private set { } //Length: 43
	}

	public private override PlayerChannels PlayerChannels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override string PlayerName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override RoomChannels RoomChannels
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override Rooms Rooms
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private TServer Server
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[CanBeNull]
	public IServerAdmin ServerAdmin
	{
		 get { } //Length: 15
	}

	public override ConnectionStatus Status
	{
		 get { } //Length: 70
	}

	protected BaseCommsNetwork`5() { }

	[CompilerGenerated]
	public override void add_ModeChanged(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public override void add_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public override void add_TextPacketReceived(Action value) { }

	[CompilerGenerated]
	public override void add_VoicePacketReceived(Action value) { }

	private void ChangeState(IState newState) { }

	[NotNull]
	protected abstract TClient CreateClient(TClientParam connectionParameters) { }

	[NotNull]
	protected abstract TServer CreateServer(TServerParam connectionParameters) { }

	private override void Dissonance.Networking.ICommsNetwork.Initialize(string playerName, Rooms rooms, PlayerChannels playerChannels, RoomChannels roomChannels, CodecSettings codecSettings) { }

	[CompilerGenerated]
	protected TClient get_Client() { }

	[CompilerGenerated]
	public override CodecSettings get_CodecSettings() { }

	[CompilerGenerated]
	public bool get_IsInitialized() { }

	public override NetworkMode get_Mode() { }

	[CompilerGenerated]
	public override PlayerChannels get_PlayerChannels() { }

	[CompilerGenerated]
	public override string get_PlayerName() { }

	[CompilerGenerated]
	public override RoomChannels get_RoomChannels() { }

	[CompilerGenerated]
	public override Rooms get_Rooms() { }

	[CompilerGenerated]
	protected TServer get_Server() { }

	public IServerAdmin get_ServerAdmin() { }

	public override ConnectionStatus get_Status() { }

	protected override void Initialize() { }

	private void LoadState() { }

	protected override void OnDisable() { }

	public void OnInspectorGui() { }

	private void OnModeChanged(NetworkMode obj) { }

	private void OnPlayerEnteredRoom(RoomEvent evt) { }

	private void OnPlayerExitedRoom(RoomEvent evt) { }

	private void OnPlayerJoined(string obj, CodecSettings codecSettings) { }

	private void OnPlayerLeft(string obj) { }

	private void OnPlayerStartedSpeaking(string obj) { }

	private void OnPlayerStoppedSpeaking(string obj) { }

	private void OnTextPacketReceived(TextMessage obj) { }

	private void OnVoicePacketReceived(VoicePacket obj) { }

	[CompilerGenerated]
	public override void remove_ModeChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public override void remove_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public override void remove_TextPacketReceived(Action value) { }

	[CompilerGenerated]
	public override void remove_VoicePacketReceived(Action value) { }

	protected void RunAsClient(TClientParam clientParameters) { }

	protected void RunAsDedicatedServer(TServerParam serverParameters) { }

	protected void RunAsHost(TServerParam serverParameters, TClientParam clientParameters) { }

	public override void SendText(string data, ChannelType recipientType, string recipientId) { }

	public override void SendVoice(ArraySegment data) { }

	[CompilerGenerated]
	private void set_Client(TClient value) { }

	[CompilerGenerated]
	private void set_CodecSettings(CodecSettings value) { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	private void set_Mode(NetworkMode value) { }

	[CompilerGenerated]
	private void set_PlayerChannels(PlayerChannels value) { }

	[CompilerGenerated]
	private void set_PlayerName(string value) { }

	[CompilerGenerated]
	private void set_RoomChannels(RoomChannels value) { }

	[CompilerGenerated]
	private void set_Rooms(Rooms value) { }

	[CompilerGenerated]
	private void set_Server(TServer value) { }

	private void StartClient(TClientParam connectParams) { }

	private void StartServer(TServerParam connectParams) { }

	public void Stop() { }

	private void StopClient() { }

	private void StopServer() { }

	protected override void Update() { }

}

