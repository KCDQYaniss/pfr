namespace Dissonance.Networking;

internal struct ChannelBitField
{
	private const ushort TypeMask = 1; //Field offset: 0x0
	private const ushort PositionalMask = 2; //Field offset: 0x0
	private const ushort ClosureMask = 4; //Field offset: 0x0
	private const ushort PriorityOffset = 3; //Field offset: 0x0
	private const ushort PriorityMask = 24; //Field offset: 0x0
	private const ushort SessionIdOffset = 5; //Field offset: 0x0
	private const ushort SessionIdMask = 97; //Field offset: 0x0
	private const ushort AmplitudeOffset = 8; //Field offset: 0x0
	private const ushort AmplitudeMask = 65280; //Field offset: 0x0
	private readonly ushort _bitfield; //Field offset: 0x0

	public float AmplitudeMultiplier
	{
		 get { } //Length: 24
	}

	public ushort Bitfield
	{
		 get { } //Length: 4
	}

	public bool IsClosing
	{
		 get { } //Length: 9
	}

	public bool IsPositional
	{
		 get { } //Length: 8
	}

	public ChannelPriority Priority
	{
		 get { } //Length: 45
	}

	public int SessionId
	{
		 get { } //Length: 10
	}

	public ChannelType Type
	{
		 get { } //Length: 10
	}

	public ChannelBitField(ushort bitfield) { }

	public ChannelBitField(ChannelType type, int sessionId, ChannelPriority priority, float amplitudeMult, bool positional, bool closing) { }

	public float get_AmplitudeMultiplier() { }

	public ushort get_Bitfield() { }

	public bool get_IsClosing() { }

	public bool get_IsPositional() { }

	public ChannelPriority get_Priority() { }

	public int get_SessionId() { }

	public ChannelType get_Type() { }

	private static ushort PackPriority(ChannelPriority priority) { }

}

