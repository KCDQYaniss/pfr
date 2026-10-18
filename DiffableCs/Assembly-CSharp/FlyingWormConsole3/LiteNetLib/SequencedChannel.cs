namespace FlyingWormConsole3.LiteNetLib;

internal sealed class SequencedChannel : BaseChannel
{
	private int _localSequence; //Field offset: 0x28
	private ushort _remoteSequence; //Field offset: 0x2C
	private readonly bool _reliable; //Field offset: 0x2E
	private NetPacket _lastPacket; //Field offset: 0x30
	private readonly NetPacket _ackPacket; //Field offset: 0x38
	private bool _mustSendAck; //Field offset: 0x40
	private readonly byte _id; //Field offset: 0x41
	private long _lastPacketSendTime; //Field offset: 0x48

	public SequencedChannel(NetPeer peer, bool reliable, byte id) { }

	public virtual bool ProcessPacket(NetPacket packet) { }

	protected virtual bool SendNextPackets() { }

}

