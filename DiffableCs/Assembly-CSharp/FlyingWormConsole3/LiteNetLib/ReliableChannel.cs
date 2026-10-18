namespace FlyingWormConsole3.LiteNetLib;

internal sealed class ReliableChannel : BaseChannel
{
	private struct PendingPacket
	{
		private NetPacket _packet; //Field offset: 0x0
		private long _timeStamp; //Field offset: 0x8
		private bool _isSent; //Field offset: 0x10

		public bool Clear(NetPeer peer) { }

		public void Init(NetPacket packet) { }

		public virtual string ToString() { }

		public void TrySend(long currentTime, NetPeer peer, out bool hasPacket) { }

	}

	private const int BitsInByte = 8; //Field offset: 0x0
	private readonly NetPacket _outgoingAcks; //Field offset: 0x28
	private readonly PendingPacket[] _pendingPackets; //Field offset: 0x30
	private readonly NetPacket[] _receivedPackets; //Field offset: 0x38
	private readonly bool[] _earlyReceived; //Field offset: 0x40
	private int _localSeqence; //Field offset: 0x48
	private int _remoteSequence; //Field offset: 0x4C
	private int _localWindowStart; //Field offset: 0x50
	private int _remoteWindowStart; //Field offset: 0x54
	private bool _mustSendAcks; //Field offset: 0x58
	private readonly DeliveryMethod _deliveryMethod; //Field offset: 0x59
	private readonly bool _ordered; //Field offset: 0x5A
	private readonly int _windowSize; //Field offset: 0x5C
	private readonly byte _id; //Field offset: 0x60

	public ReliableChannel(NetPeer peer, bool ordered, byte id) { }

	private void ProcessAck(NetPacket packet) { }

	public virtual bool ProcessPacket(NetPacket packet) { }

	protected virtual bool SendNextPackets() { }

}

