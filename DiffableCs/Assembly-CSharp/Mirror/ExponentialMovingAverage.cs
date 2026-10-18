namespace Mirror;

public struct ExponentialMovingAverage
{
	private float alpha; //Field offset: 0x0
	private bool initialized; //Field offset: 0x4
	public double Value; //Field offset: 0x8
	public double Variance; //Field offset: 0x10
	public double StandardDeviation; //Field offset: 0x18

	public ExponentialMovingAverage(int n) { }

	public void Add(double newValue) { }

	public void SetAlpha(int n) { }

}

