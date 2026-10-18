namespace EFT.Network.Statistics;

public class NetworkValueStatistics
{
	public float value; //Field offset: 0x10
	public float averageValue; //Field offset: 0x14
	private NetworkAverageFloatStatistics _values; //Field offset: 0x18

	public NetworkValueStatistics() { }

	public void Set(float value) { }

}

