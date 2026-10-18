namespace Dissonance.Networking.Client;

internal struct OpenChannel
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly ChannelProperties _config; //Field offset: 0x0
	private readonly ChannelType _type; //Field offset: 0x8
	private readonly ushort _recipient; //Field offset: 0xC
	private readonly string _name; //Field offset: 0x10
	private readonly bool _isClosing; //Field offset: 0x18
	private readonly ushort _sessionId; //Field offset: 0x1A
	private readonly bool _sent; //Field offset: 0x1C

	public float AmplitudeMultiplier
	{
		 get { } //Length: 27
	}

	public ushort Bitfield
	{
		 get { } //Length: 263
	}

	[NotNull]
	public ChannelProperties Config
	{
		 get { } //Length: 4
	}

	public bool IsClosing
	{
		 get { } //Length: 5
	}

	public bool IsPositional
	{
		 get { } //Length: 26
	}

	[NotNull]
	public string Name
	{
		 get { } //Length: 5
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 95
	}

	public ushort Recipient
	{
		 get { } //Length: 5
	}

	public ushort SessionId
	{
		 get { } //Length: 5
	}

	public ChannelType Type
	{
		 get { } //Length: 4
	}

	private static OpenChannel() { }

	public OpenChannel(ChannelType type, ushort sessionId, ChannelProperties config, bool closing, ushort recipient, string name, bool sent = false) { }

	[Pure]
	public OpenChannel AsClosing() { }

	[Pure]
	public OpenChannel AsOpen() { }

	[Pure]
	public OpenChannel AsSent() { }

	public float get_AmplitudeMultiplier() { }

	public ushort get_Bitfield() { }

	public ChannelProperties get_Config() { }

	public bool get_IsClosing() { }

	public bool get_IsPositional() { }

	public string get_Name() { }

	public ChannelPriority get_Priority() { }

	public ushort get_Recipient() { }

	public ushort get_SessionId() { }

	public ChannelType get_Type() { }

}

