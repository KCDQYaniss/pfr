//Type is in global namespace

public class ExponentiallySmoothedMovingAverage
{
	public double Alpha; //Field offset: 0x10
	private double _average; //Field offset: 0x18

	public double Average
	{
		 get { } //Length: 6
	}

	public ExponentiallySmoothedMovingAverage() { }

	public void AddValue(double value) { }

	public double get_Average() { }

}

