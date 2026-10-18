namespace Dissonance.Networking.Client;

internal class PeerVoiceReceiver
{
	private struct ChannelsMetadata
	{
		public readonly bool IsPositional; //Field offset: 0x0
		public readonly float AmplitudeMultiplier; //Field offset: 0x4
		public readonly ChannelPriority Priority; //Field offset: 0x8

		public ChannelsMetadata(bool isPositional, float amplitudeMultiplier, ChannelPriority priority) { }

		public ChannelsMetadata CombineWith(ChannelsMetadata other) { }

	}

	private static readonly Log Log; //Field offset: 0x0
	private readonly string _name; //Field offset: 0x10
	private readonly EventQueue _events; //Field offset: 0x18
	private readonly Rooms _localListeningRooms; //Field offset: 0x20
	private readonly ConcurrentPool _channelListPool; //Field offset: 0x28
	private readonly ushort _localId; //Field offset: 0x30
	private readonly string _localName; //Field offset: 0x38
	private DateTime _lastReceiptTime; //Field offset: 0x40
	private ushort _remoteSequenceNumber; //Field offset: 0x48
	private uint _localSequenceNumber; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <Open>k__BackingField; //Field offset: 0x50
	private bool _receivedInitialPacket; //Field offset: 0x51
	private ushort _currentChannelSession; //Field offset: 0x52
	private readonly Dictionary _expectedPerChannelSessions; //Field offset: 0x58
	private readonly List _tmpCompositeIdBuffer; //Field offset: 0x60

	public string Name
	{
		 get { } //Length: 5
	}

	public private bool Open
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static PeerVoiceReceiver() { }

	public PeerVoiceReceiver(string remoteName, ushort localId, string localName, EventQueue events, Rooms listeningRooms, ConcurrentPool channelListPool) { }

	public void CheckTimeout(DateTime utcNow, TimeSpan activeTimeout, TimeSpan inactiveTimeout) { }

	public string get_Name() { }

	[CompilerGenerated]
	public bool get_Open() { }

	private bool HasChannelSessionChanged(int compositeId, int expectedValue) { }

	private Nullable IsChannelToLocalPlayer(ChannelBitField channel, ushort recipient) { }

	private static bool IsPacketFromPreviousSession(ushort currentChannelSession, ushort packetChannelSession, bool isExtendedRange) { }

	private void ReadChannels(ref PacketReader reader, ushort numChannels, out bool allClosing, out bool forceReset, out ChannelsMetadata channelsMetadata, ICollection channelsOut) { }

	public void ReceivePacket(ref PacketReader reader, DateTime utcNow) { }

	private void RemoveChannelsExcept(List keys) { }

	[CompilerGenerated]
	private void set_Open(bool value) { }

	private void StartSpeaking(ushort startSequenceNumber, ushort channelSession, DateTime utcNow) { }

	public void StopSpeaking() { }

	private bool UpdateSequenceNumber(ushort sequenceNumber, DateTime utcNow) { }

	private bool UpdateSpeakerState(bool allClosing, bool forceReset, ushort channelSession, ushort sequenceNumber, DateTime utcNow) { }

}

