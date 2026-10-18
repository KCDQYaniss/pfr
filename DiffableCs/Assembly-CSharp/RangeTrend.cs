//Type is in global namespace

public class RangeTrend
{
	private readonly double[] _values; //Field offset: 0x10
	private readonly int _valuesCount; //Field offset: 0x18
	private int _head; //Field offset: 0x1C
	private int _maxIndex; //Field offset: 0x20
	private int _minIndex; //Field offset: 0x24

	public double RangeDiff
	{
		 get { } //Length: 125
	}

	public RangeTrend(int count) { }

	public void AddValue(double val) { }

	private void FindMax() { }

	private void FindMin() { }

	public double get_RangeDiff() { }

}

