namespace EFT.Network.Statistics;

public class NetworkCountStatistics
{
	public int totalValue; //Field offset: 0x10
	public int currentValue; //Field offset: 0x14
	public int lastValue; //Field offset: 0x18
	public float averageValue; //Field offset: 0x1C
	private NetworkAverageIntStatistics _values; //Field offset: 0x20

	public NetworkCountStatistics() { }

	public void Commit() { }

	public void Increment() { }

	public void Increment(int value) { }

}

