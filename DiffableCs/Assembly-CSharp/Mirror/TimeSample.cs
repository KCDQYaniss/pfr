namespace Mirror;

public struct TimeSample
{
	private readonly Stopwatch watch; //Field offset: 0x0
	private double beginTime; //Field offset: 0x8
	private ExponentialMovingAverage ema; //Field offset: 0x10
	public double average; //Field offset: 0x30

	public TimeSample(int n) { }

	public void Begin() { }

	public void End() { }

}

