namespace Coffee.UISoftMaskInternal;

public struct MinMax01
{
	[SerializeField]
	private float m_Min; //Field offset: 0x0
	[SerializeField]
	private float m_Max; //Field offset: 0x4

	public float average
	{
		 get { } //Length: 18
	}

	public float max
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public float min
	{
		 get { } //Length: 5
		 set { } //Length: 39
	}

	public MinMax01(float min, float max) { }

	public bool Approximately(MinMax01 other) { }

	public float get_average() { }

	public float get_max() { }

	public float get_min() { }

	public void set_max(float value) { }

	public void set_min(float value) { }

}

