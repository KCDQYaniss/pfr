namespace Dissonance.Networking.Client;

internal struct VoicePacketOptions
{
	private const byte EXTENDED_RANGE_FLAG = 128; //Field offset: 0x0
	private readonly byte _bitfield; //Field offset: 0x0

	public byte Bitfield
	{
		 get { } //Length: 4
	}

	public byte ChannelSession
	{
		 get { } //Length: 6
	}

	public int ChannelSessionRange
	{
		 get { } //Length: 17
	}

	public bool IsChannelSessionExtendedRange
	{
		 get { } //Length: 7
	}

	private VoicePacketOptions(byte bitfield) { }

	public byte get_Bitfield() { }

	public byte get_ChannelSession() { }

	public int get_ChannelSessionRange() { }

	public bool get_IsChannelSessionExtendedRange() { }

	public static VoicePacketOptions Pack(byte channelSession) { }

	public static VoicePacketOptions Unpack(byte bitfield) { }

}

