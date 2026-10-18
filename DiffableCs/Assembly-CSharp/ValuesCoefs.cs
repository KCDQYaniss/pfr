//Type is in global namespace

public class ValuesCoefs
{
	[Range(0.01, 10)]
	public float MainTexColorCoef; //Field offset: 0x10
	[Range(-10, 10)]
	public float MinimumTemperatureValue; //Field offset: 0x14
	[Range(-1, 1)]
	public float RampShift; //Field offset: 0x18

	public ValuesCoefs() { }

}

