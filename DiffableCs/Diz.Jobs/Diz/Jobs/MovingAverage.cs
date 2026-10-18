namespace Diz.Jobs;

public class MovingAverage
{
	private readonly int _bufferSize; //Field offset: 0x10
	private readonly double _bufferSizeDouble; //Field offset: 0x18
	private int _counter; //Field offset: 0x20
	private readonly double[] _buffer; //Field offset: 0x28
	private double _average; //Field offset: 0x30

	public double Average
	{
		 get { } //Length: 6
	}

	public int BufferSize
	{
		 get { } //Length: 164
	}

	public MovingAverage(int bufferSize) { }

	public void AddValue(double value) { }

	public double get_Average() { }

	public int get_BufferSize() { }

	public void SetAll(double value) { }

}

