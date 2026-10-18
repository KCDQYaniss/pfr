namespace EFT.Network.Statistics;

public class NetworkLoseStatistics
{
	public int totalCount; //Field offset: 0x10
	public int loseCount; //Field offset: 0x14
	public int lastLoseCountValue; //Field offset: 0x18
	public float averageLoseCountValue; //Field offset: 0x1C
	public float lastLosePercentValue; //Field offset: 0x20
	public float averageLosePercentValue; //Field offset: 0x24
	private NetworkAverageIntStatistics _loseCountValues; //Field offset: 0x28
	private NetworkAverageFloatStatistics _losePercentValues; //Field offset: 0x30

	public NetworkLoseStatistics() { }

	public void Commit() { }

	public void Increment(int total, int lose) { }

}

