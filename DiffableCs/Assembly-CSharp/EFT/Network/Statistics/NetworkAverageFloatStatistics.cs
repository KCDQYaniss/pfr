namespace EFT.Network.Statistics;

public class NetworkAverageFloatStatistics
{
	private readonly int _length; //Field offset: 0x10
	private readonly float[] _values; //Field offset: 0x18
	private int _index; //Field offset: 0x20
	private float _sum; //Field offset: 0x24

	public NetworkAverageFloatStatistics(int length) { }

	public float Update(float nextInput) { }

}

