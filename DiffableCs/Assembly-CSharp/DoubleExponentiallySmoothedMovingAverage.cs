//Type is in global namespace

public class DoubleExponentiallySmoothedMovingAverage
{
	public double Alpha; //Field offset: 0x10
	public double Beta; //Field offset: 0x18
	private double _average; //Field offset: 0x20
	private double _b; //Field offset: 0x28

	public double Average
	{
		 get { } //Length: 6
	}

	public DoubleExponentiallySmoothedMovingAverage() { }

	public void AddValue(double value) { }

	public double get_Average() { }

}

