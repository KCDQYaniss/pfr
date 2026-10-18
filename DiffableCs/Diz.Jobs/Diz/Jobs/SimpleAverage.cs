namespace Diz.Jobs;

public class SimpleAverage
{
	private double _sum; //Field offset: 0x10
	private int _count; //Field offset: 0x18

	public double Average
	{
		 get { } //Length: 29
	}

	public double Count
	{
		 get { } //Length: 10
	}

	public double Sum
	{
		 get { } //Length: 6
	}

	public SimpleAverage() { }

	public void AddValue(double value) { }

	public double get_Average() { }

	public double get_Count() { }

	public double get_Sum() { }

}

