namespace Dissonance.Networking;

internal struct PacketReader
{
	private static readonly Log Log; //Field offset: 0x0
	private readonly ArraySegment _array; //Field offset: 0x0
	private int _count; //Field offset: 0x10

	public ArraySegment All
	{
		 get { } //Length: 10
	}

	public ArraySegment Read
	{
		 get { } //Length: 226
	}

	public ArraySegment Unread
	{
		 get { } //Length: 257
	}

	private static PacketReader() { }

	public PacketReader(ArraySegment array) { }

	public PacketReader(byte[] array) { }

	private void Check(int count, string type) { }

	private byte FastReadByte() { }

	public ArraySegment get_All() { }

	public ArraySegment get_Read() { }

	public ArraySegment get_Unread() { }

	public byte ReadByte() { }

	public ArraySegment ReadByteSegment() { }

	public ClientInfo ReadClientInfo() { }

	public ClientInfo ReadClientStateHeader() { }

	public void ReadClientStateRooms(List rooms) { }

	public CodecSettings ReadCodecSettings() { }

	public void ReadDeltaChannelState(out bool joined, out ushort peer, out string name) { }

	public uint ReadErrorWrongSession() { }

	public void ReadhandshakeP2P(out ushort peerId) { }

	public void ReadHandshakeRequest(out string name, out CodecSettings codecSettings) { }

	public void ReadHandshakeResponseBody(List clients, Dictionary outputRoomsToPeerId) { }

	public void ReadHandshakeResponseHeader(out uint session, out ushort clientId) { }

	public bool ReadPacketHeader(out MessageTypes messageType) { }

	public void ReadRelay(List destinations, out ArraySegment data) { }

	public void ReadRemoveClient(out ushort clientId) { }

	[CanBeNull]
	public string ReadString() { }

	public TextPacket ReadTextPacket() { }

	public ushort ReadUInt16() { }

	public uint ReadUInt32() { }

	public void ReadVoicePacketChannel(out ChannelBitField bitfield, out ushort recipient) { }

	public void ReadVoicePacketHeader1(out ushort senderId) { }

	public void ReadVoicePacketHeader2(out VoicePacketOptions options, out ushort sequenceNumber, out ushort numChannels) { }

}

