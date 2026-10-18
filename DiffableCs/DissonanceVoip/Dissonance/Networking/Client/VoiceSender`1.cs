namespace Dissonance.Networking.Client;

internal class VoiceSender`1
{
	private struct ChannelDelta
	{
		public readonly bool Open; //Field offset: 0x0
		public readonly ChannelType Type; //Field offset: 0x0
		public readonly ChannelProperties Properties; //Field offset: 0x0
		public readonly ushort RecipientId; //Field offset: 0x0
		public readonly string RecipientName; //Field offset: 0x0

		public ChannelDelta(bool open, ChannelType type, ChannelProperties properties, ushort recipientId, string recipientName) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly ISendQueue _sender; //Field offset: 0x0
	private readonly ISession _session; //Field offset: 0x0
	private readonly IClientCollection _peers; //Field offset: 0x0
	private readonly EventQueue _events; //Field offset: 0x0
	private readonly PlayerChannels _playerChannels; //Field offset: 0x0
	private readonly RoomChannels _roomChannels; //Field offset: 0x0
	private byte _channelSessionId; //Field offset: 0x0
	private readonly ReadonlyLockedValue _openChannels; //Field offset: 0x0
	private readonly ReadonlyLockedValue _deltas; //Field offset: 0x0
	private readonly List _pendingPlayerChannels; //Field offset: 0x0
	private ushort _sequenceNumber; //Field offset: 0x0
	private readonly HashSet _tmpDestsSet; //Field offset: 0x0
	private readonly List _tmpDestsList; //Field offset: 0x0
	private bool _hadId; //Field offset: 0x0
	private int _noIdSendCount; //Field offset: 0x0

	private static VoiceSender`1() { }

	public VoiceSender`1(ISendQueue sender, ISession session, IClientCollection peers, EventQueue events, PlayerChannels playerChannels, RoomChannels roomChannels) { }

	private void ApplyChannelDelta(ChannelDelta d, Unlocker openChannels) { }

	private void ApplyChannelDeltas(Unlocker openChannels) { }

	private static bool AreAllChannelsClosing(Unlocker openChannels) { }

	private void ClearClosedChannels() { }

	private void CloseChannel(ChannelType type, ChannelProperties properties, ushort id) { }

	private void ClosePlayerChannel(string player, ChannelProperties config) { }

	private void CloseRoomChannel(string room, ChannelProperties config) { }

	[NotNull]
	private List GetVoiceDestinations(IList openChannels) { }

	private void OnPlayerJoined(string name, CodecSettings codecSettings) { }

	private void OnPlayerLeft(string name) { }

	private void OpenChannel(ChannelType type, ChannelProperties config, ushort recipient, string name) { }

	private void OpenPlayerChannel(string player, ChannelProperties config) { }

	private void OpenRoomChannel(string room, ChannelProperties config) { }

	public void Send(ArraySegment encodedAudio) { }

	public void Stop() { }

}

