//Type is in global namespace

public class MovingMaximum
{
	private readonly int _bufferSize; //Field offset: 0x10
	private int _counter; //Field offset: 0x14
	private readonly double[] _buffer; //Field offset: 0x18
	private double _previousMax; //Field offset: 0x20
	private double _max; //Field offset: 0x28

	public int BufferSize
	{
		 get { } //Length: 164
	}

	public double Max
	{
		 get { } //Length: 6
	}

	public MovingMaximum(int bufferSize) { }

	public void AddValue(double value) { }

	public int get_BufferSize() { }

	public double get_Max() { }

}

