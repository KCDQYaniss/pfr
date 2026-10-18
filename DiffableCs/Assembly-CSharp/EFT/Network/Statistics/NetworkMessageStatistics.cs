namespace EFT.Network.Statistics;

public class NetworkMessageStatistics
{
	public NetworkCountStatistics messages; //Field offset: 0x10
	public NetworkCountStatistics bytes; //Field offset: 0x18

	public NetworkMessageStatistics() { }

	public void Commit() { }

	public void Increment(int value) { }

}

