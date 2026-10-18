//Type is in global namespace

public class FloatExponentialMovingAverageCalculator
{
	private readonly float _alpha; //Field offset: 0x10
	private float _lastAverage; //Field offset: 0x14

	public float Value
	{
		 get { } //Length: 6
	}

	public FloatExponentialMovingAverageCalculator(int lookBack) { }

	public float get_Value() { }

	public float NextValue(float value) { }

}

