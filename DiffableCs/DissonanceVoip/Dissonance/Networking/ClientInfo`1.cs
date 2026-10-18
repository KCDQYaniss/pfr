namespace Dissonance.Networking;

public class ClientInfo`1 : IEquatable
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly string _playerName; //Field offset: 0x0
	private readonly ushort _playerId; //Field offset: 0x0
	private readonly CodecSettings _codecSettings; //Field offset: 0x0
	private readonly List _rooms; //Field offset: 0x0
	private readonly ReadOnlyCollection _roomsReadonly; //Field offset: 0x0
	[CompilerGenerated]
	private TPeer <Connection>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private PeerVoiceReceiver <VoiceReceiver>k__BackingField; //Field offset: 0x0

	public CodecSettings CodecSettings
	{
		 get { } //Length: 19
	}

	[CanBeNull]
	public internal TPeer Connection
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public internal bool IsConnected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public ushort PlayerId
	{
		 get { } //Length: 5
	}

	[NotNull]
	public string PlayerName
	{
		 get { } //Length: 5
	}

	[NotNull]
	internal ReadOnlyCollection Rooms
	{
		internal get { } //Length: 76
	}

	internal PeerVoiceReceiver VoiceReceiver
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	private static ClientInfo`1() { }

	public ClientInfo`1(string playerName, ushort playerId, CodecSettings codecSettings, TPeer connection) { }

	public bool AddRoom(string roomName) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ClientInfo other) { }

	public CodecSettings get_CodecSettings() { }

	[CompilerGenerated]
	public TPeer get_Connection() { }

	[CompilerGenerated]
	public bool get_IsConnected() { }

	public ushort get_PlayerId() { }

	public string get_PlayerName() { }

	internal ReadOnlyCollection get_Rooms() { }

	[CompilerGenerated]
	internal PeerVoiceReceiver get_VoiceReceiver() { }

	public virtual int GetHashCode() { }

	public bool RemoveRoom(string roomName) { }

	[CompilerGenerated]
	internal void set_Connection(TPeer value) { }

	[CompilerGenerated]
	internal void set_IsConnected(bool value) { }

	[CompilerGenerated]
	internal void set_VoiceReceiver(PeerVoiceReceiver value) { }

	public virtual string ToString() { }

}

