namespace FlyingWormConsole3.LiteNetLib;

internal abstract class BaseChannel
{
	protected readonly NetPeer Peer; //Field offset: 0x10
	protected readonly Queue OutgoingQueue; //Field offset: 0x18
	private int _isAddedToPeerChannelSendQueue; //Field offset: 0x20

	public int PacketsInQueue
	{
		 get { } //Length: 65
	}

	protected BaseChannel(NetPeer peer) { }

	protected void AddToPeerChannelSendQueue() { }

	public void AddToQueue(NetPacket packet) { }

	public int get_PacketsInQueue() { }

	public abstract bool ProcessPacket(NetPacket packet) { }

	public bool SendAndCheckQueue() { }

	protected abstract bool SendNextPackets() { }

}

