namespace Dissonance.Networking.Client;

internal class EventQueue
{
	private enum EventType
	{
		PlayerJoined = 0,
		PlayerLeft = 1,
		PlayerEnteredRoom = 2,
		PlayerExitedRoom = 3,
		PlayerStartedSpeaking = 4,
		PlayerStoppedSpeaking = 5,
		VoiceData = 6,
		TextMessage = 7,
	}

	private struct NetworkEvent
	{
		public readonly EventType Type; //Field offset: 0x0
		private string _playerName; //Field offset: 0x8
		private CodecSettings _codecSettings; //Field offset: 0x10
		private string _room; //Field offset: 0x20
		private ReadOnlyCollection _allRooms; //Field offset: 0x28
		private readonly VoicePacket _voicePacket; //Field offset: 0x30
		private readonly TextMessage _textMessage; //Field offset: 0x68

		[NotNull]
		public ReadOnlyCollection AllRooms
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public CodecSettings CodecSettings
		{
			 get { } //Length: 19
			 set { } //Length: 16
		}

		public string PlayerName
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public string Room
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public TextMessage TextMessage
		{
			 get { } //Length: 19
		}

		public VoicePacket VoicePacket
		{
			 get { } //Length: 37
		}

		public NetworkEvent(EventType type) { }

		public NetworkEvent(VoicePacket voice) { }

		public NetworkEvent(TextMessage text) { }

		private void Check(EventType type) { }

		private void Check(EventType typeA, EventType typeB) { }

		public ReadOnlyCollection get_AllRooms() { }

		public CodecSettings get_CodecSettings() { }

		public string get_PlayerName() { }

		public string get_Room() { }

		public TextMessage get_TextMessage() { }

		public VoicePacket get_VoicePacket() { }

		public void set_AllRooms(ReadOnlyCollection value) { }

		public void set_CodecSettings(CodecSettings value) { }

		public void set_PlayerName(string value) { }

		public void set_Room(string value) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private const int MinWarnPacketCountThreshold = 12; //Field offset: 0x0
	private static readonly TimeSpan MinWarnDispatchTimeThreshold; //Field offset: 0x8
	private readonly ReadonlyLockedValue _queuedEvents; //Field offset: 0x10
	private readonly ReadonlyLockedValue _byteArrayPool; //Field offset: 0x18
	[NotNull]
	private readonly IRecycler _channelsListPool; //Field offset: 0x20
	[CompilerGenerated]
	private Action PlayerJoined; //Field offset: 0x28
	[CompilerGenerated]
	private Action PlayerLeft; //Field offset: 0x30
	[CompilerGenerated]
	private Action PlayerEnteredRoom; //Field offset: 0x38
	[CompilerGenerated]
	private Action PlayerExitedRoom; //Field offset: 0x40
	[CompilerGenerated]
	private Action VoicePacketReceived; //Field offset: 0x48
	[CompilerGenerated]
	private Action TextMessageReceived; //Field offset: 0x50
	[CompilerGenerated]
	private Action PlayerStartedSpeaking; //Field offset: 0x58
	[CompilerGenerated]
	private Action PlayerStoppedSpeaking; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnEnqueuePlayerLeft; //Field offset: 0x68
	private int _voicePacketWarnThreshold; //Field offset: 0x70
	private int _pendingVoicePackets; //Field offset: 0x74
	private DateTime _previousFlush; //Field offset: 0x78

	internal event Action OnEnqueuePlayerLeft
	{
		[CompilerGenerated]
		internal add { } //Length: 262
		[CompilerGenerated]
		internal remove { } //Length: 262
	}

	public event Action PlayerEnteredRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action PlayerExitedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action PlayerJoined
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action PlayerLeft
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action PlayerStartedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action PlayerStoppedSpeaking
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action TextMessageReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action VoicePacketReceived
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private static EventQueue() { }

	public EventQueue(ReadonlyLockedValue byteArrayPool, IRecycler channelsListPool) { }

	[CompilerGenerated]
	internal void add_OnEnqueuePlayerLeft(Action value) { }

	[CompilerGenerated]
	public void add_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void add_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void add_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public void add_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public void add_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public void add_TextMessageReceived(Action value) { }

	[CompilerGenerated]
	public void add_VoicePacketReceived(Action value) { }

	private static RoomEvent CreateRoomEvent(NetworkEvent event, bool joined) { }

	public bool DispatchEvents(Nullable utcNow = null) { }

	public void EnqueuePlayerEnteredRoom(string playerName, string room, ReadOnlyCollection allRooms) { }

	public void EnqueuePlayerExitedRoom(string playerName, string room, ReadOnlyCollection allRooms) { }

	public void EnqueuePlayerJoined(string playerName, CodecSettings codecSettings) { }

	public void EnqueuePlayerLeft(string playerName) { }

	public void EnqueueStartedSpeaking(string playerName) { }

	public void EnqueueStoppedSpeaking(string playerName) { }

	public void EnqueueTextData(TextMessage data) { }

	public void EnqueueVoiceData(VoicePacket data) { }

	public byte[] GetEventBuffer() { }

	private static bool InvokeEvent(T arg, Action handler) { }

	private static bool InvokeEvent(T1 arg1, T2 arg2, Action handler) { }

	private void PreDispatchLog(DateTime utcNow) { }

	[CompilerGenerated]
	internal void remove_OnEnqueuePlayerLeft(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerEnteredRoom(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerExitedRoom(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerJoined(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerLeft(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerStartedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_PlayerStoppedSpeaking(Action value) { }

	[CompilerGenerated]
	public void remove_TextMessageReceived(Action value) { }

	[CompilerGenerated]
	public void remove_VoicePacketReceived(Action value) { }

}

