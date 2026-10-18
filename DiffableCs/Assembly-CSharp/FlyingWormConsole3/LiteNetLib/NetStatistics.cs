namespace FlyingWormConsole3.LiteNetLib;

public sealed class NetStatistics
{
	private long _packetsSent; //Field offset: 0x10
	private long _packetsReceived; //Field offset: 0x18
	private long _bytesSent; //Field offset: 0x20
	private long _bytesReceived; //Field offset: 0x28
	private long _packetLoss; //Field offset: 0x30

	public long BytesReceived
	{
		 get { } //Length: 9
	}

	public long BytesSent
	{
		 get { } //Length: 9
	}

	public long PacketLoss
	{
		 get { } //Length: 9
	}

	public long PacketLossPercent
	{
		 get { } //Length: 35
	}

	public long PacketsReceived
	{
		 get { } //Length: 9
	}

	public long PacketsSent
	{
		 get { } //Length: 9
	}

	public NetStatistics() { }

	public void AddBytesReceived(long bytesReceived) { }

	public void AddBytesSent(long bytesSent) { }

	public void AddPacketLoss(long packetLoss) { }

	public long get_BytesReceived() { }

	public long get_BytesSent() { }

	public long get_PacketLoss() { }

	public long get_PacketLossPercent() { }

	public long get_PacketsReceived() { }

	public long get_PacketsSent() { }

	public void IncrementPacketLoss() { }

	public void IncrementPacketsReceived() { }

	public void IncrementPacketsSent() { }

	public void Reset() { }

	public virtual string ToString() { }

}

