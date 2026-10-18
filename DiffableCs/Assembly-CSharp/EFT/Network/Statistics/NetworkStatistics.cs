namespace EFT.Network.Statistics;

public class NetworkStatistics
{
	public readonly NetworkLoseStatistics lose; //Field offset: 0x10
	public readonly NetworkValueStatistics rtt; //Field offset: 0x18
	public readonly NetworkCountStatistics disordered; //Field offset: 0x20
	public readonly NetworkCountStatistics duplicated; //Field offset: 0x28
	public readonly NetworkMessageStatistics received; //Field offset: 0x30
	public readonly NetworkMessageStatistics sent; //Field offset: 0x38
	public readonly NetworkMessageStatistics reliableReceived; //Field offset: 0x40
	public readonly NetworkMessageStatistics reliableSent; //Field offset: 0x48
	public readonly NetworkMessageStatistics reliableSegmentalReceived; //Field offset: 0x50
	public readonly NetworkMessageStatistics reliableSegmentalSent; //Field offset: 0x58
	public readonly NetworkMessageStatistics unreliableReceived; //Field offset: 0x60
	public readonly NetworkMessageStatistics unreliableSent; //Field offset: 0x68
	public readonly NetworkValueStatistics receivedQueue; //Field offset: 0x70
	public readonly NetworkValueStatistics sentQueue; //Field offset: 0x78

	public NetworkStatistics() { }

	public void Commit() { }

}

