namespace EFT.Network.Statistics;

public class NetworkAverageIntStatistics
{
	private readonly int _length; //Field offset: 0x10
	private readonly int[] _values; //Field offset: 0x18
	private int _index; //Field offset: 0x20
	private int _sum; //Field offset: 0x24

	public NetworkAverageIntStatistics(int length) { }

	public float Update(int nextInput) { }

}

