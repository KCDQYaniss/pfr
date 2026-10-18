namespace Dissonance.Networking.Client;

internal class ConnectionNegotiator`1 : ISession
{
	private static readonly Log Log; //Field offset: 0x0
	private static readonly TimeSpan HandshakeRequestInterval; //Field offset: 0x0
	private readonly ISendQueue _sender; //Field offset: 0x0
	private readonly string _playerName; //Field offset: 0x0
	private readonly CodecSettings _codecSettings; //Field offset: 0x0
	private DateTime _lastHandshakeRequest; //Field offset: 0x0
	private bool _running; //Field offset: 0x0
	private int _connectionStateValue; //Field offset: 0x0
	[CompilerGenerated]
	private uint <SessionId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Nullable <LocalId>k__BackingField; //Field offset: 0x0

	public private override Nullable LocalId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override string LocalName
	{
		 get { } //Length: 5
	}

	public private override uint SessionId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ConnectionState State
	{
		 get { } //Length: 4
	}

	private static ConnectionNegotiator`1() { }

	public ConnectionNegotiator`1(ISendQueue sender, string playerName, CodecSettings codecSettings) { }

	[CompilerGenerated]
	public override Nullable get_LocalId() { }

	public override string get_LocalName() { }

	[CompilerGenerated]
	public override uint get_SessionId() { }

	public ConnectionState get_State() { }

	public void ReceiveHandshakeResponseHeader(ref PacketReader reader) { }

	private void SendHandshake(DateTime utcNow) { }

	[CompilerGenerated]
	private void set_LocalId(Nullable value) { }

	[CompilerGenerated]
	private void set_SessionId(uint value) { }

	public void Start() { }

	public void Stop() { }

	public void Update(DateTime utcNow) { }

}

