namespace Dissonance.Networking;

internal struct PacketWriter
{
	private static readonly Log Log; //Field offset: 0x0
	internal const ushort Magic = 35783; //Field offset: 0x0
	private readonly ArraySegment _array; //Field offset: 0x0
	private int _count; //Field offset: 0x10

	public ArraySegment Written
	{
		 get { } //Length: 226
	}

	private static PacketWriter() { }

	public PacketWriter(byte[] array) { }

	public PacketWriter(ArraySegment array) { }

	private void Check(int count, string type) { }

	public PacketWriter FastWriteByte(byte b) { }

	public ArraySegment get_Written() { }

	public PacketWriter Write(ushort u) { }

	public PacketWriter Write(uint u) { }

	public PacketWriter Write(string s) { }

	public PacketWriter Write(ArraySegment data) { }

	public PacketWriter Write(CodecSettings codecSettings) { }

	public PacketWriter Write(string playerName, ushort playerId, CodecSettings codecSettings) { }

	public PacketWriter Write(byte b) { }

	public PacketWriter WriteClientState(uint session, string name, ushort clientId, CodecSettings codecSettings, ReadOnlyCollection rooms) { }

	public PacketWriter WriteClientState(uint session, string name, ushort clientId, CodecSettings codecSettings, Rooms rooms) { }

	public PacketWriter WriteDeltaChannelState(uint session, bool joined, ushort peer, string name) { }

	public PacketWriter WriteErrorWrongSession(uint session) { }

	public PacketWriter WriteHandshakeP2P(uint session, ushort peerId) { }

	public PacketWriter WriteHandshakeRequest(string name, CodecSettings codecSettings) { }

	public PacketWriter WriteHandshakeResponse(uint session, ushort clientId, List clients, Dictionary peersByRoom) { }

	internal PacketWriter WriteMagic() { }

	public PacketWriter WriteRelay(uint session, List destinations, ArraySegment segment, bool reliable) { }

	public PacketWriter WriteRemoveClient(uint session, ushort clientId) { }

	internal PacketWriter WriteTextPacket(uint session, ushort senderId, ChannelType recipient, ushort target, string data) { }

	internal PacketWriter WriteVoiceData(uint session, ushort senderId, ushort sequenceNumber, byte channelSession, IList channels, ArraySegment encodedAudio) { }

}

