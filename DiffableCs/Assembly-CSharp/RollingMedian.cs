//Type is in global namespace

public class RollingMedian
{
	private int bufferSize; //Field offset: 0x10
	private int bufferCount; //Field offset: 0x14
	private int counter; //Field offset: 0x18
	private float[] buffer; //Field offset: 0x20
	private float[] sortedBuffer; //Field offset: 0x28
	private bool _dirty; //Field offset: 0x30
	private float cachedAvarage; //Field offset: 0x34

	public float Avarage
	{
		 get { } //Length: 123
	}

	public float Median
	{
		 get { } //Length: 548
	}

	public RollingMedian(int bufferSize) { }

	public void AddValue(float value) { }

	public float get_Avarage() { }

	public float get_Median() { }

}

